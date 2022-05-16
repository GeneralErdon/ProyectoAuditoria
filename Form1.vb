Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Hide()
        Dim ingreso As New Ingreso
        ingreso.ShowDialog()
        Close()


    End Sub
End Class
