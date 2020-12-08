Imports System.Data
Imports System.Data.SqlClient



Public Class ReportViewer
    Dim sqlda As New SqlDataAdapter
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnForAll.Click
        If cboReport.Text = "Categories" Then
            InventoryCategory.Focus()
            InventoryCategory.Show()

        End If
        If dtpFrom.Value >= dtpTo.Value Then
            MessageBox.Show("Invalid date", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
        If cboReport.Text = Nothing Then
            MessageBox.Show("Please Select Report")
        End If

        'Maintenance Report
        '==========================================================================
        '==========================================================================

        If cboReport.Text = "Maintenance / Repair Report" Then
            Maintenance_Report.txtDateFrom.Text = dtpFrom.Text
            Maintenance_Report.txtDateTo.Text = dtpTo.Text
            Maintenance_Report.Show()

        End If

        If cboReport.Text = "Top 10 Most Buy Items" Then
            top10mostBuy.txtDateFrom.Text = dtpFrom.Text
            top10mostBuy.txtDateTo.Text = dtpTo.Text
            top10mostBuy.Show()

        End If

        If cboReport.Text = "Truck Item History" Then
            Try
                sqlcmd = New SqlCommand("getplatenumbers", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@platenumber", cboTrucks.Text)
                sqlcmd.Connection = sqlcon
                Using f = sqlcmd.ExecuteReader
                    If f.Read Then
                        TruckRepairItemHistory.txtDateFrom.Text = dtpFrom.Text
                        TruckRepairItemHistory.txtDateTo.Text = dtpTo.Text
                        TruckRepairItemHistory.txtPlateNumber.Text = cboTrucks.Text
                        TruckRepairItemHistory.Show()

                    Else
                        MessageBox.Show("Plate number has not been found in the system please try again", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Exit Sub
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


        '-------------------------------
        'Truck Expense Report
        '-------------------------------
        If cboReport.Text = "Truck Expense" Then

            TruckExpenseReport.txtDatefrom.Text = dtpFrom.Text
            TruckExpenseReport.txtDateto.Text = dtpTo.Text
            TruckExpenseReport.Show()

        End If

        'Truck Report Worth
        '---------------------------------------------------------------------------
        '---------------------------------------------------------------------------
        If cboReport.Text = "Truck Worth" Then
            TruckReportWorth.Focus()
            TruckReportWorth.Show()

        End If

        'Purchase Order Report
        '==========================================================================
        '==========================================================================
        If cboReport.Text = "Purchase Order Report" Then
            If rbtnDaily.Checked = True Then

                Dim fromD, toD As Date
                Dim datedifference As Integer


                fromD = dtpFrom.Text
                toD = dtpTo.Text

                datedifference = DateDiff(DateInterval.Day, fromD, toD)

                If datedifference >= 32 Then
                    MessageBox.Show("The maximum interval days is from 1 to 31",
                                    "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                datedifference = datedifference + 1



                Dim ctr, pid As Integer

                pid = autopurchaseID()


                ctr = 1
                Do While ctr <= datedifference
                    Dim addedDate, purchaseorderid As String

                    purchaseorderid = "P" & Format(pid + ctr, "0###")
                    addedDate = DateAdd(DateInterval.Day, ctr, fromD)

                    sqlcmd = New SqlCommand("tempPurchaseOrder", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@purchaseorderid", purchaseorderid)
                    sqlcmd.Parameters.AddWithValue("@date", addedDate)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    ctr += 1

                Loop


                PurchaseOrderReport.txtDatefrom.Text = dtpFrom.Text
                PurchaseOrderReport.txtDateTo.Text = dtpTo.Text

                sqlcmd = New SqlCommand("getTototalPurchaseOrder", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@date1", dtpFrom.Text)
                sqlcmd.Parameters.AddWithValue("@date2", dtpTo.Text)
                sqlcmd.Connection = sqlcon

                Dim getTot As String
                Using f = sqlcmd.ExecuteReader
                    If f.Read Then
                        getTot = "The Total Purchase order of the day selected is P " & f.GetValue(0) & ".00"
                        PurchaseOrderReport.lbltot.Text = getTot

                    End If
                End Using

                PurchaseOrderReport.Show()
                PurchaseOrderReport.Focus()

            ElseIf rbtnAnnual.Checked = True Then
                AnnualReport.txtDateFrom.Text = dtpFrom.Text
                AnnualReport.txtDateTo.Text = dtpTo.Text
                AnnualReport.Show()

            ElseIf rbtnMonthly.Checked = True Then

                Dim fromD, toD As Date
                Dim datedifference As Integer


                fromD = dtpFrom.Text
                toD = dtpTo.Text

                datedifference = DateDiff(DateInterval.Month, fromD, toD)

                If datedifference >= 12 Then
                    MessageBox.Show("The maximum interval month is from 1 to 12",
                                    "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                End If
                datedifference = datedifference + 1

                Dim ctr, pid As Integer

                pid = autopurchaseID()


                ctr = 1
                Do While ctr <= datedifference
                    Dim addedDate, purchaseorderid As String

                    purchaseorderid = "P" & Format(pid + ctr, "0###")
                    addedDate = DateAdd(DateInterval.Month, ctr, fromD)

                    sqlcmd = New SqlCommand("tempPurchaseOrder", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@purchaseorderid", purchaseorderid)
                    sqlcmd.Parameters.AddWithValue("@date", addedDate)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    ctr += 1

                Loop


                MonthlyReport.txtDateFrom.Text = dtpFrom.Text
                MonthlyReport.txtDateTo.Text = dtpTo.Text
                MonthlyReport.Show()

            End If



        End If

    End Sub
    Public Function autopurchaseID()

        Dim x2 As String

        x2 = ""
        'get automatic id for purchase order
        sqlcmd = New SqlCommand("autopurchaseorderid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Using x = sqlcmd.ExecuteReader
            If x.Read Then
                x2 = Format(Mid(x.GetValue(0), 2, 5) + 1, "0###")

            End If

        End Using
        Return x2

    End Function
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        Timer1.Start()

        getallTrucks()

        getSuppliers()

        If rbtnAnnual.Checked = True Then
            rbtnDaily.Checked = False
            rbtnMonthly.Checked = False
            dtpFrom.CustomFormat = "yyyy"
            dtpTo.CustomFormat = "yyyy"
        End If

    End Sub
    Public Function getSuppliers()
        sqlcmd = New SqlCommand("getSupplierName", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        Dim dt As New DataTable

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim i As Integer
        Do While i <= dt.Rows.Count - 1
            cboSupplier.Items.Add(dt.Rows(i).Item(0))
            i += 1
        Loop


        Return dt

    End Function
  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnForBilling.Click
        If cboSupplier.Text = Nothing Then
            MessageBox.Show("Please select supplier for billing", "System Messasge", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If
        Try

            BillingReport.dtpDateFrom.Text = dtpFrom.Text
            BillingReport.dtpDateTo.Text = dtpTo.Text
            BillingReport.txtSupplierName.Text = cboSupplier.Text

            BillingReport.Show()
            BillingReport.Focus()

        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        If cboReport.Text = "Billing Report" Then
            cboSupplier.Enabled = True
            btnForBilling.Visible = True
            btnForAll.Visible = False
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Checked = True

        Else
            rbtnAnnual.Enabled = True
            rbtnMonthly.Enabled = False
            cboSupplier.Enabled = False
            cboSupplier.Text = Nothing
            btnForBilling.Visible = False
            btnForAll.Visible = True

        End If

        If cboReport.Text = "Truck Item History" Then
            cboTrucks.Enabled = True
            btnForAll.Visible = True
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Enabled = True
        Else
            cboTrucks.Enabled = False
        End If
        If cboReport.Text = "Maintenance / Repair Report" Then
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Enabled = False
            rbtnDaily.Checked = True

        End If
        If cboReport.Text = "Purchase Order Report" Then
            rbtnAnnual.Enabled = True
            rbtnDaily.Enabled = True
            rbtnMonthly.Enabled = True

        End If
        If cboReport.Text = "Truck Worth" Then
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Enabled = True
            rbtnDaily.Checked = True
        End If
        If cboReport.Text = "Categories " Then
            rbtnDaily.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnAnnual.Enabled = False

        End If
        If cboReport.Text = "Truck Expense" Then
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Checked = True
            rbtnDaily.Enabled = False
        End If
        If cboReport.Text = "Top 10 Most Buy Items" Then
            rbtnMonthly.Enabled = True
            rbtnDaily.Enabled = True
            rbtnAnnual.Enabled = True

        End If
        If cboReport.Text = "Truck Item History" Then
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Checked = True
            rbtnDaily.Enabled = True

        End If


    End Sub
    Public Function getallTrucks()
        Dim dt2 As New DataTable

        sqlcmd = New SqlCommand("getTrucksAll", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt2)

        Dim i As Integer
        Do While i <= dt2.Rows.Count - 1
            cboTrucks.Items.Add(dt2.Rows(i).Item(1))

            i += 1

        Loop

        Return dt2

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rbtnAnnual.Checked = True Then
            rbtnDaily.Checked = False
            rbtnMonthly.Checked = False
            dtpFrom.CustomFormat = "yyyy"
            dtpTo.CustomFormat = "yyyy"
        ElseIf rbtnMonthly.Checked = True Then
            rbtnAnnual.Checked = False
            rbtnDaily.Checked = False
            dtpFrom.CustomFormat = "yyyy-MM-dd"
            dtpTo.CustomFormat = "yyyy-MM-dd"
        ElseIf rbtnDaily.Checked = True Then
            rbtnAnnual.Checked = False
            rbtnMonthly.Checked = False
            dtpFrom.CustomFormat = "yyyy-MM-dd"
            dtpTo.CustomFormat = "yyyy-MM-dd"
       
        End If

        If cboReport.Text = "Categories" Then
            rbtnAnnual.Enabled = False
            rbtnDaily.Enabled = False
            rbtnMonthly.Enabled = False

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmMaintenanceMain.Focus()

    End Sub
End Class