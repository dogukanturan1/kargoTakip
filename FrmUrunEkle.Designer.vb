<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUrunEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUrunEkle))
        Me.BtnIptal = New System.Windows.Forms.Button()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSatisFiyat = New System.Windows.Forms.TextBox()
        Me.TxtAlisFiyat = New System.Windows.Forms.TextBox()
        Me.TxtUrunAdi = New System.Windows.Forms.TextBox()
        Me.TxtAdet = New System.Windows.Forms.TextBox()
        Me.TxtUrunKodu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbMarka = New System.Windows.Forms.ComboBox()
        Me.CmbKategori = New System.Windows.Forms.ComboBox()
        Me.CmbBeden = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnIptal
        '
        Me.BtnIptal.Image = CType(resources.GetObject("BtnIptal.Image"), System.Drawing.Image)
        Me.BtnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIptal.Location = New System.Drawing.Point(308, 406)
        Me.BtnIptal.Name = "BtnIptal"
        Me.BtnIptal.Size = New System.Drawing.Size(90, 38)
        Me.BtnIptal.TabIndex = 42
        Me.BtnIptal.UseVisualStyleBackColor = True
        '
        'BtnEkle
        '
        Me.BtnEkle.Image = CType(resources.GetObject("BtnEkle.Image"), System.Drawing.Image)
        Me.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEkle.Location = New System.Drawing.Point(195, 406)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(90, 38)
        Me.BtnEkle.TabIndex = 41
        Me.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(102, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Ürün Adı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(123, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Marka:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(105, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Kategori:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(135, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Adet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(101, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Alış Fiyat:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Ürün Kodu:"
        '
        'TxtSatisFiyat
        '
        Me.TxtSatisFiyat.Location = New System.Drawing.Point(195, 308)
        Me.TxtSatisFiyat.Name = "TxtSatisFiyat"
        Me.TxtSatisFiyat.Size = New System.Drawing.Size(167, 27)
        Me.TxtSatisFiyat.TabIndex = 33
        '
        'TxtAlisFiyat
        '
        Me.TxtAlisFiyat.Location = New System.Drawing.Point(195, 262)
        Me.TxtAlisFiyat.Name = "TxtAlisFiyat"
        Me.TxtAlisFiyat.Size = New System.Drawing.Size(167, 27)
        Me.TxtAlisFiyat.TabIndex = 32
        '
        'TxtUrunAdi
        '
        Me.TxtUrunAdi.Location = New System.Drawing.Point(195, 78)
        Me.TxtUrunAdi.Name = "TxtUrunAdi"
        Me.TxtUrunAdi.Size = New System.Drawing.Size(167, 27)
        Me.TxtUrunAdi.TabIndex = 31
        '
        'TxtAdet
        '
        Me.TxtAdet.Location = New System.Drawing.Point(195, 218)
        Me.TxtAdet.Name = "TxtAdet"
        Me.TxtAdet.Size = New System.Drawing.Size(167, 27)
        Me.TxtAdet.TabIndex = 30
        '
        'TxtUrunKodu
        '
        Me.TxtUrunKodu.Location = New System.Drawing.Point(195, 32)
        Me.TxtUrunKodu.Name = "TxtUrunKodu"
        Me.TxtUrunKodu.Size = New System.Drawing.Size(167, 27)
        Me.TxtUrunKodu.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(92, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Satış Fiyat:"
        '
        'CmbMarka
        '
        Me.CmbMarka.FormattingEnabled = True
        Me.CmbMarka.Location = New System.Drawing.Point(195, 125)
        Me.CmbMarka.Name = "CmbMarka"
        Me.CmbMarka.Size = New System.Drawing.Size(167, 28)
        Me.CmbMarka.TabIndex = 44
        '
        'CmbKategori
        '
        Me.CmbKategori.FormattingEnabled = True
        Me.CmbKategori.Location = New System.Drawing.Point(195, 173)
        Me.CmbKategori.Name = "CmbKategori"
        Me.CmbKategori.Size = New System.Drawing.Size(167, 28)
        Me.CmbKategori.TabIndex = 45
        '
        'CmbBeden
        '
        Me.CmbBeden.FormattingEnabled = True
        Me.CmbBeden.Location = New System.Drawing.Point(195, 350)
        Me.CmbBeden.Name = "CmbBeden"
        Me.CmbBeden.Size = New System.Drawing.Size(167, 28)
        Me.CmbBeden.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(123, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Beden:"
        '
        'FrmUrunEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(515, 472)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbBeden)
        Me.Controls.Add(Me.CmbKategori)
        Me.Controls.Add(Me.CmbMarka)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnIptal)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSatisFiyat)
        Me.Controls.Add(Me.TxtAlisFiyat)
        Me.Controls.Add(Me.TxtUrunAdi)
        Me.Controls.Add(Me.TxtAdet)
        Me.Controls.Add(Me.TxtUrunKodu)
        Me.Name = "FrmUrunEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Ekleme Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIptal As Button
    Friend WithEvents BtnEkle As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSatisFiyat As TextBox
    Friend WithEvents TxtAlisFiyat As TextBox
    Friend WithEvents TxtUrunAdi As TextBox
    Friend WithEvents TxtAdet As TextBox
    Friend WithEvents TxtUrunKodu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbMarka As ComboBox
    Friend WithEvents CmbKategori As ComboBox
    Friend WithEvents CmbBeden As ComboBox
    Friend WithEvents Label8 As Label
End Class
