namespace PUNTO_DE_VENTA.PRESENT.INGRESOS_VARIOS
{
    partial class IngresosVarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresosVarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chSinConprobante = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlComprobantes = new System.Windows.Forms.Panel();
            this.txtTipo_de_comprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlComprobantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.pnlDetalle.Controls.Add(this.txtfecha);
            this.pnlDetalle.Controls.Add(this.txtDetalle);
            this.pnlDetalle.Controls.Add(this.txtImporte);
            this.pnlDetalle.Controls.Add(this.label4);
            this.pnlDetalle.Controls.Add(this.label3);
            this.pnlDetalle.Controls.Add(this.label2);
            this.pnlDetalle.Location = new System.Drawing.Point(12, 44);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(517, 122);
            this.pnlDetalle.TabIndex = 2;
            // 
            // txtfecha
            // 
            this.txtfecha.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.txtfecha.Location = new System.Drawing.Point(98, 45);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetalle.Location = new System.Drawing.Point(98, 71);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(248, 40);
            this.txtDetalle.TabIndex = 1;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImporte.Location = new System.Drawing.Point(98, 14);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(248, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(30, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto:";
            // 
            // chSinConprobante
            // 
            this.chSinConprobante.AutoSize = true;
            this.chSinConprobante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSinConprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.chSinConprobante.Location = new System.Drawing.Point(17, 172);
            this.chSinConprobante.Name = "chSinConprobante";
            this.chSinConprobante.Size = new System.Drawing.Size(154, 20);
            this.chSinConprobante.TabIndex = 43;
            this.chSinConprobante.Text = "SIN COMPROBANTE";
            this.chSinConprobante.UseVisualStyleBackColor = true;
            this.chSinConprobante.CheckedChanged += new System.EventHandler(this.ChSinConprobante_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarRegistro);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 269);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 44);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardarRegistro.FlatAppearance.BorderSize = 0;
            this.btnGuardarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(69, 38);
            this.btnGuardarRegistro.TabIndex = 4;
            this.btnGuardarRegistro.Text = "Guardar";
            this.btnGuardarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarRegistro.UseVisualStyleBackColor = false;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.BtnGuardarRegistro_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(78, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Volver";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pnlComprobantes
            // 
            this.pnlComprobantes.Controls.Add(this.txtTipo_de_comprobante);
            this.pnlComprobantes.Controls.Add(this.label6);
            this.pnlComprobantes.Controls.Add(this.panel3);
            this.pnlComprobantes.Controls.Add(this.txtNroComprobante);
            this.pnlComprobantes.Controls.Add(this.label5);
            this.pnlComprobantes.Location = new System.Drawing.Point(15, 196);
            this.pnlComprobantes.Name = "pnlComprobantes";
            this.pnlComprobantes.Size = new System.Drawing.Size(511, 71);
            this.pnlComprobantes.TabIndex = 41;
            // 
            // txtTipo_de_comprobante
            // 
            this.txtTipo_de_comprobante.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTipo_de_comprobante.FormattingEnabled = true;
            this.txtTipo_de_comprobante.Items.AddRange(new object[] {
            "SIN COMPROBANTE",
            "FACTURA",
            "TICKET",
            "FACTURA",
            "NOTA",
            "OTRO"});
            this.txtTipo_de_comprobante.Location = new System.Drawing.Point(178, 6);
            this.txtTipo_de_comprobante.Name = "txtTipo_de_comprobante";
            this.txtTipo_de_comprobante.Size = new System.Drawing.Size(164, 21);
            this.txtTipo_de_comprobante.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nro de Comprobante:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 2);
            this.panel3.TabIndex = 3;
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNroComprobante.Location = new System.Drawing.Point(167, 43);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(175, 20);
            this.txtNroComprobante.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(27, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de Comprobante:";
            // 
            // IngresosVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(541, 324);
            this.Controls.Add(this.chSinConprobante);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlComprobantes);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresosVarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresosVarios";
            this.Load += new System.EventHandler(this.IngresosVarios_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlComprobantes.ResumeLayout(false);
            this.pnlComprobantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chSinConprobante;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlComprobantes;
        private System.Windows.Forms.ComboBox txtTipo_de_comprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label label5;
    }
}