Imports Logica

Public Class EliminarContrata
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ControladorContrata.Eliminar(txtIDPersona.Text)

    End Sub
End Class

