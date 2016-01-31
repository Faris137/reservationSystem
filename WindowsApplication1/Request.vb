Public Class Request
    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultDataSet)

    End Sub

    Private Sub Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultDataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.ConsultDataSet.Appointment)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.AppointmentBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultDataSet)
    End Sub
End Class