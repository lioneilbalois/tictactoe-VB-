<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winpop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(winpop))
        Me.roundLb = New System.Windows.Forms.Label()
        Me.winrLb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.nextBt = New Guna.UI2.WinForms.Guna2Button()
        Me.mainBt = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'roundLb
        '
        Me.roundLb.AutoSize = True
        Me.roundLb.BackColor = System.Drawing.Color.Transparent
        Me.roundLb.Font = New System.Drawing.Font("Balsamiq Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundLb.ForeColor = System.Drawing.Color.White
        Me.roundLb.Location = New System.Drawing.Point(20, 27)
        Me.roundLb.Name = "roundLb"
        Me.roundLb.Size = New System.Drawing.Size(166, 52)
        Me.roundLb.TabIndex = 0
        Me.roundLb.Text = "--Round--"
        '
        'winrLb
        '
        Me.winrLb.AutoSize = True
        Me.winrLb.BackColor = System.Drawing.Color.Transparent
        Me.winrLb.Font = New System.Drawing.Font("Balsamiq Sans", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winrLb.ForeColor = System.Drawing.Color.White
        Me.winrLb.Location = New System.Drawing.Point(99, 91)
        Me.winrLb.Name = "winrLb"
        Me.winrLb.Size = New System.Drawing.Size(172, 58)
        Me.winrLb.TabIndex = 1
        Me.winrLb.Text = "--Name--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Another round automatically starting...."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(28, 195)
        Me.ProgressBar1.Minimum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(187, 10)
        Me.ProgressBar1.Step = 25
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.Value = 50
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'nextBt
        '
        Me.nextBt.BackColor = System.Drawing.Color.White
        Me.nextBt.BorderThickness = 2
        Me.nextBt.CheckedState.Parent = Me.nextBt
        Me.nextBt.CustomImages.Parent = Me.nextBt
        Me.nextBt.FillColor = System.Drawing.Color.White
        Me.nextBt.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextBt.ForeColor = System.Drawing.Color.Black
        Me.nextBt.HoverState.Parent = Me.nextBt
        Me.nextBt.Location = New System.Drawing.Point(256, 165)
        Me.nextBt.Name = "nextBt"
        Me.nextBt.ShadowDecoration.Parent = Me.nextBt
        Me.nextBt.Size = New System.Drawing.Size(99, 24)
        Me.nextBt.TabIndex = 13
        Me.nextBt.Text = "Next Round"
        '
        'mainBt
        '
        Me.mainBt.BackColor = System.Drawing.Color.White
        Me.mainBt.BorderThickness = 2
        Me.mainBt.CheckedState.Parent = Me.mainBt
        Me.mainBt.CustomImages.Parent = Me.mainBt
        Me.mainBt.FillColor = System.Drawing.Color.White
        Me.mainBt.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainBt.ForeColor = System.Drawing.Color.Black
        Me.mainBt.HoverState.Parent = Me.mainBt
        Me.mainBt.Location = New System.Drawing.Point(256, 191)
        Me.mainBt.Name = "mainBt"
        Me.mainBt.ShadowDecoration.Parent = Me.mainBt
        Me.mainBt.Size = New System.Drawing.Size(99, 24)
        Me.mainBt.TabIndex = 14
        Me.mainBt.Text = "Main Menu"
        '
        'winpop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(380, 237)
        Me.Controls.Add(Me.mainBt)
        Me.Controls.Add(Me.nextBt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.winrLb)
        Me.Controls.Add(Me.roundLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "winpop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roundLb As Label
    Friend WithEvents winrLb As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents nextBt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mainBt As Guna.UI2.WinForms.Guna2Button
End Class
