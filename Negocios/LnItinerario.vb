Imports Datos
Public Class LnIntinerario

    Dim objDatos As New LdIntinerario


    Public Function InsertarIntinerario(aeropuertoDestinoId As Integer, aeropuertoOrigenId As Integer, aerolineaId As Integer, fechaSalida As Date, fechaLlegada As Date, Asientos As Integer, avionId As Integer) As Boolean

        Try

            If objDatos.spInsertarIntinerario(aeropuertoDestinoId, aeropuertoOrigenId, aerolineaId, fechaSalida, fechaLlegada, Asientos, avionId) Then
                Return True

            Else
                Return False

            End If
        Catch ex As Exception

        End Try


    End Function

    Public Function ListaIntinerario() As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spListaIntinerario
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function

    Public Function BuscarIntinerario(itinerarioId As Integer) As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spBuscarIntinerario(itinerarioId)
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function

    Public Function ActualizarIntinerario(itinerarioId As Integer, aeropuertoDestinoId As Integer, aeropuertoOrigenId As Integer, aerolineaId As Integer, fechaSalida As Date, fechaLlegada As Date, Asientos As Integer, avionId As Integer) As Boolean

        Try

            If objDatos.spActualizarIntinerario(itinerarioId, aeropuertoDestinoId, aeropuertoOrigenId, aerolineaId, fechaSalida, fechaLlegada, Asientos, avionId) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BorrarIntinerario(itinerarioId As Integer) As Boolean
        Try

            If objDatos.spBorrarIntinerario(itinerarioId) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
