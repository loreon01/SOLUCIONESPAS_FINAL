Public Class Form4
    Private claseusuarios As Usuarios
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        claseusuarios = New Usuarios
        claseusuarios.AgregarUsuario()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class