<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMusteriEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusteriEkle))
        Me.TxtMusteriId = New System.Windows.Forms.TextBox()
        Me.TxtTc = New System.Windows.Forms.TextBox()
        Me.TxtAdSoyad = New System.Windows.Forms.TextBox()
        Me.TxtTelefon = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtAdres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.BtnIptal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtMusteriId
        '
        Me.TxtMusteriId.Location = New System.Drawing.Point(179, 48)
        Me.TxtMusteriId.Name = "TxtMusteriId"
        Me.TxtMusteriId.Size = New System.Drawing.Size(167, 27)
        Me.TxtMusteriId.TabIndex = 0
        '
        'TxtTc
        '
        Me.TxtTc.Location = New System.Drawing.Point(179, 141)
        Me.TxtTc.Name = "TxtTc"
        Me.TxtTc.Size = New System.Drawing.Size(167, 27)
        Me.TxtTc.TabIndex = 1
        '
        'TxtAdSoyad
        '
        Me.TxtAdSoyad.Location = New System.Drawing.Point(179, 93)
        Me.TxtAdSoyad.Name = "TxtAdSoyad"
        Me.TxtAdSoyad.Size = New System.Drawing.Size(167, 27)
        Me.TxtAdSoyad.TabIndex = 2
        '
        'TxtTelefon
        '
        Me.TxtTelefon.Location = New System.Drawing.Point(179, 186)
        Me.TxtTelefon.Name = "TxtTelefon"
        Me.TxtTelefon.Size = New System.Drawing.Size(167, 27)
        Me.TxtTelefon.TabIndex = 18
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(179, 230)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(167, 27)
        Me.TxtMail.TabIndex = 19
        '
        'TxtAdres
        '
        Me.TxtAdres.Location = New System.Drawing.Point(179, 276)
        Me.TxtAdres.Multiline = True
        Me.TxtAdres.Name = "TxtAdres"
        Me.TxtAdres.Size = New System.Drawing.Size(167, 82)
        Me.TxtAdres.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(64, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Müşteri ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(102, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Adres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(97, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(90, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Telefon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(70, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TC Kimlik:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(61, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Adı Soyadı:"
        '
        'BtnEkle
        '
        Me.BtnEkle.Image = CType(resources.GetObject("BtnEkle.Image"), System.Drawing.Image)
        Me.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEkle.Location = New System.Drawing.Point(156, 373)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(90, 38)
        Me.BtnEkle.TabIndex = 27
        Me.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'BtnIptal
        '
        Me.BtnIptal.Image = CType(resources.GetObject("BtnIptal.Image"), System.Drawing.Image)
        Me.BtnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIptal.Location = New System.Drawing.Point(272, 373)
        Me.BtnIptal.Name = "BtnIptal"
        Me.BtnIptal.Size = New System.Drawing.Size(90, 38)
        Me.BtnIptal.TabIndex = 28
        Me.BtnIptal.UseVisualStyleBackColor = True
        '
        'frmMusteriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(441, 450)
        Me.Controls.Add(Me.BtnIptal)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAdres)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtTelefon)
        Me.Controls.Add(Me.TxtAdSoyad)
        Me.Controls.Add(Me.TxtTc)
        Me.Controls.Add(Me.TxtMusteriId)
        Me.Name = "frmMusteriEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Ekleme Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMusteriId As TextBox
    Friend WithEvents TxtTc As TextBox
    Friend WithEvents TxtAdSoyad As TextBox
    Friend WithEvents TxtTelefon As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnEkle As Button
    Friend WithEvents BtnIptal As Button
End Class
