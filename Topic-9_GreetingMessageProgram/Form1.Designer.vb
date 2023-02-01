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
        Me.lblLabelOne = New System.Windows.Forms.Label()
        Me.btnGre = New System.Windows.Forms.Button()
        Me.btnWel = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoPurple = New System.Windows.Forms.RadioButton()
        Me.rdoNavy = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblLabelOne
        '
        Me.lblLabelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLabelOne.Location = New System.Drawing.Point(44, 72)
        Me.lblLabelOne.Name = "lblLabelOne"
        Me.lblLabelOne.Size = New System.Drawing.Size(414, 495)
        Me.lblLabelOne.TabIndex = 0
        '
        'btnGre
        '
        Me.btnGre.BackColor = System.Drawing.Color.Yellow
        Me.btnGre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGre.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnGre.Location = New System.Drawing.Point(526, 112)
        Me.btnGre.Name = "btnGre"
        Me.btnGre.Size = New System.Drawing.Size(129, 57)
        Me.btnGre.TabIndex = 1
        Me.btnGre.Text = "Greeting"
        Me.btnGre.UseVisualStyleBackColor = False
        '
        'btnWel
        '
        Me.btnWel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnWel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWel.ForeColor = System.Drawing.Color.Cyan
        Me.btnWel.Location = New System.Drawing.Point(526, 216)
        Me.btnWel.Name = "btnWel"
        Me.btnWel.Size = New System.Drawing.Size(129, 57)
        Me.btnWel.TabIndex = 2
        Me.btnWel.Text = "&Welcome"
        Me.btnWel.UseVisualStyleBackColor = False
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.Gray
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.Orange
        Me.btnClr.Location = New System.Drawing.Point(526, 325)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(129, 57)
        Me.btnClr.TabIndex = 3
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnCls
        '
        Me.btnCls.BackColor = System.Drawing.Color.Pink
        Me.btnCls.ForeColor = System.Drawing.Color.Purple
        Me.btnCls.Location = New System.Drawing.Point(526, 441)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(129, 57)
        Me.btnCls.TabIndex = 4
        Me.btnCls.Text = "C&lose"
        Me.btnCls.UseVisualStyleBackColor = False
        '
        'rdoRed
        '
        Me.rdoRed.ForeColor = System.Drawing.Color.Red
        Me.rdoRed.Location = New System.Drawing.Point(699, 131)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(115, 24)
        Me.rdoRed.TabIndex = 5
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "Red"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoPurple
        '
        Me.rdoPurple.AutoSize = True
        Me.rdoPurple.ForeColor = System.Drawing.Color.Purple
        Me.rdoPurple.Location = New System.Drawing.Point(699, 235)
        Me.rdoPurple.Name = "rdoPurple"
        Me.rdoPurple.Size = New System.Drawing.Size(70, 21)
        Me.rdoPurple.TabIndex = 6
        Me.rdoPurple.TabStop = True
        Me.rdoPurple.Text = "Purple"
        Me.rdoPurple.UseVisualStyleBackColor = True
        '
        'rdoNavy
        '
        Me.rdoNavy.AutoSize = True
        Me.rdoNavy.ForeColor = System.Drawing.Color.Navy
        Me.rdoNavy.Location = New System.Drawing.Point(699, 344)
        Me.rdoNavy.Name = "rdoNavy"
        Me.rdoNavy.Size = New System.Drawing.Size(61, 21)
        Me.rdoNavy.TabIndex = 7
        Me.rdoNavy.TabStop = True
        Me.rdoNavy.Text = "Navy"
        Me.rdoNavy.UseVisualStyleBackColor = True
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 694)
        Me.Controls.Add(Me.rdoNavy)
        Me.Controls.Add(Me.rdoPurple)
        Me.Controls.Add(Me.rdoRed)
        Me.Controls.Add(Me.btnCls)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnWel)
        Me.Controls.Add(Me.btnGre)
        Me.Controls.Add(Me.lblLabelOne)
        Me.Name = "frmName"
        Me.Text = "Greeting Message Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLabelOne As System.Windows.Forms.Label
    Friend WithEvents btnGre As System.Windows.Forms.Button
    Friend WithEvents btnWel As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnCls As System.Windows.Forms.Button
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPurple As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNavy As System.Windows.Forms.RadioButton

End Class
