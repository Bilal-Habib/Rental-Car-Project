Imports System.IO

Public Class VehicleHire

    Public Make As String
    Public Model As String
    Public FuelType As String
    Public TotalAmount As String

    Public CustomerForename As String
    Public CustomerSurname As String
    Public CustomerContact As String
    Public CustomerAddress As String
    Public CustomerEmail As String
    'defining relevant variables at any early stage for easy use
    'these variables will be used to hold the values from the data grid views

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        MainFormMenu.Show()
        Me.Hide()
    End Sub

    Dim cost As Decimal
    Dim vat As Decimal = 1.25
    Dim total As Decimal

    Private Sub cmdCalcuate_Click(sender As Object, e As EventArgs) Handles cmdCalcuate.Click
        Try
            If Insurance.Checked = True Then
                total = (Val(CostPerDay.Text) * Val(NoOfDays.Text) * vat) + 100
                'Calculates total with insurance
            Else
                total = (Val(CostPerDay.Text) * Val(NoOfDays.Text) * vat)
                'Calculates total without insurance
            End If

            TotalIncVAT.Text = Format(total, "0.00")
            TotalAmount = TotalIncVAT.Text

            'Format() changes the values of the numbers to 2 decimal places
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdGenerateInvoice.Click
        Invoice.Show()
        Me.Hide()
    End Sub

    Private Sub cmdRefreshCustomer_Click(sender As Object, e As EventArgs) Handles cmdRefreshCustomer.Click
        Dim datagrid As DataGridView = CustomerDataGrid
        RefreshDatabase(datagrid, Customerfilename, 6)
    End Sub

    Private Sub cmdSearchCustomer_Click(sender As Object, e As EventArgs) Handles cmdSearchCustomer.Click
        Dim datagrid As DataGridView = CustomerDataGrid
        Dim textbox As String = TextBoxCustomerSearch.Text
        SearchRecord(Customerfilename, datagrid, textbox)
    End Sub

    Private Sub cmdVehicleSearch_Click(sender As Object, e As EventArgs) Handles cmdVehicleSearch.Click
        Dim datagrid As DataGridView = VehicleDataGrid
        Dim textbox As String = TextBoxVehicleSearch.Text
        SearchRecord(VehicleFilename, datagrid, textbox)
    End Sub

    Private Sub cmdRefreshVehicleDataGrid_Click(sender As Object, e As EventArgs) Handles cmdRefreshVehicleDataGrid.Click
        Dim datagrid As DataGridView = VehicleDataGrid
        RefreshDatabase(datagrid, VehicleFilename, 6)
    End Sub

    Private Sub VehicleDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles VehicleDataGrid.CellContentClick
        Make = VehicleDataGrid.CurrentRow.Cells(1).Value
        Model = VehicleDataGrid.CurrentRow.Cells(2).Value
        CostPerDay.Text = VehicleDataGrid.CurrentRow.Cells(3).Value
        'Sets value of cost per day from record to the the Cost / Day textbox
        FuelType = VehicleDataGrid.CurrentRow.Cells(4).Value
        MessageBox.Show(Make + sep + Model + CostPerDay.Text + sep + FuelType)
    End Sub
    '

    Private Sub CustomerDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGrid.CellContentClick
        CustomerForename = CustomerDataGrid.CurrentRow.Cells(1).Value
        CustomerSurname = CustomerDataGrid.CurrentRow.Cells(2).Value
        CustomerContact = CustomerDataGrid.CurrentRow.Cells(3).Value
        CustomerAddress = CustomerDataGrid.CurrentRow.Cells(4).Value
        CustomerEmail = CustomerDataGrid.CurrentRow.Cells(5).Value
        MessageBox.Show(CustomerForename + sep + CustomerSurname + sep + CustomerContact + sep + CustomerAddress + sep + CustomerEmail)
    End Sub

    Private Sub VehicleHire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Please Enter a Number!")
    End Sub
    'sets the values from the records into the public variables created
End Class