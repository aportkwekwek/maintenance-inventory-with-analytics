﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsonQueueReport
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.itemsonQueueReportDataSet = New WindowsApplication8.itemsonQueueReportDataSet()
        Me.itemsOnQueueReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.itemsOnQueueReportTableAdapter = New WindowsApplication8.itemsonQueueReportDataSetTableAdapters.itemsOnQueueReportTableAdapter()
        CType(Me.itemsonQueueReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemsOnQueueReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "itemsOnQueue"
        ReportDataSource1.Value = Me.itemsOnQueueReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.ItemsonQueueReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1177, 575)
        Me.ReportViewer1.TabIndex = 0
        '
        'itemsonQueueReportDataSet
        '
        Me.itemsonQueueReportDataSet.DataSetName = "itemsonQueueReportDataSet"
        Me.itemsonQueueReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'itemsOnQueueReportBindingSource
        '
        Me.itemsOnQueueReportBindingSource.DataMember = "itemsOnQueueReport"
        Me.itemsOnQueueReportBindingSource.DataSource = Me.itemsonQueueReportDataSet
        '
        'itemsOnQueueReportTableAdapter
        '
        Me.itemsOnQueueReportTableAdapter.ClearBeforeFill = True
        '
        'ItemsonQueueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 575)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ItemsonQueueReport"
        Me.Text = "ItemsonQueueReport"
        CType(Me.itemsonQueueReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemsOnQueueReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents itemsOnQueueReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents itemsonQueueReportDataSet As WindowsApplication8.itemsonQueueReportDataSet
    Friend WithEvents itemsOnQueueReportTableAdapter As WindowsApplication8.itemsonQueueReportDataSetTableAdapters.itemsOnQueueReportTableAdapter
End Class
