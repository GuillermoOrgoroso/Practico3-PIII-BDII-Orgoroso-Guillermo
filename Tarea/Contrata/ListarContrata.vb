Imports Logica
Public Class ListarContrata
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click

        Dim tabla As New DataTable

        tabla.Load(ControladorContrata.Listar())
        DataListar.DataSource = tabla

    End Sub
End Class