﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SWF3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SWF3))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.PIC_keypad = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_keypad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("LCARS", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(553, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "QUIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(679, 545)
        Me.AxShockwaveFlash1.TabIndex = 11
        '
        'PIC_keypad
        '
        Me.PIC_keypad.Image = Global.LCARS_KEYPAD_VB.My.Resources.Resources.blue_terminal_end_lft
        Me.PIC_keypad.Location = New System.Drawing.Point(493, 459)
        Me.PIC_keypad.Name = "PIC_keypad"
        Me.PIC_keypad.Size = New System.Drawing.Size(23, 37)
        Me.PIC_keypad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_keypad.TabIndex = 27
        Me.PIC_keypad.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("LCARS", 26.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label6.Location = New System.Drawing.Point(512, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 39)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "85"
        '
        'SWF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(679, 545)
        Me.Controls.Add(Me.PIC_keypad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SWF3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        Me.TopMost = True
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_keypad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents PIC_keypad As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
