Public Class Choose
    Private Sub btnCookieClicker_Click(sender As Object, e As EventArgs) Handles btnCookieClicker.Click
        Me.Hide()

        CookieClicker.ShowDialog()
        End
    End Sub

    Private Sub btnCookieClickerTimed_Click(sender As Object, e As EventArgs) Handles btnCookieClickerTimed.Click

        Me.Hide()
        form1.ShowDialog()
        End
    End Sub
End Class