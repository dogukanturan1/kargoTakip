<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKategori))
        Me.TxtKategori = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnIptal = New System.Windows.Forms.Button()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtKategori
        '
        Me.TxtKategori.Location = New System.Drawing.Point(193, 50)
        Me.TxtKategori.Name = "TxtKategori"
        Me.TxtKategori.Size = New System.Drawing.Size(169, 27)
        Me.TxtKategori.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(89, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Kategori:"
        '
        'BtnIptal
        '
        Me.BtnIptal.Image = CType(resources.GetObject("BtnIptal.Image"), System.Drawing.Image)
        Me.BtnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIptal.Location = New System.Drawing.Point(272, 109)
        Me.BtnIptal.Name = "BtnIptal"
        Me.BtnIptal.Size = New System.Drawing.Size(90, 38)
        Me.BtnIptal.TabIndex = 48
        Me.BtnIptal.UseVisualStyleBackColor = True
        '
        'BtnEkle
        '
        Me.BtnEkle.Image = CType(resources.GetObject("BtnEkle.Image"), System.Drawing.Image)
        Me.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEkle.Location = New System.Drawing.Point(167, 109)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(90, 38)
        Me.BtnEkle.TabIndex = 47
        Me.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'frmKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(450, 206)
        Me.Controls.Add(Me.BtnIptal)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.TxtKategori)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori Ekleme Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKategori As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnIptal As Button
    Friend WithEvents BtnEkle As Button
End Class
