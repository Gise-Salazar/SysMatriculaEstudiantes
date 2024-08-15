using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysMatriculaEstudiantes.EN
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public string Nivel { get; set; }
        public int IdProfesor { get; set; }
        public int IdMatricula { get; set; }
        public int IdAsignatura { get; set; }
    }
}