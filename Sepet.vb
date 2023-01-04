Imports System.Data.SqlClient

Public Class Sepet
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")
    Dim tablo As New DataTable
    Sub SepeteEkle(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()

            End If
            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()


        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir müşteri bulunmakta", "Uyarı")
        End Try
    End Sub

    Sub TextlereMusteriGetir(MUSTERIID As TextBox, ADISOYADI As TextBox, TELEFON As TextBox, MAIL As TextBox, ADRES As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from MUSTERI where MUSTERIID = '" & MUSTERIID.Text & "'", baglanti)
        Dim reader As SqlDataReader
        reader = komut.ExecuteReader
        While reader.Read()
            ADISOYADI.Text = reader(1)
            TELEFON.Text = reader(3)
            MAIL.Text = reader(4)
            ADRES.Text = reader(5)

        End While
        baglanti.Close()
    End Sub

    Sub TextlereUrunGetir(URUNKODU As TextBox, URUNADI As TextBox, MARKA As TextBox, KATEGORI As TextBox, SATISFIYAT As TextBox, BEDEN As TextBox, ADET As TextBox, TOPLAMFIYAT As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from URUNLER where URUNKODU = '" & URUNKODU.Text & "'", baglanti)
        Dim reader As SqlDataReader
        reader = komut.ExecuteReader
        While reader.Read()
            URUNADI.Text = reader(1)
            MARKA.Text = reader(2)
            KATEGORI.Text = reader(3)
            SATISFIYAT.Text = reader(6)
            BEDEN.Text = reader(7)
            TOPLAMFIYAT.Text = (Double.Parse(ADET.Text) * Double.Parse(SATISFIYAT.Text)).ToString("0.00")

        End While
        baglanti.Close()
    End Sub

    Sub TextlereMusteriGetir2(MUSTERIID As TextBox, ADISOYADI As TextBox, TELEFON As TextBox, MAIL As TextBox, ADRES As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from MUSTERI where MUSTERIID = '" & MUSTERIID.Text & "'", baglanti)
        Dim reader As SqlDataReader
        reader = komut.ExecuteReader
        While reader.Read()
            ADISOYADI.Text = reader(1)
            TELEFON.Text = reader(3)
            MAIL.Text = reader(4)
            ADRES.Text = reader(5)

        End While
        baglanti.Close()
    End Sub
    Sub TextlereSatisGetir(Id As TextBox, ADISOYADI As TextBox, TELEFON As TextBox, ADRES As TextBox, MAIL As TextBox, URUNADI As TextBox, TOPLAMFIYAT As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from SATIS where Id = '" & Id.Text & "'", baglanti)
        Dim reader As SqlDataReader
        reader = komut.ExecuteReader
        While reader.Read()

            ADISOYADI.Text = reader(2)
            TELEFON.Text = reader(3)
            ADRES.Text = reader(4)
            MAIL.Text = reader(13)
            URUNADI.Text = reader(8)

            TOPLAMFIYAT.Text = reader(12)



        End While
        baglanti.Close()
    End Sub
    Sub KayitGetir(sorgu As String, dgrid As DataGridView)
        tablo.Clear()
        Dim adtr As New SqlDataAdapter(sorgu, baglanti)
        adtr.Fill(tablo)
        dgrid.DataSource = tablo
    End Sub
    Sub Kayit2(command As SqlCommand, sorgu As String)
        baglanti.Open()
        command.Connection = baglanti
        command.CommandText = sorgu
        command.ExecuteNonQuery()
        baglanti.Close()


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
End Class
