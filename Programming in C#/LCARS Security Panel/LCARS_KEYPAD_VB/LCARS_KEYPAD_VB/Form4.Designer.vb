<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lbl100percent = New System.Windows.Forms.Label()
        Me.lbltransparent = New System.Windows.Forms.Label()
        Me.lblzeropercent = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOpenDown = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(81, 168)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(208, 45)
        Me.TrackBar1.TabIndex = 13
        Me.TrackBar1.Visible = False
        '
        'lbl100percent
        '
        Me.lbl100percent.AutoSize = True
        Me.lbl100percent.Location = New System.Drawing.Point(284, 168)
        Me.lbl100percent.Name = "lbl100percent"
        Me.lbl100percent.Size = New System.Drawing.Size(33, 13)
        Me.lbl100percent.TabIndex = 16
        Me.lbl100percent.Text = "100%"
        Me.lbl100percent.Visible = False
        '
        'lbltransparent
        '
        Me.lbltransparent.AutoSize = True
        Me.lbltransparent.Location = New System.Drawing.Point(144, 152)
        Me.lbltransparent.Name = "lbltransparent"
        Me.lbltransparent.Size = New System.Drawing.Size(95, 13)
        Me.lbltransparent.TabIndex = 14
        Me.lbltransparent.Text = "TRANSPARENCY"
        Me.lbltransparent.Visible = False
        '
        'lblzeropercent
        '
        Me.lblzeropercent.AutoSize = True
        Me.lblzeropercent.Location = New System.Drawing.Point(63, 168)
        Me.lblzeropercent.Name = "lblzeropercent"
        Me.lblzeropercent.Size = New System.Drawing.Size(21, 13)
        Me.lblzeropercent.TabIndex = 15
        Me.lblzeropercent.Text = "0%"
        Me.lblzeropercent.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.LCARS_KEYPAD_VB.My.Resources.Resources.XP_Minimize
        Me.Button4.Location = New System.Drawing.Point(337, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 20)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.LCARS_KEYPAD_VB.My.Resources.Resources.XP_Maximize
        Me.Button3.Location = New System.Drawing.Point(357, -2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 20)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.LCARS_KEYPAD_VB.My.Resources.Resources.close_btn
        Me.Button2.Location = New System.Drawing.Point(377, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.LCARS_KEYPAD_VB.My.Resources.Resources.alpha_People_hl_next
        Me.Button1.Location = New System.Drawing.Point(364, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 39)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOpenDown
        '
        Me.btnOpenDown.Image = Global.LCARS_KEYPAD_VB.My.Resources.Resources.NoThumbDefault_submenu
        Me.btnOpenDown.Location = New System.Drawing.Point(47, 35)
        Me.btnOpenDown.Name = "btnOpenDown"
        Me.btnOpenDown.Size = New System.Drawing.Size(79, 73)
        Me.btnOpenDown.TabIndex = 10
        Me.btnOpenDown.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LCARS_KEYPAD_VB.My.Resources.Resources.NoThumbDefault_submenu
        Me.PictureBox1.Location = New System.Drawing.Point(337, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(401, 254)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lbl100percent)
        Me.Controls.Add(Me.lbltransparent)
        Me.Controls.Add(Me.lblzeropercent)
        Me.Controls.Add(Me.btnOpenDown)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.LightGray
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenDown As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lbl100percent As System.Windows.Forms.Label
    Friend WithEvents lbltransparent As System.Windows.Forms.Label
    Friend WithEvents lblzeropercent As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
