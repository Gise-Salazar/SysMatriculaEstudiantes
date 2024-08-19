using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;
namespace ESFE.SysMatriculaEstudiantes.BL
    {
        public class MatriculaBL
        {
            private MatriculaDAL matriculaDAL = new MatriculaDAL();

            public void RegistrarMatricula(Matricula matricula)
            {
                // Validaciones y lógica de negocio
                matriculaDAL.InsertarMatricula(matricula);
            }
        }
    }
