﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;

using System.Globalization;
using System.Threading;


namespace PUNTO_DE_VENTA.MODULOS.CAJA
{
    public partial class CIERRE_DE_CAJA : Form
    {
        public CIERRE_DE_CAJA()
        {
            InitializeComponent();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("CERRAR_CAJA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", txtIdCaja.Text);
                cmd.Parameters.AddWithValue("@fechafin", txtfechacierre.Value);
                cmd.Parameters.AddWithValue("@fechacierre", txtfechacierre.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CIERRE_DE_CAJA_Load(object sender, EventArgs e)
        {
            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            lblSerialPC.Text = lblSerialPC.Text.Trim();
                lblSerialPC.Text = MOS.Properties["SerialNumber"].Value.ToString();
                MOSTRAR_CAJA_POR_SERIAL();
                try
                {
                    txtIdCaja.Text = datalistado_caja.SelectedCells[1].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void MOSTRAR_CAJA_POR_SERIAL()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPC.Text);
                da.Fill(dt);
                datalistado_caja.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
