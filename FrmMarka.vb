Public Class FrmMarka
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
        K.Ekle_Sil_Guncelle("insert into MARKA values('" & TxtMarka.Text & "')")
    End Sub
End Class