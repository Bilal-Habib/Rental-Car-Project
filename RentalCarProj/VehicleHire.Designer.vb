<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehicleHire
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
        Me.NoOfDays = New System.Windows.Forms.TextBox()
        Me.CostPerDay = New System.Windows.Forms.TextBox()
        Me.TotalIncVAT = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmdCalcuate = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Insurance = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGenerateInvoice = New System.Windows.Forms.Button()
        Me.cmdRefreshCustomer = New System.Windows.Forms.Button()
        Me.cmdSearchCustomer = New System.Windows.Forms.Button()
        Me.TextBoxCustomerSearch = New System.Windows.Forms.TextBox()
        Me.cmdVehicleSearch = New System.Windows.Forms.Button()
        Me.TextBoxVehicleSearch = New System.Windows.Forms.TextBox()
        Me.cmdRefreshVehicleDataGrid = New System.Windows.Forms.Button()
        Me.VehicleDataGrid = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGrid = New System.Windows.Forms.DataGridView()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VehicleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoOfDays
        '
        Me.NoOfDays.Location = New System.Drawing.Point(1545, 238)
        Me.NoOfDays.Name = "NoOfDays"
        Me.NoOfDays.Size = New System.Drawing.Size(127, 26)
        Me.NoOfDays.TabIndex = 14
        Me.NoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CostPerDay
        '
        Me.CostPerDay.Location = New System.Drawing.Point(1707, 324)
        Me.CostPerDay.Name = "CostPerDay"
        Me.CostPerDay.ReadOnly = True
        Me.CostPerDay.Size = New System.Drawing.Size(127, 26)
        Me.CostPerDay.TabIndex = 13
        Me.CostPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalIncVAT
        '
        Me.TotalIncVAT.Location = New System.Drawing.Point(1544, 324)
        Me.TotalIncVAT.Name = "TotalIncVAT"
        Me.TotalIncVAT.ReadOnly = True
        Me.TotalIncVAT.Size = New System.Drawing.Size(128, 26)
        Me.TotalIncVAT.TabIndex = 12
        Me.TotalIncVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1711, 238)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(127, 26)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = "25%"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCalcuate
        '
        Me.cmdCalcuate.Location = New System.Drawing.Point(1527, 640)
        Me.cmdCalcuate.Name = "cmdCalcuate"
        Me.cmdCalcuate.Size = New System.Drawing.Size(160, 48)
        Me.cmdCalcuate.TabIndex = 16
        Me.cmdCalcuate.Text = "Calculate"
        Me.cmdCalcuate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(1623, 708)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(160, 48)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Insurance
        '
        Me.Insurance.AutoSize = True
        Me.Insurance.Location = New System.Drawing.Point(1550, 395)
        Me.Insurance.Name = "Insurance"
        Me.Insurance.Size = New System.Drawing.Size(106, 24)
        Me.Insurance.TabIndex = 18
        Me.Insurance.Text = "Insurance"
        Me.Insurance.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1705, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "VAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1543, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. of Days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1705, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cost / Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1539, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total (inc. VAT)"
        '
        'cmdGenerateInvoice
        '
        Me.cmdGenerateInvoice.Location = New System.Drawing.Point(1713, 640)
        Me.cmdGenerateInvoice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdGenerateInvoice.Name = "cmdGenerateInvoice"
        Me.cmdGenerateInvoice.Size = New System.Drawing.Size(159, 48)
        Me.cmdGenerateInvoice.TabIndex = 27
        Me.cmdGenerateInvoice.Text = "Generate Invoice"
        Me.cmdGenerateInvoice.UseVisualStyleBackColor = True
        '
        'cmdRefreshCustomer
        '
        Me.cmdRefreshCustomer.Location = New System.Drawing.Point(1527, 559)
        Me.cmdRefreshCustomer.Name = "cmdRefreshCustomer"
        Me.cmdRefreshCustomer.Size = New System.Drawing.Size(160, 63)
        Me.cmdRefreshCustomer.TabIndex = 29
        Me.cmdRefreshCustomer.Text = "Refresh Customer Database"
        Me.cmdRefreshCustomer.UseVisualStyleBackColor = True
        '
        'cmdSearchCustomer
        '
        Me.cmdSearchCustomer.Location = New System.Drawing.Point(22, 28)
        Me.cmdSearchCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSearchCustomer.Name = "cmdSearchCustomer"
        Me.cmdSearchCustomer.Size = New System.Drawing.Size(204, 35)
        Me.cmdSearchCustomer.TabIndex = 30
        Me.cmdSearchCustomer.Text = "Search For a Customer"
        Me.cmdSearchCustomer.UseVisualStyleBackColor = True
        '
        'TextBoxCustomerSearch
        '
        Me.TextBoxCustomerSearch.Location = New System.Drawing.Point(250, 31)
        Me.TextBoxCustomerSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxCustomerSearch.Name = "TextBoxCustomerSearch"
        Me.TextBoxCustomerSearch.Size = New System.Drawing.Size(252, 26)
        Me.TextBoxCustomerSearch.TabIndex = 31
        '
        'cmdVehicleSearch
        '
        Me.cmdVehicleSearch.Location = New System.Drawing.Point(780, 28)
        Me.cmdVehicleSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdVehicleSearch.Name = "cmdVehicleSearch"
        Me.cmdVehicleSearch.Size = New System.Drawing.Size(168, 35)
        Me.cmdVehicleSearch.TabIndex = 32
        Me.cmdVehicleSearch.Text = "Search For a Vehicle"
        Me.cmdVehicleSearch.UseVisualStyleBackColor = True
        '
        'TextBoxVehicleSearch
        '
        Me.TextBoxVehicleSearch.Location = New System.Drawing.Point(975, 31)
        Me.TextBoxVehicleSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxVehicleSearch.Name = "TextBoxVehicleSearch"
        Me.TextBoxVehicleSearch.Size = New System.Drawing.Size(252, 26)
        Me.TextBoxVehicleSearch.TabIndex = 33
        '
        'cmdRefreshVehicleDataGrid
        '
        Me.cmdRefreshVehicleDataGrid.Location = New System.Drawing.Point(1713, 559)
        Me.cmdRefreshVehicleDataGrid.Name = "cmdRefreshVehicleDataGrid"
        Me.cmdRefreshVehicleDataGrid.Size = New System.Drawing.Size(159, 63)
        Me.cmdRefreshVehicleDataGrid.TabIndex = 36
        Me.cmdRefreshVehicleDataGrid.Text = "Refresh Vehicle Database"
        Me.cmdRefreshVehicleDataGrid.UseVisualStyleBackColor = True
        '
        'VehicleDataGrid
        '
        Me.VehicleDataGrid.AllowUserToAddRows = False
        Me.VehicleDataGrid.AllowUserToDeleteRows = False
        Me.VehicleDataGrid.AllowUserToOrderColumns = True
        Me.VehicleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.VehicleDataGrid.Location = New System.Drawing.Point(791, 103)
        Me.VehicleDataGrid.Name = "VehicleDataGrid"
        Me.VehicleDataGrid.ReadOnly = True
        Me.VehicleDataGrid.RowTemplate.Height = 28
        Me.VehicleDataGrid.Size = New System.Drawing.Size(715, 829)
        Me.VehicleDataGrid.TabIndex = 37
        '
        'Column10
        '
        Me.Column10.HeaderText = "ID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 150
        '
        'Column11
        '
        Me.Column11.HeaderText = "Make"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 200
        '
        'Column12
        '
        Me.Column12.HeaderText = "Model"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 200
        '
        'Column13
        '
        Me.Column13.HeaderText = "Cost Per Day"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 200
        '
        'Column14
        '
        Me.Column14.HeaderText = "Fuel Type"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 200
        '
        'CustomerDataGrid
        '
        Me.CustomerDataGrid.AllowUserToAddRows = False
        Me.CustomerDataGrid.AllowUserToDeleteRows = False
        Me.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25})
        Me.CustomerDataGrid.Location = New System.Drawing.Point(22, 103)
        Me.CustomerDataGrid.Name = "CustomerDataGrid"
        Me.CustomerDataGrid.ReadOnly = True
        Me.CustomerDataGrid.RowTemplate.Height = 28
        Me.CustomerDataGrid.Size = New System.Drawing.Size(752, 829)
        Me.CustomerDataGrid.TabIndex = 38
        '
        'Column20
        '
        Me.Column20.HeaderText = "ID"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 150
        '
        'Column21
        '
        Me.Column21.HeaderText = "Forename"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 200
        '
        'Column22
        '
        Me.Column22.HeaderText = "Surname"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 200
        '
        'Column23
        '
        Me.Column23.HeaderText = "Contact Number"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 200
        '
        'Column24
        '
        Me.Column24.HeaderText = "Address"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Width = 200
        '
        'Column25
        '
        Me.Column25.HeaderText = "Email"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Width = 200
        '
        'VehicleHire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1892, 955)
        Me.Controls.Add(Me.CustomerDataGrid)
        Me.Controls.Add(Me.VehicleDataGrid)
        Me.Controls.Add(Me.cmdRefreshVehicleDataGrid)
        Me.Controls.Add(Me.TextBoxVehicleSearch)
        Me.Controls.Add(Me.cmdVehicleSearch)
        Me.Controls.Add(Me.TextBoxCustomerSearch)
        Me.Controls.Add(Me.cmdSearchCustomer)
        Me.Controls.Add(Me.cmdRefreshCustomer)
        Me.Controls.Add(Me.cmdGenerateInvoice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Insurance)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCalcuate)
        Me.Controls.Add(Me.NoOfDays)
        Me.Controls.Add(Me.CostPerDay)
        Me.Controls.Add(Me.TotalIncVAT)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "VehicleHire"
        Me.Text = "Vehicle Hire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VehicleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoOfDays As TextBox
    Friend WithEvents CostPerDay As TextBox
    Friend WithEvents TotalIncVAT As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cmdCalcuate As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Insurance As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdRefreshCar As Button
    Friend WithEvents cmdGenerateInvoice As Button
    Friend WithEvents cmdRefreshCustomer As Button
    Friend WithEvents cmdSearchCustomer As Button
    Friend WithEvents TextBoxCustomerSearch As TextBox
    Friend WithEvents cmdVehicleSearch As Button
    Friend WithEvents TextBoxVehicleSearch As TextBox
    Public WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents VehicleDataGridView As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents cmdRefreshVehicleDataGrid As Button
    Friend WithEvents VehicleDataGrid As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGrid As DataGridView
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
End Class
