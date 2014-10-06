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
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.tmrFall = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picPipe = New System.Windows.Forms.PictureBox()
        Me.picOpening = New System.Windows.Forms.PictureBox()
        Me.tmrEnd = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.picBird.Image = Global.Gamefail.My.Resources.Resources.flapbird1
        Me.picBird.Location = New System.Drawing.Point(192, 210)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(40, 30)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 0
        Me.picBird.TabStop = False
        '
        'tmrFall
        '
        Me.tmrFall.Enabled = True
        Me.tmrFall.Interval = 10
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Franklin Gothic Book", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(212, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 37)
        Me.lblScore.TabIndex = 1
        '
        'picPipe
        '
        Me.picPipe.BackColor = System.Drawing.Color.Transparent
        Me.picPipe.Image = Global.Gamefail.My.Resources.Resources.pipe
        Me.picPipe.Location = New System.Drawing.Point(375, 0)
        Me.picPipe.Name = "picPipe"
        Me.picPipe.Size = New System.Drawing.Size(40, 480)
        Me.picPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPipe.TabIndex = 2
        Me.picPipe.TabStop = False
        '
        'picOpening
        '
        Me.picOpening.BackColor = System.Drawing.Color.Transparent
        Me.picOpening.Location = New System.Drawing.Point(375, 190)
        Me.picOpening.Name = "picOpening"
        Me.picOpening.Size = New System.Drawing.Size(40, 70)
        Me.picOpening.TabIndex = 3
        Me.picOpening.TabStop = False
        '
        'tmrEnd
        '
        Me.tmrEnd.Interval = 10000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gamefail.My.Resources.Resources.jprgqobw
        Me.ClientSize = New System.Drawing.Size(424, 482)
        Me.Controls.Add(Me.picOpening)
        Me.Controls.Add(Me.picPipe)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picBird)
        Me.Name = "frmMain"
        Me.Text = "Flappy Bird"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFall As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picPipe As System.Windows.Forms.PictureBox
    Friend WithEvents picOpening As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnd As System.Windows.Forms.Timer

End Class
