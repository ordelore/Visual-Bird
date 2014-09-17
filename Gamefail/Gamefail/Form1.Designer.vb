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
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picBird.Image = Global.Gamefail.My.Resources.Resources.flapbird1
        Me.picBird.Location = New System.Drawing.Point(190, 210)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(66, 53)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 0
        Me.picBird.TabStop = False
        '
        'tmrFall
        '
        Me.tmrFall.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gamefail.My.Resources.Resources.jprgqobw
        Me.ClientSize = New System.Drawing.Size(464, 480)
        Me.Controls.Add(Me.picBird)
        Me.Name = "frmMain"
        Me.Text = "Flappy Bird"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFall As System.Windows.Forms.Timer

End Class
