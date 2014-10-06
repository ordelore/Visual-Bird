'Programmer: Lorenzo Orders
'Description: Flappy Bird in Visual Basic
'License: Use this code but give me credit


Public Class frmMain
    'Prepare variables

    Dim intPipeDistance As Integer
    Dim intScore As Integer
    Dim intHigh As Integer
    Dim intOpening As Integer
    Dim intTime As Integer
    Public Shared Sub Randomize()
        'Random number for opening of pipe


    End Sub

    Private Sub frmMain_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Make bird go up
        intTime = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrFall.Tick

        If intTime > 0 Then
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - intTime)
            intTime = intTime - 1
        End If
        If intPipeDistance = 0 Then
            lblScore.Text = intScore
            Dim intOpening As Integer
            Dim rndNumb As New Random
            intOpening = rndNumb.Next(1, 9)
            'See if bird has crossed the pipe
            intPipeDistance = 500
        End If
        If Not (intTime = 5) Then
            'picVird.Location = New Point(picBird.Location.X, 'y=ax^2'
            picBird.Location = New Point(picBird.Location.X, 0.01 * intTime * intTime)
            intTime = intTime + 1
        End If

        If picBird.Location.Y < 465 Then
            'Measures how long since the last pipe travel and moves pipe 1 closer
            intPipeDistance = intPipeDistance - 2
            picPipe.Location = New Point(intPipeDistance, picPipe.Location.Y)
            picOpening.Location = New Point(intPipeDistance, intOpening * 10)
            lblScore.Text = intScore
            If intPipeDistance = picBird.Location.X - picOpening.Size.Width Then
                'If pipe is at right distance, then add score.
                intScore = intScore + 1
                intPipeDistance = 0
            End If
            For Z = 1 To 5 Step 1
                'Bird go down
                picBird.Location = New Point(picBird.Location.X, picBird.Location.Y + 1)
            Next Z
        End If

        If (picBird.Location.Y = 465) Then
            'End game if bird hits the ground
            Ending()
        End If

        If picBird.Location.X + picOpening.Size.Width >= picOpening.Location.X Then
            'If bird hits pipe, end game
            If picBird.Location.Y <= picOpening.Location.Y Then
                Ending()
            End If
            If picBird.Location.Y <= picOpening.Location.Y Then
                Ending()
            End If
        End If

    End Sub
    Public Sub Ending()
        If intScore > intHigh Then
            'update high score
            intHigh = intScore
        End If
        picBird.Visible = False
        picPipe.Visible = False
        lblScore.Text = intHigh
        tmrEnd.Enabled = True

    End Sub

    Private Sub picPipe_MouseClick(sender As Object, e As MouseEventArgs) Handles picPipe.MouseClick
        For Z = 1 To 45 Step 1
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - 1)
        Next Z
    End Sub

    Private Sub picOpening_MouseClick(sender As Object, e As MouseEventArgs) Handles picOpening.MouseClick
        For Z = 1 To 45 Step 1
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - 1)
        Next Z
    End Sub

    Private Sub tmrEnd_Tick(sender As Object, e As EventArgs) Handles tmrEnd.Tick
        Me.Close()
    End Sub
End Class