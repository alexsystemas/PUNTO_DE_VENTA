namespace PUNTO_DE_VENTA.PRESENT.REPORTES.REPORTES_DE_KARDEX_listo.REPORTE_DE_INVENTARIOS_todos
{
    partial class ReportePVencidos
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.6D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            this.pageFooterSection1.Style.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Top;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.837D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "=Now()";
            // 
            // textBox2
            // 
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Top;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.837D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "REPORTE DE VENCIMIENTO DE PRODUCTOS";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.08D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.347D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.589D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.747D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5D)));
            this.table1.Body.SetCellContent(0, 1, this.textBox15);
            this.table1.Body.SetCellContent(0, 2, this.textBox16);
            this.table1.Body.SetCellContent(0, 3, this.textBox17);
            this.table1.Body.SetCellContent(0, 4, this.textBox3);
            this.table1.Body.SetCellContent(0, 0, this.textBox6);
            tableGroup1.Name = "group3";
            tableGroup1.ReportItem = this.textBox8;
            tableGroup2.Name = "tableGroup1";
            tableGroup2.ReportItem = this.textBox9;
            tableGroup3.Name = "tableGroup2";
            tableGroup3.ReportItem = this.textBox11;
            tableGroup4.Name = "group";
            tableGroup4.ReportItem = this.textBox7;
            tableGroup5.Name = "group2";
            tableGroup5.ReportItem = this.textBox5;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.ColumnGroups.Add(tableGroup5);
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox9,
            this.textBox11,
            this.textBox7,
            this.textBox5,
            this.textBox3,
            this.textBox6,
            this.textBox8});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.table1.Name = "table1";
            tableGroup6.Name = "group1";
            this.table1.RowGroups.Add(tableGroup6);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.764D), Telerik.Reporting.Drawing.Unit.Cm(1.046D));
            // 
            // textBox15
            // 
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.08D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox15.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox15.Style.Font.Bold = false;
            this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox15.StyleName = "";
            this.textBox15.Value = "=Fields.Descripcion";
            // 
            // textBox16
            // 
            this.textBox16.Format = "{0:N2}";
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.347D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox16.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox16.Style.Font.Bold = false;
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox16.StyleName = "";
            this.textBox16.Value = "=Fields.F_vencimiento";
            // 
            // textBox17
            // 
            this.textBox17.Format = "{0:N2}";
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.589D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox17.Style.Font.Bold = false;
            this.textBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox17.StyleName = "";
            this.textBox17.Value = "=Fields.[Dias Vencidos]";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.08D), Telerik.Reporting.Drawing.Unit.Cm(0.546D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox9.Value = "Producto";
            // 
            // textBox11
            // 
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.347D), Telerik.Reporting.Drawing.Unit.Cm(0.546D));
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox11.Value = "Fec Vencimiento";
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.589D), Telerik.Reporting.Drawing.Unit.Cm(0.546D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox7.StyleName = "";
            this.textBox7.Value = "Dias Vencidos";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.747D), Telerik.Reporting.Drawing.Unit.Cm(0.546D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.StyleName = "";
            this.textBox5.Value = "Stock";
            // 
            // textBox3
            // 
            this.textBox3.Format = "{0:N2}";
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.747D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox3.Style.Font.Bold = false;
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.StyleName = "";
            this.textBox3.Value = "=Fields.Stock";
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed;
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.StyleName = "";
            this.textBox6.Value = "=Fields.Codigo";
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(0.546D));
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox8.Value = "Codigo";
            // 
            // ReportePVencidos
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.Name = "ReportePVencidos";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17.837D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        public Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
    }
}