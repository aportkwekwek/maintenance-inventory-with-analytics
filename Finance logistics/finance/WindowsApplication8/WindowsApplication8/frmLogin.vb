Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlcmd = New SqlCommand("login", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@userid", txtUsername.Text)
        sqlcmd.Parameters.AddWithValue("@userpass", txtPassword.Text)
        sqlcmd.Parameters.AddWithValue("@dept", lblDepartment.Text)
        sqlcmd.Connection = sqlcon
        Using s = sqlcmd.ExecuteReader
            If s.Read Then
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Hide()
                frmFinance.Show()
                frmFinance.lblUserInformation.Text = "Welcome " & s.GetValue(2) & " " & s.GetValue(3)
                MessageBox.Show("Welcome " & s.GetValue(2) & " " & s.GetValue(3))

            Else
                MessageBox.Show("Invalid Username or Password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                txtUsername.SelectAll()
                txtUsername.Focus()
                txtPassword.Clear()

                Exit Sub
            End If
        End Using
    End Sub

  
  
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.TextLength < 1 Or txtUsername.TextLength < 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

End Class