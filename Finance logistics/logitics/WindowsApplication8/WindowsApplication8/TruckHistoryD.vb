Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class TruckHistoryD
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub TruckHistoryD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        sqlcon.ConnectionString = connString()

        sqlcon.Open()

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Dim datefrom, dateto, truckid, platenumber, allC As String
        datefrom = txtDateFrom.Text
        dateto = txtDateTo.Text
        truckid = txtTruckid.Text
        platenumber = txtPlatenumber.Text

        allC = platenumber & " history from " & datefrom & " to " & dateto

        sqlcmd = New SqlCommand("getTruckHistoryRP", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@truckid", truckid)
        sqlcmd.Parameters.AddWithValue("@datefrom", datefrom)
        sqlcmd.Parameters.AddWithValue("@dateto", dateto)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim r(0) As ReportParameter


        r(0) = New ReportParameter("dates", allC, True)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("truckHistoryDS", dt))
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class