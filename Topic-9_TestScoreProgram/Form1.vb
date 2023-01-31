Public Class frmTestScoreProgram
    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Num3 As Integer
    Dim Result As Double
    Private Sub btnAT_Click(sender As Object, e As EventArgs) Handles btnAT.Click
        Num1 = txtInput1.Text
        Num2 = txtInput2.Text
        Num3 = txtInput3.Text
        Result = ((Num1) + (Num2) + (Num3)) / 3
        lblNum.Text = Result
    End Sub

    Private Sub btnRT_Click(sender As Object, e As EventArgs) Handles btnRT.Click
        txtInput1.Text = ""
        txtInput2.Text = ""
        txtInput3.Text = ""
        lblNum.Text = ""
    End Sub

    Private Sub btnEW_Click(sender As Object, e As EventArgs) Handles btnEW.Click
        Application.Exit()
    End Sub
End Class
