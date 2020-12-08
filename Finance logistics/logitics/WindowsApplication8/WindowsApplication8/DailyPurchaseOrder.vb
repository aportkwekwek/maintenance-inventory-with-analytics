Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class DailyPurchaseOrder
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub DailyPurchaseOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmLogisticsMain.Focus()
        Reportviewer.Focus()

    End Sub


    Private Sub DailyPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DailyPurchaseOrderDataSet.samplesss' table. You can move, or remove it, as needed.
        'Me.samplesssTableAdapter.Fill(Me.DailyPurchaseOrderDataSet.samplesss)
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        sqlcon.ConnectionString = connString()

        sqlcon.Open()

        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        sqlcmd = New SqlCommand("samplesss", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        sqlcmd.Dispose()


        Dim r(0), i(0) As ReportParameter
        Dim dateReport As String


        dateReport = "Total Purchase order from day " & txtDateFrom.Text & " to day " & txtDateTo.Text
        r(0) = New ReportParameter("monthReport", dateReport, True)

        i(0) = New ReportParameter("total", lblTotal.Text, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dailyPurchaseOrder", dt))
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)






    End Sub
End Class