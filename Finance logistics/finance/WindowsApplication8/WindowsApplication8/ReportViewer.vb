Imports System.Data
Imports System.Data.SqlClient


Public Class ReportViewer
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim sqlds As New DataSet
    Dim dt As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cboReportType.Text = Nothing Then
                MessageBox.Show("Please Select Report Type")

                Exit Sub

            End If
            If cboReportType.Text = "Purchase Order Report" Then
                sqlcmd = New SqlCommand("getTototalPurchaseOrder", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@date1", dtpDateFrom.Text)
                sqlcmd.Parameters.AddWithValue("@date2", dtpDateTo.Text)
                sqlcmd.Connection = sqlcon

                Dim getTot As String
                Using f = sqlcmd.ExecuteReader
                    If f.Read Then
                        getTot = "The Total Purchase order of this Month is = " & f.GetValue(0)
                        PurchaseOrderReport.lbltot.Text = getTot


                    End If
                End Using

                PurchaseOrderReport.txtDateFrom.Text = dtpDateFrom.Text
                PurchaseOrderReport.txtDateTo.Text = dtpDateTo.Text
                PurchaseOrderReport.Show()
                Exit Sub
            End If
            If cboReportType.Text = "Billing Report" Then

                BillingReport.txtDateFrom.Text = dtpDateFrom.Text
                BillingReport.txtDateTo.Text = dtpDateTo.Text
                BillingReport.txtSupplierName.Text = cboSupplier.Text
                BillingReport.Show()
                Exit Sub


            End If

            If cboReportType.Text = "Truck Net Worth" Then

                TruckNetWorth.Show()

            End If
        Catch ex As Exception


            MessageBox.Show(ex.Message)

        End Try
      
    End Sub
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        getSuppliers()

    End Sub

    Private Sub cboReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportType.SelectedIndexChanged
        If cboReportType.Text = "Billing Report" Then
            cboSupplier.Enabled = True
            rbtnDaily.Checked = True
            rbtnAnnual.Enabled = False
            rbtnMonthly.Enabled = False
            rbtnDaily.Enabled = False
        Else
            cboSupplier.Text = Nothing
            cboSupplier.Enabled = False
            rbtnAnnual.Enabled = True
            rbtnMonthly.Enabled = True
            rbtnDaily.Enabled = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rbtnAnnual.Checked = True Then
            rbtnDaily.Checked = False
            rbtnMonthly.Checked = False
            dtpDateFrom.CustomFormat = "yyyy"
            dtpDateTo.CustomFormat = "yyyy"
        ElseIf rbtnDaily.Checked = True Then
            rbtnAnnual.Checked = False
            rbtnMonthly.Checked = False
            dtpDateTo.CustomFormat = "yyyy-MM-dd"
            dtpDateFrom.CustomFormat = "yyyy-MM-dd"
        ElseIf rbtnMonthly.Checked = True Then
            rbtnAnnual.Checked = False
            rbtnDaily.Checked = False
            dtpDateFrom.CustomFormat = "yyyy-MM-dd"
            dtpDateTo.CustomFormat = "yyyy-MM-dd"
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

End Class