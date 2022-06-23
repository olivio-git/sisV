using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
namespace DAL
{
    public class IngresoDAL
    {
        public IngresoDAL() { }
        public DataTable ListarIngresos()
        {
            string query = "select * from Ingreso";
            DataTable tabla = conexion.EjecutarDataTable(query, "TABLA");
            return tabla;
        }
        public void AgregarIngreso(Ingreso i)
        {
            string query="insert into ingreso values("+i.Fecha+","+i.Total+",'"+i.idProveedor+"','"+i.Estado+"')";

            conexion.Ejecutar(query);
        }
    }
}
