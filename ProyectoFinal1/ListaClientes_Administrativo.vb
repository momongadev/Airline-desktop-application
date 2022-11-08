Imports Datos

Imports Negocios
Public Class ListaClientes_Administrativo

    Dim objDatos As New LnCliente()



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Try
            Menu_Administrativo.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnVolverListCli_Click(sender As Object, e As EventArgs) Handles btnVolverListCli.Click
        Try
            Menu_Administrativo.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ListaClientes_Administrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DataSet
            ds = objDatos.ConsultarListaClientes
            dtgvListaClientes.DataSource = ds.Tables(0)
            'la lista se actualiza cada vez que se abre el formulario porque se carga en el load

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnModReserva_Click(sender As Object, e As EventArgs) Handles btnModReserva.Click
        Try

            If dtgvListaClientes.SelectedRows(0).Cells.Count > 0 Then

                sesId = dtgvListaClientes.SelectedRows(0).Cells(0).Value
                sesIdentificacion = dtgvListaClientes.SelectedRows(0).Cells(1).Value

                sesNombre = dtgvListaClientes.SelectedRows(0).Cells(2).Value
                sesApellido1 = dtgvListaClientes.SelectedRows(0).Cells(3).Value
                sesApellido2 = dtgvListaClientes.SelectedRows(0).Cells(4).Value
                sesGenero = dtgvListaClientes.SelectedRows(0).Cells(5).Value
                sesNacionalidad = dtgvListaClientes.SelectedRows(0).Cells(6).Value
                sesFechaNacimiento = dtgvListaClientes.SelectedRows(0).Cells(7).Value
                sesUsuario = dtgvListaClientes.SelectedRows(0).Cells(8).Value
                sesContrasenia = dtgvListaClientes.SelectedRows(0).Cells(9).Value
                Reservas_Cliente.Show()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim ds As New DataSet
            ds = objDatos.ConsultarListaClientes
            dtgvListaClientes.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class