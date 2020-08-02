Imports Logica
Public Class ListarPersona


    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim tabla As New DataTable

            tabla.Load(ControladorPersona.Listar())
            DataListar.DataSource = tabla
        Catch ex As Exception
            MsgBox("Error al listar")
        End Try

    End Sub

    Private Sub DataListar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListar.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class