<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatorProgram
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
        Me.lblEnterFirstNum = New System.Windows.Forms.Label()
        Me.lblEnterSecondNum = New System.Windows.Forms.Label()
        Me.lblDisplayResult = New System.Windows.Forms.Label()
        Me.txtInputOne = New System.Windows.Forms.TextBox()
        Me.txtInputTwo = New System.Windows.Forms.TextBox()
        Me.lblOutputDisplay = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterFirstNum
        '
        Me.lblEnterFirstNum.AutoSize = True
        Me.lblEnterFirstNum.Location = New System.Drawing.Point(69, 45)
        Me.lblEnterFirstNum.Name = "lblEnterFirstNum"
        Me.lblEnterFirstNum.Size = New System.Drawing.Size(127, 17)
        Me.lblEnterFirstNum.TabIndex = 0
        Me.lblEnterFirstNum.Text = "Enter First Number"
        '
        'lblEnterSecondNum
        '
        Me.lblEnterSecondNum.AutoSize = True
        Me.lblEnterSecondNum.Location = New System.Drawing.Point(69, 120)
        Me.lblEnterSecondNum.Name = "lblEnterSecondNum"
        Me.lblEnterSecondNum.Size = New System.Drawing.Size(148, 17)
        Me.lblEnterSecondNum.TabIndex = 1
        Me.lblEnterSecondNum.Text = "Enter Second Number"
        '
        'lblDisplayResult
        '
        Me.lblDisplayResult.AutoSize = True
        Me.lblDisplayResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayResult.Location = New System.Drawing.Point(69, 199)
        Me.lblDisplayResult.Name = "lblDisplayResult"
        Me.lblDisplayResult.Size = New System.Drawing.Size(116, 18)
        Me.lblDisplayResult.TabIndex = 2
        Me.lblDisplayResult.Text = "Display Result"
        '
        'txtInputOne
        '
        Me.txtInputOne.Location = New System.Drawing.Point(323, 45)
        Me.txtInputOne.Name = "txtInputOne"
        Me.txtInputOne.Size = New System.Drawing.Size(122, 22)
        Me.txtInputOne.TabIndex = 3
        '
        'txtInputTwo
        '
        Me.txtInputTwo.Location = New System.Drawing.Point(323, 120)
        Me.txtInputTwo.Name = "txtInputTwo"
        Me.txtInputTwo.Size = New System.Drawing.Size(122, 22)
        Me.txtInputTwo.TabIndex = 4
        '
        'lblOutputDisplay
        '
        Me.lblOutputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutputDisplay.Location = New System.Drawing.Point(323, 187)
        Me.lblOutputDisplay.Name = "lblOutputDisplay"
        Me.lblOutputDisplay.Size = New System.Drawing.Size(122, 51)
        Me.lblOutputDisplay.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(72, 297)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 60)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(207, 297)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(101, 60)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "Sub"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(344, 297)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(101, 60)
        Me.btnDiv.TabIndex = 8
        Me.btnDiv.Text = "Div"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(72, 393)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(101, 60)
        Me.btnMul.TabIndex = 9
        Me.btnMul.Text = "Mul"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(207, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 60)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(344, 393)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 60)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCalculatorProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 516)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblOutputDisplay)
        Me.Controls.Add(Me.txtInputTwo)
        Me.Controls.Add(Me.txtInputOne)
        Me.Controls.Add(Me.lblDisplayResult)
        Me.Controls.Add(Me.lblEnterSecondNum)
        Me.Controls.Add(Me.lblEnterFirstNum)
        Me.Name = "frmCalculatorProgram"
        Me.Text = "Calculator Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterFirstNum As System.Windows.Forms.Label
    Friend WithEvents lblEnterSecondNum As System.Windows.Forms.Label
    Friend WithEvents lblDisplayResult As System.Windows.Forms.Label
    Friend WithEvents txtInputOne As System.Windows.Forms.TextBox
    Friend WithEvents txtInputTwo As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputDisplay As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMul As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
