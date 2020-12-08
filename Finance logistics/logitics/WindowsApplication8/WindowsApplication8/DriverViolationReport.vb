Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms


Public Class DriverViolationReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub DriverViolationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        Me.ReportViewer1.RefreshReport()

        sqlcon.ConnectionString = connString()
        sqlcon.Open()

        Me.ReportViewer1.LocalReport.DataSources.Clear()


        sqlcmd = New SqlCommand("getdriverViolation", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@driverid", txtDriverId.Text)
        sqlcmd.Connection = sqlcon


        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim i(0) As ReportParameter
        Dim str As String

        str = "This are the violations encountered by " & txtDriverName.Text & " from time to time"

        i(0) = New ReportParameter("driverid", str, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("driverViolation", dt))

        Me.ReportViewer1.RefreshReport()



    End Sub
End Class