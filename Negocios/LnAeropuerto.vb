Imports Datos
Public Class LnAeropuerto

    Dim objDatos As New LdAerpuertos
    Public Function InsertarAeropuerto(nombre As String, pais As Integer) As Boolean

        Try

            If objDatos.spInsertarAeropuerto(nombre, pais) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BuscarAeropuertos(aeropuertoid As Integer) As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spBuscarAeropuerto(aeropuertoid)
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function

    Public Function ActualizarAeropuerto(nombre As String, pais As Integer, aeropuertoId As Integer) As Boolean

        Try

            If objDatos.spActualizarAeropuerto(nombre, pais, aeropuertoId) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function BorrarAeropuerto(aeropuertoId As Integer) As Boolean
        Try

            If objDatos.spBorrarAeropuerto(aeropuertoId) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ListaAeropuertos() As DataSet
        Dim ds As New DataSet

        Try
            ds = objDatos.spListaAeropuertos
            Return ds

        Catch ex As Exception
            Return ds
        End Try

    End Function
End Class
