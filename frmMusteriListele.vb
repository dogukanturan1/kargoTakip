
Public Class frmMusteriListele
    'TxtUrunKodu.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
    ' TxtUrun.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    'CmbMarka.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    'CmbKategori.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    'TxtAdet.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    'TxtAlisFiyat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    'TxtSatisFiyat.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
    Dim K As New Kargo
    Private Sub frmMusteriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        K.KayitGetir("select * from MUSTERI ", DataGridView1)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs) Handles BtnGuncelle.Click

        K.Ekle_Sil_Guncelle("update MUSTERI set ADSOYAD='" & TxtAdSoyad.Text & "',TC='" & TxtTc.Text & "',TELEFON='" & TxtTelefon.Text & "', MAIL='" & TxtMail.Text & "', ADRES='" & TxtAdres.Text & "' where MUSTERIID='" & TxtMusteriId.Text & "'")
        K.KayitGetir("select * from MUSTERI ", DataGridView1)
    End Sub


    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        K.Ekle_Sil_Guncelle("delete from MUSTERI where MUSTERIID='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'")
        K.KayitGetir("select * from MUSTERI ", DataGridView1)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TxtMusteriId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TxtAdSoyad.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TxtTc.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TxtTelefon.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TxtMail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TxtAdres.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub TxtMusteriAra_TextChanged(sender As Object, e As EventArgs) Handles TxtMusteriAra.TextChanged
        K.KayitGetir("select * from MUSTERI where MUSTERIID like  '%" & TxtMusteriAra.Text & "%'", DataGridView1)
    End Sub
End Class