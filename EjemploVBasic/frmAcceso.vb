Public Class frmAcceso
    Function Validar_Contrasena()
        If txtUsuario.Text = "Supervisor" And txtContrasena.Text = "456" Then
            MsgBox("Bienvenido", , "MedicalCenter")
            Me.Hide()
            frmMenuPrincipal.Show()
            txtUsuario.BackColor = Color.White
            txtContrasena.BackColor = Color.White
        Else
            MsgBox("Usuarioyt contraseña incorrectos", , "MedicaCenter")
            txtUsuario.Text = ""
            txtContrasena.Text = ""
            txtUsuario.Focus()
            txtUsuario.BackColor = Color.Violet
            txtContrasena.BackColor = Color.Violet
            'comentarios
        End If
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Validar_Contrasena()

    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged

    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Validar_Contrasena()
        End If
    End Sub
End Class
