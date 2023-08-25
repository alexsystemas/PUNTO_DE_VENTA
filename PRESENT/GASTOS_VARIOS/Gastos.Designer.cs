namespace PUNTO_DE_VENTA.PRESENT.GASTOS_VARIOS
{
    partial class Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gastos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlComprobantes = new System.Windows.Forms.Panel();
            this.txtTipo_de_comprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlBuscador_conceptos = new System.Windows.Forms.Panel();
            this.btnNuevoConcepto = new System.Windows.Forms.Button();
            this.txtBuscarConcepto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlConceptos = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGuardarConceptos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtDescripcionConcepto = new System.Windows.Forms.TextBox();
            this.datalistado_conceptos = new System.Windows.Forms.DataGridView();
            this.chSinConprobante = new System.Windows.Forms.CheckBox();
            this.btnGuardarCambiosConceptos = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.pnlComprobantes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlBuscador_conceptos.SuspendLayout();
            this.pnlConceptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_conceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GASTOS(-)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.White;
            this.pnlDetalle.Controls.Add(this.txtfecha);
            this.pnlDetalle.Controls.Add(this.txtDetalle);
            this.pnlDetalle.Controls.Add(this.txtImporte);
            this.pnlDetalle.Controls.Add(this.label4);
            this.pnlDetalle.Controls.Add(this.label3);
            this.pnlDetalle.Controls.Add(this.label2);
            this.pnlDetalle.Location = new System.Drawing.Point(12, 95);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(517, 122);
            this.pnlDetalle.TabIndex = 1;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(98, 45);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(98, 71);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(248, 40);
            this.txtDetalle.TabIndex = 1;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(98, 14);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(248, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(30, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 2);
            this.panel3.TabIndex = 3;
            // 
            // pnlComprobantes
            // 
            this.pnlComprobantes.Controls.Add(this.txtTipo_de_comprobante);
            this.pnlComprobantes.Controls.Add(this.label6);
            this.pnlComprobantes.Controls.Add(this.panel3);
            this.pnlComprobantes.Controls.Add(this.txtNroComprobante);
            this.pnlComprobantes.Controls.Add(this.label5);
            this.pnlComprobantes.Location = new System.Drawing.Point(12, 247);
            this.pnlComprobantes.Name = "pnlComprobantes";
            this.pnlComprobantes.Size = new System.Drawing.Size(511, 71);
            this.pnlComprobantes.TabIndex = 4;
            // 
            // txtTipo_de_comprobante
            // 
            this.txtTipo_de_comprobante.FormattingEnabled = true;
            this.txtTipo_de_comprobante.Items.AddRange(new object[] {
            "SIN COMPROBANTE",
            "FACTURA",
            "TICKET",
            "FACTURA",
            "NOTA",
            "OTRO"});
            this.txtTipo_de_comprobante.Location = new System.Drawing.Point(167, 6);
            this.txtTipo_de_comprobante.Name = "txtTipo_de_comprobante";
            this.txtTipo_de_comprobante.Size = new System.Drawing.Size(175, 21);
            this.txtTipo_de_comprobante.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nro de Comprobante:";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(167, 43);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(175, 20);
            this.txtNroComprobante.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(21, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de Comprobante:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarRegistro);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 320);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 44);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
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
            // pnlBuscador_conceptos
            // 
            this.pnlBuscador_conceptos.Controls.Add(this.btnNuevoConcepto);
            this.pnlBuscador_conceptos.Controls.Add(this.txtBuscarConcepto);
            this.pnlBuscador_conceptos.Controls.Add(this.label8);
            this.pnlBuscador_conceptos.Location = new System.Drawing.Point(14, 44);
            this.pnlBuscador_conceptos.Name = "pnlBuscador_conceptos";
            this.pnlBuscador_conceptos.Size = new System.Drawing.Size(514, 48);
            this.pnlBuscador_conceptos.TabIndex = 6;
            // 
            // btnNuevoConcepto
            // 
            this.btnNuevoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnNuevoConcepto.Location = new System.Drawing.Point(347, 24);
            this.btnNuevoConcepto.Name = "btnNuevoConcepto";
            this.btnNuevoConcepto.Size = new System.Drawing.Size(17, 21);
            this.btnNuevoConcepto.TabIndex = 2;
            this.btnNuevoConcepto.Text = "+";
            this.btnNuevoConcepto.UseVisualStyleBackColor = true;
            this.btnNuevoConcepto.Click += new System.EventHandler(this.BtnNuevoConcepto_Click);
            // 
            // txtBuscarConcepto
            // 
            this.txtBuscarConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarConcepto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarConcepto.Location = new System.Drawing.Point(9, 24);
            this.txtBuscarConcepto.Name = "txtBuscarConcepto";
            this.txtBuscarConcepto.Size = new System.Drawing.Size(335, 21);
            this.txtBuscarConcepto.TabIndex = 1;
            this.txtBuscarConcepto.Text = "Etiqueta";
            this.txtBuscarConcepto.Click += new System.EventHandler(this.TxtConcepto_Click);
            this.txtBuscarConcepto.TextChanged += new System.EventHandler(this.TxtConcepto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar Concepto:";
            // 
            // pnlConceptos
            // 
            this.pnlConceptos.BackColor = System.Drawing.Color.White;
            this.pnlConceptos.Controls.Add(this.panel7);
            this.pnlConceptos.Controls.Add(this.btnGuardarConceptos);
            this.pnlConceptos.Controls.Add(this.label7);
            this.pnlConceptos.Controls.Add(this.btnVolver);
            this.pnlConceptos.Controls.Add(this.txtDescripcionConcepto);
            this.pnlConceptos.Controls.Add(this.btnGuardarCambiosConceptos);
            this.pnlConceptos.Location = new System.Drawing.Point(426, 324);
            this.pnlConceptos.Name = "pnlConceptos";
            this.pnlConceptos.Size = new System.Drawing.Size(49, 10);
            this.pnlConceptos.TabIndex = 1;
            this.pnlConceptos.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel7.Location = new System.Drawing.Point(22, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 1);
            this.panel7.TabIndex = 5;
            // 
            // btnGuardarConceptos
            // 
            this.btnGuardarConceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGuardarConceptos.FlatAppearance.BorderSize = 0;
            this.btnGuardarConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConceptos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnGuardarConceptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarConceptos.Location = new System.Drawing.Point(22, 87);
            this.btnGuardarConceptos.Name = "btnGuardarConceptos";
            this.btnGuardarConceptos.Size = new System.Drawing.Size(147, 38);
            this.btnGuardarConceptos.TabIndex = 4;
            this.btnGuardarConceptos.Text = "Guardar";
            this.btnGuardarConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarConceptos.UseVisualStyleBackColor = false;
            this.btnGuardarConceptos.Click += new System.EventHandler(this.BtnGuardarConceptos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(16, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Etiqueta";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(175, 85);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 38);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txtDescripcionConcepto
            // 
            this.txtDescripcionConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionConcepto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescripcionConcepto.Location = new System.Drawing.Point(19, 50);
            this.txtDescripcionConcepto.Name = "txtDescripcionConcepto";
            this.txtDescripcionConcepto.Size = new System.Drawing.Size(335, 21);
            this.txtDescripcionConcepto.TabIndex = 1;
            // 
            // datalistado_conceptos
            // 
            this.datalistado_conceptos.AllowUserToAddRows = false;
            this.datalistado_conceptos.AllowUserToResizeRows = false;
            this.datalistado_conceptos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.datalistado_conceptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado_conceptos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado_conceptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado_conceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_conceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.datalistado_conceptos.EnableHeadersVisualStyles = false;
            this.datalistado_conceptos.GridColor = System.Drawing.Color.YellowGreen;
            this.datalistado_conceptos.Location = new System.Drawing.Point(400, 322);
            this.datalistado_conceptos.Margin = new System.Windows.Forms.Padding(1);
            this.datalistado_conceptos.Name = "datalistado_conceptos";
            this.datalistado_conceptos.ReadOnly = true;
            this.datalistado_conceptos.RowHeadersVisible = false;
            this.datalistado_conceptos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado_conceptos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.datalistado_conceptos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalistado_conceptos.RowTemplate.Height = 30;
            this.datalistado_conceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_conceptos.Size = new System.Drawing.Size(10, 10);
            this.datalistado_conceptos.TabIndex = 39;
            this.datalistado_conceptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalistado_conceptos_CellClick);
            // 
            // chSinConprobante
            // 
            this.chSinConprobante.AutoSize = true;
            this.chSinConprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chSinConprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.chSinConprobante.Location = new System.Drawing.Point(14, 223);
            this.chSinConprobante.Name = "chSinConprobante";
            this.chSinConprobante.Size = new System.Drawing.Size(197, 24);
            this.chSinConprobante.TabIndex = 40;
            this.chSinConprobante.Text = "SIN COMPROBANTE";
            this.chSinConprobante.UseVisualStyleBackColor = true;
            this.chSinConprobante.CheckedChanged += new System.EventHandler(this.ChSinConprobante_CheckedChanged);
            // 
            // btnGuardarCambiosConceptos
            // 
            this.btnGuardarCambiosConceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGuardarCambiosConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambiosConceptos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.btnGuardarCambiosConceptos.Location = new System.Drawing.Point(22, 85);
            this.btnGuardarCambiosConceptos.Name = "btnGuardarCambiosConceptos";
            this.btnGuardarCambiosConceptos.Size = new System.Drawing.Size(147, 40);
            this.btnGuardarCambiosConceptos.TabIndex = 6;
            this.btnGuardarCambiosConceptos.Text = "Guardar Cambios";
            this.btnGuardarCambiosConceptos.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosConceptos.Click += new System.EventHandler(this.BtnGuardarCambiosConceptos_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PUNTO_DE_VENTA.Properties.Resources.lapiz;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::PUNTO_DE_VENTA.Properties.Resources.lapiz;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 370);
            this.Controls.Add(this.chSinConprobante);
            this.Controls.Add(this.pnlConceptos);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBuscador_conceptos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlComprobantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datalistado_conceptos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Gastos_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.pnlComprobantes.ResumeLayout(false);
            this.pnlComprobantes.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlBuscador_conceptos.ResumeLayout(false);
            this.pnlBuscador_conceptos.PerformLayout();
            this.pnlConceptos.ResumeLayout(false);
            this.pnlConceptos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_conceptos)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlComprobantes;
        private System.Windows.Forms.ComboBox txtTipo_de_comprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlConceptos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnGuardarConceptos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDescripcionConcepto;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlBuscador_conceptos;
        private System.Windows.Forms.Button btnNuevoConcepto;
        private System.Windows.Forms.TextBox txtBuscarConcepto;
        private System.Windows.Forms.DataGridView datalistado_conceptos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chSinConprobante;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnGuardarCambiosConceptos;
    }
}