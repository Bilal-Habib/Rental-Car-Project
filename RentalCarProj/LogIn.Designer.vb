<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogOnForm
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.cmdLogIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdExitApp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DimGray
        Me.username.Location = New System.Drawing.Point(314, 362)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(256, 30)
        Me.username.TabIndex = 1
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.DimGray
        Me.password.Location = New System.Drawing.Point(314, 448)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(262, 30)
        Me.password.TabIndex = 2
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogIn.Location = New System.Drawing.Point(376, 502)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(134, 48)
        Me.cmdLogIn.TabIndex = 3
        Me.cmdLogIn.Text = "Log-In"
        Me.cmdLogIn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentalCarProj.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(282, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 269)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Password"
        '
        'cmdExitApp
        '
        Me.cmdExitApp.Location = New System.Drawing.Point(44, 589)
        Me.cmdExitApp.Name = "cmdExitApp"
        Me.cmdExitApp.Size = New System.Drawing.Size(134, 48)
        Me.cmdExitApp.TabIndex = 8
        Me.cmdExitApp.Text = "Exit"
        Me.cmdExitApp.UseVisualStyleBackColor = True
        '
        'LogOnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 705)
        Me.Controls.Add(Me.cmdExitApp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "LogOnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents cmdLogIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdExitApp As Button
End Class
