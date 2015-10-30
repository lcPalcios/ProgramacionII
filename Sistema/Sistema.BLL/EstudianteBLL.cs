using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAL;
using System.Data;
using Sistema.Entity;
namespace Sistema.BLL
{
    public class EstudianteBLL
    {
        private EstudianteDAL estudianteDAL = null;
        
        private DataTable Insert(EstudianteEN estudiante, DataTable dt)
        {
            DataTable dtResult = null;  
            if(estudiante != null)
            {
                estudianteDAL = new EstudianteDAL();
                dtResult =  estudianteDAL.Insert(dt, estudiante);
            }
            return dtResult;
        }
    }
}
