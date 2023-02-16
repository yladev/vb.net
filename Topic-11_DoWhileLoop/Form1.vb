Public Class frmWhileLoop

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim objrandom As New Random
        Dim number As Integer = 0
        lstNumber.Items.Clear()

        Do While number < 30
            number = objrandom.Next(50)
            lstNumber.Items.Add(number)
        Loop

    End Sub

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Me.Dispose()
    End Sub
End Class
