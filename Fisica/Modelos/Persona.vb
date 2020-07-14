Public Class Persona
    Inherits ModeloConexion

    Public Id As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String
    Public FechaHoraCreacion As String
    Public Activo As Boolean
    Public Telefono As String



    Public Function Contar()
        Me.Comando.CommandText = "SELECT COUNT(*) FROM persona"
        Return Me.Comando.ExecuteScalar().ToString()

    End Function

    Public Sub Guardar()

        Comando.CommandText = "BEGIN WORK;"

        Try
            Comando.CommandText = "INSERT INTO persona VALUES(" + Me.Id + " ','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','" + Me.FechaHoraCreacion + "','" + Me.Activo + ")"
            Comando.ExecuteNonQuery()
            Comando.CommandText = "INSERT INTO personaTel VALUES(" + Me.Id + "','" + Me.Telefono + ")"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

            MsgBox("Intente de nuevo")

        End Try
        Comando.CommandText = "COMMIT WORK;"
        Comando.ExecuteNonQuery()

        MsgBox("Persona agregada")

    End Sub

    Public Function Listar()
        Comando.CommandText = "SELECT * FROM persona"
        Comando.ExecuteReader()
        Return Reader
    End Function

    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM persona WHERE ci = " + Me.Id
        Comando.ExecuteNonQuery()
        Comando.CommandText = "DELETE FROM personaTel where IDpersona =" + Me.Id
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE persona SET nombre = '" + Me.Nombre + "', apellido = '" + Me.Apellido + "', email = '" + Me.Mail + "',FechaHoraCreacion = '" + Me.FechaHoraCreacion + "', activo = '" + Me.Activo + "' WHERE CI = " + Me.Id
        Comando.ExecuteNonQuery()

    End Sub
    Public Sub ModificarTel()
        Comando.CommandText = "UPDATE personaTel SET Telefono = '" + Me.Telefono + "' WHERE IDpersona = '" + Me.Id
        Comando.ExecuteNonQuery()
    End Sub
End Class
