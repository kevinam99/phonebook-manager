<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Contact
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
        Me.SearchHeading_Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SearchHeading_Label1
        '
        Me.SearchHeading_Label1.AutoSize = True
        Me.SearchHeading_Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchHeading_Label1.Location = New System.Drawing.Point(178, 9)
        Me.SearchHeading_Label1.Name = "SearchHeading_Label1"
        Me.SearchHeading_Label1.Size = New System.Drawing.Size(211, 36)
        Me.SearchHeading_Label1.TabIndex = 2
        Me.SearchHeading_Label1.Text = "Update a contact"
        Me.SearchHeading_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Update_Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 366)
        Me.Controls.Add(Me.SearchHeading_Label1)
        Me.Name = "Update_Contact"
        Me.Text = "Update_Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchHeading_Label1 As Label
End Class
