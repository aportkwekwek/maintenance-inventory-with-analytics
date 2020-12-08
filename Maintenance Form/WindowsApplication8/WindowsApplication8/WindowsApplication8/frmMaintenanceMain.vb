Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmMaintenanceMain
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim sqlds As New DataSet
    Dim imgLoc, img2Loc As String
    Dim lvItemsTaken, lv, lvtechnicianMaintenance As ListViewItem
    Dim numberofStocks, totalPriceInventory As Integer
    Dim numberstockz, newVal, currPrice As Integer
    Dim itemidforNew As String
    Dim newTotPrice, oldTotPrice, truckworth As Double

  

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        'Dim query As String
        'query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"

        'sqlcon.ConnectionString = query
        'sqlcon.Open()

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()


        getStocksReady()
        getmaxidoftech()
        getalltechnician()
        viewstocks()

        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        PanelInventory.Width = 1
        PanelTruck.Width = 1
        PanelPO.Width = 1
        PanelTechnician.Width = 1
        PanelMyAccount.Width = 1

        gbEditItemProperties.Visible = False
        getcategory()

        autopurchaseorderid()

        gettruckiditemid()
        getgetwew()
        
        Timer1.Start()

    End Sub
   

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
    End Sub


    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim i As Double


        InventorySlideBack()


        If PanelInventory.Width = 1 Then
            btnInventory.BackColor = Color.Blue
            Do While i <= PanelInventory.Width - 1
                PanelInventory.Width = 50 + i
                i += 1
                PanelInventory.Visible = True
                If PanelInventory.Width = 1000 Then

                    Exit Sub
                End If
            Loop
        Else
            Do While PanelInventory.Width >= 1
                btnInventory.BackColor = Color.RoyalBlue
                PanelInventory.Width = PanelInventory.Width - 1
                If PanelInventory.Width = 1 Then
                    PanelInventory.Visible = False
                    Exit Sub
                End If
            Loop

        End If
    End Sub

    Private Sub btnTruck_Click(sender As Object, e As EventArgs) Handles btnTruck.Click
        Dim i As Double
        TruckSlideBack()

        If PanelTruck.Width = 1 Then
            btnTruck.BackColor = Color.Blue
            Do While i <= PanelTruck.Width - 1
                PanelTruck.Width = 50 + i
                i += 1
                PanelTruck.Visible = True
                If PanelTruck.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelTruck.Width >= 1
                btnTruck.BackColor = Color.RoyalBlue
                PanelTruck.Width = PanelTruck.Width - 1

                If PanelTruck.Width = 1 Then
                    PanelTruck.Visible = False
                    Exit Sub
                End If
            Loop

        End If

    End Sub

    Private Sub btnPO_Click(sender As Object, e As EventArgs) Handles btnPO.Click
        Dim i As Double

        itemsOnQueue()

        POSlideBack()

        If PanelPO.Width = 1 Then
            btnPO.BackColor = Color.Blue
            Do While i <= PanelPO.Width - 1
                PanelPO.Width = 50 + i
                i += 1
                PanelPO.Visible = True
                If PanelPO.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelPO.Width >= 1
                btnPO.BackColor = Color.RoyalBlue
                PanelPO.Width = PanelPO.Width - 1

                If PanelPO.Width = 1 Then
                    PanelPO.Visible = False
                    Exit Sub
                End If
            Loop

        End If

    End Sub


    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        Dim i As Double

        MyAccountSlideBack()

        If PanelMyAccount.Width = 1 Then
            btnMyAccount.BackColor = Color.Blue
            Do While i <= PanelMyAccount.Width - 1
                PanelMyAccount.Width = 10 + i
                i += 1
                PanelMyAccount.Visible = True
                If PanelMyAccount.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    PanelMyAccount.Visible = False
                    Exit Sub
                End If
            Loop

        End If
    End Sub


    Public Function InventorySlideBack()

        If PanelTruck.Width = 1000 Then
            Do While PanelTruck.Width >= 1
                btnTruck.BackColor = Color.RoyalBlue
                PanelTruck.Width = PanelTruck.Width - 1
                If PanelTruck.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTechnician.Width = 1000 Then
            Do While PanelTechnician.Width >= 1
                btnTechnician.BackColor = Color.RoyalBlue
                PanelTechnician.Width = PanelTechnician.Width - 1
                If PanelTechnician.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelPO.Width = 1000 Then
            Do While PanelPO.Width >= 1
                btnPO.BackColor = Color.RoyalBlue
                PanelPO.Width = PanelPO.Width - 1
                If PanelPO.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelInventory.Visible = True
        PanelTruck.Visible = False
        PanelPO.Visible = False
        PanelTechnician.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function TruckSlideBack()

        If PanelInventory.Width = 1000 Then
            Do While PanelInventory.Width >= 1
                btnInventory.BackColor = Color.RoyalBlue
                PanelInventory.Width = PanelInventory.Width - 1
                If PanelInventory.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTechnician.Width = 1000 Then
            Do While PanelTechnician.Width >= 1
                btnTechnician.BackColor = Color.RoyalBlue
                PanelTechnician.Width = PanelTechnician.Width - 1
                If PanelTechnician.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelPO.Width = 1000 Then
            Do While PanelPO.Width >= 1
                btnPO.BackColor = Color.RoyalBlue
                PanelPO.Width = PanelPO.Width - 1
                If PanelPO.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelInventory.Visible = False
        PanelTruck.Visible = True
        PanelPO.Visible = False
        PanelTechnician.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function POSlideBack()

        If PanelInventory.Width = 1000 Then
            Do While PanelInventory.Width >= 1
                btnInventory.BackColor = Color.RoyalBlue
                PanelInventory.Width = PanelInventory.Width - 1
                If PanelInventory.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTechnician.Width = 1000 Then
            Do While PanelTechnician.Width >= 1
                btnTechnician.BackColor = Color.RoyalBlue
                PanelTechnician.Width = PanelTechnician.Width - 1
                If PanelTechnician.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTruck.Width = 1000 Then
            Do While PanelTruck.Width >= 1
                btnTruck.BackColor = Color.RoyalBlue
                PanelTruck.Width = PanelTruck.Width - 1
                If PanelTruck.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelInventory.Visible = False
        PanelTruck.Visible = False
        PanelPO.Visible = True
        PanelTechnician.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function MyAccountSlideBack()

        If PanelInventory.Width = 1000 Then
            Do While PanelInventory.Width >= 1
                btnInventory.BackColor = Color.RoyalBlue
                PanelInventory.Width = PanelInventory.Width - 1
                If PanelInventory.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTechnician.Width = 1000 Then
            Do While PanelTechnician.Width >= 1
                btnTechnician.BackColor = Color.RoyalBlue
                PanelTechnician.Width = PanelTechnician.Width - 1
                If PanelTechnician.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelPO.Width = 1000 Then
            Do While PanelPO.Width >= 1
                btnPO.BackColor = Color.RoyalBlue
                PanelPO.Width = PanelPO.Width - 1
                If PanelPO.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTruck.Width = 1000 Then
            Do While PanelTruck.Width >= 1
                btnTruck.BackColor = Color.RoyalBlue
                PanelTruck.Width = PanelTruck.Width - 1
                If PanelTruck.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelInventory.Visible = False
        PanelTruck.Visible = False
        PanelPO.Visible = False
        PanelTechnician.Visible = False
        PanelMyAccount.Visible = True

        Return 0
    End Function
    Public Function ReportsSlideBack()

        If PanelInventory.Width = 1000 Then
            Do While PanelInventory.Width >= 1
                btnInventory.BackColor = Color.RoyalBlue
                PanelInventory.Width = PanelInventory.Width - 1
                If PanelInventory.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelPO.Width = 1000 Then
            Do While PanelPO.Width >= 1
                btnPO.BackColor = Color.RoyalBlue
                PanelPO.Width = PanelPO.Width - 1
                If PanelPO.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelTruck.Width = 1000 Then
            Do While PanelTruck.Width >= 1
                btnTruck.BackColor = Color.RoyalBlue
                PanelTruck.Width = PanelTruck.Width - 1
                If PanelTruck.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelInventory.Visible = False
        PanelTruck.Visible = False
        PanelPO.Visible = False
        PanelTechnician.Visible = True
        PanelMyAccount.Visible = False

        Return 0
    End Function

    Private Sub btnInventoryExit_Click_1(sender As Object, e As EventArgs)
        Do While PanelInventory.Width >= 1
            btnInventory.BackColor = Color.RoyalBlue
            PanelInventory.Width = PanelInventory.Width - 1
            If PanelInventory.Width = 1 Then
                Exit Do
            End If
        Loop


    End Sub


    Private Sub btnUpdateEditProperties_Click(sender As Object, e As EventArgs) Handles btnUpdateEditProperties.Click
        grpItemstoEdit.Enabled = False
        grpPropertiesToEdit.Enabled = False
        txtUpdateQuota.Focus()

        txtUpdateItemModel.Text = lblModeltoUpdate.Text
        txtUpdateItemName.Text = lblDesctoUpdate.Text

        gbEditItemProperties.Visible = True

    End Sub

    Private Sub btnUpdateCancel_Click(sender As Object, e As EventArgs) Handles btnUpdateCancel.Click
        dgvItemstoEdit.ReadOnly = False


        grpItemstoEdit.Enabled = True
        grpPropertiesToEdit.Enabled = True

        gbEditItemProperties.Visible = False

        grpPropertiesToEdit.Enabled = True
        lblItemtoUpdate.Text = ""
        lblDesctoUpdate.Text = ""
        lblModeltoUpdate.Text = ""
        lblQuotatoUpdate.Text = ""

        txtUpdateItemModel.Text = ""
        txtUpdateItemName.Text = ""
        txtUpdateQuota.Text = ""


    End Sub
  
    Private Function getcategory()
        sqlcmd = New SqlCommand("getcategory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "x")
        Dim i As Integer

        While i <= sqlds.Tables("x").Rows.Count - 1

            cmbAddCategory.Items.Add(sqlds.Tables("x").Rows(i).Item(0) & " - " & sqlds.Tables("x").Rows(i).Item(1))
            i += 1
        End While
        Return sqlds

    End Function
    Private Function getgetwew()
        'get All items saved in db

        sqlcmd = New SqlCommand("getgetwew", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "kjkj")

        Dim i As Integer

        While i <= sqlds.Tables("kjkj").Rows.Count - 1
            cmbSwitchParts.Items.Add(sqlds.Tables("kjkj").Rows(i).Item(0) & " - " & sqlds.Tables("kjkj").Rows(i).Item(1) & " - " & sqlds.Tables("kjkj").Rows(i).Item(2))
            '   cboTruckItem.Items.Add(sqlds.Tables("kjkj").Rows(i).Item(0) & " - " & sqlds.Tables("kjkj").Rows(i).Item(1) & " - " & sqlds.Tables("kjkj").Rows(i).Item(2))
            'cboItemList.Items.Add(sqlds.Tables("kjkj").Rows(i).Item(0) & " - " & sqlds.Tables("kjkj").Rows(i).Item(1) & " - " & sqlds.Tables("kjkj").Rows(i).Item(2))

            i += 1
        End While
        Return sqlds

    End Function
    Private Function getStocksReady()
        sqlcmd = New SqlCommand("getStocksReady", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "backspace")

        Dim pg As Integer
        Do While pg <= sqlds.Tables("backspace").Rows.Count - 1
            cboItemMaintenance.Items.Add(sqlds.Tables("backspace").Rows(pg).Item(0) & " - " & sqlds.Tables("backspace").Rows(pg).Item(1) & " - " & sqlds.Tables("backspace").Rows(pg).Item(2))
            'cboTruckItem.Items.Add(sqlds.Tables("backspace").Rows(pg).Item(0) & " - " & sqlds.Tables("backspace").Rows(pg).Item(1) & " - " & sqlds.Tables("backspace").Rows(pg).Item(2))

            pg += 1
        Loop

        Return sqlds

    End Function


       Private Function getalltechnician()
        sqlcmd = New SqlCommand("getTechnicianMaintenance", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "kape")
        Dim o As Integer
        While o <= sqlds.Tables("kape").Rows.Count - 1
            cboTechnicianRepair.Items.Add(sqlds.Tables("kape").Rows(o).Item(0) & " - " &
                                          sqlds.Tables("kape").Rows(o).Item(1) & " - " &
                                          sqlds.Tables("kape").Rows(o).Item(2) & " - " &
                                          sqlds.Tables("kape").Rows(o).Item(3))
            o += 1
        End While
        Return sqlds

    End Function

    Private Function gettruckiditemid()
        sqlcmd = New SqlCommand("getgetaw", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "kkk")
        Dim k As Integer

        While k <= sqlds.Tables("kkk").Rows.Count - 1
            cmbToExchange.Items.Add(sqlds.Tables("kkk").Rows(k).Item(0) & " - " & sqlds.Tables("kkk").Rows(k).Item(1) & " - " & sqlds.Tables("kkk").Rows(k).Item(2))
            ' cmbToTruck.Items.Add((sqlds.Tables("kkk").Rows(k).Item(0) & " - " & sqlds.Tables("kkk").Rows(k).Item(1) & " - " & sqlds.Tables("kkk").Rows(k).Item(2)))
           
            k += 1
        End While
        Return sqlds

    End Function

    Private Function getmaxmaintenanceid()
        sqlcmd = New SqlCommand("automaintenanceid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        Using r = sqlcmd.ExecuteReader
            If r.Read Then
                Dim maintenanceid, month As String
                month = Format(Date.Now, "MM")
                maintenanceid = "M" & month & Format(Mid(r.GetValue(0), 4, 8) + 1, "0####")
                lblmaintenanceid.Text = maintenanceid
                r.Close()

            End If
        End Using
        Return lblmaintenanceid.Text

    End Function

    Private Function getmaxidoftech()
        sqlcmd = New SqlCommand("getmaxTechnician", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        Using i = sqlcmd.ExecuteReader
            If i.Read Then
                Dim id, month As String
                month = Format(Date.Now, "MM")
                id = "AT" & month & Format(Mid(i.GetValue(0), 5, 8) + 1, "0###")

                lblTechid.Text = id
                i.Close()

            End If
        End Using
        Return lblTechid.Text

    End Function
    Private Function autoitemid()
        sqlcmd = New SqlCommand("autoitemid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        Using o = sqlcmd.ExecuteReader
            If o.Read Then
                Dim id, month As String
                month = Format(Date.Now, "MM")
                id = "PR" & month & Format(Mid(o.GetValue(0), 6, 8) + 1, "0###")
                lblInventoryAddItem.Text = id
                o.Close()

            End If

        End Using
        Return lblInventoryAddItem.Text


    End Function
    Private Sub btnAddItemSave_Click(sender As Object, e As EventArgs) Handles btnAddItemSave.Click
        Try
            If txtAddItemModel.Text = Nothing Then
                txtAddItemModel.Text = "N/A"

                Exit Sub

            End If
            If txtAddItemName.Text = Nothing Then
                MessageBox.Show("Please enter the item name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                txtAddItemName.Focus()
                Exit Sub
            End If
            If txtAddQuota.Text = Nothing Then
                MessageBox.Show("Please enter the quota for this item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                txtAddQuota.Focus()
                Exit Sub

            End If


            autoitemid()
            sqlcmd = New SqlCommand("AddItemonInventory", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblInventoryAddItem.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtAddItemModel.Text)
            sqlcmd.Parameters.AddWithValue("@desc", txtAddItemName.Text)
            sqlcmd.Parameters.AddWithValue("@category", Format(Mid(cmbAddCategory.Text, 1, 5)))
            sqlcmd.Parameters.AddWithValue("@quota", txtAddQuota.Text)
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbAddCategory.Text = Nothing
            txtAddItemModel.Clear()
            txtAddItemName.Clear()
            txtAddQuota.Clear()

            Dim k As Integer
            k = MessageBox.Show("Do you want to add another item?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If k = vbYes Then
                txtAddItemModel.Focus()

            Else
                tabInventories.SelectedIndex = 0

            End If

        Catch ex As Exception
            MessageBox.Show("Please check all your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click


        viewstocks()


    End Sub
    Private Function viewstocks()
        Dim dt80 As New DataTable

        sqlcmd = New SqlCommand("viewNeedofStocks", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt80)

        dgvNeedofStocks.DataSource = dt80
        Return dt80
    End Function

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchItemtoEdit.KeyPress
        If Len(txtSearchItemtoEdit.Text) > 0 Then
            sqlds.Reset()

            sqlcmd = New SqlCommand("itemsToEdit", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@desc", txtSearchItemtoEdit.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtSearchItemtoEdit.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "q")

            dgvItemstoEdit.DataSource = sqlds.Tables("q")

            dgvItemstoEdit.ReadOnly = False

        End If
    End Sub
    Private Sub dgvItemstoEdit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemstoEdit.CellContentClick
        lblItemtoUpdate.Text = dgvItemstoEdit.SelectedCells.Item(0).Value
        lblDesctoUpdate.Text = dgvItemstoEdit.SelectedCells.Item(1).Value
        lblModeltoUpdate.Text = dgvItemstoEdit.SelectedCells.Item(3).Value
        lblQuotatoUpdate.Text = dgvItemstoEdit.SelectedCells.Item(4).Value

        dgvItemstoEdit.Enabled = True


    End Sub

    Private Sub btnUpdateSave_Click(sender As Object, e As EventArgs) Handles btnUpdateSave.Click

        Try
            sqlcmd = New SqlCommand("updateitems", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblItemtoUpdate.Text)
            sqlcmd.Parameters.AddWithValue("@desc", txtUpdateItemName.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtUpdateItemModel.Text)
            sqlcmd.Parameters.AddWithValue("@quota", txtUpdateQuota.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Data updated successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUpdateItemModel.Clear()
            txtUpdateItemName.Clear()
            txtUpdateQuota.Clear()

            grpItemstoEdit.Enabled = True
            grpPropertiesToEdit.Enabled = True
            txtSearchItemtoEdit.Focus()
            gbEditItemProperties.Visible = False

        Catch ex As Exception
            MessageBox.Show("Please check all your inputs!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try
        
    End Sub
    Private Function autopurchaseorderid()
        Dim x2 As String

        'get automatic id for purchase order
        sqlcmd = New SqlCommand("autopurchaseorderid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Using x = sqlcmd.ExecuteReader
            If x.Read Then
                x2 = "P" & Format(Mid(x.GetValue(0), 2, 5) + 1, "0###")
                lblAutoPurchaseOrderID.Text = x2
                x.Close()

            End If

        End Using

        Return lblAutoPurchaseOrderID.Text

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            Dim dx, remarks As String
            dx = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss tt")
            remarks = "PENDING"

            Dim total As Double

            total = Format(Mid(lblAccumulatedTotal.Text, 2, 30))

            sqlcmd = New SqlCommand("requestPO", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblAutoPurchaseOrderID.Text)
            sqlcmd.Parameters.AddWithValue("@date", dx)
            sqlcmd.Parameters.AddWithValue("@remarks", remarks)
            sqlcmd.Parameters.AddWithValue("@total", total)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            For Each item As ListViewItem In lvRequestPO.Items

                sqlcmd = New SqlCommand("purchaseorderitemsss", sqlcon)
                sqlcmd.Parameters.AddWithValue("@id", lblAutoPurchaseOrderID.Text)
                sqlcmd.Parameters.AddWithValue("@psid", item.SubItems(7).Text)
                sqlcmd.Parameters.AddWithValue("@quantity", item.SubItems(4).Text)
                sqlcmd.Parameters.AddWithValue("@price", item.SubItems(5).Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.ExecuteNonQuery()

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlds.Reset()
            lblAccumulatedTotal.Text = "."
            autopurchaseorderid()
            txtRPOQuantity.Clear()
            lvRequestPO.Items.Clear()
            txtSearchItemRequestPO.Clear()
            MessageBox.Show("Request sent", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Try

            Dim quantity, price, subtotal As Double

            Dim listviews As ListViewItem
            quantity = txtRPOQuantity.Text
            price = FormatNumber(dgvRequestDetails.SelectedCells.Item(5).Value)

            subtotal = quantity * price

            subtotal = FormatNumber(subtotal)

            listviews = lvRequestPO.Items.Add(dgvRequestDetails.SelectedCells.Item(0).Value)
            listviews.SubItems.Add(dgvRequestDetails.SelectedCells.Item(1).Value())
            listviews.SubItems.Add(dgvRequestDetails.SelectedCells.Item(2).Value)
            listviews.SubItems.Add(dgvRequestDetails.SelectedCells.Item(3).Value)
            listviews.SubItems.Add(txtRPOQuantity.Text)
            listviews.SubItems.Add(dgvRequestDetails.SelectedCells.Item(5).Value)
            listviews.SubItems.Add(subtotal)
            listviews.SubItems.Add(dgvRequestDetails.SelectedCells.Item(6).Value)

            Dim total As Double = 0

            Dim temporary As ListViewItem

            For Each temporary In lvRequestPO.Items
                total += CDbl(temporary.SubItems.Item(6).Text)
            Next
            lblAccumulatedTotal.Text = "P " & FormatNumber(total)
        Catch ex As Exception
            MessageBox.Show("Please select one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Try
    End Sub
    Private Sub btnMyAccountChangePassword_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Do While PanelTruck.Width >= 1
            btnTruck.BackColor = Color.Transparent
            PanelTruck.Width = PanelTruck.Width - 1
            If PanelTruck.Width = 1 Then
                Exit Do
            End If
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Do While PanelPO.Width >= 1
            btnPO.BackColor = Color.Transparent
            PanelPO.Width = PanelPO.Width - 1
            If PanelPO.Width = 1 Then
                Exit Do
            End If
        Loop
    End Sub

    Private Sub txtSearchItemRequestPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchItemRequestPO.KeyPress
     

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            lvRequestPO.Items.RemoveAt(lvRequestPO.SelectedIndices(0))
            Dim total As Double = 0

            Dim temporary As ListViewItem

            For Each temporary In lvRequestPO.Items
                total += CDbl(temporary.SubItems.Item(6).Text)
            Next
            lblAccumulatedTotal.Text = "P " & FormatNumber(total)
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        sqlds.Reset()
        sqlcmd = New SqlCommand("toinventory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)

        sqlda.Fill(sqlds, "milo")

        dgvReceivedItems.DataSource = sqlds.Tables("milo")

    End Sub


    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles btnRefreshSummary.Click
        sqlds.Reset()

        sqlcmd = New SqlCommand("standbyme", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "earl")

        dgvStandby.DataSource = sqlds.Tables("earl")

        sqlcmd = New SqlCommand("deployedbyme", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "mrlapuz")

        dgvDeployed.DataSource = sqlds.Tables("mrlapuz")

        sqlcmd = New SqlCommand("undermaintenancebyme", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "rodriguez")

        dgvMaintenance.DataSource = sqlds.Tables("rodriguez")
        dgvMaintenance.Columns(3).DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt"

        sqlcmd = New SqlCommand("requesting", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "rentura")

        dgvRequestingforMaintenance.DataSource = sqlds.Tables("rentura")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnRefreshMaintenanceR.Click

        Dim dtr As New DataTable

        dtr.Reset()

        'check all requesting 
        sqlcmd = New SqlCommand("requesting", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dtr)

        dgvNeedToBeMaintained.DataSource = dtr


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If cmbToExchange.Text = Nothing Then
            MessageBox.Show("Please select a truck to have an installation", "System Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbToExchange.Focus()

            Exit Sub

        End If
        If cmbSwitchParts.Text = Nothing Then
            MessageBox.Show("Please select item", "System Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand)
            cmbSwitchParts.Focus()
            Exit Sub

        End If

        Dim k As Integer

        If cboIdentificationPartsexchange.Text = Nothing Then
            k = MessageBox.Show("There are no truck having that item. You can request a purchase order and buy that certain item. Do you want to proceed to purchase order?",
                            "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If k = vbYes Then

                btnCancelForExchange.PerformClick()
                btnPO.PerformClick()
                TabPO.SelectedIndex = 1
                Exit Sub

            Else
                Exit Sub
            End If
        End If

        If txtReasonforExchange.Text = Nothing Then
            MessageBox.Show("Please enter the reason for exchanging parts.", "System Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtReasonforExchange.Focus()
            Exit Sub

        End If


        Try

            'insert data to part exchange table  
            '------------------------------------
            '------------------------------------
            sqlcmd = New SqlCommand("partExchangex", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@totruck", Format(Mid(cmbToExchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@date", Format(Date.Now, "yyyy-MM-dd hh:mm:ss tt"))
            sqlcmd.Parameters.AddWithValue("@fromtruck", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@reason", txtReasonforExchange.Text)
            sqlcmd.Parameters.AddWithValue("@identification", Format(Mid(cboIdentificationPartsexchange.Text, 1, 10)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '------------------End------------------------'



            'update from truck to request for maintenance
            '-------------------------------
            '-------------------------------
            sqlcmd = New SqlCommand("requestForMaintenance", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '-----------------End-----------------------'



            'insert this item as a part of truck 
            '-------------------------------
            '-------------------------------
            sqlcmd = New SqlCommand("insertPartsofTruckfromMaintenance", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cmbToExchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@dateinstalled", Format(Date.Now, "yyyy-MM-dd hh:mm:ss tt"))
            sqlcmd.Parameters.AddWithValue("@identification", Format(Mid(cboIdentificationPartsexchange.Text, 1, 10)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '---------------------End---------------------'



            'get the asset of the selected item 
            '-------------------------------
            '-------------------------------
            sqlcmd = New SqlCommand("updateNumberinStockMaintenance", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cboIdentificationPartsexchange.Text, 1, 10)))
            sqlcmd.Connection = sqlcon
            Using l = sqlcmd.ExecuteReader
                If l.Read Then
                    currPrice = l.GetValue(3)

                Else
                    Exit Sub
                End If
            End Using
            '----------------End------------'



            'get current asset of truck taken then subtract
            '---------------------------------
            '---------------------------------
            sqlcmd = New SqlCommand("getNetworthofTruck", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            Using q = sqlcmd.ExecuteReader
                If q.Read Then
                    truckworth = q.GetValue(0)
                End If
            End Using

            Dim newAsset As Double
            newAsset = truckworth - currPrice
            sqlcmd = New SqlCommand("updateNewWorth", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@newWorth", newAsset)
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '-----------------------------End----------------------'



            'get current asset of truck to have an installation then add
            '---------------------------------
            '---------------------------------
            sqlcmd = New SqlCommand("getNetworthofTruck", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cmbToExchange.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            Using q = sqlcmd.ExecuteReader
                If q.Read Then
                    truckworth = q.GetValue(0)
                End If
            End Using

            Dim newWorth As Double

            newWorth = truckworth + currPrice
            sqlcmd = New SqlCommand("updateNewWorth", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@newWorth", newWorth)
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cmbToExchange.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '-------------------------End------------------------'

            'Move identification to truck 
            '-----------------------------------
            sqlcmd = New SqlCommand("MoveItemtoTruck", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cmbToExchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@id", Format(Mid(cboIdentificationPartsexchange.Text, 1, 10)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            '----------------------End---------------------

            'Remove as part of truck this item
            '----------------------------------
            sqlcmd = New SqlCommand("removethisItem", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cboIdentificationPartsexchange.Text, 1, 10)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Information successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


            btnCancelForExchange.PerformClick()
            btnPartsExchangedata.PerformClick()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles btnPartsExchangedata.Click
        sqlds.Reset()

        sqlcmd = New SqlCommand("getpartexchange", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "aso")

        dgvPartsExchange.DataSource = sqlds.Tables("aso")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnRefreshOrders.Click

        sqlds.Reset()

        sqlcmd = New SqlCommand("pendingPO", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "xyz")

        dgvPendingPO.DataSource = sqlds.Tables("xyz")

        sqlcmd = New SqlCommand("financeapprovalforPO", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "zyx")

        dgvApprovedPO.DataSource = sqlds.Tables("zyx")

    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnTechnician.Click
        Dim i As Double

        cboJob.Items.Clear()
        cboTechnicianDiagnosis.Items.Clear()

        gettechnicianJob()
        ReportsSlideBack()

        If PanelTechnician.Width = 1 Then
            btnTechnician.BackColor = Color.Blue
            Do While i <= PanelTechnician.Width - 1
                PanelTechnician.Width = 10 + i
                i += 1
                PanelTechnician.Visible = True
                If PanelTechnician.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelTechnician.Width >= 1
                btnTechnician.BackColor = Color.RoyalBlue
                PanelTechnician.Width = PanelTechnician.Width - 1

                If PanelTechnician.Width = 1 Then
                    PanelTechnician.Visible = False
                    Exit Sub
                End If
            Loop

        End If

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchTechnician.KeyPress
        sqlds.Reset()

        Try
            If txtSearchTechnician.TextLength > 1 Then
                sqlcmd = New SqlCommand("getTechnician", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@id", txtSearchTechnician.Text)
                sqlcmd.Parameters.AddWithValue("@lname", txtSearchTechnician.Text)
                sqlcmd.Parameters.AddWithValue("@fname", txtSearchTechnician.Text)
                sqlcmd.Connection = sqlcon

                sqlda = New SqlDataAdapter(sqlcmd)
                sqlda.Fill(sqlds, "wakwak")
                dgvTechnicians.DataSource = sqlds.Tables("wakwak")

            End If

        Catch ex As Exception

            Exit Sub

        End Try



    End Sub


    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click

        Try

            Dim dlg As New OpenFileDialog
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            dlg.Title = "Select Technician Image"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgLoc = dlg.FileName.ToString
                picTechnician.ImageLocation = imgLoc

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveTech_Click(sender As Object, e As EventArgs) Handles btnSaveTech.Click
        Try
            sqlcmd = New SqlCommand("getTechniciansWorking", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@lname", txtTechLastName.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtTechFirstName.Text)
            sqlcmd.Connection = sqlcon
            Using qq = sqlcmd.ExecuteReader
                If qq.Read Then
                    MessageBox.Show("The system already has an information regarding this person", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
            End Using
        Catch ex As Exception

            Exit Sub

        End Try





        Try
            Dim ms As New MemoryStream
            picTechnician.Image.Save(ms, picTechnician.Image.RawFormat)
            sqlcmd = New SqlCommand("insertTechnician", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblTechid.Text)
            sqlcmd.Parameters.AddWithValue("@lname", txtTechLastName.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtTechFirstName.Text)
            sqlcmd.Parameters.AddWithValue("@minitial", txtTechMinitial.Text)
            sqlcmd.Parameters.AddWithValue("@contact", txtTechContact.Text)
            sqlcmd.Parameters.AddWithValue("@techjob", Format(Mid(cboJob.Text, 1, 5)))
            sqlcmd.Parameters.AddWithValue("@picture", SqlDbType.Image).Value = ms.ToArray
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Technician Successfully saved!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtTechLastName.Clear()
            txtTechFirstName.Clear()
            txtTechMinitial.Clear()
            txtTechContact.Clear()
            cboTechnicianRepair.Items.Clear()
            getalltechnician()

            picTechnician.Image = My.Resources.red

            getmaxidoftech()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try


    End Sub

    Private Sub txtTechLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechLastName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 18
            Case 47 To 58

                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTechFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechFirstName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 18
            Case 47 To 58

                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTechMinitial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechMinitial.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 18
            Case 47 To 58

                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTechContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechContact.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 18
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub dgvTechnicians_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTechnicians.CellClick

        Try
            Dim identifier As String
            identifier = dgvTechnicians.SelectedCells.Item(0).Value
            sqlcmd = New SqlCommand("getpicture", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", identifier)
            sqlcmd.Connection = sqlcon

            Dim table As New DataTable

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(table)


            Dim img() As Byte

            img = table.Rows(0)(6)

            Dim ms As New MemoryStream(img)

            picSelectedTech.Image = Image.FromStream(ms)


        Catch ex As Exception
            picSelectedTech.Image = My.Resources.red

        End Try


    End Sub


    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ReportViewer.Show()
        ReportViewer.Focus()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim i As Integer
        i = MessageBox.Show("Are you sure you want to mark this item as complete?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If i = vbYes Then

            Try
                Dim description, model As String
                description = dgvReceivedItems.SelectedCells.Item(1).Value
                model = dgvReceivedItems.SelectedCells.Item(2).Value

                Dim purchaseorderID As String
                purchaseorderID = dgvReceivedItems.SelectedCells.Item(0).Value
                Dim receivedNumber As Integer
                receivedNumber = dgvReceivedItems.SelectedCells.Item(4).Value

                sqlcmd = New SqlCommand("MoveItemtoInventory", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@pid", purchaseorderID)
                sqlcmd.Parameters.AddWithValue("@qty", dgvReceivedItems.SelectedCells.Item(3).Value)
                sqlcmd.Parameters.AddWithValue("@qreceived", receivedNumber)
                sqlcmd.Parameters.AddWithValue("@date", dgvReceivedItems.SelectedCells.Item(5).Value)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                sqlcmd = New SqlCommand("markasComplete", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@pid", purchaseorderID)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()



                MessageBox.Show("Information Successfully Saved!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Please Select at least one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            End Try

            sqlds.Reset()

            sqlcmd = New SqlCommand("toinventory", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlda = New SqlDataAdapter(sqlcmd)

            sqlda.Fill(sqlds, "milo")

            dgvReceivedItems.DataSource = sqlds.Tables("milo")
        Else
            MessageBox.Show("Nothing happened", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            sqlcmd = New SqlCommand("toinventory", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using k = sqlcmd.ExecuteReader
                If k.Read Then
                    btnInventory.Image = My.Resources.red1
                Else
                    btnInventory.Image = Nothing

                End If
            End Using

            lblDateTime.Text = Format(Date.Now, "yyyy-MM-dd hh:mm:ss")

        Catch ex As Exception
            Me.Enabled = False
            ErrorPage.Show()
            ErrorPage.Focus()
            Timer1.Stop()

            Exit Sub

        End Try

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cboItemID.Text = Nothing Then
            MessageBox.Show("Please select at least one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If
        Dim pgup, pgdown As String

        pgup = Format(Mid(cboItemID.Text, 1, 10))
        pgdown = Format(Mid(cboItemID.Text, 14, 100))
        getmaxmaintenanceid()

        Dim mainteid As String
        mainteid = getmaxmaintenanceid()

        lvItemsTaken = lvMaintenanceItems.Items.Add(mainteid)
        lvItemsTaken.SubItems.Add(pgup)
        lvItemsTaken.SubItems.Add(pgdown)

        cboItemID.Items.RemoveAt(cboItemID.SelectedIndex)
        cboItemID.Text = Nothing

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lol As Integer
        If lbltruckIDmaintenance.Text = "." Then
            MessageBox.Show("The system can't save blank item!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If lvMaintenanceTechnicians.Items.Count = Nothing Then
            MessageBox.Show("Please select at least One(1) technician to fix the truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
        lol = MessageBox.Show("All information will be saved. Continue?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If lol = vbYes Then
            Try

                Dim type As String

                type = "Minor"

                getmaxmaintenanceid()
                Dim mainteid As String
                mainteid = getmaxmaintenanceid()


                'Inserting into table Maintenance
                ' --------------------------------
                '---------------------------------

                sqlcmd = New SqlCommand("savemaintenance", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@idofmaintenance", mainteid)
                sqlcmd.Parameters.AddWithValue("@idoftruck", lbltruckIDmaintenance.Text)
                sqlcmd.Parameters.AddWithValue("@datestart", dtpDateRepairStart.Value)
                sqlcmd.Parameters.AddWithValue("@type", type)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteReader()

                'Multple Save into Maintenance Technicians
                '-----------------------------------------
                '-----------------------------------------
                For Each technicians As ListViewItem In lvMaintenanceTechnicians.Items

                    sqlcmd = New SqlCommand("assignTechMaintenance", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@maintenanceid", technicians.SubItems(2).Text)
                    sqlcmd.Parameters.AddWithValue("@techid", technicians.SubItems(0).Text)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                Next

                'Updating Truck into Status Under Maintenance
                '--------------------------------------------
                '--------------------------------------------
                sqlcmd = New SqlCommand("updateTruckMaintenance", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@id", lbltruckIDmaintenance.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                For Each i As ListViewItem In lvMaintenanceItems.Items
                    Dim itemIdentificationP As String
                    itemIdentificationP = i.SubItems(1).Text

                    'Updating item identification from inventory to truck
                    '---------------------------------------------------
                    '---------------------------------------------------
                    sqlcmd = New SqlCommand("MoveItemtoTruck", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                    sqlcmd.Parameters.AddWithValue("@id", itemIdentificationP)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                    'Inserting parts of truck
                    '-----------------------
                    '-----------------------
                    sqlcmd = New SqlCommand("insertPartsofTruckfromMaintenance", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                    sqlcmd.Parameters.AddWithValue("@dateinstalled", dtpDateRepairStart.Value)
                    sqlcmd.Parameters.AddWithValue("@identification", itemIdentificationP)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                Next


                ' Multiple Save into Maintenance Items
                '-------------------------------------
                '-------------------------------------

                For Each item As ListViewItem In lvMaintenanceItems.Items

                    sqlcmd = New SqlCommand("insertTomaintenanceItems", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@mainteid", item.SubItems(0).Text)
                    sqlcmd.Parameters.AddWithValue("@itemtaken", item.SubItems(1).Text)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()


                Next

                'Mark Truck as modified 
                '----------------------------
                '----------------------------
                sqlcmd = New SqlCommand("setTrucktoModified", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()


                'Calling the price of the items from itemtable and itemidentification table 
                '---------------------------------------------------------------
                '---------------------------------------------------------------

                For Each i As ListViewItem In lvMaintenanceItems.Items
                    Dim itemTaken As String
                    itemTaken = i.SubItems(1).Text
                    sqlcmd = New SqlCommand("updateNumberinStockMaintenance", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@itemid", itemTaken)
                    sqlcmd.Connection = sqlcon
                    Using l = sqlcmd.ExecuteReader
                        If l.Read Then
                            numberstockz = l.GetValue(1)
                            newVal = numberstockz - 1
                            itemidforNew = l.GetValue(2)
                            currPrice = l.GetValue(3)
                            oldTotPrice = l.GetValue(4)

                        Else
                            Exit Sub
                        End If

                    End Using


                    Dim newTotPrice As Double
                    newTotPrice = oldTotPrice - currPrice

                    'updating number of stocks and total price of a certain item in the inventory 
                    '---------------------------------------------
                    '---------------------------------------------
                    sqlcmd = New SqlCommand("updatenumberofstocks", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@id", itemidforNew)
                    sqlcmd.Parameters.AddWithValue("@new", newVal)
                    sqlcmd.Parameters.AddWithValue("@price", newTotPrice)
                    sqlcmd.Parameters.AddWithValue("@id2", itemidforNew)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                    'Get Current net Worth of truck
                    '-------------------------------------
                    '-------------------------------------
                    sqlcmd = New SqlCommand("getNetworthofTruck", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                    sqlcmd.Connection = sqlcon
                    Using f = sqlcmd.ExecuteReader
                        If f.Read Then
                            truckworth = f.GetValue(0)
                        End If
                    End Using

                    Dim newTworth As Double
                    newTworth = truckworth + currPrice


                    'Add net value of truck 
                    '------------------------
                    '------------------------
                    sqlcmd = New SqlCommand("updateNewWorth", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@newWorth", newTworth)
                    sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()


                Next

                MessageBox.Show("Information successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                btnCancelAll.PerformClick()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show("The information you saved is invalid", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try
        Else
            MessageBox.Show("No information is saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancelAll.Click
        Try
            dgvMaintenance.Refresh()
            lvMaintenanceTechnicians.Items.Clear()
            lvMaintenanceItems.Items.Clear()
            lbltruckIDmaintenance.Text = ""
            cboTechnicianRepair.Text = Nothing
            cboItemID.Text = Nothing
            cboItemMaintenance.Text = Nothing
            sqlds.Reset()
            btnRefreshMaintenanceR.PerformClick()
            TabTruck.SelectedIndex = 0


        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub txtRPOQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRPOQuantity.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Public Function getTruckHavingthatitem()
        Try
            cboFromTruckexchange.Items.Clear()

            sqlcmd = New SqlCommand("GetItemsWith", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cmbSwitchParts.Text, 1, 8)))
            sqlcmd.Connection = sqlcon
            

            Dim dt21 As New DataTable
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt21)
            Dim k As Integer
            While k <= dt21.Rows.Count - 1
                cboFromTruckexchange.Items.Add(dt21.Rows(k).Item(2) & " - " & dt21.Rows(k).Item(3))
                k += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Return cboFromTruckexchange.Items


    End Function
    Private Sub cmbSwitchParts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSwitchParts.SelectedIndexChanged
        Try
            getTruckHavingthatitem()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnEditMyacc_Click(sender As Object, e As EventArgs) Handles btnEditMyacc.Click

        sqlcmd = New SqlCommand("getAccountInfo", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text)
        sqlcmd.Parameters.AddWithValue("@pass", txtPassword.Text)
        sqlcmd.Connection = sqlcon
        Using k = sqlcmd.ExecuteReader
            If k.Read Then
            Else
                MessageBox.Show("Incorrect Password!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If
        End Using


        If txtNewPass.Text = txtPassword.Text Then


            Dim i As Integer
            i = MessageBox.Show("Are you sure you want to update your account?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbYes Then

                sqlcmd = New SqlCommand("updatepass", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@userid", txtUsername.Text)
                sqlcmd.Parameters.AddWithValue("@userpass", txtNewPass.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Information successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Clear()
                txtNewPass.Clear()

            Else

                Exit Sub

            End If

        Else

            MessageBox.Show("Please re-check your new password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNewPass.Focus()
            txtNewPass.SelectAll()

        End If
    End Sub

    Private Sub txtQtyMaintenance_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub


    Private Sub cboItemMaintenance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemMaintenance.SelectedIndexChanged
        sqlds.Reset()
        cboItemID.Items.Clear()

        Try

            sqlcmd = New SqlCommand("getIdentificationsAll", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cboItemMaintenance.Text, 1, 8)))
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "hijk")

            Dim ctr As Integer

            Do While ctr <= sqlds.Tables("hijk").Rows.Count - 1
                cboItemID.Items.Add(sqlds.Tables("hijk").Rows(ctr).Item(0) & " - " & sqlds.Tables("hijk").Rows(ctr).Item(1) & " - " & sqlds.Tables("hijk").Rows(ctr).Item(2) & " - Price " & sqlds.Tables("hijk").Rows(ctr).Item(3))
                ctr += 1

            Loop

        Catch ex As Exception
            Exit Sub
        End Try


    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim added2, added3, compiled As String

            Dim room As ListViewItem

            For Each room In lvMaintenanceItems.SelectedItems
                added2 = room.SubItems(1).Text
                added3 = room.SubItems(2).Text
                compiled = added2 & " - " & added3
                cboItemID.Items.Add(compiled)

            Next

        Catch ex As Exception

            Exit Sub

        End Try

        Try

            lvMaintenanceItems.Items.RemoveAt(lvMaintenanceItems.SelectedIndices(0))
            MessageBox.Show("Item Removed!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If cboTechnicianRepair.Text = Nothing Then
            MessageBox.Show("Please select technician if you want to add", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If
        Try
            getmaxmaintenanceid()
            Dim mainteid As String
            mainteid = getmaxmaintenanceid()
            Dim technicianMaintenanceID, technicianFullName As String
            technicianFullName = Format(Mid(cboTechnicianRepair.Text, 12, 200))
            technicianMaintenanceID = Format(Mid(cboTechnicianRepair.Text, 1, 8))
            lvtechnicianMaintenance = lvMaintenanceTechnicians.Items.Add(technicianMaintenanceID)
            lvtechnicianMaintenance.SubItems.Add(technicianFullName)
            lvtechnicianMaintenance.SubItems.Add(mainteid)

            cboTechnicianRepair.Items.RemoveAt(cboTechnicianRepair.SelectedIndex)

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim techRepairz As ListViewItem
            Dim techidz, fullcbombo, midcombo As String


            For Each techRepairz In lvMaintenanceTechnicians.SelectedItems
                techidz = techRepairz.SubItems(0).Text
                midcombo = techRepairz.SubItems(1).Text
                fullcbombo = techidz & " - " & midcombo
                cboTechnicianRepair.Items.Add(fullcbombo)

            Next

            lvMaintenanceTechnicians.Items.RemoveAt(lvMaintenanceTechnicians.SelectedIndices(0))

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub dgvNeedToBeMaintained_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvNeedToBeMaintained.MouseClick
        Try
            sqlds.Reset()

            Dim truckid As String

            truckid = dgvNeedToBeMaintained.SelectedCells.Item(0).Value
            TabTruck.SelectedIndex = 2
            lbltruckIDmaintenance.Text = truckid


            sqlcmd = New SqlCommand("getTruckMaintained", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", truckid)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "xxx")

            dgvForMaintenance.DataSource = sqlds.Tables("xxx")

        Catch ex As Exception
            MessageBox.Show("Please select truck to be repair/maintained.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End Try

    End Sub

    Private Sub dgvMaintenance_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvMaintenance.MouseClick


        Dim maintenanceOrder, truckid As String
        Try
            maintenanceOrder = dgvMaintenance.SelectedCells.Item(0).Value
            MaintenanceRepairSummary.lblWorkOrder.Text = maintenanceOrder

            MaintenanceRepairSummary.lblDateStart.Text = dgvMaintenance.SelectedCells.Item(3).FormattedValue
            MaintenanceRepairSummary.lblTruckID.Text = dgvMaintenance.SelectedCells.Item(1).Value
            truckid = dgvMaintenance.SelectedCells.Item(1).Value


        Catch ex As Exception

            MessageBox.Show("Please select one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Exit Sub

        End Try

        Try
            sqlds.Reset()

            MaintenanceRepairSummary.Show()


            sqlcmd = New SqlCommand("maintenanceDone", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", maintenanceOrder)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "oi")

            MaintenanceRepairSummary.dgvTruckInfo.DataSource = sqlds.Tables("oi")


            'get technician/s repaired the truck
            sqlcmd = New SqlCommand("maintenanceTechnicianDone", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", maintenanceOrder)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "we")

            MaintenanceRepairSummary.dgvTechniciansWorking.DataSource = sqlds.Tables("we")


            'get items installed on truck
            sqlcmd = New SqlCommand("getItemsonMaintenanceNotDone", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", truckid)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "joke")

            MaintenanceRepairSummary.dgvItemsInstalled.DataSource = sqlds.Tables("joke")

        Catch ex As Exception
            MessageBox.Show("Please select one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try


    End Sub

    Private Sub cboItemIdentificationExchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFromTruckexchange.SelectedIndexChanged

        cboIdentificationPartsexchange.Items.Clear()


        Try
            sqlcmd = New SqlCommand("FromTruckHaving", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboFromTruckexchange.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cmbSwitchParts.Text, 1, 8)))
            sqlcmd.Connection = sqlcon

            Dim dt30 As New DataTable

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt30)

            Dim k As Integer

            Do While k < dt30.Rows.Count
                cboIdentificationPartsexchange.Items.Add(dt30.Rows(k).Item(0) & " -  Date Installed " & dt30.Rows(k).Item(6))
                k += 1
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Dim o As Integer
        o = MessageBox.Show("Are you sure you want to remove this item from truck", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If o = vbNo Then
            Exit Sub
        Else
            Try

                'mark item ended in truck 
                sqlcmd = New SqlCommand("markItemasUninstalled", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                sqlcmd.Parameters.AddWithValue("@dateProb", lblDateTime.Text)
                sqlcmd.Parameters.AddWithValue("@identification", dgvForMaintenance.SelectedCells.Item(2).Value)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                'mark this item ended
                sqlcmd = New SqlCommand("markitemEnded", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@dateexpired", lblDateTime.Text)
                sqlcmd.Parameters.AddWithValue("@identification", dgvForMaintenance.SelectedCells.Item(2).Value)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Item removed from the truck!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Refresh the datagridview 
                sqlds.Reset()

                Dim dtx As New DataTable

                sqlcmd = New SqlCommand("getTruckMaintained", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lbltruckIDmaintenance.Text)
                sqlcmd.Connection = sqlcon

                sqlda = New SqlDataAdapter(sqlcmd)
                sqlda.Fill(dtx)


                dgvForMaintenance.DataSource = dtx

            Catch ex As Exception
                MessageBox.Show("Please select item to be removed!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SupplierItemAnalysis.Show()
        SupplierItemAnalysis.Focus()

    End Sub

    Private Sub dgvTechnicianForAnalysis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTechnicianForAnalysis.CellClick
        Try
            Dim techid As String
            Dim average, hours, summation As Double

            techid = dgvTechnicianForAnalysis.SelectedCells.Item(0).Value
            sqlcmd = New SqlCommand("technicianAnalysis", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@technicianid", techid)
            sqlcmd.Connection = sqlcon

            Dim dt As New DataTable
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt)

            Dim k As Integer

            While k <= dt.Rows.Count - 1
                hours = dt.Rows(k).Item(2)
                k += 1

                summation += hours

            End While
            Dim lname, fname As String
            lname = dgvTechnicianForAnalysis.SelectedCells.Item(1).Value
            fname = dgvTechnicianForAnalysis.SelectedCells.Item(2).Value

            average = summation / k

            lblTotNumberRep.Text = k


        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub dgvStandby_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStandby.CellClick
        Dim truckid As String

        truckid = dgvStandby.SelectedCells.Item(0).Value
        If truckid = Nothing Then
            MessageBox.Show("Please select one(1) truck.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub

        End If
        TruckHistory.lblTruckID.Text = truckid

        TruckHistory.Show()

    End Sub

    Private Sub dgvDeployed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeployed.CellClick
        Dim truckid As String

        truckid = dgvDeployed.SelectedCells.Item(0).Value
        If truckid = Nothing Then
            MessageBox.Show("Please select one(1) truck.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub

        End If
        TruckHistory.lblTruckID.Text = truckid

        TruckHistory.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim techid As String
        techid = dgvTechnicians.SelectedCells.Item(0).Value
        If techid = Nothing Then
            MessageBox.Show("Please select technician", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End If
        tabTechnicianCtrl.SelectedIndex = 3
        txtTechnicianContactToUpdate.Enabled = True
        txtTechnicianfnameToUpdate.Enabled = True
        txtTechnicianLnametoUpdate.Enabled = True
        btnCancelTechnicianToUpdate.Enabled = True
        btnSaveTechnicianToUpdate.Enabled = True
        btnCancelBrowseImageTech.Enabled = True

        Try
            Dim lname, fname, contact, idofTech, minitialtech As String
            lname = dgvTechnicians.SelectedCells.Item(1).Value
            contact = dgvTechnicians.SelectedCells.Item(4).Value
            fname = dgvTechnicians.SelectedCells.Item(2).Value
            minitialtech = dgvTechnicians.SelectedCells.Item(3).Value
            idofTech = dgvTechnicians.SelectedCells.Item(0).Value

            txtTechnicianLnametoUpdate.Text = lname
            txtTechnicianfnameToUpdate.Text = fname
            txtTechnicianContactToUpdate.Text = contact
            txtTechniciantoUpdate.Text = idofTech

        Catch ex As Exception
            Exit Sub

        End Try


    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles btnCancelBrowseImageTech.Click

        Try

            Dim picturez As New OpenFileDialog
            picturez.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            picturez.Title = "Select Technician Image"
            If picturez.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgTechnicianPicToUpdate.Image = Nothing
                img2Loc = picturez.FileName.ToString
                imgTechnicianPicToUpdate.ImageLocation = img2Loc


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnSaveTechnicianToUpdate.Click
        Try
            Dim iswork As String
            If rbtnNoWork.Checked = True Then
                iswork = "NO"
            Else
                iswork = "YES"
            End If

            Dim imgS As New MemoryStream
            imgTechnicianPicToUpdate.Image.Save(imgS, imgTechnicianPicToUpdate.Image.RawFormat)
            sqlcmd = New SqlCommand("updateTechnicianInfowithPic", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@techid", txtTechniciantoUpdate.Text)
            sqlcmd.Parameters.AddWithValue("@pic", SqlDbType.Image).Value = imgS.ToArray
            sqlcmd.Parameters.AddWithValue("@working", iswork)
            sqlcmd.Parameters.AddWithValue("@lname", txtTechnicianLnametoUpdate.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtTechnicianfnameToUpdate.Text)
            sqlcmd.Parameters.AddWithValue("@contactnumber", txtTechnicianContactToUpdate.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Information Successfully saved!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTechniciantoUpdate.Clear()
            txtTechniciantoUpdate.Enabled = False
            txtTechnicianContactToUpdate.Clear()
            txtTechnicianContactToUpdate.Enabled = False
            txtTechnicianfnameToUpdate.Clear()
            txtTechnicianfnameToUpdate.Enabled = False
            txtTechnicianLnametoUpdate.Clear()
            txtTechnicianLnametoUpdate.Enabled = False
            tabTechnicianCtrl.SelectedIndex = 0
            imgTechnicianPicToUpdate.Image = My.Resources.red


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Please check all the information entered", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try


    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        txtAddItemModel.Clear()
        txtAddItemName.Clear()
        txtAddQuota.Clear()
        cmbAddCategory.Text = Nothing

    End Sub

    Private Sub rbtnYesWork_Click(sender As Object, e As EventArgs) Handles rbtnYesWork.Click
        rbtnYesWork.Checked = True
        rbtnNoWork.Checked = False

    End Sub

    Private Sub rbtnNoWork_Click(sender As Object, e As EventArgs) Handles rbtnNoWork.Click
        rbtnNoWork.Checked = True
        rbtnYesWork.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtAddPassword.PasswordChar = Nothing
            txtAddCPassword.PasswordChar = Nothing
        Else
            txtAddPassword.PasswordChar = "*"
            txtAddCPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        If txtAddUsername.Text = Nothing Then
            MessageBox.Show("Please fill in the username", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAddUsername.Focus()
            Exit Sub
        End If
        sqlcmd = New SqlCommand("getUsernameofStaff", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@username", txtAddUsername.Text)
        sqlcmd.Connection = sqlcon
        Using o = sqlcmd.ExecuteReader
            If o.Read Then
                MessageBox.Show("The username is already taken please get another username", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                txtAddUsername.SelectAll()
                txtAddUsername.Focus()
                Exit Sub
            End If
        End Using


        If txtAddPassword.Text <> txtAddCPassword.Text Then
            MessageBox.Show("The password should be matched!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtPassword.Focus()
            txtPassword.SelectAll()
            Exit Sub
        End If
        If txtAddLname.Text = Nothing Then
            MessageBox.Show("Please enter the last name of the new staff",
                            "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAddLname.Focus()

            Exit Sub

        End If
        If txtAddFname.Text = Nothing Then
            MessageBox.Show("Please enter the first name of the new staff",
                            "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAddFname.Focus()

            Exit Sub
        End If
        If cboUsertype.Text = Nothing Then
            MessageBox.Show("Please fill the user type of the new staff",
                            "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
            cboUsertype.Focus()

        End If
        Try
            sqlcmd = New SqlCommand("addUsers", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@username", txtAddUsername.Text)
            sqlcmd.Parameters.AddWithValue("@pass", txtAddPassword.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtAddFname.Text)
            sqlcmd.Parameters.AddWithValue("@lname", txtAddLname.Text)
            sqlcmd.Parameters.AddWithValue("@initial", txtAddMinitialN.Text)
            sqlcmd.Parameters.AddWithValue("@usertype", cboUsertype.Text)
            sqlcmd.Parameters.AddWithValue("@dept", frmLogin.lblDepartment.Text)
            sqlcmd.Parameters.AddWithValue("@datereg", lblDateTime.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            Dim q As Integer
            q = MessageBox.Show("Information successfully uploaded! Do you want to add new account?", "System Message", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)

            btnCancelAccounts.PerformClick()

            If q = vbYes Then
                txtAddUsername.Focus()
            Else
                Exit Sub

            End If


        Catch ex As Exception
            MessageBox.Show("Please check all your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try


    End Sub

    Private Sub btnCancelAccounts_Click(sender As Object, e As EventArgs) Handles btnCancelAccounts.Click
        txtAddCPassword.Clear()
        txtAddFname.Clear()
        txtAddUsername.Clear()
        txtAddLname.Clear()
        txtAddPassword.Clear()
        txtAddMinitialN.Clear()

    End Sub

    Private Sub txtAddFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddFname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtAddLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddLname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtAddMinitialN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddMinitialN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub dgvInventorySum_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvInventorySum.MouseDoubleClick
        Try

            ItemIdentification.lblDescription.Text = dgvInventorySum.SelectedCells.Item(0).Value
            ItemIdentification.lblModel.Text = dgvInventorySum.SelectedCells.Item(1).Value

            ItemIdentification.Show()
            ItemIdentification.Focus()

        Catch ex As Exception

            MessageBox.Show("Please select at least one item", "System Essage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        End Try
    End Sub

    Private Sub dgvInventorySum_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvInventorySum.RowPostPaint

        Try
            Dim dgvrows As DataGridViewRow = dgvInventorySum.Rows.Item(e.RowIndex)
            If CInt(dgvrows.Cells(3).FormattedValue.ToString) >= CInt(dgvrows.Cells(2).FormattedValue.ToString) Then
                dgvrows.Cells(3).Style.ForeColor = Color.Green
            Else
                dgvrows.Cells(3).Style.ForeColor = Color.Red

            End If

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Me.Refresh()



        ReportViewer.Close()
        AnnualReport.Close()
        BillingReport.Close()
        InventoryCategory.Close()
        ItemIdentification.Close()
        ItemsOnQueueReport.Close()
        Maintenance_Report.Close()
        MaintenanceRepairSummary.Close()
        MonthlyReport.Close()
        PurchaseOrderReport.Close()
        RepairReport.Close()
        SupplierItemAnalysis.Close()
        SupplierItemAnalysisReport.Close()
        TechnicianAnalysisReport.Close()
        top10mostBuy.Close()
        TruckExpenseReport.Close()
        TruckHistory.Close()
        TruckRepairItemHistory.Close()
        TruckReportWorth.Close()

        Me.Close()


        frmLogin.Show()
        frmLogin.Focus()
        frmLogin.txtUsername.Focus()

    End Sub

    Private Sub txtUpdateQuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdateQuota.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub



    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles btnCancelForExchange.Click

        cmbToExchange.Text = Nothing
        txtReasonforExchange.Text = Nothing

        cboFromTruckexchange.Text = Nothing

        cmbSwitchParts.Text = Nothing



    End Sub



    Public Function gettechnicianJob()

        sqlcmd = New SqlCommand("gettechnicianJobDesc", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Dim sqldt10 As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqldt10)

        Dim pi As Integer

        Do While pi <= sqldt10.Rows.Count - 1

            cboJob.Items.Add(sqldt10.Rows(pi).Item(0) & " - " & sqldt10.Rows(pi).Item(1))
            cboTechnicianDiagnosis.Items.Add(sqldt10.Rows(pi).Item(1))

            cboTechMasterlist.Items.Add(sqldt10.Rows(pi).Item(1))

            pi += 1

        Loop

        Return sqldt10

    End Function

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchforItem.TextChanged


        sqlcmd = New SqlCommand("summaryofInventorySearch", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@itemdesc", txtSearchforItem.Text)
        sqlcmd.Parameters.AddWithValue("@model", txtSearchforItem.Text)
        sqlcmd.Connection = sqlcon

        Dim dt50 As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt50)

        dgvInventorySum.DataSource = dt50
        dgvInventorySum.Columns(5).DefaultCellStyle.Format = "###,###,###.##"


    End Sub

    Private Sub txtSearchItemRequestPO_TextChanged(sender As Object, e As EventArgs) Handles txtSearchItemRequestPO.TextChanged
        If (txtSearchItemRequestPO.Text.Length > 1) Then
            sqlds.Reset()
            Dim dt39 As New DataTable

            sqlcmd = New SqlCommand("purchaseorderRequest", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlcmd.Parameters.AddWithValue("@item", txtSearchItemRequestPO.Text)
            sqlcmd.Parameters.AddWithValue("@desc", txtSearchItemRequestPO.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtSearchItemRequestPO.Text)
            sqlda = New SqlDataAdapter(sqlcmd)

            sqlda.Fill(dt39)

            dgvRequestDetails.DataSource = dt39
            dgvRequestDetails.Columns(6).Width = 1
            dgvRequestDetails.Columns(0).Width = 1

            dgvRequestDetails.Columns(4).DefaultCellStyle.Format = "###,###,###.##"
            dgvRequestDetails.Columns(5).DefaultCellStyle.Format = "###,###,###.##"


        End If
    End Sub

    Public Function itemsOnQueue()
        Dim dt89 As New DataTable

        sqlcmd = New SqlCommand("itemsOnQueue", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt89)

        dgvItemsOnQueue.DataSource = dt89


        Return dt89

    End Function

    Private Sub Button17_Click_2(sender As Object, e As EventArgs) Handles Button17.Click
        itemsOnQueue()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJobDesc.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 48 To 58
                e.KeyChar = Nothing

        End Select
    End Sub


    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        Try

            sqlcmd = New SqlCommand("searchJobDesc", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@jobdesc", txtJobDesc.Text)
            sqlcmd.Connection = sqlcon
            Using k = sqlcmd.ExecuteReader
                If k.Read Then
                    MessageBox.Show("There are description at the same in the database", "System Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub

                End If
            End Using

            Dim jobid As String
            jobid = getmaxjobDescription()


            sqlcmd = New SqlCommand("insertJobtechnicians", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@jobdesc", txtJobDesc.Text)
            sqlcmd.Parameters.AddWithValue("@jobid", jobid)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information successfully uploaded!", "System Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtJobDesc.Clear()


        Catch ex As Exception
            MessageBox.Show("Please check your input", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End Try
    End Sub

    Public Function getmaxjobDescription()
        Dim jobid, adni As String

        jobid = "ADNI"
        adni = "ADNI"

        Dim weh As Integer

        sqlcmd = New SqlCommand("autotechnicianjobs", sqlcon)
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandType = CommandType.StoredProcedure
        Using k = sqlcmd.ExecuteReader
            If k.Read Then

                weh = Format(Mid(k.GetValue(0), 5) + 1)
                adni = adni & weh

            End If
        End Using


        Return adni


    End Function


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTechnicianDiagnosis.SelectedIndexChanged
        Try
            Dim dt As New DataTable

            sqlcmd = New SqlCommand("getTechnicianDiagnosed", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@jobdesc", cboTechnicianDiagnosis.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt)

            dgvTechnicianForAnalysis.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If cboTechnicianDiagnosis.Text = Nothing Then
            MessageBox.Show("Please select job description", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If

        TechnicianAnalysisReport.txtJobDescription.Text = cboTechnicianDiagnosis.Text

        TechnicianAnalysisReport.Show()
        TechnicianAnalysisReport.Focus()

    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        ItemsOnQueueReport.Show()
        ItemsOnQueueReport.Focus()


    End Sub

    Private Sub txtTechnicianLnametoUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechnicianLnametoUpdate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 48 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTechnicianfnameToUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechnicianfnameToUpdate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 48 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTechnicianContactToUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechnicianContactToUpdate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 48 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboTechMasterlist.SelectedIndexChanged

        sqlcmd = New SqlCommand("technicianMasterList", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@jobdesc", cboTechMasterlist.Text)
        sqlcmd.Connection = sqlcon

        Dim dt88 As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt88)

        dgvTechnicianMasterlist.DataSource = dt88

    End Sub

    Private Sub cmbToExchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbToExchange.SelectedIndexChanged

    End Sub

    Private Sub tabPartsExchange_Click(sender As Object, e As EventArgs) Handles tabPartsExchange.Click

    End Sub

    Private Sub cboIdentificationPartsexchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdentificationPartsexchange.SelectedIndexChanged

    End Sub
End Class
