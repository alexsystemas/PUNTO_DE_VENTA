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
using System.Management;
using System.Net;

namespace PUNTO_DE_VENTA.PRESENT
{
    public partial class LOGIN : Form
    {
        int contador;
        int contadorCajas;
        int contador_Movimientos_de_caja;
        public static String idusuariovariable;
        public static String idcajavariable;
        public LOGIN()
        {
            InitializeComponent();
        }
        public void DIBUJARusuarios()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select * from USUARIO2 WHERE Estado = 'ACTIVO' ", con); // ejecutamos procedimiento almacenado
                SqlDataReader rdr = cmd.ExecuteReader();
            



            while (rdr.Read()) // bucle tipo while 
            {
                Label b = new Label(); // declaramos un label llamdo b
                Panel p1 = new Panel(); // declaramos un panel llamdo p1
                PictureBox I1 = new PictureBox(); // declaramos un pictureBox lllamdo I1

                b.Text = rdr["Login"].ToString(); // el testo del label b va jalar la columna del procedimento 
                b.Name = rdr["idUsuario"].ToString();// el nombre del label va jalar el idUsuario
                b.Size = new System.Drawing.Size(163, 42);// asignamos un tamaño
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);// asignamos un tipo de letra
                b.BackColor = Color.FromArgb(236, 240, 241);//asignamos un color de fondo
                b.ForeColor = Color.FromArgb(0, 85, 128);// asignamos el color de la letra
                b.Dock = DockStyle.Bottom;// agregamos la pocision del dock 
                b.TextAlign = ContentAlignment.MiddleCenter;// agregamos la pocision de la letra
                b.Cursor = Cursors.Hand;//agregamos el tipo de cursor

                p1.Size = new System.Drawing.Size(163, 140);//asiganamos el tamaño de panel
                p1.BorderStyle = BorderStyle.None;// quitamos la propiedad border
                p1.BackColor = Color.FromArgb(226, 226, 226);// asignamos un color a panel


                I1.Size = new System.Drawing.Size(163, 95); //asignamos un tamaño a nuestro pictureBox
                I1.Dock = DockStyle.Top;// asiganos pocision del I1
                I1.BackgroundImage = null;// el tratamiento de la imagen va estar en null
                byte[] bi = (Byte[])rdr["Icono"];//se pone en byte y luego obtiene la variable icono de nuetra tabla
                MemoryStream ms = new MemoryStream(bi); // asemos una conversion de datos del rdr
                I1.Image = Image.FromStream(ms);
                I1.SizeMode = PictureBoxSizeMode.Zoom;//mostramos la ppriedad zoom
                I1.Tag = rdr["Login"].ToString();
                I1.Cursor = Cursors.Hand;// avilitamos la propiedad cursor con hand

                p1.Controls.Add(b);// agregamos al panel el label b
                p1.Controls.Add(I1);// egramos al panel el pictureBox
                b.BringToFront();// decimos que el label estaria adelante
                flowyoouPanel1.Controls.Add(p1); // en el FlowyouPanel1 agregamos el panel1

