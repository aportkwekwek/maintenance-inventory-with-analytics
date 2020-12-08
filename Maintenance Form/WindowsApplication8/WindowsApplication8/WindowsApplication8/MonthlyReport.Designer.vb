<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyReport
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
        Me.MonthlyPurchaseOrderReport1 = New WindowsApplication8.MonthlyPurchaseOrderReport1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MonthlyReportTableAdapter = New WindowsApplication8.MonthlyPurchaseOrderReport1TableAdapters.MonthlyReportTableAdapter()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        CType(Me.MonthlyReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyPurchaseOrderReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthlyReportBindingSource
        '
        Me.MonthlyReportBindingSource.DataMember = "MonthlyReport"
        Me.MonthlyReportBindingSource.DataSource = Me.MonthlyPurchaseOrderReport1
        '
        'MonthlyPurchaseOrderReport1
        '
        Me.MonthlyPurchaseOrderReport1.DataSetName = "MonthlyPurchaseOrderReport1"
        Me.MonthlyPurchaseOrderReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MonthlyPurchaseOrderReport"
        ReportDataSource1.Value = Me.MonthlyReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.MonthlyReportPO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(847, 477)
        Me.ReportViewer1.TabIndex = 0
        '
        'MonthlyReportTableAdapter
        '
        Me.MonthlyReportTableAdapter.ClearBeforeFill = True
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(630, 105)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(155, 22)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(630, 145)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(155, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 477)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "MonthlyReport"
        Me.Text = "MonthlyReport"
        CType(Me.MonthlyReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyPurchaseOrderReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MonthlyReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyPurchaseOrderReport1 As WindowsApplication8.MonthlyPurchaseOrderReport1
    Friend WithEvents MonthlyReportTableAdapter As WindowsApplication8.MonthlyPurchaseOrderReport1TableAdapters.MonthlyReportTableAdapter
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
End Class
