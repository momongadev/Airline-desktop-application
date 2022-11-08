Imports System.Data.SqlClient
Imports Modelos
Public Class LdCliente



    Public Function InsertarCliente(identificacion As String, nombre As String, apellido1 As String, apellido2 As String, genero As String, nacionalidad As String, fechaNacimiento As Date, usuario As String, contrasenia As String, Optional tipoUsuario As Integer = 1) As Boolean

        Dim Connection As New DBconnection



        Try

            Dim command As New SqlCommand

            command.CommandText = "spInsertarCliente"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@identificacion", SqlDbType.VarChar, 12).Value = identificacion
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre
            command.Parameters.Add("@apellido1", SqlDbType.VarChar, 50).Value = apellido1
            command.Parameters.Add("@apellido2", SqlDbType.VarChar, 50).Value = apellido2
            command.Parameters.Add("@genero", SqlDbType.Char).Value = genero
            command.Parameters.Add("@nacionalidad", SqlDbType.VarChar, 50).Value = nacionalidad
            command.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNacimiento
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario
            command.Parameters.Add("@contrasenia", SqlDbType.VarChar, 50).Value = contrasenia
            command.Parameters.Add("@tipoUsuario", SqlDbType.Int).Value = tipoUsuario

            command.Connection = conn
            conn.Open()

            command.ExecuteNonQuery()

            conn.Close()

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    Public Function spConsultarCliente(usuario As String, contrasenia As String) As mdUsuario
        Dim ds As New DataSet
        Dim user As New mdUsuario
        Dim Connection As New DBconnection
        Try
            Using cn = Connection.conn
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand("spConsultarCliente", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@contrasenia", contrasenia)
                Using r = cmd.ExecuteReader()

                    If r.Read() Then
                        user.Id = r.GetInt32(0)
                        user.Identificacion = r.GetString(1)
                        user.Nombre = r.GetString(2)
                        user.Apellido1 = r.GetString(3)
                        user.Apellido2 = r.GetString(4)
                        user.Genero = r.GetString(5)
                        user.Nacionalidad = r.GetString(6)
                        user.FechaNacimiento = r.GetDateTime(7).ToShortDateString
                        user.Usuario = r.GetString(8)
                        user.Contrasenia = r.GetString(9)
                        user.TipoUsuario = r.GetInt32(10)
                    End If
                End Using
            End Using
            conn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return user

    End Function

    Public Function spConsultarListaClientes() As DataSet

        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.Connection = Connection.conn
            Connection.conn.Open() ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("spConsultarListaClientes", conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            Connection.conn.Close()


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return ds
    End Function

    Public Function spListaReservasxCliente(idCliente As Integer) As DataSet
        Dim ds As New DataSet
        Dim Connection As New DBconnection

        Try
            Dim command As New SqlCommand

            command.Connection = Connection.conn
            Connection.conn.Open() ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("spListaReservasxCliente", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            Dim oDataAdapter As New SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            Connection.conn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return ds


    End Function

End Class
