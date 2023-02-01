<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCP
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
        Me.lblEFN = New System.Windows.Forms.Label()
        Me.lblESN = New System.Windows.Forms.Label()
        Me.lblDR = New System.Windows.Forms.Label()
        Me.lblOD = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEFN
        '
        Me.lblEFN.AutoSize = True
        Me.lblEFN.Location = New System.Drawing.Point(69, 44)
        Me.lblEFN.Name = "lblEFN"
        Me.lblEFN.Size = New System.Drawing.Size(125, 17)
        Me.lblEFN.TabIndex = 0
        Me.lblEFN.Text = "Enter First number"
        '
        'lblESN
        '
        Me.lblESN.AutoSize = True
        Me.lblESN.Location = New System.Drawing.Point(69, 106)
        Me.lblESN.Name = "lblESN"
        Me.lblESN.Size = New System.Drawing.Size(148, 17)
        Me.lblESN.TabIndex = 1
        Me.lblESN.Text = "Enter Second Number"
        '
        'lblDR
        '
        Me.lblDR.AutoSize = True
        Me.lblDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDR.Location = New System.Drawing.Point(68, 188)
        Me.lblDR.Name = "lblDR"
        Me.lblDR.Size = New System.Drawing.Size(141, 24)
        Me.lblDR.TabIndex = 2
        Me.lblDR.Text = "Display Result"
        '
        'lblOD
        '
        Me.lblOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOD.Location = New System.Drawing.Point(357, 172)
        Me.lblOD.Name = "lblOD"
        Me.lblOD.Size = New System.Drawing.Size(116, 62)
        Me.lblOD.TabIndex = 3
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(357, 39)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(116, 22)
        Me.txtInput1.TabIndex = 4
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(357, 106)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(116, 22)
        Me.txtInput2.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(72, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 53)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Addition"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(221, 304)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(109, 53)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "&Subtraction"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(373, 304)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(100, 53)
        Me.btnDiv.TabIndex = 8
        Me.btnDiv.Text = "&Division"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(72, 394)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(100, 53)
        Me.btnMul.TabIndex = 9
        Me.btnMul.Text = "&Muliply"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(221, 394)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(109, 53)
        Me.btnClr.TabIndex = 10
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(373, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 53)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 514)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblOD)
        Me.Controls.Add(Me.lblDR)
        Me.Controls.Add(Me.lblESN)
        Me.Controls.Add(Me.lblEFN)
        Me.Name = "frmCP"
        Me.Text = "Calculator Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEFN As System.Windows.Forms.Label
    Friend WithEvents lblESN As System.Windows.Forms.Label
    Friend WithEvents lblDR As System.Windows.Forms.Label
    Friend WithEvents lblOD As System.Windows.Forms.Label
    Friend WithEvents txtInput1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMul As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
