Imports Datos
Public Class LnPais

    Dim objDatosPais As New LdPais
    Dim ds As New DataSet

    Public Function ListaPais() As DataSet

        Try
            ds = objDatosPais.spListaPais
            Return ds

    Catch ex As Exception
            Return ds
        End Try
    End Function

End Class
