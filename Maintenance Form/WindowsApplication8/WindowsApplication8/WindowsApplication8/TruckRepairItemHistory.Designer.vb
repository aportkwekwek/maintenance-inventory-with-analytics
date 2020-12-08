<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TruckRepairItemHistory
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
        Me.txtPlateNumber = New System.Windows.Forms.TextBox()
        Me.truckHistoryRepairItemsDS = New WindowsApplication8.truckHistoryRepairItemsDS()
        Me.truckHistoryRepairItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.truckHistoryRepairItemsTableAdapter = New WindowsApplication8.truckHistoryRepairItemsDSTableAdapters.truckHistoryRepairItemsTableAdapter()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        CType(Me.truckHistoryRepairItemsDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.truckHistoryRepairItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "truckRepairItemHistory"
        ReportDataSource1.Value = Me.truckHistoryRepairItemsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication8.ItemHistoryReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(871, 550)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtPlateNumber
        '
        Me.txtPlateNumber.Location = New System.Drawing.Point(708, 158)
        Me.txtPlateNumber.Name = "txtPlateNumber"
        Me.txtPlateNumber.Size = New System.Drawing.Size(135, 22)
        Me.txtPlateNumber.TabIndex = 1
        Me.txtPlateNumber.Visible = False
        '
        'truckHistoryRepairItemsDS
        '
        Me.truckHistoryRepairItemsDS.DataSetName = "truckHistoryRepairItemsDS"
        Me.truckHistoryRepairItemsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'truckHistoryRepairItemsBindingSource
        '
        Me.truckHistoryRepairItemsBindingSource.DataMember = "truckHistoryRepairItems"
        Me.truckHistoryRepairItemsBindingSource.DataSource = Me.truckHistoryRepairItemsDS
        '
        'truckHistoryRepairItemsTableAdapter
        '
        Me.truckHistoryRepairItemsTableAdapter.ClearBeforeFill = True
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Location = New System.Drawing.Point(708, 204)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(135, 22)
        Me.txtDateFrom.TabIndex = 2
        Me.txtDateFrom.Visible = False
        '
        'txtDateTo
        '
        Me.txtDateTo.Location = New System.Drawing.Point(708, 242)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(135, 22)
        Me.txtDateTo.TabIndex = 3
        Me.txtDateTo.Visible = False
        '
        'TruckRepairItemHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 550)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.txtPlateNumber)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TruckRepairItemHistory"
        Me.Text = "TruckRepairItemHistory"
        CType(Me.truckHistoryRepairItemsDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.truckHistoryRepairItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
    Friend WithEvents truckHistoryRepairItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents truckHistoryRepairItemsDS As WindowsApplication8.truckHistoryRepairItemsDS
    Friend WithEvents truckHistoryRepairItemsTableAdapter As WindowsApplication8.truckHistoryRepairItemsDSTableAdapters.truckHistoryRepairItemsTableAdapter
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTo As System.Windows.Forms.TextBox
End Class
