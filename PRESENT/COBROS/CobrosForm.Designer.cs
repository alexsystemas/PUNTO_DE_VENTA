namespace PUNTO_DE_VENTA.PRESENT.COBROS
{
    partial class CobrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobrosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlGlobal = new UIDC.UI_ShadowPanel();
            this.pnlregistros = new System.Windows.Forms.Panel();
            this.pnlMovimientos = new System.Windows.Forms.Panel();
            this.datalistadoMovimientos = new System.Windows.Forms.DataGridView();
            this.Eli = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.dataListadoHitorial = new System.Windows.Forms.DataGridView();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlM = new System.Windows.Forms.Panel();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlH = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.txtTotal_Saldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.datalistadoClientes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClienteSolicitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlGlobal.SuspendLayout();
            this.pnlregistros.SuspendLayout();
            this.pnlMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoMovimientos)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoHitorial)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 565);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 250);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 565);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlGlobal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 565);
            this.panel2.TabIndex = 3;
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.AddControl = null;
            this.pnlGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlGlobal.Controls.Add(this.pnlregistros);
            this.pnlGlobal.Controls.Add(this.datalistadoClientes);
            this.pnlGlobal.Controls.Add(this.pictureBox1);
            this.pnlGlobal.Controls.Add(this.txtClienteSolicitante);
            this.pnlGlobal.Controls.Add(this.label1);
            this.pnlGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGlobal.Location = new System.Drawing.Point(0, 0);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGlobal.Size = new System.Drawing.Size(863, 565);
            this.pnlGlobal.SizeShadow = 10;
            this.pnlGlobal.TabIndex = 0;
            this.pnlGlobal.TypeShadowPanel = UIDC.UI_ShadowPanel.ShadowsPanel.Center;
            // 
            // pnlregistros
            // 
            this.pnlregistros.Controls.Add(this.label2);
            this.pnlregistros.Controls.Add(this.panel5);
            this.pnlregistros.Controls.Add(this.txtTotal_Saldo);
            this.pnlregistros.Controls.Add(this.label3);
            this.pnlregistros.Controls.Add(this.panel4);
            this.pnlregistros.Controls.Add(this.btnAbonar);
            this.pnlregistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlregistros.Location = new System.Drawing.Point(10, 79);
            this.pnlregistros.Name = "pnlregistros";
            this.pnlregistros.Size = new System.Drawing.Size(843, 346);
            this.pnlregistros.TabIndex = 651;
            this.pnlregistros.Visible = false;
            // 
            // pnlMovimientos
            // 
            this.pnlMovimientos.Controls.Add(this.datalistadoMovimientos);
            this.pnlMovimientos.Location = new System.Drawing.Point(382, 47);
            this.pnlMovimientos.Name = "pnlMovimientos";
            this.pnlMovimientos.Size = new System.Drawing.Size(205, 114);
            this.pnlMovimientos.TabIndex = 2;
            // 
            // datalistadoMovimientos
            // 
            this.datalistadoMovimientos.AllowUserToAddRows = false;
            this.datalistadoMovimientos.AllowUserToDeleteRows = false;
            this.datalistadoMovimientos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistadoMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.datalistadoMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eli});
            this.datalistadoMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoMovimientos.EnableHeadersVisualStyles = false;
            this.datalistadoMovimientos.Location = new System.Drawing.Point(0, 0);
            this.datalistadoMovimientos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.datalistadoMovimientos.Name = "datalistadoMovimientos";
            this.datalistadoMovimientos.ReadOnly = true;
            this.datalistadoMovimientos.RowHeadersVisible = false;
            this.datalistadoMovimientos.RowHeadersWidth = 9;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.datalistadoMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datalistadoMovimientos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datalistadoMovimientos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datalistadoMovimientos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.datalistadoMovimientos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoMovimientos.RowTemplate.Height = 40;
            this.datalistadoMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoMovimientos.Size = new System.Drawing.Size(205, 114);
            this.datalistadoMovimientos.TabIndex = 372;
            this.datalistadoMovimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoMovimientos_CellClick);
            // 
            // Eli
            // 
            this.Eli.DataPropertyName = "Eli";
            this.Eli.HeaderText = "";
            this.Eli.Image = global::PUNTO_DE_VENTA.Properties.Resources.x1;
            this.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eli.Name = "Eli";
            this.Eli.ReadOnly = true;
            this.Eli.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 648;
            this.label2.Text = "Estado de Cuenta";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlMovimientos);
            this.panel5.Controls.Add(this.pnlHistorial);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(6, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(817, 190);
            this.panel5.TabIndex = 650;
            // 
            // pnlHistorial
            // 
            this.pnlHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlHistorial.Controls.Add(this.dataListadoHitorial);
            this.pnlHistorial.Location = new System.Drawing.Point(14, 47);
            this.pnlHistorial.Name = "pnlHistorial";
            this.pnlHistorial.Size = new System.Drawing.Size(216, 127);
            this.pnlHistorial.TabIndex = 1;
            // 
            // dataListadoHitorial
            // 
            this.dataListadoHitorial.AllowUserToAddRows = false;
            this.dataListadoHitorial.AllowUserToDeleteRows = false;
            this.dataListadoHitorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataListadoHitorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListadoHitorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataListadoHitorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListadoHitorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListadoHitorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListadoHitorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoHitorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar1});
            this.dataListadoHitorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListadoHitorial.EnableHeadersVisualStyles = false;
            this.dataListadoHitorial.Location = new System.Drawing.Point(0, 0);
            this.dataListadoHitorial.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataListadoHitorial.Name = "dataListadoHitorial";
            this.dataListadoHitorial.ReadOnly = true;
            this.dataListadoHitorial.RowHeadersVisible = false;
            this.dataListadoHitorial.RowHeadersWidth = 9;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dataListadoHitorial.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListadoHitorial.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataListadoHitorial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataListadoHitorial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dataListadoHitorial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataListadoHitorial.RowTemplate.Height = 40;
            this.dataListadoHitorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoHitorial.Size = new System.Drawing.Size(216, 127);
            this.dataListadoHitorial.TabIndex = 372;
            // 
            // Eliminar1
            // 
            this.Eliminar1.HeaderText = "Eliminar";
            this.Eliminar1.Name = "Eliminar1";
            this.Eliminar1.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(817, 33);
            this.panel6.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnlM);
            this.panel9.Controls.Add(this.btnMovimientos);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(95, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(118, 33);
            this.panel9.TabIndex = 1;
            // 
            // pnlM
            // 
            this.pnlM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.pnlM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlM.Location = new System.Drawing.Point(0, 29);
            this.pnlM.Name = "pnlM";
            this.pnlM.Size = new System.Drawing.Size(118, 4);
            this.pnlM.TabIndex = 1;
            this.pnlM.Visible = false;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Location = new System.Drawing.Point(0, 0);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(118, 33);
            this.btnMovimientos.TabIndex = 0;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.BtnMovimientos_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlH);
            this.panel7.Controls.Add(this.btnHistorial);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(95, 33);
            this.panel7.TabIndex = 1;
            // 
            // pnlH
            // 
            this.pnlH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.pnlH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlH.Location = new System.Drawing.Point(0, 29);
            this.pnlH.Name = "pnlH";
            this.pnlH.Size = new System.Drawing.Size(95, 4);
            this.pnlH.TabIndex = 1;
            this.pnlH.Visible = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(0, 0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(95, 33);
            this.btnHistorial.TabIndex = 0;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // txtTotal_Saldo
            // 
            this.txtTotal_Saldo.AutoSize = true;
            this.txtTotal_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_Saldo.Location = new System.Drawing.Point(82, 24);
            this.txtTotal_Saldo.Name = "txtTotal_Saldo";
            this.txtTotal_Saldo.Size = new System.Drawing.Size(27, 29);
            this.txtTotal_Saldo.TabIndex = 649;
            this.txtTotal_Saldo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 649;
            this.label3.Text = "Saldo:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 1);
            this.panel4.TabIndex = 647;
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.Transparent;
            this.btnAbonar.BackgroundImage = global::PUNTO_DE_VENTA.Properties.Resources.gris_azul;
            this.btnAbonar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.Color.White;
            this.btnAbonar.Location = new System.Drawing.Point(9, 260);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(100, 34);
            this.btnAbonar.TabIndex = 646;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.BtnAbonar_Click);
            // 
            // datalistadoClientes
            // 
            this.datalistadoClientes.AllowUserToAddRows = false;
            this.datalistadoClientes.AllowUserToDeleteRows = false;
            this.datalistadoClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datalistadoClientes.BackgroundColor = System.Drawing.Color.LightGray;
            this.datalistadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoClientes.ColumnHeadersVisible = false;
            this.datalistadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistadoClientes.EnableHeadersVisualStyles = false;
            this.datalistadoClientes.Location = new System.Drawing.Point(422, 22);
            this.datalistadoClientes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.datalistadoClientes.Name = "datalistadoClientes";
            this.datalistadoClientes.ReadOnly = true;
            this.datalistadoClientes.RowHeadersVisible = false;
            this.datalistadoClientes.RowHeadersWidth = 9;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.datalistadoClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datalistadoClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.datalistadoClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.datalistadoClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.datalistadoClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoClientes.RowTemplate.Height = 40;
            this.datalistadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoClientes.Size = new System.Drawing.Size(399, 51);
            this.datalistadoClientes.TabIndex = 371;
            this.datalistadoClientes.Visible = false;
            this.datalistadoClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatalistadoClientes_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PUNTO_DE_VENTA.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(388, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtClienteSolicitante
            // 
            this.txtClienteSolicitante.ForeColor = System.Drawing.Color.Gray;
            this.txtClienteSolicitante.Location = new System.Drawing.Point(10, 50);
            this.txtClienteSolicitante.Name = "txtClienteSolicitante";
            this.txtClienteSolicitante.Size = new System.Drawing.Size(372, 23);
            this.txtClienteSolicitante.TabIndex = 9;
            this.txtClienteSolicitante.Text = "Buscar Cliente / deudor";
            this.txtClienteSolicitante.Click += new System.EventHandler(this.TxtClienteSolicitante_Click);
            this.txtClienteSolicitante.TextChanged += new System.EventHandler(this.TxtClienteSolicitante_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(843, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "COBROS";
            // 
            // CobrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CobrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CobrosForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlGlobal.ResumeLayout(false);
            this.pnlGlobal.PerformLayout();
            this.pnlregistros.ResumeLayout(false);
            this.pnlregistros.PerformLayout();
            this.pnlMovimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoMovimientos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnlHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoHitorial)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private UIDC.UI_ShadowPanel pnlGlobal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtClienteSolicitante;
        internal System.Windows.Forms.DataGridView datalistadoClientes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnlM;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlH;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label txtTotal_Saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Panel pnlMovimientos;
        internal System.Windows.Forms.DataGridView datalistadoMovimientos;
        private System.Windows.Forms.DataGridViewImageColumn Eli;
        private System.Windows.Forms.Panel pnlHistorial;
        internal System.Windows.Forms.DataGridView dataListadoHitorial;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel pnlregistros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar1;
    }
}