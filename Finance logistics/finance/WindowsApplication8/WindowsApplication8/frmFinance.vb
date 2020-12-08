Imports System.Data
Imports System.Data.SqlClient


Public Class frmFinance
    Dim sqlcmd As SqlCommand
    Dim sqlda As SqlDataAdapter
    Dim sqlcon As New SqlConnection
    Dim sqlds As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()


        Timer1.Start()

    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Top = 0
        Me.Left = 0
    End Sub


    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Dim i As Double


        InventorySlideBack()

        'PanelTruck.Visible = False
        'PanelInventory.Visible = True

        If PanelRequest.Width = 1 Then
            btnRequest.BackColor = Color.LightGray
            Do While i <= PanelRequest.Width - 1
                PanelRequest.Width = 10 + i
                i += 1
                If PanelRequest.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelRequest.Width >= 1
                btnRequest.BackColor = Color.Transparent
                PanelRequest.Width = PanelRequest.Width - 1
                If PanelRequest.Width = 1 Then
                    Exit Sub
                End If
            Loop

        End If
    End Sub

    Private Sub btnTruck_Click(sender As Object, e As EventArgs) Handles btnSupplierPrices.Click
        Dim i As Double

        TruckSlideBack()


        If panelSupplierPrices.Width = 1 Then
            btnSupplierPrices.BackColor = Color.LightGray
            Do While i <= panelSupplierPrices.Width - 1
                panelSupplierPrices.Width = 10 + i
                i += 1
                If panelSupplierPrices.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While panelSupplierPrices.Width >= 1
                btnSupplierPrices.BackColor = Color.Transparent
                panelSupplierPrices.Width = panelSupplierPrices.Width - 1

                If panelSupplierPrices.Width = 1 Then
                    Exit Sub
                End If
            Loop

        End If

    End Sub

    Private Sub btnPO_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        POSlideBack()
        ReportViewer.Show()


    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs)
        ReportsSlideBack()

    End Sub

    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        Dim i As Double

        MyAccountSlideBack()

        If PanelMyAccount.Width = 1 Then
            btnMyAccount.BackColor = Color.LightGray
            Do While i <= PanelMyAccount.Width - 1
                PanelMyAccount.Width = 10 + i
                i += 1
                If PanelMyAccount.Width = 1000 Then
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.Transparent
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Sub
                End If
            Loop

        End If
    End Sub


    Public Function InventorySlideBack()

        If panelSupplierPrices.Width = 1000 Then
            Do While panelSupplierPrices.Width >= 1
                btnSupplierPrices.BackColor = Color.Transparent
                panelSupplierPrices.Width = panelSupplierPrices.Width - 1
                If panelSupplierPrices.Width = 1 Then
                    Exit Do
                End If
            Loop
        
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.Transparent
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        
        Else

        End If

        PanelRequest.Visible = True
        panelSupplierPrices.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function TruckSlideBack()

        If PanelRequest.Width = 1000 Then
            Do While PanelRequest.Width >= 1
                btnRequest.BackColor = Color.Transparent
                PanelRequest.Width = PanelRequest.Width - 1
                If PanelRequest.Width = 1 Then
                    Exit Do
                End If
            Loop
       
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.Transparent
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
       
        Else

        End If

        PanelRequest.Visible = False
        panelSupplierPrices.Visible = True

        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function POSlideBack()

        If PanelRequest.Width = 1000 Then
            Do While PanelRequest.Width >= 1
                btnRequest.BackColor = Color.Transparent
                PanelRequest.Width = PanelRequest.Width - 1
                If PanelRequest.Width = 1 Then
                    Exit Do
                End If
            Loop
       
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.Transparent
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf panelSupplierPrices.Width = 1000 Then
            Do While panelSupplierPrices.Width >= 1
                btnSupplierPrices.BackColor = Color.Transparent
                panelSupplierPrices.Width = panelSupplierPrices.Width - 1
                If panelSupplierPrices.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelRequest.Visible = False
        panelSupplierPrices.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function MyAccountSlideBack()

        If PanelRequest.Width = 1000 Then
            Do While PanelRequest.Width >= 1
                btnRequest.BackColor = Color.Transparent
                PanelRequest.Width = PanelRequest.Width - 1
                If PanelRequest.Width = 1 Then
                    Exit Do
                End If
            Loop
       
        ElseIf panelSupplierPrices.Width = 1000 Then
            Do While panelSupplierPrices.Width >= 1
                btnSupplierPrices.BackColor = Color.Transparent
                panelSupplierPrices.Width = panelSupplierPrices.Width - 1
                If panelSupplierPrices.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelRequest.Visible = False
        panelSupplierPrices.Visible = False

        PanelMyAccount.Visible = True

        Return 0
    End Function
    Public Function ReportsSlideBack()

        If PanelRequest.Width = 1000 Then
            Do While PanelRequest.Width >= 1
                btnRequest.BackColor = Color.Transparent
                PanelRequest.Width = PanelRequest.Width - 1
                If PanelRequest.Width = 1 Then
                    Exit Do
                End If
            Loop
       
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.Transparent
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf panelSupplierPrices.Width = 1000 Then
            Do While panelSupplierPrices.Width >= 1
                btnSupplierPrices.BackColor = Color.Transparent
                panelSupplierPrices.Width = panelSupplierPrices.Width - 1
                If panelSupplierPrices.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelRequest.Visible = False
        panelSupplierPrices.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function



    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim i As Integer
        Dim remarks As String



        i = MessageBox.Show("Do you want to approve this request?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then
            remarks = "APPROVED"

            sqlcmd = New SqlCommand("financeApproval", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlcmd.Parameters.AddWithValue("@id", lblPurchaseOrderId.Text)
            sqlcmd.Parameters.AddWithValue("@remarks", remarks)
            sqlcmd.Parameters.AddWithValue("@finance", "")
            sqlcmd.ExecuteNonQuery()
            MessageBox.Show("Approved purchase order has been sent to Logistics", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grpRequest.Visible = True
            grpToEvaluate.Visible = False
            btnViewItems.PerformClick()
            sqlds.Reset()

        Else
            Try
                Dim message, title, value As String
                Dim valueof As Object
                message = "Enter the reason for denying this request"
                title = "Remarks"
                value = ""

                valueof = InputBox(message, title, value)
                If valueof = "" Then
                    Exit Sub

                End If

                remarks = "DENIED"
                sqlcmd = New SqlCommand("financeApproval", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Connection = sqlcon
                sqlcmd.Parameters.AddWithValue("@id", lblPurchaseOrderId.Text)
                sqlcmd.Parameters.AddWithValue("@remarks", remarks)
                sqlcmd.Parameters.AddWithValue("@finance", valueof)
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Denied purchase order has been sent to Maintenance ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                grpToEvaluate.Visible = False
                grpRequest.Visible = True
                sqlds.Reset()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            
            btnViewItems.PerformClick()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            sqlds.Reset()
            sqlcmd = New SqlCommand("pendingPO", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "pending")
            dgvPendingPO.DataSource = sqlds.Tables("pending")
            dgvPendingPO.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Catch ex As Exception
            MessageBox.Show("There are no request at this time", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End Try
       


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnViewItems.Click
        

        Try

            lblPurchaseOrderId.Text = dgvPendingPO.SelectedCells.Item(0).Value
            If lblPurchaseOrderId.Text = Nothing Then
                MessageBox.Show("Please click on item in the table", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                Exit Sub
            End If

            grpToEvaluate.Visible = True
            grpRequest.Visible = False
            Dim dt27 As New DataTable

            sqlcmd = New SqlCommand("toEvaluate", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblPurchaseOrderId.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt27)

            dgvListofItem.DataSource = dt27
            

        Catch ex As Exception

            Exit Sub
        End Try
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            sqlcmd = New SqlCommand("pendingPO", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using f = sqlcmd.ExecuteReader
                If f.Read Then
                    btnRequest.Image = My.Resources.red
                Else
                    btnRequest.Image = My.Resources.none
                End If
            End Using

            lblDateTimenow.Text = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss tt")

        Catch ex As Exception


            Me.Enabled = False

            Timer1.Stop()


            ErrorPage.Show()
            ErrorPage.Focus()

        End Try


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        grpRequest.Visible = True
        grpToEvaluate.Visible = False

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sqlds.Reset()

        Try
            sqlcmd = New SqlCommand("getSuppliersAll", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "xyz")

            dgvViewSuppliers.DataSource = sqlds.Tables("xyz")

        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqlds.Reset()

        Try
            sqlcmd = New SqlCommand("SupplierLastandCurrentPrice", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "lastCurr")

            dgvItemofSupplier.DataSource = sqlds.Tables("lastCurr")

            
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click

        sqlcmd = New SqlCommand("getAccountInfo", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@username", txtAccUsername.Text)
        sqlcmd.Parameters.AddWithValue("@pass", txtAccPassword.Text)
        sqlcmd.Connection = sqlcon
        Using r = sqlcmd.ExecuteReader
            If r.Read Then
            Else
                MessageBox.Show("Incorrect Password!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End Using

        If txtRetypeNPass.Text <> txtAccNPassword.Text Then
            MessageBox.Show("New Password did not matched!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAccNPassword.Focus()
            txtAccNPassword.SelectAll()
            Exit Sub

        End If

        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to update your password?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub
        Else
            sqlcmd = New SqlCommand("updatepass", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@userid", txtAccUsername.Text)
            sqlcmd.Parameters.AddWithValue("@userpass", txtAccNPassword.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Password updated successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnCancelAcc.PerformClick()
            Exit Sub


        End If

    End Sub

    Private Sub btnCancelAcc_Click(sender As Object, e As EventArgs) Handles btnCancelAcc.Click
        txtAccNPassword.Clear()
        txtRetypeNPass.Clear()
        txtAccPassword.Clear()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtAddCPassword.PasswordChar = Nothing
            txtAddPassword.PasswordChar = Nothing
        Else
            txtAddCPassword.PasswordChar = "*"
            txtAddPassword.PasswordChar = "*"

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtAddUsername.Text = Nothing Then
            MessageBox.Show("Please fill in the username", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtAddUsername.Focus()
            Exit Sub
        End If

        sqlcmd = New SqlCommand("getUsernameofStaff", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@username", txtAddUsername.Text)
        sqlcmd.Connection = sqlcon
        Using f = sqlcmd.ExecuteReader
            If f.Read Then
            Else
                MessageBox.Show("The username is already taken please get another username!", "System Message",
                                MessageBoxButtons.OK, MessageBoxIcon.None)
                txtAddUsername.Focus()
                txtAddUsername.SelectAll()

                Exit Sub
            End If

        End Using
        If txtAddPassword.Text <> txtAddCPassword.Text Then
            MessageBox.Show("The password did not match", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            txtAddPassword.Focus()
            txtAddPassword.SelectAll()
            Exit Sub
        End If
        If txtAddLname.Text = Nothing Then
            MessageBox.Show("Please enter the Last name of the new sstaff", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            txtAddLname.Focus()
            Exit Sub
        End If

        If txtAddFname.Text = Nothing Then
            MessageBox.Show("Please enter the First name of the new sstaff", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            txtAddFname.Focus()
            Exit Sub
        End If

        Try
            sqlcmd = New SqlCommand("addUsers", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@username", txtAddUsername.Text)
            sqlcmd.Parameters.AddWithValue("@pass", txtAddPassword.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtAddFname.Text)
            sqlcmd.Parameters.AddWithValue("@lname", txtAddLname.Text)
            sqlcmd.Parameters.AddWithValue("@minitial", txtAddMinitial.Text)
            sqlcmd.Parameters.AddWithValue("@usertype", "ADMIN")
            sqlcmd.Parameters.AddWithValue("@dept", frmLogin.lblDepartment.Text)
            sqlcmd.Parameters.AddWithValue("@datereg", lblDateTimenow.Text)
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Information successfully uploaded!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCancelAcc.PerformClick()

            Dim u As Integer
            u = MessageBox.Show("Do you want to add more users?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If u = vbYes Then
                txtAddUsername.Focus()
            Else
                Exit Sub

            End If
            Exit Sub

        Catch ex As Exception
            MessageBox.Show("Please check all your inputs!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancelNewAcc_Click(sender As Object, e As EventArgs) Handles btnCancelNewAcc.Click
        txtAddCPassword.Clear()
        txtAddFname.Clear()
        txtAddLname.Clear()
        txtAddMinitial.Clear()
        txtAddUsername.Clear()
        txtAddPassword.Clear()

    End Sub

    Private Sub txtAddLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddLname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtAddFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddFname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtAddMinitial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddMinitial.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select
    End Sub


    Private Sub dgvItemofSupplier_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvItemofSupplier.RowPostPaint
        Try
            Dim dgvRow As DataGridViewRow = dgvItemofSupplier.Rows(e.RowIndex)
            If CInt(dgvRow.Cells(3).FormattedValue.ToString) >= CInt(dgvRow.Cells(4).FormattedValue.ToString) Then
                dgvRow.Cells(4).Style.ForeColor = Color.Green
                dgvRow.Cells(5).Style.ForeColor = Color.Green
            Else
                dgvRow.Cells(4).Style.ForeColor = Color.Red
                dgvRow.Cells(5).Style.ForeColor = Color.Red

            End If

        Catch ex As Exception

            Exit Sub

        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()

        BillingReport.Close()
        PurchaseOrderReport.Close()
        ReportViewer.Close()
        TruckNetWorth.Close()
        Me.Close()


        frmLogin.Show()
        frmLogin.Focus()
        frmLogin.txtUsername.Focus()


    End Sub

    Private Sub dgvItemofSupplier_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvItemofSupplier.RowsAdded
       

    End Sub
End Class
