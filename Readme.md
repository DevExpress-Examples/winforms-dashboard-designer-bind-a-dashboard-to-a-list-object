<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580835/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5171)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-designer-bind-a-dashboard-to-a-list-object&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-designer-bind-a-dashboard-to-a-list-object&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
