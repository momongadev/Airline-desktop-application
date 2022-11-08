Public Class Menu_Administrativo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Aeropuertos_Administrativo.Show()
        Me.Hide()
    End Sub

    Private Sub btnAviones_Click(sender As Object, e As EventArgs) Handles btnAviones.Click
        Aviones_Administrativo.Show()
        Me.Hide()
    End Sub

    Private Sub btnItinerarios_Click(sender As Object, e As EventArgs) Handles btnItinerarios.Click
        Itinerarios_Administrativo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListaClientes_Administrativo.Show()
        Me.Hide()
    End Sub
End Class