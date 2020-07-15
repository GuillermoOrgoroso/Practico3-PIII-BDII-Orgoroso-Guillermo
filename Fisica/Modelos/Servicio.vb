Public Class Servicio
    Inherits ModeloConexion

    Public Id As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String
    Public FechaHoraCreacion As String
    Public Activo As Boolean



    Public Function listar()
        Try
            Comando.CommandText = "SELECT * FROM Servicio"
            Comando.ExecuteReader()
            Return Reader
        Catch ex As Exception
            MsgBox("Error al listar")

        End Try


    End Function


    Public Sub Guardar()
        Try

            Comando.CommandText = "INSERT INTO Servicio VALUES(" + Me.Id + "','" + Me.Nombre + "','" + Me.CostoMensual + " ',' " + Me.Tipo + "','" + Me.FechaHoraCreacion + "','" + Me.Activo + " )"
            Comando.ExecuteNonQuery()
            MsgBox("Servicio ingresado al sistema con exito.")

        Catch ex As Exception
            MsgBox("Error al intentar dar de alta al servicio, intente de nuevo.")

        End Try


    End Sub

    Public Sub Borrar()
        Try
            Comando.CommandText = "DELETE FROM Servicio WHERE ID = " + Me.Id
            Comando.ExecuteNonQuery()
            MsgBox("Servicio eliminado con exito.")

        Catch ex As Exception
            MsgBox("Error al intentar eliminar el servicio del sistema.")
        End Try



    End Sub

    Public Function Modificar()
        Try
            Comando.CommandText = "UPDATE Servicio SET Nombre = '" + Me.Nombre + " ',CostoMensual = '" + Me.CostoMensual + "', Tipo = '" + Me.Tipo + "', FechaHoraCreacion = '" + Me.FechaHoraCreacion + "', Activo ='" + Me.Activo + "' WHERE ID ='" + Me.Id
            Comando.ExecuteReader()

            Return Reader
            MsgBox("Datos del servicio modificados con exito.")

        Catch ex As Exception
            MsgBox("Error al intentar modificar los datos del servicio")

        End Try

        Return -1

    End Function

    Public Function Contar()

        Me.Comando.CommandText = "SELECT COUNT(*) FROM Servicio"
        Return Me.Comando.ExecuteScalar().ToString()

    End Function
End Class
