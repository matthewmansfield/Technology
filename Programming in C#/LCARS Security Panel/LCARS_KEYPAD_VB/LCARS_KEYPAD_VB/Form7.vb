Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lock_door()
    End Sub

    Sub unlock_door()
        Dim ProcID As Integer

        'System.Diagnostics.Process.Start("C:\VR_MAIN\door\door.lnk") ' this was when I used a batch file

        'trying something new
        'authorization_ack
        'My.Computer.Audio.Play(My.Resources.Input_Successful_1, AudioPlayMode.Background)
        'My.Computer.Audio.Play(My.Resources.authorization_ack, AudioPlayMode.Background)
        'System.Threading.Thread.Sleep(800)

        System.Diagnostics.Process.Start("C:\VR_MAIN\door\SLIDER_UNLOCK.bs2")
        Threading.Thread.Sleep(1500) 'wait for it to load
        'C:\Program Files (x86)\Parallax Inc\Stamp Editor v2.4
        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.NormalFocus)
        'ProcID = Shell("C:\Program Files (x86)\Parallax Inc\Stamp Editor v2.4\Stampw.exe", AppWinStyle.NormalFocus)
        My.Computer.Keyboard.SendKeys("^r", True) 'run the program

        'Threading.Thread.Sleep(2000) 'wait for the door to open
        Dim frm2 As New Form6()
        frm2.ShowDialog()

        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.NormalFocus)
        My.Computer.Keyboard.SendKeys("%f", True)
        My.Computer.Keyboard.SendKeys("c", True)
        System.Threading.Thread.Sleep(200)
        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.MinimizedFocus)

        'Me.WindowState = FormWindowState.Normal
        'BringWindowToTop(Me.Handle)
        'Threading.Thread.Sleep(100)
        'My.Computer.Keyboard.SendKeys("^r", True)
    End Sub

    Sub lock_door()
        Dim ProcID As Integer

        'System.Diagnostics.Process.Start("C:\VR_MAIN\door\door.lnk") ' this was when I used a batch file

        'trying something new
        'authorization_ack
        'My.Computer.Audio.Play(My.Resources.Input_Successful_1, AudioPlayMode.Background)
        'My.Computer.Audio.Play(My.Resources.authorization_ack, AudioPlayMode.Background)
        'System.Threading.Thread.Sleep(800)

        System.Diagnostics.Process.Start("C:\VR_MAIN\door\SLIDE_LOCK.bs2")
        Threading.Thread.Sleep(1500) 'wait for it to load
        'C:\Program Files (x86)\Parallax Inc\Stamp Editor v2.4
        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.NormalFocus)
        'ProcID = Shell("C:\Program Files (x86)\Parallax Inc\Stamp Editor v2.4\Stampw.exe", AppWinStyle.NormalFocus)
        My.Computer.Keyboard.SendKeys("^r", True) 'run the program

        'Threading.Thread.Sleep(2000) 'wait for the door to open
        Dim frm2 As New Form6()
        frm2.ShowDialog()

        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.NormalFocus)
        My.Computer.Keyboard.SendKeys("%f", True)
        My.Computer.Keyboard.SendKeys("c", True)
        System.Threading.Thread.Sleep(200)
        ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.MinimizedFocus)

        'Me.WindowState = FormWindowState.Normal
        'BringWindowToTop(Me.Handle)
        'Threading.Thread.Sleep(100)
        'My.Computer.Keyboard.SendKeys("^r", True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        unlock_door()
    End Sub

End Class