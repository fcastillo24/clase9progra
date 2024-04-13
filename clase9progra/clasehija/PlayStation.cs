using clase9progra.clasepadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9progra.clasehija
{
    internal class PlayStation:ClsConsola
    {
        public string ModelControlador {  get; set; }
        public string MostrarDetallePlay()
        { 
            return MostrarDetalles() + " Controlador:" + ModelControlador;
        }
    }
}
