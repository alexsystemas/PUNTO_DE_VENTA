﻿namespace PUNTO_DE_VENTA.PRESENT.APERTURA_DE_CREDITO
{
    partial class PorCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorCobrar));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCordenadas = new System.Windows.Forms.Panel();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.txtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.pnl_Proveedor = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.uI_ShadowPanel2.SuspendLayout();
            this.pnl_Proveedor.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRegistrar.TabIndex = 654;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(64, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 57);
            this.panel3.TabIndex = 650;
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
            this.datalistado.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.ColumnHeadersVisible = false;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.EnableHeadersVisualStyles = false;
            this.datalistado.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistado.Location = new System.Drawing.Point(406, 48);
            this.datalistado.Margin = new System.Windows.Forms.Padding(1);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersVisible = false;
            this.datalistado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistado.RowTemplate.Height = 30;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(31, 101);
            this.datalistado.TabIndex = 39;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalistado_CellClick);
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(504, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 99);
            this.panel2.TabIndex = 651;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(408, 21);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(29, 26);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "+";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 99);
            this.panel1.TabIndex = 652;
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
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(33, 24);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(369, 20);
            this.txtCliente.TabIndex = 8;
            this.txtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(329, 32);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(105, 20);
            this.txtFechaVencimiento.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 57);
            this.panel4.TabIndex = 653;
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
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(568, 82);
            this.uI_ShadowPanel2.SizeShadow = 10;
            this.uI_ShadowPanel2.TabIndex = 649;
            this.uI_ShadowPanel2.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaRegistro.Location = new System.Drawing.Point(137, 32);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(105, 20);
            this.txtFechaRegistro.TabIndex = 9;
            // 
            // pnl_Proveedor
            // 
            this.pnl_Proveedor.AddControl = null;
            this.pnl_Proveedor.Controls.Add(this.pnlCordenadas);
            this.pnl_Proveedor.Controls.Add(this.datalistado);
            this.pnl_Proveedor.Controls.Add(this.btn_Agregar);
            this.pnl_Proveedor.Controls.Add(this.label3);
            this.pnl_Proveedor.Controls.Add(this.label2);
            this.pnl_Proveedor.Controls.Add(this.txtDetalle);
            this.pnl_Proveedor.Controls.Add(this.txtSaldo);
            this.pnl_Proveedor.Controls.Add(this.txtCliente);
            this.pnl_Proveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Proveedor.Location = new System.Drawing.Point(0, 45);
            this.pnl_Proveedor.Name = "pnl_Proveedor";
            this.pnl_Proveedor.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Proveedor.Size = new System.Drawing.Size(568, 162);
            this.pnl_Proveedor.SizeShadow = 10;
            this.pnl_Proveedor.TabIndex = 648;
            this.pnl_Proveedor.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 45);
            this.label1.TabIndex = 647;
            this.label1.Text = "POR COBRAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PorCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 445);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.pnl_Proveedor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PorCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PorCobrar";
            this.Load += new System.EventHandler(this.PorCobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.pnl_Proveedor.ResumeLayout(false);
            this.pnl_Proveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlCordenadas;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker txtFechaVencimiento;
        private System.Windows.Forms.Panel panel4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.DateTimePicker txtFechaRegistro;
        private UIDC.UI_ShadowPanel pnl_Proveedor;
        private System.Windows.Forms.Label label1;
    }
}