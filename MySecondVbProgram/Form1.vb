Public Class Form1

    Private Sub btnhello_Click(sender As Object, e As EventArgs) Handles btnhello.Click
        lblDisplay.Text = "Hello"
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lblDisplay.Text = ""
    End Sub

    Private Sub btnexist_Click(sender As Object, e As EventArgs) Handles btnexist.Click
        Close()
    End Sub
End Class
