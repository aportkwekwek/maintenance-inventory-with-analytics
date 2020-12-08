<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class truckWorth
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
        Me.truckAssetDS = New WindowsApplication8.truckAssetDS()
        Me.getTruckallAssetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.getTruckallAssetTableAdapter = New WindowsApplication8.truckAssetDSTableAdapters.getTruckallAssetTableAdapter()
        CType(Me.truckAssetDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getTruckallAssetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "getTruckAsset"
        ReportDataSource1.Value = Me.getTruckallAssetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.TruckWorth.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(870, 576)
        Me.ReportViewer1.TabIndex = 0
        '
        'truckAssetDS
        '
        Me.truckAssetDS.DataSetName = "truckAssetDS"
        Me.truckAssetDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'getTruckallAssetBindingSource
        '
        Me.getTruckallAssetBindingSource.DataMember = "getTruckallAsset"
        Me.getTruckallAssetBindingSource.DataSource = Me.truckAssetDS
        '
        'getTruckallAssetTableAdapter
        '
        Me.getTruckallAssetTableAdapter.ClearBeforeFill = True
        '
        'truckWorth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 576)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "truckWorth"
        Me.Text = "truckWorth"
        CType(Me.truckAssetDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getTruckallAssetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents getTruckallAssetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents truckAssetDS As WindowsApplication8.truckAssetDS
    Friend WithEvents getTruckallAssetTableAdapter As WindowsApplication8.truckAssetDSTableAdapters.getTruckallAssetTableAdapter
End Class
