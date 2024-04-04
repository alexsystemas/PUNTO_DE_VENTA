namespace PUNTO_DE_VENTA.PRESENT.INVENTARIOS_KARDEX
{
    partial class kardex_entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kardex_entrada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAgregarDat = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnletiqueta = new System.Windows.Forms.Panel();
            this.pictboxNotificcion = new System.Windows.Forms.PictureBox();
            this.lblAnuciosNuevosPrecios = new System.Windows.Forms.Label();
            this.DatalistadoProductos = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtcMotivo = new System.Windows.Forms.TextBox();
            this.txtPrecioMayoreo = new System.Windows.Forms.TextBox();
            this.txt_P_Venta = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblcantidadActual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPMay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAgregarDat.SuspendLayout();
            this.pnletiqueta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxNotificcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatalistadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAgregarDat
            // 
            this.panelAgregarDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelAgregarDat.Controls.Add(this.btnReportes);
            this.panelAgregarDat.Controls.Add(this.pnletiqueta);
            this.panelAgregarDat.Controls.Add(this.DatalistadoProductos);
            this.panelAgregarDat.Controls.Add(this.txtFecha);
            this.panelAgregarDat.Controls.Add(this.txtcMotivo);
            this.panelAgregarDat.Controls.Add(this.txtPrecioMayoreo);
            this.panelAgregarDat.Controls.Add(this.txt_P_Venta);
            this.panelAgregarDat.Controls.Add(this.txtCosto);
            this.panelAgregarDat.Controls.Add(this.txtAgregar);
            this.panelAgregarDat.Controls.Add(this.txtBuscarProducto);
            this.panelAgregarDat.Controls.Add(this.lblcantidadActual);
            this.panelAgregarDat.Controls.Add(this.label9);
            this.panelAgregarDat.Controls.Add(this.label8);
            this.panelAgregarDat.Controls.Add(this.lblPMay);
            this.panelAgregarDat.Controls.Add(this.label6);
            this.panelAgregarDat.Controls.Add(this.label5);
            this.panelAgregarDat.Controls.Add(this.label4);
            this.panelAgregarDat.Controls.Add(this.label2);
            this.panelAgregarDat.Controls.Add(this.label1);
            this.panelAgregarDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarDat.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarDat.Name = "panelAgregarDat";
            this.panelAgregarDat.Size = new System.Drawing.Size(521, 445);
            this.panelAgregarDat.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportes.Location = new System.Drawing.Point(138, 322);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(138, 47);
            this.btnReportes.TabIndex = 544;
            this.btnReportes.Text = "Guardar";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // pnletiqueta
            // 
            this.pnletiqueta.BackColor = System.Drawing.Color.Gainsboro;
            this.pnletiqueta.Controls.Add(this.pictboxNotificcion);
            this.pnletiqueta.Controls.Add(this.lblAnuciosNuevosPrecios);
            this.pnletiqueta.Location = new System.Drawing.Point(20, 372);
            this.pnletiqueta.Name = "pnletiqueta";
            this.pnletiqueta.Size = new System.Drawing.Size(457, 50);
            this.pnletiqueta.TabIndex = 491;
            // 
            // pictboxNotificcion
            // 
            this.pictboxNotificcion.Image = global::PUNTO_DE_VENTA.Properties.Resources.informacion;
            this.pictboxNotificcion.Location = new System.Drawing.Point(3, 3);
            this.pictboxNotificcion.Name = "pictboxNotificcion";
            this.pictboxNotificcion.Size = new System.Drawing.Size(42, 44);
            this.pictboxNotificcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxNotificcion.TabIndex = 491;
            this.pictboxNotificcion.TabStop = false;
            this.pictboxNotificcion.Visible = false;
            // 
            // lblAnuciosNuevosPrecios
            // 
            this.lblAnuciosNuevosPrecios.BackColor = System.Drawing.Color.GhostWhite;
            this.lblAnuciosNuevosPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(130)))));
            this.lblAnuciosNuevosPrecios.Location = new System.Drawing.Point(51, 12);
            this.lblAnuciosNuevosPrecios.Name = "lblAnuciosNuevosPrecios";
            this.lblAnuciosNuevosPrecios.Size = new System.Drawing.Size(387, 32);
            this.lblAnuciosNuevosPrecios.TabIndex = 490;
            this.lblAnuciosNuevosPrecios.Text = "label3";
            // 
            // DatalistadoProductos
            // 
            this.DatalistadoProductos.AllowUserToAddRows = false;
            this.DatalistadoProductos.AllowUserToDeleteRows = false;
            this.DatalistadoProductos.AllowUserToResizeRows = false;
            this.DatalistadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.DatalistadoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatalistadoProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatalistadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatalistadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatalistadoProductos.ColumnHeadersVisible = false;
            this.DatalistadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatalistadoProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatalistadoProductos.EnableHeadersVisualStyles = false;
            this.DatalistadoProductos.Location = new System.Drawing.Point(17, 71);
            this.DatalistadoProductos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DatalistadoProductos.Name = "DatalistadoProductos";
            this.DatalistadoProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatalistadoProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatalistadoProductos.RowHeadersVisible = false;
            this.DatalistadoProductos.RowHeadersWidth = 5;
            this.DatalistadoProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.DatalistadoProductos.RowTemplate.Height = 33;
            this.DatalistadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatalistadoProductos.Size = new System.Drawing.Size(460, 350);
            this.DatalistadoProductos.TabIndex = 489;
            this.DatalistadoProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoProductos_CellClick_1);
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.DataPropertyName = "Marcar";
            this.DataGridViewCheckBoxColumn1.HeaderText = "Marcar";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.ReadOnly = true;
            this.DataGridViewCheckBoxColumn1.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(142, 255);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(134, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtcMotivo
            // 
            this.txtcMotivo.Location = new System.Drawing.Point(138, 288);
            this.txtcMotivo.Multiline = true;
            this.txtcMotivo.Name = "txtcMotivo";
            this.txtcMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcMotivo.Size = new System.Drawing.Size(138, 31);
            this.txtcMotivo.TabIndex = 3;
            // 
            // txtPrecioMayoreo
            // 
            this.txtPrecioMayoreo.Location = new System.Drawing.Point(144, 217);
            this.txtPrecioMayoreo.Name = "txtPrecioMayoreo";
            this.txtPrecioMayoreo.Size = new System.Drawing.Size(132, 20);
            this.txtPrecioMayoreo.TabIndex = 3;
            // 
            // txt_P_Venta
            // 
            this.txt_P_Venta.Location = new System.Drawing.Point(144, 182);
            this.txt_P_Venta.Name = "txt_P_Venta";
            this.txt_P_Venta.Size = new System.Drawing.Size(132, 20);
            this.txt_P_Venta.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(144, 149);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(132, 20);
            this.txtCosto.TabIndex = 3;
            this.txtCosto.TextChanged += new System.EventHandler(this.TxtCosto_TextChanged);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(144, 115);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(132, 20);
            this.txtAgregar.TabIndex = 3;
            this.txtAgregar.TextChanged += new System.EventHandler(this.TxtAgregar_TextChanged);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(20, 49);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(306, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.TxtBoxBuscar_TextChanged);
            // 
            // lblcantidadActual
            // 
            this.lblcantidadActual.AutoSize = true;
            this.lblcantidadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadActual.Location = new System.Drawing.Point(160, 85);
            this.lblcantidadActual.Name = "lblcantidadActual";
            this.lblcantidadActual.Size = new System.Drawing.Size(16, 17);
            this.lblcantidadActual.TabIndex = 1;
            this.lblcantidadActual.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Motivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "F de registro:";
            // 
            // lblPMay
            // 
            this.lblPMay.AutoSize = true;
            this.lblPMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMay.Location = new System.Drawing.Point(16, 217);
            this.lblPMay.Name = "lblPMay";
            this.lblPMay.Size = new System.Drawing.Size(122, 20);
            this.lblPMay.TabIndex = 1;
            this.lblPMay.Text = "Precio Mayoreo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Agregar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantiadad Actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Producto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ingeso de Proctos";
            // 
            // kardex_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 445);
            this.Controls.Add(this.panelAgregarDat);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kardex_entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex_Entrada";
            this.Load += new System.EventHandler(this.Kardex_entrada_Load);
            this.panelAgregarDat.ResumeLayout(false);
            this.panelAgregarDat.PerformLayout();
            this.pnletiqueta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictboxNotificcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatalistadoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcMotivo;
        private System.Windows.Forms.TextBox txtPrecioMayoreo;
        private System.Windows.Forms.TextBox txt_P_Venta;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblcantidadActual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPMay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DataGridView DatalistadoProductos;
        private System.Windows.Forms.Panel pnletiqueta;
        private System.Windows.Forms.PictureBox pictboxNotificcion;
        private System.Windows.Forms.Label lblAnuciosNuevosPrecios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnReportes;
    }
}