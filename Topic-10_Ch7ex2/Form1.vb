Public Class frmCh7ex2
    Dim a As Integer
    Dim b As Integer

    Private Sub rdoBC_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBC.CheckedChanged
        lblPrc.Text = 2500
    End Sub

    Private Sub rdoEspresso_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEspresso.CheckedChanged
        lblPrc.Text = 1000
    End Sub

    Private Sub rdoMocha_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMocha.CheckedChanged
        lblPrc.Text = 1500
    End Sub

    Private Sub rdoCap_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCap.CheckedChanged
        lblPrc.Text = 3500
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        a = txtQuan.Text
        b = txtPay.Text

        If (rdoBC.Checked = True) Then
            lblTotalAmount.Text = (lblPrc.Text * a)
        ElseIf (rdoCap.Checked = True) Then
            lblTotalAmount.Text = (lblPrc.Text * a)
        ElseIf (rdoEspresso.Checked = True) Then
            lblTotalAmount.Text = (lblPrc.Text * a)
        ElseIf (rdoMocha.Checked = True) Then
            lblTotalAmount.Text = (lblPrc.Text * a)
        End If

        lblBal.Text = b - lblTotalAmount.Text

        If (b < lblTotalAmount.Text) Then
            MessageBox.Show("You need more money to buy this!", "Error Payment", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        lblPrc.Text = ""
        txtQuan.Text = ""
        lblTotalAmount.Text = ""
        txtPay.Text = ""
        lblBal.Text = ""
    End Sub

    Private Sub btnPrn_Click(sender As Object, e As EventArgs) Handles btnPrn.Click
        MessageBox.Show("Thank you!" & vbCrLf & "____" & vbCrLf & "Total Amount:" & lblTotalAmount.Text & vbCrLf & "Payment:" & txtPay.Text & vbCrLf & "____" & vbCrLf & "Balance:" & lblBal.Text, "Payment Receive", MessageBoxButtons.OK)
    End Sub
End Class
