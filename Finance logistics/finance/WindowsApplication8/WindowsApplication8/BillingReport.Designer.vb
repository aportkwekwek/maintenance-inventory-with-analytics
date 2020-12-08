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
        Me.ReportForSupplierDataSet = New WindowsApplication8.ReportForSupplierDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.ReportforSupplierTableAdapter = New WindowsApplication8.ReportForSupplierDataSetTableAdapters.ReportforSupplierTableAdapter()
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportForSupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportforSupplierBindingSource
        '
        Me.ReportforSupplierBindingSource.DataMember = "ReportforSupplier"
        Me.ReportforSupplierBindingSource.DataSource = Me.ReportForSupplierDataSet
        '
        'ReportForSupplierDataSet
        '
        Me.ReportForSupplierDataSet.DataSetName = "ReportForSupplierDataSet"
        Me.ReportForSupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BillingReportds"
        ReportDataSource1.Value = Me.ReportforSupplierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.BillingReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(627, 448)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(422, 93)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(144, 20)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(422, 136)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(144, 20)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(422, 163)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(144, 20)
        Me.txtSupplierName.TabIndex = 3
        Me.txtSupplierName.Visible = False
        '
        'ReportforSupplierTableAdapter
        '
        Me.ReportforSupplierTableAdapter.ClearBeforeFill = True
        '
        'BillingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 448)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BillingReport"
        Me.Text = "BillingReport"
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportForSupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents ReportforSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportForSupplierDataSet As WindowsApplication8.ReportForSupplierDataSet
    Friend WithEvents ReportforSupplierTableAdapter As WindowsApplication8.ReportForSupplierDataSetTableAdapters.ReportforSupplierTableAdapter
End Class
