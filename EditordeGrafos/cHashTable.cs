using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditordeGrafos
{
    public class cHashTable
    {
        public int NumRanuras; 
        public int NumDatos; 
        public int TamReg;
        public int CubetasEmpty;
        public int EOF;
        public Cubeta[] Ranuras;
        public int[] DirRanuras;
        public List<Cubeta> Vacias;

        public cHashTable()
        {
            Vacias = new List<Cubeta>();
        }
        public void creaRanuras()
        {
            Ranuras = new Cubeta[NumRanuras];
            DirRanuras = new int[NumRanuras];
            for (int i = 0; i < NumRanuras; i++)
            {
                Ranuras[i] = null;
                DirRanuras[i] = 0;
            }
        }

        public Cubeta insertaEnCubeta(int dir, int clave, int tamCub)
        {
            Cubeta returnal = null;
            int slot = clave % NumRanuras;

            if (Ranuras[slot] != null){returnal = Ranuras[slot].Inserta(clave, dir, tamCub, Vacias);}
            else
            {
                if (Vacias.Count == 0)
                {
                    Ranuras[slot] = new Cubeta(NumDatos);
                    Ranuras[slot].Dir = dir;
                    DirRanuras[slot] = dir;
                    Ranuras[slot].Inserta(clave, dir, tamCub, Vacias);
                    returnal = Ranuras[slot];
                }
                else
                {
                    Ranuras[slot] = Vacias.First();
                    returnal = Ranuras[slot];
                    DirRanuras[slot] = returnal.Dir;
                    CubetasEmpty = returnal.DirSig;
                    Ranuras[slot].Inserta(clave, dir, tamCub, Vacias);
                    Vacias.Remove(returnal);
                }
            }
            if (Vacias.Contains(returnal))
            {
                Vacias.Remove(returnal);
                CubetasEmpty = returnal.DirSig;
                if (Vacias.Count > 0)
                {
                    Vacias.First().DirSig = returnal.DirSig;
                    Vacias.First().Sig = returnal.Sig;
                }
            }
            return returnal;
        }
        public Cubeta eliminaEnCubeta(int clave)
        {
            Cubeta returnal = null;
            int slot = clave % NumRanuras;
            if (Ranuras[slot] != null){returnal = Ranuras[slot].Elimina(clave);}
            return returnal;
        }
    }
}
