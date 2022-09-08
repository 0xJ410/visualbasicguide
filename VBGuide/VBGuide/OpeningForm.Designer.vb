<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpeningForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningForm))
        Me.VisualBasicLabel = New System.Windows.Forms.Label()
        Me.LTELabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.HelpButton1 = New System.Windows.Forms.Button()
        Me.AppVersionLabel = New System.Windows.Forms.Label()
        Me.HelpButton2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualBasicLabel
        '
        Me.VisualBasicLabel.AutoSize = True
        Me.VisualBasicLabel.BackColor = System.Drawing.Color.Transparent
        Me.VisualBasicLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualBasicLabel.Location = New System.Drawing.Point(329, 9)
        Me.VisualBasicLabel.Name = "VisualBasicLabel"
        Me.VisualBasicLabel.Size = New System.Drawing.Size(273, 36)
        Me.VisualBasicLabel.TabIndex = 0
        Me.VisualBasicLabel.Text = "Visual Basic Guide"
        '
        'LTELabel
        '
        Me.LTELabel.AutoSize = True
        Me.LTELabel.BackColor = System.Drawing.Color.Transparent
        Me.LTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTELabel.Location = New System.Drawing.Point(437, 59)
        Me.LTELabel.Name = "LTELabel"
        Me.LTELabel.Size = New System.Drawing.Size(155, 18)
        Me.LTELabel.TabIndex = 1
        Me.LTELabel.Text = "Learning things easier." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.VBGuide.My.Resources.Resources.kisspng_microsoft_visual_basic_2005_visual_basic_net_micr_vba_5b3382046c27d6_514067801530102276443
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(31, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 104)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(71, 119)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(91, 48)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'HelpButton1
        '
        Me.HelpButton1.Location = New System.Drawing.Point(416, 417)
        Me.HelpButton1.Name = "HelpButton1"
        Me.HelpButton1.Size = New System.Drawing.Size(90, 42)
        Me.HelpButton1.TabIndex = 4
        Me.HelpButton1.Text = "What is Visual Basic?"
        Me.HelpButton1.UseVisualStyleBackColor = True
        '
        'AppVersionLabel
        '
        Me.AppVersionLabel.AutoSize = True
        Me.AppVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.AppVersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppVersionLabel.ForeColor = System.Drawing.Color.White
        Me.AppVersionLabel.Location = New System.Drawing.Point(12, 442)
        Me.AppVersionLabel.Name = "AppVersionLabel"
        Me.AppVersionLabel.Size = New System.Drawing.Size(96, 20)
        Me.AppVersionLabel.TabIndex = 5
        Me.AppVersionLabel.Text = "App Version"
        '
        'HelpButton2
        '
        Me.HelpButton2.Location = New System.Drawing.Point(512, 417)
        Me.HelpButton2.Name = "HelpButton2"
        Me.HelpButton2.Size = New System.Drawing.Size(90, 42)
        Me.HelpButton2.TabIndex = 6
        Me.HelpButton2.Text = " What's the use of this app?"
        Me.HelpButton2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.VBGuide.My.Resources.Resources.DearestSerpentineEnglishsetter_size_restricted
        Me.PictureBox2.Location = New System.Drawing.Point(458, 315)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'OpeningForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VBGuide.My.Resources.Resources.coding
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(614, 471)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.HelpButton2)
        Me.Controls.Add(Me.AppVersionLabel)
        Me.Controls.Add(Me.HelpButton1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LTELabel)
        Me.Controls.Add(Me.VisualBasicLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpeningForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisualBasicLabel As System.Windows.Forms.Label
    Friend WithEvents LTELabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents HelpButton1 As System.Windows.Forms.Button
    Friend WithEvents AppVersionLabel As System.Windows.Forms.Label
    Friend WithEvents HelpButton2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
