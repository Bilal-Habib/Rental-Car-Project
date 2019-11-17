<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitMessage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdYes = New System.Windows.Forms.Button()
        Me.cmdNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure you want to exit the program?"
        '
        'cmdYes
        '
        Me.cmdYes.Location = New System.Drawing.Point(124, 87)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(174, 37)
        Me.cmdYes.TabIndex = 1
        Me.cmdYes.Text = "Yes"
        Me.cmdYes.UseVisualStyleBackColor = True
        '
        'cmdNo
        '
        Me.cmdNo.Location = New System.Drawing.Point(360, 87)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(174, 37)
        Me.cmdNo.TabIndex = 2
        Me.cmdNo.Text = "No"
        Me.cmdNo.UseVisualStyleBackColor = True
        '
        'ExitMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 160)
        Me.Controls.Add(Me.cmdNo)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ExitMessage"
        Me.Text = "ExitMessage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdYes As Button
    Friend WithEvents cmdNo As Button
End Class
