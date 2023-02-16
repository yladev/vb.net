Public Class Form1

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Me.Close()
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        lblName.ForeColor = Color.White
        cboColor.Text = ""
        cboColor.Focus()
    End Sub

    Private Sub cboColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColor.SelectedIndexChanged
        If (cboColor.SelectedIndex = 0) Then
            lblName.ForeColor = Color.Goldenrod
        End If
        If (cboColor.SelectedIndex = 1) Then
            lblName.ForeColor = Color.Red
        End If
        If (cboColor.SelectedIndex = 2) Then
            lblName.ForeColor = Color.Purple
        End If
        If (cboColor.SelectedIndex = 3) Then
            lblName.ForeColor = Color.Gray
        End If
        If (cboColor.SelectedIndex = 4) Then
            lblName.ForeColor = Color.Blue
        End If
    End Sub
End Class
