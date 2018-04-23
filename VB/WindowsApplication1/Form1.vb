Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Imports DevExpress.XtraGrid.Views.Grid.Customization

Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Scrolling

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Public Sub InitData()
			For i As Integer = 0 To 3
				dataSet11.DataTable1.Rows.Add(New Object() { 0, i,DateTime.Today, i })
			Next i
			dataSet11.AcceptChanges()

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
		End Sub


		Private Sub gridView2_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridView2.RowCellStyle
			Dim view As GridView = CType(sender, GridView)
			Dim row As DataRow = view.GetDataRow(e.RowHandle)
			If row.RowState <> DataRowState.Unchanged Then
				If e.Column.UnboundType = DevExpress.Data.UnboundColumnType.Bound AndAlso row.HasVersion(DataRowVersion.Original) Then
					If (Not Equals(row(e.Column.FieldName, DataRowVersion.Current), row(e.Column.FieldName, DataRowVersion.Original))) Then
						e.Appearance.BackColor = Color.Red
					End If
				End If
			End If
		End Sub


	End Class
End Namespace
