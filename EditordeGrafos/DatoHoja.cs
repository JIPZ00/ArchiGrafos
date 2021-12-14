using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditordeGrafos
{
    /*
    •	Tipo: 8 bytes
    *   Nombre: cadena de 30 caracteres (30 bytes) * 4
    •	Dirección de la entidad: long (8 bytes) *4 
    •	Dirección de la siguiente entidad: long (8 bytes) *4 
    *   Dato: long (8 bytes)
    *   
    *   
    *   Total: 200 bytes
    */
    public class DatoHoja
    {
        public long Dir;
        public char Tipo;
        public long degree; 
        public List<long> ptrs;
        public List<long> datos;

        public DatoHoja()
        {

        }
        public DatoHoja(int grado)
        {
            degree = grado;
            ptrs = new List<long>();
            datos = new List<long>();
        }

    }
}
