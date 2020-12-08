<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnnualReport
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
        Me.AnnualReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnnualReportDataSet = New WindowsApplication8.AnnualReportDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AnnualReportTableAdapter = New WindowsApplication8.AnnualReportDataSetTableAdapters.AnnualReportTableAdapter()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        CType(Me.AnnualReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnnualReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnnualReportBindingSource
        '
        Me.AnnualReportBindingSource.DataMember = "AnnualReport"
        Me.AnnualReportBindingSource.DataSource = Me.AnnualReportDataSet
        '
        'AnnualReportDataSet
        '
        Me.AnnualReportDataSet.DataSetName = "AnnualReportDataSet"
        Me.AnnualReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "AnnualReport"
        ReportDataSource1.Value = Me.AnnualReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.AnnualReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(795, 478)
        Me.ReportViewer1.TabIndex = 0
        '
        'AnnualReportTableAdapter
        '
        Me.AnnualReportTableAdapter.ClearBeforeFill = True
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(579, 123)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(177, 22)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(579, 161)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(177, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'AnnualReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 478)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AnnualReport"
        Me.Text = "AnnualReport"
        CType(Me.AnnualReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnnualReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AnnualReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnnualReportDataSet As WindowsApplication8.AnnualReportDataSet
    Friend WithEvents AnnualReportTableAdapter As WindowsApplication8.AnnualReportDataSetTableAdapters.AnnualReportTableAdapter
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
End Class
