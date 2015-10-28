using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }

        public Estudiante() { }

        public Estudiante(string pNombre, string pApellido, DateTime pFecha,
                            string pTelefono)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNac = pFecha;
            Telefono = pTelefono;
        }

        public Estudiante(int pId, string pNombre, string pApellido, 
            DateTime pFecha, string pTelefono)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNac = pFecha;
            Telefono = pTelefono;
        }



    }
}
