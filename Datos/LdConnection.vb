
Imports System.Data.SqlClient
Module LdConnection
    Public machine = Net.Dns.GetHostName
    'esto funciona para mi maquina(karla) y usar el otro para sqlexpress
    'Dim connectionString As String = ("Server=CR-PF29PKBN;Database=Reservaciones;User Id=sa;Password=Administrator$01")

    Public conn As New SqlConnection("Data Source=" + machine + "\SQLEXPRESS;Initial Catalog=Reservaciones;Integrated Security=True")
    'Public conn As New SqlConnection(connectionString)

End Module
