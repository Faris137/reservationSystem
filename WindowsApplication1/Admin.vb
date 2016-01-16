Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student.Visible = True
        Student.Label1.Text = Me.TextBox1.Text
    End Sub
End Class