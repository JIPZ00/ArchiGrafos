using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditordeGrafos
{
    /*
    •	Dirección de la entidad: long (8 bytes)
    *   Tipo: char (1 byte)
    •	Nombre: numero ong (8 bytes)
    •	Dirección de la siguiente entidad: long (8 bytes)
    *   
    *   Total: 25 bytes
     */
    public class DatoArbol
    {
        public long Dir;
        public char Tipo;
        public long Numero;
        public long Sig_Dir;

        public DatoArbol()
        {

        }
        public DatoArbol(int dato)
        {
            Numero = dato;
            Sig_Dir = -1;
            Tipo = 'D';
        }
    }
}
