using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditordeGrafos
{
    public class Cubeta
    {
        public int Dir;
        public int Cuenta;
        public List<int> Claves;
        public int Tam;
        public Cubeta Sig;
        public int DirSig;

        public Cubeta(int n)
        {
            Tam = n;
            Claves = new List<int>();
            Sig = null;
            DirSig = 0;
        }
        public Cubeta Inserta(int clave, int EOF, int tamReg, List<Cubeta> vacias)
        {
            if (Cuenta == Tam)
            {
                if (Sig == null)
                {
                    Cubeta returnal;
                    Claves.Add(clave);
                    Claves.Sort();
                    if (vacias.Count != 0)
                    {
                        Sig = vacias.First();
                        DirSig = Sig.Dir;
                    }
                    else
                    {
                        Sig = new Cubeta(Tam);
                        Sig.Dir = EOF;
                        DirSig = EOF;
                    }
                    Sig.Inserta(Claves.Last(), EOF, tamReg, vacias);
                    Claves.Remove(Claves.Last());
                    returnal = Sig;
                    return returnal;
                }
                else{return Sig.Inserta(clave, EOF, tamReg, vacias);}
            }
            else
            {
                Claves.Add(clave);
                Claves.Sort();
                Cuenta = Claves.Count();
            }
            return null;
        }
        public Cubeta Elimina(int clave)
        {
            if (Claves.Contains(clave))
            {
                Claves.Remove(clave);
                Cuenta = Claves.Count();
                if (Cuenta == 0){return this;}
            }
            else{if (Sig != null){return Sig.Elimina(clave);}}
            return null;
        }
    }
}
