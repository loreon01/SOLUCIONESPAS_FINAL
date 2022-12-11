Public Class Form5
    Dim clasepoliza As Poliza
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clasepoliza = New Poliza
        clasepoliza.AgregarPoliza()
    End Sub
End Class