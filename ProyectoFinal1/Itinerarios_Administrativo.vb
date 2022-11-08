Imports Negocios
Imports Modelos

Public Class Itinerarios_Administrativo
    Dim objDatosItinerario As New LnIntinerario()

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Menu_Administrativo.Show()
        Me.Close()

    End Sub



    Private Sub btnModificarItinerario_Click(sender As Object, e As EventArgs) Handles btnModificarItinerario.Click
        Try


            If dgItinerarios.SelectedRows.Count = 1 Then
                Dim Itinerario As New LnIntinerario
                Dim Intine As New mdItinerario

                Intine.itinerarioId = dgItinerarios.SelectedRows(0).Cells(0).Value
                Intine.aeropuertoDestinoId = dgItinerarios.SelectedRows(0).Cells(1).Value
                Intine.AeropuertoDestinoNombre = dgItinerarios.SelectedRows(0).Cells(2).Value
                Intine.PaisDestino = dgItinerarios.SelectedRows(0).Cells(3).Value
                Intine.aeropuertoOrigenId = dgItinerarios.SelectedRows(0).Cells(4).Value
                Intine.AeropuertoOrigenNombre = dgItinerarios.SelectedRows(0).Cells(5).Value
                Intine.PaisOrigen = dgItinerarios.SelectedRows(0).Cells(6).Value
                Intine.aerolineaId = dgItinerarios.SelectedRows(0).Cells(7).Value
                Intine.AerolineaNombre = dgItinerarios.SelectedRows(0).Cells(8).Value
                Intine.fechaSalida = dgItinerarios.SelectedRows(0).Cells(9).Value
                Intine.fechaLlegada = dgItinerarios.SelectedRows(0).Cells(10).Value
                Intine.Asientos = dgItinerarios.SelectedRows(0).Cells(11).Value
                Intine.avionId = dgItinerarios.SelectedRows(0).Cells(12).Value
                Intine.AvionNombre = dgItinerarios.SelectedRows(0).Cells(13).Value



                txt_Codigo.Text = Intine.itinerarioId
                cbPaisDesde.SelectedText = Intine.PaisOrigen
                cbPaisDesde.Text = Intine.PaisOrigen
                cbPaisHasta.SelectedText = Intine.PaisDestino
                cbPaisHasta.Text = Intine.PaisDestino
                cb_AeropuertoDestinoId.SelectedText = Intine.AeropuertoDestinoNombre
                cb_AeropuertoDestinoId.Text = Intine.AeropuertoDestinoNombre
                cb_AeropuertoOrigenId.SelectedText = Intine.AeropuertoOrigenNombre
                cb_AeropuertoOrigenId.Text = Intine.AeropuertoOrigenNombre
                cb_AerolineaId.SelectedText = Intine.AerolineaNombre
                cb_AerolineaId.Text = Intine.AerolineaNombre
                dp_FechaSalida.Text = Intine.fechaSalida
                dp_FechaLlegada.Text = Intine.fechaLlegada

                cb_AvionId.SelectedItem = Intine.AvionNombre
                Itinerario.ActualizarIntinerario(Intine.itinerarioId, Intine.aeropuertoDestinoId, Intine.aeropuertoOrigenId, Intine.aerolineaId, Intine.fechaSalida, Intine.fechaLlegada, Intine.Asientos, Intine.avionId)

                Dim ds As New DataSet
                ds = objDatosItinerario.ListaIntinerario
                dgItinerarios.DataSource = ds.Tables(0)



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo modificar el record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Itinerarios_Administrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dsItinerario As New DataSet
            dsItinerario = objDatosItinerario.ListaIntinerario
            dgItinerarios.DataSource = dsItinerario.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Dim objNegociosReserva As New Negocios.LnReserva

        Dim listPais = objNegociosReserva.obtenerPaises()

        Dim comboSource As New Dictionary(Of Integer, String)()

        For Each item As Modelos.mdPais In listPais

            comboSource.Add(item.ID, item.Nombre)
        Next

        cbPaisDesde.DataSource = New BindingSource(comboSource, Nothing)
        cbPaisDesde.DisplayMember = "Value"
        cbPaisDesde.ValueMember = "Key"

        cbPaisHasta.DataSource = New BindingSource(comboSource, Nothing)
        cbPaisHasta.DisplayMember = "Value"
        cbPaisHasta.ValueMember = "Key"

        Dim objAerolinea As New LnAerolineas

        Dim dataAero = objAerolinea.DevolverListaAerolineas()

        Dim comboSource2 As New Dictionary(Of Integer, String)()

        For Each row As DataRow In dataAero.Tables(0).Rows

            comboSource2.Add(row.ItemArray(0), row.ItemArray(1))

        Next

        cb_AerolineaId.DataSource = New BindingSource(comboSource2, Nothing)
        cb_AerolineaId.DisplayMember = "Value"
        cb_AerolineaId.ValueMember = "Key"



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Codigo.TextChanged

    End Sub

    Private Sub btnAgregarItinerario_Click(sender As Object, e As EventArgs) Handles btnAgregarItinerario.Click
        Try
            Dim Itinerario As New LnIntinerario
            Dim Intine As New mdItinerario

            Intine.aeropuertoDestinoId = cb_AeropuertoDestinoId.SelectedValue
            Intine.aeropuertoOrigenId = cb_AeropuertoOrigenId.SelectedValue
            Intine.aerolineaId = cb_AerolineaId.SelectedValue
            Intine.fechaSalida = dp_FechaSalida.Text
            Intine.fechaLlegada = dp_FechaLlegada.Text
            Intine.Asientos = txt_Asientos.Text
            Intine.avionId = cb_AvionId.SelectedValue
            Itinerario.InsertarIntinerario(Intine.aeropuertoDestinoId, Intine.aeropuertoOrigenId, Intine.aerolineaId, Intine.fechaSalida, Intine.fechaLlegada, Intine.Asientos, Intine.avionId)


            Dim ds As New DataSet
            ds = objDatosItinerario.ListaIntinerario
            dgItinerarios.DataSource = ds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEliminarItinerario_Click(sender As Object, e As EventArgs) Handles btnEliminarItinerario.Click
        Try
            If dgItinerarios.CurrentRow IsNot Nothing Then
                Dim objDatos As New LnIntinerario

                objDatos.BorrarIntinerario(dgItinerarios.Rows(dgItinerarios.CurrentRow.Index).Cells(0).Value)
                dgItinerarios.Rows.Remove(dgItinerarios.CurrentRow)
                MessageBox.Show("El dato itinerario fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show("El dato avion no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cbPaisDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaisDesde.SelectedIndexChanged

        ActualizarComboAeropuerto(DirectCast(cbPaisDesde.SelectedItem, KeyValuePair(Of Integer, String)).Key, cb_AeropuertoOrigenId)

    End Sub

    Public Sub ActualizarComboAeropuerto(paisId As Integer, combo As ComboBox)

        Try

            Dim objNegociosReserva As New Negocios.LnReserva

            Dim listAeropuertos = objNegociosReserva.obtenerAeropuertosxPais(paisId)

            Dim comboSource As New Dictionary(Of Integer, String)()

            For Each val As Modelos.mdAerpuertos In listAeropuertos

                comboSource.Add(val.AeropuertoId, val.NombreAeropuerto)

            Next

            combo.DataSource = New BindingSource(comboSource, Nothing)
            combo.DisplayMember = "Value"
            combo.ValueMember = "Key"
        Catch ex As Exception

        End Try



    End Sub

    Private Sub cbPaisHasta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaisHasta.SelectedIndexChanged
        ActualizarComboAeropuerto(DirectCast(cbPaisHasta.SelectedItem, KeyValuePair(Of Integer, String)).Key, cb_AeropuertoDestinoId)
    End Sub

    Private dstxtAsiento As DataSet

    Private Sub cb_AerolineaId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_AerolineaId.SelectedIndexChanged

        Try
            Dim objNegociosAvion As New Negocios.LnAvion
            Dim dataSourceAvionPorAerolinea = objNegociosAvion.DevolverAvionesPorAerolineaId(DirectCast(cb_AerolineaId.SelectedItem, KeyValuePair(Of Integer, String)).Key)
            Dim comboSource As New Dictionary(Of Integer, String)()

            For Each row As DataRow In dataSourceAvionPorAerolinea.Tables(0).Rows

                comboSource.Add(row.ItemArray(0), row.ItemArray(3))

            Next

            dstxtAsiento = dataSourceAvionPorAerolinea

            cb_AvionId.DataSource = New BindingSource(comboSource, Nothing)
            cb_AvionId.DisplayMember = "Value"
            cb_AvionId.ValueMember = "Key"

        Catch ex As Exception

        End Try

    End Sub

    Public Sub ActualizarTxtAsientos(ds As DataSet)
        Try

            For Each row As DataRow In ds.Tables(0).Rows

                ' Console.WriteLine(row + " " + DirectCast(cb_AerolineaId.SelectedItem, KeyValuePair(Of Integer, String)).Key)

                If DirectCast(cb_AvionId.SelectedItem, KeyValuePair(Of Integer, String)).Key = row.ItemArray(0) Then

                    txt_Asientos.Text = row.ItemArray(1)

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_AvionId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_AvionId.SelectedIndexChanged

        ActualizarTxtAsientos(dstxtAsiento)

    End Sub

    Private Sub dgItinerarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItinerarios.CellContentClick

    End Sub
End Class