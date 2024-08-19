using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;


namespace ESFE.SysMatriculaEstudiantes.BL
{
        public class AsignaturaBL
        {
            private AsignaturaDAL asignaturaDAL = new AsignaturaDAL();

            public void RegistrarAsignatura(Asignatura asignatura)
            {
                // Validaciones y lógica de negocio
                asignaturaDAL.InsertarAsignatura(asignatura);
            }
        }
    }