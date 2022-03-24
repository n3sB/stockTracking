Public Class frmSifremiUnuttum
    Private Sub txtKullaniciAdi_TextChanged(sender As Object, e As EventArgs) Handles txtKullaniciAdi.TextChanged

    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        K.SifremiUnuttum(txtKullaniciAdi.Text, txtSifre.Text, txtSifreTekrar.Text, txtAdiSoyadi.Text, txtSoru.Text, txtCevap.Text, DateTime.Now.ToShortDateString)

    End Sub
    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
    Dim K As New Kullanici


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSoru.TextChanged

    End Sub

    Private Sub frmSifremiUnuttum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class