Imports Logica
Public Class EliminarServicio
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ControladorServiciovb.Borrar(txtCI.Text)


    End Sub
End Class