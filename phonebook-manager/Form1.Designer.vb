﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phonebook
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Phonebook))
        Me.Welcome = New System.Windows.Forms.Label()
        Me.Subtitle = New System.Windows.Forms.Label()
        Me.GitHub = New System.Windows.Forms.LinkLabel()
        Me.AvailableGitHub = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.BackColor = System.Drawing.Color.Transparent
        Me.Welcome.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Welcome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Welcome.Location = New System.Drawing.Point(75, 235)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(699, 44)
        Me.Welcome.TabIndex = 0
        Me.Welcome.Text = "Welcome to the Phonebook Manager"
        '
        'Subtitle
        '
        Me.Subtitle.AutoSize = True
        Me.Subtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Subtitle.Location = New System.Drawing.Point(431, 311)
        Me.Subtitle.Name = "Subtitle"
        Me.Subtitle.Size = New System.Drawing.Size(343, 25)
        Me.Subtitle.TabIndex = 1
        Me.Subtitle.Text = "- A FOSS project by Kevin Mathew"
        Me.Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GitHub
        '
        Me.GitHub.ActiveLinkColor = System.Drawing.Color.Black
        Me.GitHub.AutoSize = True
        Me.GitHub.CausesValidation = False
        Me.GitHub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GitHub.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GitHub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GitHub.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GitHub.Location = New System.Drawing.Point(690, 354)
        Me.GitHub.Name = "GitHub"
        Me.GitHub.Size = New System.Drawing.Size(84, 28)
        Me.GitHub.TabIndex = 2
        Me.GitHub.TabStop = True
        Me.GitHub.Text = "GitHub"
        '
        'AvailableGitHub
        '
        Me.AvailableGitHub.AutoSize = True
        Me.AvailableGitHub.BackColor = System.Drawing.SystemColors.Control
        Me.AvailableGitHub.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableGitHub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AvailableGitHub.Location = New System.Drawing.Point(562, 354)
        Me.AvailableGitHub.Name = "AvailableGitHub"
        Me.AvailableGitHub.Size = New System.Drawing.Size(131, 28)
        Me.AvailableGitHub.TabIndex = 3
        Me.AvailableGitHub.Text = "Available on"
        Me.AvailableGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(179, 409)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(377, 10)
        Me.ProgressBar1.Step = 7
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Phonebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(844, 520)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.AvailableGitHub)
        Me.Controls.Add(Me.GitHub)
        Me.Controls.Add(Me.Subtitle)
        Me.Controls.Add(Me.Welcome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Phonebook"
        Me.Text = "Phonebook Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Welcome As Label
    Friend WithEvents Subtitle As Label
    Friend WithEvents GitHub As LinkLabel
    Friend WithEvents AvailableGitHub As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
