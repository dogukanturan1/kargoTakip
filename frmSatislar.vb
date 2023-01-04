
Imports System.Data.SqlClient


Public Class frmSatislar
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")
    Dim K As New Kargo
    Dim spt As New Sepet
    Sub FiyatYenile()
        Try
            lblkayitsayisi.Text = DataGridView1.Rows.Count - 1
            Dim toplamtutar As Double = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                toplamtutar += DataGridView1.Rows(i).Cells("TOPLAMFIYAT").Value
                lbltoplamsatismiktari.Text = toplamtutar.ToString("0.00")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        frmAnaSayfa.Show()
        Me.Hide()
    End Sub
    Sub Temizle()
        For Each control As Control In Me.PanelMusteri.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub TxtMusteriid_TextChanged(sender As Object, e As EventArgs) Handles TxtMusteriid.TextChanged
        If TxtMusteriid.Text = "" Then
            Temizle()
        End If
        spt.TextlereMusteriGetir(TxtMusteriid, TxtAdiSoyadi, TxtTelefon, TxtMail, TxtAdres)
    End Sub

    Private Sub TxtUrunKodu_TextChanged(sender As Object, e As EventArgs) Handles TxtUrunKodu.TextChanged
        If TxtUrunKodu.Text = "*" Then
            TxtUrunKodu.Text = ""
        End If
        If TxtUrunKodu.Text = "" Then
            For Each control As Control In Me.PanelSatis.Controls
                If TypeOf control Is TextBox Then

                    If control.Name <> TxtAdet.Name Then


                        control.Text = ""
                    End If
                End If
            Next
        End If
        spt.TextlereUrunGetir(TxtUrunKodu, TxtUrunAdi, TxtMarka, TxtKategori, TxtBirimFiyat, TxtBeden, TxtAdet, TxtToplamFiyat)
    End Sub

    Private Sub TxtAdet_TextChanged(sender As Object, e As EventArgs) Handles TxtAdet.TextChanged
        Try
            TxtToplamFiyat.Text = (Double.Parse(TxtAdet.Text) * Double.Parse(TxtBirimFiyat.Text)).ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSatislar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spt.KayitGetir("select * from SATIS ", DataGridView1)


        FiyatYenile()

    End Sub

    Private Sub BtnSatisEkle_Click(sender As Object, e As EventArgs) Handles BtnSatisEkle.Click
        If DataGridView1.Rows.Count > 1 Then
            For i = 0 To DataGridView1.Rows.Count - 2

                Dim sorgu As String = ("insert into SATIS values('" & TxtMusteriid.Text & "','" & TxtAdiSoyadi.Text & "','" & TxtTelefon.Text & "','" & TxtAdres.Text & "',@URUNKODU,'" & TxtKategori.Text & "','" & TxtMarka.Text & "', '" & TxtUrunAdi.Text & "',@ADET,'" & TxtBeden.Text & "', @SATISFIYAT, @TOPLAMFIYAT ,  '" & TxtMail.Text & "' ,'" & DateTime.Now.ToString() & "' )")
                Dim komut As New SqlCommand()
                komut.Parameters.AddWithValue("@ADET", Double.Parse(TxtAdet.Text))
                komut.Parameters.AddWithValue("@TOPLAMFIYAT", Double.Parse(TxtToplamFiyat.Text))
                komut.Parameters.AddWithValue("@SATISFIYAT", Double.Parse(TxtBirimFiyat.Text))
                komut.Parameters.AddWithValue("@URUNKODU", (TxtUrunKodu.Text))


                spt.Kayit2(komut, sorgu)
                Dim sorgu2 As String = "update URUNLER set ADET=ADET-@ADET WHERE URUNKODU=@URUNKODU"
                Dim komut2 As New SqlCommand()
                komut2.Parameters.AddWithValue("@URUNKODU", DataGridView1.Rows(i).Cells("URUNKODU").Value.ToString())
                komut2.Parameters.AddWithValue("@ADET", Double.Parse(DataGridView1.Rows(i).Cells("ADET").Value.ToString()))
                spt.Kayit2(komut2, sorgu2)

            Next
            MessageBox.Show("Satış Eklendi")
            TxtUrunKodu.Text = ""
            TxtAdet.Text = "1"
            spt.KayitGetir("select * from SATIS ", DataGridView1)
            FiyatYenile()
        End If

    End Sub

    Private Sub TxtUrunKodu_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUrunKodu.KeyDown
        If e.KeyCode = Keys.Multiply Then
            TxtAdet.Text = TxtUrunKodu.Text.Replace("*", "")
            TxtUrunKodu.Text = ""
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        K.Ekle_Sil_Guncelle_Satis("delete from SATIS where Id='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'")
        K.KayitGetir("select * from SATIS ", DataGridView1)
        FiyatYenile()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TxtSatisKodu.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TxtMusteriid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TxtAdiSoyadi.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TxtTelefon.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TxtAdres.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TxtUrunKodu.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TxtKategori.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        TxtMarka.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        TxtUrunAdi.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        TxtAdet.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        TxtBeden.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        TxtBirimFiyat.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        TxtToplamFiyat.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        TxtMail.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()

    End Sub

    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs) Handles BtnGuncelle.Click
        K.Ekle_Sil_Guncelle_Satis("update SATIS set MUSTERIID='" & TxtMusteriid.Text & "',ADISOYADI='" & TxtAdiSoyadi.Text & "',URUNKODU='" & TxtUrunKodu.Text & "', KATEGORI='" & TxtKategori.Text & "', MARKA='" & TxtMarka.Text & "',URUNADI='" & TxtUrunAdi.Text & "',ADET='" & TxtAdet.Text & "',BEDEN='" & TxtBeden.Text & "',SATISFIYAT='" & TxtBirimFiyat.Text & "',TOPLAMFIYAT='" & TxtToplamFiyat.Text & "' where Id='" & TxtSatisKodu.Text & "'")
        K.KayitGetir("select * from SATIS ", DataGridView1)
        FiyatYenile()

    End Sub

    Private Sub PanelSatis_Paint(sender As Object, e As PaintEventArgs) Handles PanelSatis.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub
    Dim satirsayisi As Integer = 0
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim font As New Font("Arial", 20)
            Dim firca As New SolidBrush(Color.Black)
            Dim kalem As New Pen(Color.Black)


            e.Graphics.DrawString("Düzenleme Tarihi:" + DateTime.Now.ToLongDateString() + " " +
                              "" + DateTime.Now.ToLongTimeString(), font, firca, 50, 25)
            e.Graphics.DrawLine(kalem, 50, 65, 770, 65)
            e.Graphics.DrawLine(kalem, 50, 1000, 50, 65)

            e.Graphics.DrawLine(kalem, 50, 1000, 770, 1000)
            e.Graphics.DrawLine(kalem, 770, 1000, 770, 65)

            font = New Font("Arial", 20, FontStyle.Bold)
            e.Graphics.DrawString("Satış Listesi", font, firca, 350, 75)
            e.Graphics.DrawLine(kalem, 50, 110, 770, 110)

            font = New Font("Arial", 15, FontStyle.Bold)
            e.Graphics.DrawString("Adı Soyadı", font, firca, 60, 118)
            e.Graphics.DrawString("Ürün Adı", font, firca, 260, 118)

            e.Graphics.DrawString("Beden", font, firca, 495, 118)

            e.Graphics.DrawString("Toplam Fiyat", font, firca, 610, 118)
            e.Graphics.DrawLine(kalem, 50, 150, 770, 150)

            e.Graphics.DrawString("Toplam Satış Sayısı= " + lblkayitsayisi.Text + " ", font, firca, 60, 1065)

            e.Graphics.DrawString("Genel Toplam= " + lbltoplamsatismiktari.Text + " TL", font, firca, 480, 1065)

            Dim y As Integer = 160

            font = New Font("Arial", 15)
            Dim i As Integer = 0

            While i < DataGridView1.Rows.Count - 1

                e.Graphics.DrawString(DataGridView1(2, i).Value.ToString(), font, firca, 60, y)
                e.Graphics.DrawString(DataGridView1(8, i).Value.ToString(), font, firca, 260, y)

                e.Graphics.DrawString(DataGridView1(10, i).Value.ToString(), font, firca, 500, y)

                e.Graphics.DrawString(DataGridView1(12, i).Value.ToString(), font, firca, 670, y)

                y = y + 25
                i = i + 1

            End While
        Catch
        End Try


    End Sub


End Class