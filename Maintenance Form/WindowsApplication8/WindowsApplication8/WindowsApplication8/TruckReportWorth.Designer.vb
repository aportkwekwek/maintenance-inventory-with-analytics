<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TruckReportWorth
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
        Me.AcroDistributionNetworkIncDataSet = New WindowsApplication8.AcroDistributionNetworkIncDataSet()
        Me.getTruckallAssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.getTruckallAssetTableAdapter = New WindowsApplication8.AcroDistributionNetworkIncDataSetTableAdapters.getTruckallAssetTableAdapter()
        CType(Me.AcroDistributionNetworkIncDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getTruckallAssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TruckReportAsset"
        ReportDataSource1.Value = Me.getTruckallAssetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.TruckReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(780, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'AcroDistributionNetworkIncDataSet
        '
        Me.AcroDistributionNetworkIncDataSet.DataSetName = "AcroDistributionNetworkIncDataSet"
        Me.AcroDistributionNetworkIncDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'getTruckallAssetBindingSource
        '
        Me.getTruckallAssetBindingSource.DataMember = "getTruckallAsset"
        Me.getTruckallAssetBindingSource.DataSource = Me.AcroDistributionNetworkIncDataSet
        '
        'getTruckallAssetTableAdapter
        '
        Me.getTruckallAssetTableAdapter.ClearBeforeFill = True
        '
        'TruckReportWorth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TruckReportWorth"
        Me.Text = "TruckReportWorth"
        CType(Me.AcroDistributionNetworkIncDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getTruckallAssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents getTruckallAssetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcroDistributionNetworkIncDataSet As WindowsApplication8.AcroDistributionNetworkIncDataSet
    Friend WithEvents getTruckallAssetTableAdapter As WindowsApplication8.AcroDistributionNetworkIncDataSetTableAdapters.getTruckallAssetTableAdapter
End Class
