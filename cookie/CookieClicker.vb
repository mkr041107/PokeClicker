Public Class CookieClicker
    Dim PPS As Integer
    Dim UBallQuantity As Integer
    Dim GBallQuantity As Integer
    Dim MBallQuantity As Integer
    Dim UBallPrice As Integer
    Dim GBallPice As Integer
    Dim MBallPrice As Integer
    Dim AFarmQuantity As Integer
    Dim AFarmPrice As Integer
    Dim GBallUpgradePrice As Integer
    Dim UBallUpgadePrice As Integer
    Dim AFarmUpgradePice As Integer
    Dim MBallUpgradePrice As Integer
    Dim clicks As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbMBall.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbGBall.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbUBall.Click

    End Sub

    Private Sub lblMBallName_Click(sender As Object, e As EventArgs) Handles lblMBallName.Click

    End Sub

    Private Sub lblPokeBalls_Click(sender As Object, e As EventArgs) Handles lblPokeBalls.Click

    End Sub

    Private Sub CookieClicker_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub

    Private Sub CookieClicker_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        clicks += 1
        lblPokeBalls.Text = clicks
    End Sub
End Class