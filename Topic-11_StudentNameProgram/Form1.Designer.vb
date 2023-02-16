<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSNP
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
        Me.btnAN = New System.Windows.Forms.Button()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 16
        Me.lstName.Location = New System.Drawing.Point(12, 12)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(537, 404)
        Me.lstName.TabIndex = 0
        '
        'btnAN
        '
        Me.btnAN.Location = New System.Drawing.Point(56, 450)
        Me.btnAN.Name = "btnAN"
        Me.btnAN.Size = New System.Drawing.Size(115, 66)
        Me.btnAN.TabIndex = 1
        Me.btnAN.Text = "Add Name"
        Me.btnAN.UseVisualStyleBackColor = True
        '
        'btnCls
        '
        Me.btnCls.Location = New System.Drawing.Point(382, 450)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(115, 66)
        Me.btnCls.TabIndex = 2
        Me.btnCls.Text = "Close"
        Me.btnCls.UseVisualStyleBackColor = True
        '
        'frmSNP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 541)
        Me.Controls.Add(Me.btnCls)
        Me.Controls.Add(Me.btnAN)
        Me.Controls.Add(Me.lstName)
        Me.Name = "frmSNP"
        Me.Text = "Student Name Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnAN As System.Windows.Forms.Button
    Friend WithEvents btnCls As System.Windows.Forms.Button

End Class
