<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinance
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMyAccount = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSupplierPrices = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.PanelRequest = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpToEvaluate = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblPurchaseOrderId = New System.Windows.Forms.Label()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.dgvListofItem = New System.Windows.Forms.DataGridView()
        Me.grpRequest = New System.Windows.Forms.GroupBox()
        Me.dgvPendingPO = New System.Windows.Forms.DataGridView()
        Me.btnViewItems = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.panelSupplierPrices = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvViewSuppliers = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvItemofSupplier = New System.Windows.Forms.DataGridView()
        Me.PanelMyAccount = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCancelAcc = New System.Windows.Forms.Button()
        Me.btnSaveAcc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRetypeNPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccNPassword = New System.Windows.Forms.TextBox()
        Me.txtAccPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAccUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAddMinitial = New System.Windows.Forms.TextBox()
        Me.txtAddFname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddLname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelNewAcc = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAddCPassword = New System.Windows.Forms.TextBox()
        Me.txtAddPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDateTimenow = New System.Windows.Forms.Label()
        Me.lblUserInformation = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.PanelRequest.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpToEvaluate.SuspendLayout()
        CType(Me.dgvListofItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        CType(Me.dgvPendingPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSupplierPrices.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvViewSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvItemofSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMyAccount.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnMyAccount)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnSupplierPrices)
        Me.Panel1.Controls.Add(Me.btnRequest)
        Me.Panel1.Location = New System.Drawing.Point(11, 198)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 566)
        Me.Panel1.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogOut.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.logout
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(0, 468)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(284, 75)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnMyAccount
        '
        Me.btnMyAccount.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnMyAccount.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.ma
        Me.btnMyAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMyAccount.FlatAppearance.BorderSize = 0
        Me.btnMyAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyAccount.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyAccount.Location = New System.Drawing.Point(4, 359)
        Me.btnMyAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.Size = New System.Drawing.Size(284, 75)
        Me.btnMyAccount.TabIndex = 6
        Me.btnMyAccount.Text = "My Account"
        Me.btnMyAccount.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReports.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.rprt
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(4, 236)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(284, 86)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnSupplierPrices
        '
        Me.btnSupplierPrices.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSupplierPrices.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.sp
        Me.btnSupplierPrices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSupplierPrices.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSupplierPrices.FlatAppearance.BorderSize = 0
        Me.btnSupplierPrices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnSupplierPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplierPrices.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplierPrices.Location = New System.Drawing.Point(0, 112)
        Me.btnSupplierPrices.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupplierPrices.Name = "btnSupplierPrices"
        Me.btnSupplierPrices.Size = New System.Drawing.Size(284, 95)
        Me.btnSupplierPrices.TabIndex = 3
        Me.btnSupplierPrices.Text = "Supplier Prices"
        Me.btnSupplierPrices.UseVisualStyleBackColor = False
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRequest.BackgroundImage = Global.WindowsApplication8.My.Resources.Resources.req
        Me.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRequest.FlatAppearance.BorderSize = 0
        Me.btnRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequest.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.Image = Global.WindowsApplication8.My.Resources.Resources.red
        Me.btnRequest.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnRequest.Location = New System.Drawing.Point(0, 11)
        Me.btnRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(284, 80)
        Me.btnRequest.TabIndex = 2
        Me.btnRequest.Text = "Request"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'PanelRequest
        '
        Me.PanelRequest.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelRequest.Controls.Add(Me.TabControl1)
        Me.PanelRequest.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRequest.Location = New System.Drawing.Point(13, 4)
        Me.PanelRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRequest.Name = "PanelRequest"
        Me.PanelRequest.Size = New System.Drawing.Size(1, 610)
        Me.PanelRequest.TabIndex = 1
        Me.PanelRequest.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(43, 46)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1265, 507)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpToEvaluate)
        Me.TabPage1.Controls.Add(Me.grpRequest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1257, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Purchase Order Request"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpToEvaluate
        '
        Me.grpToEvaluate.Controls.Add(Me.Button3)
        Me.grpToEvaluate.Controls.Add(Me.lblPurchaseOrderId)
        Me.grpToEvaluate.Controls.Add(Me.btnEvaluate)
        Me.grpToEvaluate.Controls.Add(Me.dgvListofItem)
        Me.grpToEvaluate.Location = New System.Drawing.Point(34, 19)
        Me.grpToEvaluate.Margin = New System.Windows.Forms.Padding(4)
        Me.grpToEvaluate.Name = "grpToEvaluate"
        Me.grpToEvaluate.Padding = New System.Windows.Forms.Padding(4)
        Me.grpToEvaluate.Size = New System.Drawing.Size(1153, 426)
        Me.grpToEvaluate.TabIndex = 7
        Me.grpToEvaluate.TabStop = False
        Me.grpToEvaluate.Text = "Items of Purchase Order"
        Me.grpToEvaluate.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(879, 383)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblPurchaseOrderId
        '
        Me.lblPurchaseOrderId.AutoSize = True
        Me.lblPurchaseOrderId.Location = New System.Drawing.Point(81, 383)
        Me.lblPurchaseOrderId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPurchaseOrderId.Name = "lblPurchaseOrderId"
        Me.lblPurchaseOrderId.Size = New System.Drawing.Size(19, 19)
        Me.lblPurchaseOrderId.TabIndex = 8
        Me.lblPurchaseOrderId.Text = "."
        Me.lblPurchaseOrderId.Visible = False
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(735, 384)
        Me.btnEvaluate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(127, 28)
        Me.btnEvaluate.TabIndex = 4
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'dgvListofItem
        '
        Me.dgvListofItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListofItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListofItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListofItem.Location = New System.Drawing.Point(25, 23)
        Me.dgvListofItem.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListofItem.Name = "dgvListofItem"
        Me.dgvListofItem.ReadOnly = True
        Me.dgvListofItem.Size = New System.Drawing.Size(1108, 341)
        Me.dgvListofItem.TabIndex = 7
        '
        'grpRequest
        '
        Me.grpRequest.Controls.Add(Me.dgvPendingPO)
        Me.grpRequest.Controls.Add(Me.btnViewItems)
        Me.grpRequest.Controls.Add(Me.Button4)
        Me.grpRequest.Location = New System.Drawing.Point(23, 36)
        Me.grpRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRequest.Size = New System.Drawing.Size(1197, 330)
        Me.grpRequest.TabIndex = 6
        Me.grpRequest.TabStop = False
        Me.grpRequest.Text = "Request Purchase Order"
        '
        'dgvPendingPO
        '
        Me.dgvPendingPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPendingPO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPendingPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingPO.Location = New System.Drawing.Point(24, 39)
        Me.dgvPendingPO.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPendingPO.Name = "dgvPendingPO"
        Me.dgvPendingPO.ReadOnly = True
        Me.dgvPendingPO.Size = New System.Drawing.Size(1129, 208)
        Me.dgvPendingPO.TabIndex = 0
        '
        'btnViewItems
        '
        Me.btnViewItems.Location = New System.Drawing.Point(1049, 278)
        Me.btnViewItems.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewItems.Name = "btnViewItems"
        Me.btnViewItems.Size = New System.Drawing.Size(100, 28)
        Me.btnViewItems.TabIndex = 4
        Me.btnViewItems.Text = "View Items"
        Me.btnViewItems.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(561, 278)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'panelSupplierPrices
        '
        Me.panelSupplierPrices.BackColor = System.Drawing.Color.RoyalBlue
        Me.panelSupplierPrices.Controls.Add(Me.TabControl2)
        Me.panelSupplierPrices.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSupplierPrices.Location = New System.Drawing.Point(22, 4)
        Me.panelSupplierPrices.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSupplierPrices.Name = "panelSupplierPrices"
        Me.panelSupplierPrices.Size = New System.Drawing.Size(1, 610)
        Me.panelSupplierPrices.TabIndex = 9
        Me.panelSupplierPrices.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(21, 21)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1228, 565)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.dgvViewSuppliers)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1220, 534)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "List of Suppliers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(1071, 494)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(139, 27)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Refresh List"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Here are the list of the suppliers"
        '
        'dgvViewSuppliers
        '
        Me.dgvViewSuppliers.AllowUserToAddRows = False
        Me.dgvViewSuppliers.AllowUserToDeleteRows = False
        Me.dgvViewSuppliers.AllowUserToResizeColumns = False
        Me.dgvViewSuppliers.AllowUserToResizeRows = False
        Me.dgvViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvViewSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvViewSuppliers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewSuppliers.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvViewSuppliers.Location = New System.Drawing.Point(17, 58)
        Me.dgvViewSuppliers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvViewSuppliers.Name = "dgvViewSuppliers"
        Me.dgvViewSuppliers.ReadOnly = True
        Me.dgvViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewSuppliers.Size = New System.Drawing.Size(1185, 408)
        Me.dgvViewSuppliers.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.dgvItemofSupplier)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(1220, 534)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Items of Supplier"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1090, 489)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvItemofSupplier
        '
        Me.dgvItemofSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemofSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvItemofSupplier.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvItemofSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemofSupplier.Location = New System.Drawing.Point(16, 23)
        Me.dgvItemofSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvItemofSupplier.Name = "dgvItemofSupplier"
        Me.dgvItemofSupplier.ReadOnly = True
        Me.dgvItemofSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemofSupplier.Size = New System.Drawing.Size(1177, 451)
        Me.dgvItemofSupplier.TabIndex = 0
        '
        'PanelMyAccount
        '
        Me.PanelMyAccount.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelMyAccount.Controls.Add(Me.TabControl3)
        Me.PanelMyAccount.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMyAccount.Location = New System.Drawing.Point(4, 4)
        Me.PanelMyAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMyAccount.Name = "PanelMyAccount"
        Me.PanelMyAccount.Size = New System.Drawing.Size(1, 610)
        Me.PanelMyAccount.TabIndex = 11
        Me.PanelMyAccount.Visible = False
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(16, 16)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1243, 560)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCancelAcc)
        Me.TabPage2.Controls.Add(Me.btnSaveAcc)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1235, 530)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "My Account"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancelAcc
        '
        Me.btnCancelAcc.Location = New System.Drawing.Point(1108, 483)
        Me.btnCancelAcc.Name = "btnCancelAcc"
        Me.btnCancelAcc.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelAcc.TabIndex = 9
        Me.btnCancelAcc.Text = "Cancel"
        Me.btnCancelAcc.UseVisualStyleBackColor = True
        '
        'btnSaveAcc
        '
        Me.btnSaveAcc.Location = New System.Drawing.Point(1019, 483)
        Me.btnSaveAcc.Name = "btnSaveAcc"
        Me.btnSaveAcc.Size = New System.Drawing.Size(86, 29)
        Me.btnSaveAcc.TabIndex = 8
        Me.btnSaveAcc.Text = "Update"
        Me.btnSaveAcc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRetypeNPass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAccNPassword)
        Me.GroupBox1.Controls.Add(Me.txtAccPassword)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAccUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 265)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
        '
        'txtRetypeNPass
        '
        Me.txtRetypeNPass.BackColor = System.Drawing.SystemColors.Info
        Me.txtRetypeNPass.Location = New System.Drawing.Point(198, 182)
        Me.txtRetypeNPass.MaxLength = 20
        Me.txtRetypeNPass.Name = "txtRetypeNPass"
        Me.txtRetypeNPass.Size = New System.Drawing.Size(253, 25)
        Me.txtRetypeNPass.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Re-type Password"
        '
        'txtAccNPassword
        '
        Me.txtAccNPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtAccNPassword.Location = New System.Drawing.Point(200, 139)
        Me.txtAccNPassword.MaxLength = 20
        Me.txtAccNPassword.Name = "txtAccNPassword"
        Me.txtAccNPassword.Size = New System.Drawing.Size(253, 25)
        Me.txtAccNPassword.TabIndex = 6
        '
        'txtAccPassword
        '
        Me.txtAccPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtAccPassword.Location = New System.Drawing.Point(200, 93)
        Me.txtAccPassword.MaxLength = 20
        Me.txtAccPassword.Name = "txtAccPassword"
        Me.txtAccPassword.Size = New System.Drawing.Size(253, 25)
        Me.txtAccPassword.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "New Password"
        '
        'txtAccUsername
        '
        Me.txtAccUsername.BackColor = System.Drawing.SystemColors.Info
        Me.txtAccUsername.Enabled = False
        Me.txtAccUsername.Location = New System.Drawing.Point(200, 46)
        Me.txtAccUsername.MaxLength = 20
        Me.txtAccUsername.Name = "txtAccUsername"
        Me.txtAccUsername.Size = New System.Drawing.Size(253, 25)
        Me.txtAccUsername.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Old Password"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.btnCancelNewAcc)
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(1235, 530)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Add Account"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAddMinitial)
        Me.GroupBox3.Controls.Add(Me.txtAddFname)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAddLname)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 290)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 195)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Information"
        '
        'txtAddMinitial
        '
        Me.txtAddMinitial.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddMinitial.Location = New System.Drawing.Point(200, 139)
        Me.txtAddMinitial.MaxLength = 3
        Me.txtAddMinitial.Name = "txtAddMinitial"
        Me.txtAddMinitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddMinitial.Size = New System.Drawing.Size(253, 25)
        Me.txtAddMinitial.TabIndex = 6
        '
        'txtAddFname
        '
        Me.txtAddFname.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddFname.Location = New System.Drawing.Point(200, 93)
        Me.txtAddFname.MaxLength = 50
        Me.txtAddFname.Name = "txtAddFname"
        Me.txtAddFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddFname.Size = New System.Drawing.Size(253, 25)
        Me.txtAddFname.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Middle Initial"
        '
        'txtAddLname
        '
        Me.txtAddLname.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddLname.Location = New System.Drawing.Point(200, 46)
        Me.txtAddLname.MaxLength = 50
        Me.txtAddLname.Name = "txtAddLname"
        Me.txtAddLname.Size = New System.Drawing.Size(253, 25)
        Me.txtAddLname.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Last Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "First Name"
        '
        'btnCancelNewAcc
        '
        Me.btnCancelNewAcc.Location = New System.Drawing.Point(1108, 483)
        Me.btnCancelNewAcc.Name = "btnCancelNewAcc"
        Me.btnCancelNewAcc.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelNewAcc.TabIndex = 8
        Me.btnCancelNewAcc.Text = "Cancel"
        Me.btnCancelNewAcc.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1019, 483)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 29)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txtAddCPassword)
        Me.GroupBox2.Controls.Add(Me.txtAddPassword)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAddUsername)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 234)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Information"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 193)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAddCPassword
        '
        Me.txtAddCPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddCPassword.Location = New System.Drawing.Point(200, 139)
        Me.txtAddCPassword.MaxLength = 20
        Me.txtAddCPassword.Name = "txtAddCPassword"
        Me.txtAddCPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddCPassword.Size = New System.Drawing.Size(253, 25)
        Me.txtAddCPassword.TabIndex = 3
        '
        'txtAddPassword
        '
        Me.txtAddPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddPassword.Location = New System.Drawing.Point(200, 93)
        Me.txtAddPassword.MaxLength = 20
        Me.txtAddPassword.Name = "txtAddPassword"
        Me.txtAddPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddPassword.Size = New System.Drawing.Size(253, 25)
        Me.txtAddPassword.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Re-type Password"
        '
        'txtAddUsername
        '
        Me.txtAddUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddUsername.Location = New System.Drawing.Point(200, 46)
        Me.txtAddUsername.MaxLength = 20
        Me.txtAddUsername.Name = "txtAddUsername"
        Me.txtAddUsername.Size = New System.Drawing.Size(253, 25)
        Me.txtAddUsername.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Password"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication8.My.Resources.Resources._18579184_10154916342537415_421547549_n
        Me.PictureBox1.Location = New System.Drawing.Point(16, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblDateTimenow
        '
        Me.lblDateTimenow.AutoSize = True
        Me.lblDateTimenow.Location = New System.Drawing.Point(615, 53)
        Me.lblDateTimenow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateTimenow.Name = "lblDateTimenow"
        Me.lblDateTimenow.Size = New System.Drawing.Size(51, 17)
        Me.lblDateTimenow.TabIndex = 17
        Me.lblDateTimenow.Text = "Label1"
        '
        'lblUserInformation
        '
        Me.lblUserInformation.AutoSize = True
        Me.lblUserInformation.Font = New System.Drawing.Font("Lucida Sans", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInformation.Location = New System.Drawing.Point(612, 26)
        Me.lblUserInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserInformation.Name = "lblUserInformation"
        Me.lblUserInformation.Size = New System.Drawing.Size(70, 22)
        Me.lblUserInformation.TabIndex = 18
        Me.lblUserInformation.Text = "Label1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelMyAccount)
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSupplierPrices)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(302, 198)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(27, 618)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'frmFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1608, 834)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblUserInformation)
        Me.Controls.Add(Me.lblDateTimenow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFinance"
        Me.Text = "Acro Distribution Network Incorporated"
        Me.Panel1.ResumeLayout(False)
        Me.PanelRequest.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpToEvaluate.ResumeLayout(False)
        Me.grpToEvaluate.PerformLayout()
        CType(Me.dgvListofItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        CType(Me.dgvPendingPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSupplierPrices.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvViewSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvItemofSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMyAccount.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents PanelRequest As System.Windows.Forms.Panel
    Friend WithEvents btnSupplierPrices As System.Windows.Forms.Button
    Friend WithEvents btnMyAccount As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents panelSupplierPrices As System.Windows.Forms.Panel
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents PanelMyAccount As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnViewItems As System.Windows.Forms.Button
    Friend WithEvents dgvPendingPO As System.Windows.Forms.DataGridView
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvViewSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvItemofSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents grpRequest As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListofItem As System.Windows.Forms.DataGridView
    Friend WithEvents grpToEvaluate As System.Windows.Forms.GroupBox
    Friend WithEvents lblPurchaseOrderId As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancelAcc As System.Windows.Forms.Button
    Friend WithEvents btnSaveAcc As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRetypeNPass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAccNPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtAccPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAccUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddCPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtAddPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelNewAcc As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddMinitial As System.Windows.Forms.TextBox
    Friend WithEvents txtAddFname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddLname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDateTimenow As System.Windows.Forms.Label
    Friend WithEvents lblUserInformation As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

End Class
