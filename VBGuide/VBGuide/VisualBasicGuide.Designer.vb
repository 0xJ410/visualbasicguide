<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualBasicGuide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualBasicGuide))
        Me.VisualBasicText = New System.Windows.Forms.Label()
        Me.LightModeButton = New System.Windows.Forms.Button()
        Me.DarkModeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VisualBasicLogo = New System.Windows.Forms.PictureBox()
        Me.ExampleLabel = New System.Windows.Forms.Label()
        Me.ExampleBox = New System.Windows.Forms.TextBox()
        Me.LOGLabel = New System.Windows.Forms.Label()
        Me.SourceCodeLabel = New System.Windows.Forms.Label()
        Me.DefinitionLabel = New System.Windows.Forms.Label()
        Me.CodeBox = New System.Windows.Forms.TextBox()
        Me.DefinitionBox = New System.Windows.Forms.TextBox()
        Me.LOG = New System.Windows.Forms.ComboBox()
        CType(Me.VisualBasicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualBasicText
        '
        Me.VisualBasicText.AutoSize = True
        Me.VisualBasicText.BackColor = System.Drawing.Color.Transparent
        Me.VisualBasicText.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualBasicText.Location = New System.Drawing.Point(56, 96)
        Me.VisualBasicText.Name = "VisualBasicText"
        Me.VisualBasicText.Size = New System.Drawing.Size(104, 18)
        Me.VisualBasicText.TabIndex = 25
        Me.VisualBasicText.Text = "Visual Basic"
        '
        'LightModeButton
        '
        Me.LightModeButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightModeButton.Location = New System.Drawing.Point(518, 12)
        Me.LightModeButton.Name = "LightModeButton"
        Me.LightModeButton.Size = New System.Drawing.Size(80, 23)
        Me.LightModeButton.TabIndex = 24
        Me.LightModeButton.Text = "Light Mode"
        Me.LightModeButton.UseVisualStyleBackColor = True
        Me.LightModeButton.Visible = False
        '
        'DarkModeButton
        '
        Me.DarkModeButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DarkModeButton.Location = New System.Drawing.Point(518, 12)
        Me.DarkModeButton.Name = "DarkModeButton"
        Me.DarkModeButton.Size = New System.Drawing.Size(80, 23)
        Me.DarkModeButton.TabIndex = 23
        Me.DarkModeButton.Text = "Dark Mode"
        Me.DarkModeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VisualBasicLogo
        '
        Me.VisualBasicLogo.BackColor = System.Drawing.Color.Transparent
        Me.VisualBasicLogo.BackgroundImage = Global.VBGuide.My.Resources.Resources._279_2797509_unlimited_pngprdazit2017_05_27t09_microsoft_visual_basic_logo
        Me.VisualBasicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VisualBasicLogo.InitialImage = Nothing
        Me.VisualBasicLogo.Location = New System.Drawing.Point(48, 12)
        Me.VisualBasicLogo.Name = "VisualBasicLogo"
        Me.VisualBasicLogo.Size = New System.Drawing.Size(121, 81)
        Me.VisualBasicLogo.TabIndex = 21
        Me.VisualBasicLogo.TabStop = False
        '
        'ExampleLabel
        '
        Me.ExampleLabel.AutoSize = True
        Me.ExampleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ExampleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExampleLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExampleLabel.Location = New System.Drawing.Point(18, 178)
        Me.ExampleLabel.Name = "ExampleLabel"
        Me.ExampleLabel.Size = New System.Drawing.Size(83, 21)
        Me.ExampleLabel.TabIndex = 20
        Me.ExampleLabel.Text = "Example:"
        '
        'ExampleBox
        '
        Me.ExampleBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExampleBox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExampleBox.Location = New System.Drawing.Point(18, 203)
        Me.ExampleBox.Multiline = True
        Me.ExampleBox.Name = "ExampleBox"
        Me.ExampleBox.ReadOnly = True
        Me.ExampleBox.Size = New System.Drawing.Size(205, 255)
        Me.ExampleBox.TabIndex = 19
        '
        'LOGLabel
        '
        Me.LOGLabel.AutoSize = True
        Me.LOGLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGLabel.Location = New System.Drawing.Point(10, 119)
        Me.LOGLabel.Name = "LOGLabel"
        Me.LOGLabel.Size = New System.Drawing.Size(198, 19)
        Me.LOGLabel.TabIndex = 18
        Me.LOGLabel.Text = "Choose the following:"
        '
        'SourceCodeLabel
        '
        Me.SourceCodeLabel.AutoSize = True
        Me.SourceCodeLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SourceCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SourceCodeLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceCodeLabel.Location = New System.Drawing.Point(247, 178)
        Me.SourceCodeLabel.Name = "SourceCodeLabel"
        Me.SourceCodeLabel.Size = New System.Drawing.Size(119, 21)
        Me.SourceCodeLabel.TabIndex = 17
        Me.SourceCodeLabel.Text = "Source Code:"
        '
        'DefinitionLabel
        '
        Me.DefinitionLabel.AutoSize = True
        Me.DefinitionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DefinitionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefinitionLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefinitionLabel.Location = New System.Drawing.Point(247, 17)
        Me.DefinitionLabel.Name = "DefinitionLabel"
        Me.DefinitionLabel.Size = New System.Drawing.Size(110, 21)
        Me.DefinitionLabel.TabIndex = 16
        Me.DefinitionLabel.Text = "Definition:"
        '
        'CodeBox
        '
        Me.CodeBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CodeBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeBox.Location = New System.Drawing.Point(247, 202)
        Me.CodeBox.Multiline = True
        Me.CodeBox.Name = "CodeBox"
        Me.CodeBox.ReadOnly = True
        Me.CodeBox.Size = New System.Drawing.Size(351, 255)
        Me.CodeBox.TabIndex = 15
        '
        'DefinitionBox
        '
        Me.DefinitionBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DefinitionBox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefinitionBox.Location = New System.Drawing.Point(247, 42)
        Me.DefinitionBox.Multiline = True
        Me.DefinitionBox.Name = "DefinitionBox"
        Me.DefinitionBox.ReadOnly = True
        Me.DefinitionBox.Size = New System.Drawing.Size(351, 116)
        Me.DefinitionBox.TabIndex = 14
        '
        'LOG
        '
        Me.LOG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LOG.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOG.FormattingEnabled = True
        Me.LOG.Location = New System.Drawing.Point(14, 141)
        Me.LOG.Name = "LOG"
        Me.LOG.Size = New System.Drawing.Size(190, 23)
        Me.LOG.TabIndex = 13
        '
        'VisualBasicGuide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(614, 471)
        Me.Controls.Add(Me.VisualBasicText)
        Me.Controls.Add(Me.LightModeButton)
        Me.Controls.Add(Me.DarkModeButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VisualBasicLogo)
        Me.Controls.Add(Me.ExampleLabel)
        Me.Controls.Add(Me.ExampleBox)
        Me.Controls.Add(Me.LOGLabel)
        Me.Controls.Add(Me.SourceCodeLabel)
        Me.Controls.Add(Me.DefinitionLabel)
        Me.Controls.Add(Me.CodeBox)
        Me.Controls.Add(Me.DefinitionBox)
        Me.Controls.Add(Me.LOG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VisualBasicGuide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Guide"
        CType(Me.VisualBasicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisualBasicText As System.Windows.Forms.Label
    Friend WithEvents LightModeButton As System.Windows.Forms.Button
    Friend WithEvents DarkModeButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VisualBasicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ExampleLabel As System.Windows.Forms.Label
    Friend WithEvents ExampleBox As System.Windows.Forms.TextBox
    Friend WithEvents LOGLabel As System.Windows.Forms.Label
    Friend WithEvents SourceCodeLabel As System.Windows.Forms.Label
    Friend WithEvents DefinitionLabel As System.Windows.Forms.Label
    Friend WithEvents CodeBox As System.Windows.Forms.TextBox
    Friend WithEvents DefinitionBox As System.Windows.Forms.TextBox
    Friend WithEvents LOG As System.Windows.Forms.ComboBox
End Class
