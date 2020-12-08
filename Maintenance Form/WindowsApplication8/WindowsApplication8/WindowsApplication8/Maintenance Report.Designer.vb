<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_Report
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
        Me.truckNumberofMaintenanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcroDistributionNetworkIncDataSet2 = New WindowsApplication8.AcroDistributionNetworkIncDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.truckNumberofMaintenanceTableAdapter = New WindowsApplication8.AcroDistributionNetworkIncDataSet2TableAdapters.truckNumberofMaintenanceTableAdapter()
        Me.lblMonth = New System.Windows.Forms.Label()
        CType(Me.truckNumberofMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcroDistributionNetworkIncDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'truckNumberofMaintenanceBindingSource
        '
        Me.truckNumberofMaintenanceBindingSource.DataMember = "truckNumberofMaintenance"
        Me.truckNumberofMaintenanceBindingSource.DataSource = Me.AcroDistributionNetworkIncDataSet2
        '
        'AcroDistributionNetworkIncDataSet2
        '
        Me.AcroDistributionNetworkIncDataSet2.DataSetName = "AcroDistributionNetworkIncDataSet2"
        Me.AcroDistributionNetworkIncDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MaintenanceReport"
        ReportDataSource1.Value = Me.truckNumberofMaintenanceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.MaintenanceReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(993, 513)
        Me.ReportViewer1.TabIndex = 3
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(740, 401)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(205, 22)
        Me.txtDateTo.TabIndex = 5
        Me.txtDateTo.Visible = False
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(740, 343)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(205, 22)
        Me.txtDateFrom.TabIndex = 4
        Me.txtDateFrom.Visible = False
        '
        'truckNumberofMaintenanceTableAdapter
        '
        Me.truckNumberofMaintenanceTableAdapter.ClearBeforeFill = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(871, 300)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(51, 17)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "Label1"
        Me.lblMonth.Visible = False
        '
        'Maintenance_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 513)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Maintenance_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance_Report"
        CType(Me.truckNumberofMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcroDistributionNetworkIncDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents truckNumberofMaintenanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcroDistributionNetworkIncDataSet2 As WindowsApplication8.AcroDistributionNetworkIncDataSet2
    Friend WithEvents truckNumberofMaintenanceTableAdapter As WindowsApplication8.AcroDistributionNetworkIncDataSet2TableAdapters.truckNumberofMaintenanceTableAdapter
    Friend WithEvents lblMonth As System.Windows.Forms.Label

End Class
