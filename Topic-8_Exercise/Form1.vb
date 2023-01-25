Public Class frmName

    Private Sub btnButton1_Click(sender As Object, e As EventArgs) Handles btnButton1.Click
        lblName.Text = "Hello Everyone!, My name is Yan Linn Aung. I am a junior web-developer. My Github acc is github.com/yladev."
    End Sub

    Private Sub btnButton2_Click(sender As Object, e As EventArgs) Handles btnButton2.Click
        lblName.Text = ""
    End Sub

    Private Sub btnButton3_Click(sender As Object, e As EventArgs) Handles btnButton3.Click
        Close()
    End Sub

    Private Sub rdoGoldenrod_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGoldenrod.CheckedChanged
        Me.ForeColor = Color.Goldenrod
    End Sub

    Private Sub rdoPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPurple.CheckedChanged
        Me.ForeColor = Color.Purple
    End Sub

    Private Sub rdoRed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRed.CheckedChanged
        Me.ForeColor = Color.Red
    End Sub

    Private Sub rdoBlack_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBlack.CheckedChanged
        Me.BackColor = Color.Black
    End Sub

    Private Sub rdoWhite_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWhite.CheckedChanged
        Me.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = Image.FromFile("D:\HTML, CSS & JAVASCRIPT\yla-dev\images\90de2591-0246-410b-93f2-e45950d74117.jpg")
    End Sub

End Class
