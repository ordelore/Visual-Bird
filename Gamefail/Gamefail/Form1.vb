'Programmer: Lorenzo Orders
'Description: Flappy Bird in Visual Basic
'License: Use this code but give me credit


Public Class frmMain
    'Prepare variables
    Dim intPipeDistance As Integer
    Dim intScore As Integer
    Dim intHigh As Integer
    Dim intOpening
    Public Shared Sub Randomize()
        'Random number for opening of pipe
        Dim intOpening = 
    End Sub




    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'Make bird go up
        For Z = 1 To 45 Step 1
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - 1)
        Next Z

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrFall.Tick

        If intPipeDistance = 0 Then
            Randomize()
            'See if bird has crossed the pipe
            intPipeDistance = 500

        End If

        If picBird.Location.Y < 465 Then
            'Measures how long since the last pipe travel and moves pipe 1 closer
            intPipeDistance = intPipeDistance - 2
            picPipe.Location = New Point(intPipeDistance, picPipe.Location.Y)
            picOpening.Location = New Point(intPipeDistance, intOpening)
            lblScore.Text = intScore
            If intPipeDistance = picBird.Location.X - 40 Then
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
            Ending()
        End If
        If Not ((intPipeDistance <= picBird.Location.X <= intPipeDistance + 40) And (intOpening <= picBird.Location.Y <= intOpening + 50)) Then
            Ending()
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
        For Q = 1 To 900 Step 1
        Next
        Me.Close()
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
End Class
