Public Class Servicio
    Inherits ModeloConexion

    Public Id As String
    Public Nombre As String
    Public CostoMensual As String
    Public Tipo As String
    Public FechaHoraCreacion As String
    Public Activo As Boolean



    Public Function listar()

        Comando.CommandText = "SELECT * FROM Servicio"
            Comando.ExecuteReader()
            Return Reader

    End Function


    Public Sub Guardar()


        Comando.CommandText = "INSERT INTO Servicio VALUES(" + Me.Id + "','" + Me.Nombre + "','" + Me.CostoMensual + " ',' " + Me.Tipo + "','" + Me.FechaHoraCreacion + "','" + Me.Activo + " )"
        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Borrar()

        Comando.CommandText = "DELETE FROM Servicio WHERE ID = " + Me.Id
        Comando.ExecuteNonQuery()


    End Sub

    Public Function Modificar()

        Comando.CommandText = "UPDATE Servicio SET Nombre = '" + Me.Nombre + " ',CostoMensual = '" + Me.CostoMensual + "', Tipo = '" + Me.Tipo + "', FechaHoraCreacion = '" + Me.FechaHoraCreacion + "', Activo ='" + Me.Activo + "' WHERE ID ='" + Me.Id
        Comando.ExecuteReader()

        Return Reader

    End Function

    Public Function Contar()

        Me.Comando.CommandText = "SELECT COUNT(*) FROM Servicio"
        Return Me.Comando.ExecuteScalar().ToString()

    End Function
End Class
