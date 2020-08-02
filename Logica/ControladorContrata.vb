

Imports Fisica

Public Module ControladorContrata

    Public Function Listar()

        Dim p As New Contrata
            Return p.Listar()





    End Function

    Public Sub Eliminar(idpersona As String)

        Dim p As New Contrata
            p.Borrar()



    End Sub

    Public Sub Alta(idpersona As String, idservicio As String, fechacreacion As String, fechacontratacion As String, fechafincontrato As String)

        Dim p As New Contrata

            p.IDpersona = idpersona
            p.IDServicio = idservicio
            p.FechaContratacion = fechacontratacion
            p.FechaContratacion = fechacontratacion
            p.FechaFinContrato = fechafincontrato

            p.Guardar()




    End Sub

    Public Sub Modificar(idpersona As String, idservicio As String, fechacreacion As String, fechacontratacion As String, fechafincontrato As String)

        Dim p As New Contrata

            p.IDpersona = idpersona
            p.IDServicio = idservicio
            p.FechaContratacion = fechacontratacion
            p.FechaContratacion = fechacontratacion
            p.FechaFinContrato = fechafincontrato
            p.Modificar()



    End Sub

End Module
