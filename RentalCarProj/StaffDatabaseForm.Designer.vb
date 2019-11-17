<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxForename = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.cmdDeleteRow = New System.Windows.Forms.Button()
        Me.cmdAddRow = New System.Windows.Forms.Button()
        Me.cmdExitForm = New System.Windows.Forms.Button()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAuthorityLevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSearchStaff = New System.Windows.Forms.Button()
        Me.cmdEditStaff = New System.Windows.Forms.Button()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "UserName"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(343, 302)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxUsername.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-171, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-171, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(343, 402)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxPassword.TabIndex = 35
        '
        'TextBoxForename
        '
        Me.TextBoxForename.Location = New System.Drawing.Point(39, 405)
        Me.TextBoxForename.Name = "TextBoxForename"
        Me.TextBoxForename.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxForename.TabIndex = 34
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(39, 302)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxID.TabIndex = 33
        '
        'cmdDeleteRow
        '
        Me.cmdDeleteRow.Location = New System.Drawing.Point(39, 157)
        Me.cmdDeleteRow.Name = "cmdDeleteRow"
        Me.cmdDeleteRow.Size = New System.Drawing.Size(170, 51)
        Me.cmdDeleteRow.TabIndex = 32
        Me.cmdDeleteRow.Text = "Delete"
        Me.cmdDeleteRow.UseVisualStyleBackColor = True
        '
        'cmdAddRow
        '
        Me.cmdAddRow.Location = New System.Drawing.Point(39, 58)
        Me.cmdAddRow.Name = "cmdAddRow"
        Me.cmdAddRow.Size = New System.Drawing.Size(170, 55)
        Me.cmdAddRow.TabIndex = 31
        Me.cmdAddRow.Text = "Add "
        Me.cmdAddRow.UseVisualStyleBackColor = True
        '
        'cmdExitForm
        '
        Me.cmdExitForm.Location = New System.Drawing.Point(218, 671)
        Me.cmdExitForm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdExitForm.Name = "cmdExitForm"
        Me.cmdExitForm.Size = New System.Drawing.Size(164, 55)
        Me.cmdExitForm.TabIndex = 30
        Me.cmdExitForm.Text = "Exit"
        Me.cmdExitForm.UseVisualStyleBackColor = True
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AllowUserToAddRows = False
        Me.StaffDataGridView.AllowUserToDeleteRows = False
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.StaffDataGridView.Location = New System.Drawing.Point(615, 49)
        Me.StaffDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.ReadOnly = True
        Me.StaffDataGridView.Size = New System.Drawing.Size(1184, 851)
        Me.StaffDataGridView.TabIndex = 29
        '
        'Column1
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 190
        '
        'Column2
        '
        Me.Column2.HeaderText = "Forename"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 190
        '
        'Column3
        '
        Me.Column3.HeaderText = "Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 190
        '
        'Column4
        '
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 190
        '
        'Column5
        '
        Me.Column5.HeaderText = "Password"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 190
        '
        'Column6
        '
        Me.Column6.HeaderText = "Authority Level"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 190
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(34, 671)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(160, 55)
        Me.cmdRefresh.TabIndex = 28
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 459)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Authority Level"
        '
        'TextBoxAuthorityLevel
        '
        Me.TextBoxAuthorityLevel.Location = New System.Drawing.Point(343, 500)
        Me.TextBoxAuthorityLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxAuthorityLevel.Name = "TextBoxAuthorityLevel"
        Me.TextBoxAuthorityLevel.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxAuthorityLevel.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 263)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 355)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Forename"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Location = New System.Drawing.Point(39, 500)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxSurname.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Surname"
        '
        'cmdSearchStaff
        '
        Me.cmdSearchStaff.Location = New System.Drawing.Point(342, 58)
        Me.cmdSearchStaff.Name = "cmdSearchStaff"
        Me.cmdSearchStaff.Size = New System.Drawing.Size(171, 55)
        Me.cmdSearchStaff.TabIndex = 47
        Me.cmdSearchStaff.Text = "Search"
        Me.cmdSearchStaff.UseVisualStyleBackColor = True
        '
        'cmdEditStaff
        '
        Me.cmdEditStaff.Location = New System.Drawing.Point(343, 157)
        Me.cmdEditStaff.Name = "cmdEditStaff"
        Me.cmdEditStaff.Size = New System.Drawing.Size(170, 51)
        Me.cmdEditStaff.TabIndex = 48
        Me.cmdEditStaff.Text = "Edit"
        Me.cmdEditStaff.UseVisualStyleBackColor = True
        '
        'StaffDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 983)
        Me.Controls.Add(Me.cmdEditStaff)
        Me.Controls.Add(Me.cmdSearchStaff)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAuthorityLevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxForename)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.cmdDeleteRow)
        Me.Controls.Add(Me.cmdAddRow)
        Me.Controls.Add(Me.cmdExitForm)
        Me.Controls.Add(Me.StaffDataGridView)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StaffDatabaseForm"
        Me.Text = "StaffDatabaseForm"
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxForename As TextBox
    Public WithEvents TextBoxID As TextBox
    Friend WithEvents cmdDeleteRow As Button
    Friend WithEvents cmdAddRow As Button
    Friend WithEvents cmdExitForm As Button
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAuthorityLevel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSearchStaff As Button
    Friend WithEvents cmdEditStaff As Button
End Class
