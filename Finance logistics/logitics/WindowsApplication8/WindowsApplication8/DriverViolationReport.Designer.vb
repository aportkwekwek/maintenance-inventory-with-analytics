<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverViolationReport
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
        Me.txtDriverId = New System.Windows.Forms.TextBox()
        Me.txtDriverName = New System.Windows.Forms.TextBox()
        Me.DriverViolationDataSet = New WindowsApplication8.DriverViolationDataSet()
        Me.driverViolationReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.driverViolationReportTableAdapter = New WindowsApplication8.DriverViolationDataSetTableAdapters.driverViolationReportTableAdapter()
        CType(Me.DriverViolationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.driverViolationReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "driverViolation"
        ReportDataSource1.Value = Me.driverViolationReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.DriverViolation.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(743, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDriverId
        '
        Me.txtDriverId.Location = New System.Drawing.Point(575, 109)
        Me.txtDriverId.Name = "txtDriverId"
        Me.txtDriverId.Size = New System.Drawing.Size(115, 22)
        Me.txtDriverId.TabIndex = 1
        '
        'txtDriverName
        '
        Me.txtDriverName.Location = New System.Drawing.Point(575, 157)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(115, 22)
        Me.txtDriverName.TabIndex = 2
        '
        'DriverViolationDataSet
        '
        Me.DriverViolationDataSet.DataSetName = "DriverViolationDataSet"
        Me.DriverViolationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'driverViolationReportBindingSource
        '
        Me.driverViolationReportBindingSource.DataMember = "driverViolationReport"
        Me.driverViolationReportBindingSource.DataSource = Me.DriverViolationDataSet
        '
        'driverViolationReportTableAdapter
        '
        Me.driverViolationReportTableAdapter.ClearBeforeFill = True
        '
        'DriverViolationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 517)
        Me.Controls.Add(Me.txtDriverName)
        Me.Controls.Add(Me.txtDriverId)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "DriverViolationReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriverViolationReport"
        CType(Me.DriverViolationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.driverViolationReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDriverId As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents driverViolationReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverViolationDataSet As WindowsApplication8.DriverViolationDataSet
    Friend WithEvents driverViolationReportTableAdapter As WindowsApplication8.DriverViolationDataSetTableAdapters.driverViolationReportTableAdapter
End Class
