Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Management
Imports System.Text
Imports System.String


Public Class Form1

    ' Option Explicit
    Dim g As Graphics
    Dim m_sngX As Single = 0
    Dim m_sngY As Single

    Dim m_sngCPUY As Single
    Dim m_sngProcsY As Single
    Dim m_sngMemY As Single

    Dim cntr As Integer = 0
    Dim penCPU As New System.Drawing.Pen(Color.Red, 2.0F)
    Dim penProcs As New System.Drawing.Pen(Color.Lime, 3.0F)
    Dim penMem As New System.Drawing.Pen(Color.Blue, 4.0F)

    Dim Dt As Date = Now
    Dim NewDT As DateTime = Now()
    Dim s1 As String
    Dim hwndSelected As Long
    Dim sClassSelected As String
    Dim sTitleSelected As String

    Private Enum RefreshConstants
        REFRESH_NORMAL = 0
        REFRESH_IFEXPIRED = 1
        REFRESH_CONTINUE = 2
        REFRESH_COMPLETELY = 3
    End Enum
    'attempt to hide app
    'Private Declare Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    'Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
    'Private Const SW_SHOWMINNOACTIVE As Int32 = 7
    'Private Const SW_SHOWNORMAL As Int32 = 1
    'Private Const SW_HIDE As Int32 = 0

    'To use it:
    ' ShowWindow(GetConsoleWindow(), SW_HIDE)



    'Private Declare Function ShowCursor Lib "user32" (ByVal bShow As Long) As Long

    ' Sub routineOne()
    '     ShowCursor(False)
    'End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.Location = New Point(0, 0)
        'Me.TopMost = True
        'Me.Opacity = 0.5

        lights_blinking()
        keepingtime()
        ' Me.lbl_CURRENT_TIME.Text = Date.Now.ToString()
        keepingDATE()


        MyNewSub() 'here is where we make the middle section empty


        ' OPEN_Hide_ALTARIS()

        ' routineOne()

        'ShowCursor(bShow:=False)
        Dim aFileStream As FileStream = Nothing
        Dim encode As New System.Text.ASCIIEncoding

        If Len(Dir("password.txt")) > 0 Then
            'file exists - proceed accordingly
            My.Computer.Audio.Play(My.Resources.Input_successful_2, AudioPlayMode.Background)
        Else
            'file doesn't exist - take appropriate action
            Try
                aFileStream = New FileStream("password.txt", FileMode.OpenOrCreate, FileAccess.Write)

                Dim myBinaryWriter As New BinaryWriter(aFileStream)
                myBinaryWriter.Write(encode.GetBytes("Enter Password"))
                'myBinaryWriter.Write(1) 
            Catch ye As Exception
                Console.WriteLine(ye.StackTrace)
            Finally
                If Not (aFileStream Is Nothing) Then aFileStream.Close()
            End Try
        End If




    End Sub



    Sub MyNewSub()
        BackColor = Color.Red

        TransparencyKey = BackColor

    End Sub



    ' End Sub


    Public Sub InitializeMyForm()

        BackColor = Color.Red

        ' Make the background color of form display transparently.

        TransparencyKey = BackColor

    End Sub 'InitializeMyForm


    Sub keepingtime() Handles Timer1.Tick
        Timer1.Enabled = True
        lbl_CURRENT_TIME.Text = TimeOfDay
    End Sub
    Sub keepingDATE() Handles Timer2.Tick
        Timer2.Enabled = True
        lbl_CURRENT_DATE.Text = Date.Today
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyPad.Click
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)

        'Dim admin As New Form3()
        'Dim keypad As New Form2()
        Form2.Show()
        ' keypad = Nothing
        'admin.Hide()
    End Sub

    Private Sub btnSystemProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.PIC_SystemProcess.Visible = True

        'Me.btn_sysprocess_close.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Display_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub
    ' Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
    '     Me.PictureBox1.Visible = True
    ' End Sub
    'Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
    '    Me.PictureBox1.Visible = False
    'End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        'Dim admin As New Form3()
        'Dim keypad As New Form2()
        'admin.Show()
        Form3.Show()
        'admin = Nothing
        'keypad.Hide()
    End Sub
    ' Private Sub Button3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
    '     Me.PictureBox4.Visible = True

    '    End Sub
    '   Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
    '       Me.PictureBox4.Visible = False

    '    End Sub


    Private Sub lbl_CURRENT_TIME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CURRENT_TIME.Click
        'Me.lbl_CURRENT_TIME.Text = System.DateTime.Now

    End Sub

    'Private Sub btnKeyPad_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyPad.MouseHover
    '    Me.PIC_keypad.Visible = True
    'End Sub

    'Private Sub btnKeyPad_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyPad.MouseLeave
    '    Me.PIC_keypad.Visible = False
    'End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.PIC_SystemProcess.Visible = False

        'Me.btn_sysprocess_close.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        If TrackBar1.Value = 10 Then
            Me.Opacity = 0.1
        End If
        If TrackBar1.Value = 9 Then
            Me.Opacity = 0.2
        End If
        If TrackBar1.Value = 8 Then
            Me.Opacity = 0.3
        End If
        If TrackBar1.Value = 7 Then
            Me.Opacity = 0.4
        End If
        If TrackBar1.Value = 6 Then
            Me.Opacity = 0.5
        End If
        If TrackBar1.Value = 5 Then
            Me.Opacity = 0.6
        End If
        If TrackBar1.Value = 4 Then
            Me.Opacity = 0.7
        End If
        If TrackBar1.Value = 3 Then
            Me.Opacity = 0.8
        End If
        If TrackBar1.Value = 2 Then
            Me.Opacity = 0.9
        End If
        If TrackBar1.Value = 1 Then
            Me.Opacity = 1.0
        End If

    End Sub


    ' Private Sub btnSystemProcess_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemProcess.MouseHover
    '     Me.PictureBox3.Visible = True
    ' End Sub

    'Private Sub btnSystemProcess_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemProcess.MouseLeave
    '    Me.PictureBox3.Visible = False
    'End Sub

    'Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseKeyPad.MouseHover
    '    Me.PictureBox2.Visible = True
    'End Sub
    'Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseKeyPad.MouseLeave
    '    Me.PictureBox2.Visible = False
    'End Sub
    Private Sub BtnCloseKeyPad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseKeyPad.Click
        My.Computer.Audio.Play(My.Resources.doorbell, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        'Form2.Visible = False
        'Dim keypad As New Form2()
        ' form.Close()
        'Form2.Hide()
        ' keypad.Close()
        'Me.Focus()
        'ShowCursor(bShow:=True)
    End Sub

#Region "   Kill altarisv"
    Private Sub KILL_BUTTON()
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("altarisv")

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub
#End Region

#Region "   Open, Hide and Reresh Altaris"
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, _
                   ByVal lpOperation As String, ByVal lpFile As String, _
                   ByVal lpParameters As String, ByVal lpDirectory As String, _
                   ByVal nShowCmd As Long) As Long

    Private Const SW_HIDE = 0

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long

    Private Sub OPEN_Hide_ALTARIS()
        ShellExecute(0, "open", "notepad.exe", "", "", SW_HIDE)
    End Sub

    Private Sub REFRESH_ALTARIS()
        KILL_BUTTON()
        System.Threading.Thread.Sleep(4000)
        OPEN_Hide_ALTARIS()
    End Sub
