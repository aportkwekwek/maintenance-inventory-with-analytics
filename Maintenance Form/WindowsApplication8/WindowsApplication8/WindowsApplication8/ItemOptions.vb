Imports System.Data
Imports System.Data.SqlClient


Public Class ItemOptions


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim i As Integer
        If RadioButton2.Checked = True Then
            Do While i <= Me.Height <= 419
                Me.Height = i + 10
                i += 1
                If Me.Height = 419 Then
                    Exit Sub
                End If
            Loop
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim i As Integer
        If RadioButton1.Checked = True Then
            Do While i <= Me.Height <= 247
                Me.Height = i + 10
                i += 1
                If Me.Height = 247 Then
                    Exit Sub
                End If
            Loop
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing
        End Select
    End Sub

    
    Private Sub ItemOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class