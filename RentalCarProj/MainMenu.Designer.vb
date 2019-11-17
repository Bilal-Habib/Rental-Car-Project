<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormMenu
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
        Me.cmdEditCustomerDatabase = New System.Windows.Forms.Button()
        Me.cmdExitApplication = New System.Windows.Forms.Button()
        Me.cmdEditVehicleForm = New System.Windows.Forms.Button()
        Me.cmdEditStaffDatabase = New System.Windows.Forms.Button()
        Me.cmdInvoiceForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdEditCustomerDatabase
        '
        Me.cmdEditCustomerDatabase.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditCustomerDatabase.Location = New System.Drawing.Point(243, 66)
        Me.cmdEditCustomerDatabase.Name = "cmdEditCustomerDatabase"
        Me.cmdEditCustomerDatabase.Size = New System.Drawing.Size(290, 77)
        Me.cmdEditCustomerDatabase.TabIndex = 1
        Me.cmdEditCustomerDatabase.Text = "Edit Customer Database"
        Me.cmdEditCustomerDatabase.UseVisualStyleBackColor = True
        '
        'cmdExitApplication
        '
        Me.cmdExitApplication.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitApplication.Location = New System.Drawing.Point(243, 568)
        Me.cmdExitApplication.Name = "cmdExitApplication"
        Me.cmdExitApplication.Size = New System.Drawing.Size(290, 75)
        Me.cmdExitApplication.TabIndex = 3
        Me.cmdExitApplication.Text = "Exit Application"
        Me.cmdExitApplication.UseVisualStyleBackColor = True
        '
        'cmdEditVehicleForm
        '
        Me.cmdEditVehicleForm.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditVehicleForm.Location = New System.Drawing.Point(243, 194)
        Me.cmdEditVehicleForm.Name = "cmdEditVehicleForm"
        Me.cmdEditVehicleForm.Size = New System.Drawing.Size(290, 75)
        Me.cmdEditVehicleForm.TabIndex = 4
        Me.cmdEditVehicleForm.Text = "Edit Vehicle Database"
        Me.cmdEditVehicleForm.UseVisualStyleBackColor = True
        '
        'cmdEditStaffDatabase
        '
        Me.cmdEditStaffDatabase.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditStaffDatabase.Location = New System.Drawing.Point(243, 319)
        Me.cmdEditStaffDatabase.Name = "cmdEditStaffDatabase"
        Me.cmdEditStaffDatabase.Size = New System.Drawing.Size(290, 75)
        Me.cmdEditStaffDatabase.TabIndex = 5
        Me.cmdEditStaffDatabase.Text = "Edit Staff Database"
        Me.cmdEditStaffDatabase.UseVisualStyleBackColor = True
        '
        'cmdInvoiceForm
        '
        Me.cmdInvoiceForm.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvoiceForm.Location = New System.Drawing.Point(243, 443)
        Me.cmdInvoiceForm.Name = "cmdInvoiceForm"
        Me.cmdInvoiceForm.Size = New System.Drawing.Size(290, 75)
        Me.cmdInvoiceForm.TabIndex = 6
        Me.cmdInvoiceForm.Text = "Generate Invoice"
        Me.cmdInvoiceForm.UseVisualStyleBackColor = True
        '
        'MainFormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 708)
        Me.Controls.Add(Me.cmdInvoiceForm)
        Me.Controls.Add(Me.cmdEditStaffDatabase)
        Me.Controls.Add(Me.cmdEditVehicleForm)
        Me.Controls.Add(Me.cmdExitApplication)
        Me.Controls.Add(Me.cmdEditCustomerDatabase)
        Me.Name = "MainFormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdEditCustomerDatabase As Button
    Friend WithEvents cmdExitApplication As Button
    Friend WithEvents cmdEditVehicleForm As Button
    Friend WithEvents cmdEditStaffDatabase As Button
    Friend WithEvents cmdInvoiceForm As Button
End Class
