Imports Fisica

Public Module ControladorServiciovb



    Public Sub DarAlta(id As String, nombre As String, costomensual As String, tipo As String, fechahoracreacion As String, activo As Boolean)

        Dim p As New Servicio

            p.Id = id
            p.Nombre = nombre
            p.CostoMensual = costomensual
            p.Tipo = tipo
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo

            p.Guardar()



    End Sub

    Public Function Listar()

        Dim p As New Servicio
            Return p.listar()


    End Function

    Public Sub Borrar(id As String)

        Dim p As New Servicio
            p.Id = id
            p.Borrar()



    End Sub

    Public Sub Modificar(id As String, nombre As String, costomensual As String, tipo As String, fechahoracreacion As String, activo As Boolean)

        Dim p As New Servicio

            p.Id = id
            p.Nombre = nombre
            p.CostoMensual = costomensual
            p.Tipo = tipo
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo

            p.Modificar()


    End Sub

    Public Function ObtenerCantidad()
        Dim p As New Servicio
        Return p.Contar()
    End Function

End Module
