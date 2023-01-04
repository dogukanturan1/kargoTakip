<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUrunler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUrunler))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnKategoriEkle = New System.Windows.Forms.Button()
        Me.BtnMarkaEkle = New System.Windows.Forms.Button()
        Me.BtnAnasayfa = New System.Windows.Forms.Button()
        Me.BtnUrunEkle = New System.Windows.Forms.Button()
        Me.PnlSayfa = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CmbBeden = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbKategori = New System.Windows.Forms.ComboBox()
        Me.CmbMarka = New System.Windows.Forms.ComboBox()
        Me.TxtSatisFiyat = New System.Windows.Forms.TextBox()
        Me.TxtAlisFiyat = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtUrun = New System.Windows.Forms.TextBox()
        Me.TxtUrunKodu = New System.Windows.Forms.TextBox()
        Me.TxtAdet = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnGuncelle = New System.Windows.Forms.Button()
        Me.PnlUrunListele = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PnlSayfa.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlUrunListele.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnKategoriEkle)
        Me.Panel1.Controls.Add(Me.BtnMarkaEkle)
        Me.Panel1.Controls.Add(Me.BtnAnasayfa)
        Me.Panel1.Controls.Add(Me.BtnUrunEkle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1463, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 885)
        Me.Panel1.TabIndex = 1
        '
        'BtnKategoriEkle
        '
        Me.BtnKategoriEkle.BackColor = System.Drawing.Color.White
        Me.BtnKategoriEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnKategoriEkle.Image = CType(resources.GetObject("BtnKategoriEkle.Image"), System.Drawing.Image)
        Me.BtnKategoriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnKategoriEkle.Location = New System.Drawing.Point(12, 301)
        Me.BtnKategoriEkle.Name = "BtnKategoriEkle"
        Me.BtnKategoriEkle.Size = New System.Drawing.Size(164, 73)
        Me.BtnKategoriEkle.TabIndex = 21
        Me.BtnKategoriEkle.Text = "KATEGORİ EKLE"
        Me.BtnKategoriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKategoriEkle.UseVisualStyleBackColor = False
        '
        'BtnMarkaEkle
        '
        Me.BtnMarkaEkle.BackColor = System.Drawing.Color.White
        Me.BtnMarkaEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnMarkaEkle.Image = CType(resources.GetObject("BtnMarkaEkle.Image"), System.Drawing.Image)
        Me.BtnMarkaEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMarkaEkle.Location = New System.Drawing.Point(12, 177)
        Me.BtnMarkaEkle.Name = "BtnMarkaEkle"
        Me.BtnMarkaEkle.Size = New System.Drawing.Size(164, 73)
        Me.BtnMarkaEkle.TabIndex = 20
        Me.BtnMarkaEkle.Text = "MARKA EKLE"
        Me.BtnMarkaEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMarkaEkle.UseVisualStyleBackColor = False
        '
        'BtnAnasayfa
        '
        Me.BtnAnasayfa.BackColor = System.Drawing.Color.White
        Me.BtnAnasayfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnAnasayfa.Image = CType(resources.GetObject("BtnAnasayfa.Image"), System.Drawing.Image)
        Me.BtnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAnasayfa.Location = New System.Drawing.Point(21, 797)
        Me.BtnAnasayfa.Name = "BtnAnasayfa"
        Me.BtnAnasayfa.Size = New System.Drawing.Size(151, 76)
        Me.BtnAnasayfa.TabIndex = 19
        Me.BtnAnasayfa.Text = "ANA SAYFA"
        Me.BtnAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnasayfa.UseVisualStyleBackColor = False
        '
        'BtnUrunEkle
        '
        Me.BtnUrunEkle.BackColor = System.Drawing.Color.White
        Me.BtnUrunEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnUrunEkle.Image = CType(resources.GetObject("BtnUrunEkle.Image"), System.Drawing.Image)
        Me.BtnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUrunEkle.Location = New System.Drawing.Point(12, 58)
        Me.BtnUrunEkle.Name = "BtnUrunEkle"
        Me.BtnUrunEkle.Size = New System.Drawing.Size(164, 73)
        Me.BtnUrunEkle.TabIndex = 17
        Me.BtnUrunEkle.Text = "ÜRÜN EKLE"
        Me.BtnUrunEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUrunEkle.UseVisualStyleBackColor = False
        '
        'PnlSayfa
        '
        Me.PnlSayfa.Controls.Add(Me.Panel2)
        Me.PnlSayfa.Controls.Add(Me.PnlUrunListele)
        Me.PnlSayfa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSayfa.Location = New System.Drawing.Point(0, 0)
        Me.PnlSayfa.Name = "PnlSayfa"
        Me.PnlSayfa.Size = New System.Drawing.Size(1463, 885)
        Me.PnlSayfa.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.CmbBeden)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CmbKategori)
        Me.Panel2.Controls.Add(Me.CmbMarka)
        Me.Panel2.Controls.Add(Me.TxtSatisFiyat)
        Me.Panel2.Controls.Add(Me.TxtAlisFiyat)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.TxtUrun)
        Me.Panel2.Controls.Add(Me.TxtUrunKodu)
        Me.Panel2.Controls.Add(Me.TxtAdet)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.BtnGuncelle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 656)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1463, 229)
        Me.Panel2.TabIndex = 1
        '
        'CmbBeden
        '
        Me.CmbBeden.FormattingEnabled = True
        Me.CmbBeden.Location = New System.Drawing.Point(571, 23)
        Me.CmbBeden.Name = "CmbBeden"
        Me.CmbBeden.Size = New System.Drawing.Size(167, 28)
        Me.CmbBeden.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(475, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "BEDEN:"
        '
        'CmbKategori
        '
        Me.CmbKategori.FormattingEnabled = True
        Me.CmbKategori.Location = New System.Drawing.Point(162, 161)
        Me.CmbKategori.Name = "CmbKategori"
        Me.CmbKategori.Size = New System.Drawing.Size(167, 28)
        Me.CmbKategori.TabIndex = 98
        '
        'CmbMarka
        '
        Me.CmbMarka.FormattingEnabled = True
        Me.CmbMarka.Location = New System.Drawing.Point(162, 116)
        Me.CmbMarka.Name = "CmbMarka"
        Me.CmbMarka.Size = New System.Drawing.Size(167, 28)
        Me.CmbMarka.TabIndex = 97
        '
        'TxtSatisFiyat
        '
        Me.TxtSatisFiyat.Location = New System.Drawing.Point(571, 157)
        Me.TxtSatisFiyat.Name = "TxtSatisFiyat"
        Me.TxtSatisFiyat.Size = New System.Drawing.Size(167, 27)
        Me.TxtSatisFiyat.TabIndex = 96
        '
        'TxtAlisFiyat
        '
        Me.TxtAlisFiyat.Location = New System.Drawing.Point(571, 109)
        Me.TxtAlisFiyat.Name = "TxtAlisFiyat"
        Me.TxtAlisFiyat.Size = New System.Drawing.Size(167, 27)
        Me.TxtAlisFiyat.TabIndex = 95
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label17.Location = New System.Drawing.Point(433, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 19)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "SATIS FIYAT:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label18.Location = New System.Drawing.Point(26, 165)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 19)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "KATEGORI:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label19.Location = New System.Drawing.Point(444, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 19)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "ALIS FIYAT:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label20.Location = New System.Drawing.Point(495, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 19)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "ADET:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label21.Location = New System.Drawing.Point(56, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 19)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "MARKA:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label22.Location = New System.Drawing.Point(33, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 19)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "ÜRÜN ADI:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label24.Location = New System.Drawing.Point(10, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(132, 19)
        Me.Label24.TabIndex = 86
        Me.Label24.Text = "ÜRÜN KODU:"
        '
        'TxtUrun
        '
        Me.TxtUrun.Location = New System.Drawing.Point(162, 68)
        Me.TxtUrun.Name = "TxtUrun"
        Me.TxtUrun.Size = New System.Drawing.Size(167, 27)
        Me.TxtUrun.TabIndex = 85
        '
        'TxtUrunKodu
        '
        Me.TxtUrunKodu.Location = New System.Drawing.Point(162, 23)
        Me.TxtUrunKodu.Name = "TxtUrunKodu"
        Me.TxtUrunKodu.Size = New System.Drawing.Size(167, 27)
        Me.TxtUrunKodu.TabIndex = 84
        '
        'TxtAdet
        '
        Me.TxtAdet.Location = New System.Drawing.Point(571, 64)
        Me.TxtAdet.Name = "TxtAdet"
        Me.TxtAdet.Size = New System.Drawing.Size(167, 27)
        Me.TxtAdet.TabIndex = 83
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(874, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 81)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "SİL"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnGuncelle
        '
        Me.BtnGuncelle.BackColor = System.Drawing.Color.White
        Me.BtnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnGuncelle.Image = CType(resources.GetObject("BtnGuncelle.Image"), System.Drawing.Image)
        Me.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuncelle.Location = New System.Drawing.Point(874, 27)
        Me.BtnGuncelle.Name = "BtnGuncelle"
        Me.BtnGuncelle.Size = New System.Drawing.Size(119, 81)
        Me.BtnGuncelle.TabIndex = 81
        Me.BtnGuncelle.Text = "GÜNCELLE"
        Me.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuncelle.UseVisualStyleBackColor = False
        '
        'PnlUrunListele
        '
        Me.PnlUrunListele.BackColor = System.Drawing.Color.Gray
        Me.PnlUrunListele.Controls.Add(Me.DataGridView1)
        Me.PnlUrunListele.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlUrunListele.Location = New System.Drawing.Point(0, 0)
        Me.PnlUrunListele.Name = "PnlUrunListele"
        Me.PnlUrunListele.Size = New System.Drawing.Size(1463, 885)
        Me.PnlUrunListele.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1463, 885)
        Me.DataGridView1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(12, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 69)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "EXCEL'E AKTAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmUrunler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1647, 885)
        Me.Controls.Add(Me.PnlSayfa)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "frmUrunler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Listesi"
        Me.Panel1.ResumeLayout(False)
        Me.PnlSayfa.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlUrunListele.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAnasayfa As Button
    Friend WithEvents BtnUrunEkle As Button
    Friend WithEvents BtnKategoriEkle As Button
    Friend WithEvents BtnMarkaEkle As Button
    Friend WithEvents PnlSayfa As Panel
    Friend WithEvents PnlUrunListele As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CmbKategori As ComboBox
    Friend WithEvents CmbMarka As ComboBox
    Friend WithEvents TxtSatisFiyat As TextBox
    Friend WithEvents TxtAlisFiyat As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtUrun As TextBox
    Friend WithEvents TxtUrunKodu As TextBox
    Friend WithEvents TxtAdet As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnGuncelle As Button
    Friend WithEvents CmbBeden As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
