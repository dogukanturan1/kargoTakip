Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Public Class frmUrunler
    Dim baglanti As New SqlConnection("Data Source=DOGUKAN;Initial Catalog=DbKargoTakip;Integrated Security=True")

    Dim Ko As New Kargo
    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
    Dim K As New Kargo
    Sub SayfaGetir(frm As Form)
        PnlSayfa.Controls.Clear()
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        PnlSayfa.Controls.Add(frm)
        frm.Show()
    End Sub





    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnMarkaEkle_Click(sender As Object, e As EventArgs) Handles BtnMarkaEkle.Click
        FrmMarka.ShowDialog()


    End Sub

    Private Sub BtnKategoriEkle_Click(sender As Object, e As EventArgs) Handles BtnKategoriEkle.Click
        frmKategori.ShowDialog()

    End Sub

    Private Sub BtnAnasayfa_Click(sender As Object, e As EventArgs) Handles BtnAnasayfa.Click
        frmAnaSayfa.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUrunEkle_Click(sender As Object, e As EventArgs) Handles BtnUrunEkle.Click
        FrmUrunEkle.ShowDialog()

    End Sub

    Private Sub frmUrunler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ko.KayitGetir("select * from URUNLER ", DataGridView1)
        Ko.ComboyaGetir(CmbKategori, "select * from KATEGORI")
        Ko.ComboyaGetir(CmbMarka, "select * from MARKA")
        Ko.ComboyaGetir(CmbBeden, "select * from BEDEN")
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        TxtUrunKodu.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TxtUrun.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        CmbMarka.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        CmbKategori.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TxtAdet.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TxtAlisFiyat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TxtSatisFiyat.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        CmbBeden.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
    End Sub

    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs) Handles BtnGuncelle.Click
        K.Ekle_Sil_Guncelle_Urun("update URUNLER set URUNADI='" & TxtUrun.Text & "',MARKA='" & CmbMarka.Text & "',KATEGORI='" & CmbKategori.Text & "', ADET='" & TxtAdet.Text & "', ALISFIYAT='" & TxtAlisFiyat.Text & "',SATISFIYAT='" & TxtSatisFiyat.Text & "',BEDEB='" & CmbBeden.Text & "' where URUNKODU='" & TxtUrunKodu.Text & "'")
        K.KayitGetir("select * from URUNLER ", DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        K.Ekle_Sil_Guncelle_Urun("delete from URUNLER where URUNKODU='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'")
        K.KayitGetir("select * from URUNLER ", DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim excel As New Application
        Dim kitap As New Workbook
        Dim sayfa As Worksheet
        kitap = excel.Workbooks.Add
        sayfa = kitap.Worksheets(1)

        For i = 0 To DataGridView1.ColumnCount - 1
            sayfa.Cells(1, i + 1) = DataGridView1.Columns(i).HeaderText

        Next
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                sayfa.Cells(i + 2, j + 1) = DataGridView1(j, i).Value
            Next
        Next
    End Sub
End Class