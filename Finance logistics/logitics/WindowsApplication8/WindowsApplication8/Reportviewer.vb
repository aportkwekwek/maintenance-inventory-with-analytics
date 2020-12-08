Imports System.Data
Imports System.Data.SqlClient


Public Class Reportviewer
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rbtnAnnual.Checked = True Then
            dtpFrom.CustomFormat = "yyyy"
            dtpTo.CustomFormat = "yyyy"
        ElseIf rbtnDaily.Checked = True Then
            dtpFrom.CustomFormat = "yyyy-MM-dd"
            dtpTo.CustomFormat = "yyyy-MM-dd"
        ElseIf rbtnMonthly.Checked = True Then
            dtpFrom.CustomFormat = "yyyy-MM-dd"
            dtpTo.CustomFormat = "yyyy-MM-dd"
        End If
    End Sub

    Private Sub btnForAll_Click(sender As Object, e As EventArgs) Handles btnForAll.Click

        If cboReport.Text = "Truck Worth" Then
            truckWorth.Show()
            truckWorth.Focus()
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False

            Exit Sub

        End If

        If dtpFrom.Value >= dtpTo.Value Then
            MessageBox.Show("Invalid date", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If

        If cboReport.Text = "Top 10 Most Truck Repaired" Then
            Top10MostRepairedTrucks.txtDatefrom.Text = dtpFrom.Text
            Top10MostRepairedTrucks.txtDateTo.Text = dtpTo.Text

            Top10MostRepairedTrucks.Show()
            Top10MostRepairedTrucks.Focus()

        End If

        If cboReport.Text = "Truck History" Then
            If cboTruckID.Text = Nothing Then
                MessageBox.Show("Please select truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub

            End If
            TruckHistoryD.txtDateFrom.Text = dtpFrom.Text
            TruckHistoryD.txtDateTo.Text = dtpTo.Text
            TruckHistoryD.txtTruckid.Text = Format(Mid(cboTruckID.Text, 1, 6))
            TruckHistoryD.txtPlatenumber.Text = Format(Mid(cboTruckID.Text, 10, 15))
            TruckHistoryD.Focus()
            TruckHistoryD.Show()

        End If

        If cboReport.Text = "Purchase Order" Then
            If rbtnDaily.Checked = True Then


                sqlcmd = New SqlCommand("getTototalPurchaseOrder", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@date1", dtpFrom.Text)
                sqlcmd.Parameters.AddWithValue("@date2", dtpTo.Text)
                sqlcmd.Connection = sqlcon
                Dim tot As String

                Using i = sqlcmd.ExecuteReader
                    If i.Read Then
                        tot = "The Total Purchase order of the day selected is P " & i.GetValue(0) & ".00"
                    Else
                        tot = "x"
                    End If
                End Using

                DailyPurchaseOrder.lblTotal.Text = tot
                DailyPurchaseOrder.txtDateFrom.Text = dtpFrom.Text
                DailyPurchaseOrder.txtDateTo.Text = dtpTo.Text
                DailyPurchaseOrder.Focus()
                DailyPurchaseOrder.Show()
            ElseIf rbtnMonthly.Checked = True Then


                MonthlyPurchaseOrder.txtDatefrom.Text = dtpFrom.Text
                MonthlyPurchaseOrder.txtDateto.Text = dtpTo.Text
                MonthlyPurchaseOrder.Focus()
                MonthlyPurchaseOrder.Show()
            ElseIf rbtnAnnual.Checked = True Then

                AnnualPurchaseOrder.txtDatefrom.Text = dtpFrom.Text
                AnnualPurchaseOrder.txtDateto.Text = dtpTo.Text
                AnnualPurchaseOrder.Focus()
                AnnualPurchaseOrder.Show()

            End If

        End If


    End Sub

    Private Sub Reportviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()


        sqlcon.ConnectionString = connString()

        sqlcon.Open()

        getallTrucks()


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
            cboTruckID.Items.Add(dt2.Rows(i).Item(0) & " - " & dt2.Rows(i).Item(1))

            i += 1

        Loop

        Return dt2

    End Function

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        If cboReport.Text = "Truck History" Then
            cboTruckID.Enabled = True
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
        Else
            cboTruckID.Enabled = False
            rbtnAnnual.Enabled = True
            rbtnMonthly.Enabled = True
            cboTruckID.Text = Nothing

        End If
    End Sub
End Class