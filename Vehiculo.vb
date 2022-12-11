Imports System.Data.SqlClient

Public Class Vehiculo
    Inherits Cliente
    Dim modelo As String
    Dim año As Integer
    Dim patente As String
    Dim chasis As String
    Dim suma As Decimal
    Dim motor As String
    Dim uso As String
    Dim conex As Conexion

    Public Property ModeloVeh As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property
    Public Property AñoVeh As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property

    Public Property PatenteVeh As String
        Get
            Return patente
        End Get
        Set(value As String)
            patente = value
        End Set
    End Property
    Public Property ChasisVeh As String
        Get
            Return chasis
        End Get
        Set(value As String)
            chasis = value
        End Set
    End Property
    Public Property SumaVeh As Decimal
        Get
            Return suma
        End Get
        Set(value As Decimal)
            suma = value
        End Set
    End Property
    Public Property MotorVeh As String
        Get
            Return motor
        End Get
        Set(value As String)
            motor = value
        End Set
    End Property
    Public Property UsoVeh As String
        Get
            Return uso
        End Get
        Set(value As String)
            uso = value
        End Set
    End Property
    Public Sub VerificarIngreso() ''verifica que la patente ingresada por el usuario, corresponda a la de un vehiculo registrado
        Try
            conex = New Conexion()
            conex.miConexion.Open()
            Dim patenteuser As String = Form2.Txt_Buscador.Text
            Dim comando As New SqlCommand("verificarpatente", conex.miConexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patente", patenteuser)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()
                If .Parameters("@result").Value = 1 Then

                    Form3.Show()
                    Form2.Hide()

                Else
                    MsgBox("La patente ingresada no corresponde a ninguna poliza")
                End If
            End With



        Catch ex As Exception
            MsgBox("Hubo un error durante la verificacion de la patente" & ex.Message)
        End Try

    End Sub
    Public Sub DatosVeh() ''obtiene los datos del vehiculo que corresponda a la patente ingresada
        Try
            conex = New Conexion()
            conex.miConexion.Open()
            Dim patenteuser As String = Form2.Txt_Buscador.Text
            Dim resultado As SqlDataReader
            Dim comando As New SqlCommand("datosvehiculo", conex.miConexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patente", patenteuser)
                resultado = .ExecuteReader()
                resultado.Read()

                modelo = resultado.GetValue(0)
                año = resultado.GetValue(1)
                patente = resultado.GetValue(2)
                chasis = resultado.GetValue(3)
                suma = resultado.GetValue(4)
                motor = resultado.GetValue(5)
                uso = resultado.GetValue(6)
            End With

        Catch ex As Exception
            MsgBox("Hubo un error al obtener los datos del vehiculo" & ex.Message)
        End Try


    End Sub
End Class
