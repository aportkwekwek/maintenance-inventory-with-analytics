<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierItemAnalysisReport
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
        Me.SupplierItemAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierItemAnalysisx = New WindowsApplication8.SupplierItemAnalysisx()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbldesc = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.TextBox()
        Me.SupplierItemAnalysisTableAdapter = New WindowsApplication8.SupplierItemAnalysisxTableAdapters.SupplierItemAnalysisTableAdapter()
        CType(Me.SupplierItemAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierItemAnalysisx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierItemAnalysisBindingSource
        '
        Me.SupplierItemAnalysisBindingSource.DataMember = "SupplierItemAnalysis"
        Me.SupplierItemAnalysisBindingSource.DataSource = Me.SupplierItemAnalysisx
        '
        'SupplierItemAnalysisx
        '
        Me.SupplierItemAnalysisx.DataSetName = "SupplierItemAnalysisx"
        Me.SupplierItemAnalysisx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "SupplierItemAnalysis1"
        ReportDataSource1.Value = Me.SupplierItemAnalysisBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(742, 534)
        Me.ReportViewer1.TabIndex = 0
        '
        'lbldesc
        '
        Me.lbldesc.Location = New System.Drawing.Point(527, 107)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(139, 22)
        Me.lbldesc.TabIndex = 1
        Me.lbldesc.Visible = False
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(527, 164)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(139, 22)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Visible = False
        '
        'SupplierItemAnalysisTableAdapter
        '
        Me.SupplierItemAnalysisTableAdapter.ClearBeforeFill = True
        '
        'SupplierItemAnalysisReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 534)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "SupplierItemAnalysisReport"
        Me.Text = "SupplierItemAnalysisReport"
        CType(Me.SupplierItemAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierItemAnalysisx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbldesc As System.Windows.Forms.TextBox
    Friend WithEvents lblModel As System.Windows.Forms.TextBox
    Friend WithEvents SupplierItemAnalysisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierItemAnalysisx As WindowsApplication8.SupplierItemAnalysisx
    Friend WithEvents SupplierItemAnalysisTableAdapter As WindowsApplication8.SupplierItemAnalysisxTableAdapters.SupplierItemAnalysisTableAdapter
End Class
