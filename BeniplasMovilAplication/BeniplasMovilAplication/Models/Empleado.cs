using System;
using System.Collections.Generic;
using System.Text;

namespace BeniplasMovilAplication.Models
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public long NumTel { get; set; }
        public long Codigo { get; set; }
        public string Contrasena { get; set; }

        public int EmpleadoID { get; set; }
    }
}
