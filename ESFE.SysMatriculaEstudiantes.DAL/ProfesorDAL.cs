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
        public class ProfesorDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

        public void InsertarProfesor(Profesor profesor)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Profesor (Nombre, Apellido, CorreoElectronico, Telefono) VALUES (@Nombre, @Apellido, @CorreoElectronico, @Telefono)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", profesor.Nombre);
                    command.Parameters.AddWithValue("@Apellido", profesor.Apellido);
                    command.Parameters.AddWithValue("@CorreoElectronico", profesor.CorreoElectronico);
                    command.Parameters.AddWithValue("@Telefono", profesor.Telefono);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
