Imports System.IO

Module ModuleCode

    'Public Sub SortID()
    '    Using writer As New StreamWriter(Customerfilename, False)
    '        For i As Integer = 0 To NumOfCustomers - 1
    '            With CustomerDatabase(NumOfCustomers)
    '                NumOfCustomers = i
    '                .ID = NumOfCustomers
    '            End With
    '            writer.Write(CustomerDatabase(i).ID)
    '        Next
    '        NumOfCustomers += 1
    '    End Using
    'End Sub

    Public Sub SearchRecord(filename As String, DataGrid As DataGridView, Textbox As String)
        Dim columns_expected As Integer = DataGrid.Columns.Count
        Dim condition As Boolean
        DataGrid.Rows.Clear()
        'Datagriview rows clear

        Using SearchReader As New StreamReader(filename)
            While Not SearchReader.EndOfStream
                'Searches through every record
                Dim FullLine As String = SearchReader.ReadLine()
                If FullLine.Contains(Textbox) Then
                    Dim SeparatedLine() As String = FullLine.Split(",")
                    'Separates the line being read by commas
                    DataGrid.Rows.Add("")
                    If SeparatedLine.Length = columns_expected Then
                        For ix As Integer = 0 To columns_expected - 1
                            DataGrid.Rows(DataGrid.Rows.Count - 1).Cells(ix).Value = SeparatedLine(ix)
                        Next
                    End If
                    condition = True
                End If
            End While
        End Using
        If condition = True Then
            MessageBox.Show("Record Found!")
        Else
            MessageBox.Show("No Results!")
        End If
    End Sub

    Public Sub Delete(Filename As String, TextBox As String, numofrecords As Integer)
        Dim list As New List(Of String)()

        Using Deletereader As New StreamReader(Filename)
            While Not Deletereader.EndOfStream
                Dim FullLine As String = Deletereader.ReadLine()
                Dim Item() As String = Split(FullLine, sep)
                If Item(0) = TextBox Then
                    'Do nothing
                Else
                    list.Add(FullLine)
                End If
            End While
        End Using
        Dim NewNumOfRecords As Integer = list.Count
        Using writer As New StreamWriter(Filename, False)
            For i = 0 To NewNumOfRecords - 1
                writer.Write(list(i) & vbCrLf)
            Next
            numofrecords = NewNumOfRecords
        End Using
        MessageBox.Show(numofrecords)
    End Sub

    Public Sub RefreshDatabase(Datagrid As DataGridView, filename As String, columns_expected As Integer)

        Datagrid.Rows.Clear()
        'Acts as refresh button where we keep importing the customer database
        Dim reader As New StreamReader(filename)
        Dim FullLine As String = ""
        Do
            FullLine = reader.ReadLine
            If FullLine Is Nothing Then Exit Do
            Dim SeparatedLine() As String = FullLine.Split(",")
            Datagrid.Rows.Add("")
            If SeparatedLine.Length = columns_expected Then
                For ix As Integer = 0 To columns_expected - 1
                    Datagrid.Rows(Datagrid.Rows.Count - 1).Cells(ix).Value = SeparatedLine(ix)
                Next
            End If
        Loop
        reader.Close()
        MessageBox.Show(NumOfCustomers)
    End Sub
    'Use this in version 3

    Public Sub AddCustomer()
        Try
            CustomerDatabaseForm.TextBoxID.Text = NumOfCustomers + 1
            'Increments the number of records by 1

            With CustomerDatabase(NumOfCustomers)
                .ID = CustomerDatabaseForm.TextBoxID.Text
                .Forename = CustomerDatabaseForm.TextBoxForename.Text
                .Surname = CustomerDatabaseForm.TextBoxSurname.Text
                .Contact = CustomerDatabaseForm.TextBoxContactNo.Text
                .Address = CustomerDatabaseForm.TextBoxAddress.Text
                .Email = CustomerDatabaseForm.TextBoxEmail.Text
            End With
            'Puts values from all textboxes into the record elements

            Dim File As StreamWriter
            File = My.Computer.FileSystem.OpenTextFileWriter(VehicleFilename, True)
            With CustomerDatabase(NumOfCustomers)

                If (.ID = "" Or .Forename = "" Or .Surname = "" Or .Contact = "" Or .Address = "" Or .Email = "") Then
                    MessageBox.Show("Please fill in all fields")
                ElseIf (.Contact.ToString.Length < 11 Or .Contact.ToString.Length > 11) Then
                    MessageBox.Show("Contact Number must be 11 characters long")
                Else
                    Dim oneline As String = .ID & sep & .Forename & sep & .Surname & sep & .Contact.ToString & sep & .Address & sep & .Email
                    File.WriteLine(oneline)
                    'write the line to file
                End If
            End With
            File.Close()
        Catch ex As Exception
            MessageBox.Show("Unknown Error")
        End Try
    End Sub

    Public Sub AddVehicle()
        VehicleDatabaseForm.TextBoxId.Text = NumOfVehicles

        With VehicleDatabase(NumOfVehicles) 'Puts values from all textboxes into the record elements
            .ID = VehicleDatabaseForm.TextBoxId.Text
            .Make = VehicleDatabaseForm.TextBoxMake.Text
            .Model = VehicleDatabaseForm.TextBoxModel.Text
            .CostPerDay = VehicleDatabaseForm.TextBoxCostPerDay.Text
            .FuelType = VehicleDatabaseForm.TextBoxFuelType.Text
        End With

        Dim File As StreamWriter
        File = My.Computer.FileSystem.OpenTextFileWriter(VehicleFilename, True)
        With VehicleDatabase(NumOfVehicles)
            Dim oneline As String = .ID.ToString + sep + .Make + sep + .Model + sep + .CostPerDay.ToString + sep + .FuelType
            File.WriteLine(oneline) 'write the line to file
        End With
        File.Close()

        NumOfVehicles += 1
    End Sub

    Public Sub AddStaff()
        StaffDatabaseForm.TextBoxID.Text = NumOfStaff + 1
        'This assigns an automatic ID number to the ID Textbox

        With StaffDatabase(NumOfStaff)
            .ID = StaffDatabaseForm.TextBoxID.Text
            .Forename = StaffDatabaseForm.TextBoxForename.Text
            .Surname = StaffDatabaseForm.TextBoxSurname.Text
            .Username = StaffDatabaseForm.TextBoxUsername.Text
            .Password = StaffDatabaseForm.TextBoxPassword.Text
            .AuthorityLevel = StaffDatabaseForm.TextBoxAuthorityLevel.Text
        End With
        'Puts values from all textboxes into the record elements

        Dim File As StreamWriter
        File = My.Computer.FileSystem.OpenTextFileWriter(StaffFilename, True)

        With StaffDatabase(NumOfStaff)
            Dim oneline As String = .ID.ToString + sep + .Forename + sep + .Surname + sep + .Username + sep + .Password + sep + .AuthorityLevel.ToString
            File.WriteLine(oneline) 'write the line to file
        End With

        File.Close()
        NumOfStaff += 1
        'Updates the number of records
    End Sub

End Module
