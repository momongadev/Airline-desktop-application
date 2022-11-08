Imports Negocios
Imports Modelos
Public Class Aviones_Administrativo

    Dim objDatosAvion As New LnAvion()
    Dim objDatosAerolinea As New LnAerolineas()

    Private Sub btnAgregarAvion_Click(sender As Object, e As EventArgs) Handles btnAgregarAvion.Click
        Try
            Dim Avion As New LnAvion
            Dim Avi As New mdAviones

            Avi.Capacidad = txt_Capacidad.Text
            Avi.aerolineaId = cb_CodAerolinea.SelectedValue
            Avi.nombre = txt_NombreAvion.Text



            Avion.InsertarAvion(Avi.Capacidad, Avi.aerolineaId, Avi.nombre)


            Dim ds As New DataSet
            ds = objDatosAvion.ListaAvion
            dgAvion.DataSource = ds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Aviones_Administrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' esta parte es para el datagrid 
            Dim dsAviones As New DataSet
            dsAviones = objDatosAvion.ListaAvion
            dgAvion.DataSource = dsAviones.Tables(0)
            'la lista se actualiza cada vez que se abre el formulario porque se carga en el load
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'esto es para el combox de aerolineas
            Dim dsAerolineas As New DataSet
            dsAerolineas = objDatosAerolinea.DevolverListaAerolineas

            cb_CodAerolinea.DataSource = dsAerolineas.Tables(0)
            cb_CodAerolinea.ValueMember = "aerolineaId"
            cb_CodAerolinea.DisplayMember = "nombre"




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnModificarAvion_Click(sender As Object, e As EventArgs) Handles btnModificarAvion.Click

        Try


            If dgAvion.SelectedRows.Count = 1 Then
                Dim avion As New mdAviones

                avion.AvionId = dgAvion.SelectedRows(0).Cells(0).Value
                avion.nombre = dgAvion.SelectedRows(0).Cells(1).Value
                avion.Capacidad = dgAvion.SelectedRows(0).Cells(2).Value
                avion.Nombre_aerolinea = dgAvion.SelectedRows(0).Cells(3).Value

                txt_CodAvion.Text = avion.AvionId
                txt_NombreAvion.Text = avion.nombre
                txt_Capacidad.Text = avion.Capacidad
                cb_CodAerolinea.SelectedText = avion.Nombre_aerolinea ' este selecciona el item del combo box
                cb_CodAerolinea.Text = avion.Nombre_aerolinea ' este lo muestra 

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo modificar el record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try
            Dim Avion As New LnAvion
            Dim Avi As New mdAviones

            Avi.Capacidad = txt_Capacidad.Text
            Avi.aerolineaId = cb_CodAerolinea.SelectedValue
            Avi.nombre = txt_NombreAvion.Text
            Avi.AvionId = txt_CodAvion.Text



            Avion.ActualizarAvion(Avi.Capacidad, Avi.AvionId, Avi.aerolineaId, Avi.nombre)


            Dim ds As New DataSet
            ds = objDatosAvion.ListaAvion
            dgAvion.DataSource = ds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEliminarAvion_Click(sender As Object, e As EventArgs) Handles btnEliminarAvion.Click
        Try
            If dgAvion.CurrentRow IsNot Nothing Then
                Dim objDatos As New LnAeropuerto
                objDatos.BorrarAeropuerto(dgAvion.Rows(dgAvion.CurrentRow.Index).Cells(0).Value)
                dgAvion.Rows.Remove(dgAvion.CurrentRow)
                MessageBox.Show("El dato avion fue eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show("El dato avion no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class