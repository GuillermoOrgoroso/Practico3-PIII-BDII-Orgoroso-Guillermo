Imports Fisica
Public Module ControladorPersona
    Public Sub DarAlta(id As String, nombre As String, apellido As String, mail As String, fechahoracreacion As String, activo As Boolean, telefono As String)

        Dim p As New Persona
            p.Id = id
            p.Nombre = nombre
            p.Apellido = apellido
            p.Mail = mail
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo
            p.Telefono = telefono
            p.Guardar()


    End Sub

    Public Sub DarBaja(id As String)
        Try
            Dim p As New Persona
            p.Id = id
            p.Borrar()
            MsgBox("Eliminado con exito")

        Catch ex As Exception
            MsgBox("Error al intentar dar la baja")

        End Try


    End Sub

    Public Function Listar()
        Try
            Dim p As New Persona
            Return p.Listar()
        Catch ex As Exception
            MsgBox("Error al listar")

        End Try
        Return -1

    End Function

    Public Sub Modificar(id As String, nombre As String, apellido As String, mail As String, fechahoracreacion As String, activo As Boolean)
        Try
            Dim p As New Persona
            p.Id = id
            p.Nombre = nombre
            p.Apellido = apellido
            p.Mail = mail
            p.FechaHoraCreacion = fechahoracreacion
            p.Activo = activo

            p.Modificar()
            MsgBox("Modificado con exito")
        Catch ex As Exception
            MsgBox("Error al modificar")
        End Try


    End Sub

    Public Sub ModificarTel(id As String, telefono As String)
        Try
            Dim p As New Persona
            p.Id = id
            p.Telefono = telefono

            p.ModificarTel()

            MsgBox("Telefono modificado con exito")
        Catch ex As Exception
            MsgBox("Error al modificar telefono")
        End Try


    End Sub

    Public Function ObtenerCantidad()

        Dim p As New Persona
        Return p.Contar()

    End Function

End Module
