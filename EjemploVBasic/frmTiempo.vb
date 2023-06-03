Public Class frmTiempo
    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnDetenerTiempo_Click(sender As Object, e As EventArgs) Handles btnDetenerTiempo.Click
        tmrHora.Enabled = False
    End Sub

    Private Sub btnMostrarHora_Click(sender As Object, e As EventArgs) Handles btnMostrarHora.Click
        tmrHora.Enabled = True
    End Sub
End Class

