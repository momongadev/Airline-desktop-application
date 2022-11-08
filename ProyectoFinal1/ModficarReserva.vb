Imports Negocios
Imports Modelos


Public Class ModficarReserva
    Dim objDatos As New LnCliente()
    Dim idCliente = SesionActiva.sesId
    Dim idReserva = SesionReserva.sesReservaId
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ModficarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ds As New DataSet
        ds = objDatos.ListaReservasxCliente(idCliente)

        Dim table As New DataTable
        'Creación de las columnas
        table.Columns.Add("RESERVAID")
        table.Columns.Add("ClienteId")
        table.Columns.Add("DestinoId")
        table.Columns.Add("OrigenId")
        table.Columns.Add("Asientos")
        dgReservas.DataSource = table
        dgReservas.DataSource = ds.Tables(0)



        'Se cargan los itinerarios
        Try
            Dim objDatosItinerario As New LnIntinerario()
            Dim objDatosItinerario2 As New LnIntinerario()
            Dim dsItinerario As New DataSet
            Dim dsItinerario2 As New DataSet
            dsItinerario = objDatosItinerario.ListaIntinerario
            dsItinerario2 = objDatosItinerario2.ListaIntinerario
            If dsItinerario.Tables.Count >= 0 Then
                dgItinerariosIda.DataSource = dsItinerario.Tables(0)
                dgItinerariosRegreso.DataSource = dsItinerario2.Tables(0)
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Aceptar(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try


            If dgReservas.SelectedRows.Count = 1 Then
                Dim reserva As New mdReserva
                Dim reserv As New LnReserva

                reserva.ID = dgReservas.SelectedRows(0).Cells(0).Value
                reserva.ItinerarioDestinoId = dgItinerariosIda.SelectedRows(0).Cells(0).Value
                reserva.ItinerarioOrigenId = dgItinerariosRegreso.SelectedRows(0).Cells(0).Value
                reserva.Asientos = dgReservas.SelectedRows(0).Cells(4).Value

                reserv.ActualizarReserva(reserva.ID, reserva.ItinerarioDestinoId, reserva.ItinerarioOrigenId, reserva.Asientos)



                Dim ds As New DataSet
                ds = objDatos.ListaReservasxCliente(idCliente)
                dgReservas.DataSource = ds.Tables(0)

                MessageBox.Show("", "Se modificó el record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo modificar el record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)

    End Sub
End Class