Imports System.IO

Class VehicleDatabaseForm

    Private Sub CarsDatabse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FullLine As String = ""
        FileOpen(1, VehicleFilename, OpenMode.Input)
        Do While Not EOF(1)
            FullLine = LineInput(1)
            Dim Item() As String = Split(FullLine, sep)
            With VehicleDatabase(NumOfVehicles)
                .ID = Item(0)
                .Make = Item(1)
                .Model = Item(2)
                .CostPerDay = Item(3)
                .FuelType = Item(4)
            End With
            NumOfVehicles += 1
        Loop
        FileClose(1)
        MessageBox.Show(NumOfVehicles)
    End Sub

    Private Sub cmdExitPage_Click(sender As Object, e As EventArgs) Handles cmdExitPage.Click
        MainFormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub cmdRefreshPage_Click(sender As Object, e As EventArgs) Handles cmdRefreshPage.Click

        CarDataGridView.Rows.Clear()
        'Acts as refresh button where we keep importing the customer database
        Dim columns_expected As Integer = 5
        Dim reader As New StreamReader(VehicleFilename)
        Dim sline As String = ""
        Do
            sline = reader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            CarDataGridView.Rows.Add("")
            If words.Length = columns_expected Then
                For ix As Integer = 0 To columns_expected - 1
                    CarDataGridView.Rows(CarDataGridView.Rows.Count - 1).Cells(ix).Value = words(ix)
                Next
            End If
        Loop
        reader.Close()
        'looping through the array and adding a comma between every value to easily locate it
    End Sub

    Private Sub cmdAddCarRow_Click(sender As Object, e As EventArgs) Handles cmdAddCarRow.Click
        With VehicleDatabase(NumOfVehicles) 'Puts values from all textboxes into the record elements
            .ID = TextBoxId.Text
            .Make = TextBoxMake.Text
            .Model = TextBoxModel.Text
            .CostPerDay = TextBoxCostPerDay.Text
            .FuelType = TextBoxFuelType.Text
        End With

        Dim File As StreamWriter
        File = My.Computer.FileSystem.OpenTextFileWriter(VehicleFilename, True)
        With VehicleDatabase(NumOfVehicles)
            Dim oneline As String = .ID.ToString + sep + .Make + sep + .Model + sep + .CostPerDay.ToString + sep + .FuelType
            File.WriteLine(oneline) 'write the line to file
        End With
        File.Close()
    End Sub

    Private Sub cmdDeleteCarRow_Click(sender As Object, e As EventArgs) Handles cmdDeleteCarRow.Click

        Dim TextBoxi As String = TextBoxId.Text
        Delete(VehicleFilename, TextBoxi, NumOfVehicles)

    End Sub
End Class