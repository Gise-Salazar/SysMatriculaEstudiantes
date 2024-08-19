using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysMatriculaEstudiantes.DAL
{
    
        public class CursoDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

            public void InsertarCurso(Curso curso)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Curso (Nombre, Descripcion, Horario, Nivel, IdProfesor, IdMatricula, IdAsignatura) VALUES (@Nombre, @Descripcion, @Horario, @Nivel, @IdProfesor, @IdMatricula, @IdAsignatura)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", curso.Descripcion);
                    command.Parameters.AddWithValue("@Horario", curso.Horario);
                    command.Parameters.AddWithValue("@Nivel", curso.Nivel);
                    command.Parameters.AddWithValue("@IdProfesor", curso.IdProfesor);
                    command.Parameters.AddWithValue("@IdMatricula", curso.IdMatricula);
                    command.Parameters.AddWithValue("@IdAsignatura", curso.IdAsignatura);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

