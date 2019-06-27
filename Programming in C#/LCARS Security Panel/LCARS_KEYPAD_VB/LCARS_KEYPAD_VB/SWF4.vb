Public Class SWF4


    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.Close()
    End Sub

    Sub PlayLoopingBackgroundSoundFile()

        ' My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        'My.Computer.Audio.Play("C:\Waterfall.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Display_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class