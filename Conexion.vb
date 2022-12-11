Imports System.Data.SqlClient
Public Class Conexion
    Public miConexion As New SqlConnection
    Public miComando As New SqlCommand

    Public Sub EjecutarSQL(SentenciaSQL As String)

        miComando.CommandText = SentenciaSQL
        miConexion.Open()
        miComando.ExecuteNonQuery()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()

    End Sub

    Public Sub New()
        miConexion = New SqlConnection() With {
                .ConnectionString = "Data Source=.;Initial Catalog=SolucionesPAS;Integrated Security=True"
        }
    End Sub

End Class
