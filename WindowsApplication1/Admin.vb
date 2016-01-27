Public Class Admin


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter1.Fill(Me.ConsultDataSet.user)
        UserDataGridView.AllowUserToAddRows = True
        UserDataGridView.AllowUserToDeleteRows = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class