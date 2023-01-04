Imports System.Data.SqlClient

Public Class frmKargoFirmalar
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")
    Dim K As New Kargo
    Dim spt As New Sepet


    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        frmAnaSayfa.Show()
        Me.Hide()

    End Sub

    Private Sub BtnAras_Click(sender As Object, e As EventArgs) Handles BtnAras.Click
        FrmArasKargo.ShowDialog()

    End Sub
    Sub Temizle()
        For Each control As Control In Me.PanelSatis.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub frmKargoFirmalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spt.KayitGetir("select * from GIDENKARGO ", DataGridView1)
        spt.ComboyaGetir(cmbodeme, "select * from ODEMETURU")
        spt.ComboyaGetir(cmbkargo, "select * from KARGOFIRMA")
        spt.ComboyaGetir(Cmbteslimatyeri, "select * from TESLIMAT")
    End Sub

    Private Sub BtnMng_Click(sender As Object, e As EventArgs) Handles BtnMng.Click
        FrmMngKargo.ShowDialog()


    End Sub

    Private Sub BtnYurtici_Click(sender As Object, e As EventArgs) Handles BtnYurtici.Click
        frmYurticiKargo.ShowDialog()


    End Sub

    Private Sub BtnPtt_Click(sender As Object, e As EventArgs) Handles BtnPtt.Click
        frmPttKargo.ShowDialog()


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TxtSatisId_TextChanged(sender As Object, e As EventArgs) Handles TxtSatisId.TextChanged
        If TxtSatisId.Text = "" Then

            Temizle()
        End If

        spt.TextlereSatisGetir(TxtSatisId, TxtAdiSoyadi, TxtTelefon, txtadres, txtmail, TxtUrunAdi, TxtToplamSatis)
    End Sub

    Private Sub TxtKargoUcreti_TextChanged(sender As Object, e As EventArgs) Handles TxtKargoUcreti.TextChanged
        Try
            TxtToplamUcret.Text = (Double.Parse(TxtKargoUcreti.Text) + Double.Parse(TxtToplamSatis.Text)).ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnKargoEkle_Click(sender As Object, e As EventArgs) Handles BtnKargoEkle.Click
        Dim sorgu As String = ("insert into GIDENKARGO values ('" & TxtSatisId.Text & "','" & TxtUrunAdi.Text & "','" & TxtAdiSoyadi.Text & "','" & TxtTelefon.Text & "','" & txtmail.Text & "','" & txtadres.Text & "',@SATISFIYAT,'" & cmbodeme.Text & "','" & cmbkargo.Text & "','" & Cmbteslimatyeri.Text & "',@KARGOUCRETI,@TOPLAMUCRET,'" & DateTime.Now.ToString() & "'  )")
        Dim komut As New SqlCommand()
        komut.Parameters.AddWithValue("@SATISFIYAT", Double.Parse(TxtToplamSatis.Text))
        komut.Parameters.AddWithValue("@KARGOUCRETI", Double.Parse(TxtKargoUcreti.Text))
        komut.Parameters.AddWithValue("@TOPLAMUCRET", Double.Parse(TxtToplamUcret.Text))

        spt.Kayit2(komut, sorgu)
        TxtSatisId.Text = ""
        TxtKargoUcreti.Text = "0"
        spt.KayitGetir("select * from GIDENKARGO ", DataGridView1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

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
            e.Graphics.DrawString("Kargo Listesi", font, firca, 350, 75)
            e.Graphics.DrawLine(kalem, 50, 110, 770, 110)

            font = New Font("Arial", 15, FontStyle.Bold)
            e.Graphics.DrawString("Satış ID", font, firca, 50, 118)
            e.Graphics.DrawString("Adı Soyadı", font, firca, 140, 118)


            e.Graphics.DrawString("Ödeme Türü", font, firca, 300, 118)
            e.Graphics.DrawString("Kargo Firma", font, firca, 460, 118)
            e.Graphics.DrawString("Adres", font, firca, 600, 118)
            e.Graphics.DrawLine(kalem, 50, 150, 770, 150)

            'e.Graphics.DrawString("Toplam Satış Sayısı= " + lblkayitsayisi.Text + " ", font, firca, 60, 1065)

            'e.Graphics.DrawString("Genel Toplam= " + lbltoplamsatismiktari.Text + " TL", font, firca, 480, 1065)

            Dim y As Integer = 160

            font = New Font("Arial", 15)
            Dim i As Integer = 0

            While i < DataGridView1.Rows.Count - 1

                e.Graphics.DrawString(DataGridView1(1, i).Value.ToString(), font, firca, 55, y)
                e.Graphics.DrawString(DataGridView1(3, i).Value.ToString(), font, firca, 145, y)

                e.Graphics.DrawString(DataGridView1(8, i).Value.ToString(), font, firca, 305, y)
                e.Graphics.DrawString(DataGridView1(9, i).Value.ToString(), font, firca, 450, y)
                e.Graphics.DrawString(DataGridView1(6, i).Value.ToString(), font, firca, 600, y)

                y = y + 25
                i = i + 1

            End While
        Catch
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class