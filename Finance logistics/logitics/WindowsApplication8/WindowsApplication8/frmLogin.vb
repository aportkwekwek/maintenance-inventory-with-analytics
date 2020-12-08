Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin
    Dim sqlcmd As SqlCommand
    Dim sqlcon As New SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            sqlcon.ConnectionString = connString()
            sqlcon.Open()
        Catch ex As Exception
            
            MessageBox.Show("Please contact your network administrator", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            sqlcmd = New SqlCommand("login", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@userid", txtUsername.Text)
            sqlcmd.Parameters.AddWithValue("@userpass", txtPass.Text)
            sqlcmd.Parameters.AddWithValue("@dept", lblDepartment.Text)
            sqlcmd.Connection = sqlcon
            Using f = sqlcmd.ExecuteReader
                If f.Read Then
                    If f.GetValue(5) = "USER" Then
                        frmLogisticsMain.btnMyAccount.Enabled = False
                        frmLogisticsMain.btnMyAccount.Visible = False
                        frmLogisticsMain.btnLogOut.Location = frmLogisticsMain.btnMyAccount.Location

                    Else
                        frmLogisticsMain.btnMyAccount.Enabled = True

                    End If
                    Me.Hide()
                    txtUsername.Clear()
                    txtPass.Clear()
                    frmLogisticsMain.Show()
                    MessageBox.Show("Welcome " & f.GetValue(2) & " " & f.GetValue(3))
                    frmLogisticsMain.lblWelcome.Text = "WELCOME " & f.GetValue(2) & " " & f.GetValue(3)
                    frmLogisticsMain.txtUsername.Text = f.GetValue(0)
                Else

                    MessageBox.Show("Incorrect Username or Password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Cant login this time please contact your network administrator", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = MessageBox.Show("Are you sure you want to quit?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then

            txtUsername.Clear()
            txtPass.Clear()
            Me.Close()
            sqlcon.Close()
        Else

            Exit Sub

        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If txtPass.TextLength < 1 Or txtUsername.TextLength < 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class