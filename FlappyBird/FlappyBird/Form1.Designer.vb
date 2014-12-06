<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picPipe = New System.Windows.Forms.PictureBox()
        Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
        Me.picOpening = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.tmrFlap = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        CType(Me.picPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPipe
        '
        Me.picPipe.Image = Global.FlappyBird.My.Resources.Resources.pipe
        Me.picPipe.Location = New System.Drawing.Point(434, -4)
        Me.picPipe.Name = "picPipe"
        Me.picPipe.Size = New System.Drawing.Size(38, 470)
        Me.picPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPipe.TabIndex = 0
        Me.picPipe.TabStop = False
        '
        'tmrTick
        '
        Me.tmrTick.Enabled = True
        Me.tmrTick.Interval = 25
        '
        'picOpening
        '
        Me.picOpening.BackColor = System.Drawing.Color.Transparent
        Me.picOpening.Location = New System.Drawing.Point(434, 151)
        Me.picOpening.Name = "picOpening"
        Me.picOpening.Size = New System.Drawing.Size(38, 72)
        Me.picOpening.TabIndex = 1
        Me.picOpening.TabStop = False
        '
        'picBird
        '
        Me.picBird.Image = Global.FlappyBird.My.Resources.Resources.flapbird
        Me.picBird.Location = New System.Drawing.Point(227, 216)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(43, 30)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 2
        Me.picBird.TabStop = False
        '
        'tmrFlap
        '
        Me.tmrFlap.Enabled = True
        Me.tmrFlap.Interval = 25
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(227, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(30, 32)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        '
        'lblGameOver
        '
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(76, 130)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(332, 78)
        Me.lblGameOver.TabIndex = 4
        Me.lblGameOver.Text = "Game Over! Press Me To Play Again!"
        Me.lblGameOver.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlappyBird.My.Resources.Resources.jprgqobw
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.picOpening)
        Me.Controls.Add(Me.picPipe)
        Me.Name = "frmMain"
        Me.Text = "The Incredible Flapable Bird!"
        CType(Me.picPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPipe As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTick As System.Windows.Forms.Timer
    Friend WithEvents picOpening As System.Windows.Forms.PictureBox
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFlap As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblGameOver As System.Windows.Forms.Label

End Class
