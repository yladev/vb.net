Public Class frmSum

    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Sum As Integer

    Private Sub AddSum()
        Sum = Num1 + Num2
    End Sub

    Private Sub frmSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Num1 = Val(InputBox("Enter First number:", "Add Program"))
        Num2 = Val(InputBox("Enter Second number:", "Add Program"))
        AddSum()
        MsgBox("The sum is=" & Sum)
    End Sub
End Class
