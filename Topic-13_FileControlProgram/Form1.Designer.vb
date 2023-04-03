<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCP
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
        Me.lblEYN = New System.Windows.Forms.Label()
        Me.lblEYA = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEYN
        '
        Me.lblEYN.AutoSize = True
        Me.lblEYN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEYN.Location = New System.Drawing.Point(40, 56)
        Me.lblEYN.Name = "lblEYN"
        Me.lblEYN.Size = New System.Drawing.Size(137, 18)
        Me.lblEYN.TabIndex = 0
        Me.lblEYN.Text = "Enter Your Name"
        '
        'lblEYA
        '
        Me.lblEYA.AutoSize = True
        Me.lblEYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEYA.Location = New System.Drawing.Point(40, 113)
        Me.lblEYA.Name = "lblEYA"
        Me.lblEYA.Size = New System.Drawing.Size(121, 18)
        Me.lblEYA.TabIndex = 1
        Me.lblEYA.Text = "Enter Your Age"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(329, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 22)
        Me.txtName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(329, 109)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(178, 22)
        Me.txtAge.TabIndex = 3
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(43, 185)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(464, 212)
        Me.lstDisplay.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnSave.Location = New System.Drawing.Point(43, 445)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 61)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnOpen.Location = New System.Drawing.Point(233, 445)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(98, 61)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ForeColor = System.Drawing.Color.Blue
        Me.btnPrint.Location = New System.Drawing.Point(409, 445)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(98, 61)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmFCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(560, 543)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEYA)
        Me.Controls.Add(Me.lblEYN)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmFCP"
        Me.Text = "File Control Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEYN As System.Windows.Forms.Label
    Friend WithEvents lblEYA As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button

End Class
