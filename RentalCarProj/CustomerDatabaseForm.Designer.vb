<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdExitForm = New System.Windows.Forms.Button()
        Me.cmdAddRow = New System.Windows.Forms.Button()
        Me.cmdDeleteRow = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxContactNo = New System.Windows.Forms.TextBox()
        Me.TextBoxForename = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.cmdSearchCustomer = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(62, 781)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(160, 55)
        Me.cmdRefresh.TabIndex = 0
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.CustomerDataGridView.Location = New System.Drawing.Point(701, 109)
        Me.CustomerDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.Size = New System.Drawing.Size(1185, 802)
        Me.CustomerDataGridView.TabIndex = 1
        '
        'Column1
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Forename"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Contact Number"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Address"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "Email"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'cmdExitForm
        '
        Me.cmdExitForm.Location = New System.Drawing.Point(272, 781)
        Me.cmdExitForm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdExitForm.Name = "cmdExitForm"
        Me.cmdExitForm.Size = New System.Drawing.Size(164, 55)
        Me.cmdExitForm.TabIndex = 2
        Me.cmdExitForm.Text = "Exit"
        Me.cmdExitForm.UseVisualStyleBackColor = True
        '
        'cmdAddRow
        '
        Me.cmdAddRow.Location = New System.Drawing.Point(62, 52)
        Me.cmdAddRow.Name = "cmdAddRow"
        Me.cmdAddRow.Size = New System.Drawing.Size(170, 55)
        Me.cmdAddRow.TabIndex = 3
        Me.cmdAddRow.Text = "Add"
        Me.cmdAddRow.UseVisualStyleBackColor = True
        '
        'cmdDeleteRow
        '
        Me.cmdDeleteRow.Location = New System.Drawing.Point(62, 151)
        Me.cmdDeleteRow.Name = "cmdDeleteRow"
        Me.cmdDeleteRow.Size = New System.Drawing.Size(170, 51)
        Me.cmdDeleteRow.TabIndex = 4
        Me.cmdDeleteRow.Text = "Delete"
        Me.cmdDeleteRow.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Forename"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'TextBoxContactNo
        '
        Me.TextBoxContactNo.Location = New System.Drawing.Point(424, 395)
        Me.TextBoxContactNo.Name = "TextBoxContactNo"
        Me.TextBoxContactNo.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxContactNo.TabIndex = 18
        '
        'TextBoxForename
        '
        Me.TextBoxForename.Location = New System.Drawing.Point(62, 398)
        Me.TextBoxForename.Name = "TextBoxForename"
        Me.TextBoxForename.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxForename.TabIndex = 17
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(62, 295)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxID.TabIndex = 16
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(424, 295)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxAddress.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Address"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(424, 151)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(170, 51)
        Me.cmdEdit.TabIndex = 29
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 458)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Surname"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Location = New System.Drawing.Point(62, 499)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxSurname.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(424, 499)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxEmail.TabIndex = 33
        '
        'cmdSearchCustomer
        '
        Me.cmdSearchCustomer.Location = New System.Drawing.Point(944, 38)
        Me.cmdSearchCustomer.Name = "cmdSearchCustomer"
        Me.cmdSearchCustomer.Size = New System.Drawing.Size(164, 55)
        Me.cmdSearchCustomer.TabIndex = 35
        Me.cmdSearchCustomer.Text = "Search"
        Me.cmdSearchCustomer.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(701, 52)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxSearch.TabIndex = 36
        '
        'CustomerDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 974)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.cmdSearchCustomer)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxContactNo)
        Me.Controls.Add(Me.TextBoxForename)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.cmdDeleteRow)
        Me.Controls.Add(Me.cmdAddRow)
        Me.Controls.Add(Me.cmdExitForm)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Name = "CustomerDatabaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCustomerInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdExitForm As Button
    Friend WithEvents cmdAddRow As Button
    Friend WithEvents cmdDeleteRow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxContactNo As TextBox
    Friend WithEvents TextBoxForename As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents cmdEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSearchCustomer As Button
    Friend WithEvents TextBoxSearch As TextBox
End Class
