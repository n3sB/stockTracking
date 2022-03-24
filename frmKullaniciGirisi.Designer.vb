<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKullaniciGirisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKullaniciGirisi))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.linklblSifremiUnuttum = New System.Windows.Forms.LinkLabel()
        Me.lblCikis = New System.Windows.Forms.Label()
        Me.lblUyeOl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(270, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(270, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.AccessibleName = ""
        Me.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(310, 72)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adınız"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(150, 16)
        Me.txtKullaniciAdi.TabIndex = 1
        Me.txtKullaniciAdi.Tag = ""
        '
        'txtSifre
        '
        Me.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSifre.Location = New System.Drawing.Point(310, 128)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.PlaceholderText = "Şifreniz"
        Me.txtSifre.Size = New System.Drawing.Size(150, 16)
        Me.txtSifre.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Giriş"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(311, 201)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Beni Hatırla"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'linklblSifremiUnuttum
        '
        Me.linklblSifremiUnuttum.AutoSize = True
        Me.linklblSifremiUnuttum.Location = New System.Drawing.Point(270, 233)
        Me.linklblSifremiUnuttum.Name = "linklblSifremiUnuttum"
        Me.linklblSifremiUnuttum.Size = New System.Drawing.Size(95, 15)
        Me.linklblSifremiUnuttum.TabIndex = 7
        Me.linklblSifremiUnuttum.TabStop = True
        Me.linklblSifremiUnuttum.Text = "Şifremi Unuttum"
        '
        'lblCikis
        '
        Me.lblCikis.AutoSize = True
        Me.lblCikis.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCikis.ForeColor = System.Drawing.Color.Red
        Me.lblCikis.Location = New System.Drawing.Point(477, 9)
        Me.lblCikis.Name = "lblCikis"
        Me.lblCikis.Size = New System.Drawing.Size(27, 30)
        Me.lblCikis.TabIndex = 8
        Me.lblCikis.Text = "X"
        '
        'lblUyeOl
        '
        Me.lblUyeOl.AutoSize = True
        Me.lblUyeOl.Location = New System.Drawing.Point(401, 233)
        Me.lblUyeOl.Name = "lblUyeOl"
        Me.lblUyeOl.Size = New System.Drawing.Size(42, 15)
        Me.lblUyeOl.TabIndex = 8
        Me.lblUyeOl.Text = "Üye Ol"
        '
        'frmKullaniciGirisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 311)
        Me.Controls.Add(Me.lblUyeOl)
        Me.Controls.Add(Me.lblCikis)
        Me.Controls.Add(Me.linklblSifremiUnuttum)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKullaniciGirisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents linklblSifremiUnuttum As LinkLabel
    Friend WithEvents lblCikis As Label
    Friend WithEvents lblUyeOl As Label
End Class
