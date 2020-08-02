Imports Logica
Public Class EliminarPersona
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ControladorPersona.DarBaja(txtIDPersona.Text)
            MsgBox("Eliminado con exito")
        Catch ex As Exception
            MsgBox("Error al eliminar")
        End Try


    End Sub
End Class