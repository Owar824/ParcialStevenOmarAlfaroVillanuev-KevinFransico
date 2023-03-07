using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1StevenOmarAlfaroVillanueva.Entidades
{
    public class Venta
    {
        public int IdentificadorDelProducto { get; set; }
        public string Nombreodeproducto { get; set; }
        
        public string  DescripcioDeProducto { get; set; }

        public float  PrecioDelProducto { get; set; }

        public int CantidadDelProducto { get; set; }

    }
}
