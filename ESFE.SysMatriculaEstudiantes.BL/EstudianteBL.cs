using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;
using ESFE.SysMatriculaEstudiantes.DAL.Properties;
using System.Text.RegularExpressions;

namespace ESFE.SysMatriculaEstudiantes.BL
{

    public class EstudianteBL
    {
        public int InsertarEstudiante(Estudiante estudiante)
        {
            EstudianteDAL estudianteDAL = new EstudianteDAL();
            return estudianteDAL.InsertarEstudiante(estudiante);
        }

      
    }
}



