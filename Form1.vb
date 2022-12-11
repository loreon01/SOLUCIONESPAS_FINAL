Imports System.Data.SqlClient
Public Class Form1
    Private claseusuarios As Usuarios
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        claseusuarios = New Usuarios
        claseusuarios.Login()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
