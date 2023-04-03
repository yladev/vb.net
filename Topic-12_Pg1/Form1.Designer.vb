<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPeym = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPeym
        '
        Me.lblPeym.AutoSize = True
        Me.lblPeym.Location = New System.Drawing.Point(22, 26)
        Me.lblPeym.Name = "lblPeym"
        Me.lblPeym.Size = New System.Drawing.Size(156, 17)
        Me.lblPeym.TabIndex = 0
        Me.lblPeym.Text = "Please Enter your mark"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(251, 26)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(137, 22)
        Me.txtMark.TabIndex = 1
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.Yellow
        Me.btnCal.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnCal.Location = New System.Drawing.Point(286, 80)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(102, 46)
        Me.btnCal.TabIndex = 2
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 157)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.lblPeym)
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeym As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents btnCal As System.Windows.Forms.Button

End Class
