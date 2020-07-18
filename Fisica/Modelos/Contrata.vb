Public Class Contrata
    Inherits ModeloConexion

    Public IDpersona As String
    Public IDServicio As String
    Public FechaCreacion As String
    Public FechaContratacion As String
    Public FechaFinContrato As String

    Public Sub Guardar()


        Comando.CommandText = "INSERT INTO contrata VALUES(" + Me.IDpersona + "','" + Me.IDServicio + "','" + Me.FechaCreacion + "','" + Me.FechaContratacion + "','" + Me.FechaFinContrato + " )"
        Comando.ExecuteNonQuery()
        MsgBox("Datos del contrato ingresados con exito")

    End Sub

    Public Function Listar()

        Comando.CommandText = "SELECT * FROM Contrato"
        Comando.ExecuteReader()

        Return Reader

    End Function

    Public Sub Borrar()

        Comando.CommandText = "DELETE * FROM Contrata wehere IDpersona = " + Me.IDpersona
        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE Contrata SET FechaContratacion = '" + Me.FechaContratacion + "',FechaFinContato = '" + Me.FechaFinContrato + "' WHERE IDpersona = '" + Me.IDpersona + "' AND IDservicio = '" + Me.IDServicio + "' AND FechaCreacion = '" + Me.FechaCreacion
        Comando.ExecuteNonQuery()

    End Sub

End Class
