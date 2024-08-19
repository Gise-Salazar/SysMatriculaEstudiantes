using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;

namespace ESFE.SysMatriculaEstudiantes.BL
    {
        public class ProfesorBL
        {
            private ProfesorDAL profesorDAL = new ProfesorDAL();

            public void RegistrarProfesor(Profesor profesor)
            {
                // Validaciones y lógica de negocio
                profesorDAL.InsertarProfesor(profesor);
            }
        }
}

