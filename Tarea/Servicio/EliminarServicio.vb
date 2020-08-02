Imports Logica
Public Class EliminarServicio
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ControladorServiciovb.Borrar(txtCI.Text)
            MsgBox("Eliminado con exito")

        Catch ex As Exception
            MsgBox("Error al eliminar")
        End Try



    End Sub
End Class