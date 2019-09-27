Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess
Imports DevExpress.XtraEditors
Imports System

Namespace Dashboard_BindingToList
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			dashboardViewer1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs
			AddHandler dashboardViewer1.CustomizeDashboardTitle, AddressOf DashboardViewer1_CustomizeDashboardTitle
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			Dim dashboard As New Dashboard()

			Dim dataSource As New DashboardObjectDataSource("Data Source 1")
			AddHandler dashboardViewer1.DataLoading, Sub(s, ev)
				If ev.DataSourceName = "Data Source 1" Then
					ev.Data = Data.CreateData()
				End If
			End Sub
			dashboard.DataSources.Add(dataSource)

			Dim pies As New PieDashboardItem()
			pies.DataSource = dashboard.DataSources(0)
			Dim salesPersonArgument As New Dimension("SalesPerson")
			Dim quantity As New Measure("Quantity")
			pies.Arguments.Add(salesPersonArgument)
			salesPersonArgument.TopNOptions.Enabled = True
			salesPersonArgument.TopNOptions.Count = 3
			salesPersonArgument.TopNOptions.Measure = quantity
			pies.Values.Add(quantity)

			Dim grid As New GridDashboardItem()
			grid.DataSource = dashboard.DataSources(0)
			grid.Columns.Add(New GridDimensionColumn(New Dimension("SalesPerson")))
			grid.Columns.Add(New GridMeasureColumn(New Measure("Quantity")))

			dashboard.Items.AddRange(pies, grid)
			dashboardViewer1.Dashboard = dashboard

		End Sub

		Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim titleButton As DashboardToolbarItem = New DashboardToolbarItem("Load Data", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
				dashboardViewer1.ReloadData()
			End Sub))
			titleButton.Caption = "Reload Data"
			e.Items.Add(titleButton)
		End Sub
	End Class
End Namespace
