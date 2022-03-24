<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnasayfa
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
        Me.pnlButtonlar = New System.Windows.Forms.Panel()
        Me.btnUrunListele = New System.Windows.Forms.Button()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÜrünToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünÇıkarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünGüncelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KullanıcıGirişiSayfasıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KullanıcıEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ŞifremiUnuttumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkaEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BirimEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkaSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BirimSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YardımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSayfalar = New System.Windows.Forms.Panel()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlButtonlar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtonlar
        '
        Me.pnlButtonlar.Controls.Add(Me.btnUrunListele)
        Me.pnlButtonlar.Controls.Add(Me.btnEkle)
        Me.pnlButtonlar.Controls.Add(Me.MenuStrip1)
        Me.pnlButtonlar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtonlar.Location = New System.Drawing.Point(0, 0)
        Me.pnlButtonlar.Name = "pnlButtonlar"
        Me.pnlButtonlar.Size = New System.Drawing.Size(1568, 100)
        Me.pnlButtonlar.TabIndex = 0
        '
        'btnUrunListele
        '
        Me.btnUrunListele.Location = New System.Drawing.Point(116, 36)
        Me.btnUrunListele.Name = "btnUrunListele"
        Me.btnUrunListele.Size = New System.Drawing.Size(85, 50)
        Me.btnUrunListele.TabIndex = 2
        Me.btnUrunListele.Text = "Ürün  Listele"
        Me.btnUrunListele.UseVisualStyleBackColor = True
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(12, 36)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(85, 50)
        Me.btnEkle.TabIndex = 1
        Me.btnEkle.Text = "Ürün Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünToolStripMenuItem, Me.KullanıcıGirişiSayfasıToolStripMenuItem, Me.AyarlarToolStripMenuItem, Me.HakkındaToolStripMenuItem, Me.YardımToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1568, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ÜrünToolStripMenuItem
        '
        Me.ÜrünToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünEkleToolStripMenuItem, Me.ÜrünÇıkarToolStripMenuItem, Me.ÜrünGüncelleToolStripMenuItem})
        Me.ÜrünToolStripMenuItem.Name = "ÜrünToolStripMenuItem"
        Me.ÜrünToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ÜrünToolStripMenuItem.Text = "Ürün"
        '
        'ÜrünEkleToolStripMenuItem
        '
        Me.ÜrünEkleToolStripMenuItem.Name = "ÜrünEkleToolStripMenuItem"
        Me.ÜrünEkleToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ÜrünEkleToolStripMenuItem.Text = "Ürün Ekle"
        '
        'ÜrünÇıkarToolStripMenuItem
        '
        Me.ÜrünÇıkarToolStripMenuItem.Name = "ÜrünÇıkarToolStripMenuItem"
        Me.ÜrünÇıkarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ÜrünÇıkarToolStripMenuItem.Text = "Ürün Listele"
        '
        'ÜrünGüncelleToolStripMenuItem
        '
        Me.ÜrünGüncelleToolStripMenuItem.Name = "ÜrünGüncelleToolStripMenuItem"
        Me.ÜrünGüncelleToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ÜrünGüncelleToolStripMenuItem.Text = "Ürün Güncelle"
        '
        'KullanıcıGirişiSayfasıToolStripMenuItem
        '
        Me.KullanıcıGirişiSayfasıToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KullanıcıEkleToolStripMenuItem, Me.ŞifremiUnuttumToolStripMenuItem})
        Me.KullanıcıGirişiSayfasıToolStripMenuItem.Name = "KullanıcıGirişiSayfasıToolStripMenuItem"
        Me.KullanıcıGirişiSayfasıToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.KullanıcıGirişiSayfasıToolStripMenuItem.Text = "Kullanıcı "
        '
        'KullanıcıEkleToolStripMenuItem
        '
        Me.KullanıcıEkleToolStripMenuItem.Name = "KullanıcıEkleToolStripMenuItem"
        Me.KullanıcıEkleToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle"
        '
        'ŞifremiUnuttumToolStripMenuItem
        '
        Me.ŞifremiUnuttumToolStripMenuItem.Name = "ŞifremiUnuttumToolStripMenuItem"
        Me.ŞifremiUnuttumToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ŞifremiUnuttumToolStripMenuItem.Text = "Şifremi Unuttum"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KategoriEkleToolStripMenuItem, Me.MarkaEkleToolStripMenuItem, Me.BirimEkleToolStripMenuItem, Me.KategoriSilToolStripMenuItem, Me.MarkaSilToolStripMenuItem, Me.BirimSilToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'KategoriEkleToolStripMenuItem
        '
        Me.KategoriEkleToolStripMenuItem.Name = "KategoriEkleToolStripMenuItem"
        Me.KategoriEkleToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.KategoriEkleToolStripMenuItem.Text = "Kategori Ekle"
        '
        'MarkaEkleToolStripMenuItem
        '
        Me.MarkaEkleToolStripMenuItem.Name = "MarkaEkleToolStripMenuItem"
        Me.MarkaEkleToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MarkaEkleToolStripMenuItem.Text = "Marka Ekle"
        '
        'BirimEkleToolStripMenuItem
        '
        Me.BirimEkleToolStripMenuItem.Name = "BirimEkleToolStripMenuItem"
        Me.BirimEkleToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BirimEkleToolStripMenuItem.Text = "Birim Ekle"
        '
        'KategoriSilToolStripMenuItem
        '
        Me.KategoriSilToolStripMenuItem.Name = "KategoriSilToolStripMenuItem"
        Me.KategoriSilToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.KategoriSilToolStripMenuItem.Text = "Kategori Sil"
        '
        'MarkaSilToolStripMenuItem
        '
        Me.MarkaSilToolStripMenuItem.Name = "MarkaSilToolStripMenuItem"
        Me.MarkaSilToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MarkaSilToolStripMenuItem.Text = "Marka Sil"
        '
        'BirimSilToolStripMenuItem
        '
        Me.BirimSilToolStripMenuItem.Name = "BirimSilToolStripMenuItem"
        Me.BirimSilToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BirimSilToolStripMenuItem.Text = "Birim Sil"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'YardımToolStripMenuItem
        '
        Me.YardımToolStripMenuItem.Name = "YardımToolStripMenuItem"
        Me.YardımToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.YardımToolStripMenuItem.Text = "Yardım"
        '
        'pnlSayfalar
        '
        Me.pnlSayfalar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSayfalar.Location = New System.Drawing.Point(0, 100)
        Me.pnlSayfalar.Name = "pnlSayfalar"
        Me.pnlSayfalar.Size = New System.Drawing.Size(1568, 537)
        Me.pnlSayfalar.TabIndex = 1
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'frmAnasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1568, 637)
        Me.Controls.Add(Me.pnlSayfalar)
        Me.Controls.Add(Me.pnlButtonlar)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAnasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ana Sayfa Formu"
        Me.pnlButtonlar.ResumeLayout(False)
        Me.pnlButtonlar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlButtonlar As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ÜrünToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünÇıkarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünGüncelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KullanıcıGirişiSayfasıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KullanıcıEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ŞifremiUnuttumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkaEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BirimEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkaSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BirimSilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YardımToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlSayfalar As Panel
    Friend WithEvents btnUrunListele As Button
    Friend WithEvents btnEkle As Button
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
End Class
