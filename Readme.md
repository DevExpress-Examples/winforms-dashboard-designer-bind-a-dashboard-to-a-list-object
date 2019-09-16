<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Dashboard_BindingToList/Data.cs) (VB: [Data.vb](./VB/Dashboard_BindingToList/Data.vb))
* [Form1.cs](./CS/Dashboard_BindingToList/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_BindingToList/Form1.vb))
<!-- default file list end -->
# How to Bind a Dashboard to a List


This example demonstrates how to bind a dashboard to a List object.

The quantity values are provided at runtime. The dashboard data source is added to the [Dashboard.DataSources](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.DataSources) collection on the first load.

Click the **Reload Data** button to call the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/Devexpress.DashboardWin.DashboardViewer.ReloadData.overloads) method. It raises the [DashboardViewer.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataLoading) event and supplies the dashboard with updated data.

![](/images/screenshot.png)


