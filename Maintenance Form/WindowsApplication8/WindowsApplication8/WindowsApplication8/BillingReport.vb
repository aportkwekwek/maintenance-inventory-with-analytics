Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class BillingReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub BillingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        
        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Dim tot As String

        tot = "0"
        Dim i(0), j(0) As ReportParameter
        Dim dates, supplier As String

        supplier = txtSupplierName.Text
        sqlcmd = New SqlCommand("totalBilling", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@sname", supplier)
        sqlcmd.Parameters.AddWithValue("@datefrom", dtpDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", dtpDateTo.Text)
        sqlcmd.Connection = sqlcon
        Using q = sqlcmd.ExecuteReader
            If q.Read Then
                Try
                    tot = q.GetValue(0)
                    tot = FormatNumber(tot)
                Catch
                    tot = "x"
                    MessageBox.Show("There are no purchases from the company " & supplier & " from these dates")
                    Me.Close()
                    Exit Sub
                End Try

            End If

        End Using

        sqlcmd = New SqlCommand("ReportforSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@supplierName", txtSupplierName.Text)
        sqlcmd.Parameters.AddWithValue("@FromDate", dtpDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@toDate", dtpDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)


        dates = "From " & dtpDateFrom.Text & " to " & dtpDateTo.Text
        i(0) = New ReportParameter("dates", dates, True)
        j(0) = New ReportParameter("CompanyName", supplier, True)

        Dim k(0) As ReportParameter

        Dim total As String
        total = "The total purchase ordered is P " & tot
        k(0) = New ReportParameter("total", total, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {k(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {j(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("BillingReport", dt))
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
End Class