using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAL;
using System.Data;

namespace BSS
{
    public class PersonaBSS
    {
        public PersonaBSS() { }
        PersonaDAL PersonaDAL =new PersonaDAL();
        public DataTable ListarPersonas()
        {
            DataTable dt = PersonaDAL.ListarPersonas();
            return dt;
        }
    }
}
