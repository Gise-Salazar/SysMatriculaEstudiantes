using ESFE.SysMatriculaEstudiantes.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESFE.SysMatriculaEstudiantes.DAL;
using ESFE.SysMatriculaEstudiantes.DAL.Properties;
using System.Text.RegularExpressions;

namespace ESFE.SysMatriculaEstudiantes.BL
{

    public class EstudianteBL
    {
        public int InsertarEstudiante(Estudiante estudiante)
        {
            EstudianteDAL estudianteDAL = new EstudianteDAL();
            return estudianteDAL.InsertarEstudiante(estudiante);
        }

        //otro metodo Seleccionar todo
        public List<Estudiante> ObtenerEstudiante()
        {
            List<Estudiante> _marcas = new List<Estudiante>();


            //la lista es para tener todos los valores necesitamos que devuelva todo lo que esta en la tabla
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("SELECT * FROM Estudiante", _conn as SqlConnection);
                SqlDataReader _reader = _command.ExecuteReader();//esto se lo se usa con el select

                while (_reader.Read())
                {
                    Estudiante estudiante = new Estudiante
                    {

                        //esto es un casteo esto pasar parametros al tipo de datos que va a leer
                        Id = (int)_reader.GetSqlInt32(0),
                        Nombres = _reader.GetString(1),
                        Direccion = _reader.GetString(2),
                        Telefono = (int)_reader.GetSqlInt32(3),
                        Apellidos = _reader.GetString(4)


                    };

                    estudiante.Add(estudiante);
                }

                _reader.Close();
                _conn.Close();
                return estudiante;
            }
        }
    }
}


