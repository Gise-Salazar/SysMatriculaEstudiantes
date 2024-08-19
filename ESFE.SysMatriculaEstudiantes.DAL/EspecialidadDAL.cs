using System;
using ESFE.SysMatriculaEstudiantes.EN;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESFE.SysMatriculaEstudiantes.DAL
{
        public class EspecialidadDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

        public void InsertarEspecialidad (Especialidad especialidad)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Especialidad (Nombre) VALUES (@Nombre)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", especialidad.Nombre);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
 }
