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
			Dim objectDataSource As New DashboardObjectDataSource("Data Source 1")
			objectDataSource.DataSource = GetType(Data)
			objectDataSource.DataMember = "CreateData"
			dashboard.DataSources.Add(objectDataSource)

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
		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs) Handles dashboardViewer1.DataLoading
			If e.DataSourceName = "Data Source 1" Then
				e.Data = Data.CreateData()
			End If
		End Sub

		Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim titleButton As DashboardToolbarItem = New DashboardToolbarItem("Load Data", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
					' Reloads data in data sources.
				dashboardViewer1.ReloadData()
			End Sub))
			titleButton.Caption = "Reload Data"
			e.Items.Add(titleButton)
		End Sub
	End Class
End Namespace
