Imports Logica
Public Class EliminarPersona
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ControladorPersona.DarBaja(txtIDPersona.Text)

    End Sub
End Class