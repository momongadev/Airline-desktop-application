Imports Negocios

Public Class MenuValidacion
    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        RegistroNuevo_Clientes.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim objNegocios As New LnCliente()

        Try
            If (objNegocios.ExisteCliente(txtUsuario.Text, txtContrasenia.Text)) Then


                If sesTipoUsuario = 1 Then
                    MessageBox.Show("El Usuario existe en el sistema")
                    Reservas_Cliente.Show()
                Else
                    MessageBox.Show("Bienvenido " + sesUsuario)
                    Menu_Administrativo.Show()
                End If


            Else
                txtUsuario.Clear()
                txtContrasenia.Clear()
                MessageBox.Show(" El Usuario no existe en el sistema, favor revisar")
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub MenuValidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
