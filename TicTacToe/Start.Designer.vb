<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basicBt = New System.Windows.Forms.Button()
        Me.ultiBt = New System.Windows.Forms.Button()
        Me.mechBt = New System.Windows.Forms.Button()
        Me.aboutBt = New System.Windows.Forms.Button()
        Me.settingsBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tic Tac Toe (Local Multiplayer)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Play"
        '
        'basicBt
        '
        Me.basicBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicBt.Location = New System.Drawing.Point(102, 133)
        Me.basicBt.Name = "basicBt"
        Me.basicBt.Size = New System.Drawing.Size(121, 28)
        Me.basicBt.TabIndex = 2
        Me.basicBt.Text = "Basic"
        Me.basicBt.UseVisualStyleBackColor = True
        '
        'ultiBt
        '
        Me.ultiBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ultiBt.Location = New System.Drawing.Point(102, 162)
        Me.ultiBt.Name = "ultiBt"
        Me.ultiBt.Size = New System.Drawing.Size(121, 28)
        Me.ultiBt.TabIndex = 3
        Me.ultiBt.Text = "Ultimate"
        Me.ultiBt.UseVisualStyleBackColor = True
        '
        'mechBt
        '
        Me.mechBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mechBt.Location = New System.Drawing.Point(87, 210)
        Me.mechBt.Name = "mechBt"
        Me.mechBt.Size = New System.Drawing.Size(121, 28)
        Me.mechBt.TabIndex = 4
        Me.mechBt.Text = "Mechanics"
        Me.mechBt.UseVisualStyleBackColor = True
        '
        'aboutBt
        '
        Me.aboutBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutBt.Location = New System.Drawing.Point(87, 277)
        Me.aboutBt.Name = "aboutBt"
        Me.aboutBt.Size = New System.Drawing.Size(121, 28)
        Me.aboutBt.TabIndex = 5
        Me.aboutBt.Text = "About"
        Me.aboutBt.UseVisualStyleBackColor = True
        '
        'settingsBt
        '
        Me.settingsBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBt.Location = New System.Drawing.Point(87, 243)
        Me.settingsBt.Name = "settingsBt"
        Me.settingsBt.Size = New System.Drawing.Size(121, 28)
        Me.settingsBt.TabIndex = 6
        Me.settingsBt.Text = "Settings"
        Me.settingsBt.UseVisualStyleBackColor = True
        '
        'startForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 358)
        Me.Controls.Add(Me.settingsBt)
        Me.Controls.Add(Me.aboutBt)
        Me.Controls.Add(Me.mechBt)
        Me.Controls.Add(Me.ultiBt)
        Me.Controls.Add(Me.basicBt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "startForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents basicBt As Button
    Friend WithEvents ultiBt As Button
    Friend WithEvents mechBt As Button
    Friend WithEvents aboutBt As Button
    Friend WithEvents settingsBt As Button
End Class
