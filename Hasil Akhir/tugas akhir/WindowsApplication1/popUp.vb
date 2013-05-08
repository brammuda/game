Public Class popUp
    Dim objSoal = New kelasSoal
    Public soalKe As Integer
    Public jawaban As String
    Dim tipe As Integer
    Public Sub awal()
        tipe = objSoal.soal(soalKe).tipe
        labelSoal.Text = objSoal.soal(soalKe).teks
        If tipe = 1 Then
            pilihanA.Visible = False
            pilihanB.Visible = False
            pilihanC.Visible = False
            pilihanD.Visible = False
            pilihanE.Visible = False
            isian.Visible = False
            tombolIsian.Visible = False
            pilihanBenar.Visible = True
            pilihanSalah.Visible = True
        ElseIf tipe = 2 Then
            pilihanBenar.Visible = False
            pilihanSalah.Visible = False
            isian.Visible = False
            tombolIsian.Visible = False
            pilihanA.Text = objSoal.soal(soalKe).pilihan(1)
            pilihanB.Text = objSoal.soal(soalKe).pilihan(2)
            pilihanC.Text = objSoal.soal(soalKe).pilihan(3)
            pilihanD.Text = objSoal.soal(soalKe).pilihan(4)
            pilihanE.Text = objSoal.soal(soalKe).pilihan(5)
            pilihanA.Visible = True
            pilihanB.Visible = True
            pilihanC.Visible = True
            pilihanD.Visible = True
            pilihanE.Visible = True
        ElseIf tipe = 3 Then
            pilihanA.Visible = False
            pilihanB.Visible = False
            pilihanC.Visible = False
            pilihanD.Visible = False
            pilihanE.Visible = False
            pilihanBenar.Visible = False
            pilihanSalah.Visible = False
            isian.Visible = True
            tombolIsian.Visible = True
        End If
    End Sub

    Private Sub lanjut()
        tampilanUtama.mainkan()
        Me.Hide()
        isian.Text = ""
    End Sub

    Private Sub pilihanA_Click(sender As Object, e As EventArgs) Handles pilihanA.Click
        jawaban = "1"
        lanjut()
    End Sub

    Private Sub pilihanB_Click(sender As Object, e As EventArgs) Handles pilihanB.Click
        jawaban = "2"
        lanjut()
    End Sub

    Private Sub pilihanC_Click(sender As Object, e As EventArgs) Handles pilihanC.Click
        jawaban = "3"
        lanjut()
    End Sub

    Private Sub pilihanD_Click(sender As Object, e As EventArgs) Handles pilihanD.Click
        jawaban = "4"
        lanjut()
    End Sub

    Private Sub pilihanE_Click(sender As Object, e As EventArgs) Handles pilihanE.Click
        jawaban = "5"
        lanjut()
    End Sub

    Private Sub pilihanBenar_Click(sender As Object, e As EventArgs) Handles pilihanBenar.Click
        jawaban = "1"
        lanjut()
    End Sub

    Private Sub pilihanSalah_Click(sender As Object, e As EventArgs) Handles pilihanSalah.Click
        jawaban = "0"
        lanjut()
    End Sub

    Private Sub tombolIsian_Click(sender As Object, e As EventArgs) Handles tombolIsian.Click
        jawaban = isian.Text
        lanjut()
    End Sub

    Private Sub popUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class