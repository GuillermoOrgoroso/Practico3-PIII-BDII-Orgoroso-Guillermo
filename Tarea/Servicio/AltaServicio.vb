Imports Logica
Public Class AltaServicio
    Dim tipo As String
    Dim activo As Boolean = False
    Private Sub btnDarAlta_Click(sender As Object, e As EventArgs) Handles btnDarAlta.Click
        ControladorServiciovb.DarAlta(txtIDServicio.Text, txtNombre.Text, txtCostoMensual.Text, txtFechoYhora.Text, tipo, activo)

    End Sub

    Private Sub rdoLimpieza_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLimpieza.CheckedChanged
        tipo = "Limpieza"

    End Sub

    Private Sub rdoMantenimiento_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMantenimiento.CheckedChanged
        tipo = "Mantenimiento"
    End Sub

    Private Sub rdoElectricidad_CheckedChanged(sender As Object, e As EventArgs) Handles rdoElectricidad.CheckedChanged
        tipo = "Electricidad"
    End Sub

    Private Sub rdoTelecomunicaciones_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTelecomunicaciones.CheckedChanged
        tipo = "Telecomunicaciones"
    End Sub

    Private Sub rdoInformatica_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInformatica.CheckedChanged
        tipo = "Informatica"
    End Sub



    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        activo = True
    End Sub
End Class