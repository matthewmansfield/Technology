Imports System.IO
Public Class Form3

    Private Sub btnExplore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplore.Click
        Me.PictureBox3.Visible = True
        Me.btnLCARSTERMINAL.Visible = True

        Me.btnAddPassword.Visible = True
        Me.btnDeletePassword.Visible = True

        Me.PIC_ADD_PASSWORD.Visible = True
        Me.PIC_DEL_PASSWORD.Visible = True
        Me.AxShockwaveFlash1.Visible = True

        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
    End Sub
    'Private Sub btnExplore_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplore.MouseHover
    '    Me.picmenu.Visible = True
    'End Sub
    'Private Sub btnExplore_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExplore.MouseLeave
    '    Me.picmenu.Visible = False
    'End Sub

    Private Sub btnQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQUIT.Click
        My.Computer.Audio.Play(My.Resources.Display_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
        Me.Close()
    End Sub
    Private Sub btnQUIT_onhover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQUIT.Click
        Me.Close()
    End Sub

    Private Sub btnLCARSTERMINAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCARSTERMINAL.Click
        Me.PictureBox3.Visible = False
        Me.btnLCARSTERMINAL.Visible = False

        Me.btnAddPassword.Visible = False
        Me.btnDeletePassword.Visible = False
    End Sub

    ' Private Sub btnQUIT_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQUIT.MouseHover
    '     Me.picquit.Visible = True
    ' End Sub
    ' Private Sub btnQUIT_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQUIT.MouseLeave
    '     Me.picquit.Visible = False
    ' End Sub

    'Private Sub btnAddPassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPassword.MouseHover
    '    Me.PIC_ADD_PASSWORD.Visible = True
    'End Sub
    'Private Sub btnAddPassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPassword.MouseLeave
    '    Me.PIC_ADD_PASSWORD.Visible = False
    'End Sub

    'Private Sub btnDeletePassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePassword.MouseHover
    '    Me.PIC_DEL_PASSWORD.Visible = True
    'End Sub
    'Private Sub btnDeletePassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePassword.MouseLeave
    '    Me.PIC_DEL_PASSWORD.Visible = False
    'End Sub

    Private Sub btnAddPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPassword.Click
        TxtPssWd.Visible = True
        BtnSave.Visible = True
        'PicSave.Visible = True
        GrpKeyPad.Visible = True
        Me.PicSave.Visible = True
        My.Computer.Audio.Play(My.Resources.Ready_for_input_2, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
    End Sub

    ' Private Sub TxtPssWd_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPssWd.MouseHover
    '     Me.PictureBox5.Visible = True
    ' End Sub

    Private Sub btnDeletePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePassword.Click
        'TxtPssWd.Visible = True
        ' BtnSave.Visible = True
        ' PicSave.Visible = True
        ' GrpKeyPad.Visible = True
        Me.PIC_DEL_PASSWORD.Visible = False
        Me.PictureBox3.Visible = False
        Me.btnLCARSTERMINAL.Visible = False
        Me.PIC_ADD_PASSWORD.Visible = False

        Me.btnAddPassword.Visible = False
        Me.btnDeletePassword.Visible = False
        Me.AxShockwaveFlash1.Visible = False

        GrpKeyPad.Visible = False
        TxtPssWd.Visible = False
        BtnSave.Visible = False
        PicSave.Visible = False
        My.Computer.Audio.Play(My.Resources.Deskviewer_screen_off, AudioPlayMode.Background)
        System.Threading.Thread.Sleep(800)
    End Sub


    Private Sub TxtPssWd_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPssWd.MouseLeave
        Me.PictureBox5.Visible = False
    End Sub

    Private Sub Number1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number1.Click

        TxtPssWd.Focus()
        SendKeys.Send(1)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number2.Click
        TxtPssWd.Focus()
        SendKeys.Send(2)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number3.Click
        TxtPssWd.Focus()
        SendKeys.Send(3)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number4.Click
        TxtPssWd.Focus()
        SendKeys.Send(4)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number5.Click
        TxtPssWd.Focus()
        SendKeys.Send(5)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number6.Click
        TxtPssWd.Focus()
        SendKeys.Send(6)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number7.Click
        TxtPssWd.Focus()
        SendKeys.Send(7)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number8.Click
        TxtPssWd.Focus()
        SendKeys.Send(8)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number9.Click
        TxtPssWd.Focus()
        SendKeys.Send(9)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub Number0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number0.Click
        TxtPssWd.Focus()
        SendKeys.Send(0)
        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
    End Sub

    Private Sub BtnStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStar.Click
        'GrpKeyPad.Visible = False
        'TxtPssWd.Visible = False
        'BtnSave.Visible = False
        'PicSave.Visible = False
        If (TxtPssWd.Text = "") Then
            'MsgBox("Nothing to delete!", _
            ' MsgBoxStyle.OkOnly, _
            '"Error!")
            My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
        Else
            TxtPssWd.Focus()
            TxtPssWd.SelectionStart = TxtPssWd.Text.Length + 1
            TxtPssWd.Text = TxtPssWd.Text.Remove(TxtPssWd.Text.Length - 1, 1)
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If


    End Sub

    ' Private Sub BtnSave_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.MouseLeave
    '     PicSave.Visible = False
    ' End Sub

    'Private Sub BtnSave_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.MouseHover
    '    PicSave.Visible = True
    'End Sub

    Private Sub BtnPound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPound.Click
        'MsgBox("This button doesn't do anything.", _
        ' vbExclamation, _
        ' "So Solly")
        My.Computer.Audio.Play(My.Resources.Access_Denied, AudioPlayMode.Background)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        GrpKeyPad.Visible = False
        TxtPssWd.Visible = False
        BtnSave.Visible = False
        PicSave.Visible = False

        'TxtPssWd.Text = Val(TxtPssWd.Text)
        'Dim password_code As String = File.ReadAllText("password.bin")
        ' Initializes string.
        Dim aFileStream As FileStream = Nothing
        Dim encode As New System.Text.ASCIIEncoding

        'check to 
        If Len(Dir("password.txt")) > 0 Then
            'file exists - proceed accordingly
            Dim fso As Object
            fso = CreateObject("Scripting.FileSystemObject")
            fso.Deletefile("password.txt")

            Try
                aFileStream = New FileStream("password.txt", FileMode.OpenOrCreate, FileAccess.Write)

                Dim myBinaryWriter As New BinaryWriter(aFileStream)
                myBinaryWriter.Write(encode.GetBytes(TxtPssWd.Text))
                'myBinaryWriter.Write(1) 
            Catch ye As Exception
                Console.WriteLine(ye.StackTrace)
            Finally
                If Not (aFileStream Is Nothing) Then aFileStream.Close()
            End Try

            My.Computer.Audio.Play(My.Resources.Input_successful_2, AudioPlayMode.Background)
            System.Threading.Thread.Sleep(800)
        Else
            'file doesn't exist - take appropriate action
            'Dim fso As Object
            'fso = CreateObject("Scripting.FileSystemObject")
            ' fso.Deletefile("c:\windows\desktop\doc1.doc")
            My.Computer.Audio.Play(My.Resources.Engineering_Alert, AudioPlayMode.Background)
            System.Threading.Thread.Sleep(800)

        End If
        'My.Computer.Audio.Play(My.Resources.Input_Successful_1, AudioPlayMode.Background)

        ' Dim objWriter As New System.IO.StreamWriter("password.bin", False)
        '  Dim TestString As String = TxtPssWd.Text
        '   Dim TrimString As String
        '   TrimString = Trim(TestString)
        '   TxtPssWd.Text = TrimString
        '   objWriter.WriteLine(TxtPssWd.Text)
        '   objWriter.Close()


    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim password As New OpenFileDialog

        'password.ShowDialog()

        ' Dim password_code As String = File.ReadAllText("password.txt")

        ' TxtPssWd.Text = password_code





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

            TxtPssWd.Text = final

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

            TxtPssWd.Text = final1
        End If

    End Sub

    Private Sub TxtPssWd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPssWd.TextChanged
        TxtPssWd.SelectionStart = TxtPssWd.Text.Length + 1
    End Sub
    Private Sub TxtPssWd_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPssWd.GotFocus
        TxtPssWd.SelectionStart = TxtPssWd.Text.Length + 1
    End Sub


End Class