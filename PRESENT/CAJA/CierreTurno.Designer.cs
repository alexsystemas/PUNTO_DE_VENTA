namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    partial class CierreTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreTurno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldeberiaHaber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldiferencia = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblanuncio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(123, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efectivo esperado en caja:";
            // 
            // lbldeberiaHaber
            // 
            this.lbldeberiaHaber.AutoSize = true;
            this.lbldeberiaHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeberiaHaber.ForeColor = System.Drawing.Color.Maroon;
            this.lbldeberiaHaber.Location = new System.Drawing.Point(195, 150);
            this.lbldeberiaHaber.Name = "lbldeberiaHaber";
            this.lbldeberiaHaber.Size = new System.Drawing.Size(40, 18);
            this.lbldeberiaHaber.TabIndex = 2;
            this.lbldeberiaHaber.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(103, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "¿Cuanto de Efectivo hay en caja?";
            // 
            // txtHay
            // 
            this.txtHay.Location = new System.Drawing.Point(160, 200);
            this.txtHay.Name = "txtHay";
            this.txtHay.Size = new System.Drawing.Size(115, 20);
            this.txtHay.TabIndex = 3;
            this.txtHay.Click += new System.EventHandler(this.TxtHay_Click);
            this.txtHay.TextChanged += new System.EventHandler(this.TxtHay_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(163, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 1);
            this.panel1.TabIndex = 4;
            // 
            // lbldiferencia
            // 
            this.lbldiferencia.AutoSize = true;
            this.lbldiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiferencia.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbldiferencia.Location = new System.Drawing.Point(195, 227);
            this.lbldiferencia.Name = "lbldiferencia";
            this.lbldiferencia.Size = new System.Drawing.Size(40, 18);
            this.lbldiferencia.TabIndex = 2;
            this.lbldiferencia.Text = "0.00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.checkBox1.Location = new System.Drawing.Point(40, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Se enviara a: ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.panel2.Location = new System.Drawing.Point(147, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 1);
            this.panel2.TabIndex = 7;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCobrar.BackgroundImage = global::PUNTO_DE_VENTA.Properties.Resources.gris_azul;
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(146, 292);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(149, 46);
            this.btnCobrar.TabIndex = 647;
            this.btnCobrar.Text = "Cerrar Turno";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(323, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 648;
            this.label1.Text = "Fecha Actual.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 649;
            this.label6.Text = "Usuario Operador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(37, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 649;
            this.label7.Text = "------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.label8.Location = new System.Drawing.Point(342, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 648;
            this.label8.Text = "--/--/--";
            // 
            // lblanuncio
            // 
            this.lblanuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanuncio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.lblanuncio.Location = new System.Drawing.Point(102, 358);
            this.lblanuncio.Name = "lblanuncio";
            this.lblanuncio.Size = new System.Drawing.Size(283, 22);
            this.lblanuncio.TabIndex = 650;
            this.lblanuncio.Text = "...";
            this.lblanuncio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CierreTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 389);
            this.Controls.Add(this.lblanuncio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHay);
            this.Controls.Add(this.lbldiferencia);
            this.Controls.Add(this.lbldeberiaHaber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CierreTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CierreTurno";
            this.Load += new System.EventHandler(this.CierreTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldeberiaHaber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldiferencia;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblanuncio;
    }
}