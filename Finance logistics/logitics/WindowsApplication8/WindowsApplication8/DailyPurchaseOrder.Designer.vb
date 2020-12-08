<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyPurchaseOrder
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
        Me.DailyPurchaseOrderDataSet = New WindowsApplication8.DailyPurchaseOrderDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.samplesssTableAdapter = New WindowsApplication8.DailyPurchaseOrderDataSetTableAdapters.samplesssTableAdapter()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyPurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'samplesssBindingSource
        '
        Me.samplesssBindingSource.DataMember = "samplesss"
        Me.samplesssBindingSource.DataSource = Me.DailyPurchaseOrderDataSet
        '
        'DailyPurchaseOrderDataSet
        '
        Me.DailyPurchaseOrderDataSet.DataSetName = "DailyPurchaseOrderDataSet"
        Me.DailyPurchaseOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dailyPurchaseOrder"
        ReportDataSource1.Value = Me.samplesssBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.POdaily.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(560, 169)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(150, 22)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(560, 225)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(150, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'samplesssTableAdapter
        '
        Me.samplesssTableAdapter.ClearBeforeFill = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(567, 343)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 17)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Label1"
        Me.lblTotal.Visible = False
        '
        'DailyPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 517)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "DailyPurchaseOrder"
        Me.Text = "DailyPurchaseOrder"
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyPurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents samplesssBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyPurchaseOrderDataSet As WindowsApplication8.DailyPurchaseOrderDataSet
    Friend WithEvents samplesssTableAdapter As WindowsApplication8.DailyPurchaseOrderDataSetTableAdapters.samplesssTableAdapter
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
