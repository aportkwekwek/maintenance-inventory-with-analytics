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
        Me.AcroDistributionNetworkIncDataSet = New WindowsApplication8.AcroDistributionNetworkIncDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.samplesssTableAdapter = New WindowsApplication8.AcroDistributionNetworkIncDataSetTableAdapters.samplesssTableAdapter()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcroDistributionNetworkIncDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'samplesssBindingSource
        '
        Me.samplesssBindingSource.DataMember = "samplesss"
        Me.samplesssBindingSource.DataSource = Me.AcroDistributionNetworkIncDataSet
        '
        'AcroDistributionNetworkIncDataSet
        '
        Me.AcroDistributionNetworkIncDataSet.DataSetName = "AcroDistributionNetworkIncDataSet"
        Me.AcroDistributionNetworkIncDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.samplesssBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.PurchaseOrderReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(940, 449)
        Me.ReportViewer1.TabIndex = 0
        '
        'samplesssTableAdapter
        '
        Me.samplesssTableAdapter.ClearBeforeFill = True
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(704, 374)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(132, 22)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(704, 334)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(132, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.Location = New System.Drawing.Point(700, 286)
        Me.lbltot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(51, 17)
        Me.lbltot.TabIndex = 4
        Me.lbltot.Text = "Label1"
        Me.lbltot.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(700, 314)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(51, 17)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Label1"
        Me.lblMonth.Visible = False
        '
        'PurchaseOrderReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 449)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PurchaseOrderReport"
        Me.Text = "PurchaseOrderReport"
        CType(Me.samplesssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcroDistributionNetworkIncDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents samplesssBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcroDistributionNetworkIncDataSet As WindowsApplication8.AcroDistributionNetworkIncDataSet
    Friend WithEvents samplesssTableAdapter As WindowsApplication8.AcroDistributionNetworkIncDataSetTableAdapters.samplesssTableAdapter
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
End Class
