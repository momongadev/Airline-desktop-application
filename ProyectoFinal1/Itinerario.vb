Public Class Itinerario

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Reservas_Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub Itinerario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            Dim ObjetosItinerarios As New Negocios.LnIntinerario()
            dtgvIitnerariosIda.DataSource = ObjetosItinerarios.ConsultarItinerarioPorFiltro(Negocios.sesPaisDesdeIdDes, Negocios.sesPaisHastaIdDes, Negocios.sesCuandoViajaDes, Negocios.sesCuandoRegresaDes, Negocios.sesAeropuertoOrigenIdDes, Negocios.sesAeropuertoDestinoIdDes)
            dtgvItinerariosRegreso.DataSource = ObjetosItinerarios.ConsultarItinerarioPorFiltro(Negocios.sesPaisDesdeIdOri, Negocios.sesPaisHastaIdOri, Negocios.sesCuandoViajaOri, Negocios.sesCuandoRegresaOri, Negocios.sesAeropuertoOrigenIdOri, Negocios.sesAeropuertoDestinoIdOri)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Dim objetoItinerarios As New Negocios.LnReserva()

        Try

            Try
                If Not dtgvItinerariosRegreso.Rows.Count > 0 Or Not dtgvIitnerariosIda.Rows.Count > 0 Then

                    MessageBox.Show("No hay itenerarios que mostrar")
                Else
                    If dtgvIitnerariosIda.SelectedRows.Count > 0 And dtgvItinerariosRegreso.SelectedRows.Count > 0 Then
                        Dim itiIdaId = dtgvIitnerariosIda.SelectedRows(0).Cells(0).Value
                        Dim itiRegreId = dtgvItinerariosRegreso.SelectedRows(0).Cells(0).Value

                        objetoItinerarios.InsertarReserva(Negocios.sesId, itiIdaId, itiRegreId, 20)
                        Reservas_Cliente.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Escoja todos los itenerarios")
                    End If

                End If
            Catch ex As Exception

            End Try




        Catch ex As Exception

        End Try


    End Sub
End Class