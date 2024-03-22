using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Management;
using System.Xml;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.DATE;

namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    public partial class APERTURA_DE_CAJA : Form
    {
        public APERTURA_DE_CAJA()
        {
            InitializeComponent();
        }
        int txtIdCaja;
        private void APERTURA_DE_CAJA_Load(object sender, EventArgs e)
        {
            Bases.Cambiar_idioma_regional();
            Obtener_datos.obtener_id_caja_PorSerial(ref txtIdCaja);
            //centrar_panel();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            bool estado = Editar_datos.editar_dinero_caja_inicial(txtIdCaja, Convert.ToDouble(txtmontos.Text));
            if (estado == true)
            {
                pasar_a_ventas();
            }
        }
        private void centrar_panel()
        {
            pnlCaja.Location = new Point((Width - pnlCaja.Width) / 2, (Height - pnlCaja.Height) / 2);
        }
        private void BtnOmitir_Click(object sender, EventArgs e)
        {
            pasar_a_ventas();
        }

        private void pasar_a_ventas()
        {
            Dispose();
            VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
            frm.ShowDialog();
            
        }

        private void Txtmontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Separador_de_Numeros(txtmontos, e);
        }
    }
}
