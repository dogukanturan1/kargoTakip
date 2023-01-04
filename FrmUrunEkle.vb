Imports System.Data.SqlClient

Public Class FrmUrunEkle
    Dim K As New Kargo
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")
    Private Sub BtnIptal_Click(sender As Object, e As EventArgs) Handles BtnIptal.Click
        Me.Close()
    End Sub
    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub


    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click


        Dim sorgu As String = ("insert into URUNLER values('" & TxtUrunKodu.Text & "','" & TxtUrunAdi.Text & "','" & CmbMarka.Text & "', '" & CmbKategori.Text & "', @ADET, @ALISFIYAT , @SATISFIYAT,'" & CmbBeden.Text & "' )")
        Dim komut As New SqlCommand()
        komut.Parameters.AddWithValue("@ADET", Double.Parse(TxtAdet.Text))
        komut.Parameters.AddWithValue("@ALISFIYAT", Double.Parse(TxtAlisFiyat.Text))
        komut.Parameters.AddWithValue("@SATISFIYAT", Double.Parse(TxtSatisFiyat.Text))

        K.Kayit2(komut, sorgu)



    End Sub

    Private Sub FrmUrunEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        K.ComboyaGetir(CmbKategori, "select * from KATEGORI")
        K.ComboyaGetir(CmbMarka, "select * from MARKA")
        K.ComboyaGetir(CmbBeden, "select * from BEDEN")
    End Sub

    Private Sub CmbMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMarka.SelectedIndexChanged

    End Sub
End Class