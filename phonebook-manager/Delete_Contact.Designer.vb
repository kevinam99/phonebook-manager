<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delete_Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete_Contact))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SourceCode_LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Exit_Button2 = New System.Windows.Forms.Button()
        Me.Search_Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CreatName_Label1 = New System.Windows.Forms.Label()
        Me.DeleteHeading_Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(189, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Delete contact"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SourceCode_LinkLabel1
        '
        Me.SourceCode_LinkLabel1.AutoSize = True
        Me.SourceCode_LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SourceCode_LinkLabel1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceCode_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.SourceCode_LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.SourceCode_LinkLabel1.Location = New System.Drawing.Point(469, 265)
        Me.SourceCode_LinkLabel1.Name = "SourceCode_LinkLabel1"
        Me.SourceCode_LinkLabel1.Size = New System.Drawing.Size(84, 15)
        Me.SourceCode_LinkLabel1.TabIndex = 21
        Me.SourceCode_LinkLabel1.TabStop = True
        Me.SourceCode_LinkLabel1.Text = "Source code"
        '
        'Exit_Button2
        '
        Me.Exit_Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button2.Location = New System.Drawing.Point(365, 184)
        Me.Exit_Button2.Name = "Exit_Button2"
        Me.Exit_Button2.Size = New System.Drawing.Size(90, 33)
        Me.Exit_Button2.TabIndex = 20
        Me.Exit_Button2.Text = "Exit"
        Me.Exit_Button2.UseVisualStyleBackColor = True
        '
        'Search_Button1
        '
        Me.Search_Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button1.Location = New System.Drawing.Point(257, 108)
        Me.Search_Button1.Name = "Search_Button1"
        Me.Search_Button1.Size = New System.Drawing.Size(129, 25)
        Me.Search_Button1.TabIndex = 19
        Me.Search_Button1.Text = "Search"
        Me.Search_Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(199, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 26)
        Me.TextBox1.TabIndex = 18
        '
        'CreatName_Label1
        '
        Me.CreatName_Label1.AutoSize = True
        Me.CreatName_Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatName_Label1.Location = New System.Drawing.Point(36, 76)
        Me.CreatName_Label1.Name = "CreatName_Label1"
        Me.CreatName_Label1.Size = New System.Drawing.Size(66, 26)
        Me.CreatName_Label1.TabIndex = 17
        Me.CreatName_Label1.Text = "Name"
        '
        'DeleteHeading_Label1
        '
        Me.DeleteHeading_Label1.AutoSize = True
        Me.DeleteHeading_Label1.BackColor = System.Drawing.Color.Transparent
        Me.DeleteHeading_Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteHeading_Label1.Location = New System.Drawing.Point(193, 9)
        Me.DeleteHeading_Label1.Name = "DeleteHeading_Label1"
        Me.DeleteHeading_Label1.Size = New System.Drawing.Size(200, 36)
        Me.DeleteHeading_Label1.TabIndex = 16
        Me.DeleteHeading_Label1.Text = "Delete a contact"
        Me.DeleteHeading_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Delete_Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(565, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SourceCode_LinkLabel1)
        Me.Controls.Add(Me.Exit_Button2)
        Me.Controls.Add(Me.Search_Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CreatName_Label1)
        Me.Controls.Add(Me.DeleteHeading_Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Delete_Contact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phonebook Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SourceCode_LinkLabel1 As LinkLabel
    Friend WithEvents Exit_Button2 As Button
    Friend WithEvents Search_Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CreatName_Label1 As Label
    Friend WithEvents DeleteHeading_Label1 As Label
End Class
