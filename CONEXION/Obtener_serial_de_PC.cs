using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace PUNTO_DE_VENTA.CONEXION
{
    class Obtener_serial_de_PC
    {
        public static void ObtenerSerialPC(ref TextBox txtserial)
        {
            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            txtserial.Text = MOS.Properties["SerialNumber"].Value.ToString();
            txtserial.Text = txtserial.Text.Trim();
        }
      
    }
}
