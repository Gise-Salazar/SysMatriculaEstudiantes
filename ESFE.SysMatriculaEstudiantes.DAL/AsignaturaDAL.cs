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

        public class AsignaturaDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

            public void InsertarAsignatura(Asignatura asignatura)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Asignatura (Nombre, Descripcion, Horario) VALUES (@Nombre, @Descripcion, @Horario)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", asignatura.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", asignatura.Descripcion);
                    command.Parameters.AddWithValue("@Horario", asignatura.Horario);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
}