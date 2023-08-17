using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace PUNTO_DE_VENTA.Logica
{
    class Bases
    {
        public static void obtener_serialPC(ref string serial)
        {
            ManagementObject serialPC = new ManagementObject((@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'"));
            serial = serialPC.Properties["serialNumber"].Value.ToString();
            serial = serial.Trim();
          
        }
        
        public static void Cambiar_idioma_regional()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
        }

    }
}
