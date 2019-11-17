<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleDatabaseForm
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
        Me.TextBoxCostPerDay = New System.Windows.Forms.TextBox()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAddCarRow = New System.Windows.Forms.Button()
        Me.cmdRefreshPage = New System.Windows.Forms.Button()
        Me.cmdExitPage = New System.Windows.Forms.Button()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdDeleteCarRow = New System.Windows.Forms.Button()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMake = New System.Windows.Forms.TextBox()
        Me.TextBoxFuelType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCostPerDay
        '
        Me.TextBoxCostPerDay.Location = New System.Drawing.Point(64, 458)
        Me.TextBoxCostPerDay.Name = "TextBoxCostPerDay"
        Me.TextBoxCostPerDay.Size = New System.Drawing.Size(144, 26)
        Me.TextBoxCostPerDay.TabIndex = 5
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Location = New System.Drawing.Point(294, 458)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(140, 26)
        Me.TextBoxModel.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(290, 392)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(98, 20)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "Model Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cost Per Day"
        '
        'cmdAddCarRow
        '
        Me.cmdAddCarRow.Location = New System.Drawing.Point(63, 129)
        Me.cmdAddCarRow.Name = "cmdAddCarRow"
        Me.cmdAddCarRow.Size = New System.Drawing.Size(155, 55)
        Me.cmdAddCarRow.TabIndex = 9
        Me.cmdAddCarRow.Text = "Add Row"
        Me.cmdAddCarRow.UseVisualStyleBackColor = True
        '
        'cmdRefreshPage
        '
        Me.cmdRefreshPage.Location = New System.Drawing.Point(308, 723)
        Me.cmdRefreshPage.Name = "cmdRefreshPage"
        Me.cmdRefreshPage.Size = New System.Drawing.Size(141, 52)
        Me.cmdRefreshPage.TabIndex = 10
        Me.cmdRefreshPage.Text = "Refresh"
        Me.cmdRefreshPage.UseVisualStyleBackColor = True
        '
        'cmdExitPage
        '
        Me.cmdExitPage.Location = New System.Drawing.Point(67, 723)
        Me.cmdExitPage.Name = "cmdExitPage"
        Me.cmdExitPage.Size = New System.Drawing.Size(141, 52)
        Me.cmdExitPage.TabIndex = 11
        Me.cmdExitPage.Text = "Exit"
        Me.cmdExitPage.UseVisualStyleBackColor = True
        '
        'CarDataGridView
        '
        Me.CarDataGridView.AllowUserToAddRows = False
        Me.CarDataGridView.AllowUserToDeleteRows = False
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5})
        Me.CarDataGridView.Location = New System.Drawing.Point(476, 29)
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.ReadOnly = True
        Me.CarDataGridView.RowTemplate.Height = 28
        Me.CarDataGridView.Size = New System.Drawing.Size(1894, 911)
        Me.CarDataGridView.TabIndex = 12
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column1
        '
        Me.Column1.HeaderText = "Vehicle Make"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Model"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cost Per Day"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fuel Type"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'cmdDeleteCarRow
        '
        Me.cmdDeleteCarRow.Location = New System.Drawing.Point(294, 129)
        Me.cmdDeleteCarRow.Name = "cmdDeleteCarRow"
        Me.cmdDeleteCarRow.Size = New System.Drawing.Size(150, 55)
        Me.cmdDeleteCarRow.TabIndex = 13
        Me.cmdDeleteCarRow.Text = "Delete Row"
        Me.cmdDeleteCarRow.UseVisualStyleBackColor = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(64, 318)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(144, 26)
        Me.TextBoxId.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Make"
        '
        'TextBoxMake
        '
        Me.TextBoxMake.Location = New System.Drawing.Point(294, 318)
        Me.TextBoxMake.Name = "TextBoxMake"
        Me.TextBoxMake.Size = New System.Drawing.Size(140, 26)
        Me.TextBoxMake.TabIndex = 17
        '
        'TextBoxFuelType
        '
        Me.TextBoxFuelType.Location = New System.Drawing.Point(64, 565)
        Me.TextBoxFuelType.Name = "TextBoxFuelType"
        Me.TextBoxFuelType.Size = New System.Drawing.Size(144, 26)
        Me.TextBoxFuelType.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fuel Type"
        '
        'VehicleDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1822, 1050)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxFuelType)
        Me.Controls.Add(Me.TextBoxMake)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.cmdDeleteCarRow)
        Me.Controls.Add(Me.CarDataGridView)
        Me.Controls.Add(Me.cmdExitPage)
        Me.Controls.Add(Me.cmdRefreshPage)
        Me.Controls.Add(Me.cmdAddCarRow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.TextBoxCostPerDay)
        Me.Name = "VehicleDatabaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VehicleDatabse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCostPerDay As TextBox
    Friend WithEvents TextBoxModel As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAddCarRow As Button
    Friend WithEvents cmdRefreshPage As Button
    Friend WithEvents cmdExitPage As Button
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents cmdDeleteCarRow As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMake As TextBox
    Friend WithEvents TextBoxFuelType As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
