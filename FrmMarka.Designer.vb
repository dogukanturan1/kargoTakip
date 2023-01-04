<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMarka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarka))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMarka = New System.Windows.Forms.TextBox()
        Me.BtnIptal = New System.Windows.Forms.Button()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marka:"
        '
        'TxtMarka
        '
        Me.TxtMarka.Location = New System.Drawing.Point(179, 53)
        Me.TxtMarka.Name = "TxtMarka"
        Me.TxtMarka.Size = New System.Drawing.Size(169, 27)
        Me.TxtMarka.TabIndex = 3
        '
        'BtnIptal
        '
        Me.BtnIptal.Image = CType(resources.GetObject("BtnIptal.Image"), System.Drawing.Image)
        Me.BtnIptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIptal.Location = New System.Drawing.Point(258, 112)
        Me.BtnIptal.Name = "BtnIptal"
        Me.BtnIptal.Size = New System.Drawing.Size(90, 38)
        Me.BtnIptal.TabIndex = 44
        Me.BtnIptal.UseVisualStyleBackColor = True
        '
        'BtnEkle
        '
        Me.BtnEkle.Image = CType(resources.GetObject("BtnEkle.Image"), System.Drawing.Image)
        Me.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEkle.Location = New System.Drawing.Point(153, 112)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(90, 38)
        Me.BtnEkle.TabIndex = 43
        Me.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'FrmMarka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(450, 206)
        Me.Controls.Add(Me.BtnIptal)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.TxtMarka)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMarka"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marka Ekleme Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMarka As TextBox
    Friend WithEvents BtnIptal As Button
    Friend WithEvents BtnEkle As Button
End Class
