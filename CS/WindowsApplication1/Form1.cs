using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using DevExpress.XtraGrid.Views.Grid.Customization;

using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Scrolling;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        public void InitData() {
            for (int i = 0; i <= 3; i++) {
                dataSet11.DataTable1.Rows.Add(new object[] {  0, i,DateTime.Today, i });
            }
			dataSet11.AcceptChanges();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
         }


		private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e) {
			GridView view = (GridView)sender;
			DataRow row = view.GetDataRow(e.RowHandle);
			if(row.RowState != DataRowState.Unchanged) {
				if(e.Column.UnboundType == DevExpress.Data.UnboundColumnType.Bound && row.HasVersion(DataRowVersion.Original)) {
					if(!Equals(row[e.Column.FieldName, DataRowVersion.Current], row[e.Column.FieldName, DataRowVersion.Original]))
						e.Appearance.BackColor = Color.Red;
				}
			}
		}


    }
}
