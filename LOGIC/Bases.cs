using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Drawing;

namespace PUNTO_DE_VENTA.LOGIC
{
    class Bases
    {
       public static void Obtener_serialPC(ref string serial)
        {
            ManagementObject serialPC = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            serial = serialPC.Properties["SerialNumber"].Value.ToString();
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

        public static void Multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.White;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
    }
}
