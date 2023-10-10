Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim counter As Integer
        For counter = 1 To 10
            ListBox1.Items.Add(counter)
        Next
    End Sub
End Class
