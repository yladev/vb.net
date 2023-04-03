<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDP
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
        Me.lblDivisor = New System.Windows.Forms.Label()
        Me.txtDivisorValue = New System.Windows.Forms.TextBox()
        Me.txtDividendValue = New System.Windows.Forms.TextBox()
        Me.lblDividend = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDivisor
        '
        Me.lblDivisor.AutoSize = True
        Me.lblDivisor.Location = New System.Drawing.Point(30, 26)
        Me.lblDivisor.Name = "lblDivisor"
        Me.lblDivisor.Size = New System.Drawing.Size(129, 17)
        Me.lblDivisor.TabIndex = 0
        Me.lblDivisor.Text = "Enter Divisor Value"
        '
        'txtDivisorValue
        '
        Me.txtDivisorValue.Location = New System.Drawing.Point(340, 26)
        Me.txtDivisorValue.Name = "txtDivisorValue"
        Me.txtDivisorValue.Size = New System.Drawing.Size(133, 22)
        Me.txtDivisorValue.TabIndex = 1
        '
        'txtDividendValue
        '
        Me.txtDividendValue.Location = New System.Drawing.Point(340, 90)
        Me.txtDividendValue.Name = "txtDividendValue"
        Me.txtDividendValue.Size = New System.Drawing.Size(133, 22)
        Me.txtDividendValue.TabIndex = 2
        '
        'lblDividend
        '
        Me.lblDividend.AutoSize = True
        Me.lblDividend.Location = New System.Drawing.Point(30, 95)
        Me.lblDividend.Name = "lblDividend"
        Me.lblDividend.Size = New System.Drawing.Size(141, 17)
        Me.lblDividend.TabIndex = 3
        Me.lblDividend.Text = "Enter Dividend Value"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(30, 203)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(443, 112)
        Me.lblResult.TabIndex = 4
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(57, 395)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(114, 59)
        Me.btnCal.TabIndex = 5
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnCls
        '
        Me.btnCls.Location = New System.Drawing.Point(340, 395)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(114, 59)
        Me.btnCls.TabIndex = 6
        Me.btnCls.Text = "Close"
        Me.btnCls.UseVisualStyleBackColor = True
        '
        'frmDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 537)
        Me.Controls.Add(Me.btnCls)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblDividend)
        Me.Controls.Add(Me.txtDividendValue)
        Me.Controls.Add(Me.txtDivisorValue)
        Me.Controls.Add(Me.lblDivisor)
        Me.Name = "frmDP"
        Me.Text = "Division Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDivisor As System.Windows.Forms.Label
    Friend WithEvents txtDivisorValue As System.Windows.Forms.TextBox
    Friend WithEvents txtDividendValue As System.Windows.Forms.TextBox
    Friend WithEvents lblDividend As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents btnCls As System.Windows.Forms.Button

End Class
