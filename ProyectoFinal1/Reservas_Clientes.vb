
Public Class Reservas_Cliente
    Dim objNeegociosReserva As New Negocios.LnReserva()
    Private Sub btnNuevaReserva_Click(sender As Object, e As EventArgs) Handles btnNuevaReserva.Click
        Nueva_Reserva.Show()
    End Sub

    Private Sub CargaTabla()
        Try
            'Definición de la variable tipo Tabla
            Dim table As New DataTable
            'Creación de las columnas
            table.Columns.Add("RESERVAID")
            table.Columns.Add("ITINERARIO DESTINO")
            table.Columns.Add("AEROLINEA DES")
            table.Columns.Add("FECHA SALIDA DES")
            table.Columns.Add("FECHA LLEGADA DES")
            table.Columns.Add("PAIS DESTINO")
            table.Columns.Add("AEROPUERTO DESTINO DES")
            table.Columns.Add("PAIS ORIGEN DES")
            table.Columns.Add("AEROPUERTO ORIGEN DES")
            table.Columns.Add("ITINERARIO ORIGEN ID")
            table.Columns.Add("AEROLINEA ORI")
            table.Columns.Add("FECHA SALIDA ORI")
            table.Columns.Add("FECHA LLEGADA ORI")
            table.Columns.Add("PAIS DESTI")
            table.Columns.Add("AEROPUERTO DESTINO ORI")
            table.Columns.Add("PAIS ORI")
            table.Columns.Add("AEROPUERTO ORIGEN")

            Dim listReservas = objNeegociosReserva.obtenerReservaPorCliente(Negocios.sesId)

            If (listReservas.Count > 0) Then
                For Each item As Modelos.mdReserva In listReservas

                    table.Rows.Add(item.ID, item.ItinerarioDestinoId, item.AER1Nombre, item.DESTFechaSalida, item.DESTFechaLlegada, item.Pais1, item.APDE1, item.Pais2, item.APDE2, item.ItinerarioOrigenId,
                                                                      item.AER2Nombre, item.ORIFechaSalida, item.ORIFechaLlegada, item.Pais3, item.APOR1, item.Pais4, item.APOR2)

                Next
            Else
                table.Rows.Clear()
            End If

            dtgvRerservasCliente.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Reservas_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaTabla()
    End Sub

    Private Sub btnModificarReserva_Click(sender As Object, e As EventArgs) Handles btnModificarReserva.Click

        If dtgvRerservasCliente.SelectedRows().Count > 0 Then
            Negocios.sesReservaId = dtgvRerservasCliente.SelectedRows(0).Cells(0).Value

            ModficarReserva.Show()
        Else
            MessageBox.Show("Seleccione una fila")
        End If


    End Sub

    Private Sub btnEliminarReserva_Click(sender As Object, e As EventArgs) Handles btnEliminarReserva.Click
        Try

            Dim resId = dtgvRerservasCliente.Rows(dtgvRerservasCliente.CurrentRow.Index).Cells(0).Value
            objNeegociosReserva.eliminarReserva(resId)
            dtgvRerservasCliente.Rows.Remove(dtgvRerservasCliente.CurrentRow)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar reserva")
        End Try
    End Sub

    Private Sub btnExportarReserva_Click(sender As Object, e As EventArgs) Handles btnExportarReserva.Click

        Try

            Dim usuarioReservaExportar As New Modelos.mdUsuario

            usuarioReservaExportar.Identificacion = Negocios.sesIdentificacion
            usuarioReservaExportar.Nombre = Negocios.sesNombre
            usuarioReservaExportar.Apellido1 = Negocios.sesApellido1
            usuarioReservaExportar.Apellido2 = Negocios.sesApellido2
            usuarioReservaExportar.Genero = Negocios.sesGenero
            usuarioReservaExportar.Nacionalidad = Negocios.sesNacionalidad
            usuarioReservaExportar.FechaNacimiento = Negocios.sesFechaNacimiento
            usuarioReservaExportar.Usuario = Negocios.sesUsuario

            If dtgvRerservasCliente.Rows.Count > 0 Then
                Dim docXML As New Negocios.DocumentoXMLReserva
                If dtgvRerservasCliente.SelectedRows.Count > 0 Then

                    For Each row As DataGridViewRow In dtgvRerservasCliente.SelectedRows

                        If row.Cells(0).Value IsNot Nothing Then
                            Dim res As New Modelos.mdReservaExportar

                            res.PaisOrigen = row.Cells(15).Value
                            res.PaisDestino = row.Cells(13).Value
                            res.AeropuertoOrigen = row.Cells(16).Value
                            res.AeropuertoDestino = row.Cells(13).Value
                            res.InformacionDelVuelo = "ReservaID: " + row.Cells(0).Value + "\nFechaSalida: " + row.Cells(11).Value + "\nFechaLlegada: " + row.Cells(12).Value

                            usuarioReservaExportar.listReservas.Add(res)
                        End If


                    Next
                Else
                    For Each row As DataGridViewRow In dtgvRerservasCliente.Rows

                        If row.Cells(0).Value IsNot Nothing Then
                            Dim res As New Modelos.mdReservaExportar

                            res.PaisOrigen = row.Cells(15).Value
                            res.PaisDestino = row.Cells(13).Value
                            res.AeropuertoOrigen = row.Cells(16).Value
                            res.AeropuertoDestino = row.Cells(13).Value
                            res.InformacionDelVuelo = "ReservaID: " + row.Cells(0).Value + "\nFechaSalida: " + row.Cells(11).Value.ToString + "\nFechaLlegada: " + row.Cells(12).Value.ToString

                            usuarioReservaExportar.listReservas.Add(res)
                        End If

                    Next

                End If
                saveFileXML.Title = "Seleccione una ubicacion"
                saveFileXML.Filter = "XML|*.xml"
                If saveFileXML.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Dim url = saveFileXML.FileName

                    docXML.CreaDocumentoXML(usuarioReservaExportar, url)

                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error al exportar")
        End Try

    End Sub
End Class