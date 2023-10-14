using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.PRESENT.CONFIGURACION
{
    public partial class PANEL_CONFIGURACIONES : Form
    {
        public PANEL_CONFIGURACIONES()
        {
            InitializeComponent();
        }

        private void PictureBoxProductos_Click(object sender, EventArgs e)
        {
            Dispose();
            PRESENT.PRODUCTOS_OK.Productos_OK frm = new PRESENT.PRODUCTOS_OK.Productos_OK();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();

        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void LblProductos_Click(object sender, EventArgs e)
        {

            PRESENT.PRODUCTOS_OK.Productos_OK frm = new PRESENT.PRODUCTOS_OK.Productos_OK();
            frm.ShowDialog();
        }

   

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Dispose();
            CONFIGURACION.PANEL_CONFIGURACIONES frm = new CONFIGURACION.PANEL_CONFIGURACIONES();
            frm.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            configurar_empresa();
        }
        private void configurar_empresa()
        {
            EMPRESA_CONFIGURACION.EMPRESA_CONFIG frm = new EMPRESA_CONFIGURACION.EMPRESA_CONFIG();
            frm.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            configurar_empresa();
        }

        private void usuarios()
        {
            UsuariosOK frm=new  UsuariosOK();
            frm.ShowDialog();
        }

        private void PictureBoxUsuarios_Click(object sender, EventArgs e)
        {
            usuarios();
        }

        private void LblUsuarios_Click(object sender, EventArgs e)
        {
            usuarios();
        }

        private void PANEL_CONFIGURACIONES_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            caja();
        }
     

        private void Label4_Click(object sender, EventArgs e)
        {
            caja();
        }
        private void caja()
        {
            PRESENT.CAJA.Caja frm = new PRESENT.CAJA.Caja();
            frm.ShowDialog();
        }

        private void PckCopiasSeguridad_Click(object sender, EventArgs e)
        {
            PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD frm = new PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD();
            frm.ShowDialog();
        }

        private void LblCopiasseguridad_Click(object sender, EventArgs e)
        {
            PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD frm = new PRESENT.COPIAS_BD.COPIA_DE_SEGURIADAD();
            frm.ShowDialog();
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            provedor();
        }
       private void provedor()
        {
            PRESENT.CLIENTES_PROVEEDORES.Proveedores frm = new PRESENT.CLIENTES_PROVEEDORES.Proveedores();
            frm.ShowDialog();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            provedor();
        }

        private void configurar_correo()
        {
            CORREOS_BASE.ConfigurarCorreo frm = new CORREOS_BASE.ConfigurarCorreo();
            frm.ShowDialog();
        }

        private void PckNotificacionCorreo_Click(object sender, EventArgs e)
        {
            configurar_correo();
        }

        private void LblNotificacionCorreo_Click(object sender, EventArgs e)
        {
            configurar_correo();
        }
    }
}
