﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyPurchaseOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MonthlyReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthlyPurchaseOrderDataSet = New WindowsApplication8.MonthlyPurchaseOrderDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDatefrom = New System.Windows.Forms.TextBox()
        Me.txtDateto = New System.Windows.Forms.TextBox()
        Me.MonthlyReportTableAdapter = New WindowsApplication8.MonthlyPurchaseOrderDataSetTableAdapters.MonthlyReportTableAdapter()
        CType(Me.MonthlyReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyPurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthlyReportBindingSource
        '
        Me.MonthlyReportBindingSource.DataMember = "MonthlyReport"
        Me.MonthlyReportBindingSource.DataSource = Me.MonthlyPurchaseOrderDataSet
        '
        'MonthlyPurchaseOrderDataSet
        '
        Me.MonthlyPurchaseOrderDataSet.DataSetName = "MonthlyPurchaseOrderDataSet"
        Me.MonthlyPurchaseOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MonthlyPurchaseOrder"
        ReportDataSource1.Value = Me.MonthlyReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.MonthlyPurchaseOrder.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(708, 502)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDatefrom
        '
        Me.txtDatefrom.Location = New System.Drawing.Point(521, 106)
        Me.txtDatefrom.Name = "txtDatefrom"
        Me.txtDatefrom.Size = New System.Drawing.Size(100, 22)
        Me.txtDatefrom.TabIndex = 1
        Me.txtDatefrom.Visible = False
        '
        'txtDateto
        '
        Me.txtDateto.Location = New System.Drawing.Point(521, 159)
        Me.txtDateto.Name = "txtDateto"
        Me.txtDateto.Size = New System.Drawing.Size(100, 22)
        Me.txtDateto.TabIndex = 2
        Me.txtDateto.Visible = False
        '
        'MonthlyReportTableAdapter
        '
        Me.MonthlyReportTableAdapter.ClearBeforeFill = True
        '
        'MonthlyPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 502)
        Me.Controls.Add(Me.txtDateto)
        Me.Controls.Add(Me.txtDatefrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "MonthlyPurchaseOrder"
        Me.Text = "MonthlyPurchaseOrder"
        CType(Me.MonthlyReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyPurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDatefrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateto As System.Windows.Forms.TextBox
    Friend WithEvents MonthlyReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyPurchaseOrderDataSet As WindowsApplication8.MonthlyPurchaseOrderDataSet
    Friend WithEvents MonthlyReportTableAdapter As WindowsApplication8.MonthlyPurchaseOrderDataSetTableAdapters.MonthlyReportTableAdapter
End Class
