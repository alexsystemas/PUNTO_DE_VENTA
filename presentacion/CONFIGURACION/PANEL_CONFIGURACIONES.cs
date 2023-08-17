﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.sevendePor.CONFIGURACION
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
            sevendePor.PRODUCTOS_OK.Productos_OK frm = new sevendePor.PRODUCTOS_OK.Productos_OK();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();

        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void LblProductos_Click(object sender, EventArgs e)
        {

            sevendePor.PRODUCTOS_OK.Productos_OK frm = new sevendePor.PRODUCTOS_OK.Productos_OK();
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
            sevendePor.CAJA.Caja frm = new sevendePor.CAJA.Caja();
            frm.ShowDialog();
        }
    }
}