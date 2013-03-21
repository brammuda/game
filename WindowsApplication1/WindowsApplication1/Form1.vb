Public Class Form1

    Private Sub gerak(ByVal x As Double, ByVal y As Double, ByVal status As Integer)
        If status = 1 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y + y)
        Else
            PictureBox2.Location = New Point(PictureBox2.Location.X + x, PictureBox2.Location.Y + y)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gerak(-50, 0, 1)
        gerak(-50, 0, 2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gerak(50, 0, 1)
        gerak(50, 0, 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gerak(-1, 0, 2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gerak(1, 0, 2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = PictureBox1.Location.X
        TextBox2.Text = PictureBox1.Location.Y
        TextBox4.Text = PictureBox2.Location.X
        TextBox3.Text = PictureBox2.Location.Y
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim maju As Integer = CInt(TextBox5.Text)
        gerak(maju, 0, 2)
    End Sub
End Class
