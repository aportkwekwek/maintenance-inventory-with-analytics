Imports System.Data
Imports System.Data.SqlClient


Public Class frmReportViewer
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboReportType.Text = Nothing Then
            MessageBox.Show("Please Select Report Type")

            Exit Sub

        End If
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
        Me.Hide()

        PurchaseOrderReport.txtDateFrom.Text = dtpDateFrom.Text
        PurchaseOrderReport.txtDateTo.Text = dtpDateTo.Text
        PurchaseOrderReport.Show()


    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim query As String
        query = "Data Source=LAPTOP-FOHM0ANH,34368;Network Library=DBMSSOCN;User id=sa;Password=201311422;Initial Catalog=AcroDistributionNetworkInc;Integrated Security=False"
        sqlcon.ConnectionString = query
        sqlcon.Open()


        'sqlcon.ConnectionString = "Data Source=KETHANDMARIA-PC\SQLEXPRESS;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123"
        'sqlcon.Open()

    End Sub
End Class