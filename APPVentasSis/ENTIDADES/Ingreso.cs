using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Ingreso
    {
        public string Fecha { get; set; }
        public string Total { get; set; }
        public string idProveedor { get; set; }
        public string Estado { get; set; } 
        public Ingreso() { }
    }
}
