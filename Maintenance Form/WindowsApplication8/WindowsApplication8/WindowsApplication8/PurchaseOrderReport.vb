Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class PurchaseOrderReport
    Dim sqlcmd As New SqlCommand
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter

    Private Sub PurchaseOrderReport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()


        sqlcmd = New SqlCommand("deletTempData", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()

        

        frmMaintenanceMain.Focus()
        ReportViewer.Focus()


    End Sub


    Private Sub PurchaseOrderReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        ''TODO: This line of code loads data into the 'PurchaseOrderDataSet.samplesss' table. You can move, or remove it, as needed.
        'Me.samplesssTableAdapter.Fill(Me.PurchaseOrderDataSet.samplesss)


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        Dim dt As New DataTable

        sqlcmd = New SqlCommand("samplesss", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)
        Dim r(0), i(0) As ReportParameter

        Dim MonthofReportz As String

        MonthofReportz = "Total Purchase order from day " & txtDatefrom.Text & " to day " & txtDateTo.Text
        i(0) = New ReportParameter("MonthofReport", MonthofReportz, True)
       
        'This code is to pass text into rdlc report
        r(0) = New ReportParameter("Total", lbltot.Text, True)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("PurchaseOrder", dt))

        Me.ReportViewer1.RefreshReport()

    End Sub
  
End Class