using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class conexion
    {
        public static string CONECTAR
        {
            //get { return @"Data Source=(local); Initial Catalog=SuperMercadoDB; User ID=sa; Password:tarija2008"; }
            get { return @"Data Source=DESKTOP-NPCRIU9\SQLEXPRESS; Initial Catalog=SuperMercadoDB; Integrated Security=True"; }
        }
        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            conectar.Close ();
            return result;
        }

        public static DataTable EjecutarDataTable(string consulta, string tabla)
        {
            SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            return dt;
        }
    }
}
