<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRadio
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
        Me.lblBackColor = New System.Windows.Forms.Label()
        Me.lblForeColor = New System.Windows.Forms.Label()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.rdoBlack = New System.Windows.Forms.RadioButton()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.rdoFred = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblBackColor
        '
        Me.lblBackColor.AutoSize = True
        Me.lblBackColor.Location = New System.Drawing.Point(118, 75)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(76, 17)
        Me.lblBackColor.TabIndex = 0
        Me.lblBackColor.Text = "Back Color"
        '
        'lblForeColor
        '
        Me.lblForeColor.AutoSize = True
        Me.lblForeColor.Location = New System.Drawing.Point(118, 308)
        Me.lblForeColor.Name = "lblForeColor"
        Me.lblForeColor.Size = New System.Drawing.Size(74, 17)
        Me.lblForeColor.TabIndex = 1
        Me.lblForeColor.Text = "Fore Color"
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(131, 150)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(55, 21)
        Me.rdoRed.TabIndex = 2
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "Red"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(393, 150)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(69, 21)
        Me.rdoGreen.TabIndex = 3
        Me.rdoGreen.TabStop = True
        Me.rdoGreen.Text = "Green"
        Me.rdoGreen.UseVisualStyleBackColor = True
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(703, 150)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(57, 21)
        Me.rdoBlue.TabIndex = 4
        Me.rdoBlue.TabStop = True
        Me.rdoBlue.Text = "Blue"
        Me.rdoBlue.UseVisualStyleBackColor = True
        '
        'rdoBlack
        '
        Me.rdoBlack.AutoSize = True
        Me.rdoBlack.Location = New System.Drawing.Point(131, 394)
        Me.rdoBlack.Name = "rdoBlack"
        Me.rdoBlack.Size = New System.Drawing.Size(63, 21)
        Me.rdoBlack.TabIndex = 5
        Me.rdoBlack.TabStop = True
        Me.rdoBlack.Text = "Black"
        Me.rdoBlack.UseVisualStyleBackColor = True
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.Location = New System.Drawing.Point(393, 394)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(61, 21)
        Me.rdoWhite.TabIndex = 6
        Me.rdoWhite.TabStop = True
        Me.rdoWhite.Text = "white"
        Me.rdoWhite.UseVisualStyleBackColor = True
        '
        'rdoFred
        '
        Me.rdoFred.AutoSize = True
        Me.rdoFred.Location = New System.Drawing.Point(703, 394)
        Me.rdoFred.Name = "rdoFred"
        Me.rdoFred.Size = New System.Drawing.Size(55, 21)
        Me.rdoFred.TabIndex = 7
        Me.rdoFred.TabStop = True
        Me.rdoFred.Text = "Red"
        Me.rdoFred.UseVisualStyleBackColor = True
        '
        'frmRadio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 722)
        Me.Controls.Add(Me.rdoFred)
        Me.Controls.Add(Me.rdoWhite)
        Me.Controls.Add(Me.rdoBlack)
        Me.Controls.Add(Me.rdoBlue)
        Me.Controls.Add(Me.rdoGreen)
        Me.Controls.Add(Me.rdoRed)
        Me.Controls.Add(Me.lblForeColor)
        Me.Controls.Add(Me.lblBackColor)
        Me.Name = "frmRadio"
        Me.Text = "Radio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackColor As System.Windows.Forms.Label
    Friend WithEvents lblForeColor As System.Windows.Forms.Label
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlack As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFred As System.Windows.Forms.RadioButton

End Class
