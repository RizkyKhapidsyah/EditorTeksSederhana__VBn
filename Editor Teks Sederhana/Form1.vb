Imports System.IO

Public Class Form1
    'variabel-variabel level-kelas
    Private strNamafile As String = String.Empty 'nama file dari dokumen
    Dim blnApaBerubah As Boolean = False    'flag ubah file

    Sub HapusDokumen()
        'menghapus isi dari kotak teks
        teksDokumen.Clear()

        'membersihkan nama dokumen
        strNamafile = String.Empty

        'menetapkan blnApaBerubah menjadi False
        blnApaBerubah = False
    End Sub

    'prosedur BukaDokumen membuka file dan
    'memuatnya ke dalam TextBox untuk pengeditan

    Sub BukaDokumen()
        Dim fileMasukan As StreamReader 'variabel objek

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            'membaca nama file yang diseleksi
            strNamafile = ofdOpenFile.FileName

            Try
                'membuka file
                fileMasukan = File.OpenText(strNamafile)

                'membaca isi file ke dalam TextBox
                teksDokumen.Text = fileMasukan.ReadToEnd

                'menutup file
                fileMasukan.Close()

                'memperbarui variabel blnApaBerubah
                blnApaBerubah = False
            Catch
                'pesan error untuk error pembukaan file
                MessageBox.Show("Error ketika membuka file.")
            End Try
        End If
    End Sub

    'prosedur SimpanDokumen menyimpan dokumen

    Sub SimpanDokumen()
        Dim fileKeluaran As StreamWriter 'variabel objek

        Try
            'menciptakan file
            fileKeluaran = File.CreateText(strNamafile)

            'menuliskan TextBox ke file
            fileKeluaran.Write(teksDokumen.Text)

            'menutup file
            fileKeluaran.Close()

            'memperbarui variabel blnApaBerubah
            blnApaBerubah = False
        Catch
            'pesan error ketika menciptakan file
            MessageBox.Show("Error ketika menciptakan file.")
        End Try
    End Sub

    Private Sub teksDokumen_TextChanged(sender As Object, e As EventArgs) Handles teksDokumen.TextChanged
        'mengindikasikan bahwa teks telah berubah
        blnApaBerubah = True
    End Sub

    Private Sub mnuBaru_Click(sender As Object, e As EventArgs) Handles mnuBaru.Click
        'apakah dokumen telah berubah?
        If blnApaBerubah = True Then
            'memastikan sebelum membersihkan dokumen
            If MessageBox.Show("Dokumen belum disimpan. " &
            "Anda yakin?", "Memastikan",
            MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                HapusDokumen()
            End If
        Else
            'dokumen tidak berubah, jadi bersihkan
            HapusDokumen()
        End If
    End Sub

    Private Sub mnuFileBuka_Click(sender As Object, e As EventArgs) Handles mnuFileBuka.Click
        'apakah dokumen telah berubah?
        If blnApaBerubah = True Then
            'memastikan sebelum membersihkan dan mengganti
            If MessageBox.Show("Dokumen belum disimpan. " &
            "Anda yakin?", "Memastikan",
            MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                HapusDokumen()
                BukaDokumen()
            End If
        Else
            'dokumen tidak berubah, jadi ganti
            HapusDokumen()
            BukaDokumen()
        End If
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        'apakah dokumen sudah punya nama file?
        If strNamafile = String.Empty Then
            'Dokumen belum disimpan, jadi
            'gunakan kotak dialog Save As
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strNamafile = sfdSaveFile.FileName
                SimpanDokumen()
            End If
        Else
            'simpan dokumen dengan nama file sekarang
            SimpanDokumen()
        End If
    End Sub

    Private Sub mnuSimpanSbg_Click(sender As Object, e As EventArgs) Handles mnuSimpanSbg.Click
        'menyimpan dokumen dengan nama file baru
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strNamafile = sfdSaveFile.FileName
            SimpanDokumen()
        End If
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        'menutup form
        Me.Close()
    End Sub

    Private Sub mnuHelpTentang_Click(sender As Object, e As EventArgs) Handles mnuHelpTentang.Click
        'menampilkan kotak tentang
        MessageBox.Show("Editor Teks Sederhana Versi 1.0")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'jika dokumen telah dimodifikasi, pastikan
        'sebelum user keluar
        If blnApaBerubah = True Then
            If MessageBox.Show("Dokumen belum disimpan. " &
            "Anda bermaksud membuangnya?",
            "Memastikan",
            MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class
