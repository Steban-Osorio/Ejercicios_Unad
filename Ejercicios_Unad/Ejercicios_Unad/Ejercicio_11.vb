Public Class Ejercicio_11
    Private Sub Ejercicio_11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCalcular11_Click(sender As Object, e As EventArgs) Handles ButtonCalcular11.Click
        TxEscala.Text = Val((100 * TxNota75.Text) / (TxValorCurso.Text * 0.75))
        TxEscala.Text = Val((5 * TxEscala.Text) / 100)
    End Sub

    Private Sub ButtonRetornar11_Click(sender As Object, e As EventArgs) Handles ButtonRetornar11.Click
        Close()
    End Sub
End Class