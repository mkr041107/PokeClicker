Public Class CookieClicker
    Dim PPS As Double = 0.0
    Dim UBallQuantity As Integer
    Dim GBallQuantity As Integer
    Dim MBallQuantity As Integer
    Dim UBallPrice As Integer = 100
    Dim GBallPrice As Integer = 15
    Dim MBallPrice As Integer = 12000
    Dim AFarmQuantity As Integer = 100
    Dim AFarmPrice As Integer
    Dim GBallUpgradePrice As Integer = 100
    Dim UBallUpgadePrice As Integer = 1000
    Dim AFarmUpgradePice As Integer = 11000
    Dim MBallUpgradePrice As Integer = 1200000
    Dim Pokeballs As Double = 0.0
    Dim GBallUpgradeQuantity As Integer = 0
    Dim UBallUpgradeQuantity As Integer = 0
    Dim AFarmUpgradeQuantity As Integer = 0
    Dim MBallUpgradeQuantity As Integer = 0


    Private Sub lblMBallName_Click(sender As Object, e As EventArgs) Handles lblMBallName.Click

    End Sub

    Private Sub lblPokeBalls_Click(sender As Object, e As EventArgs) Handles lblPokeBalls.Click

    End Sub
    Private Sub CookieClicker_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Pokeballs += 1
        lblPokeBalls.Text = "Pokeballs: " & Pokeballs
    End Sub

    Private Sub pbGBall_Click(sender As Object, e As EventArgs) Handles pbGBall.Click
        If (Pokeballs > GBallPrice) Then
            Pokeballs -= GBallPrice
            GBallPrice *= 1.15
            lblGBallPrice.Text = "Cost: " & GBallPrice
            GBallQuantity += 1
            lblGBallQuantity.Text = GBallQuantity

            If (GBallUpgradeQuantity = 1) Then
                PPS += 0.1 * 2
            Else
                PPS += 0.1
            End If
            lblPPS.Text = "PPS: " & PPS
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Pokeballs += PPS
        lblPokeBalls.Text = "Pokèball " & Pokeballs

    End Sub

    Private Sub pbUBall_Click(sender As Object, e As EventArgs) Handles pbUBall.Click
        If (Pokeballs > UBallPrice) Then
            Pokeballs -= UBallPrice
            UBallPrice *= 1.15
            lblUBallPrice.Text = "Cost: " & UBallPrice
            UBallQuantity += 1
            lblUBallQuantity.Text = UBallQuantity
            If (UBallUpgradeQuantity = 1) Then
                PPS += 0.1 * 2
            Else
                PPS += 0.1
            End If
            lblPPS.Text = "PPS: " & PPS
        End If
    End Sub

    Private Sub pbAFarm_Click(sender As Object, e As EventArgs) Handles pbAFarm.Click
        If (Pokeballs > AFarmPrice) Then
            Pokeballs -= AFarmPrice
            AFarmPrice *= 1.15
            lblAFarmPrice.Text = "Cost: " & AFarmPrice
            AFarmQuantity += 1
            lblAFarmQuantity.Text = AFarmQuantity

            If AFarmUpgradeQuantity = 1 Then
                PPS += 8 * 2
            Else
                PPS += 8
            End If
            lblPPS.Text = "PPS: " & PPS
        End If
    End Sub

    Private Sub pbMBall_Click(sender As Object, e As EventArgs) Handles pbMBall.Click
        If (Pokeballs > MBallPrice) Then
            Pokeballs -= MBallPrice
            MBallPrice *= 1.15
            lblMBallPrice.Text = "Cost: " & MBallPrice
            MBallQuantity += 1
            lblMBallQuantity.Text = MBallQuantity
            If MBallUpgradeQuantity = 1 Then
                PPS += 47 * 2
            Else
                PPS += 47
            End If
            lblPPS.Text = "PPS: " & PPS
        End If
    End Sub

    Private Sub lblGBallQuantity_Click(sender As Object, e As EventArgs) Handles lblGBallQuantity.Click

    End Sub

    Private Sub lblAFarmPrice_Click(sender As Object, e As EventArgs) Handles lblAFarmPrice.Click

    End Sub

    Private Sub pbMBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbMBallUpgrade.Click
        If (Pokeballs >= MBallUpgradePrice) Then
            MBallUpgradeQuantity += 1
            Pokeballs -= MBallUpgradePrice
            pbMBallUpgrade.Enabled = False
        End If
    End Sub


    Private Sub pbGBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbGBallUpgrade.Click
        If Pokeballs >= GBallUpgradePrice Then
            GBallUpgradeQuantity += 1
            Pokeballs -= GBallUpgradePrice
            pbAFarmUpgrade.Enabled = False
        End If
    End Sub

    Private Sub pbAFarmUpgrade_Click(sender As Object, e As EventArgs) Handles pbAFarmUpgrade.Click
        If Pokeballs >= GBallUpgradePrice Then
            AFarmUpgradeQuantity += 1
            Pokeballs -= AFarmUpgradePice
            pbAFarmUpgrade.Enabled = False
        End If
    End Sub

    Private Sub pbUBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbUBallUpgrade.Click
        If Pokeballs >= UBallUpgadePrice Then
            UBallUpgradeQuantity += 1
            Pokeballs -= UBallUpgadePrice
            pbUBallUpgrade.Enabled = False
        End If
    End Sub
End Class