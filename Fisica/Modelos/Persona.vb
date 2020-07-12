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
            Comando.CommandText = "INSERT INTO personaTel VALUES(" + Me.Id + "','" + Me.Telefono + ")"
            Comando.ExecuteNonQuery()
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


    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM personas WHERE ci = " + Me.Id
    End Sub



End Class
