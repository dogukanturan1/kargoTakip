Public Class frmMusteriEkle
    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) 
        frmAnaSayfa.Show()
        Me.Hide()
    End Sub

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
    Dim K As New Kargo
    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click
        K.Ekle_Sil_Guncelle("insert into MUSTERI values('" & TxtMusteriId.Text & "','" & TxtAdSoyad.Text & "','" & TxtTc.Text & "','" & TxtTelefon.Text & "','" & TxtMail.Text & "','" & TxtAdres.Text & "')")
    End Sub
End Class