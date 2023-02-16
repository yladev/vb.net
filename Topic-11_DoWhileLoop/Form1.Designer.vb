<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhileLoop
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
        Me.btnCls = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCls
        '
        Me.btnCls.Location = New System.Drawing.Point(314, 190)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(108, 46)
        Me.btnCls.TabIndex = 0
        Me.btnCls.Text = "Close"
        Me.btnCls.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(314, 39)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(108, 46)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.ItemHeight = 16
        Me.lstNumber.Location = New System.Drawing.Point(26, 12)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(268, 372)
        Me.lstNumber.TabIndex = 2
        '
        'frmWhileLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 429)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnCls)
        Me.Name = "frmWhileLoop"
        Me.Text = "Random Number Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCls As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lstNumber As System.Windows.Forms.ListBox

End Class
