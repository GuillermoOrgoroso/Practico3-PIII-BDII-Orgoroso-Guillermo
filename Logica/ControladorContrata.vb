

Imports Fisica

Public Module ControladorContrata

    Public Function Listar()
        Try
            Dim p As New Contrata
            Return p.Listar()

        Catch ex As Exception
            MsgBox("Error al listar")

        End Try

    End Function

    Public Sub Eliminar(idpersona As String)
        Try
            Dim p As New Contrata
            p.Borrar()
            MsgBox("Eliminado con exito")

        Catch ex As Exception
            MsgBox("Error al intentar eliminar")

        End Try

    End Sub

    Public Sub Alta(idpersona As String, idservicio As String, fechacreacion As String, fechacontratacion As String, fechafincontrato As String)
        Try
            Dim p As New Contrata

            p.IDpersona = idpersona
            p.IDServicio = idservicio
            p.FechaContratacion = fechacontratacion
            p.FechaContratacion = fechacontratacion
            p.FechaFinContrato = fechafincontrato

            p.Guardar()
            MsgBox("Alta realizada con exito")


        Catch ex As Exception
            MsgBox("Error en el alta")
        End Try



    End Sub

    Public Sub Modificar(idpersona As String, idservicio As String, fechacreacion As String, fechacontratacion As String, fechafincontrato As String)
        Try
            Dim p As New Contrata

            p.IDpersona = idpersona
            p.IDServicio = idservicio
            p.FechaContratacion = fechacontratacion
            p.FechaContratacion = fechacontratacion
            p.FechaFinContrato = fechafincontrato
            p.Modificar()
            MsgBox("Modificado con exito")

        Catch ex As Exception
            MsgBox("Error al modificar")
        End Try


    End Sub

End Module
