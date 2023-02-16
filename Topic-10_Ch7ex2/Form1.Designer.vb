<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCh7ex2
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
        Me.grbCT = New System.Windows.Forms.GroupBox()
        Me.rdoCap = New System.Windows.Forms.RadioButton()
        Me.rdoMocha = New System.Windows.Forms.RadioButton()
        Me.rdoEspresso = New System.Windows.Forms.RadioButton()
        Me.rdoBC = New System.Windows.Forms.RadioButton()
        Me.lblOT = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTA = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnPrn = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.lblPrc = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblBal = New System.Windows.Forms.Label()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.grbCT.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCT
        '
        Me.grbCT.Controls.Add(Me.rdoCap)
        Me.grbCT.Controls.Add(Me.rdoMocha)
        Me.grbCT.Controls.Add(Me.rdoEspresso)
        Me.grbCT.Controls.Add(Me.rdoBC)
        Me.grbCT.Location = New System.Drawing.Point(53, 78)
        Me.grbCT.Name = "grbCT"
        Me.grbCT.Size = New System.Drawing.Size(192, 218)
        Me.grbCT.TabIndex = 0
        Me.grbCT.TabStop = False
        Me.grbCT.Text = "Choose Item"
        '
        'rdoCap
        '
        Me.rdoCap.AutoSize = True
        Me.rdoCap.Location = New System.Drawing.Point(9, 166)
        Me.rdoCap.Name = "rdoCap"
        Me.rdoCap.Size = New System.Drawing.Size(147, 21)
        Me.rdoCap.TabIndex = 3
        Me.rdoCap.TabStop = True
        Me.rdoCap.Text = "Cappuccino   3500"
        Me.rdoCap.UseVisualStyleBackColor = True
        '
        'rdoMocha
        '
        Me.rdoMocha.AutoSize = True
        Me.rdoMocha.Location = New System.Drawing.Point(9, 126)
        Me.rdoMocha.Name = "rdoMocha"
        Me.rdoMocha.Size = New System.Drawing.Size(147, 21)
        Me.rdoMocha.TabIndex = 2
        Me.rdoMocha.TabStop = True
        Me.rdoMocha.Text = "Mocha           1500"
        Me.rdoMocha.UseVisualStyleBackColor = True
        '
        'rdoEspresso
        '
        Me.rdoEspresso.AutoSize = True
        Me.rdoEspresso.Location = New System.Drawing.Point(9, 85)
        Me.rdoEspresso.Name = "rdoEspresso"
        Me.rdoEspresso.Size = New System.Drawing.Size(148, 21)
        Me.rdoEspresso.TabIndex = 1
        Me.rdoEspresso.TabStop = True
        Me.rdoEspresso.Text = "Espresso       1000"
        Me.rdoEspresso.UseVisualStyleBackColor = True
        '
        'rdoBC
        '
        Me.rdoBC.AutoSize = True
        Me.rdoBC.Location = New System.Drawing.Point(9, 45)
        Me.rdoBC.Name = "rdoBC"
        Me.rdoBC.Size = New System.Drawing.Size(148, 21)
        Me.rdoBC.TabIndex = 0
        Me.rdoBC.TabStop = True
        Me.rdoBC.Text = "Black Coffee  2500"
        Me.rdoBC.UseVisualStyleBackColor = True
        '
        'lblOT
        '
        Me.lblOT.AutoSize = True
        Me.lblOT.Location = New System.Drawing.Point(59, 28)
        Me.lblOT.Name = "lblOT"
        Me.lblOT.Size = New System.Drawing.Size(75, 17)
        Me.lblOT.TabIndex = 0
        Me.lblOT.Text = "Order Item"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(273, 95)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 17)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(273, 136)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(61, 17)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblTA
        '
        Me.lblTA.AutoSize = True
        Me.lblTA.Location = New System.Drawing.Point(273, 179)
        Me.lblTA.Name = "lblTA"
        Me.lblTA.Size = New System.Drawing.Size(92, 17)
        Me.lblTA.TabIndex = 3
        Me.lblTA.Text = "Total Amount"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(273, 222)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(63, 17)
        Me.lblPayment.TabIndex = 4
        Me.lblPayment.Text = "Payment"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(273, 268)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(59, 17)
        Me.lblBalance.TabIndex = 5
        Me.lblBalance.Text = "Balance"
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.Yellow
        Me.btnCal.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnCal.Location = New System.Drawing.Point(62, 374)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(97, 51)
        Me.btnCal.TabIndex = 6
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'btnPrn
        '
        Me.btnPrn.BackColor = System.Drawing.Color.Black
        Me.btnPrn.ForeColor = System.Drawing.Color.Cyan
        Me.btnPrn.Location = New System.Drawing.Point(466, 369)
        Me.btnPrn.Name = "btnPrn"
        Me.btnPrn.Size = New System.Drawing.Size(97, 56)
        Me.btnPrn.TabIndex = 7
        Me.btnPrn.Text = "Print"
        Me.btnPrn.UseVisualStyleBackColor = False
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.Pink
        Me.btnClr.ForeColor = System.Drawing.Color.Purple
        Me.btnClr.Location = New System.Drawing.Point(268, 372)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(97, 51)
        Me.btnClr.TabIndex = 8
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'lblPrc
        '
        Me.lblPrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrc.Location = New System.Drawing.Point(442, 89)
        Me.lblPrc.Name = "lblPrc"
        Me.lblPrc.Size = New System.Drawing.Size(121, 23)
        Me.lblPrc.TabIndex = 9
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Location = New System.Drawing.Point(442, 178)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(121, 23)
        Me.lblTotalAmount.TabIndex = 10
        '
        'lblBal
        '
        Me.lblBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBal.Location = New System.Drawing.Point(442, 267)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(121, 23)
        Me.lblBal.TabIndex = 11
        '
        'txtQuan
        '
        Me.txtQuan.Location = New System.Drawing.Point(442, 131)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(121, 22)
        Me.txtQuan.TabIndex = 13
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(442, 219)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(121, 22)
        Me.txtPay.TabIndex = 14
        '
        'frmCh7ex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 470)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblPrc)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnPrn)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblTA)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblOT)
        Me.Controls.Add(Me.grbCT)
        Me.Name = "frmCh7ex2"
        Me.Text = "Ch7ex2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbCT.ResumeLayout(False)
        Me.grbCT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbCT As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCap As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMocha As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEspresso As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBC As System.Windows.Forms.RadioButton
    Friend WithEvents lblOT As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblTA As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents btnPrn As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents lblPrc As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents txtQuan As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox

End Class
