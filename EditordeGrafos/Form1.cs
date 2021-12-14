using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace EditordeGrafos
{
    public partial class Form1 : Form
    {
        public int degree = 5;
        public List<DatoArbol> ListDatos;
        public List<DatoHoja> ListHojas;
        public List<DatoIntermedio> ListHIntermedias;
        public List<DatoRaiz> ListHRaiz;
        public List<long> Datos;
        public string Archivo; 
        public string extension; 
        public FileStream Arch;
        public int tamaño;
        public DatoHoja DatoRaiz;
        public bool bandera = false;

        public Form1()
        {
            InitializeComponent();
            ListHojas = new List<DatoHoja>();
            ListDatos = new List<DatoArbol>();
            Datos = new List<long>();
            tamaño = 1000;
        }
        private void CloseF(object sender, EventArgs e)
        {
            ListHojas = new List<DatoHoja>();
            ListDatos = new List<DatoArbol>();
            Datos = new List<long>();
            DatoRaiz = null;
            tamaño = 1000;
            InsertaDatos();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e){NewF(sender, e);}
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e){AbreArchivo(sender, e);}
        private void AddBoton_Click(object sender, EventArgs e){AgregaDato(sender, e);}
        private void NewF(object sender, EventArgs e)
        {
            CloseF(null, null);
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo = saveDialog.FileName;
                extension = Path.GetExtension(saveDialog.FileName);
                Arch = new FileStream(Archivo, FileMode.Create, FileAccess.Write);
                NewPage('H');
                DatoRaiz = ListHojas.First();
                InsertaDatos();
                Arch.Close();
            }
        }
        private void AbreArchivo(object sender, EventArgs e)
        {
            CloseF(null, null);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = Application.StartupPath;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                bandera = true;
                Archivo = openDialog.FileName;
                extension = Path.GetExtension(openDialog.FileName);
                Arch = new FileStream(Archivo, FileMode.Open, FileAccess.Read);
                NewPage('H');
                DatoRaiz = ListHojas.First();
                StreamReader sr;
                sr = new StreamReader(Arch);
                string texto = sr.ReadToEnd();
                texto.Trim(' ');
                string[] content = texto.Split(',');
                int aux = 0;
                foreach (string c in content){if (int.TryParse(c, out aux)){AgregaDato(aux);}}
                Arch.Close();
                bandera = false;
            }
        }
        private DatoHoja NewPage(char t)
        {
            DatoHoja nHoja = new DatoHoja(degree);
            nHoja.Dir = tamaño;
            nHoja.Tipo = t;
            tamaño += 70;
            ListHojas.Add(nHoja);
            return nHoja;
        }
        private DatoArbol guardaDato(int numero)
        {
            DatoArbol r = new DatoArbol(numero);
            r.Dir = tamaño;
            tamaño += 25;
            if (ListDatos.Count > 0){ListDatos.Last().Sig_Dir = r.Dir;}
            ListDatos.Add(r);
            Datos.Add(r.Numero);
            if (!bandera)
            {
                StreamWriter sw;
                Arch = new FileStream(Archivo, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(Arch);
                sw.Write(r.Numero.ToString() + ", ");
                sw.Flush();
                Arch.Close();
            }
            return r;
        }
        private void AgregaDato(object sender, EventArgs e)
        {
            int numero = -1;
            if (TextBox.TextLength > 0)
            {
                if (int.TryParse(TextBox.Text, out numero)){ AgregaDato(numero);}
                else { MessageBox.Show("Ya existe este dato");}
            }
            else{MessageBox.Show("Inserte un dato");}
        }
        private void DividePagina(DatoHoja Dato)
        {
            DatoHoja parienteM = NewPage(Dato.Tipo);
            int cont = 0;
            foreach (var R in Dato.datos)
            {
                if (Dato.Tipo == 'H' || Dato.Tipo == 'R')
                {
                    if (cont >= 2)
                    {
                        parienteM.datos.Add(R);
                        parienteM.ptrs.Add(Dato.ptrs[cont]);
                        if (Dato.Tipo == 'R' && Dato.datos.Last() == R){parienteM.ptrs.Add(Dato.ptrs[cont] + 1);}
                    }
                }
                else
                {
                    if (cont >= 3)
                    {
                        parienteM.datos.Add(R);
                        parienteM.ptrs.Add(Dato.ptrs[cont]);
                    }
                }
                cont++;
            }
            foreach (var R in parienteM.datos){if (Dato.datos.Contains(R)){Dato.datos.Remove(R);}}
            foreach (var P in parienteM.ptrs){if (Dato.ptrs.Contains(P)){Dato.ptrs.Remove(P);}}
            if (Dato.Tipo != 'R')
            {
                DatoHoja padre = getPadre(Dato.Dir);
                InsertaNodo(padre, parienteM);
            }
            else{SepararPagina(parienteM);}
        }
        private void InsertaNodo(DatoHoja nPa, DatoHoja nMy)
        {
            nPa.datos.Add(nMy.datos.First());
            nPa.datos.Sort();
            nPa.ptrs.Insert(nPa.datos.IndexOf(nMy.datos.First()) + 1, nMy.Dir);
            if (nMy.Tipo != 'H'){nMy.datos.Remove(nMy.datos.First());}
            if (nPa.datos.Count > degree - 1)
            {
                if (nPa.Tipo != 'R'){DividePagina(nPa);}
                else{SepararPagina(nMy);}
            }
        }
        private DatoHoja getPadre(long dirHijo)
        {
            DatoHoja padre = null;
            foreach (var a in ListHojas)
            {
                if (a.ptrs.Contains(dirHijo))
                {
                    padre = a;
                    break;
                }
            }
            return padre;
        }
        private void AgregaDato(int numero)
        {
            if (!Datos.Contains(numero))
            {
                DatoArbol r = guardaDato(numero);
                if (DatoRaiz.Tipo == 'H')
                {
                    DatoRaiz.datos.Add(numero);
                    DatoRaiz.datos.Sort();
                    DatoRaiz.ptrs.Insert(DatoRaiz.datos.IndexOf(numero), r.Dir);
                    if (DatoRaiz.datos.Count > degree - 1){Rseparar();}
                }
                else
                {
                    DatoHoja hoja = sHoja(numero, DatoRaiz);
                    hoja.datos.Add(numero);
                    hoja.datos.Sort();
                    hoja.ptrs.Insert(hoja.datos.IndexOf(numero), r.Dir);
                    if (hoja.datos.Count > degree - 1){DividePagina(hoja);}
                }
                InsertaDatos();
            }
            else{MessageBox.Show("Ya existe el dato");}
        }
        public DatoHoja sHoja(int num, DatoHoja actual)
        {
            DatoHoja found = null;
            if (actual.Tipo == 'H'){ return actual;}
            else
            {
                foreach (var r in actual.datos)
                {
                    if (num < r){found = sHoja(num, getRIH(actual.ptrs[actual.datos.IndexOf(r)]));break;}
                    else{if (actual.datos.Last() == r){found = sHoja(num, getRIH(actual.ptrs[actual.datos.IndexOf(r) + 1]));break;}}
                }
            }
            return found;
        }
        public DatoHoja getRIH(long dir)
        {
            DatoHoja look = null;
            foreach (var a in ListHojas){if (a.Dir == dir){look = a;break;}}
            return look;
        }
        public void Rseparar()
        {
            DatoHoja parienteM = NewPage('H');
            DatoHoja RaizPrincipal = NewPage('R');
            int cont = 0;
            foreach (var R in DatoRaiz.datos)
            {
                if (cont >= 2)
                {
                    parienteM.datos.Add(R);
                    parienteM.ptrs.Add(DatoRaiz.ptrs[cont]);
                }
                cont++;
            }
            foreach (var R in parienteM.datos)
            {if (DatoRaiz.datos.Contains(R)){DatoRaiz.datos.Remove(R);}}
            foreach (var P in parienteM.ptrs)
            {if(DatoRaiz.ptrs.Contains(P)){DatoRaiz.ptrs.Remove(P);}}
            RaizPrincipal.datos.Add(getLeftH(parienteM));
            RaizPrincipal.ptrs.Add(DatoRaiz.Dir);
            RaizPrincipal.ptrs.Add(parienteM.Dir);
            DatoRaiz = RaizPrincipal;
        }
        public void SepararPagina(DatoHoja parienteM)
        {
            if (DatoRaiz.datos.Count > degree - 1)
            {
                parienteM = NewPage('I');
                int cont = 0;
                foreach (var R in DatoRaiz.datos)
                {
                    if (cont >= 2)
                    {
                        parienteM.datos.Add(R);
                        parienteM.ptrs.Add(DatoRaiz.ptrs[cont + 1]);
                    }
                    cont++;
                }
                foreach (var R in parienteM.datos){if (DatoRaiz.datos.Contains(R)){DatoRaiz.datos.Remove(R);}}
                foreach (var P in parienteM.ptrs){if (DatoRaiz.ptrs.Contains(P)){DatoRaiz.ptrs.Remove(P);}}
            }
            parienteM.Tipo = 'I';
            DatoHoja RaizPrincipal = NewPage('R');
            RaizPrincipal.ptrs.Add(DatoRaiz.Dir);
            InsertaNodo(RaizPrincipal, parienteM);
            DatoRaiz.Tipo = 'I';
            DatoRaiz = RaizPrincipal;
        }
        public long  getLeftH(DatoHoja Hoja)
        {
            long menor;
            menor = Hoja.datos.First();
            return menor;
        }
        private void InsertaDatos()
        {
            DataGridView1.Rows.Clear();
            int contador = 0;
            foreach (var data in ListHojas)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = data.Dir });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = data.Tipo });
                foreach (var l in data.ptrs)
                {
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = l });
                    if (data.ptrs.IndexOf(l) < data.datos.Count){fila.Cells.Add(new DataGridViewTextBoxCell { Value = data.datos[data.ptrs.IndexOf(l)] });}
                    contador++;
                }
                if (contador <= degree - 1)
                {
                    if (data.Tipo == 'H')
                    {
                        for (; contador < degree - 1; contador++)
                        {
                            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "-1" });
                            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                        }
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = "-1" });
                    }
                    else
                    {
                        for (; contador < degree; contador++)
                        {
                            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                            fila.Cells.Add(new DataGridViewTextBoxCell { Value = "-1" });
                        }
                    }
                }
                DataGridView1.Rows.Add(fila);
                contador = 0;
            }
            foreach (var data in ListDatos){DataGridView1.Rows.Add(data.Dir, data.Tipo, data.Sig_Dir, data.Numero);}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            EliminaDato(sender, e);
        }

        private void EliminaDato(object sender, EventArgs e)
        {
            int numero = -1;
            if (boxElimina.TextLength > 0)
            {
                if (int.TryParse(boxElimina.Text, out numero)) { EliminaDato(numero); }
                else { MessageBox.Show("No se puede eliminar dato"); }
            }
            else { MessageBox.Show("Inserte un dato a eliminar"); }
        }
        private void EliminaDato(int numero)
        {
            if (!Datos.Contains(numero))
            {
                MessageBox.Show("Dato no existe");
            }
            else{
                MessageBox.Show("Dato eliminado");
            }
        }

        //---------------------

        //---------------------
    }
}
