<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select an option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(116, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create a new contact"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(116, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Search a contact"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(116, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(263, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Update a contact"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(116, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(263, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete a contact"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OptionsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 298)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phonebook Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Process1 As Process
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
