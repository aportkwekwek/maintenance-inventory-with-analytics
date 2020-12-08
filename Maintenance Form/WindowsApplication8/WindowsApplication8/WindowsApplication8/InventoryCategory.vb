Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class InventoryCategory
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub InventoryCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        ''TODO: This line of code loads data into the 'InventoryCategoryDataSet.categoryPartition' table. You can move, or remove it, as needed.
        'Me.categoryPartitionTableAdapter.Fill(Me.InventoryCategoryDataSet.categoryPartition)

        dt.Reset()

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        sqlcmd = New SqlCommand("categoryPartition", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)


        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("categoriesPartition", dt))
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class