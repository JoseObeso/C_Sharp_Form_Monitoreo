using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistemamonitoreo
{
    public class ConexionSQL
    {
         public SqlConnection LeerCadena()
        {

            SqlConnection Cnx_SQL = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQLServer"].ConnectionString);

           





          
            if (Cnx_SQL.State == System.Data.ConnectionState.Open)
            {
                Cnx_SQL.Close();

            }
            else
            {
                Cnx_SQL.Open();
            }
            return Cnx_SQL;


        }
    }
}
