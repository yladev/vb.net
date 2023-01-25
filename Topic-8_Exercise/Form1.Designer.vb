<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.btnButton2 = New System.Windows.Forms.Button()
        Me.btnButton3 = New System.Windows.Forms.Button()
        Me.rdoGoldenrod = New System.Windows.Forms.RadioButton()
        Me.rdoPurple = New System.Windows.Forms.RadioButton()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdoBlack = New System.Windows.Forms.RadioButton()
        Me.lblTextColor = New System.Windows.Forms.Label()
        Me.lblBgColor = New System.Windows.Forms.Label()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(73, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(550, 387)
        Me.lblName.TabIndex = 0
        '
        'btnButton1
        '
        Me.btnButton1.BackColor = System.Drawing.Color.Red
        Me.btnButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton1.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnButton1.Location = New System.Drawing.Point(73, 575)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(112, 60)
        Me.btnButton1.TabIndex = 1
        Me.btnButton1.Text = "Start"
        Me.btnButton1.UseVisualStyleBackColor = False
        '
        'btnButton2
        '
        Me.btnButton2.BackColor = System.Drawing.Color.Red
        Me.btnButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton2.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnButton2.Location = New System.Drawing.Point(281, 575)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(114, 60)
        Me.btnButton2.TabIndex = 2
        Me.btnButton2.Text = "Close"
        Me.btnButton2.UseVisualStyleBackColor = False
        '
        'btnButton3
        '
        Me.btnButton3.BackColor = System.Drawing.Color.Red
        Me.btnButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton3.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnButton3.Location = New System.Drawing.Point(518, 575)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(105, 60)
        Me.btnButton3.TabIndex = 3
        Me.btnButton3.Text = "Exit"
        Me.btnButton3.UseVisualStyleBackColor = False
        '
        'rdoGoldenrod
        '
        Me.rdoGoldenrod.AutoSize = True
        Me.rdoGoldenrod.BackColor = System.Drawing.SystemColors.Control
        Me.rdoGoldenrod.ForeColor = System.Drawing.Color.Goldenrod
        Me.rdoGoldenrod.Location = New System.Drawing.Point(73, 494)
        Me.rdoGoldenrod.Name = "rdoGoldenrod"
        Me.rdoGoldenrod.Size = New System.Drawing.Size(93, 21)
        Me.rdoGoldenrod.TabIndex = 4
        Me.rdoGoldenrod.TabStop = True
        Me.rdoGoldenrod.Text = "goldenrod"
        Me.rdoGoldenrod.UseVisualStyleBackColor = False
        '
        'rdoPurple
        '
        Me.rdoPurple.AutoSize = True
        Me.rdoPurple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPurple.ForeColor = System.Drawing.Color.Purple
        Me.rdoPurple.Location = New System.Drawing.Point(281, 494)
        Me.rdoPurple.Name = "rdoPurple"
        Me.rdoPurple.Size = New System.Drawing.Size(69, 21)
        Me.rdoPurple.TabIndex = 5
        Me.rdoPurple.TabStop = True
        Me.rdoPurple.Text = "purple"
        Me.rdoPurple.UseVisualStyleBackColor = False
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRed.ForeColor = System.Drawing.Color.Red
        Me.rdoRed.Location = New System.Drawing.Point(518, 494)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(50, 21)
        Me.rdoRed.TabIndex = 6
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "red"
        Me.rdoRed.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(666, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(701, 387)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'rdoBlack
        '
        Me.rdoBlack.AutoSize = True
        Me.rdoBlack.ForeColor = System.Drawing.Color.Black
        Me.rdoBlack.Location = New System.Drawing.Point(73, 717)
        Me.rdoBlack.Name = "rdoBlack"
        Me.rdoBlack.Size = New System.Drawing.Size(63, 21)
        Me.rdoBlack.TabIndex = 8
        Me.rdoBlack.TabStop = True
        Me.rdoBlack.Text = "Black"
        Me.rdoBlack.UseVisualStyleBackColor = True
        '
        'lblTextColor
        '
        Me.lblTextColor.AutoSize = True
        Me.lblTextColor.Location = New System.Drawing.Point(70, 448)
        Me.lblTextColor.Name = "lblTextColor"
        Me.lblTextColor.Size = New System.Drawing.Size(68, 17)
        Me.lblTextColor.TabIndex = 9
        Me.lblTextColor.Text = "TextColor"
        '
        'lblBgColor
        '
        Me.lblBgColor.AutoSize = True
        Me.lblBgColor.Location = New System.Drawing.Point(70, 672)
        Me.lblBgColor.Name = "lblBgColor"
        Me.lblBgColor.Size = New System.Drawing.Size(58, 17)
        Me.lblBgColor.TabIndex = 10
        Me.lblBgColor.Text = "BgColor"
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rdoWhite.Location = New System.Drawing.Point(281, 717)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(65, 21)
        Me.rdoWhite.TabIndex = 11
        Me.rdoWhite.TabStop = True
        Me.rdoWhite.Text = "White"
        Me.rdoWhite.UseVisualStyleBackColor = True
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 760)
        Me.Controls.Add(Me.rdoWhite)
        Me.Controls.Add(Me.lblBgColor)
        Me.Controls.Add(Me.lblTextColor)
        Me.Controls.Add(Me.rdoBlack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rdoRed)
        Me.Controls.Add(Me.rdoPurple)
        Me.Controls.Add(Me.rdoGoldenrod)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.lblName)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "frmName"
        Me.Text = "ThisIsMyExerciseProgram"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnButton1 As System.Windows.Forms.Button
    Friend WithEvents btnButton2 As System.Windows.Forms.Button
    Friend WithEvents btnButton3 As System.Windows.Forms.Button
    Friend WithEvents rdoGoldenrod As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPurple As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rdoBlack As System.Windows.Forms.RadioButton
    Friend WithEvents lblTextColor As System.Windows.Forms.Label
    Friend WithEvents lblBgColor As System.Windows.Forms.Label
    Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton

End Class
