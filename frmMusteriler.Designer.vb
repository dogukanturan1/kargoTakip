<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusteriler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusteriler))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAnasayfa = New System.Windows.Forms.Button()
        Me.BtnMusteriListele = New System.Windows.Forms.Button()
        Me.BtnMusteriEkle = New System.Windows.Forms.Button()
        Me.PnlSayfa = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMusteriAra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAdSoyad = New System.Windows.Forms.TextBox()
        Me.TxtTc = New System.Windows.Forms.TextBox()
        Me.TxtMusteriId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtTelefon = New System.Windows.Forms.TextBox()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.BtnGuncelle = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSayfa.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnAnasayfa)
        Me.Panel1.Controls.Add(Me.BtnMusteriListele)
        Me.Panel1.Controls.Add(Me.BtnMusteriEkle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1444, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 885)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'BtnAnasayfa
        '
        Me.BtnAnasayfa.BackColor = System.Drawing.Color.White
        Me.BtnAnasayfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnAnasayfa.Image = CType(resources.GetObject("BtnAnasayfa.Image"), System.Drawing.Image)
        Me.BtnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAnasayfa.Location = New System.Drawing.Point(52, 528)
        Me.BtnAnasayfa.Name = "BtnAnasayfa"
        Me.BtnAnasayfa.Size = New System.Drawing.Size(151, 76)
        Me.BtnAnasayfa.TabIndex = 16
        Me.BtnAnasayfa.Text = "ANA SAYFA"
        Me.BtnAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnasayfa.UseVisualStyleBackColor = False
        '
        'BtnMusteriListele
        '
        Me.BtnMusteriListele.BackColor = System.Drawing.Color.White
        Me.BtnMusteriListele.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnMusteriListele.Image = CType(resources.GetObject("BtnMusteriListele.Image"), System.Drawing.Image)
        Me.BtnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMusteriListele.Location = New System.Drawing.Point(6, 322)
        Me.BtnMusteriListele.Name = "BtnMusteriListele"
        Me.BtnMusteriListele.Size = New System.Drawing.Size(191, 79)
        Me.BtnMusteriListele.TabIndex = 15
        Me.BtnMusteriListele.Text = "MÜŞTERİ LİSTELE"
        Me.BtnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMusteriListele.UseVisualStyleBackColor = False
        '
        'BtnMusteriEkle
        '
        Me.BtnMusteriEkle.BackColor = System.Drawing.Color.White
        Me.BtnMusteriEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnMusteriEkle.Image = CType(resources.GetObject("BtnMusteriEkle.Image"), System.Drawing.Image)
        Me.BtnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMusteriEkle.Location = New System.Drawing.Point(6, 206)
        Me.BtnMusteriEkle.Name = "BtnMusteriEkle"
        Me.BtnMusteriEkle.Size = New System.Drawing.Size(191, 79)
        Me.BtnMusteriEkle.TabIndex = 13
        Me.BtnMusteriEkle.Text = "MÜŞTERİ EKLE"
        Me.BtnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMusteriEkle.UseVisualStyleBackColor = False
        '
        'PnlSayfa
        '
        Me.PnlSayfa.Controls.Add(Me.DataGridView1)
        Me.PnlSayfa.Controls.Add(Me.Label7)
        Me.PnlSayfa.Controls.Add(Me.TxtMusteriAra)
        Me.PnlSayfa.Controls.Add(Me.Label6)
        Me.PnlSayfa.Controls.Add(Me.Label5)
        Me.PnlSayfa.Controls.Add(Me.Label1)
        Me.PnlSayfa.Controls.Add(Me.TxtAdSoyad)
        Me.PnlSayfa.Controls.Add(Me.TxtTc)
        Me.PnlSayfa.Controls.Add(Me.TxtMusteriId)
        Me.PnlSayfa.Controls.Add(Me.Label4)
        Me.PnlSayfa.Controls.Add(Me.Label3)
        Me.PnlSayfa.Controls.Add(Me.Label2)
        Me.PnlSayfa.Controls.Add(Me.TxtAdres)
        Me.PnlSayfa.Controls.Add(Me.TxtMail)
        Me.PnlSayfa.Controls.Add(Me.TxtTelefon)
        Me.PnlSayfa.Controls.Add(Me.BtnSil)
        Me.PnlSayfa.Controls.Add(Me.BtnGuncelle)
        Me.PnlSayfa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSayfa.Location = New System.Drawing.Point(0, 0)
        Me.PnlSayfa.Name = "PnlSayfa"
        Me.PnlSayfa.Size = New System.Drawing.Size(1444, 885)
        Me.PnlSayfa.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1444, 638)
        Me.DataGridView1.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(824, 713)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 23)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Müşteri ID Ara:"
        '
        'TxtMusteriAra
        '
        Me.TxtMusteriAra.Location = New System.Drawing.Point(814, 748)
        Me.TxtMusteriAra.Name = "TxtMusteriAra"
        Me.TxtMusteriAra.Size = New System.Drawing.Size(167, 27)
        Me.TxtMusteriAra.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(60, 737)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Adı Soyadı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(69, 784)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "TC Kimlik:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(63, 691)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Müşteri ID:"
        '
        'TxtAdSoyad
        '
        Me.TxtAdSoyad.Location = New System.Drawing.Point(178, 736)
        Me.TxtAdSoyad.Name = "TxtAdSoyad"
        Me.TxtAdSoyad.Size = New System.Drawing.Size(167, 27)
        Me.TxtAdSoyad.TabIndex = 49
        '
        'TxtTc
        '
        Me.TxtTc.Location = New System.Drawing.Point(178, 784)
        Me.TxtTc.Name = "TxtTc"
        Me.TxtTc.Size = New System.Drawing.Size(167, 27)
        Me.TxtTc.TabIndex = 48
        '
        'TxtMusteriId
        '
        Me.TxtMusteriId.Location = New System.Drawing.Point(178, 691)
        Me.TxtMusteriId.Name = "TxtMusteriId"
        Me.TxtMusteriId.Size = New System.Drawing.Size(167, 27)
        Me.TxtMusteriId.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(373, 694)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(380, 738)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(385, 780)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Adres:"
        '
        'TxtAdres
        '
        Me.TxtAdres.Location = New System.Drawing.Point(462, 780)
        Me.TxtAdres.Multiline = True
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(167, 82)
        Me.TxtAdres.TabIndex = 43
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(462, 734)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(167, 27)
        Me.TxtMail.TabIndex = 42
        '
        'TxtTelefon
        '
        Me.TxtTelefon.Location = New System.Drawing.Point(462, 690)
        Me.TxtTelefon.Name = "TxtTelefon"
        Me.TxtTelefon.Size = New System.Drawing.Size(167, 27)
        Me.TxtTelefon.TabIndex = 41
        '
        'BtnSil
        '
        Me.BtnSil.BackColor = System.Drawing.Color.White
        Me.BtnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnSil.Image = CType(resources.GetObject("BtnSil.Image"), System.Drawing.Image)
        Me.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSil.Location = New System.Drawing.Point(661, 780)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(119, 81)
        Me.BtnSil.TabIndex = 40
        Me.BtnSil.Text = "SİL"
        Me.BtnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSil.UseVisualStyleBackColor = False
        '
        'BtnGuncelle
        '
        Me.BtnGuncelle.BackColor = System.Drawing.Color.White
        Me.BtnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnGuncelle.Image = CType(resources.GetObject("BtnGuncelle.Image"), System.Drawing.Image)
        Me.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuncelle.Location = New System.Drawing.Point(661, 694)
        Me.BtnGuncelle.Name = "BtnGuncelle"
        Me.BtnGuncelle.Size = New System.Drawing.Size(119, 81)
        Me.BtnGuncelle.TabIndex = 39
        Me.BtnGuncelle.Text = "GÜNCELLE"
        Me.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuncelle.UseVisualStyleBackColor = False
        '
        'frmMusteriler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1647, 885)
        Me.Controls.Add(Me.PnlSayfa)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "frmMusteriler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteriler"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSayfa.ResumeLayout(False)
        Me.PnlSayfa.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMusteriEkle As Button
    Friend WithEvents BtnMusteriListele As Button
    Friend WithEvents PnlSayfa As Panel
    Friend WithEvents BtnAnasayfa As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMusteriAra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAdSoyad As TextBox
    Friend WithEvents TxtTc As TextBox
    Friend WithEvents TxtMusteriId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtTelefon As TextBox
    Friend WithEvents BtnSil As Button
    Friend WithEvents BtnGuncelle As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
