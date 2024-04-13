using clase9progra.clasepadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9progra.clasehija
{
    internal class segaDreamcast:ClsConsola
    {
        public string juegossega { get; set; }
        public string MostrarDetallesega()
        {
            return MostrarDetalles() + " Juego Sega:" + juegossega;
        }
    }
}
