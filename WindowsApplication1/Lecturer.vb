Public Class Lecturer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultDataSet)

    End Sub

    Private Sub Lecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultDataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.ConsultDataSet.Appointment)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AppointmentBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.AppointmentBindingSource.AddNew()
    End Sub
End Class