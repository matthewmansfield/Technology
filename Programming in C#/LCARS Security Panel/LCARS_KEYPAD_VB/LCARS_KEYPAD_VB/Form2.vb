Imports System.IO
Public Class Form2

    Private Sub ButtonStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStar.Click
        'Me.Close()
        If (TxtToTest.Text = "") Then
            ' MsgBox("Nothing to delete!", _
            'MsgBoxStyle.OkOnly, _
            '"Error!")
            My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
            'System.Threading.Thread.Sleep(800)
        Else
            TxtToTest.Focus()
            TxtToTest.SelectionStart = TxtToTest.Text.Length + 1
            TxtToTest.Text = TxtToTest.Text.Remove(TxtToTest.Text.Length - 1, 1)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            'System.Threading.Thread.Sleep(800)
        End If

    End Sub

    Private Sub Number1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number1.Click
        TxtToTest.Focus()
        SendKeys.Send(1)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        'System.Threading.Thread.Sleep(800)
    End Sub

    Private Sub Number2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number2.Click
        TxtToTest.Focus()
        SendKeys.Send(2)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number3.Click
        TxtToTest.Focus()
        SendKeys.Send(3)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number4.Click
        TxtToTest.Focus()
        SendKeys.Send(4)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number5.Click
        TxtToTest.Focus()
        SendKeys.Send(5)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number6.Click
        TxtToTest.Focus()
        SendKeys.Send(6)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number7.Click
        TxtToTest.Focus()
        SendKeys.Send(7)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number8.Click
        TxtToTest.Focus()
        SendKeys.Send(8)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number9.Click
        TxtToTest.Focus()
        SendKeys.Send(9)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub ButtonZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZero.Click
        TxtToTest.Focus()
        SendKeys.Send(0)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub ButtonPound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPound.Click
        'SendKeys.Send("{ENTER}")
        Dim Str1 As String 'which is what is on file
        Dim Str2 As String 'the user input
        Dim TrimString As String
        Dim final As String

        'Dim aFileStream As FileStream
        'filtering the code to weed out whitespace, etc
        Dim password_code As String = File.ReadAllText("password.txt") 'File.ReadAllText("password.txt")
        Dim TestString As String = password_code


        ' Returns "<-Trim->  ".
        'TrimString = LTrim(TestString)
        ' Returns "  <-Trim->".
        'TrimString = RTrim(TestString)
        ' Returns "<-Trim->".
        'TrimString = LTrim(RTrim(TestString))
        ' Using the Trim function alone achieves the same result.
        ' Returns "<-Trim->".
        TrimString = Trim(TestString)
        final = TrimString.Replace("\n", "").Replace("\r", "")

        'TextBox2.Text = final

        Str1 = final
        Str2 = TxtToTest.Text

        'JUST IN CASE ----- > this works here:
        ' Label1.Text = ""
        ' Dim MyInt As Integer = StrComp(Str1, Str2)
        ' Label1.Text = MyInt


        If (StrComp(Str1, Str2, vbTextCompare) = 0) Then
            'Form6.Show()
           
            OpenDoor() 'if it's the correct code, open the door


        ElseIf (StrComp(Str1, Str2, vbTextCompare) = -1) Then

            ErrorRed()
            
            '   MsgBox("Incorrect Password. Please Try Again.", _
            'MsgBoxStyle.OkOnly, _
            '  "Whoa...")
            'change all of the colors of the pad also
            '





        ElseIf (StrComp(Str1, Str2, vbTextCompare) = 1) Then
            ErrorRed()

            ' My.Computer.Audio.Play(My.Resources.Engineering_Alert, AudioPlayMode.Background)
            'System.Threading.Thread.Sleep(800)
            '  MsgBox("Incorrect Password. Please Try Again.", _
            'MsgBoxStyle.OkOnly, _
            '   "Whoa...")

            'change all of the colors of the pad also


        End If

        TxtToTest.Text = ""


    End Sub

    Sub OpenDoor()
        Dim ProcID As Integer

        'System.Diagnostics.Process.Start("C:\VR_MAIN\door\door.lnk") ' this was when I used a batch file

        'trying something new
        'authorization_ack
        'My.Computer.Audio.Play(My.Resources.Input_Successful_1, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.authorization_ack, AudioPlayMode.Background)
        'System.Threading.Thread.Sleep(800)

        System.Diagnostics.Process.Start("C:\VR_MAIN\door\DOOR_OPEN_AND_LOCK.bs2")
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

    Sub ErrorRed()

        My.Computer.Audio.Play(My.Resources.Engineering_Alert, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)

        Number1.BackColor = Color.Red
        Number2.BackColor = Color.Red
        Number3.BackColor = Color.Red

        Number4.BackColor = Color.Red
        Number5.BackColor = Color.Red
        Number6.BackColor = Color.Red

        Number7.BackColor = Color.Red
        Number8.BackColor = Color.Red
        Number9.BackColor = Color.Red

        ButtonZero.BackColor = Color.Red
        ButtonStar.BackColor = Color.Red
        ButtonPound.BackColor = Color.Red
        TxtToTest.BackColor = Color.Red

        Me.Refresh()
        Threading.Thread.Sleep(100)

        Number1.BackColor = Color.RoyalBlue
        Number2.BackColor = Color.RoyalBlue
        Number3.BackColor = Color.RoyalBlue

        Number4.BackColor = Color.RoyalBlue
        Number5.BackColor = Color.RoyalBlue
        Number6.BackColor = Color.RoyalBlue

        Number7.BackColor = Color.RoyalBlue
        Number8.BackColor = Color.RoyalBlue
        Number9.BackColor = Color.RoyalBlue

        ButtonZero.BackColor = Color.RoyalBlue
        ButtonStar.BackColor = Color.RoyalBlue
        ButtonPound.BackColor = Color.Magenta
        TxtToTest.BackColor = Color.RoyalBlue

        Me.Refresh()

        Threading.Thread.Sleep(100)

        Number1.BackColor = Color.Red
        Number2.BackColor = Color.Red
        Number3.BackColor = Color.Red

        Number4.BackColor = Color.Red
        Number5.BackColor = Color.Red
        Number6.BackColor = Color.Red

        Number7.BackColor = Color.Red
        Number8.BackColor = Color.Red
        Number9.BackColor = Color.Red

        ButtonZero.BackColor = Color.Red
        ButtonStar.BackColor = Color.Red
        ButtonPound.BackColor = Color.Red
        TxtToTest.BackColor = Color.Red

        Me.Refresh()
        Threading.Thread.Sleep(100)

        Number1.BackColor = Color.RoyalBlue
        Number2.BackColor = Color.RoyalBlue
        Number3.BackColor = Color.RoyalBlue

        Number4.BackColor = Color.RoyalBlue
        Number5.BackColor = Color.RoyalBlue
        Number6.BackColor = Color.RoyalBlue

        Number7.BackColor = Color.RoyalBlue
        Number8.BackColor = Color.RoyalBlue
        Number9.BackColor = Color.RoyalBlue

        ButtonZero.BackColor = Color.RoyalBlue
        ButtonStar.BackColor = Color.RoyalBlue
        ButtonPound.BackColor = Color.Magenta
        TxtToTest.BackColor = Color.RoyalBlue

        Me.Refresh()
        Threading.Thread.Sleep(100)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim aFileStream As FileStream = Nothing
        Dim encode As New System.Text.ASCIIEncoding

        If Len(Dir("password.txt")) > 0 Then
            'file exists - proceed accordingly

            Dim password_code As String = File.ReadAllText("password.txt")
            ' Initializes string.
            Dim TestString As String = password_code
            Dim TrimString As String
            Dim final As String

            TrimString = Trim(TestString)
            final = TrimString.Replace("\n", "").Replace("\r", "")

            TxtOnFile.Text = final

            ' My.Computer.Audio.Play(My.Resources.Input_successful_2, AudioPlayMode.Background)
        Else
            'file doesn't exist - take appropriate action
            Try
                aFileStream = New FileStream("password.txt", FileMode.OpenOrCreate, FileAccess.Write)

                Dim myBinaryWriter As New BinaryWriter(aFileStream)
                myBinaryWriter.Write(encode.GetBytes("No Password on File"))
                'myBinaryWriter.Write(1) 
            Catch ye As Exception
                Console.WriteLine(ye.StackTrace)
            Finally
                If Not (aFileStream Is Nothing) Then aFileStream.Close()
            End Try
            'now set the text in the file to the textbox

            Dim password_code1 As String = File.ReadAllText("password.txt")
            ' Initializes string.
            Dim TestString1 As String = password_code1
            Dim TrimString1 As String
            Dim final1 As String

            TrimString1 = Trim(TestString1)
            final1 = TrimString1.Replace("\n", "").Replace("\r", "")

            TxtToTest.Text = final1





        End If









    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.Deskviewer_screen_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub

    Private Sub PicSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSave.Click
        My.Computer.Audio.Play(My.Resources.Deskviewer_screen_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Display_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub
End Class