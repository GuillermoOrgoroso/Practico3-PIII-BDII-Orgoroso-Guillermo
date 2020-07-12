Public Class Contrata
    Inherits ModeloConexion

    Public IDpersona As String
    Public IDServicio As String
    Public FechaCreacion As String
    Public FechaContratacion As String
    Public FechaFinContrato As String

    Public Sub Guardar()
        Try

            Comando.CommandText = "INSERT INTO contrata VALUES(" + Me.IDpersona + "','" + Me.IDServicio + "','" + Me.FechaCreacion + "','" + Me.FechaContratacion + "','" + Me.FechaFinContrato + " )"
            Comando.ExecuteNonQuery()
            MsgBox("Datos del contrato ingresados con exito")
        Catch ex As Exception
            MsgBox("Error al intentar guardar los datos del contrato, intente de nuevo")
        End Try
    End Sub

    Public Function Listar()
        Try
            Comando.CommandText = "SELECT * FROM Contrato"
            Comando.ExecuteReader()

            Return Reader
        Catch ex As Exception
            MsgBox("Error, intente de nuevo")
        End Try

        Return -1
    End Function

    Public Sub Borrar()
        Try
            Comando.CommandText = "DELETE * FROM Contrato wehere IDpersona = " + Me.IDpersona
            Comando.ExecuteNonQuery()
            MsgBox("Baja del contrato realizada con exito")
        Catch ex As Exception
            MsgBox("Error al intentar dar de baja al contrato, intente nuevamente")

        End Try


    End Sub

    Public Sub Modificar()
        Try
            Comando.CommandText = "UPDATE Contrato SET FechaContratacion = '" + Me.FechaContratacion + "',FechaFinContato = '" + Me.FechaFinContrato + "' WHERE IDpersona = '" + Me.IDpersona + "' AND IDservicio = '" + Me.IDServicio + "' AND FechaCreacion = '" + Me.FechaCreacion
            Comando.ExecuteNonQuery()
            MsgBox("Contrato modificad con exito.")
        Catch ex As Exception
            MsgBox("Error al intentar modificar el contrato, intente de nuevo")

        End Try

    End Sub

End Class
