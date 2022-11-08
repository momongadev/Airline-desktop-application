Imports System.Data.SqlClient
Public Class DBconnection
    Public machine = Net.Dns.GetHostName
    'Para uso de sql karla
    'Dim connectionString As String = ("Server=CR-PF29PKBN;Database=Reservaciones;User Id=sa;Password=Administrator$01")
    'Public conn As New SqlConnection(connectionString)

    'para uso sqlexpress
    Public conn As New SqlConnection("Data Source=" + machine + "\SQLEXPRESS;Initial Catalog=Reservaciones;Integrated Security=True")
End Class


