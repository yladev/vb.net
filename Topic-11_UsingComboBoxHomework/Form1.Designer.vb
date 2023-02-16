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
        Me.lblCC = New System.Windows.Forms.Label()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(41, 29)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(93, 17)
        Me.lblCC.TabIndex = 0
        Me.lblCC.Text = "Choose Color"
        '
        'cboColor
        '
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Items.AddRange(New Object() {"Goldenrod", "Red", "Purple", "Gray", "Blue"})
        Me.cboColor.Location = New System.Drawing.Point(386, 29)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(132, 24)
        Me.cboColor.TabIndex = 1
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.Pink
        Me.btnClr.ForeColor = System.Drawing.Color.Purple
        Me.btnClr.Location = New System.Drawing.Point(44, 586)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(110, 70)
        Me.btnClr.TabIndex = 3
        Me.btnClr.Text = "&Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnCls
        '
        Me.btnCls.BackColor = System.Drawing.Color.Black
        Me.btnCls.ForeColor = System.Drawing.Color.Cyan
        Me.btnCls.Location = New System.Drawing.Point(408, 586)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(110, 70)
        Me.btnCls.TabIndex = 4
        Me.btnCls.Text = "&Close"
        Me.btnCls.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(44, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(474, 462)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Hello Eveyone! I'm Yan Linn Aung."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 688)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCls)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.lblCC)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnCls As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
