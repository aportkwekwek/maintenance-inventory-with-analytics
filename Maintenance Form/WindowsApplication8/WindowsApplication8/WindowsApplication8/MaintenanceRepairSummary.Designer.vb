<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceRepairSummary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTruckInfo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTechniciansWorking = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDateTimeToday = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboItemID = New System.Windows.Forms.ComboBox()
        Me.cboItemIdentification = New System.Windows.Forms.ComboBox()
        Me.lvItmAdd = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblWorkOrder = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblDateStart = New System.Windows.Forms.Label()
        Me.lblTruckID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvItemsInstalled = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTruckInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTechniciansWorking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvItemsInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Truck Information"
        '
        'dgvTruckInfo
        '
        Me.dgvTruckInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTruckInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTruckInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTruckInfo.Location = New System.Drawing.Point(21, 34)
        Me.dgvTruckInfo.Name = "dgvTruckInfo"
        Me.dgvTruckInfo.RowTemplate.Height = 24
        Me.dgvTruckInfo.Size = New System.Drawing.Size(613, 125)
        Me.dgvTruckInfo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(693, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Major", "Minor"})
        Me.cboStatus.Location = New System.Drawing.Point(806, 59)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(215, 24)
        Me.cboStatus.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Technician(s)"
        '
        'dgvTechniciansWorking
        '
        Me.dgvTechniciansWorking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTechniciansWorking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTechniciansWorking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTechniciansWorking.Location = New System.Drawing.Point(21, 32)
        Me.dgvTechniciansWorking.Name = "dgvTechniciansWorking"
        Me.dgvTechniciansWorking.RowTemplate.Height = 24
        Me.dgvTechniciansWorking.Size = New System.Drawing.Size(613, 116)
        Me.dgvTechniciansWorking.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(977, 619)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mark as Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1092, 619)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 28)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDateTimeToday
        '
        Me.lblDateTimeToday.AutoSize = True
        Me.lblDateTimeToday.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTimeToday.Location = New System.Drawing.Point(974, 9)
        Me.lblDateTimeToday.Name = "lblDateTimeToday"
        Me.lblDateTimeToday.Size = New System.Drawing.Size(143, 17)
        Me.lblDateTimeToday.TabIndex = 10
        Me.lblDateTimeToday.Text = "Date Time Today"
        Me.lblDateTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(693, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Add Item(s)"
        '
        'cboItemID
        '
        Me.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemID.FormattingEnabled = True
        Me.cboItemID.Location = New System.Drawing.Point(806, 118)
        Me.cboItemID.Name = "cboItemID"
        Me.cboItemID.Size = New System.Drawing.Size(387, 24)
        Me.cboItemID.TabIndex = 12
        '
        'cboItemIdentification
        '
        Me.cboItemIdentification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemIdentification.FormattingEnabled = True
        Me.cboItemIdentification.Location = New System.Drawing.Point(806, 148)
        Me.cboItemIdentification.Name = "cboItemIdentification"
        Me.cboItemIdentification.Size = New System.Drawing.Size(387, 24)
        Me.cboItemIdentification.TabIndex = 13
        '
        'lvItmAdd
        '
        Me.lvItmAdd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvItmAdd.FullRowSelect = True
        Me.lvItmAdd.Location = New System.Drawing.Point(696, 230)
        Me.lvItmAdd.Name = "lvItmAdd"
        Me.lvItmAdd.Size = New System.Drawing.Size(500, 119)
        Me.lvItmAdd.TabIndex = 14
        Me.lvItmAdd.UseCompatibleStateImageBehavior = False
        Me.lvItmAdd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MaintenanceID"
        Me.ColumnHeader1.Width = 1
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Identification"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 360
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1110, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 28)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblWorkOrder
        '
        Me.lblWorkOrder.AutoSize = True
        Me.lblWorkOrder.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkOrder.Location = New System.Drawing.Point(741, 630)
        Me.lblWorkOrder.Name = "lblWorkOrder"
        Me.lblWorkOrder.Size = New System.Drawing.Size(17, 17)
        Me.lblWorkOrder.TabIndex = 16
        Me.lblWorkOrder.Text = "."
        Me.lblWorkOrder.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1030, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 28)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Remove Selected Item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblDateStart
        '
        Me.lblDateStart.AutoSize = True
        Me.lblDateStart.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateStart.Location = New System.Drawing.Point(440, 9)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(143, 17)
        Me.lblDateStart.TabIndex = 18
        Me.lblDateStart.Text = "Date Time Today"
        Me.lblDateStart.Visible = False
        '
        'lblTruckID
        '
        Me.lblTruckID.AutoSize = True
        Me.lblTruckID.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTruckID.Location = New System.Drawing.Point(704, 624)
        Me.lblTruckID.Name = "lblTruckID"
        Me.lblTruckID.Size = New System.Drawing.Size(17, 17)
        Me.lblTruckID.TabIndex = 19
        Me.lblTruckID.Text = "."
        Me.lblTruckID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTruckInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 178)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Truck Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvTechniciansWorking)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(650, 163)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Technician(s)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvItemsInstalled)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(650, 163)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item(s) installed"
        '
        'dgvItemsInstalled
        '
        Me.dgvItemsInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemsInstalled.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvItemsInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsInstalled.Location = New System.Drawing.Point(21, 32)
        Me.dgvItemsInstalled.Name = "dgvItemsInstalled"
        Me.dgvItemsInstalled.RowTemplate.Height = 24
        Me.dgvItemsInstalled.Size = New System.Drawing.Size(613, 116)
        Me.dgvItemsInstalled.TabIndex = 7
        '
        'MaintenanceRepairSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1231, 659)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTruckID)
        Me.Controls.Add(Me.lblDateStart)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblWorkOrder)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lvItmAdd)
        Me.Controls.Add(Me.cboItemIdentification)
        Me.Controls.Add(Me.cboItemID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDateTimeToday)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MaintenanceRepairSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaintenanceRepairSummary"
        CType(Me.dgvTruckInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTechniciansWorking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvItemsInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvTruckInfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvTechniciansWorking As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDateTimeToday As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboItemID As System.Windows.Forms.ComboBox
    Friend WithEvents cboItemIdentification As System.Windows.Forms.ComboBox
    Friend WithEvents lvItmAdd As System.Windows.Forms.ListView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblWorkOrder As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblDateStart As System.Windows.Forms.Label
    Friend WithEvents lblTruckID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvItemsInstalled As System.Windows.Forms.DataGridView
End Class
