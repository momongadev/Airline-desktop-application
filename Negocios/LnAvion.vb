Imports Datos
Public Class LnAvion

    Dim objDatos As New LdAvion

    Public Function InsertarAvion(Capacida As String, aerolineaId As Integer, Nombre As String) As Boolean

        Try

            If objDatos.spInsertarAvion(Capacida, aerolineaId, Nombre) Then
                Return True

            Else
                Return False

            End If
        Catch ex As Exception

        End Try


    End Function

    Public Function ListaAvion() As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spListaAvion
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function

    Public Function BuscarAvion(avionId As Integer) As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spBuscarAvion(avionId)
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function

    Public Function ActualizarAvion(capacidad As Integer, avionId As Integer, aerolinea As Integer, nombre As String) As Boolean

        Try

            If objDatos.spActualizarAvion(capacidad, avionId, aerolinea, nombre) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BorrarAvion(avionId As Integer) As Boolean
        Try

            If objDatos.spBorrarAvion(avionId) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function DevolverAvionesPorAerolineaId(aeroId As Integer) As DataSet
        Dim ds As New DataSet
        Try


            ds = objDatos.spDevolverListaAvionPorId(aeroId)
            Return ds

        Catch ex As Exception

            Return ds
        End Try

    End Function

End Class
