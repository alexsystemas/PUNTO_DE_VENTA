using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
  public  class LcreditosPorPagar
    {
        public int IdCredito { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_registro { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public double Total { get; set; }
        public double Saldo { get; set; }
        public string Estado { get; set; }
        public int Id_caja { get; set; }
        public int Id_proveedor { get; set; }

    }
    }


