using Parcial1StevenOmarAlfaroVillanueva.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Parcial1StevenOmarAlfaroVillanueva.Negocio
{
    public class ClsVenta
    {
        public string Cobro(Venta venta)
        {
            float total = venta.PrecioDelProducto * venta.CantidadDelProducto;
            


            if(total > 50)

            {
                float total2 = total - 10;


                return $"Total a pagar:  precio original:{total},el precio con descuento  es de:{total2} ";
            }
            else
            {
                return $"Total a pagar: precio original:{total}";
            }

        }
    }
}
