<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nameAsk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nameAsk))
        Me.roundLb = New System.Windows.Forms.Label()
        Me.modeLb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.p1Tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.p2Tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.skipBt = New Guna.UI2.WinForms.Guna2Button()
        Me.playBt = New Guna.UI2.WinForms.Guna2Button()
        Me.backBt = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'roundLb
        '
        Me.roundLb.AutoSize = True
        Me.roundLb.BackColor = System.Drawing.Color.Transparent
        Me.roundLb.Font = New System.Drawing.Font("Balsamiq Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundLb.ForeColor = System.Drawing.Color.Black
        Me.roundLb.Location = New System.Drawing.Point(22, 35)
        Me.roundLb.Name = "roundLb"
        Me.roundLb.Size = New System.Drawing.Size(136, 35)
        Me.roundLb.TabIndex = 1
        Me.roundLb.Text = "Game Mode:"
        '
        'modeLb
        '
        Me.modeLb.AutoSize = True
        Me.modeLb.BackColor = System.Drawing.Color.Transparent
        Me.modeLb.Font = New System.Drawing.Font("Balsamiq Sans", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeLb.ForeColor = System.Drawing.Color.Black
        Me.modeLb.Location = New System.Drawing.Point(154, 30)
        Me.modeLb.Name = "modeLb"
        Me.modeLb.Size = New System.Drawing.Size(152, 47)
        Me.modeLb.TabIndex = 2
        Me.modeLb.Text = "------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Player 1 Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Player 2 Name:"
        '
        'p1Tb
        '
        Me.p1Tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.p1Tb.DefaultText = ""
        Me.p1Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.p1Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.p1Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.p1Tb.DisabledState.Parent = Me.p1Tb
        Me.p1Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.p1Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1Tb.FocusedState.Parent = Me.p1Tb
        Me.p1Tb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.p1Tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.p1Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1Tb.HoverState.Parent = Me.p1Tb
        Me.p1Tb.Location = New System.Drawing.Point(163, 96)
        Me.p1Tb.Name = "p1Tb"
        Me.p1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.p1Tb.PlaceholderText = ""
        Me.p1Tb.SelectedText = ""
        Me.p1Tb.ShadowDecoration.Parent = Me.p1Tb
        Me.p1Tb.Size = New System.Drawing.Size(174, 20)
        Me.p1Tb.TabIndex = 5
        '
        'p2Tb
        '
        Me.p2Tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.p2Tb.DefaultText = ""
        Me.p2Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.p2Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.p2Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.p2Tb.DisabledState.Parent = Me.p2Tb
        Me.p2Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.p2Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p2Tb.FocusedState.Parent = Me.p2Tb
        Me.p2Tb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.p2Tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.p2Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p2Tb.HoverState.Parent = Me.p2Tb
        Me.p2Tb.Location = New System.Drawing.Point(163, 131)
        Me.p2Tb.Name = "p2Tb"
        Me.p2Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.p2Tb.PlaceholderText = ""
        Me.p2Tb.SelectedText = ""
        Me.p2Tb.ShadowDecoration.Parent = Me.p2Tb
        Me.p2Tb.Size = New System.Drawing.Size(174, 20)
        Me.p2Tb.TabIndex = 6
        '
        'skipBt
        '
        Me.skipBt.BackColor = System.Drawing.Color.White
        Me.skipBt.BorderThickness = 2
        Me.skipBt.CheckedState.Parent = Me.skipBt
        Me.skipBt.CustomImages.Parent = Me.skipBt
        Me.skipBt.FillColor = System.Drawing.Color.White
        Me.skipBt.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skipBt.ForeColor = System.Drawing.Color.Black
        Me.skipBt.HoverState.Parent = Me.skipBt
        Me.skipBt.Location = New System.Drawing.Point(225, 186)
        Me.skipBt.Name = "skipBt"
        Me.skipBt.ShadowDecoration.Parent = Me.skipBt
        Me.skipBt.Size = New System.Drawing.Size(63, 24)
        Me.skipBt.TabIndex = 12
        Me.skipBt.Text = "Skip"
        '
        'playBt
        '
        Me.playBt.BackColor = System.Drawing.Color.White
        Me.playBt.BorderThickness = 2
        Me.playBt.CheckedState.Parent = Me.playBt
        Me.playBt.CustomImages.Parent = Me.playBt
        Me.playBt.FillColor = System.Drawing.Color.White
        Me.playBt.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playBt.ForeColor = System.Drawing.Color.Black
        Me.playBt.HoverState.Parent = Me.playBt
        Me.playBt.Location = New System.Drawing.Point(291, 186)
        Me.playBt.Name = "playBt"
        Me.playBt.ShadowDecoration.Parent = Me.playBt
        Me.playBt.Size = New System.Drawing.Size(63, 24)
        Me.playBt.TabIndex = 13
        Me.playBt.Text = "Play"
        '
        'backBt
        '
        Me.backBt.BackColor = System.Drawing.Color.White
        Me.backBt.BorderThickness = 2
        Me.backBt.CheckedState.Parent = Me.backBt
        Me.backBt.CustomImages.Parent = Me.backBt
        Me.backBt.FillColor = System.Drawing.Color.White
        Me.backBt.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBt.ForeColor = System.Drawing.Color.Black
        Me.backBt.HoverState.Parent = Me.backBt
        Me.backBt.Location = New System.Drawing.Point(28, 186)
        Me.backBt.Name = "backBt"
        Me.backBt.ShadowDecoration.Parent = Me.backBt
        Me.backBt.Size = New System.Drawing.Size(63, 24)
        Me.backBt.TabIndex = 14
        Me.backBt.Text = "Back"
        '
        'nameAsk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(380, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.backBt)
        Me.Controls.Add(Me.playBt)
        Me.Controls.Add(Me.skipBt)
        Me.Controls.Add(Me.p2Tb)
        Me.Controls.Add(Me.p1Tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.modeLb)
        Me.Controls.Add(Me.roundLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "nameAsk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roundLb As Label
    Friend WithEvents modeLb As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents p1Tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents p2Tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents skipBt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents playBt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents backBt As Guna.UI2.WinForms.Guna2Button
End Class
