using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.PRESENT.CAJA;
using PUNTO_DE_VENTA.DATE;
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.PRESENT;

namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    public partial class CierreTurno : Form
    {
        public CierreTurno()
        {
            InitializeComponent();
        }
        string correobase;
        string contraseña;
        string estado;
        double dinerocalculado;
        double resultado;
        string correoReceptor;
        int idusario;
        int idcaja;
        string usuario;

        private void CierreTurno_Load(object sender, EventArgs e)
        {
            lblDeberiaHaber.Text = lblVentasTotal.dineroEnCaja.ToString();
            dinerocalculado = Convert.ToDouble(lblDeberiaHaber.Text);
            mostrarCorreoBase();
            mostrarcorreodeEnvio();
            mostrarUsuarioSesion();
        }
        private void mostrarUsuarioSesion()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarUsuariosSesion(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                usuario = row["Nombres_y_Apellidos"].ToString();
            }
        }
        public void mostrarcorreodeEnvio()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrar_empresa(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                correoReceptor = row["Correo_para_envio_de_reportes"].ToString();
                txtCorreo.Text = correoReceptor;
            }
        }
        //public void mostrarcorreodeEnvio()
        //{
        //    DataTable dt = new DataTable();
        //    Obtener_datos.mostrar_empresa(ref dt);
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        correoReceptor = row["Correo_para_envio_de_reportes"].ToString();
        //        txtcorreo.Text = correoReceptor;
        //    }
        //}
        private void mostrarCorreoBase()
        {
            DataTable dt = new DataTable();
            Obtener_datos.mostrarCorreoBase(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                estado = Bases.Desencriptar(row["EstadoEnvio"].ToString());
                correobase = Bases.Desencriptar(row["Correo"].ToString());
                contraseña = Bases.Desencriptar(row["Password"].ToString());
            }
            if (estado == "Sincronizado")
            {
                checkCorreo.Checked = true;
            }
            else
            {
                checkCorreo.Checked = false;

            }
        }
        private void TxtHay_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        private void validacionesCalculo()
        {
            if (resultado == 0)
            {
                lblanuncio.Text = "Genial, Todo esta perfecto";
                lblanuncio.ForeColor = Color.FromArgb(0, 166, 63);
                lbldiferencia.ForeColor = Color.FromArgb(0, 166, 63);
                lblanuncio.Visible = true;

            }
            if (resultado < dinerocalculado & resultado != 0)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;

            }
            if (resultado > dinerocalculado)
            {
                lblanuncio.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                lblanuncio.ForeColor = Color.FromArgb(231, 63, 67);
                lbldiferencia.ForeColor = Color.FromArgb(231, 63, 67);
                lblanuncio.Visible = true;
            }
        }
        private void calcular()
        {
            try
            {


                double hay;
                hay = Convert.ToDouble(txthay.Text);
                if (string.IsNullOrEmpty(txthay.Text))
                {
                    hay = 0;
                }
                resultado = hay - dinerocalculado;
                lbldiferencia.Text = resultado.ToString();
                validacionesCalculo();
            }
            catch (Exception)
            {


            }
        }

        private void TxtHay_Click(object sender, EventArgs e)
        {

        }

        private void CheckCorreo_Click(object sender, EventArgs e)
        {
            if (estado != "Sincronizado")
            {
                PRESENT.CORREOS_BASE.ConfigurarCorreo frm = new PRESENT.CORREOS_BASE.ConfigurarCorreo();
                frm.FormClosing += Frm_FormClosing;
                frm.ShowDialog();
            }
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mostrarCorreoBase();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            cerrarCaja();

        }
        private void enviarcorreo()
        {
            if (checkCorreo.Checked == true)
            {
                ReemplazarHtml();
                bool estado;
                estado = Bases.enviarCorreo(correobase, contraseña, htmldeEnvio.Text, "Cierre de caja de VEGA", txtCorreo.Text, "");
                if (estado == true)
                {
                    MessageBox.Show("Reporte de cierre de caja Enviado");
                    generarCopiasBd();
                }
                else
                {
                    MessageBox.Show("Error de envio al correo");
                    generarCopiasBd();

                }
            }
            else
            {
                generarCopiasBd();
            }

        }

        private void generarCopiasBd()
        {
            Dispose();
            PRESENT.COPIAS_BD.GeneradorAutomatico frm = new PRESENT.COPIAS_BD.GeneradorAutomatico();
            frm.ShowDialog();
        }
        private void cerrarCaja()
        {
            Obtener_datos.mostrar_inio_de_secion(ref idusario);
            Obtener_datos.obtener_id_caja_PorSerial(ref idcaja);
            Lmcaja parametros = new Lmcaja();
            Editar_datos funcion = new Editar_datos();
            parametros.fechafin = DateTime.Now;
            parametros.fechacierre = DateTime.Now;
            parametros.ingresos = lblVentasTotal.Ingresos;
            parametros.egresos = lblVentasTotal.Egresos;
            parametros.Saldo_queda_en_caja = 0;
            parametros.Id_usuario = idusario;
            parametros.Total_calculado = dinerocalculado;
            parametros.Total_real = Convert.ToDouble(txthay.Text);
            parametros.Estado = "CAJA CERRADA";
            parametros.Diferencia = resultado;
            parametros.Id_caja = idcaja;
            if (funcion.cerrarCaja(parametros) == true)
            {
                enviarcorreo();
            }
        }

        public void ReemplazarHtml()
        {
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@ventas_totales", lblVentasTotal.ventastotales.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@Ganancias", lblVentasTotal.ganancias.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@fecha",DateTime.Now.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@usuario_nombre", usuario);
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@fondo_caja", lblVentasTotal.saldoInicial.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@ventas_efectivo", lblVentasTotal.ventasEfectivo.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@pagos", "0");
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@cobros", "0");
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@ingresosvarios", lblVentasTotal.ingresosEfectivo.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@gastosvarios", lblVentasTotal.gastosEfectivo.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@esperado", lblDeberiaHaber.Text);
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@vefectivo", lblVentasTotal.ventasEfectivo.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@vtarjeta", lblVentasTotal.ventasTarjeta.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@vcredito", lblVentasTotal.ventasCredito.ToString());
            htmldeEnvio.Text = htmldeEnvio.Text.Replace("@Tventas", lblVentasTotal.ventastotales.ToString());
        }

        private void CheckCorreo_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
            CAJA.lblVentasTotal frm = new CAJA.lblVentasTotal();
            frm.ShowDialog();
        }
    }
}
