Public Class VerificarSalida

    Private Sub btnSi_Click(sender As System.Object, e As System.EventArgs) Handles btnSi.Click
        Application.Exit()
    End Sub

    Private Sub btnNo_Click(sender As System.Object, e As System.EventArgs) Handles btnNo.Click

        Tienda.ShowDialog()
    End Sub

    Private Sub VerificarSalida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class