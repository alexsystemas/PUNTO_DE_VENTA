namespace PUNTO_DE_VENTA.PRESENT.COMPRAS
{
    partial class HistorialCompras
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.datalistadoCompras = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgDetallecompra = new System.Windows.Forms.DataGridView();
            this.EL = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCompras)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDerecha.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.datalistadoCompras);
            this.pnlIzquierdo.Controls.Add(this.panel3);
            this.pnlIzquierdo.Controls.Add(this.label1);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(891, 1107);
            this.pnlIzquierdo.TabIndex = 9;
            // 
            // datalistadoCompras
            // 
            this.datalistadoCompras.AllowUserToAddRows = false;
            this.datalistadoCompras.AllowUserToResizeRows = false;
            this.datalistadoCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.datalistadoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistadoCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoCompras.EnableHeadersVisualStyles = false;
            this.datalistadoCompras.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistadoCompras.Location = new System.Drawing.Point(0, 186);
            this.datalistadoCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalistadoCompras.Name = "datalistadoCompras";
            this.datalistadoCompras.ReadOnly = true;
            this.datalistadoCompras.RowHeadersVisible = false;
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistadoCompras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistadoCompras.RowTemplate.Height = 30;
            this.datalistadoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoCompras.Size = new System.Drawing.Size(891, 921);
            this.datalistadoCompras.TabIndex = 38;
            this.datalistadoCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoCompras_CellClick);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtbusca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(112)))), ((int)(((byte)(148)))));
            this.panel4.Location = new System.Drawing.Point(128, 81);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 2);
            this.panel4.TabIndex = 635;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 634;
            this.pictureBox1.TabStop = false;
            // 
            // txtbusca
            // 
            this.txtbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.Location = new System.Drawing.Point(125, 17);
            this.txtbusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(703, 53);
            this.txtbusca.TabIndex = 633;
            this.txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(891, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras Realizadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDerecha
            // 
            this.panelDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelDerecha.Controls.Add(this.dgDetallecompra);
            this.panelDerecha.Controls.Add(this.panel1);
            this.panelDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecha.Location = new System.Drawing.Point(0, 0);
            this.panelDerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(2761, 1107);
            this.panelDerecha.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1031);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2761, 76);
            this.panel1.TabIndex = 0;
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.BackColor = System.Drawing.Color.LightGray;
            this.pnlBienvenida.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBienvenida.Location = new System.Drawing.Point(891, 0);
            this.pnlBienvenida.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(16, 1107);
            this.pnlBienvenida.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(936, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1056, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 39);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // dgDetallecompra
            // 
            this.dgDetallecompra.AllowUserToAddRows = false;
            this.dgDetallecompra.AllowUserToDeleteRows = false;
            this.dgDetallecompra.AllowUserToResizeRows = false;
            this.dgDetallecompra.BackgroundColor = System.Drawing.Color.White;
            this.dgDetallecompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetallecompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDetallecompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallecompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallecompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EL});
            this.dgDetallecompra.EnableHeadersVisualStyles = false;
            this.dgDetallecompra.GridColor = System.Drawing.Color.Gainsboro;
            this.dgDetallecompra.Location = new System.Drawing.Point(944, 38);
            this.dgDetallecompra.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgDetallecompra.Name = "dgDetallecompra";
            this.dgDetallecompra.ReadOnly = true;
            this.dgDetallecompra.RowHeadersVisible = false;
            this.dgDetallecompra.RowHeadersWidth = 9;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgDetallecompra.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDetallecompra.RowTemplate.Height = 36;
            this.dgDetallecompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetallecompra.Size = new System.Drawing.Size(1696, 447);
            this.dgDetallecompra.TabIndex = 626;
            // 
            // EL
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.EL.DefaultCellStyle = dataGridViewCellStyle2;
            this.EL.HeaderText = "";
            this.EL.Image = ((System.Drawing.Image)(resources.GetObject("EL.Image")));
            this.EL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EL.Name = "EL";
            this.EL.ReadOnly = true;
            this.EL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EL.ToolTipText = "Opcional \"Supr\" para Eliminar";
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBienvenida);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.panelDerecha);
            this.Name = "HistorialCompras";
            this.Size = new System.Drawing.Size(2761, 1107);
            this.Load += new System.EventHandler(this.HistorialCompras_Load);
            this.pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoCompras)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDerecha.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallecompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.DataGridView datalistadoCompras;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBienvenida;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgDetallecompra;
        private System.Windows.Forms.DataGridViewImageColumn EL;
    }
}