#End Region

#Region "   Open FileZilla"
    Private Declare Function ShowWindow _
            Lib "user32" _
           (ByVal hwnd As Long, _
            ByVal nCmdShow As Long) As Long

    Private Const SW_SHOWNORMAL = 1
    Private Const SW_SHOWMINIMIZED = 2
    Private Const SW_SHOWMAXIMIZED = 3

    Private Sub OPEN_Hide_FILEZILLA()
        ShellExecute(0, "open", "notepad.exe", "", "", SW_HIDE)
        '  Private Sub Hide_Example()
        ''''''''''ShellExecute(0, "open", "C:\FZ\filezilla.exe", "", "", SW_HIDE)


        '  Dim ProcID As Integer
        '   ProcID = Shell("C:\FZ\filezilla.exe", AppWinStyle.NormalFocus)
        'Me.WindowState = FormWindowState.Normal
        'BringWindowToTop(Me.Handle)

        '  Threading.Thread.Sleep(100)
        '  My.Computer.Keyboard.SendKeys("^r", True)


        'SendKeys.Send("^r")
        ' Start the Calculator application, and store the process id.

        ' Activate the Calculator application.
        'AppActivate(ProcID)
    End Sub






    Private Sub filezilla_Find()

        Dim p As Process = Process.GetProcessesByName("FileZilla")(0)
        If p.MainWindowTitle = "FileZilla" Then
            'Do something
            My.Computer.Keyboard.SendKeys("^r", True)
            'My.Computer.Keyboard.SendKeys("~", True)
        End If

        ' Dim Find As Long
        '    ' Find = FindWindow(vbNullString, "FileZilla")

        '    Find = FindWindow("FileZilla", vbNullString)

        '    If Find <> 0 Then
        'MsgBox("FileZilla is open!", vbInformation, "FileZilla")
        '     ShowWindow(Find, SW_SHOWNORMAL)
        '     My.Computer.Keyboard.SendKeys("+(AC)", True)
        '    My.Computer.Keyboard.SendKeys("~", True)
        '    Else
        '    MsgBox("FileZilla isn't open!", vbInformation, "Window not found.")
        '    End If
    End Sub




    ' Send the keystrokes to the Calculator application.
    ''''     My.Computer.Keyboard.SendKeys("+(AC)", True)
    ''''      My.Computer.Keyboard.SendKeys("~", True)
    'My.Computer.Keyboard.SendKeys("{ENTER}")
    'My.Computer.Keyboard.SendKeys("=", True)
    ' The result is 22 * 44 = 968.



    'NOTES ON HOW TO SEND KEYSTROKES TO ANOTHER PROGRAM: 

    ' Dim ProcID As Integer
    ' ' Start the Calculator application, and store the process id.
    ' ProcID = Shell("CALC.EXE", AppWinStyle.NormalFocus)
    ' ' Activate the Calculator application.
    ' AppActivate(ProcID)
    ' ' Send the keystrokes to the Calculator application.
    ' My.Computer.Keyboard.SendKeys("22", True)
    ' My.Computer.Keyboard.SendKeys("*", True)
    ' My.Computer.Keyboard.SendKeys("44", True)
    ' My.Computer.Keyboard.SendKeys("=", True)
    ' ' The result is 22 * 44 = 968.


    ' Threading.Thread.Sleep(10)
    ' Do
    ''''''''''' DoEvents()
    '  Dim closeprogram = FindWindow(vbNullString, "openCanvas4.5e Plus")
    '   Loop Until ("openCanvas4.5e Plus" <> 0)
    ' MsgBox(CStr(FindWindow(vbNullString, "Untitled - Notepad")))
    '  End Sub

