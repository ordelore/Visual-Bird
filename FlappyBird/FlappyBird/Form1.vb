Public Class frmMain
    Private picBirdX As Integer
    Private picBirdY As Integer
    Private blnGameOver As Boolean
    Private blnFlap As Boolean
    Private intFlapTimes As Integer
    Private intScore As Integer
    Private rndRandom As New Random

    Private Sub frmMain_Click(sender As Object, e As EventArgs) Handles Me.Click, picPipe.Click, picBird.Click, picOpening.Click, lblScore.Click
        If blnGameOver = False Then
            blnFlap = True
            intFlapTimes = 0
        End If
    End Sub

    Private Sub tmrTick_Tick(sender As Object, e As EventArgs) Handles tmrTick.Tick
        picPipe.Left -= 2
        picOpening.Left -= 2
        picBird.Top += 2
        If picPipe.Left = -picPipe.Width Then
            intScore += 1
            lblScore.Text = intScore.ToString()
            lblScore.Location = New Point((Me.Width / 2) - (lblScore.Width / 2), lblScore.Location.Y)
            picPipe.Left = Me.Width
            picOpening.Left = Me.Width
            picOpening.Top = 10 * rndRandom.Next(2, 48)
        End If
        If (picBird.Bounds.IntersectsWith(picPipe.Bounds)) And Not (picBird.Bounds.IntersectsWith(picOpening.Bounds)) Then
            blnGameOver = True
        End If
        If picBird.Top + picBird.Height = 500 Then
            blnGameOver = True
        End If
        If blnGameOver = True Then
            tmrTick.Stop()
            tmrFlap.Stop()
            lblGameOver.Visible = True
        End If
    End Sub

    Private Sub tmrFlap_Tick(sender As Object, e As EventArgs) Handles tmrFlap.Tick
        If blnFlap = True Then
            picBird.Top -= 6
            intFlapTimes += 1
            If intFlapTimes = 8 Then
                blnFlap = False
                intFlapTimes = 0
            End If
        End If
    End Sub

    Private Sub lblGameOver_Click(sender As Object, e As EventArgs) Handles lblGameOver.Click
        blnGameOver = False
        tmrFlap.Enabled = True
        tmrTick.Enabled = True
        picBird.Top = 30
        picPipe.Left = 434
        picOpening.Left = 434
        lblGameOver.Visible = False
        lblScore.Text = 0
        intScore = 0
        lblScore.Location = New Point((Me.Width / 2) - (lblScore.Width / 2), lblScore.Location.Y)
        picPipe.Left = Me.Width
        picOpening.Left = Me.Width
        picOpening.Top = 10 * rndRandom.Next(2, 48)
    End Sub
End Class
