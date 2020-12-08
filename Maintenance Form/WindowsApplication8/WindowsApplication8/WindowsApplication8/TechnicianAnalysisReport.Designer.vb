<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechnicianAnalysisReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtJobDescription = New System.Windows.Forms.TextBox()
        Me.TechnicianAnalysisDataSet = New WindowsApplication8.TechnicianAnalysisDataSet()
        Me.TechnicianAnalysisForReportingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechnicianAnalysisForReportingTableAdapter = New WindowsApplication8.TechnicianAnalysisDataSetTableAdapters.TechnicianAnalysisForReportingTableAdapter()
        CType(Me.TechnicianAnalysisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnicianAnalysisForReportingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "technicianAnalysis"
        ReportDataSource2.Value = Me.TechnicianAnalysisForReportingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.TechAnalysis.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(736, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtJobDescription
        '
        Me.txtJobDescription.Location = New System.Drawing.Point(580, 114)
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.Size = New System.Drawing.Size(100, 22)
        Me.txtJobDescription.TabIndex = 1
        Me.txtJobDescription.Visible = False
        '
        'TechnicianAnalysisDataSet
        '
        Me.TechnicianAnalysisDataSet.DataSetName = "TechnicianAnalysisDataSet"
        Me.TechnicianAnalysisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TechnicianAnalysisForReportingBindingSource
        '
        Me.TechnicianAnalysisForReportingBindingSource.DataMember = "TechnicianAnalysisForReporting"
        Me.TechnicianAnalysisForReportingBindingSource.DataSource = Me.TechnicianAnalysisDataSet
        '
        'TechnicianAnalysisForReportingTableAdapter
        '
        Me.TechnicianAnalysisForReportingTableAdapter.ClearBeforeFill = True
        '
        'TechnicianAnalysisReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 517)
        Me.Controls.Add(Me.txtJobDescription)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TechnicianAnalysisReport"
        Me.Text = "TechnicianAnalysisReport"
        CType(Me.TechnicianAnalysisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnicianAnalysisForReportingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtJobDescription As System.Windows.Forms.TextBox
    Friend WithEvents TechnicianAnalysisForReportingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TechnicianAnalysisDataSet As WindowsApplication8.TechnicianAnalysisDataSet
    Friend WithEvents TechnicianAnalysisForReportingTableAdapter As WindowsApplication8.TechnicianAnalysisDataSetTableAdapters.TechnicianAnalysisForReportingTableAdapter
End Class
