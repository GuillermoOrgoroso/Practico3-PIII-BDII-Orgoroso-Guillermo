Imports Logica
Public Class ListarContrata
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim tabla As New DataTable

            tabla.Load(ControladorContrata.Listar())
            DataListar.DataSource = tabla
        Catch ex As Exception
            MsgBox("Error al listar")
        End Try


    End Sub
End Class