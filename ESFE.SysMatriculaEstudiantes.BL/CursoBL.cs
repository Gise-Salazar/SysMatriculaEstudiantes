using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;

namespace ESFE.SysMatriculaEstudiantes.BL
    {
        public class CursoBL
        {
            private CursoDAL cursoDAL = new CursoDAL();

            public void RegistrarCurso(Curso curso)
            {
                // Validaciones y lógica de negocio
                cursoDAL.InsertarCurso(curso);
            }
        }
    }
