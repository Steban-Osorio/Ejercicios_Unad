Public Class Ejercicio_16
    Private Sub ButtonCalcular16_Click(sender As Object, e As EventArgs) Handles ButtonCalcular16.Click
        TxDistancia16.Text = Val(((TxTiempo16.Text + 0.5) * 9.81) * (TxTiempo16.Text * TxTiempo16.Text))
    End Sub

    Private Sub ButtonRetornar16_Click(sender As Object, e As EventArgs) Handles ButtonRetornar16.Click
        Close()
    End Sub
End Class