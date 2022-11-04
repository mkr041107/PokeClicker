<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbCursor1 = New System.Windows.Forms.PictureBox()
        Me.pbPokeClicker = New System.Windows.Forms.PictureBox()
        Me.pbCookieClickerTimed = New System.Windows.Forms.PictureBox()
        Me.pbCursor2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pbCursor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPokeClicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCookieClickerTimed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCursor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(734, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome To PokèClicker, Please Pick One"
        '
        'pbCursor1
        '
        Me.pbCursor1.BackColor = System.Drawing.Color.Transparent
        Me.pbCursor1.Image = Global.cookie.My.Resources.Resources.th_2510880536
        Me.pbCursor1.Location = New System.Drawing.Point(598, 295)
        Me.pbCursor1.Name = "pbCursor1"
        Me.pbCursor1.Size = New System.Drawing.Size(48, 60)
        Me.pbCursor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCursor1.TabIndex = 5
        Me.pbCursor1.TabStop = False
        '
        'pbPokeClicker
        '
        Me.pbPokeClicker.Image = Global.cookie.My.Resources.Resources.pokemon_pokeball_toy_7cm_3996445687
        Me.pbPokeClicker.Location = New System.Drawing.Point(444, 149)
        Me.pbPokeClicker.Name = "pbPokeClicker"
        Me.pbPokeClicker.Size = New System.Drawing.Size(232, 221)
        Me.pbPokeClicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPokeClicker.TabIndex = 4
        Me.pbPokeClicker.TabStop = False
        '
        'pbCookieClickerTimed
        '
        Me.pbCookieClickerTimed.Image = Global.cookie.My.Resources.Resources.cookie
        Me.pbCookieClickerTimed.Location = New System.Drawing.Point(84, 148)
        Me.pbCookieClickerTimed.Name = "pbCookieClickerTimed"
        Me.pbCookieClickerTimed.Size = New System.Drawing.Size(229, 222)
        Me.pbCookieClickerTimed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCookieClickerTimed.TabIndex = 3
        Me.pbCookieClickerTimed.TabStop = False
        '
        'pbCursor2
        '
        Me.pbCursor2.BackColor = System.Drawing.Color.Transparent
        Me.pbCursor2.Image = Global.cookie.My.Resources.Resources.th_2510880536
        Me.pbCursor2.Location = New System.Drawing.Point(249, 310)
        Me.pbCursor2.Name = "pbCursor2"
        Me.pbCursor2.Size = New System.Drawing.Size(48, 60)
        Me.pbCursor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCursor2.TabIndex = 6
        Me.pbCursor2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cookie Clicker (Timed)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PokèClicker"
        '
        'Choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbCursor2)
        Me.Controls.Add(Me.pbCursor1)
        Me.Controls.Add(Me.pbPokeClicker)
        Me.Controls.Add(Me.pbCookieClickerTimed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Choose"
        Me.Text = "Choose"
        CType(Me.pbCursor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPokeClicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCookieClickerTimed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCursor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pbCookieClickerTimed As PictureBox
    Friend WithEvents pbPokeClicker As PictureBox
    Friend WithEvents pbCursor1 As PictureBox
    Friend WithEvents pbCursor2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
