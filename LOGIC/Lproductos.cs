﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.LOGIC
{
   public class Lproductos
    {
        public int Id_Producto1 { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int Id_grupo { get; set; }
        public string Usa_inventarios { get; set; }
        public string Stock { get; set; }
        public double Precio_de_compra { get; set; }
        public string Fecha_de_vencimiento { get; set; }
        public double Precio_de_venta { get; set; }
        public string Codigo { get; set; }
        public int Se_vende_a { get; set; }
        public string Impuesto { get; set; }
        public double Stock_minimo { get; set; }
        public double Precio_mayoreo { get; set; }
        public double Sub_total_pv { get; set; }
        public double Sub_total_pm { get; set; }
        public double A_partir_de { get; set; }
    }
}
