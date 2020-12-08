Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms



Public Class Top10MostRepairedTrucks
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub Top10MostRepairedTrucks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reportviewer.Focus()

    End Sub

    Private Sub Top10MostRepairedTrucks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        ''TODO: This line of code loads data into the 'top10RepairTrucks.getTop5Repairtrucks' table. You can move, or remove it, as needed.
        'Me.getTop5RepairtrucksTableAdapter.Fill(Me.top10RepairTrucks.getTop5Repairtrucks)

        sqlcon.ConnectionString = connString()

        sqlcon.Open()


        Me.ReportViewer1.LocalReport.DataSources.Clear()


        sqlcmd = New SqlCommand("getTop5Repairtrucks", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim r(0) As ReportParameter

        Dim comment As String

        comment = "This is the top 10 most repaired trucks from " & txtDatefrom.Text & " to " & txtDateTo.Text
        r(0) = New ReportParameter("dates", comment, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("top10RepairedDS", dt))

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub txtDatefrom_TextChanged(sender As Object, e As EventArgs) Handles txtDatefrom.TextChanged

    End Sub
End Class