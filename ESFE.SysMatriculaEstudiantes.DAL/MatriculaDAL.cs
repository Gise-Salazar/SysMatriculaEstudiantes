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

        public class MatriculaDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

        public void InsertarMatricula(Matricula matricula)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Matricula (Fecha, Estado) VALUES (@Fecha, @Estado)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Fecha", matricula.Fecha);
                    command.Parameters.AddWithValue("@Estado", matricula.Estado);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
