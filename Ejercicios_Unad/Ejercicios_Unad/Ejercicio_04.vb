Public Class Ejercicio_04
    Private Sub Ejercicio_04_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxDistancia.Text = Val(((TxTiempo.Text + 0.5) * 9.81) * (TxTiempo.Text * TxTiempo.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class