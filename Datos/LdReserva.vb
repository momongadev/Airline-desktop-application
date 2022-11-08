Imports System.Data.SqlClient
Imports Modelos
Public Class LdReserva

    Public Function ObteterReservasPorCliente(idCLiente As Integer) As List(Of mdReserva)
        Dim Connection As New DBconnection
        Dim listReserva As New List(Of mdReserva)
        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("spListaReservasxClienteCompleto", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@clienteId", idCLiente)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Dim reserva As New mdReserva

                        reserva.ID = r.GetInt32(0)
                        reserva.ItinerarioDestinoId = r.GetInt32(1)
                        reserva.AER1Nombre = r.GetString(2)
                        reserva.DESTFechaSalida = r.GetDateTime(3)
                        reserva.DESTFechaLlegada = r.GetDateTime(4)
                        reserva.Pais1 = r.GetString(5)
                        reserva.APDE1 = r.GetString(6)
                        reserva.Pais2 = r.GetString(7)
                        reserva.APOR1 = r.GetString(8)
                        reserva.ItinerarioOrigenId = r.GetInt32(9)
                        reserva.AER2Nombre = r.GetString(10)
                        reserva.ORIFechaSalida = r.GetDateTime(11)
                        reserva.ORIFechaLlegada = r.GetDateTime(12)
                        reserva.Pais3 = r.GetString(13)
                        reserva.APDE2 = r.GetString(14)
                        reserva.Pais4 = r.GetString(15)
                        reserva.APOR2 = r.GetString(16)

                        listReserva.Add(reserva)
                    End While
                    r.Close()
                End Using

            End Using
            conn.Close()

            Return listReserva
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerPaises() As List(Of mdPais)

        Dim Connection As New DBconnection
        Dim listPaises As New List(Of mdPais)
        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("spListaPais", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Dim pais As New mdPais
                        pais.ID = r.GetInt32(0)
                        pais.Nombre = r.GetString(1)
                        listPaises.Add(pais)

                    End While
                End Using
            End Using
            conn.Close()

            Return listPaises
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerAeropuertoxPais(paisId As Integer) As List(Of mdAerpuertos)

        Dim Connection As New DBconnection
        Dim listAeropuertos As New List(Of mdAerpuertos)

        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("ConsultarAeropuertosxPais", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@paisId", paisId)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Dim aeropuerto As New mdAerpuertos
                        aeropuerto.AeropuertoId = r.GetInt32(0)
                        aeropuerto.NombreAeropuerto = r.GetString(1)
                        listAeropuertos.Add(aeropuerto)

                    End While
                    r.Close()
                End Using
            End Using
            conn.Close()

            Return listAeropuertos
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub eliminarReseva(reservaId As Integer)

        Dim Connection As New DBconnection
        Dim listAeropuertos As New List(Of mdAerpuertos)

        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("spBorrarReserva", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idReserva", reservaId)
            End Using
            conn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub spInsertarReserva(clienteId As Integer, itinerarioDestinoId As Integer, itinerarioOrigenId As Integer, asientos As Integer)

        Dim Connection As New DBconnection

        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("spInsertarReserva", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ClienteId", clienteId)
                cmd.Parameters.AddWithValue("@ItinerarioDestinoId", itinerarioDestinoId)
                cmd.Parameters.AddWithValue("@ItinerarioOrigenId", itinerarioOrigenId)
                cmd.Parameters.AddWithValue("@Asientos", asientos)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Function spActualizarReserva(reservaId As Integer, itinerarioDestinoId As Integer, itinerarioOrigenId As Integer, Asientos As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spActualizarReserva"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@reservaId", SqlDbType.Int).Value = reservaId
            command.Parameters.Add("@itinerarioDestinoId", SqlDbType.Int).Value = itinerarioDestinoId
            command.Parameters.Add("@itinerarioOrigenId", SqlDbType.Int).Value = itinerarioOrigenId
            command.Parameters.Add("@Asientos", SqlDbType.Int).Value = Asientos

            command.Connection = Connection.conn
            Connection.conn.Open()

            command.ExecuteNonQuery()

            Connection.conn.Close()

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function


End Class
