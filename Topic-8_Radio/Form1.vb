Public Class frmRadio

    Private Sub rdoRed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRed.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub rdoGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGreen.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub rdoBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBlue.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub rdoBlack_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBlack.CheckedChanged
        Me.ForeColor = Color.Black
    End Sub

    Private Sub rdoWhite_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWhite.CheckedChanged
        Me.ForeColor = Color.White
    End Sub

    Private Sub rdoFred_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFred.CheckedChanged
        Me.ForeColor = Color.Red
    End Sub
End Class
