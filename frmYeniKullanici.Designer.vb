<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYeniKullanici
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
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.txtCevap = New System.Windows.Forms.TextBox()
        Me.txtSoru = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(55, 217)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 27)
        Me.btnEkle.TabIndex = 6
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'btnIptal
        '
        Me.btnIptal.Location = New System.Drawing.Point(150, 217)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(75, 27)
        Me.btnIptal.TabIndex = 7
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'txtCevap
        '
        Me.txtCevap.Location = New System.Drawing.Point(115, 162)
        Me.txtCevap.Name = "txtCevap"
        Me.txtCevap.PlaceholderText = "Cevabı giriniz"
        Me.txtCevap.Size = New System.Drawing.Size(141, 23)
        Me.txtCevap.TabIndex = 5
        '
        'txtSoru
        '
        Me.txtSoru.Location = New System.Drawing.Point(115, 134)
        Me.txtSoru.Name = "txtSoru"
        Me.txtSoru.PlaceholderText = "Soruyu giriniz"
        Me.txtSoru.Size = New System.Drawing.Size(141, 23)
        Me.txtSoru.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Cevap :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Soru :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Adı Soyadı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Şifre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kullanıcı Adı : "
        '
        'txtAdiSoyadi
        '
        Me.txtAdiSoyadi.Location = New System.Drawing.Point(115, 106)
        Me.txtAdiSoyadi.Name = "txtAdiSoyadi"
        Me.txtAdiSoyadi.PlaceholderText = "Adınız Soyadınız"
        Me.txtAdiSoyadi.Size = New System.Drawing.Size(141, 23)
        Me.txtAdiSoyadi.TabIndex = 3
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(115, 78)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.PlaceholderText = "Şifreniz"
        Me.txtSifre.Size = New System.Drawing.Size(141, 23)
        Me.txtSifre.TabIndex = 2
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(115, 50)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adınız"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(141, 23)
        Me.txtKullaniciAdi.TabIndex = 1
        '
        'frmYeniKullanici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 268)
        Me.Controls.Add(Me.txtCevap)
        Me.Controls.Add(Me.txtSoru)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAdiSoyadi)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnEkle)
        Me.Name = "frmYeniKullanici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeni Kullanıcı Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents txtCevap As TextBox
    Friend WithEvents txtSoru As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdiSoyadi As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents txtKullaniciAdi As TextBox
End Class
