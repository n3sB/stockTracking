<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSifremiUnuttum
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtSifreTekrar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoru = New System.Windows.Forms.TextBox()
        Me.txtCevap = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIptal
        '
        Me.btnIptal.Location = New System.Drawing.Point(147, 231)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(75, 27)
        Me.btnIptal.TabIndex = 8
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Location = New System.Drawing.Point(66, 231)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(75, 27)
        Me.btnGuncelle.TabIndex = 7
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Adı Soyadı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Şifre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kullanıcı Adı : "
        '
        'txtAdiSoyadi
        '
        Me.txtAdiSoyadi.Location = New System.Drawing.Point(117, 70)
        Me.txtAdiSoyadi.Name = "txtAdiSoyadi"
        Me.txtAdiSoyadi.PlaceholderText = "Adınız Soyadınız"
        Me.txtAdiSoyadi.Size = New System.Drawing.Size(141, 23)
        Me.txtAdiSoyadi.TabIndex = 2
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(117, 151)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.PlaceholderText = "Şifreniz"
        Me.txtSifre.Size = New System.Drawing.Size(141, 23)
        Me.txtSifre.TabIndex = 5
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(117, 43)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adınız"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(141, 23)
        Me.txtKullaniciAdi.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(28, 181)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(70, 15)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Şifre Tekrar :"
        '
        'txtSifreTekrar
        '
        Me.txtSifreTekrar.Location = New System.Drawing.Point(117, 178)
        Me.txtSifreTekrar.Name = "txtSifreTekrar"
        Me.txtSifreTekrar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifreTekrar.PlaceholderText = "Şifrenizi tekrar giriniz"
        Me.txtSifreTekrar.Size = New System.Drawing.Size(141, 23)
        Me.txtSifreTekrar.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Soru :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cevap :"
        '
        'txtSoru
        '
        Me.txtSoru.Location = New System.Drawing.Point(117, 97)
        Me.txtSoru.Name = "txtSoru"
        Me.txtSoru.PlaceholderText = "Soruyu giriniz"
        Me.txtSoru.Size = New System.Drawing.Size(141, 23)
        Me.txtSoru.TabIndex = 3
        '
        'txtCevap
        '
        Me.txtCevap.Location = New System.Drawing.Point(117, 124)
        Me.txtCevap.Name = "txtCevap"
        Me.txtCevap.PlaceholderText = "Cevabı giriniz"
        Me.txtCevap.Size = New System.Drawing.Size(141, 23)
        Me.txtCevap.TabIndex = 4
        '
        'frmSifremiUnuttum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(282, 301)
        Me.Controls.Add(Me.txtCevap)
        Me.Controls.Add(Me.txtSoru)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtSifreTekrar)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAdiSoyadi)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Name = "frmSifremiUnuttum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Şifremi Unuttum Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIptal As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdiSoyadi As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents label6 As Label
    Friend WithEvents txtSifreTekrar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoru As TextBox
    Friend WithEvents txtCevap As TextBox
End Class
