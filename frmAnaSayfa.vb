Public Class frmAnaSayfa


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMusteriler.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKargoFirmalar_Click(sender As Object, e As EventArgs) Handles BtnKargoFirmalar.Click
        frmKargoFirmalar.Show()
        Me.Hide()

    End Sub

    Private Sub BtnSatislar_Click(sender As Object, e As EventArgs) Handles BtnSatislar.Click
        frmSatislar.Show()
        Me.Hide()

    End Sub

    Private Sub BtnUrunler_Click(sender As Object, e As EventArgs) Handles BtnUrunler.Click
        frmUrunler.Show()
        Me.Hide()

    End Sub

    Private Sub frmAnaSayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class