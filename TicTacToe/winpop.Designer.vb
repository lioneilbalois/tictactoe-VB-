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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.SuspendLayout()
        '
        'roundLb
        '
        Me.roundLb.AutoSize = True
        Me.roundLb.BackColor = System.Drawing.Color.Transparent
        Me.roundLb.Font = New System.Drawing.Font("Balsamiq Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundLb.ForeColor = System.Drawing.Color.White
        Me.roundLb.Location = New System.Drawing.Point(23, 27)
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
        Me.winrLb.Location = New System.Drawing.Point(89, 78)
        Me.winrLb.Name = "winrLb"
        Me.winrLb.Size = New System.Drawing.Size(172, 58)
        Me.winrLb.TabIndex = 1
        Me.winrLb.Text = "--Name--"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Balsamiq Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(269, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Next Round"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Balsamiq Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(269, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Another round automatically starting...."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(28, 205)
        Me.ProgressBar1.Minimum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(215, 10)
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
        Me.Guna2AnimateWindow1.Interval = 400
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'winpop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(380, 237)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
