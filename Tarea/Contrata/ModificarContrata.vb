Imports Logica
Public Class ModificarContrata
    Private Sub BtnDarAlta_Click(sender As Object, e As EventArgs) Handles BtnDarAlta.Click
        Try
            ControladorContrata.Modificar(txtIDPersona.Text, txtIDServicio.Text, txtFechaCreacion.Text, txtFechaContratacion.Text, txtFechaFinContrato.Text)
            MsgBox("Modificado con exito!")
        Catch ex As Exception
            MsgBox("Error al modificar, intente de nuevo")
        End Try

    End Sub
End Class