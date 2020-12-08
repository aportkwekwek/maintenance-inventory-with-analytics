<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportforSuppliers
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.dtpDateFrom = New System.Windows.Forms.TextBox()
        Me.dtpDateTo = New System.Windows.Forms.TextBox()
        Me.ReportForSupplierDs = New WindowsApplication8.ReportForSupplierDs()
        Me.ReportforSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportforSupplierTableAdapter = New WindowsApplication8.ReportForSupplierDsTableAdapters.ReportforSupplierTableAdapter()
        CType(Me.ReportForSupplierDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(935, 623)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(596, 141)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(100, 22)
        Me.txtSupplierName.TabIndex = 1
        Me.txtSupplierName.Visible = False
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(596, 196)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(100, 22)
        Me.dtpDateFrom.TabIndex = 2
        Me.dtpDateFrom.Visible = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Location = New System.Drawing.Point(596, 247)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(100, 22)
        Me.dtpDateTo.TabIndex = 3
        Me.dtpDateTo.Visible = False
        '
        'ReportForSupplierDs
        '
        Me.ReportForSupplierDs.DataSetName = "ReportForSupplierDs"
        Me.ReportForSupplierDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportforSupplierBindingSource
        '
        Me.ReportforSupplierBindingSource.DataMember = "ReportforSupplier"
        Me.ReportforSupplierBindingSource.DataSource = Me.ReportForSupplierDs
        '
        'ReportforSupplierTableAdapter
        '
        Me.ReportforSupplierTableAdapter.ClearBeforeFill = True
        '
        'ReportforSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 623)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportforSuppliers"
        Me.Text = "ReportforSuppliers"
        CType(Me.ReportForSupplierDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportforSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.TextBox
    Friend WithEvents ReportforSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportForSupplierDs As WindowsApplication8.ReportForSupplierDs
    Friend WithEvents ReportforSupplierTableAdapter As WindowsApplication8.ReportForSupplierDsTableAdapters.ReportforSupplierTableAdapter
End Class
