using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BSS;
using System.Data;
using ENTIDADES;
namespace BSS
{
    public class IngresoBSS
    {
        public IngresoBSS() { }
        IngresoDAL IngresoDAL = new IngresoDAL();
        public DataTable ListarIngresos()
        {
            DataTable dt = IngresoDAL.ListarIngresos();
            return dt;
        }
        public void InsertarIngreso(Ingreso ingreso)
        {
            IngresoDAL.AgregarIngreso(ingreso);
        }
    }
}
