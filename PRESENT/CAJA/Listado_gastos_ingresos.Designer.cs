namespace PUNTO_DE_VENTA.PRESENT.CAJA
{
    partial class Listado_gastos_ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_gastos_ingresos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uI_GradientPanel1 = new UIDC.UI_GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datalistadoGastos = new System.Windows.Forms.DataGridView();
            this.datalistadoIngresos = new System.Windows.Forms.DataGridView();
            this.EliminarG = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarI = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.uI_GradientPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 342);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datalistadoGastos);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 342);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datalistadoIngresos);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(453, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 342);
            this.panel3.TabIndex = 2;
            // 
            // uI_GradientPanel1
            // 
            this.uI_GradientPanel1.BackColor = System.Drawing.Color.White;
            this.uI_GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uI_GradientPanel1.Location = new System.Drawing.Point(440, 0);
            this.uI_GradientPanel1.Name = "uI_GradientPanel1";
            this.uI_GradientPanel1.Size = new System.Drawing.Size(13, 342);
            this.uI_GradientPanel1.TabIndex = 3;
            this.uI_GradientPanel1.UIBackColor = System.Drawing.Color.Empty;
            this.uI_GradientPanel1.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.uI_GradientPanel1.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.uI_GradientPanel1.UIForeColor = System.Drawing.Color.Empty;
            this.uI_GradientPanel1.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.uI_GradientPanel1.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.uI_GradientPanel1.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uI_GradientPanel1.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos de Caja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresos de caja";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblGastos);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 61);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 61);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGastos
            // 
            this.lblGastos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(62, 0);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(378, 61);
            this.lblGastos.TabIndex = 1;
            this.lblGastos.Text = "0.00";
            this.lblGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblIngresos);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 61);
            this.panel5.TabIndex = 2;
            // 
            // lblIngresos
            // 
            this.lblIngresos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(62, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(347, 61);
            this.lblIngresos.TabIndex = 1;
            this.lblIngresos.Text = "0.00";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 61);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datalistadoGastos
            // 
            this.datalistadoGastos.AllowUserToAddRows = false;
            this.datalistadoGastos.AllowUserToResizeRows = false;
            this.datalistadoGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.datalistadoGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarG});
            this.datalistadoGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoGastos.EnableHeadersVisualStyles = false;
            this.datalistadoGastos.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistadoGastos.Location = new System.Drawing.Point(0, 41);
            this.datalistadoGastos.Margin = new System.Windows.Forms.Padding(1);
            this.datalistadoGastos.Name = "datalistadoGastos";
            this.datalistadoGastos.ReadOnly = true;
            this.datalistadoGastos.RowHeadersVisible = false;
            this.datalistadoGastos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistadoGastos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistadoGastos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistadoGastos.RowTemplate.Height = 30;
            this.datalistadoGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoGastos.Size = new System.Drawing.Size(440, 240);
            this.datalistadoGastos.TabIndex = 38;
            this.datalistadoGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoGastos_CellClick);
            // 
            // datalistadoIngresos
            // 
            this.datalistadoIngresos.AllowUserToAddRows = false;
            this.datalistadoIngresos.AllowUserToResizeRows = false;
            this.datalistadoIngresos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.datalistadoIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoIngresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoIngresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarI});
            this.datalistadoIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoIngresos.EnableHeadersVisualStyles = false;
            this.datalistadoIngresos.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistadoIngresos.Location = new System.Drawing.Point(0, 41);
            this.datalistadoIngresos.Margin = new System.Windows.Forms.Padding(1);
            this.datalistadoIngresos.Name = "datalistadoIngresos";
            this.datalistadoIngresos.ReadOnly = true;
            this.datalistadoIngresos.RowHeadersVisible = false;
            this.datalistadoIngresos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistadoIngresos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistadoIngresos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistadoIngresos.RowTemplate.Height = 30;
            this.datalistadoIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoIngresos.Size = new System.Drawing.Size(409, 240);
            this.datalistadoIngresos.TabIndex = 39;
            this.datalistadoIngresos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoIngresos_CellClick);
            // 
            // EliminarG
            // 
            this.EliminarG.HeaderText = "";
            this.EliminarG.Image = ((System.Drawing.Image)(resources.GetObject("EliminarG.Image")));
            this.EliminarG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarG.Name = "EliminarG";
            this.EliminarG.ReadOnly = true;
            // 
            // EliminarI
            // 
            this.EliminarI.HeaderText = "";
            this.EliminarI.Image = ((System.Drawing.Image)(resources.GetObject("EliminarI.Image")));
            this.EliminarI.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarI.Name = "EliminarI";
            this.EliminarI.ReadOnly = true;
            // 
            // Listado_gastos_ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 371);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado_gastos_ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_gastos_ingresos";
            this.Load += new System.EventHandler(this.Listado_gastos_ingresos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UIDC.UI_GradientPanel uI_GradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datalistadoIngresos;
        private System.Windows.Forms.DataGridView datalistadoGastos;
        private System.Windows.Forms.DataGridViewImageColumn EliminarG;
        private System.Windows.Forms.DataGridViewImageColumn EliminarI;
    }
}