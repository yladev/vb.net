Public Class frmCB

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.BackColor = Color.White
        cboCol.Text = ""
        cboCol.Focus()
    End Sub

    Private Sub cboCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCol.SelectedIndexChanged
        If (cboCol.SelectedIndex = 0) Then
            lstDisplay.BackColor = Color.Black
        End If
        If (cboCol.SelectedIndex = 1) Then
            lstDisplay.BackColor = Color.Red
        End If
        If (cboCol.SelectedIndex = 2) Then
            lstDisplay.BackColor = Color.Green
        End If
        If (cboCol.SelectedIndex = 3) Then
            lstDisplay.BackColor = Color.Gray
        End If
        If (cboCol.SelectedIndex = 4) Then
            lstDisplay.BackColor = Color.Blue
        End If
    End Sub
End Class
