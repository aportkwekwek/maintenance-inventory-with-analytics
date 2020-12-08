<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingReport
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
        Me.ReportforSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingReportDataSet = New WindowsApplication8.BillingReportDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtpDateFrom = New System.Windows.Forms.TextBox()
        Me.dtpDateTo = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.ReportforSupplierTableAdapter = New WindowsApplication8.BillingReportDataSetTableAdapters.ReportforSupplierTableAdapter()
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportforSupplierBindingSource
        '
        Me.ReportforSupplierBindingSource.DataMember = "ReportforSupplier"
        Me.ReportforSupplierBindingSource.DataSource = Me.BillingReportDataSet
        '
        'BillingReportDataSet
        '
        Me.BillingReportDataSet.DataSetName = "BillingReportDataSet"
        Me.BillingReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BillingReport"
        ReportDataSource1.Value = Me.ReportforSupplierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.BillingReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(819, 496)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(513, 98)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(100, 22)
        Me.dtpDateFrom.TabIndex = 1
        Me.dtpDateFrom.Visible = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Location = New System.Drawing.Point(513, 161)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(100, 22)
        Me.dtpDateTo.TabIndex = 2
        Me.dtpDateTo.Visible = False
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(513, 227)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(100, 22)
        Me.txtSupplierName.TabIndex = 3
        Me.txtSupplierName.Visible = False
        '
        'ReportforSupplierTableAdapter
        '
        Me.ReportforSupplierTableAdapter.ClearBeforeFill = True
        '
        'BillingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 496)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BillingReport"
        Me.Text = "BillingReport"
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtpDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents ReportforSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingReportDataSet As WindowsApplication8.BillingReportDataSet
    Friend WithEvents ReportforSupplierTableAdapter As WindowsApplication8.BillingReportDataSetTableAdapters.ReportforSupplierTableAdapter
End Class
