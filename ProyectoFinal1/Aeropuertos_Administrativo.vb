Imports Negocios
Imports Modelos
Public Class Aeropuertos_Administrativo

    Dim objDatos As New LnAeropuerto()
    Dim objDatos_Pais As New LnPais()
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Try
            Menu_Administrativo.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se completar la accion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Dim Aeropuerto As New LnAeropuerto
            Dim Aero As New mdAerpuertos

            Aero.NombreAeropuerto = txt_Nombre_Aeropuerto.Text
            Aero.Paisid = cbPais.SelectedValue


            Aeropuerto.InsertarAeropuerto(Aero.NombreAeropuerto, Aero.Paisid)


            Dim ds As New DataSet
            ds = objDatos.ListaAeropuertos
            dgAeropuerto.DataSource = ds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Aeropuertos_Administrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DataSet
            ds = objDatos.ListaAeropuertos
            dgAeropuerto.DataSource = ds.Tables(0)
            'la lista se actualiza cada vez que se abre el formulario porque se carga en el load

            '''''''''''''''''''''''''''''para el combox de pais
            Dim dsPais As New DataSet
            dsPais = objDatos_Pais.ListaPais

            cbPais.DataSource = dsPais.Tables(0)
            cbPais.ValueMember = "PaisId"
            cbPais.DisplayMember = "nombre_pais"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgAeropuerto.SelectedRows.Count = 1 Then
                Dim aeropuerto As New mdAerpuertos

                aeropuerto.AeropuertoId = dgAeropuerto.SelectedRows(0).Cells(0).Value
                aeropuerto.NombreAeropuerto = dgAeropuerto.SelectedRows(0).Cells(1).Value
                aeropuerto.NombrePais = dgAeropuerto.SelectedRows(0).Cells(2).Value

                txt_CodAeropuerto.Text = aeropuerto.AeropuertoId
                txt_Nombre_Aeropuerto.Text = aeropuerto.NombreAeropuerto
                cbPais.SelectedText = aeropuerto.NombrePais
                cbPais.Text = aeropuerto.NombrePais


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo modificar el dato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try


            If dgAeropuerto.CurrentRow IsNot Nothing Then
                Dim objDatos As New LnAeropuerto
                objDatos.BorrarAeropuerto(dgAeropuerto.Rows(dgAeropuerto.CurrentRow.Index).Cells(0).Value)
                dgAeropuerto.Rows.Remove(dgAeropuerto.CurrentRow)
                MessageBox.Show("El aeropuerto fue eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show("El aeropuerto no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnActualizardatos_Click(sender As Object, e As EventArgs) Handles btnActualizardatos.Click

        Try
            Dim Aeropuerto As New LnAeropuerto
            Dim Aero As New mdAerpuertos

            Aero.NombreAeropuerto = txt_Nombre_Aeropuerto.Text
            Aero.Paisid = cbPais.SelectedValue
            Aero.AeropuertoId = txt_CodAeropuerto.Text


            Aeropuerto.ActualizarAeropuerto(Aero.NombreAeropuerto, Aero.Paisid, Aero.AeropuertoId)


            Dim ds As New DataSet
            ds = objDatos.ListaAeropuertos
            dgAeropuerto.DataSource = ds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class