Imports System.IO
Imports System.Drawing.Printing

Public Class frmFCP
    Private WithEvents docToPrint As New PrintDocument
    Private WithEvents PrintPreviewDialog1 As New PrintPreviewDialog
    Private WithEvents PrintDocument1 As New PrintDocument


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim data As String
        data = txtName.Text + "|"
        data += txtAge.Text + "|"

        Try
            Dim f1 As FileStream = New FileStream("Sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim sw As StreamWriter = New StreamWriter(f1)

            sw.Write(data)
            sw.Close()

            MessageBox.Show("Successfully Saved")

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return
        End Try

        txtName.Text = ""
        txtAge.Text = ""
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim aldata = New ArrayList()

        Try
            Dim fs As FileStream = New FileStream("Sample.txt", FileMode.OpenOrCreate, FileAccess.Read)
            Dim sr As StreamReader = New StreamReader(fs)
            Dim line As String

            line = sr.ReadLine()
            aldata.Add(line)
            sr.Close()

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Return
        End Try

        txtName.Text = ""
        For Each studata As String In aldata
            lstDisplay.Items.Add(studata)
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim startX As Integer = 62
        Dim startY As Integer = 62

        For x As Integer = 0 To lstDisplay.Items.Count - 1
            e.Graphics.DrawString(lstDisplay.Items(x).ToString, lstDisplay.Font, Brushes.Black, startX, startY)
            startY += lstDisplay.ItemHeight
        Next
    End Sub
End Class