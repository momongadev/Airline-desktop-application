Imports System.Data.SqlClient
Imports Modelos
Public Class LdIntinerario


    Public Function spInsertarIntinerario(aeropuertoDestinoId As Integer, aeropuertoOrigenId As Integer, aerolineaId As Integer, fechaSalida As Date, fechaLlegada As Date, Asientos As Integer, avionId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try

            Dim command As New SqlCommand

            command.CommandText = "spInsertarItinerario"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@aeropuertoDestinoId", SqlDbType.Int).Value = aeropuertoDestinoId
            command.Parameters.Add("@aeropuertoOrigenId", SqlDbType.Int).Value = aeropuertoOrigenId
            command.Parameters.Add("@aerolineaId", SqlDbType.Int).Value = aerolineaId
            command.Parameters.Add("@fechaSalida", SqlDbType.DateTime).Value = fechaSalida
            command.Parameters.Add("@fechaLlegada", SqlDbType.DateTime).Value = fechaLlegada
            command.Parameters.Add("@Asientos", SqlDbType.Int).Value = Asientos
            command.Parameters.Add("@avionId", SqlDbType.Int).Value = avionId

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



    Public Function spListaIntinerario() As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.CommandText = "spConsularItinerarioCompleto"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = Connection.conn
            Connection.conn.Open()

            'command.ExecuteReader()
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(command)
            oDataAdapter.Fill(ds)

            Connection.conn.Close()

            Return ds

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return ds

        End Try
    End Function

    Public Function spBuscarIntinerario(itinerarioId As Integer) As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBuscarIntinerario"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@itinerarioId", SqlDbType.Int).Value = itinerarioId


            command.Connection = Connection.conn
            Connection.conn.Open()

            command.ExecuteNonQuery()
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(command)
            oDataAdapter.Fill(ds)

            Connection.conn.Close()

            Return ds

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return ds
        End Try
    End Function

    Public Function spActualizarIntinerario(itinerarioId As Integer, aeropuertoDestinoId As Integer, aeropuertoOrigenId As Integer, aerolineaId As Integer, fechaSalida As Date, fechaLlegada As Date, Asientos As Integer, avionId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spActualizarIntinerario"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@IntinerarioId", SqlDbType.Int).Value = itinerarioId
            command.Parameters.Add("@aeropuertoDestinoId", SqlDbType.Int).Value = aeropuertoDestinoId
            command.Parameters.Add("@aeropuertoOrigenId", SqlDbType.Int).Value = aeropuertoOrigenId
            command.Parameters.Add("@aerolineaId", SqlDbType.Int).Value = aerolineaId
            command.Parameters.Add("@fechaSalida", SqlDbType.DateTime).Value = fechaSalida
            command.Parameters.Add("@aerolineaId", SqlDbType.Int).Value = fechaLlegada
            command.Parameters.Add("@Asientos", SqlDbType.Int).Value = Asientos
            command.Parameters.Add("@avionId", SqlDbType.Int).Value = avionId

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

    Public Function spBorrarItinerario(itinerarioId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBorrarItinerario"
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.Add("@itinerarioId ", SqlDbType.Int).Value = itinerarioId

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

    Public Function ConsultarItinerarioPorFiltro(paisDesdeId As Integer, paisHastaId As Integer, cuandoViaja As Date, cuandoRegresa As Date, aeropuertoOrigenId As Integer, aeropuertoDestinoId As Integer) As DataSet
        Dim Connection As New DBconnection
        Dim ds As New DataSet
        Try


            Dim command As New SqlCommand

            command.CommandText = "spConsultarItinerarioPorFiltros"
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.Add("@paisDesdeId ", SqlDbType.Int).Value = paisDesdeId
            command.Parameters.AddWithValue("@paisHastaId", paisHastaId)
            command.Parameters.AddWithValue("@cuandoViaja", cuandoViaja)
            command.Parameters.AddWithValue("@cuandoRegresa", cuandoRegresa)
            command.Parameters.AddWithValue("@aeropuertoOrigenId", aeropuertoOrigenId)
            command.Parameters.AddWithValue("@aeropuertoDestinoId", aeropuertoDestinoId)

            command.Connection = Connection.conn
            Connection.conn.Open()

            Dim oDataAdapter As New SqlClient.SqlDataAdapter(command)
            oDataAdapter.Fill(ds)
            Connection.conn.Close()

            Return ds

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return ds
        End Try

    End Function

End Class
