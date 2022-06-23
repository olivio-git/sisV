using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProveedorDAL
    {
        public ProveedorDAL()
        {
        }
        public DataTable ListarProveedor()
        {
            string query="select * from Proveedor";
            return conexion.EjecutarDataTable(query, "Tabla");
        }
        public DataTable ListarProveedorSeleccionado(int id)
        {

            String query = "select * from proveedor where IDPROVEEDOR=" + id + "";
            return conexion.EjecutarDataTable(query, "TABLA");
        }

    }
}
