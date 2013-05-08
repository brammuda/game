Public Class kelasSoal
    Structure data
        Dim tipe As Integer '1=yes/no 2=pilgan 3=isian
        Dim teks As String 'teks soal
        Dim pilihan() As String 'pilihan untuk tipe soal 2
        Dim jawaban As String 'jawaban pertanyaan
    End Structure
    Public soal(15) As data
    Sub New()
        For i = 1 To 15
            ReDim soal(i).pilihan(5)
        Next
        soal(1).tipe = 1 ' ini untuk soal nomor 1, tipe yes/no
        soal(1).teks = "Jakarta adalah ibukota negara Indonesia"
        soal(1).jawaban = 1 'benar
        soal(2).tipe = 1 ' ini untuk soal nomor 2, tipe yes/no
        soal(2).teks = "2 x 4 + 2 adalah 12"
        soal(2).jawaban = 0 'salah
        soal(3).tipe = 1 ' ini untuk soal nomor 3, tipe yes/no
        soal(3).teks = "badminton adalah suatu olahraga raket yang dimainkan oleh dua orang atau dua pasangan yang saling berlawanan."
        soal(3).jawaban = 1 'benar
        soal(4).tipe = 1 ' ini untuk soal nomor 4, tipe yes/no
        soal(4).teks = "Mark Zuckerberg adalah pembuat media sosial facebook"
        soal(4).jawaban = 1 'benar
        soal(5).tipe = 1 ' ini untuk soal nomor 5, tipe yes/no
        soal(5).teks = "Selat malaka menghubungkan pulau jawa dan pulau sumatra"
        soal(5).jawaban = 0 'salah

        soal(6).tipe = 2
        soal(6).teks = "Cabang ilmu yang membahas tentang makhluk hidup adalah ?"
        soal(6).pilihan(1) = "Statistika"
        soal(6).pilihan(2) = "Biologi"
        soal(6).pilihan(3) = "Morfologi"
        soal(6).pilihan(4) = "Bioteknologi"
        soal(6).pilihan(5) = "Biogeografi"
        soal(6).jawaban = 2
        soal(7).tipe = 2
        soal(7).teks = "Siapakah pencipta lagu Indonesia Raya?"
        soal(7).pilihan(1) = "Kusbini"
        soal(7).pilihan(2) = "Iwan Fals"
        soal(7).pilihan(3) = "Ismail Marzuki"
        soal(7).pilihan(4) = "W.R. Supratman"
        soal(7).pilihan(5) = "Susilo Bambanng Yudhoyono "
        soal(7).jawaban = 4
        soal(8).tipe = 2
        soal(8).teks = "Akar dari 49 adalah ?"
        soal(8).pilihan(1) = "9"
        soal(8).pilihan(2) = "8"
        soal(8).pilihan(3) = "7"
        soal(8).pilihan(4) = "6"
        soal(8).pilihan(5) = "5"
        soal(8).jawaban = 3
        soal(9).tipe = 2
        soal(9).teks = "Tanggal dan Bulan apakah hari lahirnya ibu RA. Kartini ?"
        soal(9).pilihan(1) = "21 Mei"
        soal(9).pilihan(2) = "25 Mei"
        soal(9).pilihan(3) = "21 Maret"
        soal(9).pilihan(4) = "25 April"
        soal(9).pilihan(5) = "21 April"
        soal(9).jawaban = 5
        soal(10).tipe = 2
        soal(10).teks = "Yang merupakan peralatan masukan (input device) adalah?"
        soal(10).pilihan(1) = "Mouse"
        soal(10).pilihan(2) = "Printer"
        soal(10).pilihan(3) = "Monitor"
        soal(10).pilihan(4) = "Speaker"
        soal(10).pilihan(5) = "Harddisk"
        soal(10).jawaban = 1

        soal(11).tipe = 3 ' ini untuk soal nomor 1,tipe isian
        soal(11).teks = "8 x 5 / 4 - 10 = ?"
        soal(11).jawaban = 0
        soal(12).tipe = 3 ' ini untuk soal nomor 2,tipe isian
        soal(12).teks = "Siapakah presiden RI yang ketiga ?"
        soal(12).jawaban = "BJ Habibie"
        soal(13).tipe = 3 ' ini untuk soal nomor 3,tipe isian
        soal(13).teks = "Samudra yang terluas di dunia adalah"
        soal(13).jawaban = "samudra pasifik"
        soal(14).tipe = 3 ' ini untuk soal nomor 4,tipe isian
        soal(14).teks = "Tari Kecak adalah tari tradisional yang berasala dari "
        soal(14).jawaban = "bali"
        soal(15).tipe = 3 ' ini untuk soal nomor 5,tipe isian
        soal(15).teks = "Bendera merah putih dijahit oleh "
        soal(15).jawaban = "Fatmawati"
    End Sub
End Class
