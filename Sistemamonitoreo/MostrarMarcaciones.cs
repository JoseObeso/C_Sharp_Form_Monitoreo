using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// dataGridView1
namespace Sistemamonitoreo
{
    public class MostrarMarcaciones
    {
        ConexionSQL Cn = new ConexionSQL();

        public  DataTable MostrarMarcacionesEnForm()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRAR_ULTIMAS_MARCACIONES", Cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }


    }
}
