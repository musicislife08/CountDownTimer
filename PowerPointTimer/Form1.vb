Public Class Form1
    Public Time As New TimeSpan
    Private Sub CDTimer_Tick(sender As Object, e As EventArgs) Handles CDTimer.Tick
        Time = Time.Subtract(New TimeSpan(0, 0, 1))
        If Time.TotalSeconds <= 30 Then
            lblCountDown.ForeColor = Color.Red
        ElseIf Time.TotalSeconds <= 90 Then
            lblCountDown.ForeColor = Color.Orange
        End If
        lblCountDown.Text = Time.ToString("c")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Time = New TimeSpan(0, CInt(tbMin.Text), 0)
        Dim t = Time.ToString("c")
        lblCountDown.Text = t
        lblCountDown.ForeColor = Color.Black
        CDTimer.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Time = New TimeSpan(0, CInt(tbMin.Text), 0)
        TimerCheckHotkey.Enabled = True
    End Sub

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    Private Sub TimerCheckHotkey_Tick(sender As Object, e As EventArgs) Handles TimerCheckHotkey.Tick
        Dim R As Boolean = GetAsyncKeyState(Keys.Right)
        Dim L As Boolean = GetAsyncKeyState(Keys.Left)
        Dim D As Boolean = GetAsyncKeyState(Keys.Down)
        Dim U As Boolean = GetAsyncKeyState(Keys.Up)
        If R Or L Or D Or U Then
            Time = New TimeSpan(0, CInt(tbMin.Text), 0)
            Dim t = Time.ToString("c")
            lblCountDown.Text = t
            lblCountDown.ForeColor = Color.Black
            CDTimer.Start()
            TimerCheckHotkey.Enabled = True
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        If CDTimer.Enabled Then
            BtnStop.Text = "Resume"
            CDTimer.Enabled = False
        Else
            BtnStop.Text = "Stop"
            CDTimer.Enabled = True
        End If
    End Sub

End Class
