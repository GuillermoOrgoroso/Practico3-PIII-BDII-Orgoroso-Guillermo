Imports Logica
Public Class ListarServicio
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim tabla As New DataTable

            tabla.Load(ControladorServiciovb.Listar())
            DataListar.DataSource = tabla

        Catch ex As Exception
            MsgBox("Error al listar")
        End Try

    End Sub
End Class