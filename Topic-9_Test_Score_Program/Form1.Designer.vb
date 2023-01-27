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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTest1Score = New System.Windows.Forms.Label()
        Me.lblTest2Score = New System.Windows.Forms.Label()
        Me.lblTest3Score = New System.Windows.Forms.Label()
        Me.lblAverageTestScore = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtInputOne = New System.Windows.Forms.TextBox()
        Me.txtInputTwo = New System.Windows.Forms.TextBox()
        Me.txtInputThree = New System.Windows.Forms.TextBox()
        Me.btnAverageTest = New System.Windows.Forms.Button()
        Me.btnResetTest = New System.Windows.Forms.Button()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(61, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(443, 42)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Test Score Program"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTest1Score
        '
        Me.lblTest1Score.AutoSize = True
        Me.lblTest1Score.Location = New System.Drawing.Point(63, 109)
        Me.lblTest1Score.Name = "lblTest1Score"
        Me.lblTest1Score.Size = New System.Drawing.Size(89, 17)
        Me.lblTest1Score.TabIndex = 1
        Me.lblTest1Score.Text = "Test 1 Score"
        '
        'lblTest2Score
        '
        Me.lblTest2Score.AutoSize = True
        Me.lblTest2Score.Location = New System.Drawing.Point(63, 151)
        Me.lblTest2Score.Name = "lblTest2Score"
        Me.lblTest2Score.Size = New System.Drawing.Size(89, 17)
        Me.lblTest2Score.TabIndex = 2
        Me.lblTest2Score.Text = "Test 2 Score"
        '
        'lblTest3Score
        '
        Me.lblTest3Score.AutoSize = True
        Me.lblTest3Score.Location = New System.Drawing.Point(63, 196)
        Me.lblTest3Score.Name = "lblTest3Score"
        Me.lblTest3Score.Size = New System.Drawing.Size(89, 17)
        Me.lblTest3Score.TabIndex = 3
        Me.lblTest3Score.Text = "Test 3 Score"
        '
        'lblAverageTestScore
        '
        Me.lblAverageTestScore.AutoSize = True
        Me.lblAverageTestScore.Location = New System.Drawing.Point(63, 251)
        Me.lblAverageTestScore.Name = "lblAverageTestScore"
        Me.lblAverageTestScore.Size = New System.Drawing.Size(134, 17)
        Me.lblAverageTestScore.TabIndex = 4
        Me.lblAverageTestScore.Text = "Average Test Score"
        '
        'lblNumber
        '
        Me.lblNumber.Location = New System.Drawing.Point(356, 251)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblNumber.TabIndex = 5
        '
        'txtInputOne
        '
        Me.txtInputOne.Location = New System.Drawing.Point(359, 104)
        Me.txtInputOne.Name = "txtInputOne"
        Me.txtInputOne.Size = New System.Drawing.Size(145, 22)
        Me.txtInputOne.TabIndex = 6
        '
        'txtInputTwo
        '
        Me.txtInputTwo.Location = New System.Drawing.Point(359, 148)
        Me.txtInputTwo.Name = "txtInputTwo"
        Me.txtInputTwo.Size = New System.Drawing.Size(145, 22)
        Me.txtInputTwo.TabIndex = 7
        '
        'txtInputThree
        '
        Me.txtInputThree.Location = New System.Drawing.Point(359, 191)
        Me.txtInputThree.Name = "txtInputThree"
        Me.txtInputThree.Size = New System.Drawing.Size(145, 22)
        Me.txtInputThree.TabIndex = 8
        '
        'btnAverageTest
        '
        Me.btnAverageTest.Location = New System.Drawing.Point(330, 303)
        Me.btnAverageTest.Name = "btnAverageTest"
        Me.btnAverageTest.Size = New System.Drawing.Size(174, 27)
        Me.btnAverageTest.TabIndex = 9
        Me.btnAverageTest.Text = "Average Test"
        Me.btnAverageTest.UseVisualStyleBackColor = True
        '
        'btnResetTest
        '
        Me.btnResetTest.Location = New System.Drawing.Point(330, 345)
        Me.btnResetTest.Name = "btnResetTest"
        Me.btnResetTest.Size = New System.Drawing.Size(174, 26)
        Me.btnResetTest.TabIndex = 10
        Me.btnResetTest.Text = "Reset Test"
        Me.btnResetTest.UseVisualStyleBackColor = True
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Location = New System.Drawing.Point(330, 386)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(174, 27)
        Me.btnExitWindow.TabIndex = 11
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = True
        '
        'frmTestScoreProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 462)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.btnResetTest)
        Me.Controls.Add(Me.btnAverageTest)
        Me.Controls.Add(Me.txtInputThree)
        Me.Controls.Add(Me.txtInputTwo)
        Me.Controls.Add(Me.txtInputOne)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblAverageTestScore)
        Me.Controls.Add(Me.lblTest3Score)
        Me.Controls.Add(Me.lblTest2Score)
        Me.Controls.Add(Me.lblTest1Score)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmTestScoreProgram"
        Me.Text = "Test Score Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblTest1Score As System.Windows.Forms.Label
    Friend WithEvents lblTest2Score As System.Windows.Forms.Label
    Friend WithEvents lblTest3Score As System.Windows.Forms.Label
    Friend WithEvents lblAverageTestScore As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents txtInputOne As System.Windows.Forms.TextBox
    Friend WithEvents txtInputTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtInputThree As System.Windows.Forms.TextBox
    Friend WithEvents btnAverageTest As System.Windows.Forms.Button
    Friend WithEvents btnResetTest As System.Windows.Forms.Button
    Friend WithEvents btnExitWindow As System.Windows.Forms.Button

End Class
