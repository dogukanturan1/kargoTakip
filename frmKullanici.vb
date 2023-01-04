Public Class frmKullanici
    Private Sub LblCikis_Click(sender As Object, e As EventArgs) Handles LblCikis.Click
        Me.Close()
    End Sub
    Dim K As New Kullanici
    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""

            End If
        Next
    End Sub
    Private Sub BtnGiris_Click(sender As Object, e As EventArgs) Handles BtnGiris.Click
        K.KullaniciGirisi(TxtKullaniciAdi.Text, TxtSifre.Text)
    End Sub

    Private Sub frmKullanici_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
