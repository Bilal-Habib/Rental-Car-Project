Imports System.IO

Class CustomerDatabaseForm

    Dim index As Integer

    Private Sub EditCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FullLine As String
        FileOpen(1, Customerfilename, OpenMode.Input)
        Do While Not EOF(1)
            FullLine = LineInput(1)
            Dim Item() As String = Split(FullLine, sep)
            With CustomerDatabase(NumOfCustomers)
                .ID = Item(0)
                .Forename = Item(1)
                .Surname = Item(2)
                .Contact = Item(3)
                .Address = Item(4)
                .Email = Item(5)
            End With
            NumOfCustomers += 1
        Loop
        FileClose(1)
        MessageBox.Show(NumOfCustomers)
    End Sub

    'Private Sub bubble()
    '    Dim swapped As Boolean
    '    Dim tempval As Integer
    '    Do
    '        For counter As Integer = 0 To NumOfCustomers - 2
    '            If CustomerDatabase(counter).ID > CustomerDatabase(counter + 1).ID Then
    '                tempval = CustomerDatabase(counter + 1).ID
    '                MsgBox("tempval now holds: " & CustomerDatabase(counter + 1).ID)
    '                CustomerDatabase(counter + 1) = CustomerDatabase(counter)
    '                MessageBox.Show(CustomerDatabase(counter + 1).ID = CustomerDatabase(counter).ID)
    '                CustomerDatabase(counter).ID = tempval
    '                'MsgBox(CustomerDatabase(counter + 1).ID = tempval)
    '                swapped = True
    '            End If
    '        Next
    '    Loop Until swapped = False
    'End Sub

    Private Sub cmdExitForm_Click(sender As Object, e As EventArgs) Handles cmdExitForm.Click
        'bubble()
        MainFormMenu.Show()
        Me.Hide()
        'Hides current form and shows the main menu
    End Sub

    Private Sub cmdAddRow_Click(sender As Object, e As EventArgs) Handles cmdAddRow.Click
        AddCustomer()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick

        'get the index of the selected datagridview row
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        'Show Data from the selected row to textboxes
        selectedRow = CustomerDataGridView.Rows(index)
        TextBoxID.Text = selectedRow.Cells(0).Value.ToString()
        TextBoxForename.Text = selectedRow.Cells(1).Value.ToString()
        TextBoxSurname.Text = selectedRow.Cells(2).Value.ToString()
        TextBoxContactNo.Text = selectedRow.Cells(3).Value.ToString()
        TextBoxAddress.Text = selectedRow.Cells(4).Value.ToString()
        TextBoxEmail.Text = selectedRow.Cells(5).Value.ToString()

    End Sub

    Private Sub cmdDeleteRow_Click(sender As Object, e As EventArgs) Handles cmdDeleteRow.Click
        Delete(Customerfilename, TextBoxID.Text, NumOfCustomers)
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        RefreshDatabase(CustomerDataGridView, Customerfilename, 6)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Delete(Customerfilename, TextBoxID.Text, NumOfCustomers)
        AddCustomer()
        'With CustomerDatabase(NumOfCustomers)
        '    Using SearchReader As New StreamReader(Customerfilename)
        '        While Not SearchReader.EndOfStream
        '            Dim line() As String = SearchReader.ReadLine().Split(",")


        '        End While
        '    End Using
        'End With

        'Dim File = My.Computer.FileSystem.OpenTextFileWriter(Customerfilename, True) 'open the file
        'Dim position As Integer = -1

        'For i As Integer = 0 To NumOfCustomers - 1 'loop through all the records
        '    With CustomerDatabase(i)
        '        If .ID = TextBoxID.Text Then
        '            position = i
        '        End If
        '    End With
        'Next

        'With CustomerDatabase(position) 'Puts values from all textboxes into the record elements
        '    .ID = TextBoxID.Text
        '    .Name = TextBoxName.Text
        '    .Contact = TextBoxContactNo.Text
        '    .Address = TextBoxAddress.Text
        'End With
        'Dim sep As String = ","

        'With CustomerDatabase(position)
        '    Dim oneline As String = .ID + sep + .Name + sep + .Contact + sep + .Address
        '    File.WriteLine(oneline) 'write the line to file
        'End With
        'File.Close()
    End Sub

    Private Sub cmdSearchCustomer_Click(sender As Object, e As EventArgs) Handles cmdSearchCustomer.Click
        SearchRecord(Customerfilename, CustomerDataGridView, TextBoxSearch.Text)
    End Sub
End Class