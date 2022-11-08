Imports System.Data.SqlClient
Imports Modelos
Public Class LdAvion

    Public Function spInsertarAvion(capacidad As String, aerolineaId As Integer, nombre As String) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spInsertarAvion"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Capacidad", SqlDbType.VarChar, 100).Value = capacidad
            command.Parameters.Add("@aerolineaId", SqlDbType.Int).Value = aerolineaId
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre

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

    Public Function spDevolverListaAvionPorId(aerolineaId As Integer) As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.CommandText = "spDevolverAvionxAerolinea"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@aerolineaId", aerolineaId)
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
    Public Function spListaAvion() As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.CommandText = "spListaAvion"
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

    Public Function spBuscarAvion(avionId As Integer) As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBuscarAvion"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@avionId", SqlDbType.Int).Value = avionId


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

    Public Function spActualizarAvion(capacidad As String, avionId As Integer, aerolineaId As Integer, nombre As String) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spActualizarAvion"
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Capacidad", SqlDbType.VarChar, 100).Value = capacidad
            command.Parameters.Add("@avionId ", SqlDbType.Int).Value = avionId
            command.Parameters.Add("@aerolineaId ", SqlDbType.Int).Value = aerolineaId
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre

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

    Public Function spBorrarAvion(avionId As Integer) As Boolean

        Dim Connection As New DBconnection

        Try


            Dim command As New SqlCommand

            command.CommandText = "spBorrarAvion"
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.Add("@avionId ", SqlDbType.Int).Value = avionId

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
