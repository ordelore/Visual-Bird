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
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picBird.Image = Global.Gamefail.My.Resources.Resources.flapbird1
        Me.picBird.Location = New System.Drawing.Point(265, 263)
        Me.picBird.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(88, 65)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 0
        Me.picBird.TabStop = False
        '
        'tmrFall
        '
        Me.tmrFall.Enabled = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("TI Calc Fonts", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(309, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 38)
        Me.lblScore.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gamefail.My.Resources.Resources.jprgqobw
        Me.ClientSize = New System.Drawing.Size(619, 485)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picBird)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Flappy Bird"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFall As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label

End Class
