using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;
using ESFE.SysMatriculaEstudiantes.DAL.Properties;

namespace ESFE.SysMatriculaEstudiantes.DAL
{
   
    
        public class EstudianteDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";


        public int InsertarEstudiante(Estudiante estudiante)
        {
            using (IDbConnection conexion = BDComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_INGRESARESTUDIANTE", conexion as SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(new SqlParameter("@NOMBRES_ESTU", estudiante.Nombres));
                comando.Parameters.Add(new SqlParameter("@APELLIDOS_ESTU", estudiante.Apellidos));
                comando.Parameters.Add(new SqlParameter("@FECHA_NACIMIENTO_ESTU", estudiante.FechaNacimiento));
                comando.Parameters.Add(new SqlParameter("@DIRECCION_ESTU", estudiante.Direccion));
                comando.Parameters.Add(new SqlParameter("@TELEFONO_ESTU", estudiante.Telefono));
                comando.Parameters.Add(new SqlParameter("@CORREO_ELECTRONICO_ESTU", estudiante.CorreoElectronico));
                comando.Parameters.Add(new SqlParameter("@ID_MATRICULA_ESTUDIANTE", estudiante.IdMatricula));
                comando.Parameters.Add(new SqlParameter("@ID_ENCARGADO_ESTUDIANTE", estudiante.IdEncargado));
                comando.Parameters.Add(new SqlParameter("@ID_CURSO_ESTUDIANTE", estudiante.IdCurso));

                int resultado = comando.ExecuteNonQuery();
                conexion.Close();
                return resultado;
            }
        }

    }
}    


    
