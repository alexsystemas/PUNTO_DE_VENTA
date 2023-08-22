namespace PUNTO_DE_VENTA.PRESENT.VENTAS_MENU_PRINCIPAL
{
    partial class Ventas_en_espera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_en_espera));
            this.panel1 = new System.Windows.Forms.Panel();
            this.a = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datalistado_ventas_en_espera = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView_detalle_ventas_restaurar = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha_venta = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_ventas_en_espera)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalle_ventas_restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datalistado_ventas_en_espera);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 697);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_detalle_ventas_restaurar);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 697);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtbusca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 81);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 634;
            this.pictureBox1.TabStop = false;
            // 
            // txtbusca
            // 
            this.txtbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.Location = new System.Drawing.Point(42, 34);
            this.txtbusca.Margin = new System.Windows.Forms.Padding(1);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(222, 26);
            this.txtbusca.TabIndex = 633;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 635;
            this.label1.Text = "Ventas en Espera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datalistado_ventas_en_espera
            // 
            this.datalistado_ventas_en_espera.AllowUserToAddRows = false;
            this.datalistado_ventas_en_espera.AllowUserToResizeRows = false;
            this.datalistado_ventas_en_espera.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.datalistado_ventas_en_espera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado_ventas_en_espera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado_ventas_en_espera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado_ventas_en_espera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_ventas_en_espera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado_ventas_en_espera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistado_ventas_en_espera.EnableHeadersVisualStyles = false;
            this.datalistado_ventas_en_espera.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistado_ventas_en_espera.Location = new System.Drawing.Point(0, 81);
            this.datalistado_ventas_en_espera.Margin = new System.Windows.Forms.Padding(1);
            this.datalistado_ventas_en_espera.Name = "datalistado_ventas_en_espera";
            this.datalistado_ventas_en_espera.ReadOnly = true;
            this.datalistado_ventas_en_espera.RowHeadersVisible = false;
            this.datalistado_ventas_en_espera.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado_ventas_en_espera.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistado_ventas_en_espera.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistado_ventas_en_espera.RowTemplate.Height = 30;
            this.datalistado_ventas_en_espera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_ventas_en_espera.Size = new System.Drawing.Size(277, 616);
            this.datalistado_ventas_en_espera.TabIndex = 38;
            this.datalistado_ventas_en_espera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalistado_ventas_en_espera_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Controls.Add(this.btn_restaurar);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 43);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblFecha_venta);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(844, 38);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView_detalle_ventas_restaurar
            // 
            this.dataGridView_detalle_ventas_restaurar.AllowUserToAddRows = false;
            this.dataGridView_detalle_ventas_restaurar.AllowUserToResizeRows = false;
            this.dataGridView_detalle_ventas_restaurar.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView_detalle_ventas_restaurar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_detalle_ventas_restaurar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_detalle_ventas_restaurar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_detalle_ventas_restaurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detalle_ventas_restaurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.dataGridView_detalle_ventas_restaurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_detalle_ventas_restaurar.EnableHeadersVisualStyles = false;
            this.dataGridView_detalle_ventas_restaurar.GridColor = System.Drawing.Color.YellowGreen;
            this.dataGridView_detalle_ventas_restaurar.Location = new System.Drawing.Point(5, 81);
            this.dataGridView_detalle_ventas_restaurar.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView_detalle_ventas_restaurar.Name = "dataGridView_detalle_ventas_restaurar";
            this.dataGridView_detalle_ventas_restaurar.ReadOnly = true;
            this.dataGridView_detalle_ventas_restaurar.RowHeadersVisible = false;
            this.dataGridView_detalle_ventas_restaurar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_detalle_ventas_restaurar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView_detalle_ventas_restaurar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_detalle_ventas_restaurar.RowTemplate.Height = 30;
            this.dataGridView_detalle_ventas_restaurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_detalle_ventas_restaurar.Size = new System.Drawing.Size(844, 616);
            this.dataGridView_detalle_ventas_restaurar.TabIndex = 39;
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
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 697);
            this.panel6.TabIndex = 40;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_restaurar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btn_restaurar.Image = global::PUNTO_DE_VENTA.Properties.Resources.play;
            this.btn_restaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restaurar.Location = new System.Drawing.Point(0, 6);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(145, 37);
            this.btn_restaurar.TabIndex = 2;
            this.btn_restaurar.Text = "Restaurar Venta";
            this.btn_restaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_restaurar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btn_eliminar.Image = global::PUNTO_DE_VENTA.Properties.Resources.xx;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(145, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(146, 37);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar Venta";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(844, 6);
            this.panel7.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Venta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha_venta
            // 
            this.lblFecha_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_venta.Location = new System.Drawing.Point(139, 0);
            this.lblFecha_venta.Name = "lblFecha_venta";
            this.lblFecha_venta.Size = new System.Drawing.Size(705, 38);
            this.lblFecha_venta.TabIndex = 1;
            this.lblFecha_venta.Text = "--";
            this.lblFecha_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Ventas_en_espera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas_en_espera";
            this.Text = "Ventas_en_espera";
            this.Load += new System.EventHandler(this.Ventas_en_espera_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_ventas_en_espera)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalle_ventas_restaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker a;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.DataGridView datalistado_ventas_en_espera;
        private System.Windows.Forms.DataGridView dataGridView_detalle_ventas_restaurar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblFecha_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}