                b.Click += new EventHandler(mieventoLabel); // creamos evento por codigo eventoHandler llamando metodo click
                I1.Click += new EventHandler(miEventoImagen);
            }
            con.Close();
        }
           catch (Exception)
            {

               
            }
}

    private void MOSTRAR_PERMISOS()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand com = new SqlCommand("mostrar_permisos_por_usuario_ROL_UNICO", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LOGIN", txtLogin.Text);
            string importe;


            try
            {
                con.Open();
                importe = Convert.ToString(com.ExecuteScalar());
                con.Close();
                lblRol.Text = importe;

            }
            catch (Exception ex)
            {

            }




        }
        private void miEventoImagen(System.Object sender, EventArgs e)
        {
             txtLogin.Text = ((PictureBox)sender).Tag.ToString();// traemos la propiedad Tag de nuetro pictureBox
             panelIngresoDeContrasena.Visible = true;
             panelUsuarios.Visible = false;
             MOSTRAR_PERMISOS();

            

        }
        private void mieventoLabel(System.Object sender, EventArgs e)
        {
              txtLogin.Text = ((Label)sender).Text; //Traemos la propiedad del texto de mi label
              panelIngresoDeContrasena.Visible = true; // el panel lo hacemos visible
              panelUsuarios.Visible = false;// ocultamos el panel
              MOSTRAR_PERMISOS();


            
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            DIBUJARusuarios();
            timer1.Start();
            escalar_paneles();
        }

        void escalar_paneles()
        {
            panelUsuarios.Size = new System.Drawing.Size (794, 618);
            panelIngresoDeContrasena.Size = new System.Drawing.Size(630, 568);
            panelRestaurar_Cuenta.Size=new System.Drawing.Size(553, 223);
            PdCarga.Size = new System.Drawing.Size(175, 153);

            panelIngresoDeContrasena.Visible = false;
            PdCarga.Location = new Point((Width - PdCarga.Width) / 2, (Height - PdCarga.Height) / 2); // centramos el gif en el centro
            panelIngresoDeContrasena.Location = new Point((Width - panelIngresoDeContrasena.Width) / 2, (Height - panelIngresoDeContrasena.Height) / 2);
            panelUsuarios.Location = new Point((Width - panelUsuarios.Width) / 2, (Height - panelUsuarios.Height) / 2);
            panelRestaurar_Cuenta.Location = new Point((Width - panelRestaurar_Cuenta.Width) / 2, (Height - panelRestaurar_Cuenta.Height) / 2);

        }
        private void ListarAPERTURAS_de_detalle_de_cierres_de_caja()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPc.Text);
                da.Fill(dt);
                datalistado_detalle_cierre_de_caja.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void TxtPassword_TextChanged_1(object sender, EventArgs e)
        {
           
            Iniciar_sesion_correcto(); //mandamos llamar el metodo
        }
        private void contar_aperturas_de_cierres_de_caja() // creamos un metodo para realizar un conteo
        {
            int x;

            x = datalistado_detalle_cierre_de_caja.Rows.Count;
            contadorCajas = (x);
        }
        private void aperturar_detalle_de_cierre_caja()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_DETALLE_cierre_de_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Today);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", txtidcaja.Text);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Iniciar_sesion_correcto()
        {
           

            cargar_Usuarios();
            contar();
            try
            {
                IDUSUARIO.Text = dataListado.SelectedCells[1].Value.ToString();
                txtNombre.Text = dataListado.SelectedCells[2].Value.ToString();
                idusuariovariable = IDUSUARIO.Text;
            }
            catch
            {

            }

                if (contador > 0)
            {
                   ListarAPERTURAS_de_detalle_de_cierres_de_caja();
                   contar_aperturas_de_cierres_de_caja();
                   if (contadorCajas == 0 & lblRol.Text != "Solo Ventas(no esta autorizado para manejar dinero)")
                    {
                         aperturar_detalle_de_cierre_caja();
                         lblaperturaDeCaja.Text = "Nuevo*****";
                         timer2.Start();

                     }
                else
                {
                    if (lblRol.Text != "Solo Ventas(no esta autorizado para manejar dinero)")
                    {
                        MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario();
                        contar_MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario();
                        try
                        {
                            lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells[1].Value.ToString();
                            lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells[2].Value.ToString();
                        }
                        catch
                        {

                        }
                        if (contador_Movimientos_de_caja == 0)

                        {

                            if (lblusuario_queinicioCaja.Text != "admin" & txtLogin.Text == "admin")
                            {
                               // MessageBox.Show("Continuaras Turno de *" + lblnombredeCajero.Text + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblpermisodeCaja.Text = "correcto";
                            }
                            if (lblusuario_queinicioCaja.Text == "admin" & txtLogin.Text == "admin")
                            {

                                lblpermisodeCaja.Text = "correcto";
                            }

                            else if (lblusuario_queinicioCaja.Text != txtLogin.Text)
                            {
                                MessageBox.Show("Para poder continuar con el Turno de *" + lblnombredeCajero.Text + "* ,Inicia sesion con el Usuario " + lblusuario_queinicioCaja.Text + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblpermisodeCaja.Text = "vacio";

                            }
                            else if (lblusuario_queinicioCaja.Text == txtLogin.Text)
                            {
                                lblpermisodeCaja.Text = "correcto";
                            }
                        }
                        else
                        {
                            lblpermisodeCaja.Text = "correcto";
                        }
                        if (lblpermisodeCaja.Text == "correcto")
                        {
                            lblaperturaDeCaja.Text = "Aperturado";
                            timer2.Start();

                        }

                    }
                    else
                {
                    timer2.Start();
                }


                }



            }

        }


        private void MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPc.Text);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", IDUSUARIO.Text);
                da.Fill(dt);
                datalistado_movimientos_validar.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void contar_MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario()
        {
            int x;

            x = datalistado_movimientos_validar.Rows.Count;
            contador_Movimientos_de_caja = (x);

        }
        private void contar() // creamos un metodo para realizar un conteo
        {
            int x;

            x = dataListado.Rows.Count;
          
            
            contador = (x);

              


        }

        private void cargar_Usuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("validar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@password",CONEXION.Encryptar_en_texto.Encriptar (txtPassword.Text));
                da.SelectCommand.Parameters.AddWithValue("@login", txtLogin.Text);

                da.Fill(dt);
                dataListado.DataSource = dt;
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void mostrar_correos()
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("select Correo from USUARIO2 where Estado='ACTIVO'", con);

                da.Fill(dt);
                txtCorreo.DisplayMember = "Correo";
                txtCorreo.ValueMember = "Correo";
                txtCorreo.DataSource = dt;
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }



        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            panelRestaurar_Cuenta.Visible = false;
            panelUsuarios.Visible = true;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOlvideContraseña_Click_1(object sender, EventArgs e)
        {
            panelRestaurar_Cuenta.Visible = true;
            panelUsuarios.Visible = false;
            mostrar_correos();
        }


        private void mostrar_usuarios_por_correo()
        {
            try
            {
                string resultado;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                SqlCommand da = new SqlCommand("buscar_USUARIO_por_correo", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@correo", txtCorreo.Text);

                con.Open();
                lblResultadoContraseña.Text = Convert.ToString(da.ExecuteScalar());
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            mostrar_usuarios_por_correo();
            richTextBox1.Text = richTextBox1.Text.Replace("@pass", lblResultadoContraseña.Text);//nos devuelve una cadena con dichos requisitos especificados
            enviarCorreo("pruebasalex022@gmail.com", "jnudqrccnvxyhqis", richTextBox1.Text, "Solicitud de Contraseña", txtCorreo.Text, ""); //agregamos el correo y contraseña donde enviara las respuesta requeridas
        }
        internal void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta) // hacemos la validacion de datos para el envio de correo
        {
            try
            {
                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add((destinatario));
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                lblEstado_de_envio.Text = "ENVIADO";
                MessageBox.Show("Contraseña Enviada, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelRestaurar_Cuenta.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblEstado_de_envio.Text = "Correo no registrado";
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
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPc.Text);
                da.Fill(dt);
                datalistado_caja.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        string INDICADOR;
        private void mostrar_usuarios_registrados()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("select * from USUARIO2", con);
                da.Fill(dt);
                datalistado_USUARIOS_REGISTRADOS.DataSource = dt;
                con.Close();
                INDICADOR = "CORRECTO";
            }
            catch (Exception ex)
            {

                INDICADOR = "INCORRECTO";
            }
        }
        private void MOSTRAR_licencia_temporal()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("select * from Marcan ", con);
                da.Fill(dt);
                datalistado_licencia_temporal.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                INDICADOR = "INCORRECTO";
            }
        }
        int txtcontador_USUARIOS;
        private void contar_USUARIOS()
        {
            int x;
            x = datalistado_USUARIOS_REGISTRADOS.Rows.Count;
            txtcontador_USUARIOS = (x);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            mostrar_usuarios_registrados();

            if (INDICADOR == "CORRECTO")
            {
                contar_USUARIOS();
                if (txtcontador_USUARIOS == 0)
                {
                    Hide();
                    PRESENT.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA frm = new PRESENT.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA();
                    frm.ShowDialog();
                    Dispose();
                }
              

            }


            if (INDICADOR == "INCORRECTO")
            {
                Hide();
                PRESENT.ASISTENTE_DE_ISTALACION_servidor.Eleccion_Servidor_o_remoto frm = new PRESENT.ASISTENTE_DE_ISTALACION_servidor.Eleccion_Servidor_o_remoto();
                frm.ShowDialog();
                Dispose();
            }
            // timer1.Stop();
            try
            {

                ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
               
                    lblSerialPc.Text = MOS.Properties["SerialNumber"].Value.ToString();
                    lblSerialPc.Text = lblSerialPc.Text.Trim(); 

                    MOSTRAR_CAJA_POR_SERIAL();
                    try
                    {
                    txtidcaja.Text = datalistado_caja.SelectedCells[1].Value.ToString();
                    lblcaja.Text = datalistado_caja.SelectedCells[2].Value.ToString();
                    idcajavariable = txtidcaja.Text;

                }
                    catch (Exception ex)
                     {
                    MessageBox.Show(ex.Message);
                     }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MOSTRAR_licencia_temporal();
            try
            {
                txtfecha_final_licencia_temporal.Value = Convert.ToDateTime( CONEXION.Encryptar_en_texto.Desencriptar(datalistado_licencia_temporal.SelectedCells[3].Value.ToString()));
                lblSerialPCLocal.Text = (CONEXION.Encryptar_en_texto.Desencriptar(datalistado_licencia_temporal.SelectedCells[2].Value.ToString()));
                lblEstadoLicencia.Text = (CONEXION.Encryptar_en_texto.Desencriptar(datalistado_licencia_temporal.SelectedCells[4].Value.ToString()));
                txtfecha_Inicio_licencia_temporal.Value = Convert.ToDateTime(CONEXION.Encryptar_en_texto.Desencriptar(datalistado_licencia_temporal.SelectedCells[5].Value.ToString()));

            }
            catch (Exception ex)
            {

              
            }
            if (lblEstadoLicencia.Text != "VENCIDO")
            {
                string fechaHOY = Convert.ToString(DateTime.Now);
                DateTime fecha_ddmmyy = Convert.ToDateTime(fechaHOY.Split(' ')[0]);

                if(txtfecha_final_licencia_temporal.Value >= fecha_ddmmyy)
                {

                    if (txtfecha_Inicio_licencia_temporal.Value <= fecha_ddmmyy)
                    {
                        if(lblEstadoLicencia.Text=="?ACTIVO?")
                        {
                            Ingresar_por_licencia_temporal();
                        }
                        else if (lblEstadoLicencia.Text == "?ACTIVO PRO?")
                        {
                            Ingresaer_por_licencia_de_paga(); 
                        }

                    }
                    else
                    {
                       Hide();
                        PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                        frm.ShowDialog();
                        Dispose();
                    }
                }
                else
                {
                    Hide();
                    PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                    frm.ShowDialog();
                    Dispose();
                }
            }
            else
            {
                Hide();
                PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                frm.ShowDialog();
                Dispose();
            }
        }
        private void Ingresar_por_licencia_temporal()
        {
            lblEstadoLicencia.Text = "Licencia de prueba Activada hasta el: " + txtfecha_final_licencia_temporal.Text;
        }

        private void Ingresaer_por_licencia_de_paga()
        {
            lblEstadoLicencia.Text = "Licencia de PROFECCIONAL Activada hasta el: " + txtfecha_final_licencia_temporal.Text;
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + "9";
        }

        private void BtnBorrarTodo_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        private void BtnBorrarDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                int largo;
                if (txtPassword.Text != "")
                {
                    largo = txtPassword.Text.Length;
                    txtPassword.Text = Mid(txtPassword.Text, 1, largo - 1);
                }
            }
            catch
            {

            }
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnOcultar.Visible = false;
            btnVer.Visible = true;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnOcultar.Visible = true;
            btnVer.Visible = false;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void editar_inicio_De_sesion()
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_inicio_De_sesion", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", IDUSUARIO.Text);
                cmd.Parameters.AddWithValue("@Id_serial_Pc", CONEXION.Encryptar_en_texto.Encriptar(lblSerialPc.Text));
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                BackColor = Color.FromArgb(218, 243, 233);
                progressBar1.Value = progressBar1.Value + 10;
                PdCarga.Visible = true;
                panelIngresoDeContrasena.Visible = false;
                panelUsuarios.Visible = false;
                panelRestaurar_Cuenta.Visible = false;

            }
            else
            {
                progressBar1.Value = 0;
                timer2.Stop();
                if (txtLogin.Text == "admin")
                {
                    editar_inicio_De_sesion();
                    this.Hide();
                    admin_nivel_dios.DASHBOARD_PRINCIPAL frm = new admin_nivel_dios.DASHBOARD_PRINCIPAL();
                    frm.ShowDialog();
                    Dispose();
                }
                else
                {
                    if (lblaperturaDeCaja.Text == "Nuevo*****" & lblRol.Text == "Cajero (Si esta autorizado para manejar dinero)")
                    {
                        editar_inicio_De_sesion();
                        this.Hide();
                        CAJA.APERTURA_DE_CAJA frm = new CAJA.APERTURA_DE_CAJA();
                        frm.ShowDialog();
                        Dispose();
                    }
                    else if (lblaperturaDeCaja.Text != "Nuevo*****" & lblRol.Text == "Cajero (Si esta autorizado para manejar dinero)")
                    {
                        editar_inicio_De_sesion();
                        this.Hide();
                        VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                        frm.ShowDialog();
                        Dispose();
                    }
                    else if (lblRol.Text == "Solo Ventas (no esta autorizado para manejar dinero)")
                    {
                        editar_inicio_De_sesion();
                        this.Hide();
                        VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                        frm.ShowDialog();
                        Dispose();

                    }
                }

            }
        }

        private void BtnCambiarUsuarios_Click(object sender, EventArgs e)
        {
            panelIngresoDeContrasena.Visible = false;
            panelUsuarios.Visible = true;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            panelIngresoDeContrasena.Visible = false;
            panelRestaurar_Cuenta.Visible = true;
        }
    }



}


  


