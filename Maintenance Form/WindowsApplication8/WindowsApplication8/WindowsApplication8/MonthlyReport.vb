Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class MonthlyReport
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim dt As New DataTable

    Private Sub MonthlyReport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Me.Hide()


        sqlcmd = New SqlCommand("deletTempData", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()

        

        frmMaintenanceMain.Focus()
        ReportViewer.Focus()
    End Sub

    Private Sub MonthlyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Reset()
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()
        Me.ReportViewer1.LocalReport.DataSources.Clear()


        Me.ReportViewer1.RefreshReport()

        sqlcmd = New SqlCommand("MonthlyReport", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon


        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim l(0) As ReportParameter
        Dim dateFromthis, dateTothis, all As String
        dateFromthis = txtDateFrom.Text
        dateTothis = txtDateTo.Text
        all = "Purchase order report from " & dateFromthis & " to " & dateTothis

        l(0) = New ReportParameter("MonthlyReportParam", all, True)


        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {l(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("MonthlyPurchaseOrderReport", dt))

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
End Class