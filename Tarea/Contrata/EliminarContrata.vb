Imports Logica

Public Class EliminarContrata
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            ControladorContrata.Eliminar(txtIDPersona.Text)
            MsgBox("Eliminado con exito!")
        Catch ex As Exception
            MsgBox("Error al eliminar")
        End Try


    End Sub
End Class

