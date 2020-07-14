Public Class Main
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim ventanaAlta As New AltaServicio
        ventanaAlta.Show()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        Dim ventanaBaja As New EliminarServicio
        ventanaBaja.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim ventanaModificar As New ModificarServicio
        ventanaModificar.Show()

    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Dim ventanaListar As New ListarServicio
        ventanaListar.Show()

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        Dim ventanaAlta As New AltaPersona
        ventanaAlta.Show()

    End Sub

    Private Sub BajaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem1.Click
        Dim ventanaBaja As New EliminarPersona
        ventanaBaja.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        Dim ventanaModificar As New ModificarPersona
        ventanaModificar.Show()

    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        Dim ventanaListar As New ListarPersona
        ventanaListar.Show()

    End Sub

    Private Sub AltaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem2.Click
        Dim ventanaAlta As New AltaContrata
        ventanaAlta.Show()

    End Sub

    Private Sub BajaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem2.Click
        Dim ventanaBaja As New EliminarContrata
        ventanaBaja.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem2.Click
        Dim ventanaModificar As New ModificarContrata
        ventanaModificar.Show()

    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem2.Click
        Dim ventanaListar As New ListarContrata
        ventanaListar.show()

    End Sub
End Class
