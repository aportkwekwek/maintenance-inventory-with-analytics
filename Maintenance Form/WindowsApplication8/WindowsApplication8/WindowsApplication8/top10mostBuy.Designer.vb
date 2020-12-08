<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class top10mostBuy
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
        Me.top10MostBuyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.top10MostBuyds = New WindowsApplication8.top10MostBuyds()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.top10MostBuyTableAdapter = New WindowsApplication8.top10MostBuydsTableAdapters.top10MostBuyTableAdapter()
        CType(Me.top10MostBuyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top10MostBuyds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'top10MostBuyBindingSource
        '
        Me.top10MostBuyBindingSource.DataMember = "top10MostBuy"
        Me.top10MostBuyBindingSource.DataSource = Me.top10MostBuyds
        '
        'top10MostBuyds
        '
        Me.top10MostBuyds.DataSetName = "top10MostBuyds"
        Me.top10MostBuyds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "top10Most"
        ReportDataSource1.Value = Me.top10MostBuyBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.Top10mostBuy.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(692, 404)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(471, 105)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(132, 22)
        Me.txtDateFrom.TabIndex = 1
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(471, 160)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(132, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'top10MostBuyTableAdapter
        '
        Me.top10MostBuyTableAdapter.ClearBeforeFill = True
        '
        'top10mostBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 404)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "top10mostBuy"
        Me.Text = "top10mostBuy"
        CType(Me.top10MostBuyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top10MostBuyds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents top10MostBuyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents top10MostBuyds As WindowsApplication8.top10MostBuyds
    Friend WithEvents top10MostBuyTableAdapter As WindowsApplication8.top10MostBuydsTableAdapters.top10MostBuyTableAdapter
End Class