#End Region


    Private Sub btnSystemProcess_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemProcess.Click
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        Form5.Show()


        'WORKS TO OPEN THE ACCEPTED WINDOW:
        'Dim frm2 As New Form6()
        'frm2.ShowDialog()
        'Dim ProcID As Integer

        'System.Diagnostics.Process.Start("C:\VR_MAIN\door\door.lnk") ' this was when I used a batch file

        'trying something new
        'My.Computer.Audio.Play(My.Resources.Input_Successful_1, AudioPlayMode.Background)
        'System.Threading.Thread.Sleep(800)
        'System.Threading.Thread.Sleep(200)
        'ProcID = Shell("C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe", AppWinStyle.MinimizedFocus
        '              )


        'Form5.Show()



        'My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        'Dim additional As New Form5()
        'Dim keypad As New Form2()
        'additional.Show()
        'additional = Nothing

        ' Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
        ' myProcess.StartInfo.FileName = "C:\Program Files\Parallax Inc\Stamp Editor v2.5.2\Stampw.exe"
        ' myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden = 0 'System.Diagnostics.ProcessWindowStyle.Normal
        ' myProcess.Start()

        'Open_Basic_Stamp()
        ' OPEN_Hide_FILEZILLA()
    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        Form7.Show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)

        'Dim admin As New Form3()
        'Dim keypad As New Form2()
        Form8.Show()

    End Sub

    Sub lights_blinking()
        Timer3.Enabled = True
        Timer4.Enabled = False

        Timer5.Enabled = True
        Timer6.Enabled = False

        Timer7.Enabled = True
        Timer8.Enabled = False

        Timer9.Enabled = True
        Timer10.Enabled = False

        Timer11.Enabled = True
        Timer12.Enabled = False

        Timer17.Enabled = True
        Timer13.Enabled = False
        Timer14.Enabled = False
        Timer15.Enabled = False
        Timer16.Enabled = False
        Timer18.Enabled = False

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'the base bar, ICK! 
        'PINK1.Visible = True
        PictureBox25.Visible = True
        PictureBox24.Visible = True


        'LBLUE1.Visible = False
 

        'SLICES:
        LBLUE_SLICE.Visible = True
        YELLOW_SLICE.Visible = False


        PictureBox9.Visible = False
        PictureBox10.Visible = True
        

        PictureBox15.Visible = True
        PictureBox13.Visible = False

        



        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        ' PINK1.Visible = False
        'LBLUE1.Visible = True
        PictureBox25.Visible = False
        PictureBox24.Visible = False

        'SLICES:
        LBLUE_SLICE.Visible = False
        YELLOW_SLICE.Visible = True

        PictureBox13.Visible = True

        PictureBox9.Visible = True
        PictureBox10.Visible = False

        PictureBox15.Visible = False



        Timer3.Enabled = True
        Timer4.Enabled = False
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        ' YELLOW1.Visible = True
        'YELLOW2.Visible = True
        'PURPLE1.Visible = True

        'slices
        LBLUE_SLICE2.Visible = False
        PictureBox11.Visible = True
        PictureBox12.Visible = False



        'flip the timers
        Timer5.Enabled = False
        Timer6.Enabled = True
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick

        ' YELLOW1.Visible = False
        'YELLOW2.Visible = False
        ' PURPLE1.Visible = False

        'slices
        LBLUE_SLICE2.Visible = True

        PictureBox11.Visible = False
        PictureBox12.Visible = True
        

        'flip the timers
        Timer5.Enabled = True
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick

        'LBLUE2.Visible = True
        'PURPLE1.Visible = True
        'PURPLE1.Visible = False
        ' YELLOW2.Visible = True

        'slices
        PINK_SLICE.Visible = True
        PURPLE_SLICE.Visible = False

        'PictureBox14.Visible = False
        PictureBox7.Visible = False

        'flip the timers
        Timer7.Enabled = False
        Timer8.Enabled = True
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick

        'LBLUE2.Visible = False

        'PURPLE1.Visible = False

        'PURPLE1.Visible = True
        ' YELLOW2.Visible = False

        'slices
        PINK_SLICE.Visible = False
        PURPLE_SLICE.Visible = True


        PictureBox7.Visible = True
        ' PictureBox14.Visible = True

        'flip the timers
        Timer7.Enabled = True
        Timer8.Enabled = False
    End Sub


    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        N1.Visible = True
        N2.Visible = True
        N3.Visible = True

        N4.Visible = False
        N5.Visible = True
        N6.Visible = False

        N7.Visible = True
        N8.Visible = False
        N9.Visible = False


        'flip the timers
        Timer9.Enabled = False
        Timer10.Enabled = True
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        N1.Visible = False
        N2.Visible = False
        N3.Visible = False

        N4.Visible = True
        N5.Visible = False
        N6.Visible = True

        N7.Visible = False
        N8.Visible = True
        N9.Visible = True



        'FLIP BACK
        Timer9.Enabled = True
        Timer10.Enabled = False
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick

        PictureBox26.Visible = True
        PictureBox27.Visible = True

        PictureBox23.Visible = True





        Timer11.Enabled = False
        Timer12.Enabled = True
    End Sub



    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        PictureBox23.Visible = False
        PictureBox26.Visible = False
        PictureBox27.Visible = False


        Timer11.Enabled = True
        Timer12.Enabled = False
    End Sub

    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        '      PictureBox21.Visible = True
        '      PURPLE1.Visible = False
        '      YELLOW1.Visible = False
        '      PINK1.Visible = False
        '      YELLOW2.Visible = False
        '      PictureBox16.Visible = False


        '        Timer17.Enabled = False
        '        Timer13.Enabled = True
        '        Timer14.Enabled = False
        '        Timer15.Enabled = False
        '        Timer16.Enabled = False
        '        Timer18.Enabled = False
    End Sub



    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        '     PictureBox21.Visible = False
        '     PURPLE1.Visible = True
        '     YELLOW1.Visible = False
        '     PINK1.Visible = False
        '     YELLOW2.Visible = False
        '     PictureBox16.Visible = False
        ''


        '       Timer17.Enabled = False
        '       Timer13.Enabled = False
        '       Timer14.Enabled = True
        '       Timer15.Enabled = False
        '       Timer16.Enabled = False
        '       Timer18.Enabled = False
    End Sub

    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        '      PictureBox21.Visible = False
        '      PURPLE1.Visible = False
        '      YELLOW1.Visible = True
        '      PINK1.Visible = False
        '      YELLOW2.Visible = False
        '      PictureBox16.Visible = False


        'rotate timers

        '      Timer17.Enabled = False
        '      Timer13.Enabled = False
        '      Timer14.Enabled = False
        '      Timer15.Enabled = True
        '      Timer16.Enabled = False
        '      Timer18.Enabled = False
    End Sub

    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        '   PictureBox21.Visible = False
        '   PURPLE1.Visible = False
        '   YELLOW1.Visible = False
        '   PINK1.Visible = True
        '   YELLOW2.Visible = False
        '   PictureBox16.Visible = False


        'rotate timers

        '        Timer17.Enabled = False
        '        Timer13.Enabled = False
        '        Timer14.Enabled = False
        '        Timer15.Enabled = False
        '        Timer16.Enabled = True
        '        Timer18.Enabled = False
    End Sub

    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        PictureBox21.Visible = False
        'PURPLE1.Visible = False
        'YELLOW1.Visible = False
        'PINK1.Visible = False
        'YELLOW2.Visible = True
        PictureBox16.Visible = False


        'rotate timers

        Timer17.Enabled = False
        Timer13.Enabled = False
        Timer14.Enabled = False
        Timer15.Enabled = False
        Timer16.Enabled = False
        Timer18.Enabled = True
    End Sub


    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        PictureBox21.Visible = False
        'PURPLE1.Visible = False
        'YELLOW1.Visible = False
        'PINK1.Visible = False
        'YELLOW2.Visible = False
        PictureBox16.Visible = True



        Timer17.Enabled = True
        Timer13.Enabled = False
        Timer14.Enabled = False
        Timer15.Enabled = False
        Timer16.Enabled = False
        Timer18.Enabled = False
    End Sub

    Private Sub PURPLE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub YELLOW2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub PINK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub LBLUE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF4.Show()
    End Sub

    Private Sub YELLOW1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub LBLUE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        Form9.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF1.Show()

        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "MODULATION"
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF2.Show()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim OpenCMD
        OpenCMD = CreateObject("wscript.shell")
        OpenCMD.run("explorer.exe shell:appsFolder\58354DavstarApps.LCARSComputerSystem_2h5gzyvxkr5rr!App")

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim proc As New System.Diagnostics.Process()

        ' proc = Process.Start("C:\Program Files\WindowsApps\58354DavstarApps.LCARSComputerSystem_3.1.8.7_neutral_2h5gzyvxkr5rr\LCARS Interface Suite.exe", "")
        proc = Process.Start("C:\Program Files (x86)\LCARS Mail\lmail.exe", "")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim proc As New System.Diagnostics.Process()

        ' proc = Process.Start("C:\Program Files\WindowsApps\58354DavstarApps.LCARSComputerSystem_3.1.8.7_neutral_2h5gzyvxkr5rr\LCARS Interface Suite.exe", "")
        proc = Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        Form9.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        StopBackgroundSound()
        Button11.Visible = True
        Button8.Visible = False
        'My.Computer.Audio.Stop("C:\VR_MAIN\LCARS_KEYPAD_VB\Resources\STTNGAmbientEngine.wav")
        'My.Computer.Audio.Play("C:\VR_MAIN\LCARS_KEYPAD_VB\Resources\STTNGAmbientEngine.wav",
        'AudioPlayMode.WaitToComplete)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'enables the outside ship sounds of the operations of the ship (not engineering)
        PlayLoopingBackgroundSoundFile()
        Button11.Visible = False
        Button8.Visible = True
    End Sub


    Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("C:\VR_MAIN\LCARS_KEYPAD_VB\Resources\STTNGAmbientEngine.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF2.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF3.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1000)
        SWF4.Show()
    End Sub
End Class
