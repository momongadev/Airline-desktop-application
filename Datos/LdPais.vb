Imports System.Data.SqlClient
Public Class LdPais


    Public Function spListaPais() As DataSet


        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.CommandText = "spListaPais"
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
