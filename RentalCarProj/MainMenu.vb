Class MainFormMenu
    Private Sub cmdEditCustomerForm_Click(sender As Object, e As EventArgs) Handles cmdEditCustomerDatabase.Click
        CustomerDatabaseForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdEditCarForm_Click(sender As Object, e As EventArgs) Handles cmdEditVehicleForm.Click
        VehicleDatabaseForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdEditStaffDatabase_Click(sender As Object, e As EventArgs) Handles cmdEditStaffDatabase.Click
        StaffDatabaseForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdInvoiceForm_Click(sender As Object, e As EventArgs) Handles cmdInvoiceForm.Click
        VehicleHire.Show()
        Me.Hide()
    End Sub

    Private Sub cmdExitApplication_Click(sender As Object, e As EventArgs) Handles cmdExitApplication.Click
        ExitMessage.Show()
    End Sub
End Class