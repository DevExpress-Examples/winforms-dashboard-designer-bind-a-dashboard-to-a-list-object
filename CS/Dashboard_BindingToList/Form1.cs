using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.DataAccess;
using DevExpress.XtraEditors;
using System;

namespace Dashboard_BindingToList {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            dashboardViewer1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs;
            dashboardViewer1.CustomizeDashboardTitle += DashboardViewer1_CustomizeDashboardTitle;
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            Dashboard dashboard = new Dashboard();
            DashboardObjectDataSource objectDataSource = new DashboardObjectDataSource("Data Source 1");
            objectDataSource.DataSource = typeof(Data);
            objectDataSource.DataMember = "CreateData";
            dashboard.DataSources.Add(objectDataSource);

            // Creates a Pie dashboard item that displays share of sold units quantity per sales person.
            PieDashboardItem pies = new PieDashboardItem();
            pies.DataSource = dashboard.DataSources[0];
            Dimension salesPersonArgument = new Dimension("SalesPerson");
            Measure quantity = new Measure("Quantity");
            pies.Arguments.Add(salesPersonArgument);
            salesPersonArgument.TopNOptions.Enabled = true; salesPersonArgument.TopNOptions.Count = 3;
            salesPersonArgument.TopNOptions.Measure = quantity;
            pies.Values.Add(quantity);

            // Creates a Grid dashboard item that displays sales persons and corresponding quantities.
            GridDashboardItem grid = new GridDashboardItem();
            grid.DataSource = dashboard.DataSources[0];
            grid.Columns.Add(new GridDimensionColumn(new Dimension("SalesPerson")));
            grid.Columns.Add(new GridMeasureColumn(new Measure("Quantity")));

            dashboard.Items.AddRange(pies, grid);
            dashboardViewer1.Dashboard = dashboard;
        }

        // Handles the DashboardViewer.DataLoading event to provide the dashboard with new data.
        private void dashboardViewer1_DataLoading(object sender, DataLoadingEventArgs e) {
            if (e.DataSourceName == "Data Source 1")
                e.Data = Data.CreateData();
        }

        private void DashboardViewer1_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            DashboardToolbarItem titleButton = new DashboardToolbarItem("Load Data",
                new Action<DashboardToolbarItemClickEventArgs>((args) =>
                {
                    // Reloads data in data sources.
                    dashboardViewer1.ReloadData();
                }));
            titleButton.Caption = "Reload Data";
            e.Items.Add(titleButton);
        }
    }
}
