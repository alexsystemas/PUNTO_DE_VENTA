using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
    public class LDetalleCompra
    {
        public int IdDetallecompra { get; set; }
        public int IdCompra { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public string Moneda { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
