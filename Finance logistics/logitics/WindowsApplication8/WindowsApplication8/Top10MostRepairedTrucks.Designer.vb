<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Top10MostRepairedTrucks
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
        Me.getTop5RepairtrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.top10RepairTrucks = New WindowsApplication8.top10RepairTrucks()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtDatefrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.getTop5RepairtrucksTableAdapter = New WindowsApplication8.top10RepairTrucksTableAdapters.getTop5RepairtrucksTableAdapter()
        CType(Me.getTop5RepairtrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top10RepairTrucks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'getTop5RepairtrucksBindingSource
        '
        Me.getTop5RepairtrucksBindingSource.DataMember = "getTop5Repairtrucks"
        Me.getTop5RepairtrucksBindingSource.DataSource = Me.top10RepairTrucks
        '
        'top10RepairTrucks
        '
        Me.top10RepairTrucks.DataSetName = "top10RepairTrucks"
        Me.top10RepairTrucks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "top10Repaired"
        ReportDataSource1.Value = Me.getTop5RepairtrucksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.top10mostRepaired.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtDatefrom
        '
        Me.txtDatefrom.Location = New System.Drawing.Point(546, 143)
        Me.txtDatefrom.Name = "txtDatefrom"
        Me.txtDatefrom.Size = New System.Drawing.Size(151, 22)
        Me.txtDatefrom.TabIndex = 1
        Me.txtDatefrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(546, 211)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(151, 22)
        Me.txtDateTo.TabIndex = 2
        Me.txtDateTo.Visible = False
        '
        'getTop5RepairtrucksTableAdapter
        '
        Me.getTop5RepairtrucksTableAdapter.ClearBeforeFill = True
        '
        'Top10MostRepairedTrucks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 517)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDatefrom)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Top10MostRepairedTrucks"
        Me.Text = "Top5MostRepairedTrucks"
        CType(Me.getTop5RepairtrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top10RepairTrucks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtDatefrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents getTop5RepairtrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents top10RepairTrucks As WindowsApplication8.top10RepairTrucks
    Friend WithEvents getTop5RepairtrucksTableAdapter As WindowsApplication8.top10RepairTrucksTableAdapters.getTop5RepairtrucksTableAdapter
End Class
