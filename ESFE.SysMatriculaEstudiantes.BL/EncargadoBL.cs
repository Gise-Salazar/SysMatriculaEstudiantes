using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;

namespace ESFE.SysMatriculaEstudiantes.BL
{
    namespace ProyectoMatricula.LogicaNegocio
    {
        public class EncargadoBL
        {
            private EncargadoDAL encargadoDAL = new EncargadoDAL();

            public void RegistrarEncargado(Encargado encargado)
            {
                // Validaciones y lógica de negocio
                encargadoDAL.InsertarEncargado(encargado);
            }
        }
    }

}
