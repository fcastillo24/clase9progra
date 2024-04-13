using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9progra.clasepadre
{
    internal class ClsConsola
    {
        public int añolanzamiento { get; set; }  
        public string Marca { get; set; }
        public string MostrarDetalles()
        {
            return  $"Marca:{Marca} Año:{añolanzamiento}";

        }
    }
}
