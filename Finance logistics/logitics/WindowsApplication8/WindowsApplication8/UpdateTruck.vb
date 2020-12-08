Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateTruck

    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim sqlds As New DataSet


    Private Sub UpdateTruck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim str As String
        'str = "data source= laptop-fohm0anh,34458;network library= dbmssocn;user id=sa;password=201311422;initial catalog=acrodistributionnetworkinc;integrated security=false"
        'sqlcon.ConnectionString = str
        'sqlcon.Open()


        sqlcon.ConnectionString = connString()

        sqlcon.Open()



        'sqlcon.ConnectionString = "Data Source=KETHANDMARIA-PC\SQLEXPRESS;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123"
        'sqlcon.Open()

        txtTruckID.Text = lblTruckID.Text

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Try
            sqlcmd = New SqlCommand("updateTruckInformation", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@truckid", txtTruckID.Text)
            sqlcmd.Parameters.AddWithValue("@plate", txtPlateNumber.Text)
            sqlcmd.Parameters.AddWithValue("@tare", txtTare.Text)
            sqlcmd.Parameters.AddWithValue("@gweight", txtGross.Text)
            sqlcmd.Parameters.AddWithValue("@color", txtColor.Text)
            sqlcmd.Parameters.AddWithValue("@cc", txtCubicCap.Text)
            sqlcmd.Parameters.AddWithValue("@nweight", txtNetWeight.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Truck successfully updated!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTruckID.Clear()
            txtPlateNumber.Clear()
            txtTare.Clear()
            txtGross.Clear()
            txtColor.Clear()
            txtCubicCap.Clear()

        Catch ex As Exception
            MessageBox.Show("Please Review the Information Given!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try

      

    End Sub

 
    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing

        End Select

    End Sub

    Private Sub txtCubicCap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCubicCap.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58

            Case Else

                e.KeyChar = Nothing

        End Select

    End Sub

    Private Sub txtTare_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTare.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing

        End Select

    End Sub

    Private Sub txtGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing

        End Select

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetWeight.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else

                e.KeyChar = Nothing

        End Select

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim message, title As String
        Dim amount As Double
        Dim valueof As Object
        message = "Enter the amount of the truck sold"
        title = "Amount"


        valueof = InputBox(message, title, amount)
        If valueof = "" Then
            Exit Sub
        Else
            Try
                sqlcmd = New SqlCommand("sellTruck", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                sqlcmd.Parameters.AddWithValue("@amtsold", valueof)
                sqlcmd.Parameters.AddWithValue("@datesold", Format(Date.Now, "yyyy-MM-dd"))
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                'mark as sold 

                sqlcmd = New SqlCommand("markThissold", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()


                MessageBox.Show("The past information of the truck is still saved.Truck will no longer have any transaction in the system.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmLogisticsMain.Focus()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
           
        End If

    End Sub
End Class