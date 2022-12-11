Public Class Form2
    Private claseusuarios As Usuarios
    Private clasevehiculo As Vehiculo
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        claseusuarios = New Usuarios
        claseusuarios.VerificarRol()
        If claseusuarios.RolUser = "user" Then
            Btn_addpol.Visible = False
            Btn_adduser.Visible = False
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        If Txt_Buscador.Text = "" Then
            MsgBox("Ingrese un valor para continuar")
        Else
            clasevehiculo = New Vehiculo
            clasevehiculo.VerificarIngreso()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_adduser.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_addpol.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Show()

    End Sub

End Class