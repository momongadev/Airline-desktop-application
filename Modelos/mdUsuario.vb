Public Class mdUsuario
    Public Id As Integer
    Public Nombre As String
    Public Apellido1 As String
    Public Apellido2 As String
    Public Genero As Char
    Public Nacionalidad As String
    Public FechaNacimiento As Date
    Public Identificacion As String
    Public Usuario As String
    Public Contrasenia As String
    Public TipoUsuario As Integer

    Public listReservas As New List(Of mdReservaExportar)

End Class
