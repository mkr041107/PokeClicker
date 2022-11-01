Public Class CookieClicker
    Dim PPS As Integer = 11
    Dim UBallQuantity As Integer
    Dim GBallQuantity As Integer
    Dim MBallQuantity As Integer
    Dim UBallPrice As Integer
    Dim GBallPrice As Integer = 0.1
    Dim MBallPrice As Integer
    Dim AFarmQuantity As Integer
    Dim AFarmPrice As Integer
    Dim GBallUpgradePrice As Integer
    Dim UBallUpgadePrice As Integer
    Dim AFarmUpgradePice As Integer
    Dim MBallUpgradePrice As Integer
    Dim Pokeballs As Integer = 1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbMBall.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbUBall.Click

    End Sub

    Private Sub lblMBallName_Click(sender As Object, e As EventArgs) Handles lblMBallName.Click

    End Sub

    Private Sub lblPokeBalls_Click(sender As Object, e As EventArgs) Handles lblPokeBalls.Click

    End Sub
    Private Sub CookieClicker_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Pokeballs += 1
        lblPokeBalls.Text = "Pokeballs: " & Pokeballs
    End Sub

    Private Sub pbGBall_Click(sender As Object, e As EventArgs) Handles pbGBall.Click
        Pokeballs -= GBallPrice
        GBallPrice *= 1.15
        lblGBallPrice.Text = "Cost: " & GBallPrice
        GBallQuantity += 1
        lblGBallQuantity.Text = GBallQuantity
        PPS += 0.1
        lblPPS.Text = "PPS: " & PPS
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Pokeballs += PPS
        lblPPS.Text = "PPS: " & PPS
    End Sub
End Class