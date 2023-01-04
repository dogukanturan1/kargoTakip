<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKullanici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKullanici))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TxtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.TxtSifre = New System.Windows.Forms.TextBox()
        Me.BtnGiris = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LblCikis = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(204, 74)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(204, 127)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'TxtKullaniciAdi
        '
        Me.TxtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKullaniciAdi.Location = New System.Drawing.Point(253, 93)
        Me.TxtKullaniciAdi.Name = "TxtKullaniciAdi"
        Me.TxtKullaniciAdi.Size = New System.Drawing.Size(148, 20)
        Me.TxtKullaniciAdi.TabIndex = 0
        '
        'TxtSifre
        '
        Me.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSifre.Location = New System.Drawing.Point(253, 147)
        Me.TxtSifre.Name = "TxtSifre"
        Me.TxtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSifre.Size = New System.Drawing.Size(148, 20)
        Me.TxtSifre.TabIndex = 1
        '
        'BtnGiris
        '
        Me.BtnGiris.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnGiris.Location = New System.Drawing.Point(253, 225)
        Me.BtnGiris.Name = "BtnGiris"
        Me.BtnGiris.Size = New System.Drawing.Size(148, 29)
        Me.BtnGiris.TabIndex = 4
        Me.BtnGiris.Text = "Giriş Yap"
        Me.BtnGiris.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(221, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Beni Hatırla"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LblCikis
        '
        Me.LblCikis.AutoSize = True
        Me.LblCikis.BackColor = System.Drawing.Color.DarkRed
        Me.LblCikis.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblCikis.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCikis.Location = New System.Drawing.Point(442, 0)
        Me.LblCikis.Name = "LblCikis"
        Me.LblCikis.Size = New System.Drawing.Size(25, 28)
        Me.LblCikis.TabIndex = 8
        Me.LblCikis.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(52, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "KULLANICI GİRİŞ EKRANI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "1234"
        '
        'frmKullanici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(467, 265)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCikis)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnGiris)
        Me.Controls.Add(Me.TxtSifre)
        Me.Controls.Add(Me.TxtKullaniciAdi)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKullanici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Giriş"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TxtKullaniciAdi As TextBox
    Friend WithEvents TxtSifre As TextBox
    Friend WithEvents BtnGiris As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LblCikis As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
