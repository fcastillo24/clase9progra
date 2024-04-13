using clase9progra.clasepadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9progra.clasehija
{
    internal class xbox:ClsConsola
    {
        public string ColorXbox { get; set; }
        public string MostrarDetalleXbox()
        {
            return MostrarDetalles() + " Color Xbox:" + ColorXbox;
        }
    }
}
