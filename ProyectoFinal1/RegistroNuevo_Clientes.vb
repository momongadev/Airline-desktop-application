Imports Negocios
Public Class RegistroNuevo_Clientes
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        MenuValidacion.Show()
    End Sub

    Dim objDatos As New LnCliente()

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        'If String.IsNullOrEmpty(txtApellido1.Text) OrElse String.IsNullOrEmpty(txtApellido2.Text) OrElse String.IsNullOrEmpty(txtIdentificacion.Text) OrElse String.IsNullOrEmpty(txtNacionalidad.Text) OrElse String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrEmpty(txt_ConfirmarContraseña.Text) OrElse String.IsNullOrEmpty(txt_NuevaContraseña.Text) OrElse String.IsNullOrEmpty(txt_Usuario.Text) OrElse String.IsNullOrEmpty(cbGenero.SelectedItem) Then
        ' MessageBox.Show("Algo esta vacio :c")
        'Else

        If txt_NuevaContraseña.Text <> txt_ConfirmarContraseña.Text Then
                MessageBox.Show("Las contraseñas no coinciden :c")

            Else
                If objDatos.InsertarCliente(txtIdentificacion.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, cbGenero.SelectedItem, txtNacionalidad.Text, dtpFechaNacimiento.Value, txt_Usuario.Text, txt_NuevaContraseña.Text) Then
                    MessageBox.Show("Se guardo correctamente c:")
                Else
                    MessageBox.Show("No se guardo nada :c")
                End If

            End If
        'End If

    End Sub
End Class