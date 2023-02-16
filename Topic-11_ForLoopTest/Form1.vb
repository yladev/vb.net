Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim a As Integer
        For a = 1 To 12
            lstName.Items.Add("2*" & a & "=" & a * 2)
        Next
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        lstName.Items.Clear()
    End Sub
End Class