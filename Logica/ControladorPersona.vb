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

        Dim p As New Persona
        p.Id = id
        p.Borrar()

    End Sub

    Public Function Listar()

        Dim p As New Persona
        Return p.Listar()

    End Function

    Public Sub Modificar(id As String, nombre As String, apellido As String, mail As String, fechahoracreacion As String, activo As Boolean)

        Dim p As New Persona
        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail
        p.FechaHoraCreacion = fechahoracreacion
        p.Activo = activo

        p.Modificar()
    End Sub

    Public Sub ModificarTel(id As String, telefono As String)

        Dim p As New Persona
        p.Id = id
        p.Telefono = telefono

        p.ModificarTel()

    End Sub

    Public Function ObtenerCantidad()

        Dim p As New Persona
        Return p.Contar()

    End Function

End Module
