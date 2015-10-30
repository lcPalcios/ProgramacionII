using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entity
{
    public class EstudianteEN
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public EstudianteEN()
        {

        }

        public EstudianteEN(string pNombre, string pApellido, string pTelefono)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Telefono = pTelefono;
        }

        public EstudianteEN(int pId,string pNombre, string pApellido, string pTelefono)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Telefono = pTelefono;
        }


    }
}
