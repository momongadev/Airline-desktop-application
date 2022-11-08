Imports Datos
Public Class LnAerolineas
    Dim objDatos As New LdAerolinea

    Public Function DevolverListaAerolineas() As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spDevolverListaAerolineas
            Return ds

        Catch ex As Exception
            Return ds
        End Try
    End Function



End Class
