Public Class Form3

    Private claseusuarios As Usuarios
    Private clasepoliza As Poliza
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        claseusuarios = New Usuarios
        claseusuarios.VerificarRol()
        ''verifica el rol del usuario
        If claseusuarios.RolUser = "user" Then
            Btn_Editar.Visible = False
            Btn_Confirmar.Visible = False
        End If
        ''ingresa en los textbox, los datos correspondientes a la busqueda del usuario
        clasepoliza = New Poliza
        clasepoliza.DatosVeh()
        Txt_Vehiculo.Text = (clasepoliza.ModeloVeh)
        Txt_Año.Text = (clasepoliza.AñoVeh)
        Txt_Patente.Text = (clasepoliza.PatenteVeh)
        Txt_Motor.Text = (clasepoliza.MotorVeh)
        Txt_Chasis.Text = (clasepoliza.ChasisVeh)
        Txt_Suma.Text = (clasepoliza.SumaVeh)
        Txt_Uso.Text = (clasepoliza.UsoVeh)

        clasepoliza.DatosCliente()
        TxtNombre.Text = (clasepoliza.NombreCliente)
        Txt_Apellido.Text = (clasepoliza.ApellidoCliente)
        Txt_Direc.Text = (clasepoliza.DireccionCliente)
        Txt_Zona.Text = (clasepoliza.ZonaCliente)
        Txt_Num.Text = (clasepoliza.TelCliente)
        Txt_Dni.Text = (clasepoliza.DniCliente)

        clasepoliza.DatosPol()
        Txt_NumPol.Text = (clasepoliza.NumPoliza)
        Txt_Vigencia.Text = (clasepoliza.VigPoliza)
        Txt_Plan.Text = (clasepoliza.PlanPoliza)
        Txt_Costo.Text = (clasepoliza.CostoPoliza)

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Btn_Editar.Visible = False
        Btn_Confirmar.Visible = True

        For Each panel As Panel In Me.Controls.OfType(Of Panel)()
            For Each txt As TextBox In panel.Controls.OfType(Of TextBox)()
                txt.Enabled = True

            Next
        Next

        Txt_NumPol.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Confirmar.Click
        clasepoliza.EditarPoliza()

    End Sub

End Class