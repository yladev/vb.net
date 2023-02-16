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
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 16
        Me.lstName.Items.AddRange(New Object() {"Yan Linn Aung"})
        Me.lstName.Location = New System.Drawing.Point(12, 12)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(268, 276)
        Me.lstName.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(21, 335)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(94, 59)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(186, 335)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(94, 59)
        Me.btnClr.TabIndex = 2
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 448)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button

End Class
