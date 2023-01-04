Imports System.Data.SqlClient

Public Class Kargo
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")
    Dim tablo As New DataTable
    Sub Ekle_Sil_Guncelle(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()

            End If
            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("İşlem Başarılı")
            frmMusteriEkle.Temizle()
            frmMusteriListele.Temizle()
        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir müşteri bulunmakta", "Uyarı")
        End Try
    End Sub

    Sub Ekle_Sil_Guncelle_Satis(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()

            End If
            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("İşlem Başarılı")
            frmSatislar.Temizle()

        Catch ex As Exception

        End Try
    End Sub
    Sub Ekle_Sil_Guncelle_Urun(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()

            End If
            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("İşlem Başarılı")
            frmUrunler.Temizle()

        Catch ex As Exception

        End Try
    End Sub

    Sub ComboyaGetir(combo As ComboBox, sorgu As String)
        combo.Items.Clear()
        If baglanti.State = ConnectionState.Closed Then
            baglanti.Open()

        End If
        Dim komut As New SqlCommand(sorgu, baglanti)
        Dim reader As SqlDataReader = komut.ExecuteReader
        While reader.Read
            combo.Items.Add(reader(0).ToString)
        End While
        baglanti.Close()

    End Sub

    Sub Kayit2(command As SqlCommand, sorgu As String)
        baglanti.Open()
        command.Connection = baglanti
        command.CommandText = sorgu
        command.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("İşlem Başarılı")

    End Sub
    Sub KayitGetir(sorgu As String, dgrid As DataGridView)
        tablo.Clear()
        Dim adtr As New SqlDataAdapter(sorgu, baglanti)
        adtr.Fill(tablo)
        dgrid.DataSource = tablo
    End Sub
End Class
