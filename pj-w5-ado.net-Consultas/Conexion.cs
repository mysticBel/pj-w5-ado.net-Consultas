using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_w5_ado.net_Consultas
{
    internal class Conexion
    {
        //Método de conexion 
        public SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager
                                        .ConnectionStrings["cn"].ConnectionString);
            return cn;
        }
    }
}
