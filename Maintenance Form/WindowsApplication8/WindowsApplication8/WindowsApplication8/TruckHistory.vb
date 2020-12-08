Imports System.Data.SqlClient
Imports System.Data

Public Class TruckHistory
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter


    Private Sub TruckHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlds As New DataSet

        sqlds.Reset()

        'Dim query As String
        'query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"
        'sqlcon.ConnectionString = query
        'sqlcon.Open()

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        sqlcmd = New SqlCommand("TruckHistory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
        sqlcmd.Connection = sqlcon

        
        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "tib")

        dgvMaintenanceRepair.DataSource = sqlds.Tables("tib")
        dgvMaintenanceRepair.Columns(2).DefaultCellStyle.Format = "MMMM dd,yyyy hh:mm:ss tt"
        dgvMaintenanceRepair.Columns(3).DefaultCellStyle.Format = "MMMM dd,yyyy hh:mm:ss tt"

        sqlcmd = New SqlCommand("PartsHistory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(sqlds, "xyz")
        dgvPartsInstalled.DataSource = sqlds.Tables("xyz")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMaintenanceMain.Focus()

    End Sub
End Class