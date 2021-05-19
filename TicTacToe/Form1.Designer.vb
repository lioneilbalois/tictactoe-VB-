<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrancePop
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
        Me.roundLb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.skipBt = New System.Windows.Forms.Button()
        Me.playBt = New System.Windows.Forms.Button()
        Me.p1Tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.p2Tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.modeLb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'roundLb
        '
        Me.roundLb.AutoSize = True
        Me.roundLb.BackColor = System.Drawing.Color.Transparent
        Me.roundLb.Font = New System.Drawing.Font("Balsamiq Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundLb.ForeColor = System.Drawing.Color.Black
        Me.roundLb.Location = New System.Drawing.Point(19, 25)
        Me.roundLb.Name = "roundLb"
        Me.roundLb.Size = New System.Drawing.Size(181, 44)
        Me.roundLb.TabIndex = 1
        Me.roundLb.Text = "Game Mode: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Player 1 Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Balsamiq Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Player 2 Name:"
        '
        'skipBt
        '
        Me.skipBt.Font = New System.Drawing.Font("Balsamiq Sans", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skipBt.Location = New System.Drawing.Point(197, 184)
        Me.skipBt.Name = "skipBt"
        Me.skipBt.Size = New System.Drawing.Size(75, 26)
        Me.skipBt.TabIndex = 4
        Me.skipBt.Text = "Skip"
        Me.skipBt.UseVisualStyleBackColor = True
        '
        'playBt
        '
        Me.playBt.Font = New System.Drawing.Font("Balsamiq Sans", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playBt.Location = New System.Drawing.Point(278, 184)
        Me.playBt.Name = "playBt"
        Me.playBt.Size = New System.Drawing.Size(75, 26)
        Me.playBt.TabIndex = 5
        Me.playBt.Text = "Play"
        Me.playBt.UseVisualStyleBackColor = True
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
        Me.p1Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1Tb.HoverState.Parent = Me.p1Tb
        Me.p1Tb.Location = New System.Drawing.Point(166, 101)
        Me.p1Tb.Name = "p1Tb"
        Me.p1Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.p1Tb.PlaceholderText = ""
        Me.p1Tb.SelectedText = ""
        Me.p1Tb.ShadowDecoration.Parent = Me.p1Tb
        Me.p1Tb.Size = New System.Drawing.Size(187, 20)
        Me.p1Tb.TabIndex = 6
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
        Me.p2Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p2Tb.HoverState.Parent = Me.p2Tb
        Me.p2Tb.Location = New System.Drawing.Point(166, 137)
        Me.p2Tb.Name = "p2Tb"
        Me.p2Tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.p2Tb.PlaceholderText = ""
        Me.p2Tb.SelectedText = ""
        Me.p2Tb.ShadowDecoration.Parent = Me.p2Tb
        Me.p2Tb.Size = New System.Drawing.Size(187, 20)
        Me.p2Tb.TabIndex = 7
        '
        'modeLb
        '
        Me.modeLb.AutoSize = True
        Me.modeLb.BackColor = System.Drawing.Color.Transparent
        Me.modeLb.Font = New System.Drawing.Font("Balsamiq Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeLb.ForeColor = System.Drawing.Color.Black
        Me.modeLb.Location = New System.Drawing.Point(185, 25)
        Me.modeLb.Name = "modeLb"
        Me.modeLb.Size = New System.Drawing.Size(190, 44)
        Me.modeLb.TabIndex = 8
        Me.modeLb.Text = "__________"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Balsamiq Sans", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Return to Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'entrancePop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modeLb)
        Me.Controls.Add(Me.p2Tb)
        Me.Controls.Add(Me.p1Tb)
        Me.Controls.Add(Me.playBt)
        Me.Controls.Add(Me.skipBt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.roundLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "entrancePop"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roundLb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents skipBt As Button
    Friend WithEvents playBt As Button
    Friend WithEvents p1Tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents p2Tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents modeLb As Label
    Friend WithEvents Button1 As Button
End Class
