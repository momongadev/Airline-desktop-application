Imports System.Data.SqlClient
Imports Modelos
Public Class LdAerpuertos


    Public Function spInsertarAeropuerto(nombreAeropuerto As String, pais As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spInsertarAeropuerto"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombreAeropuerto
            command.Parameters.Add("@Pais", SqlDbType.Int).Value = pais

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

    Public Function spBuscarAeropuerto(aeropuertoId As Integer) As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBuscarAeropuerto"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@aeropuertoId", SqlDbType.Int).Value = aeropuertoId


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


    Public Function spActualizarAeropuerto(nombre As String, pais As Integer, aeropuertoId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spActualizarAeropuerto"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre
            command.Parameters.Add("@Pais", SqlDbType.Int).Value = pais
            command.Parameters.Add("@aeropuertoId ", SqlDbType.Int).Value = aeropuertoId

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

    Public Function spBorrarAeropuerto(aeropuertoId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBorrarAeropuerto"
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.Add("@aeropuertoId ", SqlDbType.Int).Value = aeropuertoId

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

    Public Function spListaAeropuertos() As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.CommandText = "spListaAeropuertos"
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

End Class




