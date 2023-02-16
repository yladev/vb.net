Public Class frmSNP

    Private Sub btnAN_Click(sender As Object, e As EventArgs) Handles btnAN.Click
        Dim A As String
        lstName.Items.Clear()
        Do
            A = InputBox("Please Enter student Name", "Input Name")
            If A.Trim <> "" Then
                lstName.Items.Add(A)
            End If
        Loop While (A.Trim <> "")
    End Sub

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Me.Dispose()
    End Sub
End Class
