<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Contact))
        Me.CreateContactHeader_Label1 = New System.Windows.Forms.Label()
        Me.SourceCode_LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CreatName_Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Email_Label1 = New System.Windows.Forms.Label()
        Me.ContactNumber_Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Save_Button1 = New System.Windows.Forms.Button()
        Me.Exit_Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateContactHeader_Label1
        '
        Me.CreateContactHeader_Label1.AutoSize = True
        Me.CreateContactHeader_Label1.BackColor = System.Drawing.Color.Transparent
        Me.CreateContactHeader_Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateContactHeader_Label1.Location = New System.Drawing.Point(158, 9)
        Me.CreateContactHeader_Label1.Name = "CreateContactHeader_Label1"
        Me.CreateContactHeader_Label1.Size = New System.Drawing.Size(256, 36)
        Me.CreateContactHeader_Label1.TabIndex = 0
        Me.CreateContactHeader_Label1.Text = "Create a new contact"
        '
        'SourceCode_LinkLabel1
        '
        Me.SourceCode_LinkLabel1.AutoSize = True
        Me.SourceCode_LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SourceCode_LinkLabel1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceCode_LinkLabel1.Location = New System.Drawing.Point(484, 289)
        Me.SourceCode_LinkLabel1.Name = "SourceCode_LinkLabel1"
        Me.SourceCode_LinkLabel1.Size = New System.Drawing.Size(73, 13)
        Me.SourceCode_LinkLabel1.TabIndex = 1
        Me.SourceCode_LinkLabel1.TabStop = True
        Me.SourceCode_LinkLabel1.Text = "Source code"
        '
        'CreatName_Label1
        '
        Me.CreatName_Label1.AutoSize = True
        Me.CreatName_Label1.BackColor = System.Drawing.Color.Transparent
        Me.CreatName_Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatName_Label1.Location = New System.Drawing.Point(48, 61)
        Me.CreatName_Label1.Name = "CreatName_Label1"
        Me.CreatName_Label1.Size = New System.Drawing.Size(66, 26)
        Me.CreatName_Label1.TabIndex = 2
        Me.CreatName_Label1.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(240, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Email_Label1
        '
        Me.Email_Label1.AutoSize = True
        Me.Email_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Email_Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Label1.Location = New System.Drawing.Point(48, 177)
        Me.Email_Label1.Name = "Email_Label1"
        Me.Email_Label1.Size = New System.Drawing.Size(64, 26)
        Me.Email_Label1.TabIndex = 4
        Me.Email_Label1.Text = "Email"
        '
        'ContactNumber_Label2
        '
        Me.ContactNumber_Label2.AutoSize = True
        Me.ContactNumber_Label2.BackColor = System.Drawing.Color.Transparent
        Me.ContactNumber_Label2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber_Label2.Location = New System.Drawing.Point(48, 120)
        Me.ContactNumber_Label2.Name = "ContactNumber_Label2"
        Me.ContactNumber_Label2.Size = New System.Drawing.Size(159, 26)
        Me.ContactNumber_Label2.TabIndex = 5
        Me.ContactNumber_Label2.Text = "Contact number"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(240, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(283, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(240, 178)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(283, 26)
        Me.TextBox3.TabIndex = 7
        '
        'Save_Button1
        '
        Me.Save_Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Button1.Location = New System.Drawing.Point(53, 242)
        Me.Save_Button1.Name = "Save_Button1"
        Me.Save_Button1.Size = New System.Drawing.Size(193, 33)
        Me.Save_Button1.TabIndex = 8
        Me.Save_Button1.Text = "Save"
        Me.Save_Button1.UseVisualStyleBackColor = True
        '
        'Exit_Button2
        '
        Me.Exit_Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button2.Location = New System.Drawing.Point(330, 242)
        Me.Exit_Button2.Name = "Exit_Button2"
        Me.Exit_Button2.Size = New System.Drawing.Size(193, 33)
        Me.Exit_Button2.TabIndex = 9
        Me.Exit_Button2.Text = "Exit"
        Me.Exit_Button2.UseVisualStyleBackColor = True
        '
        'Create_Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(569, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Exit_Button2)
        Me.Controls.Add(Me.Save_Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ContactNumber_Label2)
        Me.Controls.Add(Me.Email_Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CreatName_Label1)
        Me.Controls.Add(Me.SourceCode_LinkLabel1)
        Me.Controls.Add(Me.CreateContactHeader_Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Create_Contact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phonebook Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateContactHeader_Label1 As Label
    Friend WithEvents SourceCode_LinkLabel1 As LinkLabel
    Friend WithEvents CreatName_Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Email_Label1 As Label
    Friend WithEvents ContactNumber_Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Save_Button1 As Button
    Friend WithEvents Exit_Button2 As Button
End Class
