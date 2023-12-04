using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
   public  class LcontrolCobros
    {
        public int idcontrolCobro { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public  int idCliente { get; set; }
        public int idUsusario { get; set; }
        public int idCaja { get; set; }
        public string Comprobante { get; set; }
        public double Efectivo { get; set; }
        public double Tarjeta { get; set; }

    }
}
