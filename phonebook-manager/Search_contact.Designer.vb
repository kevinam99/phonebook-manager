<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_contact))
        Me.SearchHeading_Label1 = New System.Windows.Forms.Label()
        Me.Exit_Button2 = New System.Windows.Forms.Button()
        Me.Search_Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CreatName_Label1 = New System.Windows.Forms.Label()
        Me.SourceCode_LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'SearchHeading_Label1
        '
        Me.SearchHeading_Label1.AutoSize = True
        Me.SearchHeading_Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchHeading_Label1.Location = New System.Drawing.Point(183, 9)
        Me.SearchHeading_Label1.Name = "SearchHeading_Label1"
        Me.SearchHeading_Label1.Size = New System.Drawing.Size(203, 36)
        Me.SearchHeading_Label1.TabIndex = 1
        Me.SearchHeading_Label1.Text = "Search a contact"
        Me.SearchHeading_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exit_Button2
        '
        Me.Exit_Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button2.Location = New System.Drawing.Point(387, 216)
        Me.Exit_Button2.Name = "Exit_Button2"
        Me.Exit_Button2.Size = New System.Drawing.Size(119, 33)
        Me.Exit_Button2.TabIndex = 13
        Me.Exit_Button2.Text = "Exit"
        Me.Exit_Button2.UseVisualStyleBackColor = True
        '
        'Search_Button1
        '
        Me.Search_Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button1.Location = New System.Drawing.Point(250, 216)
        Me.Search_Button1.Name = "Search_Button1"
        Me.Search_Button1.Size = New System.Drawing.Size(119, 33)
        Me.Search_Button1.TabIndex = 12
        Me.Search_Button1.Text = "Search"
        Me.Search_Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(250, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 26)
        Me.TextBox1.TabIndex = 11
        '
        'CreatName_Label1
        '
        Me.CreatName_Label1.AutoSize = True
        Me.CreatName_Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatName_Label1.Location = New System.Drawing.Point(87, 106)
        Me.CreatName_Label1.Name = "CreatName_Label1"
        Me.CreatName_Label1.Size = New System.Drawing.Size(66, 26)
        Me.CreatName_Label1.TabIndex = 10
        Me.CreatName_Label1.Text = "Name"
        '
        'SourceCode_LinkLabel1
        '
        Me.SourceCode_LinkLabel1.AutoSize = True
        Me.SourceCode_LinkLabel1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceCode_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.SourceCode_LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.SourceCode_LinkLabel1.Location = New System.Drawing.Point(520, 359)
        Me.SourceCode_LinkLabel1.Name = "SourceCode_LinkLabel1"
        Me.SourceCode_LinkLabel1.Size = New System.Drawing.Size(84, 15)
        Me.SourceCode_LinkLabel1.TabIndex = 14
        Me.SourceCode_LinkLabel1.TabStop = True
        Me.SourceCode_LinkLabel1.Text = "Source code"
        '
        'Search_contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.SourceCode_LinkLabel1)
        Me.Controls.Add(Me.Exit_Button2)
        Me.Controls.Add(Me.Search_Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CreatName_Label1)
        Me.Controls.Add(Me.SearchHeading_Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Search_contact"
        Me.Text = "Phonebook Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchHeading_Label1 As Label
    Friend WithEvents Exit_Button2 As Button
    Friend WithEvents Search_Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CreatName_Label1 As Label
    Friend WithEvents SourceCode_LinkLabel1 As LinkLabel
End Class
