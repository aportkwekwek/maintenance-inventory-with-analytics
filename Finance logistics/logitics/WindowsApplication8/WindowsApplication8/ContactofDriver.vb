Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class ContactofDriver
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub ContactofDriver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlcon.ConnectionString = connString()
        sqlcon.Open()
      
        Timer1.Start()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmLogisticsMain.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            sqlcmd = New SqlCommand("getPicofDriver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", lblDriverID.Text)
            sqlcmd.Connection = sqlcon

            Dim table As New DataTable
            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(table)

            Dim img() As Byte

            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)

            picDriver.Image = Image.FromStream(ms)

            sqlcmd = New SqlCommand("getallinfoDriver", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", lblDriverID.Text)
            sqlcmd.Connection = sqlcon
            Using i = sqlcmd.ExecuteReader
                If i.Read Then
                    lblName.Text = i.GetValue(1) & " ," & i.GetValue(2) & " " & i.GetValue(3)
                    lblContactNumber.Text = i.GetValue(4)
                    lblAddress.Text = i.GetValue(9)
                    lblTin.Text = i.GetValue(10)
                    'contact person
                    lblContactPerson.Text = i.GetValue(11) & " ," & i.GetValue(12) & " " & i.GetValue(13)
                    lblAddressC.Text = i.GetValue(14)
                    lblContactC.Text = i.GetValue(15)

                End If
            End Using

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
End Class