using clase9progra.clasepadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9progra.clasehija
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable { get; set; }
        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + "Es potable" + esPortable;
        }
    }
}
