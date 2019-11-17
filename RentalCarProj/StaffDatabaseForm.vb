Imports System.IO

Public Class StaffDatabaseForm

    Private Sub StaffDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oneLine As String = ""
        FileOpen(1, StaffFilename, OpenMode.Input)
        Do While Not EOF(1)
            oneLine = LineInput(1)
            Dim SeperatedLine() As String = Split(oneLine, sep)
            With StaffDatabase(NumOfStaff)
                .ID = SeperatedLine(0)
                .Forename = SeperatedLine(1)
                .Surname = SeperatedLine(2)
                .Username = SeperatedLine(3)
                .Password = SeperatedLine(4)
                .AuthorityLevel = SeperatedLine(5)
            End With
            NumOfStaff += 1
        Loop
        FileClose(1)
    End Sub

    Private Sub cmdAddRow_Click(sender As Object, e As EventArgs) Handles cmdAddRow.Click
        AddStaff()
    End Sub

    Private Sub cmdDeleteRow_Click(sender As Object, e As EventArgs) Handles cmdDeleteRow.Click
        Dim TextBoxi As String = TextBoxID.Text
        Delete(StaffFilename, TextBoxi, NumOfStaff)
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        StaffDataGridView.Rows.Clear()
        'Acts as refresh button where we keep importing the customer database
        Dim columns_expected As Integer = StaffDataGridView.Columns.Count
        Dim reader As New StreamReader(StaffFilename)
        Dim line As String = ""
        Do
            line = reader.ReadLine
            If line Is Nothing Then Exit Do
            Dim SeparatedLine() As String = line.Split(",")
            StaffDataGridView.Rows.Add("")
            If SeparatedLine.Length = columns_expected Then
                For ix As Integer = 0 To columns_expected - 1
                    StaffDataGridView.Rows(StaffDataGridView.Rows.Count - 1).Cells(ix).Value = SeparatedLine(ix)
                Next
            End If
        Loop
        reader.Close()
    End Sub

    Private Sub cmdExitForm_Click(sender As Object, e As EventArgs) Handles cmdExitForm.Click
        Me.Close()
        MainFormMenu.Show()
    End Sub

    Private Sub cmdSearchStaff_Click(sender As Object, e As EventArgs) Handles cmdSearchStaff.Click
        Try
            Dim columns_expected As Integer = 6
            Dim Found As Boolean = False
            'Boolean created for the purpose of avoiding to loop every record
            Using SearchReader As New StreamReader(StaffFilename)
                'Reads the file
                While Found = False
                    Dim line As String = SearchReader.ReadLine()
                    'Reads the contents of a line
                    If line.Contains(TextBoxForename.Text) Then
                        'Comparison to see if the file contains what the user is searching for
                        StaffDataGridView.Rows.Clear()
                        Dim SeparatedLine() As String = line.Split(",")
                        StaffDataGridView.Rows.Add("")
                        If SeparatedLine.Length = columns_expected Then
                            For ix As Integer = 0 To columns_expected - 1
                                StaffDataGridView.Rows(StaffDataGridView.Rows.Count - 1).Cells(ix).Value = SeparatedLine(ix)
                                'Adds the record found to the data grid view
                            Next
                        End If
                        Found = True
                    End If
                End While
            End Using
            If Found = True Then
                MessageBox.Show("Record Found!")
            End If
        Catch ex As Exception
            MessageBox.Show("Record Not Found!")
        End Try
    End Sub

    Private Sub cmdEditStaff_Click(sender As Object, e As EventArgs) Handles cmdEditStaff.Click
        'Dim File = My.Computer.FileSystem.OpenTextFileWriter(Customerfilename, True) 'open the file
        'Dim position As Integer = -1

        'For i As Integer = 0 To NumOfStaff - 1 'loop through all the records
        '    With StaffDatabase(i)
        '        If .ID = TextBoxID.Text Then
        '            position = i
        '        End If
        '    End With
        'Next

        'With StaffDatabase(position) 'Puts values from all textboxes into the record elements
        '    .ID = TextBoxID.Text
        '    .Forename = TextBoxForename.Text
        '    .Surname = TextBoxSurname.Text
        '    .Username = TextBoxUsername.Text
        '    .Password = TextBoxPassword.Text
        '    .AuthorityLevel = TextBoxAuthorityLevel.Text
        'End With

        'With StaffDatabase(position)
        '    Dim oneline As String = .ID + sep + .Forename + sep + .Surname + sep + .Username + sep + .Password + sep + .AuthorityLevel
        '    File.WriteLine(oneline) 'write the line to file
        'End With
        'File.Close()
        Dim TextBoxi As String = TextBoxID.Text
        Delete(TextBoxi, StaffFilename, NumOfStaff)
        AddStaff()
    End Sub

    Dim index As Integer
    Private Sub StaffDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellClick

        ' get the index of the selected datagridview row
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        ' show data from the selected row to textboxes
        selectedRow = StaffDataGridView.Rows(index)
        TextBoxID.Text = selectedRow.Cells(0).Value.ToString()
        TextBoxForename.Text = selectedRow.Cells(1).Value.ToString()
        TextBoxSurname.Text = selectedRow.Cells(2).Value.ToString()
        TextBoxUsername.Text = selectedRow.Cells(3).Value.ToString()
        TextBoxPassword.Text = selectedRow.Cells(4).Value.ToString()
        TextBoxAuthorityLevel.Text = selectedRow.Cells(5).Value.ToString()

    End Sub
End Class
