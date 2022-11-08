Imports Datos
Imports Modelos
Public Class LnCliente
    Dim objDatos As New LdCliente
    Public Function ExisteCliente(usuario, pass) As Boolean

        Dim user = objDatos.spConsultarCliente(usuario, pass)

        sesId = user.Id
        sesNombre = user.Nombre
        sesUsuario = user.Usuario
        sesContrasenia = user.Contrasenia
        sesIdentificacion = user.Identificacion
        sesTipoUsuario = user.TipoUsuario
        sesApellido2 = user.Apellido2
        sesApellido1 = user.Apellido1
        sesFechaNacimiento = user.FechaNacimiento
        sesGenero = user.Genero
        sesNacionalidad = user.Nacionalidad

        If sesId = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function InsertarCliente(identificacion As String, nombre As String, apellido1 As String, apellido2 As String, genero As String, nacionalidad As String, fechaNacimiento As Date, usuario As String, contrasenia As String)

        Dim ds As New mdCliente

        ds.apellido1 = apellido1
        ds.apellido2 = apellido2
        ds.contrasenia = contrasenia
        ds.fechaNacimiento = fechaNacimiento
        ds.genero = genero
        ds.identificacion = identificacion
        ds.usuario = usuario
        ds.tipoUsuario = 1


        If objDatos.InsertarCliente(identificacion, nombre, apellido1, apellido2, genero, nacionalidad, fechaNacimiento, usuario, contrasenia, 1) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ConsultarListaClientes() As DataSet
        Dim ds As New DataSet
        ds = objDatos.spConsultarListaClientes()
        Return ds


    End Function


    Public Function ListaReservasxCliente(idCliente As Integer) As DataSet

        Dim ds As New DataSet
        ds = objDatos.spListaReservasxCliente(idCliente)
        Return ds
    End Function


End Class
