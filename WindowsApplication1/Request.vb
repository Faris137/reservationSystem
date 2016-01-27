Public Class Request
    Private Sub AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultDataSet)

    End Sub

    Private Sub Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultDataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.ConsultDataSet.Appointment)

    End Sub
End Class