namespace PUNTO_DE_VENTA.PRESENT.APERTURA_DE_CREDITO
{
    partial class PorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorPagar));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Proveedor = new UIDC.UI_ShadowPanel();
            this.pnlCordenadas = new System.Windows.Forms.Panel();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.txtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pnl_Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.uI_ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "POR PAGAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Proveedor
            // 
            this.pnl_Proveedor.AddControl = null;
            this.pnl_Proveedor.Controls.Add(this.pnlCordenadas);
            this.pnl_Proveedor.Controls.Add(this.datalistado);
            this.pnl_Proveedor.Controls.Add(this.button1);
            this.pnl_Proveedor.Controls.Add(this.label3);
            this.pnl_Proveedor.Controls.Add(this.label2);
            this.pnl_Proveedor.Controls.Add(this.txtDetalle);
            this.pnl_Proveedor.Controls.Add(this.txtSaldo);
            this.pnl_Proveedor.Controls.Add(this.txtProveedor);
            this.pnl_Proveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Proveedor.Location = new System.Drawing.Point(0, 45);
            this.pnl_Proveedor.Name = "pnl_Proveedor";
            this.pnl_Proveedor.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Proveedor.Size = new System.Drawing.Size(480, 162);
            this.pnl_Proveedor.SizeShadow = 10;
            this.pnl_Proveedor.TabIndex = 1;
            this.pnl_Proveedor.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // pnlCordenadas
            // 
            this.pnlCordenadas.Location = new System.Drawing.Point(33, 48);
            this.pnlCordenadas.Name = "pnlCordenadas";
            this.pnlCordenadas.Size = new System.Drawing.Size(10, 10);
            this.pnlCordenadas.TabIndex = 40;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToResizeRows = false;
            this.datalistado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.ColumnHeadersVisible = false;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.EnableHeadersVisualStyles = false;
            this.datalistado.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistado.Location = new System.Drawing.Point(427, 48);
            this.datalistado.Margin = new System.Windows.Forms.Padding(1);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersVisible = false;
            this.datalistado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistado.RowTemplate.Height = 30;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(10, 101);
            this.datalistado.TabIndex = 39;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalistado_CellClick);
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalistado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saldo:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(160, 108);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(242, 41);
            this.txtDetalle.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(160, 80);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(242, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(33, 24);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(369, 20);
            this.txtProveedor.TabIndex = 8;
            this.txtProveedor.TextChanged += new System.EventHandler(this.TxtProveedor_TextChanged);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.AddControl = null;
            this.uI_ShadowPanel2.Controls.Add(this.txtFechaVencimiento);
            this.uI_ShadowPanel2.Controls.Add(this.txtFechaRegistro);
            this.uI_ShadowPanel2.Controls.Add(this.label5);
            this.uI_ShadowPanel2.Controls.Add(this.label4);
            this.uI_ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(0, 207);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(480, 82);
            this.uI_ShadowPanel2.SizeShadow = 10;
            this.uI_ShadowPanel2.TabIndex = 2;
            this.uI_ShadowPanel2.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(329, 32);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(105, 20);
            this.txtFechaVencimiento.TabIndex = 9;
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaRegistro.Location = new System.Drawing.Point(137, 32);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(105, 20);
            this.txtFechaRegistro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "F. Venc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "F. de Reg:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 106);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(416, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 39);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(64, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 57);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(64, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 10);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = global::PUNTO_DE_VENTA.Properties.Resources.gris_azul;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(178, 338);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(186, 55);
            this.btnRegistrar.TabIndex = 646;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // PorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 395);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.pnl_Proveedor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PorPagar";
            this.Load += new System.EventHandler(this.PorPagar_Load);
            this.pnl_Proveedor.ResumeLayout(false);
            this.pnl_Proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UIDC.UI_ShadowPanel pnl_Proveedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtProveedor;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.DateTimePicker txtFechaVencimiento;
        private System.Windows.Forms.DateTimePicker txtFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel pnlCordenadas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}