using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
  public  class Lclientes
    {
        public int idclientev { set; get; }
        public string Nombre { set; get; }
        public string Direccion_para_factura { set; get; }
        public string RFC { set; get; }
        public string movil { set; get; }
        public string Estado { set; get; }
        public double Saldo { set; get; }

    }
}
