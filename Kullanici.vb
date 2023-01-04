Imports System.Data.SqlClient

Public Class Kullanici
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")

    Private _KULLANICIADI As String
    Private _SIFRE As String

    Public Property KULLANICIADI() As String

        Get
            Return _KULLANICIADI
        End Get
        Set(value As String)
            _KULLANICIADI = value
        End Set
    End Property

    Public Property SIFRE() As String

        Get
            Return _SIFRE
        End Get
        Set(value As String)
            _SIFRE = value
        End Set
    End Property

    Sub KullaniciGirisi(Kadi As String, Password As String)

        KULLANICIADI = Kadi
        SIFRE = Password

        If KULLANICIADI = "" Or SIFRE = "" Then
            MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez!!!", "Uyarı1 ")
        Else
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If
            Dim komut As New SqlCommand("select * from KULLANICI where KULLANICIADI='" & KULLANICIADI & "'", baglanti)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                If reader(2) = SIFRE Then
                    frmKullanici.Hide()

                    frmAnaSayfa.Show()
                    frmKullanici.Temizle()
                Else
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Uyarı2")
                End If
            Else
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Uyarı3")
            End If
            baglanti.Close()
        End If


    End Sub

End Class
