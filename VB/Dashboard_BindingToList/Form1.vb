Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace Dashboard_BindingToList
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			Dim dashboard As New Dashboard()
			dashboard.AddDataSource("Data Source 1", Data.CreateData())

			' Creates a Pie dashboard item that displays share of sold units quantity per sales person.
			Dim pies As New PieDashboardItem()
			pies.DataSource = dashboard.DataSources(0)
			Dim salesPersonArgument As New Dimension("SalesPerson")
			Dim quantity As New Measure("Quantity")
			pies.Arguments.Add(salesPersonArgument)
			salesPersonArgument.TopNOptions.Enabled = True
			salesPersonArgument.TopNOptions.Count = 3
			salesPersonArgument.TopNOptions.Measure = quantity
			pies.Values.Add(quantity)

			' Creates a Grid dashboard item that displays sales persons and corresponding quantities.
			Dim grid As New GridDashboardItem()
			grid.DataSource = dashboard.DataSources(0)
			grid.Columns.Add(New GridDimensionColumn(New Dimension("SalesPerson")))
			grid.Columns.Add(New GridMeasureColumn(New Measure("Quantity")))

			dashboard.Items.AddRange(pies, grid)
			dashboardViewer1.Dashboard = dashboard
		End Sub

		' Handles the DashboardViewer.DataLoading event to provide the dashboard with new data.
		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DataAccess.DataLoadingEventArgs) Handles dashboardViewer1.DataLoading
			If e.DataSourceName = "Data Source 1" Then
				e.Data = Data.CreateData()
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			' Reloads data in data sources.
			dashboardViewer1.ReloadData()
		End Sub
	End Class
End Namespace
