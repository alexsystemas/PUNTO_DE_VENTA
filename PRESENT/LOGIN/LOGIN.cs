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
using PUNTO_DE_VENTA.LOGIC;
using PUNTO_DE_VENTA.CONEXION;


namespace PUNTO_DE_VENTA.PRESENT
{
    public partial class LOGIN : Form
    {
        int contador;
        int contadorCajas;
        int contador_Movimientos_de_caja;
        public static int idusuariovariable;
        public static int idcajavariable;
        int idUsuarioVerificador;
        string lblSerialPC;
        string lblSerialPCLocal;
        string cajero = "Cajero(si esta autorizado para manejar dinero)";
        string vendedor = "Solo Ventas(no esta autorizado para manejar dinero)";
        string admin = "Administrador (Control total)";
        string lblRol;
        string txtlogin;
        string lblaperturaDeCaja;




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

        private void mostrar_roles()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;

            SqlCommand com = new SqlCommand("mostrar_permisos_por_usuario_ROL_UNICO", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@idusuario", idusuariovariable);
            



            try
            {
                con.Open();
                lblRol = Convert.ToString(com.ExecuteScalar());
                con.Close();


            }
            catch (Exception ex)
            {

            }



        }
        private void miEventoImagen(System.Object sender, EventArgs e)
        {
            txtlogin = Convert.ToString(((PictureBox)sender).Tag);
            panelIngresoDeContrasena.Visible = true;
            panelUsuarios.Visible = false;




        }
        private void mieventoLabel(System.Object sender, EventArgs e)
        {
            txtlogin = ((Label)sender).Text;
            panelIngresoDeContrasena.Visible = true; // el panel lo hacemos visible
            panelUsuarios.Visible = false;// ocultamos el panel
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {

            validar_conexion();
            escalar_paneles();
        }

        void escalar_paneles()
        {
            panelUsuarios.Size = new System.Drawing.Size(794, 618);
            panelIngresoDeContrasena.Size = new System.Drawing.Size(630, 568);
            panelRestaurar_Cuenta.Size = new System.Drawing.Size(553, 223);
            PdCarga.Size = new System.Drawing.Size(175, 153);

            panelIngresoDeContrasena.Visible = false;
            PdCarga.Location = new Point((Width - PdCarga.Width) / 2, (Height - PdCarga.Height) / 2); // centramos el gif en el centro
            panelIngresoDeContrasena.Location = new Point((Width - panelIngresoDeContrasena.Width) / 2, (Height - panelIngresoDeContrasena.Height) / 2);
            panelUsuarios.Location = new Point((Width - panelUsuarios.Width) / 2, (Height - panelUsuarios.Height) / 2);
            panelRestaurar_Cuenta.Location = new Point((Width - panelRestaurar_Cuenta.Width) / 2, (Height - panelRestaurar_Cuenta.Height) / 2);

        }
        private void ListarCierres_de_caja()
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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPC);
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
        private void contar_cierres_de_caja() // creamos un metodo para realizar un conteo
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
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Now);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", idusuariovariable);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", idcajavariable);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void obtener_idusrio()
        {
            try
            {
                idusuariovariable = Convert.ToInt32(dataListado.SelectedCells[1].Value);
            }
            catch
            {

            }
        }
        private void Iniciar_sesion_correcto()
        {
            cargar_Usuarios();
            contar();

            if (contador > 0)
            {
                obtener_idusrio();
                mostrar_roles();
                if (lblRol != cajero)
                {
                    timerValidaRol.Start();
                }
                else if (lblRol == cajero)
                {
                    validar_aperturas_de_caja();
                }


            }
        } 
        private void obtener_usuario_que_aperturo_caja()
        {
            try
            {
                lblusuario_queinicioCaja.Text = datalistado_detalle_cierre_de_caja.SelectedCells[1].Value.ToString();
                lblnombredeCajero.Text = datalistado_detalle_cierre_de_caja.SelectedCells[2].Value.ToString();
            }
            catch
            {

            }
        }
        private void validar_aperturas_de_caja()
        {
            ListarCierres_de_caja();
            contar_cierres_de_caja();
            if (contadorCajas == 0)
            {
                aperturar_detalle_de_cierre_caja();
                lblaperturaDeCaja = "Nuevo*****";
                timerValidaRol.Start();
                
            }
            else
            {
                mostrar_movimientos_de_caja_por_serial_y_usuario();
                contar_movimientos_de_caja_por_usuario();
                if (contador_Movimientos_de_caja==0)
                {
                    obtener_usuario_que_aperturo_caja();
                    MessageBox.Show("Para poder continuar con el Turno de *" + lblnombredeCajero.Text + "* ,Inicia sesion con el Usuario " + lblusuario_queinicioCaja.Text + " -ó-el Usuario *admin*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    lblaperturaDeCaja = "Aperturado";
                    timerValidaRol.Start();
                }
            }
        }
        private void mostrar_movimientos_de_caja_por_serial_y_usuario()
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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblSerialPC);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuariovariable);
                da.Fill(dt);
                datalistado_movimientos_validar.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void contar_movimientos_de_caja_por_usuario()
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
                da.SelectCommand.Parameters.AddWithValue("@password",Bases.Encriptar (txtPassword.Text));
                da.SelectCommand.Parameters.AddWithValue("@login", txtlogin);

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
            enviarCorreo();
        }
       private void enviarCorreo()
        {
            mostrar_usuarios_por_correo();
            richTextBox1.Text = richTextBox1.Text.Replace("@pass", lblResultadoContraseña.Text);//nos devuelve una cadena con dichos requisitos especificados
            Bases.enviarCorreo("pruebasalex022@gmail.com", "ihzhwqqlzrhvxyol", richTextBox1.Text, "Solicitud de Contraseña", txtCorreo.Text, ""); //agregamos el correo y contraseña donde enviara las respuesta requeridas
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
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPC);
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
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("select idUsuario from USUARIO2", CONEXIONMAESTRA.conectar);
                idUsuarioVerificador = Convert.ToInt32( da.ExecuteScalar());
                CONEXIONMAESTRA.cerrar();
                INDICADOR = "CORRECTO";
            }
            catch (Exception )
            {

                INDICADOR = "INCORRECTO";
                idUsuarioVerificador = 0;
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
        private void validar_conexion()
        {
            mostrar_usuarios_registrados();

            if (INDICADOR == "CORRECTO")
            {
                if (idUsuarioVerificador == 0)
                {
                    Dispose();
                    PRESENT.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA frm = new PRESENT.ASISTENTE_DE_ISTALACION_servidor.REGISTRO_DE_EMPRESA();
                    frm.ShowDialog();
                    
                }
                else
                {
                    DIBUJARusuarios();
                }
            }
            if (INDICADOR == "INCORRECTO")
            {
                Dispose();
                PRESENT.ASISTENTE_DE_ISTALACION_servidor.Eleccion_Servidor_o_remoto frm = new PRESENT.ASISTENTE_DE_ISTALACION_servidor.Eleccion_Servidor_o_remoto();
                frm.ShowDialog();
                
            }
            
            try
            {
                Bases.Obtener_serialPC(ref lblSerialPC);
                MOSTRAR_CAJA_POR_SERIAL();
                try
                {
                    idcajavariable =Convert.ToInt32( datalistado_caja.SelectedCells[1].Value);
                    lblcaja.Text = datalistado_caja.SelectedCells[2].Value.ToString();

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
                txtfecha_final_licencia_temporal.Value = Convert.ToDateTime(Bases.Desencriptar(datalistado_licencia_temporal.SelectedCells[3].Value.ToString()));
                lblSerialPCLocal= (Bases.Desencriptar(datalistado_licencia_temporal.SelectedCells[2].Value.ToString()));
                lblEstadoLicencia.Text = (Bases.Desencriptar(datalistado_licencia_temporal.SelectedCells[4].Value.ToString()));
                txtfecha_Inicio_licencia_temporal.Value = Convert.ToDateTime(Bases.Desencriptar(datalistado_licencia_temporal.SelectedCells[5].Value.ToString()));

            }
            catch (Exception ex)
            {


            }
            if (lblEstadoLicencia.Text != "VENCIDO")
            {
                string fechaHOY = Convert.ToString(DateTime.Now);
                DateTime fecha_ddmmyy = Convert.ToDateTime(fechaHOY.Split(' ')[0]);

                if (txtfecha_final_licencia_temporal.Value >= fecha_ddmmyy)
                {

                    if (txtfecha_Inicio_licencia_temporal.Value <= fecha_ddmmyy)
                    {
                        if (lblEstadoLicencia.Text == "?ACTIVO?")
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
                        Dispose();
                        PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                        frm.ShowDialog();
                        
                    }
                }
                else
                {
                    Dispose();
                    PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                    frm.ShowDialog();
                    
                }
            }
            else
            {
                Dispose();
                PRESENT.LICENCIAS_MEMBRESIAS.Membresias frm = new PRESENT.LICENCIAS_MEMBRESIAS.Membresias();
                frm.ShowDialog();
                
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
           
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

                cmd.Parameters.AddWithValue("@id_usuario", idusuariovariable);
                cmd.Parameters.AddWithValue("@Id_serial_Pc", lblSerialPC);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TimerValidaRol_Tick(object sender, EventArgs e)
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
                timerValidaRol.Stop();
                if (lblRol == admin)
                {
                    Dispose();
                    editar_inicio_De_sesion();
                    admin_nivel_dios.DASHBOARD_PRINCIPAL frm = new admin_nivel_dios.DASHBOARD_PRINCIPAL();
                    frm.ShowDialog();
                }
                else
                {
                    if (lblaperturaDeCaja == "Nuevo*****" & lblRol == cajero)
                    {
                        editar_inicio_De_sesion();
                       
                        CAJA.APERTURA_DE_CAJA frm = new CAJA.APERTURA_DE_CAJA();
                        frm.ShowDialog();
                        Dispose();
                    }
                    else if (lblaperturaDeCaja == "Aperturado" & lblRol == cajero)
                    {
                        Dispose();
                        editar_inicio_De_sesion();
                        VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                        frm.ShowDialog();
                       
                    }
                    else if (lblRol == vendedor)
                    {
                        Dispose();
                        editar_inicio_De_sesion();
                        VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                        frm.ShowDialog();
                    }
                }

            }
        }
                    private void BtnCambiarUsuarios_Click(object sender, EventArgs e)
        {
            panelIngresoDeContrasena.Visible = false;
            panelUsuarios.Visible = true;
            txtPassword.Clear();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            panelIngresoDeContrasena.Visible = false;
            panelRestaurar_Cuenta.Visible = true;
        }

    
    }



}


  


