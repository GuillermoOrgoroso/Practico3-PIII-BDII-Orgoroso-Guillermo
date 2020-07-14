Imports Logica
Public Class ModificarContrata
    Private Sub BtnDarAlta_Click(sender As Object, e As EventArgs) Handles BtnDarAlta.Click
        ControladorContrata.Modificar(txtIDPersona.Text, txtIDServicio.Text, txtFechaCreacion.Text, txtFechaContratacion.Text, txtFechaFinContrato.Text)
    End Sub
End Class