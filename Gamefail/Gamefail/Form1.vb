'Programmer: Lorenzo Orders
'Description: Flappy Bird in Visual Basic
'License: Use this code but give me credit
Public Class frmMain




    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'Make bird go up
        For Z = 1 To 25 Step 1
            picBird.Location = New Point(picBird.Location.X, picBird.Location.Y - 1)
        Next Z

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrFall.Tick
        If picBird.Location.Y < 465 Then
            For Z = 1 To 5 Step 1
                picBird.Location = New Point(picBird.Location.X, picBird.Location.Y + 1)
            Next Z

        End If

        If picBird.Location.Y = 465 Then

        End If

    End Sub
End Class
