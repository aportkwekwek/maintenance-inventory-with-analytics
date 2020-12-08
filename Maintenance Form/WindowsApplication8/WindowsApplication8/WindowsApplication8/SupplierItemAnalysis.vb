Imports System.Data.SqlClient

Public Class SupplierItemAnalysis
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim lifetime As Integer
    Private Sub SupplierItemAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim query As String
        'query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;User id=sa;Password=201311422;Initial Catalog=AcroDistributionNetworkInc;Integrated Security=False"
        'sqlcon.ConnectionString = query
        'sqlcon.Open()
        'getSuppliers()


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            sqlcmd = New SqlCommand("ItemAnalysis", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@desc", txtSearch.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtSearch.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            Dim dt As New DataTable
            sqlda.Fill(dt)

            dgvItemList.DataSource = dt

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        
        Try
            Dim desc, model As String
            desc = dgvItemList.SelectedCells.Item(0).Value
            model = dgvItemList.SelectedCells.Item(1).Value

            sqlcmd = New SqlCommand("SupplierItemAnalysis", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@desc", desc)
            sqlcmd.Parameters.AddWithValue("@model", model)
            sqlcmd.Connection = sqlcon

            Using k = sqlcmd.ExecuteReader
                If k.Read Then
                    SupplierItemAnalysisReport.lbldesc.Text = desc
                    SupplierItemAnalysisReport.lblModel.Text = model
                    SupplierItemAnalysisReport.Show()
                    SupplierItemAnalysisReport.Focus()

                Else

                    MessageBox.Show("The item has not been broken nor installed in any truck", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End Using
            

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        txtSearch.Clear()
        frmMaintenanceMain.Focus()


    End Sub
End Class