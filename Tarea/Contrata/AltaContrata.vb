Imports Logica

Public Class AltaContrata

    Private Sub btnDarAlta_Click_1(sender As Object, e As EventArgs) Handles btnDarAlta.Click
        Try
            ControladorContrata.Alta(txtIDPersona.Text, txtIDServicio.Text, txtFechaCreacion.Text, txtFechaContratacion.Text, txtFechaFinContrato.Text)
            MsgBox("Alta exitosa")
        Catch ex As Exception
            MsgBox("Error al dar el alta")
        End Try



    End Sub


End Class