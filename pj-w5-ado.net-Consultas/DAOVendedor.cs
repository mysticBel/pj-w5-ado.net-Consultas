using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pj_w5_ado.net_Consultas
{
   
    internal class DAOVendedor
    {
         Conexion objCon = new Conexion();
         SqlConnection cn;

        // 1. Listado General de Vendedores
        public DataTable listadoGeneral()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAVENDEDORES", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //2. Listado de Distritos para COMBO
        public DataTable listadoDistritos()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADODISTRITOS", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //3. Listado de vendedores por distrito
        public DataTable listadoVendedoresxDistrito(Vendedor objV)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_VENDEDORESxDISTRITO", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@DIS", objV.ide_dis);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
