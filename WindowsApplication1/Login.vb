Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username, password As String
        If TextBox1.Text = "student" And TextBox2.Text = "student123" Then
            Student.Show()
            Me.Hide()
        ElseIf TextBox1.Text = "admin" And TextBox2.Text = "admin123" Then
            Admin.Show()
            Me.Hide()
        Else
            MsgBox("User name or Passwords is incorrect")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
