Imports Logica
Public Class ModificarPersona
    Dim activo As Boolean
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInactivo.CheckedChanged
        activo = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ControladorPersona.Modificar(txtCi.Text, txtNombre.Text, txtApellido.Text, txtMail.Text, txtFechaHoraCreacion.Text, activo)

    End Sub

    Private Sub rdoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoActivo.CheckedChanged
        activo = True
    End Sub
End Class