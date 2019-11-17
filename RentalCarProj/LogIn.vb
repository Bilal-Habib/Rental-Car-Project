Imports System.IO

Class LogOnForm

    Private Sub LogOnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oneLine As String = ""
        FileOpen(1, StaffFilename, OpenMode.Input)
        'Opens the Staff CSV File and names it "1" 
        Do While Not EOF(1)
            'Ensures every line is read by making it read the file till the end
            oneLine = LineInput(1)
            'Holds the string value of a line in the csv file
            Dim SeperatedLine() As String = Split(oneLine, sep)
            'separates the line being read in the csv file by a comma
            With StaffDatabase(NumOfStaff)
                .ID = SeperatedLine(0)
                .Forename = SeperatedLine(1)
                .Surname = SeperatedLine(2)
                .Username = SeperatedLine(3)
                .Password = SeperatedLine(4)
                .AuthorityLevel = SeperatedLine(5)
                'Assigns every variable in the structure to a value in the line being read
            End With
            NumOfStaff += 1
            'Updates the amount of records in the csv file
        Loop
        FileClose(1)
        'Closes the flie after being read
    End Sub

    Private Sub cmdLogIn_Click(sender As Object, e As EventArgs) Handles cmdLogIn.Click
        Dim Success As Boolean
        Dim LoginMessage As String
        For i As Integer = 0 To NumOfStaff - 1
            'Loops through every record
            If username.Text = "" Or password.Text = "" Then
                MessageBox.Show("Please fill in all details")
                If username.Text = StaffDatabase(i).Username And password.Text = StaffDatabase(i).Password Then
                    'Compares the username and password with the record at index i (every record)
                    Success = True
                    'Displays a message box to tell them if they have succeeded
                    LoginMessage = "Logged in as " & StaffDatabase(i).Forename & " " & StaffDatabase(i).Surname
                End If
            End If
        Next
        If Success = True Then
            FileClose(1)
            MessageBox.Show(LoginMessage)
            MainFormMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Failure")
            password.Text = ""
        End If
    End Sub

    Private Sub password_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Allows the user to press enter instead of clicking on buttons
            Dim Success As Boolean
            Dim LoginMessage As String
            For i As Integer = 0 To NumOfStaff - 1
                'Loops through every record
                If username.Text = StaffDatabase(i).Username And password.Text = StaffDatabase(i).Password Then
                    'Compares the username and password with the record at index i (every record)
                    Success = True
                    'Displays a message box to tell them if they have succeeded
                    LoginMessage = "Logged in as " & StaffDatabase(i).Forename & " " & StaffDatabase(i).Surname
                End If
            Next
            If Success = True Then
                FileClose(1)
                MessageBox.Show(LoginMessage)
                MainFormMenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Failure")
                password.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdExitApp_Click(sender As Object, e As EventArgs) Handles cmdExitApp.Click
        ExitMessage.Show()
    End Sub

End Class