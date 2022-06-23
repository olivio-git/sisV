using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
namespace DAL
{
    public class PersonaDAL
    {
        public PersonaDAL() { }

        public DataTable ListarPersonas()
        {
            string consulta = "select * from persona where IdPersona>5";
            DataTable tabla = conexion.EjecutarDataTable(consulta, "TABLA");
            return tabla;
        }
       
    }
}
