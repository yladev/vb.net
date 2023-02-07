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
            MessageBox.Show("You need more money to buy this!")
        End If
    End Sub
End Class
