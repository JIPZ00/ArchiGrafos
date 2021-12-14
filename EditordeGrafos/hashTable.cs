using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class hashTable : Form
    {
        public cHashTable Tabla;
        public int EOF;
        public int tamañoCubeta;
        public List<Decimal> Registros;
        public List<Cubeta> Cubetas;
        public string NomArch;
        public FileStream Arch;
        public hashTable()
        {
            InitializeComponent();
            Registros = new List<Decimal>();
            Cubetas = new List<Cubeta>();
        }

        public void CreaTablaHash(cHashTable nTabla)
        {
            //nTabla.NumRanuras = 8;
            nTabla.NumRanuras = Decimal.ToInt32(entradaRanuras.Value);
            //nTabla.NumDatos = 4;
            nTabla.NumDatos = Decimal.ToInt32(entradaRegistros.Value);
            //nTabla.TamReg = 50;
            nTabla.TamReg = Decimal.ToInt32(entradaTamReg.Value);
            //nTabla.EOF = 48;
            nTabla.EOF = Decimal.ToInt32(entradaEOF.Value);
        }

        public void lecturaArch(string NomArch)
        {
            foreach (string line in System.IO.File.ReadLines(@"c:\test.txt"))
            {
                DataGridView1.Rows.Add(line);
            }
        }
        private void EscribeFile()
        {
            Arch = new FileStream(NomArch, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Arch);
            sw.Write(Tabla.NumRanuras.ToString() + ",");
            sw.Write(Tabla.NumDatos + ",");
            sw.Write(Tabla.TamReg + ",");
            sw.Write(Tabla.CubetasEmpty.ToString() + ",");
            sw.Write(EOF.ToString() + ";\n");
            for (int i = 0; i < Tabla.NumRanuras; i++)
            {
                sw.Write(i.ToString() + ",");
                if (Tabla.Ranuras[i] != null){sw.Write(Tabla.Ranuras[i].Dir.ToString() + ";\n");}
                else{ sw.Write("0;\n");}
            }
            if (Cubetas.Count > 0)
            {
                foreach (Cubeta c in Cubetas)
                {
                    sw.Write(c.Dir.ToString() + "," + c.Cuenta.ToString() + ",");
                    if (c.Sig != null) { sw.Write(c.Sig.Dir.ToString() + ";\n");}
                    else{ sw.Write("0;\n");}
                    foreach (int clave in c.Claves){sw.Write(clave.ToString() + ";\n");}
                }
            }
            sw.Flush();
            Arch.Close();

            //Lectura de datos
            DataGridView1.Rows.Clear();
            Arch = new FileStream(NomArch, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(Arch);
            //foreach (string line in System.IO.File.ReadLines(@"C:\Users\jesus\Desktop\Editor de Grafos 2021\EditordeGrafos\bin\Debug\Archivos Hash\" + NomArch))
            foreach (string line in System.IO.File.ReadLines(Arch.Name))
            {
                DataGridView1.Rows.Add(line);
            }
            Arch.Close();
        }
        private void OpenAsignaDatos()
        {
            int v;
            for (int i = 0; i < Tabla.NumRanuras; i++)
            {
                v = Tabla.DirRanuras[i];
                if (Tabla.DirRanuras[i] != 0)
                {
                    foreach (Cubeta c in Cubetas)
                    {
                        if (c.Dir == v)
                        {
                            Tabla.Ranuras[i] = c;
                            break;
                        }
                    }
                }
            }
            foreach (Cubeta c in Cubetas)
            {
                if (c.DirSig != 0)
                {
                    foreach (Cubeta s in Cubetas)
                    {
                        if (c.DirSig == s.Dir)
                        {
                            c.Sig = s;
                            break;
                        }
                    }
                }
                if (c.Cuenta == 0)
                {
                    Tabla.Vacias.Add(c);
                }
            }
        }
        private void EncadenaCubetasVacias(Cubeta vacio, int clave)
        {
            int slot = clave % Tabla.NumRanuras;
            if (Tabla.Ranuras[slot] == vacio)
            {
                Tabla.Ranuras[slot] = vacio.Sig;
                Tabla.DirRanuras[slot] = vacio.DirSig;
            }
            else
            {
                Cubeta previa = ObtenCubetaAnterior(vacio);
                previa.Sig = vacio.Sig;
                previa.DirSig = vacio.DirSig;
            }
            if (Tabla.CubetasEmpty == 0){Tabla.CubetasEmpty = vacio.Dir;}
            else
            {
                vacio.DirSig = Tabla.CubetasEmpty;
                vacio.Sig = (Cubeta)Tabla.Vacias.Where(c => c.Dir == vacio.DirSig).FirstOrDefault();
                Tabla.CubetasEmpty = vacio.Dir;
            }
            Tabla.Vacias.Add(vacio);
        }
        private Cubeta ObtenCubetaAnterior(Cubeta vacio)
        {
            Cubeta previous = null;
            previous = Cubetas.Where(c => c.DirSig == vacio.Dir).FirstOrDefault();
            return previous;
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de texto|*.txt";
            saveDialog.InitialDirectory = Application.StartupPath;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                NomArch = saveDialog.FileName;
                Arch = new FileStream(NomArch, FileMode.Create, FileAccess.Write);
                Tabla = new cHashTable();
                Cubetas = new List<Cubeta>();
                Registros = new List<decimal>();
                CreaTablaHash(Tabla);

                EOF = Tabla.EOF;
                if (Tabla.EOF == 0)
                {
                    EOF += 16;
                    EOF += (4 * Tabla.NumRanuras);
                }
                tamañoCubeta = Tabla.TamReg * Tabla.NumDatos + 12;
                Tabla.creaRanuras();

                /*EOF = Tabla.EOF;
                EOF += 16;
                Tabla.creaRanuras();
                EOF += (4 * Tabla.NumRanuras);
                tamañoCubeta = Tabla.TamReg * Tabla.NumDatos + 8;*/
                btnAdd.Enabled = true;
                claveUD.Enabled = true;
                Arch.Close();
                EscribeFile();
                entradaEOF.Enabled = false;
                entradaRanuras.Enabled = false;
                entradaRegistros.Enabled = false;
                entradaTamReg.Enabled = false;


            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Archivos de texto|*.txt";
            openDialog.InitialDirectory = Application.StartupPath;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                NomArch = openDialog.FileName;
                Arch = new FileStream(NomArch, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(Arch);
                string linea;
                string[] aux;
                linea = sr.ReadLine();
                if (linea != null)
                {
                    int indaux = 0;
                    Cubeta TCub;
                    while (linea != null)
                    {
                        linea = linea.Trim();
                        aux = linea.Split(',');
                        switch (aux.Length)
                        {
                            case 5:
                                Tabla = new cHashTable();
                                int.TryParse(aux[0], out Tabla.NumRanuras);
                                int.TryParse(aux[1], out Tabla.NumDatos);
                                int.TryParse(aux[2], out Tabla.TamReg);
                                int.TryParse(aux[3], out Tabla.CubetasEmpty);
                                aux[4] = aux[4].Trim(';');
                                int.TryParse(aux[4], out Tabla.EOF);
                                EOF = Tabla.EOF;
                                Tabla.creaRanuras();
                                for (int i = 0; i < Tabla.NumRanuras; i++)
                                {
                                    linea = sr.ReadLine();
                                    aux = linea.Split(',');
                                    int.TryParse(aux[0], out indaux);
                                    aux[1] = aux[1].Trim(';');
                                    int.TryParse(aux[1], out Tabla.DirRanuras[indaux]);
                                }
                                break;
                            case 3:
                                TCub = new Cubeta(Tabla.NumDatos);
                                int.TryParse(aux[0], out TCub.Dir);
                                int.TryParse(aux[1], out TCub.Cuenta);
                                aux[2] = aux[2].Trim(';');
                                int.TryParse(aux[2], out TCub.DirSig);
                                for (int i = 0; i < TCub.Cuenta; i++)
                                {
                                    linea = sr.ReadLine();
                                    linea = linea.Trim(';');
                                    int.TryParse(linea, out indaux);
                                    TCub.Claves.Add(indaux);
                                    TCub.Claves.Sort();
                                    Registros.Add(indaux);
                                }
                                Cubetas.Add(TCub);
                                if (TCub.Cuenta == 0){Tabla.Vacias.Add(TCub);}
                                break;
                        }
                        linea = sr.ReadLine();
                    }
                    tamañoCubeta = Tabla.TamReg * Tabla.NumDatos + 8;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    claveUD.Enabled = true;
                    OpenAsignaDatos();
                }
                //Lectura de datos
                DataGridView1.Rows.Clear();
                //foreach (string line in System.IO.File.ReadLines(@"C:\Users\jesus\Desktop\Editor de Grafos 2021\EditordeGrafos\bin\Debug\Archivos Hash\" + NomArch))
                foreach (string line in System.IO.File.ReadLines(Arch.Name))
                {
                    DataGridView1.Rows.Add(line);
                }
                Arch.Close();
                entradaEOF.Enabled = false;
                entradaRanuras.Enabled = false;
                entradaRegistros.Enabled = false;
                entradaTamReg.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (claveUD.Value > 0)
            {
                if (!Registros.Contains(claveUD.Value))
                {
                    Registros.Add(claveUD.Value);
                    Cubeta returnal;
                    returnal = Tabla.insertaEnCubeta(EOF, Decimal.ToInt32(claveUD.Value), tamañoCubeta);
                    if (returnal != null && !Cubetas.Contains(returnal))
                    {
                        Cubetas.Add(returnal);
                        EOF += tamañoCubeta;
                    }
                    EscribeFile();
                    btnDelete.Enabled = true;
                }
                else{MessageBox.Show("Dato existente", "WARNING");}
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (claveUD.Value > 0)
            {
                if (Registros.Contains(claveUD.Value))
                {
                    int eliminado;
                    eliminado = Decimal.ToInt32(claveUD.Value);
                    Registros.Remove(claveUD.Value);
                    Cubeta returnal;
                    returnal = Tabla.eliminaEnCubeta(eliminado);
                    if (returnal != null){EncadenaCubetasVacias(returnal, eliminado);}
                    EscribeFile();
                    if (Registros.Count == 0){btnDelete.Enabled = false;}
                }
                else{MessageBox.Show("Dato inexistente", "WARNING");}
            }
        }
    }
}
