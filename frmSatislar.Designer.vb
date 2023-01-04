<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSatislar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSatislar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbltoplamsatismiktari = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblkayitsayisi = New System.Windows.Forms.Label()
        Me.BtnGuncelle = New System.Windows.Forms.Button()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.BtnSatisEkle = New System.Windows.Forms.Button()
        Me.PnlSatis = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelSatis = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSatisKodu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBeden = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtToplamFiyat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBirimFiyat = New System.Windows.Forms.TextBox()
        Me.TxtAdet = New System.Windows.Forms.TextBox()
        Me.TxtUrunAdi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMarka = New System.Windows.Forms.TextBox()
        Me.TxtKategori = New System.Windows.Forms.TextBox()
        Me.TxtUrunKodu = New System.Windows.Forms.TextBox()
        Me.PanelMusteri = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTelefon = New System.Windows.Forms.TextBox()
        Me.TxtAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TxtMusteriid = New System.Windows.Forms.TextBox()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.PnlSatis.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSatis.SuspendLayout()
        Me.PanelMusteri.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lbltoplamsatismiktari)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblkayitsayisi)
        Me.Panel1.Controls.Add(Me.BtnGuncelle)
        Me.Panel1.Controls.Add(Me.BtnSil)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 726)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1789, 159)
        Me.Panel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(1431, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(193, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "TOPLAM SATIŞ TUTARI :"
        '
        'lbltoplamsatismiktari
        '
        Me.lbltoplamsatismiktari.AutoSize = True
        Me.lbltoplamsatismiktari.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbltoplamsatismiktari.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltoplamsatismiktari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltoplamsatismiktari.Location = New System.Drawing.Point(1648, 86)
        Me.lbltoplamsatismiktari.Name = "lbltoplamsatismiktari"
        Me.lbltoplamsatismiktari.Size = New System.Drawing.Size(67, 23)
        Me.lbltoplamsatismiktari.TabIndex = 17
        Me.lbltoplamsatismiktari.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(1443, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 23)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "TOPLAM SATIŞ SAYISI:"
        '
        'lblkayitsayisi
        '
        Me.lblkayitsayisi.AutoSize = True
        Me.lblkayitsayisi.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblkayitsayisi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblkayitsayisi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblkayitsayisi.Location = New System.Drawing.Point(1652, 32)
        Me.lblkayitsayisi.Name = "lblkayitsayisi"
        Me.lblkayitsayisi.Size = New System.Drawing.Size(64, 23)
        Me.lblkayitsayisi.TabIndex = 15
        Me.lblkayitsayisi.Text = "toplam"
        '
        'BtnGuncelle
        '
        Me.BtnGuncelle.BackColor = System.Drawing.Color.White
        Me.BtnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnGuncelle.Image = CType(resources.GetObject("BtnGuncelle.Image"), System.Drawing.Image)
        Me.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuncelle.Location = New System.Drawing.Point(750, 46)
        Me.BtnGuncelle.Name = "BtnGuncelle"
        Me.BtnGuncelle.Size = New System.Drawing.Size(191, 79)
        Me.BtnGuncelle.TabIndex = 13
        Me.BtnGuncelle.Text = "SATIŞ GÜNCELLE"
        Me.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuncelle.UseVisualStyleBackColor = False
        '
        'BtnSil
        '
        Me.BtnSil.BackColor = System.Drawing.Color.White
        Me.BtnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnSil.Image = CType(resources.GetObject("BtnSil.Image"), System.Drawing.Image)
        Me.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSil.Location = New System.Drawing.Point(496, 46)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(191, 79)
        Me.BtnSil.TabIndex = 6
        Me.BtnSil.Text = "SATIŞ SİL"
        Me.BtnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSil.UseVisualStyleBackColor = False
        '
        'BtnSatisEkle
        '
        Me.BtnSatisEkle.BackColor = System.Drawing.Color.White
        Me.BtnSatisEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnSatisEkle.Image = CType(resources.GetObject("BtnSatisEkle.Image"), System.Drawing.Image)
        Me.BtnSatisEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSatisEkle.Location = New System.Drawing.Point(1483, 33)
        Me.BtnSatisEkle.Name = "BtnSatisEkle"
        Me.BtnSatisEkle.Size = New System.Drawing.Size(125, 89)
        Me.BtnSatisEkle.TabIndex = 12
        Me.BtnSatisEkle.Text = "SATIŞ EKLE"
        Me.BtnSatisEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSatisEkle.UseVisualStyleBackColor = False
        '
        'PnlSatis
        '
        Me.PnlSatis.Controls.Add(Me.Button1)
        Me.PnlSatis.Controls.Add(Me.Panel3)
        Me.PnlSatis.Controls.Add(Me.BtnSatisEkle)
        Me.PnlSatis.Controls.Add(Me.PanelSatis)
        Me.PnlSatis.Controls.Add(Me.PanelMusteri)
        Me.PnlSatis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSatis.Location = New System.Drawing.Point(0, 0)
        Me.PnlSatis.Name = "PnlSatis"
        Me.PnlSatis.Size = New System.Drawing.Size(1789, 726)
        Me.PnlSatis.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1638, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 89)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "YAZDIR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1789, 560)
        Me.Panel3.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1789, 560)
        Me.DataGridView1.TabIndex = 0
        '
        'PanelSatis
        '
        Me.PanelSatis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSatis.Controls.Add(Me.Label17)
        Me.PanelSatis.Controls.Add(Me.Label16)
        Me.PanelSatis.Controls.Add(Me.TxtSatisKodu)
        Me.PanelSatis.Controls.Add(Me.Label10)
        Me.PanelSatis.Controls.Add(Me.TxtBeden)
        Me.PanelSatis.Controls.Add(Me.Label12)
        Me.PanelSatis.Controls.Add(Me.TxtToplamFiyat)
        Me.PanelSatis.Controls.Add(Me.Label7)
        Me.PanelSatis.Controls.Add(Me.Label8)
        Me.PanelSatis.Controls.Add(Me.Label9)
        Me.PanelSatis.Controls.Add(Me.TxtBirimFiyat)
        Me.PanelSatis.Controls.Add(Me.TxtAdet)
        Me.PanelSatis.Controls.Add(Me.TxtUrunAdi)
        Me.PanelSatis.Controls.Add(Me.Label4)
        Me.PanelSatis.Controls.Add(Me.Label5)
        Me.PanelSatis.Controls.Add(Me.Label6)
        Me.PanelSatis.Controls.Add(Me.TxtMarka)
        Me.PanelSatis.Controls.Add(Me.TxtKategori)
        Me.PanelSatis.Controls.Add(Me.TxtUrunKodu)
        Me.PanelSatis.Location = New System.Drawing.Point(643, 12)
        Me.PanelSatis.Name = "PanelSatis"
        Me.PanelSatis.Size = New System.Drawing.Size(800, 155)
        Me.PanelSatis.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label17.Location = New System.Drawing.Point(528, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Satış Kodu:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label16.Location = New System.Drawing.Point(528, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 23)
        Me.Label16.TabIndex = 43
        '
        'TxtSatisKodu
        '
        Me.TxtSatisKodu.Location = New System.Drawing.Point(652, 113)
        Me.TxtSatisKodu.Name = "TxtSatisKodu"
        Me.TxtSatisKodu.Size = New System.Drawing.Size(125, 27)
        Me.TxtSatisKodu.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label10.Location = New System.Drawing.Point(528, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 23)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Beden:"
        '
        'TxtBeden
        '
        Me.TxtBeden.Location = New System.Drawing.Point(652, 55)
        Me.TxtBeden.Name = "TxtBeden"
        Me.TxtBeden.Size = New System.Drawing.Size(125, 27)
        Me.TxtBeden.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label12.Location = New System.Drawing.Point(528, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 23)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Toplam Fiyat:"
        '
        'TxtToplamFiyat
        '
        Me.TxtToplamFiyat.Location = New System.Drawing.Point(652, 22)
        Me.TxtToplamFiyat.Name = "TxtToplamFiyat"
        Me.TxtToplamFiyat.Size = New System.Drawing.Size(125, 27)
        Me.TxtToplamFiyat.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label7.Location = New System.Drawing.Point(284, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Satış Fiyatı:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label8.Location = New System.Drawing.Point(332, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Adet:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(299, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 23)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Ürün Adı:"
        '
        'TxtBirimFiyat
        '
        Me.TxtBirimFiyat.Location = New System.Drawing.Point(392, 106)
        Me.TxtBirimFiyat.Name = "TxtBirimFiyat"
        Me.TxtBirimFiyat.Size = New System.Drawing.Size(125, 27)
        Me.TxtBirimFiyat.TabIndex = 33
        '
        'TxtAdet
        '
        Me.TxtAdet.Location = New System.Drawing.Point(392, 64)
        Me.TxtAdet.Name = "TxtAdet"
        Me.TxtAdet.Size = New System.Drawing.Size(125, 27)
        Me.TxtAdet.TabIndex = 32
        Me.TxtAdet.Text = "1"
        Me.TxtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUrunAdi
        '
        Me.TxtUrunAdi.Location = New System.Drawing.Point(392, 21)
        Me.TxtUrunAdi.Name = "TxtUrunAdi"
        Me.TxtUrunAdi.Size = New System.Drawing.Size(125, 27)
        Me.TxtUrunAdi.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(59, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Marka:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label5.Location = New System.Drawing.Point(41, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Kategori:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label6.Location = New System.Drawing.Point(24, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Ürün Kodu:"
        '
        'TxtMarka
        '
        Me.TxtMarka.Location = New System.Drawing.Point(138, 109)
        Me.TxtMarka.Name = "TxtMarka"
        Me.TxtMarka.Size = New System.Drawing.Size(125, 27)
        Me.TxtMarka.TabIndex = 27
        '
        'TxtKategori
        '
        Me.TxtKategori.Location = New System.Drawing.Point(138, 67)
        Me.TxtKategori.Name = "TxtKategori"
        Me.TxtKategori.Size = New System.Drawing.Size(125, 27)
        Me.TxtKategori.TabIndex = 26
        '
        'TxtUrunKodu
        '
        Me.TxtUrunKodu.Location = New System.Drawing.Point(138, 24)
        Me.TxtUrunKodu.Name = "TxtUrunKodu"
        Me.TxtUrunKodu.Size = New System.Drawing.Size(125, 27)
        Me.TxtUrunKodu.TabIndex = 25
        '
        'PanelMusteri
        '
        Me.PanelMusteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMusteri.Controls.Add(Me.Label19)
        Me.PanelMusteri.Controls.Add(Me.Label20)
        Me.PanelMusteri.Controls.Add(Me.TxtAdres)
        Me.PanelMusteri.Controls.Add(Me.TxtMail)
        Me.PanelMusteri.Controls.Add(Me.Label3)
        Me.PanelMusteri.Controls.Add(Me.Label2)
        Me.PanelMusteri.Controls.Add(Me.Label1)
        Me.PanelMusteri.Controls.Add(Me.TxtTelefon)
        Me.PanelMusteri.Controls.Add(Me.TxtAdiSoyadi)
        Me.PanelMusteri.Controls.Add(Me.TxtMusteriid)
        Me.PanelMusteri.Controls.Add(Me.BtnGeri)
        Me.PanelMusteri.Location = New System.Drawing.Point(4, 5)
        Me.PanelMusteri.Name = "PanelMusteri"
        Me.PanelMusteri.Size = New System.Drawing.Size(611, 155)
        Me.PanelMusteri.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(334, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 23)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Adres:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(337, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 23)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Mail:"
        '
        'TxtAdres
        '
        Me.TxtAdres.Location = New System.Drawing.Point(442, 70)
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(125, 27)
        Me.TxtAdres.TabIndex = 26
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(442, 27)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(125, 27)
        Me.TxtMail.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(103, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Telefon:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(74, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Adı Soyadı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Müşteri ID:"
        '
        'TxtTelefon
        '
        Me.TxtTelefon.Location = New System.Drawing.Point(182, 112)
        Me.TxtTelefon.Name = "TxtTelefon"
        Me.TxtTelefon.Size = New System.Drawing.Size(125, 27)
        Me.TxtTelefon.TabIndex = 21
        '
        'TxtAdiSoyadi
        '
        Me.TxtAdiSoyadi.Location = New System.Drawing.Point(182, 70)
        Me.TxtAdiSoyadi.Name = "TxtAdiSoyadi"
        Me.TxtAdiSoyadi.Size = New System.Drawing.Size(125, 27)
        Me.TxtAdiSoyadi.TabIndex = 20
        '
        'TxtMusteriid
        '
        Me.TxtMusteriid.Location = New System.Drawing.Point(182, 27)
        Me.TxtMusteriid.Name = "TxtMusteriid"
        Me.TxtMusteriid.Size = New System.Drawing.Size(125, 27)
        Me.TxtMusteriid.TabIndex = 19
        '
        'BtnGeri
        '
        Me.BtnGeri.BackColor = System.Drawing.Color.White
        Me.BtnGeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnGeri.Image = CType(resources.GetObject("BtnGeri.Image"), System.Drawing.Image)
        Me.BtnGeri.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnGeri.Location = New System.Drawing.Point(-1, -1)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(40, 40)
        Me.BtnGeri.TabIndex = 18
        Me.BtnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGeri.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'frmSatislar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1789, 885)
        Me.Controls.Add(Me.PnlSatis)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSatislar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satışlar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlSatis.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSatis.ResumeLayout(False)
        Me.PanelSatis.PerformLayout()
        Me.PanelMusteri.ResumeLayout(False)
        Me.PanelMusteri.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSil As Button
    Friend WithEvents BtnGuncelle As Button
    Friend WithEvents BtnSatisEkle As Button
    Friend WithEvents PnlSatis As Panel
    Friend WithEvents BtnGeri As Button
    Friend WithEvents PanelSatis As Panel
    Friend WithEvents PanelMusteri As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTelefon As TextBox
    Friend WithEvents TxtAdiSoyadi As TextBox
    Friend WithEvents TxtMusteriid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtToplamFiyat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBirimFiyat As TextBox
    Friend WithEvents TxtAdet As TextBox
    Friend WithEvents TxtUrunAdi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMarka As TextBox
    Friend WithEvents TxtKategori As TextBox
    Friend WithEvents TxtUrunKodu As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtBeden As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblkayitsayisi As Label
    Friend WithEvents lbltoplamsatismiktari As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtSatisKodu As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
