<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaximumProgram
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
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.txtNumOne = New System.Windows.Forms.TextBox()
        Me.txtNumTwo = New System.Windows.Forms.TextBox()
        Me.btnMaxValue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(42, 68)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(89, 17)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "Number One"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(42, 185)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(88, 17)
        Me.lblTwo.TabIndex = 1
        Me.lblTwo.Text = "Number Two"
        '
        'txtNumOne
        '
        Me.txtNumOne.Location = New System.Drawing.Point(294, 63)
        Me.txtNumOne.Name = "txtNumOne"
        Me.txtNumOne.Size = New System.Drawing.Size(113, 22)
        Me.txtNumOne.TabIndex = 2
        '
        'txtNumTwo
        '
        Me.txtNumTwo.Location = New System.Drawing.Point(294, 180)
        Me.txtNumTwo.Name = "txtNumTwo"
        Me.txtNumTwo.Size = New System.Drawing.Size(113, 22)
        Me.txtNumTwo.TabIndex = 3
        '
        'btnMaxValue
        '
        Me.btnMaxValue.BackColor = System.Drawing.Color.Pink
        Me.btnMaxValue.ForeColor = System.Drawing.Color.Purple
        Me.btnMaxValue.Location = New System.Drawing.Point(129, 309)
        Me.btnMaxValue.Name = "btnMaxValue"
        Me.btnMaxValue.Size = New System.Drawing.Size(193, 38)
        Me.btnMaxValue.TabIndex = 4
        Me.btnMaxValue.Text = "max Value"
        Me.btnMaxValue.UseVisualStyleBackColor = False
        '
        'frmMaximumProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 413)
        Me.Controls.Add(Me.btnMaxValue)
        Me.Controls.Add(Me.txtNumTwo)
        Me.Controls.Add(Me.txtNumOne)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Name = "frmMaximumProgram"
        Me.Text = "Maximum Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents txtNumOne As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnMaxValue As System.Windows.Forms.Button

End Class
