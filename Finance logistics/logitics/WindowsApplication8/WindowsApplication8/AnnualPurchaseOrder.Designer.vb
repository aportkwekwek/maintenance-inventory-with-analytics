<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnnualPurchaseOrder
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
        Me.txtDatefrom = New System.Windows.Forms.TextBox()
        Me.txtDateto = New System.Windows.Forms.TextBox()
        Me.AnnualPOReportDataSet = New WindowsApplication8.AnnualPOReportDataSet()
        Me.AnnualReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnnualReportTableAdapter = New WindowsApplication8.AnnualPOReportDataSetTableAdapters.AnnualReportTableAdapter()
        CType(Me.AnnualPOReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnnualReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "AnnualPOReport"
        ReportDataSource1.Value = Me.AnnualReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.AnnualPurchaseOrder.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(874, 580)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDatefrom
        '
        Me.txtDatefrom.Location = New System.Drawing.Point(600, 121)
        Me.txtDatefrom.Name = "txtDatefrom"
        Me.txtDatefrom.Size = New System.Drawing.Size(100, 22)
        Me.txtDatefrom.TabIndex = 1
        '
        'txtDateto
        '
        Me.txtDateto.Location = New System.Drawing.Point(600, 169)
        Me.txtDateto.Name = "txtDateto"
        Me.txtDateto.Size = New System.Drawing.Size(100, 22)
        Me.txtDateto.TabIndex = 2
        '
        'AnnualPOReportDataSet
        '
        Me.AnnualPOReportDataSet.DataSetName = "AnnualPOReportDataSet"
        Me.AnnualPOReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnnualReportBindingSource
        '
        Me.AnnualReportBindingSource.DataMember = "AnnualReport"
        Me.AnnualReportBindingSource.DataSource = Me.AnnualPOReportDataSet
        '
        'AnnualReportTableAdapter
        '
        Me.AnnualReportTableAdapter.ClearBeforeFill = True
        '
        'AnnualPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 580)
        Me.Controls.Add(Me.txtDateto)
        Me.Controls.Add(Me.txtDatefrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AnnualPurchaseOrder"
        Me.Text = "AnnualPurchaseOrder"
        CType(Me.AnnualPOReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnnualReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDatefrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateto As System.Windows.Forms.TextBox
    Friend WithEvents AnnualReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnnualPOReportDataSet As WindowsApplication8.AnnualPOReportDataSet
    Friend WithEvents AnnualReportTableAdapter As WindowsApplication8.AnnualPOReportDataSetTableAdapters.AnnualReportTableAdapter
End Class
