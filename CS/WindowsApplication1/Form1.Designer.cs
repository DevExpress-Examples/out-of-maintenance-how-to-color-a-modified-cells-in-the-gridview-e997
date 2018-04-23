namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11 = new WindowsApplication1.DataSet1();
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colBoolProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStringProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrentDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDoubleProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colBoolProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colStringProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCurrentDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colDoubleProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
			this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colBoolProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colStringProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colCurrentDate1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colDoubleProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBoolProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStringProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrentDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDoubleProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataTable1BindingSource
			// 
			this.dataTable1BindingSource.DataMember = "DataTable1";
			this.dataTable1BindingSource.DataSource = this.dataSet11;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// defaultLookAndFeel1
			// 
			this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.dataTable1BindingSource;
			this.gridControl1.Location = new System.Drawing.Point(12, 12);
			this.gridControl1.MainView = this.gridView2;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(538, 310);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.advBandedGridView1,
            this.layoutView1});
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBoolProperty1,
            this.colStringProperty1,
            this.colCurrentDate1,
            this.colDoubleProperty1});
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
			// 
			// colBoolProperty1
			// 
			this.colBoolProperty1.Caption = "BoolProperty";
			this.colBoolProperty1.FieldName = "BoolProperty";
			this.colBoolProperty1.Name = "colBoolProperty1";
			this.colBoolProperty1.Visible = true;
			this.colBoolProperty1.VisibleIndex = 0;
			// 
			// colStringProperty1
			// 
			this.colStringProperty1.Caption = "StringProperty";
			this.colStringProperty1.FieldName = "StringProperty";
			this.colStringProperty1.Name = "colStringProperty1";
			this.colStringProperty1.Visible = true;
			this.colStringProperty1.VisibleIndex = 1;
			// 
			// colCurrentDate1
			// 
			this.colCurrentDate1.Caption = "CurrentDate";
			this.colCurrentDate1.FieldName = "CurrentDate";
			this.colCurrentDate1.Name = "colCurrentDate1";
			this.colCurrentDate1.Visible = true;
			this.colCurrentDate1.VisibleIndex = 2;
			// 
			// colDoubleProperty1
			// 
			this.colDoubleProperty1.Caption = "DoubleProperty";
			this.colDoubleProperty1.FieldName = "DoubleProperty";
			this.colDoubleProperty1.Name = "colDoubleProperty1";
			this.colDoubleProperty1.Visible = true;
			this.colDoubleProperty1.VisibleIndex = 3;
			// 
			// advBandedGridView1
			// 
			this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
			this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colBoolProperty,
            this.colStringProperty,
            this.colCurrentDate,
            this.colDoubleProperty});
			this.advBandedGridView1.GridControl = this.gridControl1;
			this.advBandedGridView1.Name = "advBandedGridView1";
			this.advBandedGridView1.OptionsSelection.MultiSelect = true;
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "gridBand1";
			this.gridBand1.Columns.Add(this.colBoolProperty);
			this.gridBand1.Columns.Add(this.colStringProperty);
			this.gridBand1.Columns.Add(this.colCurrentDate);
			this.gridBand1.Columns.Add(this.colDoubleProperty);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.Width = 464;
			// 
			// colBoolProperty
			// 
			this.colBoolProperty.Caption = "BoolProperty";
			this.colBoolProperty.FieldName = "BoolProperty";
			this.colBoolProperty.Name = "colBoolProperty";
			this.colBoolProperty.Visible = true;
			this.colBoolProperty.Width = 116;
			// 
			// colStringProperty
			// 
			this.colStringProperty.Caption = "StringProperty";
			this.colStringProperty.FieldName = "StringProperty";
			this.colStringProperty.Name = "colStringProperty";
			this.colStringProperty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
			this.colStringProperty.Visible = true;
			this.colStringProperty.Width = 116;
			// 
			// colCurrentDate
			// 
			this.colCurrentDate.Caption = "CurrentDate";
			this.colCurrentDate.FieldName = "CurrentDate";
			this.colCurrentDate.Name = "colCurrentDate";
			this.colCurrentDate.Visible = true;
			this.colCurrentDate.Width = 116;
			// 
			// colDoubleProperty
			// 
			this.colDoubleProperty.Caption = "DoubleProperty";
			this.colDoubleProperty.FieldName = "DoubleProperty";
			this.colDoubleProperty.Name = "colDoubleProperty";
			this.colDoubleProperty.Visible = true;
			this.colDoubleProperty.Width = 116;
			// 
			// layoutView1
			// 
			this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4});
			this.layoutView1.GridControl = this.gridControl1;
			this.layoutView1.Name = "layoutView1";
			this.layoutView1.TemplateCard = this.layoutViewCard1;
			// 
			// layoutViewColumn1
			// 
			this.layoutViewColumn1.Caption = "BoolProperty";
			this.layoutViewColumn1.FieldName = "BoolProperty";
			this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colBoolProperty1;
			this.layoutViewColumn1.Name = "layoutViewColumn1";
			// 
			// layoutViewField_colBoolProperty1
			// 
			this.layoutViewField_colBoolProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colBoolProperty1.Location = new System.Drawing.Point(0, 0);
			this.layoutViewField_colBoolProperty1.Name = "layoutViewField_colBoolProperty1";
			this.layoutViewField_colBoolProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colBoolProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colBoolProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn2
			// 
			this.layoutViewColumn2.Caption = "StringProperty";
			this.layoutViewColumn2.FieldName = "StringProperty";
			this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colStringProperty1;
			this.layoutViewColumn2.Name = "layoutViewColumn2";
			// 
			// layoutViewField_colStringProperty1
			// 
			this.layoutViewField_colStringProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colStringProperty1.Location = new System.Drawing.Point(0, 27);
			this.layoutViewField_colStringProperty1.Name = "layoutViewField_colStringProperty1";
			this.layoutViewField_colStringProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colStringProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colStringProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn3
			// 
			this.layoutViewColumn3.Caption = "CurrentDate";
			this.layoutViewColumn3.FieldName = "CurrentDate";
			this.layoutViewColumn3.LayoutViewField = this.layoutViewField_colCurrentDate1;
			this.layoutViewColumn3.Name = "layoutViewColumn3";
			// 
			// layoutViewField_colCurrentDate1
			// 
			this.layoutViewField_colCurrentDate1.EditorPreferredWidth = 112;
			this.layoutViewField_colCurrentDate1.Location = new System.Drawing.Point(0, 54);
			this.layoutViewField_colCurrentDate1.Name = "layoutViewField_colCurrentDate1";
			this.layoutViewField_colCurrentDate1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colCurrentDate1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colCurrentDate1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn4
			// 
			this.layoutViewColumn4.Caption = "DoubleProperty";
			this.layoutViewColumn4.FieldName = "DoubleProperty";
			this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colDoubleProperty1;
			this.layoutViewColumn4.Name = "layoutViewColumn4";
			// 
			// layoutViewField_colDoubleProperty1
			// 
			this.layoutViewField_colDoubleProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colDoubleProperty1.Location = new System.Drawing.Point(0, 81);
			this.layoutViewField_colDoubleProperty1.Name = "layoutViewField_colDoubleProperty1";
			this.layoutViewField_colDoubleProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colDoubleProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colDoubleProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewCard1
			// 
			this.layoutViewCard1.CustomizationFormText = "layoutViewCard1";
			this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colBoolProperty1,
            this.layoutViewField_colStringProperty1,
            this.layoutViewField_colCurrentDate1,
            this.layoutViewField_colDoubleProperty1});
			this.layoutViewCard1.Name = "layoutViewCard1";
			this.layoutViewCard1.Text = "layoutViewCard1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 358);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBoolProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStringProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrentDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDoubleProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBoolProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStringProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDoubleProperty;
        private DevExpress.XtraGrid.Columns.GridColumn colBoolProperty1;
        private DevExpress.XtraGrid.Columns.GridColumn colStringProperty1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colDoubleProperty1;
		private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBoolProperty1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colStringProperty1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCurrentDate1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDoubleProperty1;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

