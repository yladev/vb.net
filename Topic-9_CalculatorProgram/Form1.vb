Public Class frmCP
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Result As String
        Num1 = txtInput1.Text
        Num2 = txtInput2.Text
        Result = (Num1 + Num2)
        lblOD.Text = "Addtion Process Done =" + Result
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Num1 = txtInput1.Text
        Num2 = txtInput2.Text
        lblOD.Text = Num1 - Num2
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Num1 = txtInput1.Text
        Num2 = txtInput2.Text
        lblOD.Text = Num1 / Num2
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        Dim Num1 As Integer
        Dim Num2 As Integer
        Num1 = txtInput1.Text
        Num2 = txtInput2.Text
        lblOD.Text = Num1 * Num2
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtInput1.Text = ""
        txtInput2.Text = ""
        lblOD.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
