using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysMatriculaEstudiantes.DAL.Properties
{
    public class BDComun
    {
        public const string _stringCnn = @"Data Source=GISELA-SALAZAR\\SQLEXPRESS;Initial Catalog=Proyecto_Matricula;Integrated Security=True";
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

