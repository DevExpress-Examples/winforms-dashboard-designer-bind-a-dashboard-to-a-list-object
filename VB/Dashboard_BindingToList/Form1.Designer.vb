﻿Namespace Dashboard_BindingToList
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
			Me.dashboardViewer1.Size = New System.Drawing.Size(743, 404)
			Me.dashboardViewer1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardViewer1.DataLoading += new DevExpress.DataAccess.DataLoadingEventHandler(this.dashboardViewer1_DataLoading);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(97, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Reload Data"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(743, 404)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Name = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

