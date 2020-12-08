Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmLogisticsMain
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim sqlcon As New SqlConnection
    Dim sqlds As New DataSet
    Dim imgLoc, imgloc2 As String
    Dim qtyAlreadyArrived, itemneeded As Integer
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelPurchaseOrder1.Visible = False



        Try
            sqlcon.ConnectionString = connString()
            sqlcon.Open()


        Catch ex As Exception
            MessageBox.Show("Please contact your network adminstrator")

        End Try



        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        PanelDrivers.Width = 1

        getDrivers()
        autodriverid()
        autosupplierID()
        truckCategory()

        Timer1.Start()
        Timer2.Start()
        lifespan()

    End Sub

    Public Function lifespan()
        Dim i As Integer

        For i = 1 To 30 Step 0

            cboLifespan.Items.Add(i)
            i += 1

        Next

        Return i
    End Function

    Public Function getAllSuppliers()

        cboAllSuppliertoEdit.Items.Clear()


        sqlcmd = New SqlCommand("getSupplierName", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Dim dt As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim i As Integer
        Do While i <= dt.Rows.Count - 1
            cboAllSuppliertoEdit.Items.Add(dt.Rows(i).Item(0))
            i += 1
        Loop


        Return dt

    End Function

    Private Function autosupplierID()
        Dim autosupplier, autosupplierids As String
        sqlcmd = New SqlCommand("autosuppid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Using d = sqlcmd.ExecuteReader
            If d.Read Then
                autosupplier = "SUP" & Format(Date.Now, "yyyy")
                autosupplierids = Format(Mid(d.GetValue(0), 8, 3) + 1, "0##")
                autosupplier = autosupplier & autosupplierids
                lblSupplierID.Text = autosupplier

            End If
        End Using

        Return lblSupplierID.Text

    End Function
    Private Function getDrivers()
        Try

            sqlcmd = New SqlCommand("driverstodeliver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "po")

            Dim i As Integer
            Do While i <= sqlds.Tables("po").Rows.Count - 1
                cboDriverLoc.Items.Add(sqlds.Tables("po").Rows(i).Item(0) & " - " & sqlds.Tables("po").Rows(i).Item(1) & " - " & sqlds.Tables("po").Rows(i).Item(2))
                i += 1

            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

        Return sqlds


    End Function
    Private Function getTruck()
        cboTruckidLoc.Items.Clear()


        Try

            sqlcmd = New SqlCommand("truckstodeliver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "gettruck")

            Dim i As Integer

            Do While i <= sqlds.Tables("gettruck").Rows.Count - 1
                cboTruckidLoc.Items.Add(sqlds.Tables("gettruck").Rows(i).Item(0) & " - " & sqlds.Tables("gettruck").Rows(i).Item(1) & "-" & sqlds.Tables("gettruck").Rows(i).Item(2))

                i += 1
            Loop


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally


        End Try
        Return sqlds
    End Function


    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        sqlcmd = New SqlCommand("seenUpdate", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()
        ReportsSlideBack()

        Reportviewer.Show()
        Reportviewer.Focus()


    End Sub
    Private Function autotruckid()
        Try
            Dim autotruck, autoauto As String
            sqlcmd = New SqlCommand("autotruckid", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            Using f = sqlcmd.ExecuteReader
                If f.Read Then

                    autotruck = "T" & Format(Date.Now, "MM")
                    autoauto = Format(Mid(f.GetValue(0), 5, 4) + 1, "0##")
                    autotruckid = autotruck & autoauto
                    lblTruckId.Text = autotruckid

                End If

            End Using

        Catch ex As Exception

        End Try
        Return lblTruckId.Text


    End Function
    Private Function truckCategory()

        sqlcmd = New SqlCommand("getTruckCategory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Dim i As Integer
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "y")

        Do While i <= sqlds.Tables("y").Rows.Count - 1

            cboCategory.Items.Add(sqlds.Tables("y").Rows(i).Item(0) & "-" & sqlds.Tables("y").Rows(i).Item(1))
            i += 1

        Loop

        Return sqlda

    End Function

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Top = 0
        Me.Left = 0
    End Sub


    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click


        Dim i As Double

        InventorySlideBack()


        If PanelDrivers.Width = 1 Then
            btnDrivers.BackColor = Color.Blue
            Do While i <= PanelDrivers.Width - 1
                PanelDrivers.Width = 10 + i
                i += 1
                If PanelDrivers.Width = 1000 Then
                    PanelDrivers.Visible = True
                    Exit Sub
                End If
            Loop

        Else
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
                    PanelDrivers.Visible = False
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
                PanelTruck.Width = 10 + i
                i += 1
                If PanelTruck.Width = 1000 Then
                    PanelTruck.Visible = True
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

    Private Sub btnDeliver_Click(sender As Object, e As EventArgs) Handles btnDeliver.Click
        Dim i As Double

        getTruck()

        POSlideBack()

        If PanelDeliver.Width = 1 Then
            btnDeliver.BackColor = Color.Blue
            Do While i <= PanelDeliver.Width - 1
                PanelDeliver.Width = 10 + i
                i += 1
                If PanelDeliver.Width = 1000 Then
                    PanelDeliver.Visible = True
                    Exit Sub
                End If
            Loop
        Else
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1

                If PanelDeliver.Width = 1 Then
                    PanelDeliver.Visible = False
                    Exit Sub
                End If
            Loop

        End If

    End Sub


    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        Dim i As Double
        getAllSuppliers()


        MyAccountSlideBack()

        If PanelMyAccount.Width = 1 Then
            btnMyAccount.BackColor = Color.Blue
            Do While i <= PanelMyAccount.Width - 1
                PanelMyAccount.Width = 10 + i
                i += 1
                If PanelMyAccount.Width = 1000 Then
                    PanelMyAccount.Visible = True
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

        ElseIf PanelPurchaseOrder1.Width = 1000 Then
            PanelPurchaseOrder1.Width = 1


        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelDeliver.Width = 1000 Then
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1
                If PanelDeliver.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelDrivers.Visible = True
        PanelTruck.Visible = False
        PanelDeliver.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function TruckSlideBack()

        If PanelDrivers.Width = 1000 Then
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
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
        ElseIf PanelDeliver.Width = 1000 Then
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1
                If PanelDeliver.Width = 1 Then
                    Exit Do
                End If
            Loop
        Else

        End If

        PanelDrivers.Visible = False
        PanelTruck.Visible = True
        PanelDeliver.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    Public Function POSlideBack()

        If PanelDrivers.Width = 1000 Then
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
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

        PanelDrivers.Visible = False
        PanelTruck.Visible = False
        PanelDeliver.Visible = True
        PanelPurchaseOrder1.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function

    Public Function purchaseorderSlideback()

        If PanelDrivers.Width = 1000 Then
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
                    Exit Do
                End If
            Loop

        ElseIf PanelDeliver.Width = 1000 Then
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1
                If PanelDeliver.Width = 1 Then
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
        ElseIf PanelMyAccount.Width = 1000 Then
            Do While PanelMyAccount.Width >= 1
                btnMyAccount.BackColor = Color.RoyalBlue
                PanelMyAccount.Width = PanelMyAccount.Width - 1
                If PanelMyAccount.Width = 1 Then
                    Exit Do
                End If
            Loop

        End If

        If PanelPurchaseOrder1.Width = 1 Then
            Do While PanelPurchaseOrder1.Width >= 1
                PanelPurchaseOrder1.Width = PanelPurchaseOrder1.Width + 1
                If PanelPurchaseOrder1.Width = 1000 Then
                    Exit Do
                End If
            Loop
        End If

        PanelDrivers.Visible = False
        PanelTruck.Visible = False
        PanelDeliver.Visible = False
        PanelMyAccount.Visible = False
        PanelPurchaseOrder1.Visible = True


        Return 0

    End Function
    Public Function MyAccountSlideBack()

        If PanelDrivers.Width = 1000 Then
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
                    Exit Do
                End If
            Loop

        ElseIf PanelDeliver.Width = 1000 Then
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1
                If PanelDeliver.Width = 1 Then
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

        PanelDrivers.Visible = False
        PanelTruck.Visible = False
        PanelDeliver.Visible = False
        PanelMyAccount.Visible = True
        PanelPurchaseOrder1.Visible = False


        Return 0
    End Function
    Public Function ReportsSlideBack()

        If PanelDrivers.Width = 1000 Then
            Do While PanelDrivers.Width >= 1
                btnDrivers.BackColor = Color.RoyalBlue
                PanelDrivers.Width = PanelDrivers.Width - 1
                If PanelDrivers.Width = 1 Then
                    Exit Do
                End If
            Loop
        ElseIf PanelDeliver.Width = 1000 Then
            Do While PanelDeliver.Width >= 1
                btnDeliver.BackColor = Color.RoyalBlue
                PanelDeliver.Width = PanelDeliver.Width - 1
                If PanelDeliver.Width = 1 Then
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

        PanelDrivers.Visible = False
        PanelTruck.Visible = False
        PanelDeliver.Visible = False
        PanelPurchaseOrder1.Visible = False
        PanelMyAccount.Visible = False

        Return 0
    End Function
    'end of animation
    Private Sub btnCancelDriver_Click(sender As Object, e As EventArgs) Handles btnCancelDriver.Click
        picDriver.Image = My.Resources.notif1
        picDriver.SizeMode = PictureBoxSizeMode.StretchImage
        txtLicenseNo.Clear()
        txtDContact.Clear()
        txtDFname.Clear()
        txtDLname.Clear()
        txtDMinitial.Clear()

    End Sub

    Private Function autodriverid()
        Dim dDate, driverid As String
        dDate = Format(Date.Now, "yyyy")
        Try

            sqlcmd = New SqlCommand("autodriver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using f = sqlcmd.ExecuteReader
                If f.Read Then
                    driverid = Format(Mid(f.GetValue(0), 6, 3) + 1, "0##")
                    autodriverid = "A" & dDate & driverid
                    lblAutoDriverID.Text = autodriverid

                End If
            End Using
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally

        End Try

        Return lblAutoDriverID


    End Function
    Private Sub btnSaveDriver_Click(sender As Object, e As EventArgs) Handles btnSaveDriver.Click

        Try

            If txtDLname.Text = "" Or txtDFname.Text = "" Or txtDContact.Text = "" Or txtLicenseNo.Text = "" Then
                MessageBox.Show("Please fill in the blank spaces.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            Try

                sqlcmd = New SqlCommand("getDriversAlreadyWorking", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@fname", txtDFname.Text)
                sqlcmd.Parameters.AddWithValue("@lname", txtDLname.Text)
                sqlcmd.Connection = sqlcon
                Using f = sqlcmd.ExecuteReader
                    If f.Read Then

                        MessageBox.Show("The driver already exist in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    End If
                End Using

            Catch ex As Exception
                Exit Sub

            End Try


            autodriverid()
            Dim ms As New MemoryStream
            picDriver.Image.Save(ms, picDriver.Image.RawFormat)

            sqlcmd = New SqlCommand("insertdrivers", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblAutoDriverID.Text)
            sqlcmd.Parameters.AddWithValue("@lname", txtDLname.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtDFname.Text)
            sqlcmd.Parameters.AddWithValue("@mi", txtDMinitial.Text)
            sqlcmd.Parameters.AddWithValue("@contact", txtDContact.Text)
            sqlcmd.Parameters.AddWithValue("@license", txtLicenseNo.Text)
            sqlcmd.Parameters.AddWithValue("@expire", dtpExpired.Value)
            sqlcmd.Parameters.AddWithValue("@picture", SqlDbType.Image).Value = ms.ToArray
            sqlcmd.Parameters.AddWithValue("@tin", txtDriverTin.Text)
            sqlcmd.Parameters.AddWithValue("@address", txtDriverAddress.Text)
            sqlcmd.Parameters.AddWithValue("@cpLname", txtCpLname.Text)
            sqlcmd.Parameters.AddWithValue("@cpFname", txtCpFname.Text)
            sqlcmd.Parameters.AddWithValue("@cpminitial", txtCpMinitial.Text)
            sqlcmd.Parameters.AddWithValue("@cpAddress", txtCpAddress.Text)
            sqlcmd.Parameters.AddWithValue("@cpNumber", txtCpContact.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            MessageBox.Show("Driver Successfully Added", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpExpired.Value = Format(Date.Now, "yyyy-MM-dd")
            picDriver.Image = My.Resources.notif
            Dim i As Integer
            i = MessageBox.Show("Do you want to add another driver?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbYes Then
                btnCancelDriver.PerformClick()
            Else
                btnCancelDriver.PerformClick()

            End If
        Catch ex As Exception

            MessageBox.Show("Invalid Input")
            Exit Sub

        Finally

        End Try

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        PanelDrivers.Width = 1
        btnDrivers.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        tabTrucks.SelectedIndex = 0

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If txtColor.Text = "" Or txtBrand.Text = "" Or cboCategory.Text = "" Or txtNet.Text = "" Or txtWorth.Text = "" Then
            MessageBox.Show("Please fill the blank item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
        If cboLifespan.Text = Nothing Then
            MessageBox.Show("Please enter the expected lifespan of the truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cboLifespan.Focus()
            Exit Sub

        End If
        If txtExpectedVal.Text = Nothing Then
            MessageBox.Show("Please enter the approximate value of the truck in N years", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtExpectedVal.Focus()
            Exit Sub
        End If
        Try
            Dim residual, expectedVal, noYears, initialWorth As Double
            Dim dateToSold, datepurchase As Date
            datepurchase = dtpPurchase.Text
            noYears = cboLifespan.Text
            dateToSold = DateAdd(DateInterval.Year, noYears, datepurchase)
            dateToSold = dateToSold.ToString("yyyy-MM-dd")
            expectedVal = txtExpectedVal.Text

            initialWorth = txtWorth.Text
            residual = (initialWorth - expectedVal) / noYears
            MessageBox.Show(dateToSold)


            autotruckid()
            sqlcmd = New SqlCommand("inserTrucks", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", lblTruckId.Text)
            sqlcmd.Parameters.AddWithValue("@plate", txtPlateNo.Text)
            sqlcmd.Parameters.AddWithValue("@color", txtColor.Text)
            sqlcmd.Parameters.AddWithValue("@brand", txtBrand.Text)
            sqlcmd.Parameters.AddWithValue("@cat", Format(Mid(cboCategory.Text, 1, 5)))
            sqlcmd.Parameters.AddWithValue("@cube", txtCubeCap.Text)
            sqlcmd.Parameters.AddWithValue("@gross", txtGross.Text)
            sqlcmd.Parameters.AddWithValue("@tare", txtTare.Text)
            sqlcmd.Parameters.AddWithValue("@net", txtNet.Text)
            sqlcmd.Parameters.AddWithValue("@date", dtpPurchase.Text)
            sqlcmd.Parameters.AddWithValue("@worth", txtWorth.Text)
            sqlcmd.Parameters.AddWithValue("@lifespan", dateToSold)
            sqlcmd.Parameters.AddWithValue("@expectedVal", txtExpectedVal.Text)
            sqlcmd.Parameters.AddWithValue("@residual", residual)
            sqlcmd.ExecuteNonQuery()


            Dim i As Integer
            MessageBox.Show("Truck Information Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = MessageBox.Show("Do you want to add another truck?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbYes Then
                autotruckid()
                txtPlateNo.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                cboCategory.Text = Nothing
                txtCubeCap.Clear()
                txtGross.Clear()
                txtTare.Clear()
                txtNet.Clear()
                txtWorth.Clear()
                dtpPurchase.Refresh()
                txtPlateNo.Focus()
            Else
                autotruckid()
                txtPlateNo.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                cboCategory.ResetText()
                txtCubeCap.Clear()
                txtGross.Clear()
                txtTare.Clear()
                txtNet.Clear()
                txtWorth.Clear()
                cboCategory.Text = Nothing
                tabTrucks.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Please put a valid input", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSearchTrucks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchTrucks.KeyPress
        sqlds.Reset()



        If txtSearchTrucks.TextLength >= 1 Then
            sqlcmd = New SqlCommand("searchTruckson", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", txtSearchTrucks.Text)
            sqlcmd.Parameters.AddWithValue("@plate", txtSearchTrucks.Text)
            sqlcmd.Parameters.AddWithValue("@color", txtSearchTrucks.Text)
            sqlcmd.Parameters.AddWithValue("@brand", txtSearchTrucks.Text)
            sqlcmd.Parameters.AddWithValue("@status", txtSearchTrucks.Text)

            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "o")

            dgvTrucks.DataSource = sqlds.Tables("o")
            dgvTrucks.CellBorderStyle = DataGridViewAutoSizeRowMode.AllCells

        End If
    End Sub

    Private Sub txtGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        Select Case (Asc(e.KeyChar))
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        tabDeliveryDestination.SelectedIndex = 0

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles btnClearDelivery.Click
        txtDestinationLoc.Clear()
        cboDriverLoc.Text = Nothing
        cboTruckidLoc.Text = Nothing

    End Sub

    Private Sub btnSaveLoc_Click(sender As Object, e As EventArgs) Handles btnSaveLoc.Click
        Try
            sqlcmd = New SqlCommand("vismin", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@location", txtDestinationLoc.Text)
            sqlcmd.Connection = sqlcon
            Using o = sqlcmd.ExecuteReader
                If o.Read Then

                    MessageBox.Show("The destination is not part of luzon", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
            End Using

            sqlcmd = New SqlCommand("truckdriverslocation", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboTruckidLoc.Text, 1, 6)))
            sqlcmd.Parameters.AddWithValue("@driverid", Format(Mid(cboDriverLoc.Text, 1, 8)))
            sqlcmd.Parameters.AddWithValue("@date", lblDateToday.Text)
            sqlcmd.Parameters.AddWithValue("@destination", txtDestinationLoc.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()


            sqlcmd = New SqlCommand("setDeployed", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", Format(Mid(cboTruckidLoc.Text, 1, 6)))
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()


            cboTruckidLoc.Items.Clear()
            cboDriverLoc.Items.Clear()

            MessageBox.Show("Information Successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cboDriverLoc.Items.Clear()
            cboDriverLoc.Items.Clear()
            Dim x As Integer
            x = MessageBox.Show("Do you want to add another transaction?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = vbYes Then
                getDrivers()
                getTruck()
                btnClearDelivery.PerformClick()
            Else
                btnRefresh.PerformClick()
                getDrivers()
                getTruck()
                btnClearDelivery.PerformClick()
                tabDeliveryDestination.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Please fill the blank items", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        sqlds.Reset()

        sqlcmd = New SqlCommand("listofdeployed", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "earl")

        dgvDeployedTrucks.DataSource = sqlds.Tables("earl")

        dgvDeployedTrucks.Columns(6).DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss"

        sqlcmd = New SqlCommand("listofstandby", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "jessie")

        dgvStandBy.DataSource = sqlds.Tables("jessie")


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do While PanelDeliver.Width >= 1
            btnDeliver.BackColor = Color.RoyalBlue
            PanelDeliver.Width = PanelDeliver.Width - 1

            If PanelDeliver.Width = 1 Then

                PanelDeliver.Visible = False

                Exit Sub
            End If
        Loop

    End Sub

    Private Sub btnUpdateTruck_Click(sender As Object, e As EventArgs) Handles btnUpdateTruck.Click
        Try

            lblTruckLocationR.Text = dgvDeployedTrucks.SelectedCells.Item(7).Value
            lblTruckIDReturned.Text = dgvDeployedTrucks.SelectedCells.Item(0).Value
            lblDriverIDReturned.Text = dgvDeployedTrucks.SelectedCells.Item(3).Value
            lblDateDeployedR.Text = dgvDeployedTrucks.SelectedCells.Item(6).FormattedValue
            lblDateReturnedTruck.Visible = True
            btnUpdateStatus.Enabled = True
            tabDeliveryDestination.SelectedIndex = 2

        Catch ex As Exception
            MessageBox.Show("Please select one item to update", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub

        End Try


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        Try
            sqlcmd = New SqlCommand("updatetruck", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", lblTruckIDReturned.Text)
            sqlcmd.Parameters.AddWithValue("@datedeployed", lblDateDeployedR.Text)
            sqlcmd.Parameters.AddWithValue("@driverid", lblDriverIDReturned.Text)
            sqlcmd.Parameters.AddWithValue("@datereturned", lblDateReturnedTruck.Text)
            sqlcmd.Parameters.AddWithValue("@destination", lblTruckLocationR.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information Successfully Updated!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdateStatus.Enabled = False
            lblDateReturnedTruck.Visible = False
            lblTruckIDReturned.Text = "."
            lblDateDeployedR.Text = "."
            lblDriverIDReturned.Text = "."
            lblTruckLocationR.Text = "."

            tabDeliveryDestination.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSearchDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchDriver.KeyPress

        sqlds.Reset()
        If Len(txtSearchDriver.Text) > 0 Then
            sqlcmd = New SqlCommand("searchdrivers", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure

            sqlcmd.Parameters.AddWithValue("@id", txtSearchDriver.Text)
            sqlcmd.Parameters.AddWithValue("@lname", txtSearchDriver.Text)
            sqlcmd.Parameters.AddWithValue("@fname", txtSearchDriver.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "x")
            dgvDrivers.DataSource = sqlds.Tables("x")
            dgvDrivers.CellBorderStyle = DataGridViewAutoSizeRowMode.AllCells

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If txtPass1.Text = txtPassReEnter.Text Then

                sqlcmd = New SqlCommand("updatepass", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@userid", txtUsername.Text)
                sqlcmd.Parameters.AddWithValue("@userpass", txtNewPass.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Password updated successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPass1.Clear()
                txtPassReEnter.Clear()
                txtNewPass.Clear()
            Else
                MessageBox.Show("Password did not match!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                txtPass1.Focus()
                txtPass1.SelectAll()

                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()

        AnnualPurchaseOrder.Close()
        DailyPurchaseOrder.Close()
        EditPriceofItem.Close()
        ItemsonQueueReport.Close()
        MaintenanceItems.Close()
        MonthlyPurchaseOrder.Close()
        Reportviewer.Close()
        Top10MostRepairedTrucks.Close()
        TruckHistoryD.Close()
        truckWorth.Close()
        UpdateTruck.Close()
        viewTruckHistory.Close()

        Me.Close()
        frmLogin.Show()
        frmLogin.Focus()
        frmLogin.txtUsername.Focus()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            sqlcmd = New SqlCommand("notification", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using f = sqlcmd.ExecuteReader
                If f.Read Then
                    btnPurchaseOrder.Image = My.Resources.notif1
                Else
                    btnPurchaseOrder.Image = My.Resources.none
                End If
            End Using

            sqlcmd = New SqlCommand("driversNotification", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using j = sqlcmd.ExecuteReader
                If j.Read Then
                    btnDrivers.Image = My.Resources.notif1
                Else
                    btnDrivers.Image = My.Resources.none

                End If
            End Using


            If tabDeliveryDestination.SelectedIndex = 2 Then
                btnUpdateTruck.Visible = False
            Else
                btnUpdateTruck.Visible = True

            End If
        Catch ex As Exception
            Timer1.Stop()
            ErrorPage.Show()
            ErrorPage.Focus()
            Me.Enabled = False
            

        End Try


    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        sqlds.Reset()

        sqlcmd = New SqlCommand("viewUsers", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@department", frmLogin.lblDepartment.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "o")
        dgvViewUsers.DataSource = sqlds.Tables("o")

    End Sub

    Private Sub btnAddUsers_Click(sender As Object, e As EventArgs) Handles btnAddUsers.Click
        btnSaveUsers.Visible = True
        btnAddUsers.Enabled = False
        txtUsernameAdd.Enabled = True
        txtPassAdd.Enabled = True
        txtMInitialAdd.Enabled = True
        cboUserTypeAdd.Enabled = True
        txtFnameAdd.Enabled = True
        txtLNameAdd.Enabled = True

    End Sub

    Private Sub btnSaveUsers_Click(sender As Object, e As EventArgs) Handles btnSaveUsers.Click
        Try
            If txtUsernameAdd.Text.Length < 4 Or txtPassAdd.Text.Length < 4 Or txtFnameAdd.Text = " " Or txtLNameAdd.Text = " " Then
                MessageBox.Show("Fill the blank areas", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                sqlcmd = New SqlCommand("addUsers", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@username", txtUsernameAdd.Text)
                sqlcmd.Parameters.AddWithValue("@pass", txtPassAdd.Text)
                sqlcmd.Parameters.AddWithValue("@fname", txtFnameAdd.Text)
                sqlcmd.Parameters.AddWithValue("@lname", txtLNameAdd.Text)
                sqlcmd.Parameters.AddWithValue("@initial", txtMInitialAdd.Text)
                sqlcmd.Parameters.AddWithValue("@usertype", cboUserTypeAdd.Text)
                sqlcmd.Parameters.AddWithValue("@dept", frmLogin.lblDepartment.Text)
                sqlcmd.Parameters.AddWithValue("@datereg", Format(Date.Now, "yyyy-MM-dd"))
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("User Successfully Added!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtUsernameAdd.Enabled = False
                txtPassAdd.Enabled = False
                txtMInitialAdd.Enabled = False
                cboUserTypeAdd.Enabled = False
                txtFnameAdd.Enabled = False
                txtLNameAdd.Enabled = False
                txtUsernameAdd.Clear()
                txtPassAdd.Clear()
                txtFnameAdd.Clear()
                txtLNameAdd.Clear()
                txtMInitialAdd.Clear()
                Button22.PerformClick()
                btnAddUsers.Enabled = True
                btnSaveUsers.Visible = False


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        txtPass1.Clear()
        txtPassReEnter.Clear()
        txtNewPass.Clear()

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Try
            sqlcmd = New SqlCommand("insertSuppliers", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlcmd.Parameters.AddWithValue("@id", lblSupplierID.Text)
            sqlcmd.Parameters.AddWithValue("@sname", txtSupplierName.Text)
            sqlcmd.Parameters.AddWithValue("@loc", txtSupplierLoc.Text)
            sqlcmd.Parameters.AddWithValue("@contact", txtSupplierContact.Text)
            sqlcmd.ExecuteNonQuery()

            autosupplierID()
            txtSupplierName.Clear()
            txtSupplierLoc.Clear()
            txtSupplierContact.Clear()


            MessageBox.Show("Information Successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim i As Integer
            i = MessageBox.Show("Do you want to create another supplier", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbYes Then
                txtSupplierName.Focus()

            Else
                tabAccounts.SelectedIndex = 0

            End If


        Catch ex As Exception
            MessageBox.Show("Invalid Input", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally
            getAllSuppliers()

        End Try




    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        txtSupplierName.Clear()
        txtSupplierContact.Clear()
        txtSupplierLoc.Clear()

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles btnRefreshSupplierAccountsEdit.Click
        Try
            sqlds.Reset()
            sqlcmd = New SqlCommand("viewSuppAccounts", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(sqlds, "supp")

            dgvListofSuppliers.DataSource = sqlds.Tables("supp")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

        Try
            lblSupplierIdUpdate.Text = dgvListofSuppliers.SelectedCells.Item(0).Value
            txtEditSuppContact.Text = dgvListofSuppliers.SelectedCells.Item(3).Value
            txtEditSuppLoc.Text = dgvListofSuppliers.SelectedCells.Item(2).Value
            txtEditSuppName.Text = dgvListofSuppliers.SelectedCells.Item(1).Value
            grpSupplierAcc.Visible = False
            grpEditSupplier.Visible = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles btnBackSupplierEdit.Click
        grpSupplierAcc.Visible = True
        grpEditSupplier.Visible = False
        btnRefreshSupplierAccountsEdit.PerformClick()

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Try
            Dim o As Integer
            o = MessageBox.Show("Are you sure you want to update this account?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If o = vbYes Then
                sqlcmd = New SqlCommand("updateSupplier", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@id", lblSupplierIdUpdate.Text)
                sqlcmd.Parameters.AddWithValue("@contact", txtEditSuppContact.Text)
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Account updated successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnBackSupplierEdit.PerformClick()

            Else
                MessageBox.Show("Account not updated!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                Exit Sub

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnPurchaseOrder_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrder.Click
        PanelPurchaseOrder1.Visible = True


        sqlds.Reset()
        ReportsSlideBack()


        sqlcmd = New SqlCommand("listofPOArrived", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "vv")


        dgvListofPOArrived.DataSource = sqlds.Tables("vv")

        If PanelPurchaseOrder1.Width = 1000 Then
            PanelPurchaseOrder1.Width = 1
            PanelPurchaseOrder1.Visible = False
        ElseIf PanelPurchaseOrder1.Width = 1 Then
            PanelPurchaseOrder1.Width = 1000
            PanelPurchaseOrder1.Visible = True

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            lblTimeToday.Text = Format(DateAndTime.Now, "yyyy-MM-dd hh:mm:ss tt")

            lblDateToday.Text = Format(DateAndTime.Now, "yyyy-MM-dd hh:mm:ss tt")
            lblDateReturnedTruck.Text = Format(DateAndTime.Now, "yyyy-MM-dd hh:mm:ss tt")
            sqlcmd = New SqlCommand("NewUpdates", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            Using s = sqlcmd.ExecuteReader
                If s.Read Then
                    btnReports.Image = My.Resources.notif1
                Else

                    btnReports.Image = My.Resources.none
                End If
            End Using
        Catch ex As Exception
            Exit Sub

        End Try


    End Sub
    Private Function itemidentification()

        Dim x As String
        sqlcmd = New SqlCommand("maxItemIdentification", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        Using i = sqlcmd.ExecuteReader
            If i.Read Then
                x = Format(Mid(i.GetValue(0), 6, 11) + 1, "0#####")
            Else
                x = Nothing

            End If
        End Using

        Return x


    End Function



    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click

        Try
            Dim itemArrived, temp As Integer
            itemArrived = txtQtyArrived.Text
            temp = 0

            If itemArrived > itemneeded Then

                MessageBox.Show("The quantity arrived should be less than needed!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub

            Else
                Try
                    Dim i As Integer

                    i = MessageBox.Show("Are you sure you want to make this transaction?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If i = vbNo Then
                        Exit Sub
                    Else

                        Dim qArr, p, ctr, psid As Integer
                        Dim poid, itemid As String
                        qArr = itemArrived
                        temp = itemArrived + qtyAlreadyArrived


                        poid = dgvListofPOArrived.SelectedCells.Item(5).Value
                        itemid = dgvListofPOArrived.SelectedCells.Item(0).Value
                        psid = dgvListofPOArrived.SelectedCells.Item(9).Value

                        'updating Quantity needed
                        sqlcmd = New SqlCommand("forwardtoMaintenance", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@arrived", temp)
                        sqlcmd.Parameters.AddWithValue("@pid", poid)
                        sqlcmd.Parameters.AddWithValue("@psid", psid)
                        sqlcmd.Parameters.AddWithValue("@dateArr", lblTimeToday.Text)
                        sqlcmd.Connection = sqlcon
                        sqlcmd.ExecuteNonQuery()

                        'ending this process

                        'Ending process

                        'Automating identification of item
                        itemidentification()

                        Dim qArriveds As Integer

                        qArriveds = txtQtyArrived.Text
                        Dim itemidentificationsz As String

                        poid = dgvListofPOArrived.SelectedCells.Item(5).Value
                        itemid = dgvListofPOArrived.SelectedCells.Item(0).Value
                        psid = dgvListofPOArrived.SelectedCells.Item(9).Value

                        Dim itmPrice As Integer

                        sqlcmd = New SqlCommand("getPricePerItem", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@poid", poid)
                        sqlcmd.Parameters.AddWithValue("@psid", psid)
                        sqlcmd.Connection = sqlcon

                        Using l = sqlcmd.ExecuteReader
                            If l.Read Then
                                itmPrice = l.GetValue(0)
                            End If

                        End Using

                        '----------------------------------

                        Dim totalprice, newprice As Double

                        sqlcmd = New SqlCommand("getTotalPriceInventory", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@itemid", itemid)
                        sqlcmd.Connection = sqlcon

                        Using po = sqlcmd.ExecuteReader
                            If po.Read Then
                                totalprice = po.GetValue(0)
                            End If
                        End Using

                        newprice = totalprice + itmPrice

                        sqlcmd = New SqlCommand("updateTotPrice", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@itemid", itemid)
                        sqlcmd.Parameters.AddWithValue("@totPrice", newprice)
                        sqlcmd.Connection = sqlcon
                        sqlcmd.ExecuteNonQuery()

                        Dim numberofStocks, setnumber As Integer

                        sqlcmd = New SqlCommand("getNumberofItems", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@itemid", itemid)
                        sqlcmd.Connection = sqlcon
                        Using j = sqlcmd.ExecuteReader
                            If j.Read Then
                                numberofStocks = j.GetValue(0)
                            End If
                        End Using

                        setnumber = numberofStocks + txtQtyArrived.Text


                        sqlcmd = New SqlCommand("setNumberofStocks", sqlcon)
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@itemid", itemid)
                        sqlcmd.Parameters.AddWithValue("@qty", setnumber)
                        sqlcmd.ExecuteNonQuery()


                        p = itemidentification()

                        ctr = 1

                        Do While ctr <= qArriveds

                            Dim yearnow, remarks As String
                            yearnow = Format(Date.Now, "yyyy")
                            remarks = "Inventory"
                            itemidentificationsz = "I" & yearnow & Format(p + ctr, "0####")
                            sqlcmd = New SqlCommand("insertIdentification", sqlcon)
                            sqlcmd.CommandType = CommandType.StoredProcedure
                            sqlcmd.Parameters.AddWithValue("@id", itemidentificationsz)
                            sqlcmd.Parameters.AddWithValue("@itemid", itemid)
                            sqlcmd.Parameters.AddWithValue("@dateacquired", lblTimeToday.Text)
                            sqlcmd.Parameters.AddWithValue("@remarks", remarks)
                            sqlcmd.Parameters.AddWithValue("@price", itmPrice)
                            sqlcmd.Parameters.AddWithValue("@poid", poid)
                            sqlcmd.ExecuteNonQuery()

                            'ending process
                            '---------------------------------

                            ctr += 1

                        Loop


                        MessageBox.Show("Item has moved to maintenance department", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtQtyArrived.Clear()


                    End If

                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                Finally

                    sqlds.Reset()
                    sqlcmd = New SqlCommand("listofPOArrived", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Connection = sqlcon
                    sqlda = New SqlDataAdapter(sqlcmd)
                    sqlda.Fill(sqlds, "vv")

                    dgvListofPOArrived.DataSource = sqlds.Tables("vv")

                End Try

            End If

        Catch ex As Exception
            MessageBox.Show("Please check your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try




    End Sub





    Private Sub dgvListofPOArrived_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListofPOArrived.MouseClick
        Try

            itemneeded = dgvListofPOArrived.SelectedCells.Item(8).Value
            qtyAlreadyArrived = dgvListofPOArrived.SelectedCells.Item(7).Value


            test.Text = itemneeded

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If dgvTrucks.SelectedCells.Item(10).Value = "STAND BY" Then

        Else
            MessageBox.Show("The truck is only applicable for request if the truck is on stand by", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If


        Try
            Dim truckidformaintenance As String
            truckidformaintenance = dgvTrucks.SelectedCells.Item(0).Value
            sqlcmd = New SqlCommand("requestforMaintenance", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@id", truckidformaintenance)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Truck has already been requested for maintenance", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlds.Reset()
        Catch ex As Exception
            Exit Sub
        End Try



    End Sub


    Private Sub txtDFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDFname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtDLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDLname.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtDMinitial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDMinitial.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtDContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDContact.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtSupplierContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierContact.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrand.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtNet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNet.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtTare_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTare.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing
        End Select
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try

            Dim dlg As New OpenFileDialog
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            dlg.Title = "Select Driver Image"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgLoc = dlg.FileName.ToString
                picDriver.ImageLocation = imgLoc


            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvDrivers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrivers.CellClick




        Try
            Dim id As String
            id = dgvDrivers.SelectedCells.Item(0).Value
            sqlcmd = New SqlCommand("getPicofDriver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", id)
            sqlcmd.Connection = sqlcon

            Dim table As New DataTable
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(table)

            Dim img() As Byte

            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            picSelectedDriver.Image = Image.FromStream(ms)


        Catch ex As Exception

            Exit Sub

        End Try

    End Sub


    Private Sub cboDriverLoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDriverLoc.SelectedIndexChanged
        Try
            sqlcmd = New SqlCommand("getPicofDriver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", Format(Mid(cboDriverLoc.Text, 1, 8)))
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)

            Dim dt As New DataTable


            sqlda.Fill(dt)

            Dim imgDriverLoc() As Byte

            imgDriverLoc = dt.Rows(0)(0)

            Dim ms As New MemoryStream(imgDriverLoc)

            imgDriverDeliver.Image = Image.FromStream(ms)


        Catch ex As Exception

            imgDriverDeliver.Image = My.Resources.notif1

        End Try



    End Sub

    Private Sub dgvListofPOArrived_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListofPOArrived.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If dgvTrucks.SelectedCells.Item(10).Value = "Sold" Then
            MessageBox.Show("You are no longer available to update this truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub


        End If


        Try


            UpdateTruck.lblBrand.Text = dgvTrucks.SelectedCells.Item(3).Value
            UpdateTruck.lblTruckID.Text = dgvTrucks.SelectedCells.Item(0).Value
            UpdateTruck.lblTare.Text = dgvTrucks.SelectedCells.Item(6).Value
            UpdateTruck.lblColor.Text = dgvTrucks.SelectedCells.Item(2).Value
            UpdateTruck.lblCubicCap.Text = dgvTrucks.SelectedCells.Item(5).Value
            UpdateTruck.lblPlateNumber.Text = dgvTrucks.SelectedCells.Item(1).Value
            UpdateTruck.lblGrossWeight.Text = dgvTrucks.SelectedCells.Item(7).Value
            UpdateTruck.lblNetWeight.Text = dgvTrucks.SelectedCells.Item(9).Value

            UpdateTruck.Show()
        Catch ex As Exception
            MessageBox.Show("Please choose truck to update")
            Exit Sub

        End Try



    End Sub

    Private Sub txtQtyArrived_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtyArrived.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtWorth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWorth.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub txtExpectedVal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpectedVal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing
        End Select
    End Sub

    Private Sub dgvTrucks_DoubleClick(sender As Object, e As EventArgs) Handles dgvTrucks.DoubleClick
        Try
            Dim truckid As String

            truckid = dgvTrucks.SelectedCells.Item(0).Value
            viewTruckHistory.lblTruckid.Text = truckid
            viewTruckHistory.Show()
            viewTruckHistory.Focus()


        Catch ex As Exception
            MessageBox.Show("Please select truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAllSuppliertoEdit.SelectedIndexChanged
        txtSearchforItemSupplier.Clear()
        txtSearchforItemSupplier.Text = " "
        dgvSupplierItem.Refresh()

    End Sub

    Private Sub txtSearchforItemSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSearchforItemSupplier.TextChanged
        Try

            Dim dtSupplier As New DataTable

            dtSupplier.Clear()

            sqlcmd = New SqlCommand("getAllSupplierItem", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@suppname", cboAllSuppliertoEdit.Text)
            sqlcmd.Parameters.AddWithValue("@desc", txtSearchforItemSupplier.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtSearchforItemSupplier.Text)
            sqlcmd.Connection = sqlcon


            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dtSupplier)

            dgvSupplierItem.DataSource = dtSupplier

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If cboAllSuppliertoEdit.Text = Nothing Then
            MessageBox.Show("Please select the supplier", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvSupplierItem.ClearSelection()


            Exit Sub
        End If

        If dgvSupplierItem.SelectedCells.Item(0).Value = Nothing Then
            MessageBox.Show("Please select at least one item!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try

            EditPriceofItem.lblDescription.Text = dgvSupplierItem.SelectedCells.Item(0).Value
            EditPriceofItem.lblModel.Text = dgvSupplierItem.SelectedCells.Item(1).Value
            EditPriceofItem.SupplierName.Text = cboAllSuppliertoEdit.Text
            EditPriceofItem.Show()
            EditPriceofItem.Focus()

        Catch ex As Exception

            Exit Sub

        End Try


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If cboAllSuppliertoEdit.Text = Nothing Then
            MessageBox.Show("Please select supplier", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            cboAllSuppliertoEdit.Focus()
            cboAllSuppliertoEdit.SuspendLayout()

            Exit Sub

        End If
        Try
            MaintenanceItems.Show()
            MaintenanceItems.Focus()
            MaintenanceItems.lblSname.Text = cboAllSuppliertoEdit.Text


        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ItemsonQueueReport.Show()
        ItemsonQueueReport.Focus()

    End Sub


    Private Sub btnBrowseUpdateImg_Click(sender As Object, e As EventArgs) Handles btnBrowseUpdateImg.Click

        Try

            Dim dlg As New OpenFileDialog
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            dlg.Title = "Select Driver Image"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgloc2 = dlg.FileName.ToString
                imgUpdateDriver.ImageLocation = imgloc2


            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Exit Sub

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim ms As New MemoryStream
            imgUpdateDriver.Image.Save(ms, imgDriverDeliver.Image.RawFormat)
            sqlcmd = New SqlCommand("updateDriverinformation", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", txtUdriverid.Text)
            sqlcmd.Parameters.AddWithValue("@contact", txtUdrivercontact.Text)
            sqlcmd.Parameters.AddWithValue("@driverslicense", txtUdriverlicense.Text)
            sqlcmd.Parameters.AddWithValue("@expirationdate", dtpUdriverexpired.Text)
            sqlcmd.Parameters.AddWithValue("@pic", SqlDbType.Image).Value = ms.ToArray
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            sqlcmd = New SqlCommand("updateDriverAdditional", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon
            sqlcmd.Parameters.AddWithValue("@driverid", txtUdriverid.Text)
            sqlcmd.Parameters.AddWithValue("@tin", txtTin.Text)
            sqlcmd.Parameters.AddWithValue("@address", txtAddress.Text)
            sqlcmd.Parameters.AddWithValue("@cpLname", txtContactUL.Text)
            sqlcmd.Parameters.AddWithValue("@cpFname", txtContactUF.Text)
            sqlcmd.Parameters.AddWithValue("@cpMinitial", txtContactUM.Text)
            sqlcmd.Parameters.AddWithValue("@cpAddress", txtContactUAddress.Text)
            sqlcmd.Parameters.AddWithValue("@cpNumber", txtContactUnumber.Text)
            sqlcmd.ExecuteNonQuery()


            MessageBox.Show("Information Successfully updated!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnCancelUpdateDriver.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Please check your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End Try
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnUpdateDriver.Click
        Try
            txtUdriverid.Text = dgvDrivers.SelectedCells.Item(0).Value
            txtUdriverfname.Text = dgvDrivers.SelectedCells.Item(2).Value
            txtUdriverlname.Text = dgvDrivers.SelectedCells.Item(1).Value
            txtUdriverinitial.Text = dgvDrivers.SelectedCells.Item(3).Value
            txtUdrivercontact.Text = dgvDrivers.SelectedCells.Item(4).Value
            imgUpdateDriver.Image = picSelectedDriver.Image

            tabDrivers.SelectedIndex = 2

            Try
                sqlcmd = New SqlCommand("getallinfoDriver", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@driverid", dgvDrivers.SelectedCells.Item(0).Value)
                sqlcmd.Connection = sqlcon
                Using i = sqlcmd.ExecuteReader
                    If i.Read Then
                        'contact person
                        txtContactUF.Text = i.GetValue(12)
                        txtContactUL.Text = i.GetValue(11)
                        txtContactUM.Text = i.GetValue(13)
                        txtContactUAddress.Text = i.GetValue(14)
                        txtContactUnumber.Text = i.GetValue(15)

                    End If
                End Using
            Catch ex As Exception
                Exit Sub

            End Try
           


        Catch ex As Exception

            tabDrivers.SelectedIndex = 0
            Exit Sub

        End Try
       

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateDriver.Click

        txtAddress.Clear()
        txtTin.Clear()
        txtContactUAddress.Clear()
        txtContactUF.Clear()
        txtContactUL.Clear()
        txtContactUM.Clear()
        txtContactUnumber.Clear()
        txtUdrivercontact.Clear()
        txtUdriverfname.Clear()
        txtUdriverid.Clear()
        txtUdriverlname.Clear()
        txtUdriverinitial.Clear()
        txtUdriverlicense.Clear()
        dtpUdriverexpired.Text = Format(Date.Now, "yyyy-MM-dd")
        imgUpdateDriver.Image = My.Resources.notif

    End Sub

    Private Sub dgvDrivers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrivers.CellContentClick

    End Sub

    Private Sub dgvDrivers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDrivers.MouseDoubleClick
        Try
            DriversViolation.lblDriverID.Text = dgvDrivers.SelectedCells.Item(0).Value
            DriversViolation.lblDriverName.Text = dgvDrivers.SelectedCells.Item(1).Value & ", " & dgvDrivers.SelectedCells.Item(2).Value & " " & dgvDrivers.SelectedCells.Item(3).Value


            DriversViolation.Show()
            DriversViolation.Focus()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvDrivers_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDrivers.RowPostPaint
        Try
            
            
            Dim dgvrow As DataGridViewRow = dgvDrivers.Rows(e.RowIndex)
            Dim expirationdate, datetonight As Date

            datetonight = Date.Now
            expirationdate = dgvrow.Cells(6).Value


            If expirationdate <= datetonight Then
                dgvrow.Cells(6).Style.ForeColor = Color.Red
            Else
                dgvrow.Cells(6).Style.ForeColor = Color.Green
            End If

        Catch ex As Exception
            Exit Sub

        End Try


    End Sub

    Private Sub btnContactPersonDriver_Click(sender As Object, e As EventArgs) Handles btnContactPersonDriver.Click
        Try

            ContactofDriver.lblDriverID.Text = dgvDrivers.SelectedCells.Item(0).Value
            ContactofDriver.Show()
            ContactofDriver.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally


            ContactofDriver.lblDriverID.Text = dgvDrivers.SelectedCells.Item(0).Value

        End Try


    End Sub

    Private Sub dgvTrucks_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvTrucks.RowPostPaint
        Try

            Dim dgvrow As DataGridViewRow = dgvTrucks.Rows(e.RowIndex)

            Dim color As String

            color = dgvrow.Cells(10).Value

            If color = "STAND BY" Then
                dgvrow.Cells(0).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(1).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(2).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(3).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(4).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(5).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(6).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(7).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(8).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(9).Style.BackColor = Drawing.Color.Green
                dgvrow.Cells(10).Style.BackColor = Drawing.Color.Green

            ElseIf color = "Sold" Then

                dgvrow.Cells(0).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(1).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(2).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(3).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(4).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(5).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(6).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(7).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(8).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(9).Style.BackColor = Drawing.Color.Silver
                dgvrow.Cells(10).Style.BackColor = Drawing.Color.Silver



            ElseIf color = "Under Maintenance" Then
                dgvrow.Cells(0).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(1).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(2).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(3).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(4).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(5).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(6).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(7).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(8).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(9).Style.BackColor = Drawing.Color.Red
                dgvrow.Cells(10).Style.BackColor = Drawing.Color.Red

                    

            ElseIf color = "Requesting" Then

                dgvrow.Cells(0).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(1).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(2).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(3).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(4).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(5).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(6).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(7).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(8).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(9).Style.BackColor = Drawing.Color.Violet
                dgvrow.Cells(10).Style.BackColor = Drawing.Color.Violet

            ElseIf color = "Deployed" Then
                dgvrow.Cells(0).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(1).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(2).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(3).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(4).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(5).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(6).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(7).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(8).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(9).Style.BackColor = Drawing.Color.Yellow
                dgvrow.Cells(10).Style.BackColor = Drawing.Color.Yellow

            End If


        Catch ex As Exception

            Exit Sub

        End Try


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqlcmd = New SqlCommand("getExpiredDrivers", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Dim dt22 As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt22)

        dgvExpiredLicensed.DataSource = dt22


    End Sub
End Class
