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
        public class EncargadoDAL
        {
            private string connectionString = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";

        public void InsertarEncargado(Encargado encargado)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Encargado (Nombre, Apellido, Parentesco, Direccion, Telefono, CorreoElectronico) VALUES (@Nombre, @Apellido, @Parentesco, @Direccion, @Telefono, @CorreoElectronico)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", encargado.Nombre);
                    command.Parameters.AddWithValue("@Apellido", encargado.Apellido);
                    command.Parameters.AddWithValue("@Parentesco", encargado.Parentesco);
                    command.Parameters.AddWithValue("@Direccion", encargado.Direccion);
                    command.Parameters.AddWithValue("@Telefono", encargado.Telefono);
                    command.Parameters.AddWithValue("@CorreoElectronico", encargado.CorreoElectronico);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
