Public Class CookieClicker
    'vars
    Dim PPS As Double = 0.0
    Dim UBallQuantity As Integer = 0
    Dim GBallQuantity As Integer = 0
    Dim MBallQuantity As Integer = 0
    Dim UBallPrice As Integer = 100
    Dim GBallPrice As Integer = 15
    Dim MBallPrice As Integer = 12000
    Dim AFarmQuantity As Integer = 0
    Dim AFarmPrice As Integer = 1100
    Dim GBallUpgradePrice As Integer = 100
    Dim UBallUpgadePrice As Integer = 1000
    Dim AFarmUpgradePice As Integer = 11000
    Dim MBallUpgradePrice As Integer = 1200000
    Dim Pokeballs As Double = 0.0
    Dim GBallUpgradeQuantity As Integer = 0
    Dim UBallUpgradeQuantity As Integer = 0
    Dim AFarmUpgradeQuantity As Integer = 0
    Dim MBallUpgradeQuantity As Integer = 0
    Dim PokeballUpgradePrice As Integer = 100
    Dim PokeballUpgradeQuantity As Integer = 0

    Private Sub CookieClicker_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        'clicking
        If PokeballUpgradeQuantity = 1 Then
            Pokeballs += 2
        Else
            Pokeballs += 1
        End If
        lblPokeBalls.Text = "Pokèballs: " & Pokeballs

    End Sub

    Private Sub pbGBall_Click(sender As Object, e As EventArgs) Handles pbGBall.Click
        '1st building
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
        'timer to update the values
        Pokeballs += PPS
        lblPokeBalls.Text = "Pokèballs: " & Pokeballs

    End Sub

    Private Sub pbUBall_Click(sender As Object, e As EventArgs) Handles pbUBall.Click
        'second building
        If (Pokeballs > UBallPrice) Then
            Pokeballs -= UBallPrice
            UBallPrice *= 1.15
            lblUBallPrice.Text = "Cost: " & UBallPrice
            UBallQuantity += 1
            lblUBallQuantity.Text = UBallQuantity
            If (UBallUpgradeQuantity = 1) Then
                PPS += 1 * 2
            Else
                PPS += 1
            End If
            lblPPS.Text = "PPS: " & PPS
        End If
    End Sub

    Private Sub pbAFarm_Click(sender As Object, e As EventArgs) Handles pbAFarm.Click
        'third building
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
        'fourth building
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

    Private Sub pbMBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbMBallUpgrade.Click
        '4th building upgrade
        If (Pokeballs >= MBallUpgradePrice) Then
            MBallUpgradeQuantity += 1
            PPS = (MBallQuantity * 47) * 2
            lblPPS.Text = "PPS: " & PPS
            Pokeballs -= MBallUpgradePrice
            pbMBallUpgrade.Enabled = False
        End If
    End Sub


    Private Sub pbGBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbGBallUpgrade.Click
        '1st building upgrade
        If Pokeballs >= GBallUpgradePrice Then
            GBallUpgradeQuantity += 1
            PPS = (GBallQuantity / 10) * 2
            lblPPS.Text = "PPS: " & PPS
            Pokeballs -= GBallUpgradePrice
            pbAFarmUpgrade.Enabled = False
        End If
    End Sub

    Private Sub pbAFarmUpgrade_Click(sender As Object, e As EventArgs) Handles pbAFarmUpgrade.Click
        'third building upgrade
        If Pokeballs >= GBallUpgradePrice Then
            AFarmUpgradeQuantity += 1
            PPS = (AFarmQuantity * 8) * 2
            lblPPS.Text = "PPS: " & PPS
            Pokeballs -= AFarmUpgradePice
            pbAFarmUpgrade.Enabled = False
        End If
    End Sub

    Private Sub pbUBallUpgrade_Click(sender As Object, e As EventArgs) Handles pbUBallUpgrade.Click
        'second building upgrade
        If Pokeballs >= UBallUpgadePrice Then
            UBallUpgradeQuantity += 1
            PPS = (UBallQuantity * 2)
            lblPPS.Text = "PPS: " & PPS
            Pokeballs -= UBallUpgadePrice
            pbUBallUpgrade.Enabled = False
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbPokeballUpgrade.Click
        'mouse upgrade
        If Pokeballs >= PokeballUpgradePrice Then

            Pokeballs -= PokeballUpgradePrice
            PokeballUpgradeQuantity += 1
            pbPokeballUpgrade.Enabled = False
        End If
    End Sub
End Class