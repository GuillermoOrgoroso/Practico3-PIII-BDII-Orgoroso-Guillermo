Imports Logica

Public Class AltaContrata

    Private Sub btnDarAlta_Click_1(sender As Object, e As EventArgs) Handles btnDarAlta.Click

        ControladorContrata.Alta(txtIDPersona.Text, txtIDServicio.Text, txtFechaCreacion.Text, txtFechaContratacion.Text, txtFechaFinContrato.Text)


    End Sub


End Class