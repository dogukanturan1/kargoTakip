<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusteriListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusteriListele))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnGuncelle = New System.Windows.Forms.Button()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtTelefon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAdSoyad = New System.Windows.Forms.TextBox()
        Me.TxtTc = New System.Windows.Forms.TextBox()
        Me.TxtMusteriId = New System.Windows.Forms.TextBox()
        Me.TxtMusteriAra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Size = New System.Drawing.Size(1647, 650)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnGuncelle
        '
        Me.BtnGuncelle.BackColor = System.Drawing.Color.White
        Me.BtnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnGuncelle.Image = CType(resources.GetObject("BtnGuncelle.Image"), System.Drawing.Image)
        Me.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuncelle.Location = New System.Drawing.Point(666, 695)
        Me.BtnGuncelle.Name = "BtnGuncelle"
        Me.BtnGuncelle.Size = New System.Drawing.Size(119, 81)
        Me.BtnGuncelle.TabIndex = 15
        Me.BtnGuncelle.Text = "GÜNCELLE"
        Me.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuncelle.UseVisualStyleBackColor = False
        '
        'BtnSil
        '
        Me.BtnSil.BackColor = System.Drawing.Color.White
        Me.BtnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BtnSil.Image = CType(resources.GetObject("BtnSil.Image"), System.Drawing.Image)
        Me.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSil.Location = New System.Drawing.Point(666, 781)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(119, 81)
        Me.BtnSil.TabIndex = 16
        Me.BtnSil.Text = "SİL"
        Me.BtnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSil.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(378, 695)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(385, 739)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(390, 781)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Adres:"
        '
        'TxtAdres
        '
        Me.TxtAdres.Location = New System.Drawing.Point(467, 781)
        Me.TxtAdres.Multiline = True
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(167, 82)
        Me.TxtAdres.TabIndex = 27
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(467, 735)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(167, 27)
        Me.TxtMail.TabIndex = 26
        '
        'TxtTelefon
        '
        Me.TxtTelefon.Location = New System.Drawing.Point(467, 691)
        Me.TxtTelefon.Name = "TxtTelefon"
        Me.TxtTelefon.Size = New System.Drawing.Size(167, 27)
        Me.TxtTelefon.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(65, 738)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Adı Soyadı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(74, 785)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TC Kimlik:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(68, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Müşteri ID:"
        '
        'TxtAdSoyad
        '
        Me.TxtAdSoyad.Location = New System.Drawing.Point(183, 737)
        Me.TxtAdSoyad.Name = "TxtAdSoyad"
        Me.TxtAdSoyad.Size = New System.Drawing.Size(167, 27)
        Me.TxtAdSoyad.TabIndex = 33
        '
        'TxtTc
        '
        Me.TxtTc.Location = New System.Drawing.Point(183, 785)
        Me.TxtTc.Name = "TxtTc"
        Me.TxtTc.Size = New System.Drawing.Size(167, 27)
        Me.TxtTc.TabIndex = 32
        '
        'TxtMusteriId
        '
        Me.TxtMusteriId.Location = New System.Drawing.Point(183, 692)
        Me.TxtMusteriId.Name = "TxtMusteriId"
        Me.TxtMusteriId.Size = New System.Drawing.Size(167, 27)
        Me.TxtMusteriId.TabIndex = 31
        '
        'TxtMusteriAra
        '
        Me.TxtMusteriAra.Location = New System.Drawing.Point(819, 749)
        Me.TxtMusteriAra.Name = "TxtMusteriAra"
        Me.TxtMusteriAra.Size = New System.Drawing.Size(167, 27)
        Me.TxtMusteriAra.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(829, 714)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 23)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Müşteri ID Ara:"
        '
        'frmMusteriListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1647, 885)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMusteriAra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAdSoyad)
        Me.Controls.Add(Me.TxtTc)
        Me.Controls.Add(Me.TxtMusteriId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAdres)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtTelefon)
        Me.Controls.Add(Me.BtnSil)
        Me.Controls.Add(Me.BtnGuncelle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMusteriListele"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Listeleme"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnGuncelle As Button
    Friend WithEvents BtnSil As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtTelefon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAdSoyad As TextBox
    Friend WithEvents TxtTc As TextBox
    Friend WithEvents TxtMusteriId As TextBox
    Friend WithEvents TxtMusteriAra As TextBox
    Friend WithEvents Label7 As Label
End Class
