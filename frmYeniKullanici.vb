Public Class frmYeniKullanici
    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()

    End Sub
    Dim K As New Kullanici
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        K.YeniKullanici(txtKullaniciAdi.Text, txtSifre.Text, txtAdiSoyadi.Text, txtSoru.Text, txtCevap.Text, DateTime.Now.ToShortDateString)
        Me.Close()
    End Sub
    Sub temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub frmYeniKullanici_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSoru.TextChanged

    End Sub
End Class