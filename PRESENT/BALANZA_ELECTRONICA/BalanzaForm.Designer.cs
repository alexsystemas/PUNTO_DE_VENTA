namespace PUNTO_DE_VENTA.PRESENT.BALANZA_ELECTRONICA
{
    partial class BalanzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanzaForm));
            this.btnEnviar = new System.Windows.Forms.Panel();
            this.btneviarr = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListaPuertos = new System.Windows.Forms.ComboBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListarPort = new System.Windows.Forms.Label();
            this.puertos = new System.IO.Ports.SerialPort(this.components);
            this.btnEnviar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEnviar.Controls.Add(this.btneviarr);
            this.btnEnviar.Controls.Add(this.lblEstado);
            this.btnEnviar.Controls.Add(this.button4);
            this.btnEnviar.Controls.Add(this.button3);
            this.btnEnviar.Controls.Add(this.button2);
            this.btnEnviar.Controls.Add(this.ListaPuertos);
            this.btnEnviar.Controls.Add(this.btnProbar);
            this.btnEnviar.Controls.Add(this.btn1);
            this.btnEnviar.Controls.Add(this.panel3);
            this.btnEnviar.Controls.Add(this.label6);
            this.btnEnviar.Controls.Add(this.txtResultado);
            this.btnEnviar.Controls.Add(this.label5);
            this.btnEnviar.Controls.Add(this.label4);
            this.btnEnviar.Controls.Add(this.panel2);
            this.btnEnviar.Controls.Add(this.label3);
            this.btnEnviar.Controls.Add(this.label2);
            this.btnEnviar.Controls.Add(this.pictureBox1);
            this.btnEnviar.Controls.Add(this.ListarPort);
            this.btnEnviar.Location = new System.Drawing.Point(5, 29);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(2096, 909);
            this.btnEnviar.TabIndex = 0;
            // 
            // btneviarr
            // 
            this.btneviarr.Location = new System.Drawing.Point(1235, 708);
            this.btneviarr.Name = "btneviarr";
            this.btneviarr.Size = new System.Drawing.Size(310, 81);
            this.btneviarr.TabIndex = 48;
            this.btneviarr.Text = "enviar";
            this.btneviarr.UseVisualStyleBackColor = true;
            this.btneviarr.Click += new System.EventHandler(this.Btneviarr_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.lblEstado.Location = new System.Drawing.Point(824, 823);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(167, 39);
            this.lblEstado.TabIndex = 47;
            this.lblEstado.Text = "lblEstado";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(1751, 645);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 148);
            this.button4.TabIndex = 46;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1751, 400);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 148);
            this.button3.TabIndex = 45;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1751, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 148);
            this.button2.TabIndex = 44;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ListaPuertos
            // 
            this.ListaPuertos.FormattingEnabled = true;
            this.ListaPuertos.Location = new System.Drawing.Point(1213, 212);
            this.ListaPuertos.Name = "ListaPuertos";
            this.ListaPuertos.Size = new System.Drawing.Size(332, 39);
            this.ListaPuertos.TabIndex = 43;
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.Transparent;
            this.btnProbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProbar.BackgroundImage")));
            this.btnProbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProbar.FlatAppearance.BorderSize = 0;
            this.btnProbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.Color.Transparent;
            this.btnProbar.Location = new System.Drawing.Point(877, 443);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(0);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(227, 80);
            this.btnProbar.TabIndex = 42;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.BtnProbar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(877, 708);
            this.btn1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(256, 81);
            this.btn1.TabIndex = 41;
            this.btn1.Text = "Guardar";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(720, 546);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 2);
            this.panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(722, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(701, 78);
            this.label6.TabIndex = 8;
            this.label6.Text = "Paso 3:  Si ya reconoce el peso, entonces \r\nde click a \"Guardar\"";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(1213, 468);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(332, 38);
            this.txtResultado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(1097, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(722, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(704, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Paso 2:  Elije un Puerto y de click a Probar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(720, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 2);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(1071, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(707, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paso 1:  Conecte su balanza y seleccione un Puerto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PUNTO_DE_VENTA.Properties.Resources._6030;
            this.pictureBox1.Location = new System.Drawing.Point(27, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 792);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ListarPort
            // 
            this.ListarPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListarPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(191)))), ((int)(((byte)(197)))));
            this.ListarPort.Location = new System.Drawing.Point(0, 0);
            this.ListarPort.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ListarPort.Name = "ListarPort";
            this.ListarPort.Size = new System.Drawing.Size(2096, 103);
            this.ListarPort.TabIndex = 0;
            this.ListarPort.Text = "Configurar Balanza Electronica";
            // 
            // puertos
            // 
            this.puertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puertos_DataReceived);
            // 
            // BalanzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "BalanzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanzaForm";
            this.Load += new System.EventHandler(this.BalanzaForm_Load);
            this.btnEnviar.ResumeLayout(false);
            this.btnEnviar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnEnviar;
        private System.Windows.Forms.Label ListarPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ComboBox ListaPuertos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort puertos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btneviarr;
    }
}