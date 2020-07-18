Imports Fisica

Public Module ControladorServiciovb



    Public Sub DarAlta(id As String, nombre As String, costomensual As String, tipo As String, fechahoracreacion As String, activo As Boolean)
        Try
            Dim p As New Servicio

            p.Id = id
            p.Nombre = nombre
            p.CostoMensual = costomensual
            p.Tipo = tipo
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo

            p.Guardar()
            MsgBox("Alta exitosa")
        Catch ex As Exception
            MsgBox("Error en el alta")

        End Try


    End Sub

    Public Function Listar()
        Try
            Dim p As New Servicio
            Return p.listar()

        Catch ex As Exception
            MsgBox("Error al listar")
        End Try

    End Function

    Public Sub Borrar(id As String)
        Try
            Dim p As New Servicio
            p.Id = id
            p.Borrar()
            MsgBox("Eliminado con exito")
        Catch ex As Exception
            MsgBox("Error al eliminar")
        End Try


    End Sub

    Public Sub Modificar(id As String, nombre As String, costomensual As String, tipo As String, fechahoracreacion As String, activo As Boolean)
        Try
            Dim p As New Servicio

            p.Id = id
            p.Nombre = nombre
            p.CostoMensual = costomensual
            p.Tipo = tipo
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo

            p.Modificar()
            MsgBox("Modificado con exito")
        Catch ex As Exception
            MsgBox("Error al modificar")
        End Try

    End Sub

    Public Function ObtenerCantidad()
        Dim p As New Servicio
        Return p.Contar()
    End Function

End Module
