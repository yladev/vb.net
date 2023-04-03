Public Class frmDP

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim x, y, answer As Integer

        Try
            x = txtDivisorValue.Text
            y = txtDividendValue.Text
            answer = x / y
            lblResult.Text = x & "/" & y & "=" & answer
        Catch ex As DivideByZeroException
            MessageBox.Show("Division by zero")
            lblResult.Text = "Divident shouldn't zero"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            lblResult.Text = "Invalid Divisor or Dividend"
        Finally
            MessageBox.Show("Error Checking is complete", "Try Catch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Application.Exit()
    End Sub
End Class
