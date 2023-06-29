namespace PUNTO_DE_VENTA.MODULOS.LICENCIAS_MEMBRESIAS
{
    partial class Membresias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datalistado_licencia_temporal = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSerialPcLocal = new System.Windows.Forms.TextBox();
            this.TXTFECHA_SISTEMA = new System.Windows.Forms.DateTimePicker();
            this.txtfecha_inicio_licencia = new System.Windows.Forms.DateTimePicker();
            this.txtfecha_final_licencia_temporal = new System.Windows.Forms.DateTimePicker();
            this.lll = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.TextBox();
            this.lblIDSERIAL = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.TextBox();
            this.lblarchivo1 = new System.Windows.Forms.Label();
            this.LBLESTADOLicenciaLocal = new System.Windows.Forms.Label();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelActivando_licencia = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblActivando_licencia = new System.Windows.Forms.Label();
            this.btnActivarManual = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSerialPc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_licencia_temporal)).BeginInit();
            this.panel4.SuspendLayout();
            this.PanelActivando_licencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datalistado_licencia_temporal);
            this.panel1.Controls.Add(this.lblSerialPcLocal);
            this.panel1.Controls.Add(this.TXTFECHA_SISTEMA);
            this.panel1.Controls.Add(this.txtfecha_inicio_licencia);
            this.panel1.Controls.Add(this.txtfecha_final_licencia_temporal);
            this.panel1.Controls.Add(this.lll);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblIDSERIAL);
            this.panel1.Controls.Add(this.lblSerial);
            this.panel1.Controls.Add(this.lblarchivo1);
            this.panel1.Controls.Add(this.LBLESTADOLicenciaLocal);
            this.panel1.Controls.Add(this.lblSoftware);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 292);
            this.panel1.TabIndex = 0;
            // 
            // datalistado_licencia_temporal
            // 
            this.datalistado_licencia_temporal.AllowUserToAddRows = false;
            this.datalistado_licencia_temporal.AllowUserToDeleteRows = false;
            this.datalistado_licencia_temporal.AllowUserToResizeRows = false;
            this.datalistado_licencia_temporal.BackgroundColor = System.Drawing.Color.White;
            this.datalistado_licencia_temporal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_licencia_temporal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado_licencia_temporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_licencia_temporal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistado_licencia_temporal.DefaultCellStyle = dataGridViewCellStyle2;
            this.datalistado_licencia_temporal.Location = new System.Drawing.Point(10, 328);
            this.datalistado_licencia_temporal.Name = "datalistado_licencia_temporal";
            this.datalistado_licencia_temporal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_licencia_temporal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistado_licencia_temporal.RowHeadersVisible = false;
            this.datalistado_licencia_temporal.RowHeadersWidth = 5;
            this.datalistado_licencia_temporal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.datalistado_licencia_temporal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_licencia_temporal.Size = new System.Drawing.Size(139, 69);
            this.datalistado_licencia_temporal.TabIndex = 614;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.DataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // lblSerialPcLocal
            // 
            this.lblSerialPcLocal.Location = new System.Drawing.Point(98, 266);
            this.lblSerialPcLocal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblSerialPcLocal.Name = "lblSerialPcLocal";
            this.lblSerialPcLocal.Size = new System.Drawing.Size(75, 20);
            this.lblSerialPcLocal.TabIndex = 4;
            // 
            // TXTFECHA_SISTEMA
            // 
            this.TXTFECHA_SISTEMA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXTFECHA_SISTEMA.Location = new System.Drawing.Point(95, 157);
            this.TXTFECHA_SISTEMA.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TXTFECHA_SISTEMA.Name = "TXTFECHA_SISTEMA";
            this.TXTFECHA_SISTEMA.Size = new System.Drawing.Size(78, 20);
            this.TXTFECHA_SISTEMA.TabIndex = 3;
            // 
            // txtfecha_inicio_licencia
            // 
            this.txtfecha_inicio_licencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_inicio_licencia.Location = new System.Drawing.Point(95, 179);
            this.txtfecha_inicio_licencia.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtfecha_inicio_licencia.Name = "txtfecha_inicio_licencia";
            this.txtfecha_inicio_licencia.Size = new System.Drawing.Size(78, 20);
            this.txtfecha_inicio_licencia.TabIndex = 3;
            // 
            // txtfecha_final_licencia_temporal
            // 
            this.txtfecha_final_licencia_temporal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_final_licencia_temporal.Location = new System.Drawing.Point(95, 202);
            this.txtfecha_final_licencia_temporal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtfecha_final_licencia_temporal.Name = "txtfecha_final_licencia_temporal";
            this.txtfecha_final_licencia_temporal.Size = new System.Drawing.Size(78, 20);
            this.txtfecha_final_licencia_temporal.TabIndex = 3;
            this.txtfecha_final_licencia_temporal.Value = new System.DateTime(2023, 7, 22, 0, 0, 0, 0);
            // 
            // lll
            // 
            this.lll.Location = new System.Drawing.Point(1, 88);
            this.lll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(189, 20);
            this.lll.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(0, 60);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(189, 20);
            this.lblEstado.TabIndex = 2;
            // 
            // lblIDSERIAL
            // 
            this.lblIDSERIAL.Location = new System.Drawing.Point(5, 27);
            this.lblIDSERIAL.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblIDSERIAL.Name = "lblIDSERIAL";
            this.lblIDSERIAL.Size = new System.Drawing.Size(189, 20);
            this.lblIDSERIAL.TabIndex = 2;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(4, 5);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(189, 20);
            this.lblSerial.TabIndex = 2;
            // 
            // lblarchivo1
            // 
            this.lblarchivo1.AutoSize = true;
            this.lblarchivo1.Location = new System.Drawing.Point(25, 293);
            this.lblarchivo1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblarchivo1.Name = "lblarchivo1";
            this.lblarchivo1.Size = new System.Drawing.Size(43, 13);
            this.lblarchivo1.TabIndex = 1;
            this.lblarchivo1.Text = "cadena";
            // 
            // LBLESTADOLicenciaLocal
            // 
            this.LBLESTADOLicenciaLocal.AutoSize = true;
            this.LBLESTADOLicenciaLocal.Location = new System.Drawing.Point(4, 234);
            this.LBLESTADOLicenciaLocal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LBLESTADOLicenciaLocal.Name = "LBLESTADOLicenciaLocal";
            this.LBLESTADOLicenciaLocal.Size = new System.Drawing.Size(136, 13);
            this.LBLESTADOLicenciaLocal.TabIndex = 1;
            this.LBLESTADOLicenciaLocal.Text = "LBLESTADOLicenciaLocal";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(7, 151);
            this.lblSoftware.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(68, 13);
            this.lblSoftware.TabIndex = 1;
            this.lblSoftware.Text = "SOFTWARE";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 126);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FechaFinal";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(25, 275);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(40, 13);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "lblRuta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 292);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(256, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 49);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PanelActivando_licencia);
            this.panel4.Controls.Add(this.btnActivarManual);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lblSerialPc);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(256, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 243);
            this.panel4.TabIndex = 2;
            // 
            // PanelActivando_licencia
            // 
            this.PanelActivando_licencia.Controls.Add(this.pictureBox2);
            this.PanelActivando_licencia.Controls.Add(this.lblActivando_licencia);
            this.PanelActivando_licencia.Location = new System.Drawing.Point(20, 16);
            this.PanelActivando_licencia.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PanelActivando_licencia.Name = "PanelActivando_licencia";
            this.PanelActivando_licencia.Size = new System.Drawing.Size(136, 177);
            this.PanelActivando_licencia.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PUNTO_DE_VENTA.Properties.Resources.comprobado;
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblActivando_licencia
            // 
            this.lblActivando_licencia.AutoSize = true;
            this.lblActivando_licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivando_licencia.ForeColor = System.Drawing.Color.Gray;
            this.lblActivando_licencia.Location = new System.Drawing.Point(6, 131);
            this.lblActivando_licencia.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblActivando_licencia.Name = "lblActivando_licencia";
            this.lblActivando_licencia.Size = new System.Drawing.Size(132, 20);
            this.lblActivando_licencia.TabIndex = 7;
            this.lblActivando_licencia.Text = "Licencia Activada";
            // 
            // btnActivarManual
            // 
            this.btnActivarManual.BackColor = System.Drawing.Color.White;
            this.btnActivarManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarManual.ForeColor = System.Drawing.Color.Black;
            this.btnActivarManual.Location = new System.Drawing.Point(443, 450);
            this.btnActivarManual.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnActivarManual.Name = "btnActivarManual";
            this.btnActivarManual.Size = new System.Drawing.Size(203, 37);
            this.btnActivarManual.TabIndex = 5;
            this.btnActivarManual.Text = "Activar Licencia Manualmente";
            this.btnActivarManual.UseVisualStyleBackColor = false;
            this.btnActivarManual.Click += new System.EventHandler(this.BtnActivarManual_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(228, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Activar via WEB (requiere Internet)";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(98, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(219, 434);
            this.panel5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 1);
            this.panel5.TabIndex = 4;
            // 
            // lblSerialPc
            // 
            this.lblSerialPc.Location = new System.Drawing.Point(219, 416);
            this.lblSerialPc.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblSerialPc.Name = "lblSerialPc";
            this.lblSerialPc.Size = new System.Drawing.Size(266, 20);
            this.lblSerialPc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(93, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota del pedido*\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(93, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usa este datos cuando se te pida en tu compra (es muy IMPORTANTE)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sigue usando \"VEGA\" por Solo $12 dolares americanos por Todo 1 AÑO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PUNTO_DE_VENTA.Properties.Resources.logo_vega;
            this.pictureBox1.Location = new System.Drawing.Point(212, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dlg
            // 
            this.dlg.FileName = "dlg";
            // 
            // Membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 292);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Membresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Membresias_FormClosing);
            this.Load += new System.EventHandler(this.Membresias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_licencia_temporal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelActivando_licencia.ResumeLayout(false);
            this.PanelActivando_licencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox lblSerialPc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActivarManual;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblarchivo1;
        private System.Windows.Forms.TextBox lll;
        private System.Windows.Forms.TextBox lblEstado;
        private System.Windows.Forms.TextBox lblIDSERIAL;
        private System.Windows.Forms.TextBox lblSerial;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.DateTimePicker txtfecha_inicio_licencia;
        private System.Windows.Forms.DateTimePicker txtfecha_final_licencia_temporal;
        private System.Windows.Forms.TextBox lblSerialPcLocal;
        private System.Windows.Forms.Label LBLESTADOLicenciaLocal;
        public System.Windows.Forms.DataGridView datalistado_licencia_temporal;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DateTimePicker TXTFECHA_SISTEMA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelActivando_licencia;
        private System.Windows.Forms.Label lblActivando_licencia;
    }
}