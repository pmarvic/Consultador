Public Class lblDate
    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        lblHora.Text = TimeOfDay
        lblFecha.Text = DateAndTime.Now.ToLongDateString
    End Sub

    Private Sub btnTecladoVirtual_Click(sender As Object, e As EventArgs) Handles btnTecladoVirtual.Click
        Dim OTeclado As New frmTeclado
        OTeclado.ShowDialog()
    End Sub
End Class