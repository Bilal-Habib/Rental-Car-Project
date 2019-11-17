<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.LabelMake = New System.Windows.Forms.Label()
        Me.LabelTotalAmount = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelContact = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdEmailInvoice = New System.Windows.Forms.Button()
        Me.cmdExitInvoice = New System.Windows.Forms.Button()
        Me.LabelFuelType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdPrintInvoice = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.Location = New System.Drawing.Point(105, 333)
        Me.LabelCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(149, 22)
        Me.LabelCustomerName.TabIndex = 1
        Me.LabelCustomerName.Text = "Customer Name: "
        '
        'LabelMake
        '
        Me.LabelMake.AutoSize = True
        Me.LabelMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMake.Location = New System.Drawing.Point(105, 536)
        Me.LabelMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMake.Name = "LabelMake"
        Me.LabelMake.Size = New System.Drawing.Size(127, 22)
        Me.LabelMake.TabIndex = 3
        Me.LabelMake.Text = "Vehicle Make: "
        '
        'LabelTotalAmount
        '
        Me.LabelTotalAmount.AutoSize = True
        Me.LabelTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmount.Location = New System.Drawing.Point(106, 645)
        Me.LabelTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(213, 22)
        Me.LabelTotalAmount.TabIndex = 4
        Me.LabelTotalAmount.Text = "Total Amount (inc. VAT): "
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(866, 88)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(44, 20)
        Me.LabelDate.TabIndex = 5
        Me.LabelDate.Text = "Date"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(865, 31)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(81, 25)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Invoice"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompanyName.Location = New System.Drawing.Point(105, 31)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(229, 25)
        Me.LabelCompanyName.TabIndex = 7
        Me.LabelCompanyName.Text = "Abdul's Vehicle Rental"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Address 1: 131 Ashton Old Rd"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Address 2: Manchester M12 6BL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phone: 0161 230 8223"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "E-mail: Abdul@Rental.co.uk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Bill To: "
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModel.Location = New System.Drawing.Point(105, 573)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(132, 22)
        Me.LabelModel.TabIndex = 13
        Me.LabelModel.Text = "Vehicle Model: "
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(105, 408)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(86, 22)
        Me.LabelAddress.TabIndex = 14
        Me.LabelAddress.Text = "Address: "
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContact.Location = New System.Drawing.Point(105, 370)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(150, 22)
        Me.LabelContact.TabIndex = 15
        Me.LabelContact.Text = "Contact Number: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Details: "
        '
        'cmdEmailInvoice
        '
        Me.cmdEmailInvoice.Location = New System.Drawing.Point(788, 504)
        Me.cmdEmailInvoice.Name = "cmdEmailInvoice"
        Me.cmdEmailInvoice.Size = New System.Drawing.Size(158, 54)
        Me.cmdEmailInvoice.TabIndex = 17
        Me.cmdEmailInvoice.Text = "Email"
        Me.cmdEmailInvoice.UseVisualStyleBackColor = True
        '
        'cmdExitInvoice
        '
        Me.cmdExitInvoice.Location = New System.Drawing.Point(891, 596)
        Me.cmdExitInvoice.Name = "cmdExitInvoice"
        Me.cmdExitInvoice.Size = New System.Drawing.Size(158, 54)
        Me.cmdExitInvoice.TabIndex = 18
        Me.cmdExitInvoice.Text = "Exit"
        Me.cmdExitInvoice.UseVisualStyleBackColor = True
        '
        'LabelFuelType
        '
        Me.LabelFuelType.AutoSize = True
        Me.LabelFuelType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFuelType.Location = New System.Drawing.Point(106, 611)
        Me.LabelFuelType.Name = "LabelFuelType"
        Me.LabelFuelType.Size = New System.Drawing.Size(101, 22)
        Me.LabelFuelType.TabIndex = 19
        Me.LabelFuelType.Text = "Fuel Type: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 20
        '
        'cmdPrintInvoice
        '
        Me.cmdPrintInvoice.Location = New System.Drawing.Point(979, 504)
        Me.cmdPrintInvoice.Name = "cmdPrintInvoice"
        Me.cmdPrintInvoice.Size = New System.Drawing.Size(158, 54)
        Me.cmdPrintInvoice.TabIndex = 21
        Me.cmdPrintInvoice.Text = "Print"
        Me.cmdPrintInvoice.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 808)
        Me.Controls.Add(Me.cmdPrintInvoice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelFuelType)
        Me.Controls.Add(Me.cmdExitInvoice)
        Me.Controls.Add(Me.cmdEmailInvoice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelContact)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelModel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelTotalAmount)
        Me.Controls.Add(Me.LabelMake)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCustomerName As Label
    Friend WithEvents LabelMake As Label
    Friend WithEvents LabelTotalAmount As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelCompanyName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelModel As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelContact As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdEmailInvoice As Button
    Friend WithEvents cmdExitInvoice As Button
    Friend WithEvents LabelFuelType As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdPrintInvoice As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
