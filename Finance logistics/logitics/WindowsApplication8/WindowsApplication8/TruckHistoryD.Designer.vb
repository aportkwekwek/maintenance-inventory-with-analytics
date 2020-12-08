<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TruckHistoryD
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
        Me.getTruckHistoryRPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TruckHistoryDataSet = New WindowsApplication8.TruckHistoryDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtTruckid = New System.Windows.Forms.TextBox()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.getTruckHistoryRPTableAdapter = New WindowsApplication8.TruckHistoryDataSetTableAdapters.getTruckHistoryRPTableAdapter()
        Me.txtPlatenumber = New System.Windows.Forms.TextBox()
        CType(Me.getTruckHistoryRPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TruckHistoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'getTruckHistoryRPBindingSource
        '
        Me.getTruckHistoryRPBindingSource.DataMember = "getTruckHistoryRP"
        Me.getTruckHistoryRPBindingSource.DataSource = Me.TruckHistoryDataSet
        '
        'TruckHistoryDataSet
        '
        Me.TruckHistoryDataSet.DataSetName = "TruckHistoryDataSet"
        Me.TruckHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "truckHistoryDS"
        ReportDataSource1.Value = Me.getTruckHistoryRPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.TruckHistory.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(857, 526)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtTruckid
        '
        Me.txtTruckid.Location = New System.Drawing.Point(590, 139)
        Me.txtTruckid.Name = "txtTruckid"
        Me.txtTruckid.Size = New System.Drawing.Size(166, 22)
        Me.txtTruckid.TabIndex = 1
        Me.txtTruckid.Visible = False
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(590, 196)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(166, 22)
        Me.txtDateFrom.TabIndex = 2
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(590, 245)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(166, 22)
        Me.txtDateTo.TabIndex = 3
        Me.txtDateTo.Visible = False
        '
        'getTruckHistoryRPTableAdapter
        '
        Me.getTruckHistoryRPTableAdapter.ClearBeforeFill = True
        '
        'txtPlatenumber
        '
        Me.txtPlatenumber.Location = New System.Drawing.Point(590, 91)
        Me.txtPlatenumber.Name = "txtPlatenumber"
        Me.txtPlatenumber.Size = New System.Drawing.Size(166, 22)
        Me.txtPlatenumber.TabIndex = 5
        Me.txtPlatenumber.Visible = False
        '
        'TruckHistoryD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 526)
        Me.Controls.Add(Me.txtPlatenumber)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.txtTruckid)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TruckHistoryD"
        Me.Text = "TruckHistoryD"
        CType(Me.getTruckHistoryRPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TruckHistoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtTruckid As System.Windows.Forms.TextBox
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents getTruckHistoryRPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TruckHistoryDataSet As WindowsApplication8.TruckHistoryDataSet
    Friend WithEvents getTruckHistoryRPTableAdapter As WindowsApplication8.TruckHistoryDataSetTableAdapters.getTruckHistoryRPTableAdapter
    Friend WithEvents txtPlatenumber As System.Windows.Forms.TextBox
End Class
