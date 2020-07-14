Imports Logica
Public Class AltaPersona
    Private Sub btnDarAlta_Click(sender As Object, e As EventArgs) Handles btnDarAlta.Click


        ControladorPersona.DarAlta(txtCi.Text, txtNombre.Text, txtApellido.Text, txtMail.Text, txtFechaHoraCreacion.Text, txtTelefono.Text, Activo)



    End Sub

    Dim Activo As Boolean
    Private Sub rdoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoActivo.CheckedChanged
        Activo = True
    End Sub
End Class