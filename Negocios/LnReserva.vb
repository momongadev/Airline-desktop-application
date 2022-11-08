Imports Modelos
Imports Datos
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class LnReserva

    Dim objDatos As New LdReserva()

    Public Function obtenerReservaPorCliente(clienteId As Integer) As List(Of mdReserva)

        Try
            Dim ds = objDatos.ObteterReservasPorCliente(clienteId)

            Return ds


        Catch ex As Exception
            MessageBox.Show("Error al cargar reserva por cliente")
        End Try
    End Function
    Public Function obtenerPaises() As List(Of mdPais)
        Try
            Dim listPaises = objDatos.ObtenerPaises()

            Return listPaises
        Catch ex As Exception
            MessageBox.Show("Error al cargar paises")
        End Try
    End Function

    Public Function obtenerAeropuertosxPais(paisId As Integer) As List(Of mdAerpuertos)

        Try

            Dim ds = objDatos.ObtenerAeropuertoxPais(paisId)

            Return ds

        Catch ex As Exception
            MessageBox.Show("Error al cargar aeropuerto por pais")
        End Try

    End Function

    Public Sub eliminarReserva(reservaId As Integer)

        Try

            objDatos.eliminarReseva(reservaId)

        Catch ex As Exception
            MessageBox.Show("Error al eliminar reserva")
        End Try

    End Sub

    Public Sub InsertarReserva(clienteId As Integer, itinerarioDestinoid As Integer, itinerarioOrigenId As Integer, Asientos As Integer)

        Try

            objDatos.spInsertarReserva(clienteId, itinerarioDestinoid, itinerarioOrigenId, Asientos)

        Catch ex As Exception
            MessageBox.Show("Error al insertar reserva.")
        End Try

    End Sub


    Public Function ActualizarReserva(reservaId As Integer, itinerarioDestinoId As Integer, itinerarioOrigenId As Integer, Asientos As Integer) As Boolean

        Try

            If objDatos.spActualizarReserva(reservaId, itinerarioDestinoId, itinerarioOrigenId, Asientos) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function



End Class
