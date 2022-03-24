Public Class frmKullaniciGirisi
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCikis.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUyeOl.Click
        frmYeniKullanici.ShowDialog()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
    Dim K As New Kullanici
    Sub temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        K.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text)

    End Sub

    Private Sub linklblSifremiUnuttum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblSifremiUnuttum.LinkClicked
        frmSifremiUnuttum.ShowDialog()

    End Sub

    Private Sub txtSifre_TextChanged(sender As Object, e As EventArgs) Handles txtSifre.TextChanged

    End Sub

    Private Sub txtKullaniciAdi_Click(sender As Object, e As EventArgs)
        txtKullaniciAdi.Text = " "
    End Sub

    Private Sub frmKullaniciGirisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
