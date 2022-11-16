
Public Class login
    Dim rnd = New Random()

    Private Sub Guna2GradientButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GradientButton1.Click
        If Username_TB.Text = "admin" And Password_TB.Text = "12345" Then
            MsgBox("Welcome")
            Me.Hide()
            mainmenu.Show()
        Else
            MsgBox("Wrong Details Entered!")
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GradientButton2.Click
        Username_TB.Text = ""
        Password_TB.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Guna2GradientPanel1.FillColor = randomColour.Color
        Guna2GradientPanel1.FillColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        'Guna2GradientButton1.FillColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        'Guna2GradientButton2.FillColor2 = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub

    Private Sub Guna2GradientButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GradientButton3.Click
        Me.Close()
    End Sub

    Private Sub login_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Username_TB.Text = ""
        Password_TB.Text = ""
    End Sub
    Private Sub login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Password_TB.Focus()
        Username_TB.Focus()
    End Sub
End Class