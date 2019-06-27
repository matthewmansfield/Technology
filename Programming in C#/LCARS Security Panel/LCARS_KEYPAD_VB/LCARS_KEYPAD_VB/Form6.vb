Imports System.Timers
Public Class Form6
     Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim tmr As New System.Timers.Timer()
        tmr.Interval = 5000
        tmr.Enabled = True
        tmr.Start()
        AddHandler tmr.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Delegate Sub CloseFormCallback()

    Private Sub CloseForm()
        If InvokeRequired Then
            Dim d As New CloseFormCallback(AddressOf CloseForm)
            Invoke(d, Nothing)
        Else
            Close()
        End If
    End Sub

    Private Sub OnTimedEvent(ByVal sender As Object, ByVal e As ElapsedEventArgs)
        CloseForm()
    End Sub
End Class