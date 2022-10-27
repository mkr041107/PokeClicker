Public Class form1
    Dim t As Integer = 10
    Dim clicks As Integer = 0

    Private Sub Cookie_MouseDown(sender As Object, e As MouseEventArgs) Handles Cookie.MouseDown
        clicks += 1.2
        lblClicks.Text = clicks
        If (clicks = 1) Then
            tmrMain.Start()
        End If
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        t -= 1
        lblTime.Text = t
        If t = 0 Then
            tmrMain.Stop()
            Cookie.Enabled = False
        End If
    End Sub

    Private Sub form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            t = 10
            Cookie.Enabled = True
            clicks = 0
        End If
    End Sub
End Class
