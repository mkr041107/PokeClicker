<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Cookie = New System.Windows.Forms.Label()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Cookie
        '
        Me.Cookie.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cookie.Image = Global.cookie.My.Resources.Resources.cookie
        Me.Cookie.Location = New System.Drawing.Point(201, 68)
        Me.Cookie.Name = "Cookie"
        Me.Cookie.Size = New System.Drawing.Size(72, 72)
        Me.Cookie.TabIndex = 0
        '
        'lblClicks
        '
        Me.lblClicks.AutoSize = True
        Me.lblClicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicks.Location = New System.Drawing.Point(207, 140)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(98, 108)
        Me.lblClicks.TabIndex = 1
        Me.lblClicks.Text = "0"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(679, -3)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(119, 31)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time: 10"
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 1000
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.Cookie)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cookie As Label
    Friend WithEvents lblClicks As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrMain As Timer
End Class
