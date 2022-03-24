Imports System.Data.SqlClient

Public Class Kullanici

    Dim baglanti As New SqlConnection("Data Source=Baysal;Initial Catalog=stokvb;Integrated Security=True")

    Private _kullaniciadi As String
    Private _sifre As String

    Public Property KullaniciAdi() As String
        Get
            Return _kullaniciadi

        End Get
        Set(value As String)
            _kullaniciadi = value
        End Set
    End Property

    Public Property Sifre() As String
        Get
            Return _sifre


        End Get
        Set(value As String)
            _sifre = value
        End Set
    End Property

    Sub KullaniciGirisi(Kadi As String, Password As String)
        KullaniciAdi = Kadi
        Sifre = Password

        If KullaniciAdi = "" Or Sifre = "" Then
            MessageBox.Show("Bilgilerinizi kontrol ediniz!!!", "Uyarı-1")
        Else
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
                frmKullaniciGirisi.temizle()

            End If
            Dim komut As New SqlCommand("select *from Kullanici where kullaniciadi='" & KullaniciAdi & "'", baglanti)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                If reader(1) = Sifre Then
                    frmKullaniciGirisi.Hide()
                    frmAnasayfa.Show()
                    frmKullaniciGirisi.temizle()

                Else
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı-2")
                End If
            Else
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı-2")
            End If
            baglanti.Close()
        End If
    End Sub
    Sub YeniKullanici(kadi As String, password As String, adiSoyadi As String, soru As String, cevap As String, tarih As String)
        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If
            Dim komut As New SqlCommand("insert into Kullanici values('" & kadi & "','" & password & "','" & adiSoyadi & "','" & soru & "','" & cevap & "','" & tarih & "')", baglanti)
            If kadi = " " Or password = " " Or adiSoyadi = " " Or soru = " " Or cevap = " " Then
                MessageBox.Show("Bilgilerinizi kontrol ediniz.")
            Else
                komut.ExecuteNonQuery()
                baglanti.Close()
                MessageBox.Show("Yeni Kullanıcı eklendi", "Kayıt")
                frmYeniKullanici.temizle()
            End If
        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir kullanıcı adı mevcuttur!!!", "Uyarı")
        End Try

    End Sub
    Sub SifremiUnuttum(kadi As String, password As String, passwordAgain As String, adiSoyadi As String, soru As String, cevap As String, tarih As String)
        If password = passwordAgain Then
            baglanti.Open()
            Dim komut As New SqlCommand("select *from Kullanici where KullaniciAdi='" & kadi & "' and soru='" & soru & "' and cevap='" & cevap & "'", baglanti)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                baglanti.Close()
                baglanti.Open()
                Dim komut2 As New SqlCommand("update Kullanici set sifre='" & password & "',adisoyadi='" & adiSoyadi & "', tarih='" & tarih & "' where kullaniciadi='" & kadi & "'", baglanti)
                komut2.ExecuteNonQuery()
                baglanti.Close()
                frmSifremiUnuttum.Temizle()
                MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Başarılı")
                frmSifremiUnuttum.Close()
            Else
                baglanti.Close()
                MessageBox.Show("Bilgilerinizi kontrol ediniz.!!!", "Uyarı-2")
            End If
            baglanti.Close()
        Else
            MessageBox.Show("Şifreler uyuşmuyor!!!", "Uyarı")
        End If
    End Sub
End Class
