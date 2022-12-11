Imports System.Data.SqlClient
Public Class Poliza
    Inherits Vehiculo
    Dim conex As Conexion
    Dim numero As String
    Dim vigencia As String
    Dim plan As String
    Dim costo As Integer


    Public Property NumPoliza As String
        Get
            Return numero
        End Get
        Set(value As String)
            numero = value
        End Set
    End Property
    Public Property VigPoliza As String
        Get
            Return vigencia
        End Get
        Set(value As String)
            vigencia = value
        End Set
    End Property

    Public Property PlanPoliza As String
        Get
            Return plan
        End Get
        Set(value As String)
            plan = value
        End Set
    End Property
    Public Property CostoPoliza As Integer
        Get
            Return costo
        End Get
        Set(value As Integer)
            costo = value
        End Set
    End Property

    Public Sub DatosPol() ''obtiene los datos de la poliza que corresponda a la patente ingresada
        Try
            conex = New Conexion()
            conex.miConexion.Open()
            Dim patenteuser As String = Form2.Txt_Buscador.Text
            Dim resultado As SqlDataReader
            Dim comando As New SqlCommand("datospoliza", conex.miConexion)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patente", patenteuser)
                resultado = .ExecuteReader()
                resultado.Read()

                numero = resultado.GetValue(0)
                vigencia = resultado.GetValue(1)
                plan = resultado.GetValue(2)
                costo = resultado.GetValue(3)

            End With

        Catch ex As Exception
            MsgBox("Hubo un error al obtener los datos de la poliza" & ex.Message)
        End Try


    End Sub

    Public Sub AgregarPoliza()
        conex = New Conexion()
        conex.miConexion.Open()
        Dim nombre As String = Form5.TxtNombre.Text
        Dim direccion As String = Form5.Txt_Direc.Text
        Dim chasis As String = Form5.Txt_Chasis.Text
        Dim costo As Single
        costo = Val(Form5.Txt_Costo.Text)
        Dim dni As String = Form5.Txt_Dni.Text

        Dim motor As String = Form5.Txt_Motor.Text
        Dim telefono As String = Form5.Txt_Num.Text
        Dim numpoliza As String = Form5.Txt_NumPol.Text
        Dim plan As String = Form5.Txt_Plan.Text
        Dim modelo As String = Form5.Txt_Vehiculo.Text
        Dim año As Single
        año = Val(Form5.Txt_Año.Text)

        Dim apellido As String = Form5.Txt_Apellido.Text
        Dim vigencia As String = Form5.Txt_Vigencia.Text
        Dim uso As String = Form5.Txt_Uso.Text
        Dim suma As Single
        suma = Val(Form5.Txt_Suma.Text)
        Dim zona As String = Form5.Txt_Zona.Text
        Dim patente As String = Form5.Txt_Patente.Text

        If nombre = "" Or apellido = "" Or direccion = "" Or chasis = "" Or costo = 0 Or dni = "" Or motor = "" Or telefono = "" Or numpoliza = "" Or plan = "" Or modelo = "" Or año = 0 Or vigencia = "" Or uso = "" Or suma = 0 Or zona = "" Or patente = "" Then
            MsgBox("No deje campos vacios")
        Else
            Try


                Dim comando As New SqlCommand("agregarpoliza", conex.miConexion)
                conex = New Conexion()
                conex.miConexion.Open()
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@nombre", nombre)
                    .Parameters.AddWithValue("@direccion", direccion)
                    .Parameters.AddWithValue("@chasis", chasis)
                    .Parameters.AddWithValue("@costo", costo)
                    .Parameters.AddWithValue("@dni", dni)
                    .Parameters.AddWithValue("@telefono", telefono)
                    .Parameters.AddWithValue("@numpoliza", numpoliza)
                    .Parameters.AddWithValue("@plan", plan)
                    .Parameters.AddWithValue("@modelo", modelo)
                    .Parameters.AddWithValue("@año", año)
                    .Parameters.AddWithValue("@apellido", apellido)
                    .Parameters.AddWithValue("@suma", suma)
                    .Parameters.AddWithValue("@vigencia", vigencia)
                    .Parameters.AddWithValue("@patente", patente)
                    .Parameters.AddWithValue("@zona", zona)
                    .Parameters.AddWithValue("@uso", uso)
                    .Parameters.AddWithValue("@motor", motor)
                    .Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                End With
                MsgBox("La poliza se ingreso con exito")
            Catch ex As Exception
                MsgBox("Hubo un error al ingresar poliza ")
            End Try
        End If


    End Sub
    Public Sub EditarPoliza()

        conex = New Conexion()
        conex.miConexion.Open()
        Dim nombre As String = Form3.TxtNombre.Text
        Dim direccion As String = Form3.Txt_Direc.Text
        Dim chasis As String = Form3.Txt_Chasis.Text
        Dim costo As Single
        costo = Val(Form3.Txt_Costo.Text)
        Dim dni As String = Form3.Txt_Dni.Text

        Dim motor As String = Form3.Txt_Motor.Text
        Dim telefono As String = Form3.Txt_Num.Text
        Dim numpoliza As String = Form3.Txt_NumPol.Text
        Dim plan As String = Form3.Txt_Plan.Text
        Dim modelo As String = Form3.Txt_Vehiculo.Text
        Dim año As Single
        año = Val(Form3.Txt_Año.Text)

        Dim apellido As String = Form3.Txt_Apellido.Text
        Dim vigencia As String = Form3.Txt_Vigencia.Text
        Dim uso As String = Form3.Txt_Uso.Text
        Dim suma As Single
        suma = Val(Form3.Txt_Suma.Text)
        Dim zona As String = Form3.Txt_Zona.Text
        Dim patente As String = Form3.Txt_Patente.Text
        If nombre = "" Or apellido = "" Or direccion = "" Or chasis = "" Or costo = 0 Or dni = "" Or motor = "" Or telefono = "" Or numpoliza = "" Or plan = "" Or modelo = "" Or año = 0 Or vigencia = "" Or uso = "" Or suma = 0 Or zona = "" Or patente = "" Then
            MsgBox("No deje campos vacios")
        Else
            Try

                Dim comando As New SqlCommand("editarpoliza", conex.miConexion)
                conex = New Conexion()
                conex.miConexion.Open()
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@nombre", nombre)
                    .Parameters.AddWithValue("@direccion", direccion)
                    .Parameters.AddWithValue("@chasis", chasis)
                    .Parameters.AddWithValue("@costo", costo)
                    .Parameters.AddWithValue("@dni", dni)
                    .Parameters.AddWithValue("@telefono", telefono)
                    .Parameters.AddWithValue("@numpoliza", numpoliza)
                    .Parameters.AddWithValue("@plan", plan)
                    .Parameters.AddWithValue("@modelo", modelo)
                    .Parameters.AddWithValue("@año", año)
                    .Parameters.AddWithValue("@apellido", apellido)
                    .Parameters.AddWithValue("@suma", suma)
                    .Parameters.AddWithValue("@vigencia", vigencia)
                    .Parameters.AddWithValue("@patente", patente)
                    .Parameters.AddWithValue("@zona", zona)
                    .Parameters.AddWithValue("@uso", uso)
                    .Parameters.AddWithValue("@motor", motor)
                    .ExecuteNonQuery()
                    MsgBox("La poliza se edito con exito!")
                    For Each panel As Panel In Form3.Controls.OfType(Of Panel)()
                        For Each txt As TextBox In panel.Controls.OfType(Of TextBox)()
                            txt.Enabled = False
                            Form3.Btn_Confirmar.Visible = False
                            Form3.Btn_Editar.Visible = True
                        Next
                    Next
                End With
            Catch ex As Exception
                MsgBox("Hubo un error al editar la poliza", ex.Message)
            End Try
        End If



    End Sub

End Class
