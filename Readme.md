<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580835/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5171)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for WinForms - How to Bind a Dashboard to a List of Objects

This example demonstrates how to bind a dashboard to a list of objects.

The quantity values are provided at runtime. The dashboard data source is added to the [Dashboard.DataSources](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.DataSources) collection on the first load.

Click the **Reload Data** button to call the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/Devexpress.DashboardWin.DashboardViewer.ReloadData.overloads) method. It raises the [DashboardViewer.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataLoading) event and supplies the dashboard with updated data.

![](/images/screenshot.png)

## Files to Review

* [Data.cs](./CS/Dashboard_BindingToList/Data.cs) (VB: [Data.vb](./VB/Dashboard_BindingToList/Data.vb))
* [Form1.cs](./CS/Dashboard_BindingToList/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_BindingToList/Form1.vb))

## Documentation

- [Object Data Source](https://docs.devexpress.com/Dashboard/116522/basic-concepts-and-terminology/data-sources#object-data-source)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-designer-bind-a-dashboard-to-a-list-object&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-designer-bind-a-dashboard-to-a-list-object&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
