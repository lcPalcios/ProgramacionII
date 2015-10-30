using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entity;

namespace Sistema.DAL
{
    public class EstudianteDAL
    {
        //CRUD => CREATE Retrive Update Delete
        private DataRow dr = null;

        public DataTable Insert(DataTable dt, EstudianteEN estudiante)
        {
            dr = dt.NewRow();
            dr["Id"] = estudiante.Id;
            dr["Nombre"] = estudiante.Nombre;
            dr["Apellido"] = estudiante.Apellido;
            dr["Telefono"] = estudiante.Telefono;
            dt.Rows.Add(dr);

            return dt;
        }

    }
}
