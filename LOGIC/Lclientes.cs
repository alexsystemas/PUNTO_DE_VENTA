﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
  public  class Lclientes
    {
        public int IdCliente { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string IdentificadorFiscal { set; get; }
        public string Celular { set; get; }
        public string Estado { set; get; }
        public double saldo { set; get; }

    }
}