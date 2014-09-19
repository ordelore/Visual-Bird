'Programmer: Lorenzo Orders
'Description: Flappy Bird in Visual Basic
'License: Use this code but give me credit
Public Class frmMain
    'Pre
    Dim intPipeDistance As Integer
    Dim intScore As Integer
    Dim intHigh As Integer



    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'Make bird go up
        For Z = 1 To 45 Step 1
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - 1)
        Next Z

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrFall.Tick

        If picBird.Location.Y < 465 Then
            'Measures how long since the last pipe travel
            intPipeDistance = intPipeDistance + 1
            lblScore.Text = intScore
            If intPipeDistance = 25 Then
                'If pipe is at right distance, then add score.
                intScore = intScore + 1
                intPipeDistance = 0
            End If
            For Z = 1 To 5 Step 1
                picBird.Location = New Point(picBird.Location.X, picBird.Location.Y + 1)
            Next Z

        End If

        If picBird.Location.Y = 465 Then
            picBird.Location = New Point(1000, 1000)
            If intScore > intHigh Then
                'update high score
                intHigh = intScore
            End If

        End If

    End Sub
End Class
