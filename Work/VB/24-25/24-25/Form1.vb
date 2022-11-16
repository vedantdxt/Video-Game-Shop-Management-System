Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "12345" Then
            MsgBox("Welcome")
            MainForm.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Details Entered!")
        End If
    End Sub
End Class
