<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestScoreProgram
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
        Me.lblTSC = New System.Windows.Forms.Label()
        Me.lblT1S = New System.Windows.Forms.Label()
        Me.lblT2S = New System.Windows.Forms.Label()
        Me.lblT3S = New System.Windows.Forms.Label()
        Me.lblATC = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.btnAT = New System.Windows.Forms.Button()
        Me.btnRT = New System.Windows.Forms.Button()
        Me.btnEW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTSC
        '
        Me.lblTSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSC.Location = New System.Drawing.Point(159, 27)
        Me.lblTSC.Name = "lblTSC"
        Me.lblTSC.Size = New System.Drawing.Size(420, 31)
        Me.lblTSC.TabIndex = 0
        Me.lblTSC.Text = "Test Score Program"
        Me.lblTSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblT1S
        '
        Me.lblT1S.AutoSize = True
        Me.lblT1S.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT1S.Location = New System.Drawing.Point(94, 104)
        Me.lblT1S.Name = "lblT1S"
        Me.lblT1S.Size = New System.Drawing.Size(89, 17)
        Me.lblT1S.TabIndex = 1
        Me.lblT1S.Text = "Test 1 Score"
        '
        'lblT2S
        '
        Me.lblT2S.AutoSize = True
        Me.lblT2S.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT2S.Location = New System.Drawing.Point(94, 146)
        Me.lblT2S.Name = "lblT2S"
        Me.lblT2S.Size = New System.Drawing.Size(89, 17)
        Me.lblT2S.TabIndex = 2
        Me.lblT2S.Text = "Test 2 Score"
        '
        'lblT3S
        '
        Me.lblT3S.AutoSize = True
        Me.lblT3S.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT3S.Location = New System.Drawing.Point(94, 197)
        Me.lblT3S.Name = "lblT3S"
        Me.lblT3S.Size = New System.Drawing.Size(89, 17)
        Me.lblT3S.TabIndex = 3
        Me.lblT3S.Text = "Test 3 Score"
        '
        'lblATC
        '
        Me.lblATC.AutoSize = True
        Me.lblATC.Location = New System.Drawing.Point(94, 255)
        Me.lblATC.Name = "lblATC"
        Me.lblATC.Size = New System.Drawing.Size(152, 17)
        Me.lblATC.TabIndex = 4
        Me.lblATC.Text = "Average Test Score"
        '
        'lblNum
        '
        Me.lblNum.Location = New System.Drawing.Point(423, 255)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(155, 17)
        Me.lblNum.TabIndex = 5
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(426, 99)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(151, 22)
        Me.txtInput1.TabIndex = 6
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(426, 141)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(151, 22)
        Me.txtInput2.TabIndex = 7
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(426, 192)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(151, 22)
        Me.txtInput3.TabIndex = 8
        '
        'btnAT
        '
        Me.btnAT.Location = New System.Drawing.Point(359, 324)
        Me.btnAT.Name = "btnAT"
        Me.btnAT.Size = New System.Drawing.Size(219, 37)
        Me.btnAT.TabIndex = 9
        Me.btnAT.Text = "Average Test"
        Me.btnAT.UseVisualStyleBackColor = True
        '
        'btnRT
        '
        Me.btnRT.Location = New System.Drawing.Point(359, 384)
        Me.btnRT.Name = "btnRT"
        Me.btnRT.Size = New System.Drawing.Size(219, 35)
        Me.btnRT.TabIndex = 10
        Me.btnRT.Text = "Reset Test"
        Me.btnRT.UseVisualStyleBackColor = True
        '
        'btnEW
        '
        Me.btnEW.Location = New System.Drawing.Point(359, 442)
        Me.btnEW.Name = "btnEW"
        Me.btnEW.Size = New System.Drawing.Size(219, 36)
        Me.btnEW.TabIndex = 11
        Me.btnEW.Text = "Exit Window"
        Me.btnEW.UseVisualStyleBackColor = True
        '
        'frmTestScoreProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 530)
        Me.Controls.Add(Me.btnEW)
        Me.Controls.Add(Me.btnRT)
        Me.Controls.Add(Me.btnAT)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblATC)
        Me.Controls.Add(Me.lblT3S)
        Me.Controls.Add(Me.lblT2S)
        Me.Controls.Add(Me.lblT1S)
        Me.Controls.Add(Me.lblTSC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTestScoreProgram"
        Me.Text = "Test Score Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTSC As System.Windows.Forms.Label
    Friend WithEvents lblT1S As System.Windows.Forms.Label
    Friend WithEvents lblT2S As System.Windows.Forms.Label
    Friend WithEvents lblT3S As System.Windows.Forms.Label
    Friend WithEvents lblATC As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txtInput1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput3 As System.Windows.Forms.TextBox
    Friend WithEvents btnAT As System.Windows.Forms.Button
    Friend WithEvents btnRT As System.Windows.Forms.Button
    Friend WithEvents btnEW As System.Windows.Forms.Button

End Class
