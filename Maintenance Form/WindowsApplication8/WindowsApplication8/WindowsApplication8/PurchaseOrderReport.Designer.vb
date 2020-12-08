<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderReport
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
        Me.samplesssBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderDataSet = New WindowsApplication8.PurchaseOrderDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.samplesssTableAdapter = New WindowsApplication8.PurchaseOrderDataSetTableAdapters.samplesssTableAdapter()
        Me.txtDatefrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'samplesssBindingSource
        '
        Me.samplesssBindingSource.DataMember = "samplesss"
        Me.samplesssBindingSource.DataSource = Me.PurchaseOrderDataSet
        '
        'PurchaseOrderDataSet
        '
        Me.PurchaseOrderDataSet.DataSetName = "PurchaseOrderDataSet"
        Me.PurchaseOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PurchaseOrder"
        ReportDataSource1.Value = Me.samplesssBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.PurchaseOrderReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(996, 725)
        Me.ReportViewer1.TabIndex = 0
        '
        'samplesssTableAdapter
        '
        Me.samplesssTableAdapter.ClearBeforeFill = True
        '
        'txtDatefrom
        '
        Me.txtDatefrom.Location = New System.Drawing.Point(695, 96)
        Me.txtDatefrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDatefrom.Name = "txtDatefrom"
        Me.txtDatefrom.Size = New System.Drawing.Size(199, 22)
        Me.txtDatefrom.TabIndex = 1
        Me.txtDatefrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(695, 144)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(199, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(695, 210)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 22)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.Location = New System.Drawing.Point(801, 342)
        Me.lbltot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(51, 17)
        Me.lbltot.TabIndex = 5
        Me.lbltot.Text = "Label1"
        Me.lbltot.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(801, 410)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(51, 17)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "Label1"
        Me.lblMonth.Visible = False
        '
        'PurchaseOrderReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 725)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDatefrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PurchaseOrderReport"
        Me.Text = "PurchaseOrderReport"
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents samplesssBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderDataSet As WindowsApplication8.PurchaseOrderDataSet
    Friend WithEvents samplesssTableAdapter As WindowsApplication8.PurchaseOrderDataSetTableAdapters.samplesssTableAdapter
    Friend WithEvents txtDatefrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
End Class
