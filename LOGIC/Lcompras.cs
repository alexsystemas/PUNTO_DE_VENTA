using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
   public class Lcompras
    {
        public int Idcompra { get; set; }
        public DateTime fechacompra { get; set; }
        public double Total { get; set; }
        public string Comprobante { get; set; }
        public int IdProveedor { get; set; }
        public int Idcaja { get; set; }
    }
}
