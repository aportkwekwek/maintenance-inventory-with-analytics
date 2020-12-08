<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TruckHistory
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
        Me.lblTruckID = New System.Windows.Forms.Label()
        Me.dgvMaintenanceRepair = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvPartsInstalled = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMaintenanceRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPartsInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTruckID
        '
        Me.lblTruckID.AutoSize = True
        Me.lblTruckID.Location = New System.Drawing.Point(12, 9)
        Me.lblTruckID.Name = "lblTruckID"
        Me.lblTruckID.Size = New System.Drawing.Size(51, 17)
        Me.lblTruckID.TabIndex = 0
        Me.lblTruckID.Text = "Label1"
        Me.lblTruckID.Visible = False
        '
        'dgvMaintenanceRepair
        '
        Me.dgvMaintenanceRepair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaintenanceRepair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaintenanceRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaintenanceRepair.Location = New System.Drawing.Point(19, 33)
        Me.dgvMaintenanceRepair.Name = "dgvMaintenanceRepair"
        Me.dgvMaintenanceRepair.ReadOnly = True
        Me.dgvMaintenanceRepair.RowTemplate.Height = 24
        Me.dgvMaintenanceRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMaintenanceRepair.Size = New System.Drawing.Size(1249, 184)
        Me.dgvMaintenanceRepair.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvMaintenanceRepair)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1280, 241)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintenance/Repair History"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1218, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvPartsInstalled)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1277, 198)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parts Installed"
        '
        'dgvPartsInstalled
        '
        Me.dgvPartsInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPartsInstalled.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPartsInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartsInstalled.Location = New System.Drawing.Point(14, 26)
        Me.dgvPartsInstalled.Name = "dgvPartsInstalled"
        Me.dgvPartsInstalled.ReadOnly = True
        Me.dgvPartsInstalled.RowTemplate.Height = 24
        Me.dgvPartsInstalled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPartsInstalled.Size = New System.Drawing.Size(1249, 153)
        Me.dgvPartsInstalled.TabIndex = 2
        '
        'TruckHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1307, 532)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTruckID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "TruckHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TruckHistory"
        CType(Me.dgvMaintenanceRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPartsInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTruckID As System.Windows.Forms.Label
    Friend WithEvents dgvMaintenanceRepair As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPartsInstalled As System.Windows.Forms.DataGridView
End Class
