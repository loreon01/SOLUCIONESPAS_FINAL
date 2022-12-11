Imports System.Data.SqlClient
Public Class Cliente
    Dim conex As Conexion
    Dim nombre As String
    Dim apellido As String
    Dim direccion As String
    Dim zona As String
    Dim telefono As String
    Dim dni As String

    Public Property NombreCliente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property ApellidoCliente As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public Property ZonaCliente As String
        Get
            Return zona
        End Get
        Set(value As String)
            zona = value
        End Set
    End Property
    Public Property TelCliente As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property
    Public Property DniCliente As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Sub DatosCliente() ''obtiene los datos del cliente que corresponda a la patente ingresada
        Try
            Dim patenteuser As String = Form2.Txt_Buscador.Text
            conex = New Conexion()
            conex.miConexion.Open()
            Dim resultado As SqlDataReader
            Dim comando As New SqlCommand("datoscliente", conex.miConexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patente", patenteuser)
                resultado = .ExecuteReader()
                resultado.Read()

                nombre = resultado.GetValue(0)
                apellido = resultado.GetValue(1)
                direccion = resultado.GetValue(2)
                zona = resultado.GetValue(3)
                telefono = resultado.GetValue(4)
                dni = resultado.GetValue(5)

            End With

        Catch ex As Exception
            MsgBox("Hubo un error al obtener los datos del cliente" & ex.Message)
        End Try


    End Sub
End Class
