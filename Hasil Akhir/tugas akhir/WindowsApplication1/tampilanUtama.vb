Imports System.Math
Public Class tampilanUtama
    Dim gerakLatar, gerakMa, gerakMund As Integer 'indikator waktu untuk pergerakan
    Dim maxSatuGerak As Integer = 52 'maksimal satu gerakan
    Dim arahMa, arahMund As Integer '1=maju -1=mundur
    Dim gerLa, gerMa, gerMund As Integer 'indikator yang gerak
    Dim posisiMa As Integer = 0 'posisi ma
    Dim posisiMund As Integer = 0 'posisi mund
    Public masukanDadu As Integer 'masukan angka dadu
    Public totDaduMa As Integer = 0 'total dadu ma
    Public totDaduMund As Integer = 0 'total dadu mund
    Public giliran As Integer = 2 'ma dulu yang maju
    Dim hasilRandomSoal As Integer
    Dim dataAcak(15) As Integer
    Public banyakAcak As Integer = 0

    Dim objSoal = New kelasSoal

    Private Sub gerak()
        If gerMa = 1 Then 'ma yang gerak
            HScrollBar1.Enabled = False
            tombolMain.Enabled = False
            tombolMain.Text = ""
            gerakMa += 1
            ma.Location = New Point(ma.Location.X + arahMa, ma.Location.Y)
            If gerakMa = Abs(maxSatuGerak * masukanDadu) Then
                timerMa.Stop()
                gerMa = 0
            End If
            posisiMa = totDaduMa * maxSatuGerak
        End If
        If gerMund = 1 Then 'mund yang gerak
            HScrollBar1.Enabled = False
            tombolMain.Enabled = False
            tombolMain.Text = ""
            gerakMund += 1
            mund.Location = New Point(mund.Location.X + arahMund, mund.Location.Y)
            If gerakMund = Abs(maxSatuGerak * masukanDadu) Then
                timerMund.Stop()
                gerMund = 0
            End If
            posisiMund = totDaduMund * maxSatuGerak
        End If
            If gerMa = 0 And gerMund = 0 Then
                HScrollBar1.Enabled = True
                tombolMain.Enabled = True
            End If
        If giliran = 2 Then
            tombolMain.Text = "Ma"
        Else
            tombolMain.Text = "Mund"
        End If
    End Sub

    Private Sub seleksiGerak(ByVal status As Integer, ByVal nilai As Integer)
        If status = 1 And nilai < 0 Then
            timerMa.Start()
            arahMa = -1
            gerakMa = 0
            gerMa = 1
        ElseIf status = 1 And nilai > 0 Then
            timerMa.Start()
            arahMa = 1
            gerakMa = 0
            gerMa = 1
        ElseIf status = 2 And nilai < 0 Then
            timerMund.Start()
            arahMund = -1
            gerakMund = 0
            gerMund = 1
        ElseIf status = 2 And nilai > 0 Then
            timerMund.Start()
            arahMund = 1
            gerakMund = 0
            gerMund = 1
        End If
    End Sub
    Private Sub ma_Tick(sender As Object, e As EventArgs) Handles timerMa.Tick
        gerak()
    End Sub

    Private Sub mund_Tick(sender As Object, e As EventArgs) Handles timerMund.Tick
        gerak()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim posisi As Double = (HScrollBar1.Value / 100) * (latar.Width - Me.Width)
        latar.Location = New Point(-posisi, latar.Location.Y)
        ma.Location = New Point(-posisi + posisiMa + 19, ma.Location.Y)
        mund.Location = New Point(-posisi + posisiMund + 19, mund.Location.Y)
    End Sub

    Private Sub Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tombolMain.Text = "Ma"
    End Sub

    Private Function cekJawaban() As Boolean
        Dim posisi As Integer
        If giliran = 1 Then
            posisi = totDaduMa
        Else
            posisi = totDaduMund
        End If
        If objSoal.soal(hasilRandomSoal).jawaban = popUp.jawaban Then
            Return True
        End If
        Return False
    End Function
    Public Sub mainkan()
        Dim cekMa, cekMund As Integer
        If cekJawaban() Then
            cekMa = totDaduMa + masukanDadu
            cekMund = totDaduMund + masukanDadu
        Else
            If totDaduMa - masukanDadu < 1 Then
                masukanDadu = totDaduMa
            End If
            If totDaduMund - masukanDadu < 1 Then
                masukanDadu = totDaduMund
            End If
        End If
        If giliran = 1 Then
            If cekJawaban() = True Then
                totDaduMa = totDaduMa + masukanDadu
                seleksiGerak(1, masukanDadu)
            ElseIf cekJawaban() = False Then
                totDaduMa = totDaduMa - masukanDadu
                seleksiGerak(1, -masukanDadu)
            End If
        Else
            If cekJawaban() = True Then
                totDaduMund = totDaduMund + masukanDadu
                seleksiGerak(2, masukanDadu)
            ElseIf cekJawaban() = False Then
                totDaduMund = totDaduMund - masukanDadu
                seleksiGerak(2, -masukanDadu)
            End If
        End If
        If totDaduMa >= 50 Then
            MsgBox("Ma menang, atur ulang permainan", MsgBoxStyle.Information, "Ma Mund")
            aturUlang()
        ElseIf totDaduMund >= 50 Then
            MsgBox("Mund menang, atur ulang permainan", MsgBoxStyle.Information, "Ma Mund")
            aturUlang()
        End If
    End Sub

    Private Sub pergiliran()
        If giliran = 1 Then
            giliran = 2
        Else
            giliran = 1
        End If
    End Sub
    Private Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim a As Integer = New Random().Next(Min, Max)
        While a = 0 Or a = False
            a = GetRandom(Min, Max)
        End While
        Return a
    End Function
    Private Function acakSoal() As Integer
        Dim x As Integer
sini:
        x = GetRandom(1, 15)
        If cekRandomSoal(x) = True Then
            Return x
        Else
            GoTo sini
        End If
    End Function
    Private Function cekRandomSoal(ByVal tes As Integer) As Boolean
        For i = 1 To banyakAcak
            If dataAcak(i) = tes Then
                Return False
                Stop
            End If
        Next
        Return True
    End Function

    Private Sub tombolMain_Click(sender As Object, e As EventArgs) Handles tombolMain.Click
        If banyakAcak = 14 Then
            banyakAcak = 0
        End If
        pergiliran()
        masukanDadu = GetRandom(1, 6)
        hasilRandomSoal = acakSoal()
        banyakAcak += 1
        dataAcak(banyakAcak) = hasilRandomSoal
        popUp.angkaDadu.Text = "Hasil Acak Dadu " & masukanDadu
        popUp.soalKe = hasilRandomSoal
        popUp.awal()
        popUp.Show()
    End Sub

    Private Sub AturUlangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturUlangToolStripMenuItem.Click
        aturUlang()
    End Sub
    Private Sub aturUlang()
        posisiMa = 0 'posisi ma
        posisiMund = 0 'posisi mund
        totDaduMa = 0 'total dadu ma
        totDaduMund = 0 'total dadu mund
        giliran = 2 'ma dulu yang maju
        banyakAcak = 0
        ma.Location = New Point(20, 148)
        mund.Location = New Point(20, 245)
    End Sub

    Private Sub CaraMainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaraMainToolStripMenuItem.Click
        cara_main.Show()
        Me.Hide()
    End Sub

    Private Sub PermainanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PermainanToolStripMenuItem1.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        profile.Show()
        Me.Hide()
    End Sub
End Class
