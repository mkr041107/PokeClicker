<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CookieClicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPokeBalls = New System.Windows.Forms.Label()
        Me.lblGBallName = New System.Windows.Forms.Label()
        Me.lblGBallQuantity = New System.Windows.Forms.Label()
        Me.lblUBallPrice = New System.Windows.Forms.Label()
        Me.lblUBallQuantity = New System.Windows.Forms.Label()
        Me.lblAFarmPrice = New System.Windows.Forms.Label()
        Me.lblAFarmQuantity = New System.Windows.Forms.Label()
        Me.lblMBallPrice = New System.Windows.Forms.Label()
        Me.lblMBallQuantity = New System.Windows.Forms.Label()
        Me.lblAFarmName = New System.Windows.Forms.Label()
        Me.lblMBallName = New System.Windows.Forms.Label()
        Me.lblUBallName = New System.Windows.Forms.Label()
        Me.lblGBallPrice = New System.Windows.Forms.Label()
        Me.lblGBallUpgradeName = New System.Windows.Forms.Label()
        Me.lblAFarmUpgradeName = New System.Windows.Forms.Label()
        Me.lblMBallUpgradeName = New System.Windows.Forms.Label()
        Me.lblUBallUpgradeName = New System.Windows.Forms.Label()
        Me.lblGBallUpgradePrice = New System.Windows.Forms.Label()
        Me.lblAFarmUpgradePrice = New System.Windows.Forms.Label()
        Me.lblMBallUpgradePrice = New System.Windows.Forms.Label()
        Me.lblUBallUpgradePrice = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPPS = New System.Windows.Forms.Label()
        Me.pbPokeballUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbAFarm = New System.Windows.Forms.PictureBox()
        Me.pbGBallUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbUBallUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbMBallUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbAFarmUpgrade = New System.Windows.Forms.PictureBox()
        Me.pbUBall = New System.Windows.Forms.PictureBox()
        Me.pbGBall = New System.Windows.Forms.PictureBox()
        Me.pbMBall = New System.Windows.Forms.PictureBox()
        Me.Pokeball = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbPokeballUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAFarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGBallUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUBallUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMBallUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAFarmUpgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pokeball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPokeBalls
        '
        Me.lblPokeBalls.AutoSize = True
        Me.lblPokeBalls.Location = New System.Drawing.Point(119, 77)
        Me.lblPokeBalls.Name = "lblPokeBalls"
        Me.lblPokeBalls.Size = New System.Drawing.Size(66, 13)
        Me.lblPokeBalls.TabIndex = 3
        Me.lblPokeBalls.Text = "PokèBalls: 0"
        '
        'lblGBallName
        '
        Me.lblGBallName.AutoSize = True
        Me.lblGBallName.Location = New System.Drawing.Point(664, 189)
        Me.lblGBallName.Name = "lblGBallName"
        Me.lblGBallName.Size = New System.Drawing.Size(61, 13)
        Me.lblGBallName.TabIndex = 19
        Me.lblGBallName.Text = "Great Balls:"
        '
        'lblGBallQuantity
        '
        Me.lblGBallQuantity.AutoSize = True
        Me.lblGBallQuantity.Location = New System.Drawing.Point(676, 202)
        Me.lblGBallQuantity.Name = "lblGBallQuantity"
        Me.lblGBallQuantity.Size = New System.Drawing.Size(0, 13)
        Me.lblGBallQuantity.TabIndex = 20
        Me.lblGBallQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUBallPrice
        '
        Me.lblUBallPrice.AutoSize = True
        Me.lblUBallPrice.Location = New System.Drawing.Point(676, 268)
        Me.lblUBallPrice.Name = "lblUBallPrice"
        Me.lblUBallPrice.Size = New System.Drawing.Size(52, 13)
        Me.lblUBallPrice.TabIndex = 22
        Me.lblUBallPrice.Text = "Cost: 100"
        '
        'lblUBallQuantity
        '
        Me.lblUBallQuantity.AutoSize = True
        Me.lblUBallQuantity.Location = New System.Drawing.Point(676, 251)
        Me.lblUBallQuantity.Name = "lblUBallQuantity"
        Me.lblUBallQuantity.Size = New System.Drawing.Size(0, 13)
        Me.lblUBallQuantity.TabIndex = 21
        '
        'lblAFarmPrice
        '
        Me.lblAFarmPrice.AutoSize = True
        Me.lblAFarmPrice.Location = New System.Drawing.Point(676, 336)
        Me.lblAFarmPrice.Name = "lblAFarmPrice"
        Me.lblAFarmPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblAFarmPrice.TabIndex = 24
        Me.lblAFarmPrice.Text = "Cost: 1000"
        '
        'lblAFarmQuantity
        '
        Me.lblAFarmQuantity.AutoSize = True
        Me.lblAFarmQuantity.Location = New System.Drawing.Point(676, 319)
        Me.lblAFarmQuantity.Name = "lblAFarmQuantity"
        Me.lblAFarmQuantity.Size = New System.Drawing.Size(0, 13)
        Me.lblAFarmQuantity.TabIndex = 23
        '
        'lblMBallPrice
        '
        Me.lblMBallPrice.AutoSize = True
        Me.lblMBallPrice.Location = New System.Drawing.Point(676, 400)
        Me.lblMBallPrice.Name = "lblMBallPrice"
        Me.lblMBallPrice.Size = New System.Drawing.Size(64, 13)
        Me.lblMBallPrice.TabIndex = 26
        Me.lblMBallPrice.Text = "Cost: 12000"
        '
        'lblMBallQuantity
        '
        Me.lblMBallQuantity.AutoSize = True
        Me.lblMBallQuantity.Location = New System.Drawing.Point(676, 383)
        Me.lblMBallQuantity.Name = "lblMBallQuantity"
        Me.lblMBallQuantity.Size = New System.Drawing.Size(0, 13)
        Me.lblMBallQuantity.TabIndex = 25
        '
        'lblAFarmName
        '
        Me.lblAFarmName.AutoSize = True
        Me.lblAFarmName.Location = New System.Drawing.Point(676, 302)
        Me.lblAFarmName.Name = "lblAFarmName"
        Me.lblAFarmName.Size = New System.Drawing.Size(74, 13)
        Me.lblAFarmName.TabIndex = 27
        Me.lblAFarmName.Text = "Apricot Farms:"
        '
        'lblMBallName
        '
        Me.lblMBallName.AutoSize = True
        Me.lblMBallName.Location = New System.Drawing.Point(675, 367)
        Me.lblMBallName.Name = "lblMBallName"
        Me.lblMBallName.Size = New System.Drawing.Size(62, 13)
        Me.lblMBallName.TabIndex = 28
        Me.lblMBallName.Text = "Mater Balls:"
        '
        'lblUBallName
        '
        Me.lblUBallName.AutoSize = True
        Me.lblUBallName.Location = New System.Drawing.Point(673, 238)
        Me.lblUBallName.Name = "lblUBallName"
        Me.lblUBallName.Size = New System.Drawing.Size(52, 13)
        Me.lblUBallName.TabIndex = 29
        Me.lblUBallName.Text = "Ultra Ball:"
        '
        'lblGBallPrice
        '
        Me.lblGBallPrice.AutoSize = True
        Me.lblGBallPrice.Location = New System.Drawing.Point(676, 220)
        Me.lblGBallPrice.Name = "lblGBallPrice"
        Me.lblGBallPrice.Size = New System.Drawing.Size(46, 13)
        Me.lblGBallPrice.TabIndex = 30
        Me.lblGBallPrice.Text = "Cost: 15"
        '
        'lblGBallUpgradeName
        '
        Me.lblGBallUpgradeName.AutoSize = True
        Me.lblGBallUpgradeName.Location = New System.Drawing.Point(371, 95)
        Me.lblGBallUpgradeName.Name = "lblGBallUpgradeName"
        Me.lblGBallUpgradeName.Size = New System.Drawing.Size(92, 13)
        Me.lblGBallUpgradeName.TabIndex = 31
        Me.lblGBallUpgradeName.Text = "Ancient Great Ball"
        '
        'lblAFarmUpgradeName
        '
        Me.lblAFarmUpgradeName.AutoSize = True
        Me.lblAFarmUpgradeName.Location = New System.Drawing.Point(372, 217)
        Me.lblAFarmUpgradeName.Name = "lblAFarmUpgradeName"
        Me.lblAFarmUpgradeName.Size = New System.Drawing.Size(91, 13)
        Me.lblAFarmUpgradeName.TabIndex = 32
        Me.lblAFarmUpgradeName.Text = "Auto Apricot Farm"
        '
        'lblMBallUpgradeName
        '
        Me.lblMBallUpgradeName.AutoSize = True
        Me.lblMBallUpgradeName.Location = New System.Drawing.Point(381, 358)
        Me.lblMBallUpgradeName.Name = "lblMBallUpgradeName"
        Me.lblMBallUpgradeName.Size = New System.Drawing.Size(54, 13)
        Me.lblMBallUpgradeName.TabIndex = 33
        Me.lblMBallUpgradeName.Text = "Beast Ball"
        '
        'lblUBallUpgradeName
        '
        Me.lblUBallUpgradeName.AutoSize = True
        Me.lblUBallUpgradeName.Location = New System.Drawing.Point(541, 93)
        Me.lblUBallUpgradeName.Name = "lblUBallUpgradeName"
        Me.lblUBallUpgradeName.Size = New System.Drawing.Size(88, 13)
        Me.lblUBallUpgradeName.TabIndex = 34
        Me.lblUBallUpgradeName.Text = "Ancient Ultra Ball"
        '
        'lblGBallUpgradePrice
        '
        Me.lblGBallUpgradePrice.AutoSize = True
        Me.lblGBallUpgradePrice.Location = New System.Drawing.Point(381, 9)
        Me.lblGBallUpgradePrice.Name = "lblGBallUpgradePrice"
        Me.lblGBallUpgradePrice.Size = New System.Drawing.Size(49, 13)
        Me.lblGBallUpgradePrice.TabIndex = 35
        Me.lblGBallUpgradePrice.Text = "Cost:100"
        '
        'lblAFarmUpgradePrice
        '
        Me.lblAFarmUpgradePrice.AutoSize = True
        Me.lblAFarmUpgradePrice.Location = New System.Drawing.Point(372, 130)
        Me.lblAFarmUpgradePrice.Name = "lblAFarmUpgradePrice"
        Me.lblAFarmUpgradePrice.Size = New System.Drawing.Size(61, 13)
        Me.lblAFarmUpgradePrice.TabIndex = 36
        Me.lblAFarmUpgradePrice.Text = "Cost:11000"
        '
        'lblMBallUpgradePrice
        '
        Me.lblMBallUpgradePrice.AutoSize = True
        Me.lblMBallUpgradePrice.Location = New System.Drawing.Point(381, 251)
        Me.lblMBallUpgradePrice.Name = "lblMBallUpgradePrice"
        Me.lblMBallUpgradePrice.Size = New System.Drawing.Size(70, 13)
        Me.lblMBallUpgradePrice.TabIndex = 37
        Me.lblMBallUpgradePrice.Text = "Cost: 120000"
        '
        'lblUBallUpgradePrice
        '
        Me.lblUBallUpgradePrice.AutoSize = True
        Me.lblUBallUpgradePrice.Location = New System.Drawing.Point(541, 9)
        Me.lblUBallUpgradePrice.Name = "lblUBallUpgradePrice"
        Me.lblUBallUpgradePrice.Size = New System.Drawing.Size(55, 13)
        Me.lblUBallUpgradePrice.TabIndex = 38
        Me.lblUBallUpgradePrice.Text = "Cost:1000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblPPS
        '
        Me.lblPPS.AutoSize = True
        Me.lblPPS.Location = New System.Drawing.Point(119, 120)
        Me.lblPPS.Name = "lblPPS"
        Me.lblPPS.Size = New System.Drawing.Size(49, 13)
        Me.lblPPS.TabIndex = 39
        Me.lblPPS.Text = "PPS: 0.0"
        '
        'pbPokeballUpgrade
        '
        Me.pbPokeballUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPokeballUpgrade.Image = Global.cookie.My.Resources.Resources.Ancient_Poke_Ball_Glamour
        Me.pbPokeballUpgrade.Location = New System.Drawing.Point(679, 0)
        Me.pbPokeballUpgrade.Name = "pbPokeballUpgrade"
        Me.pbPokeballUpgrade.Size = New System.Drawing.Size(117, 124)
        Me.pbPokeballUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPokeballUpgrade.TabIndex = 40
        Me.pbPokeballUpgrade.TabStop = False
        '
        'pbAFarm
        '
        Me.pbAFarm.Image = Global.cookie.My.Resources.Resources._635556544299235574_2991773832_copy
        Me.pbAFarm.Location = New System.Drawing.Point(578, 302)
        Me.pbAFarm.Name = "pbAFarm"
        Me.pbAFarm.Size = New System.Drawing.Size(63, 59)
        Me.pbAFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAFarm.TabIndex = 18
        Me.pbAFarm.TabStop = False
        '
        'pbGBallUpgrade
        '
        Me.pbGBallUpgrade.Image = Global.cookie.My.Resources.Resources._120px_Ancient_Great_Ball_Glamour
        Me.pbGBallUpgrade.Location = New System.Drawing.Point(367, 0)
        Me.pbGBallUpgrade.Name = "pbGBallUpgrade"
        Me.pbGBallUpgrade.Size = New System.Drawing.Size(159, 113)
        Me.pbGBallUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGBallUpgrade.TabIndex = 17
        Me.pbGBallUpgrade.TabStop = False
        '
        'pbUBallUpgrade
        '
        Me.pbUBallUpgrade.Image = Global.cookie.My.Resources.Resources._120px_Ancient_Ultra_Ball_Glamour
        Me.pbUBallUpgrade.Location = New System.Drawing.Point(532, 0)
        Me.pbUBallUpgrade.Name = "pbUBallUpgrade"
        Me.pbUBallUpgrade.Size = New System.Drawing.Size(151, 113)
        Me.pbUBallUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUBallUpgrade.TabIndex = 16
        Me.pbUBallUpgrade.TabStop = False
        '
        'pbMBallUpgrade
        '
        Me.pbMBallUpgrade.Image = Global.cookie.My.Resources.Resources._120px_Beast_Ball_Glamour
        Me.pbMBallUpgrade.Location = New System.Drawing.Point(367, 240)
        Me.pbMBallUpgrade.Name = "pbMBallUpgrade"
        Me.pbMBallUpgrade.Size = New System.Drawing.Size(159, 140)
        Me.pbMBallUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMBallUpgrade.TabIndex = 15
        Me.pbMBallUpgrade.TabStop = False
        '
        'pbAFarmUpgrade
        '
        Me.pbAFarmUpgrade.Image = Global.cookie.My.Resources.Resources._2013_10_18_171438_6561496_2841195642
        Me.pbAFarmUpgrade.Location = New System.Drawing.Point(367, 120)
        Me.pbAFarmUpgrade.Name = "pbAFarmUpgrade"
        Me.pbAFarmUpgrade.Size = New System.Drawing.Size(159, 113)
        Me.pbAFarmUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAFarmUpgrade.TabIndex = 14
        Me.pbAFarmUpgrade.TabStop = False
        '
        'pbUBall
        '
        Me.pbUBall.Image = Global.cookie.My.Resources.Resources.il_1588xN_2703917927_5dpc_295111173
        Me.pbUBall.Location = New System.Drawing.Point(578, 239)
        Me.pbUBall.Name = "pbUBall"
        Me.pbUBall.Size = New System.Drawing.Size(63, 57)
        Me.pbUBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUBall.TabIndex = 11
        Me.pbUBall.TabStop = False
        '
        'pbGBall
        '
        Me.pbGBall.Image = Global.cookie.My.Resources.Resources.Great_Ball_Artwork_3019201630
        Me.pbGBall.Location = New System.Drawing.Point(577, 174)
        Me.pbGBall.Name = "pbGBall"
        Me.pbGBall.Size = New System.Drawing.Size(63, 59)
        Me.pbGBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGBall.TabIndex = 10
        Me.pbGBall.TabStop = False
        '
        'pbMBall
        '
        Me.pbMBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbMBall.Image = Global.cookie.My.Resources.Resources.master_ball_by_falco4077_d75ae5m_3429987528
        Me.pbMBall.Location = New System.Drawing.Point(576, 367)
        Me.pbMBall.Name = "pbMBall"
        Me.pbMBall.Size = New System.Drawing.Size(64, 63)
        Me.pbMBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMBall.TabIndex = 9
        Me.pbMBall.TabStop = False
        '
        'Pokeball
        '
        Me.Pokeball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Pokeball.Image = Global.cookie.My.Resources.Resources.purepng1
        Me.Pokeball.Location = New System.Drawing.Point(65, 157)
        Me.Pokeball.Name = "Pokeball"
        Me.Pokeball.Size = New System.Drawing.Size(215, 204)
        Me.Pokeball.TabIndex = 8
        Me.Pokeball.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Cost: 100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(677, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Ancient Poke Ball"
        '
        'CookieClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbPokeballUpgrade)
        Me.Controls.Add(Me.lblPPS)
        Me.Controls.Add(Me.lblUBallUpgradePrice)
        Me.Controls.Add(Me.lblMBallUpgradePrice)
        Me.Controls.Add(Me.lblAFarmUpgradePrice)
        Me.Controls.Add(Me.lblGBallUpgradePrice)
        Me.Controls.Add(Me.lblUBallUpgradeName)
        Me.Controls.Add(Me.lblMBallUpgradeName)
        Me.Controls.Add(Me.lblAFarmUpgradeName)
        Me.Controls.Add(Me.lblGBallUpgradeName)
        Me.Controls.Add(Me.lblGBallPrice)
        Me.Controls.Add(Me.lblUBallName)
        Me.Controls.Add(Me.lblMBallName)
        Me.Controls.Add(Me.lblAFarmName)
        Me.Controls.Add(Me.lblMBallPrice)
        Me.Controls.Add(Me.lblMBallQuantity)
        Me.Controls.Add(Me.lblAFarmPrice)
        Me.Controls.Add(Me.lblAFarmQuantity)
        Me.Controls.Add(Me.lblUBallPrice)
        Me.Controls.Add(Me.lblUBallQuantity)
        Me.Controls.Add(Me.lblGBallQuantity)
        Me.Controls.Add(Me.lblGBallName)
        Me.Controls.Add(Me.pbAFarm)
        Me.Controls.Add(Me.pbGBallUpgrade)
        Me.Controls.Add(Me.pbUBallUpgrade)
        Me.Controls.Add(Me.pbMBallUpgrade)
        Me.Controls.Add(Me.pbAFarmUpgrade)
        Me.Controls.Add(Me.pbUBall)
        Me.Controls.Add(Me.pbGBall)
        Me.Controls.Add(Me.pbMBall)
        Me.Controls.Add(Me.Pokeball)
        Me.Controls.Add(Me.lblPokeBalls)
        Me.Name = "CookieClicker"
        Me.Text = "label2"
        CType(Me.pbPokeballUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAFarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGBallUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUBallUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMBallUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAFarmUpgrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pokeball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPokeBalls As Label
    Friend WithEvents Pokeball As PictureBox
    Friend WithEvents pbMBall As PictureBox
    Friend WithEvents pbGBall As PictureBox
    Friend WithEvents pbUBall As PictureBox
    Friend WithEvents pbAFarmUpgrade As PictureBox
    Friend WithEvents pbMBallUpgrade As PictureBox
    Friend WithEvents pbUBallUpgrade As PictureBox
    Friend WithEvents pbGBallUpgrade As PictureBox
    Friend WithEvents pbAFarm As PictureBox
    Friend WithEvents lblGBallName As Label
    Friend WithEvents lblGBallQuantity As Label
    Friend WithEvents lblUBallPrice As Label
    Friend WithEvents lblUBallQuantity As Label
    Friend WithEvents lblAFarmPrice As Label
    Friend WithEvents lblAFarmQuantity As Label
    Friend WithEvents lblMBallPrice As Label
    Friend WithEvents lblMBallQuantity As Label
    Friend WithEvents lblAFarmName As Label
    Friend WithEvents lblMBallName As Label
    Friend WithEvents lblUBallName As Label
    Friend WithEvents lblGBallPrice As Label
    Friend WithEvents lblGBallUpgradeName As Label
    Friend WithEvents lblAFarmUpgradeName As Label
    Friend WithEvents lblMBallUpgradeName As Label
    Friend WithEvents lblUBallUpgradeName As Label
    Friend WithEvents lblGBallUpgradePrice As Label
    Friend WithEvents lblAFarmUpgradePrice As Label
    Friend WithEvents lblMBallUpgradePrice As Label
    Friend WithEvents lblUBallUpgradePrice As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPPS As Label
    Friend WithEvents pbPokeballUpgrade As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
