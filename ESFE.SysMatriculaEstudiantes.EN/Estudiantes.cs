using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysMatriculaEstudiantes.EN
{
 
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int IdMatricula { get; set; }
        public int IdEncargado { get; set; }
        public int IdCurso { get; set; }
       
    }
}
