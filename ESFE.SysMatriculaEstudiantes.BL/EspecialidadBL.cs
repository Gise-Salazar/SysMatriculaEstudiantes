using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;
using ESFE.SysMatriculaEstudiantes.EN;

namespace ESFE.SysMatriculaEstudiantes.BL
{
    namespace ProyectoMatricula.LogicaNegocio
    {
        public class EspecialidadBL
        {
            private EspecialidadDAL especialidadDAL = new EspecialidadDAL();

            public void RegistrarEspecialidad(Especialidad especialidad)
            {
                // Validaciones y lógica de negocio
                especialidadDAL.InsertarEspecialidad(especialidad);
            }
        }
    }


}
