Imports System.IO
Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Display_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub

    Private Sub Number1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number1.Click
        TxtToTest.Focus()
        SendKeys.Send(1)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    

    Private Sub Number2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number2.Click
        TxtToTest.Focus()
        SendKeys.Send(1)
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

    Private Sub BtnStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStar.Click
        If (TxtToTest.Text = "") Then
            'MsgBox("Nothing to delete!", _
            ' MsgBoxStyle.OkOnly, _
            '"Error!")
            My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        Else
            TxtToTest.Focus()
            TxtToTest.SelectionStart = TxtToTest.Text.Length + 1
            TxtToTest.Text = TxtToTest.Text.Remove(TxtToTest.Text.Length - 1, 1)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub BtnPound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPound.Click
        Dim aFileStream As FileStream = Nothing
        Dim encode As New System.Text.ASCIIEncoding

        'check to 
        If Len(Dir("AdminPsswd.txt")) > 0 Then
            'file exists - proceed accordingly
            Dim fso As Object
            fso = CreateObject("Scripting.FileSystemObject")
            fso.Deletefile("AdminPsswd.txt")

            Try
                aFileStream = New FileStream("AdminPsswd.txt", FileMode.OpenOrCreate, FileAccess.Write)

                Dim myBinaryWriter As New BinaryWriter(aFileStream)
                myBinaryWriter.Write(encode.GetBytes(TxtToTest.Text))
                'myBinaryWriter.Write(1) 
            Catch ye As Exception
                Console.WriteLine(ye.StackTrace)
            Finally
                If Not (aFileStream Is Nothing) Then aFileStream.Close()
            End Try

            PassWordAccepted()
        Else
            'file doesn't exist - take appropriate action
            'Dim fso As Object
            'fso = CreateObject("Scripting.FileSystemObject")
            ' fso.Deletefile("c:\windows\desktop\doc1.doc")
            My.Computer.Audio.Play(My.Resources.Engineering_Alert, AudioPlayMode.Background)
            System.Threading.Thread.Sleep(800)

        End If
    End Sub
    Sub PassWordAccepted()
        
      
        lblPassword.Visible = True

        Me.Refresh()
        Threading.Thread.Sleep(200)

        My.Computer.Audio.Play(My.Resources.Input_successful_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(1500)

   
        lblPassword.Visible = False

        Me.Refresh()
        Threading.Thread.Sleep(100)

    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim aFileStream As FileStream = Nothing
        Dim encode As New System.Text.ASCIIEncoding

        If Len(Dir("AdminPsswd.txt")) > 0 Then
            'file exists - proceed accordingly

            Dim password_code As String = File.ReadAllText("AdminPsswd.txt")
            ' Initializes string.
            Dim TestString As String = password_code
            Dim TrimString As String
            Dim final As String

            TrimString = Trim(TestString)
            final = TrimString.Replace("\n", "").Replace("\r", "")

            TxtToTest.Text = final

            ' My.Computer.Audio.Play(My.Resources.Input_successful_2, AudioPlayMode.Background)
        Else
            'file doesn't exist - take appropriate action
            Try
                aFileStream = New FileStream("AdminPsswd.txt", FileMode.OpenOrCreate, FileAccess.Write)

                Dim myBinaryWriter As New BinaryWriter(aFileStream)
                myBinaryWriter.Write(encode.GetBytes("No Password on File"))
                'myBinaryWriter.Write(1) 
            Catch ye As Exception
                Console.WriteLine(ye.StackTrace)
            Finally
                If Not (aFileStream Is Nothing) Then aFileStream.Close()
            End Try
            'now set the text in the file to the textbox

            Dim password_code1 As String = File.ReadAllText("AdminPsswd.txt")
            ' Initializes string.
            Dim TestString1 As String = password_code1
            Dim TrimString1 As String
            Dim final1 As String

            TrimString1 = Trim(TestString1)
            final1 = TrimString1.Replace("\n", "").Replace("\r", "")

            TxtToTest.Text = final1
        End If
        TxtToTest.Focus()

    End Sub



    Sub color_clear()
        BackColor = Color.Red

        TransparencyKey = BackColor
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub
End Class