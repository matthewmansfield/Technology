Public Class Form4

    Private Property sliceCount As Integer

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        BackColor = Color.Red

        TransparencyKey = BackColor


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Panel4.BackColor = Color.DimGray
        TrackBar1.Visible = True
        lbl100percent.Visible = True
        lbltransparent.Visible = True
        lblzeropercent.Visible = True

    End Sub

    Private Sub btnOpenDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Panel4.Visible = True
        ' Panel4.BackColor = Color.DimGray
        TrackBar1.Visible = True
        lbl100percent.Visible = True
        lbltransparent.Visible = True
        lblzeropercent.Visible = True
        ' Panel3.Drawing.Size.Height(453)
        'Panel3.Size.Width(422)
        ' Drawing.Size.Equals(422, 453)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form As New Toast()
        form.Show()


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Drawing.Size.Equals(0, 0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '' Me.DefaultMinimumSize()
    End Sub
End Class