using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }        
        public string Telefeno { get; set; }
        public string Ci { get; set; }
        [Email]
        public string Correo { get; set; }
        public string Estado { get; set; }

        public Persona() { }
    }
}
