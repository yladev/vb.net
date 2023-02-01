Public Class frmName

    Private Sub btnGre_Click(sender As Object, e As EventArgs) Handles btnGre.Click
        lblLabelOne.Text = "Hello Guys! I'm Andrew. Nice to meet you."
    End Sub

    Private Sub btnWel_Click(sender As Object, e As EventArgs) Handles btnWel.Click
        lblLabelOne.Text = "Welcome to my Greeting Message Program."
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        lblLabelOne.Text = ""
    End Sub

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Application.Exit()
    End Sub

    Private Sub rdoRed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRed.CheckedChanged
        Me.ForeColor = Color.Red
    End Sub

    Private Sub rdoPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPurple.CheckedChanged
        Me.ForeColor = Color.Purple
    End Sub

    Private Sub rdoNavy_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNavy.CheckedChanged
        Me.ForeColor = Color.Navy
    End Sub
End Class
