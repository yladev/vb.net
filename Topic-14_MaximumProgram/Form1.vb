Public Class frmMaximumProgram
    Function MaxNo(ByVal one As Integer, ByVal two As Integer)
        Dim Output As Integer
        If (one > two) Then
            Output = one
        Else
            Output = two
        End If
        MaxNo = Output
    End Function

    Private Sub btnMaxValue_Click(sender As Object, e As EventArgs) Handles btnMaxValue.Click
        Dim one As Integer
        Dim two As Integer
        Dim result As Integer
        one = txtNumOne.Text
        two = txtNumTwo.Text
        result = MaxNo(one, two)
        MsgBox("Maxmium value is:" & result)
    End Sub
End Class
