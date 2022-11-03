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
        Me.btnCookieClickerTimed = New System.Windows.Forms.Button()
        Me.btnCookieClicker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCookieClickerTimed
        '
        Me.btnCookieClickerTimed.Location = New System.Drawing.Point(83, 118)
        Me.btnCookieClickerTimed.Name = "btnCookieClickerTimed"
        Me.btnCookieClickerTimed.Size = New System.Drawing.Size(324, 311)
        Me.btnCookieClickerTimed.TabIndex = 0
        Me.btnCookieClickerTimed.Text = "Cookie Clicker (Timed)"
        Me.btnCookieClickerTimed.UseVisualStyleBackColor = True
        '
        'btnCookieClicker
        '
        Me.btnCookieClicker.Location = New System.Drawing.Point(462, 118)
        Me.btnCookieClicker.Name = "btnCookieClicker"
        Me.btnCookieClicker.Size = New System.Drawing.Size(312, 320)
        Me.btnCookieClicker.TabIndex = 1
        Me.btnCookieClicker.Text = "Cookie Clicker"
        Me.btnCookieClicker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome To Cookie Clicker, Please Pick One"
        '
        'Choose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCookieClicker)
        Me.Controls.Add(Me.btnCookieClickerTimed)
        Me.Name = "Choose"
        Me.Text = "Choose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCookieClickerTimed As Button
    Friend WithEvents btnCookieClicker As Button
    Friend WithEvents Label1 As Label
End Class
