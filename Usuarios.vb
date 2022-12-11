Imports System.Data.SqlClient

Public Class Usuarios
    Dim conex As Conexion
    Public rol As String


    Public Property RolUser As String
        Get
            Return rol
        End Get
        Set(value As String)
            rol = value
        End Set
    End Property


    Public Sub Login() ''verifica que el usuario y la contraseña ingresados son correctos

        Try
            conex = New Conexion()
            conex.miConexion.Open()
            Dim Usuario As String = Form1.Txt_User.Text
            Dim contraseña As String = Form1.Txt_Pass.Text
            Dim comando As New SqlCommand("loginsolucionespas", conex.miConexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user", Usuario)
                .Parameters.AddWithValue("@pass", contraseña)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()
                If CInt(.Parameters("@result").Value = 1) Then
                    Form1.Hide()
                    Form2.Show()

                Else
                    MsgBox("El usuario o la contraseña son incorrectos")
                End If
            End With

        Catch ex As Exception
            MsgBox("Hubo un error durante el login" & ex.Message)
        End Try

    End Sub

    Public Sub VerificarRol() ''verifica el rol del usuario (admin o usuario)

        Try
            conex = New Conexion()
            conex.miConexion.Open()
            Dim Usuario As String = Form1.Txt_User.Text
            Dim resultado As SqlDataReader
            Dim comando As New SqlCommand("verificarrol", conex.miConexion)
            conex = New Conexion()
            conex.miConexion.Open()
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user", Usuario)

                .ExecuteScalar()
                resultado = comando.ExecuteReader()
                resultado.Read()
                If resultado.GetInt32(0) = 1 Then
                    rol = "admin"
                Else
                    rol = "user"
                End If

            End With
        Catch ex As Exception
            MsgBox("Hubo un error al verificar el rol " & ex.Message)
        End Try
    End Sub

    Public Sub AgregarUsuario() ''se encarga de ingresar los usuarios nuevos a la base de datos
        Dim Usuario As String = Form4.Txt_User.Text
        Dim contraseña As String = Form4.Txt_Pass.Text
        Dim nombre As String = Form4.Txt_Nombre.Text
        Dim apellido As String = Form4.Txt_Apellido.Text
        If nombre = "" Or apellido = "" Or Usuario = "" Or contraseña = "" Then
            MsgBox("No deje ningun campo vacio")
        Else
            Try
                conex = New Conexion()
                conex.miConexion.Open()

                Dim comando As New SqlCommand("agregarusuario", conex.miConexion)
                Dim role As Integer
                If Form4.AdminCheck.Checked = True Then
                    role = 1
                Else
                    role = 0
                End If
                conex = New Conexion()
                conex.miConexion.Open()
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@user", Usuario)
                    .Parameters.AddWithValue("@pass", contraseña)
                    .Parameters.AddWithValue("@rol", role)
                    .Parameters.AddWithValue("@name", nombre)
                    .Parameters.AddWithValue("@lastname", apellido)
                    .Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output
                    .ExecuteScalar()
                End With
                MsgBox("El usuario se ingreso con exito")
            Catch ex As Exception
                MsgBox("Hubo un error al ingresar usuario " & ex.Message)
            End Try
        End If

    End Sub
End Class
