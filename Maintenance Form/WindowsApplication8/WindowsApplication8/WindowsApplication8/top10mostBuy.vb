Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class top10mostBuy
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim dt As New DataTable

    Private Sub top10mostBuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        ''TODO: This line of code loads data into the 'top10MostBuyds.top10MostBuy' table. You can move, or remove it, as needed.
        'Me.top10MostBuyTableAdapter.Fill(Me.top10MostBuyds.top10MostBuy)


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()


        Me.ReportViewer1.LocalReport.DataSources.Clear()

        sqlcmd = New SqlCommand("top10MostBuy", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@dateFrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateTo", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim p(0) As ReportParameter

        Dim comment As String
        comment = "This is the list of top 10 most buy parts from " & txtDateFrom.Text & " to " & txtDateTo.Text

        p(0) = New ReportParameter("dates", comment, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("top10Most", dt))


        Me.ReportViewer1.RefreshReport()

    End Sub

End Class