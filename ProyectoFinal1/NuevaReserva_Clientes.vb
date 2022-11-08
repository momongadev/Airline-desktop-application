
Public Class Nueva_Reserva
    Private Sub Nueva_Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    End Sub


    Private Sub cbPaisDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaisDesde.SelectedIndexChanged

        CargaTabla(DirectCast(cbPaisDesde.SelectedItem, KeyValuePair(Of Integer, String)).Key, dtgvAeropuertoOrigen)

    End Sub

    Public Sub CargaTabla(id As Integer, dtgv As DataGridView)
        Dim objNegociosReserva As New Negocios.LnReserva

        Dim listAeropuertos = objNegociosReserva.obtenerAeropuertosxPais(id)

        Dim tabla As New DataTable

        tabla.Columns.Add("ID")
        tabla.Columns.Add("Nombre")

        If (listAeropuertos.Count > 0) Then
            For Each item As Modelos.mdAerpuertos In listAeropuertos

                tabla.Rows.Add(item.AeropuertoId, item.NombreAeropuerto)

            Next
        Else
            tabla.Rows.Clear()
        End If

        dtgv.DataSource = tabla
    End Sub

    Private Sub cbPaisHasta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaisHasta.SelectedIndexChanged

        CargaTabla(DirectCast(cbPaisHasta.SelectedItem, KeyValuePair(Of Integer, String)).Key, dtgvAeropuertoDestino)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reservas_Cliente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Negocios.sesPaisDesdeIdDes = DirectCast(cbPaisDesde.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Negocios.sesPaisHastaIdDes = DirectCast(cbPaisHasta.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Negocios.sesCuandoViajaDes = dtpFechaViaje.Value.Date
        Negocios.sesCuandoRegresaDes = dtpFechaRegreso.Value.Date

        If dtgvAeropuertoDestino.SelectedRows.Count > 0 And dtgvAeropuertoOrigen.SelectedRows.Count > 0 Then

            Negocios.sesAeropuertoOrigenIdDes = dtgvAeropuertoOrigen.SelectedRows(0).Cells(0).Value
            Negocios.sesAeropuertoDestinoIdDes = dtgvAeropuertoDestino.SelectedRows(0).Cells(0).Value

            VueloRegreso.Show()
            Me.Close()
        Else
            MessageBox.Show("Escoja un aeropuerto destino y de origen")
        End If
    End Sub
End Class