using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BSS
{
    public class ProveedorBSS
    {
        public ProveedorBSS()
        {
        }
        ProveedorDAL proveedorDAL=new ProveedorDAL();
        public DataTable ListarProveedor()
        {
            return proveedorDAL.ListarProveedor();
        }
        public DataTable ListarProveedorSeleccionado(int id)
        {
            return proveedorDAL.ListarProveedorSeleccionado(id);
        }
    }
}
