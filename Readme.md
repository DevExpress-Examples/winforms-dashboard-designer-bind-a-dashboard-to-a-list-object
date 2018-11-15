<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Dashboard_BindingToList/Data.cs) (VB: [Data.vb](./VB/Dashboard_BindingToList/Data.vb))
* [Form1.cs](./CS/Dashboard_BindingToList/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_BindingToList/Form1.vb))
<!-- default file list end -->
# How to bind a dashboard to a List object


<p>The following example demonstrates how to bind a dashboard to a List object.</p>
<p><br /> In this example, information about the sold units quantity is provided at runtime. The dashboard data source is added to the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_DataSourcestopic">Dashboard.DataSources</a> collection on the first load.</p>
<p>To update the displayed data, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ReloadDatatopic">DashboardViewer.ReloadData</a> method is called. This raises the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_DataLoadingtopic">DashboardViewer.DataLoading</a> event and allows supplying the dashboard with updated data.</p>

<br/>


