<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskA
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.txtText1 = New System.Windows.Forms.TextBox()
        Me.txtText2 = New System.Windows.Forms.TextBox()
        Me.grbForeColour = New System.Windows.Forms.GroupBox()
        Me.radForeGreen = New System.Windows.Forms.RadioButton()
        Me.radForeBlue = New System.Windows.Forms.RadioButton()
        Me.radForeYellow = New System.Windows.Forms.RadioButton()
        Me.radForeRed = New System.Windows.Forms.RadioButton()
        Me.grbBackColour = New System.Windows.Forms.GroupBox()
        Me.radBackGreen = New System.Windows.Forms.RadioButton()
        Me.radBackBlue = New System.Windows.Forms.RadioButton()
        Me.radBackYellow = New System.Windows.Forms.RadioButton()
        Me.radBackRed = New System.Windows.Forms.RadioButton()
        Me.cmdFont = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.chkTextbox1 = New System.Windows.Forms.CheckBox()
        Me.chkTextbox2 = New System.Windows.Forms.CheckBox()
        Me.grbForeColour.SuspendLayout()
        Me.grbBackColour.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(102, 20)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(58, 13)
        Me.lblText1.TabIndex = 0
        Me.lblText1.Text = "Text Box 1"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(366, 20)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(58, 13)
        Me.lblText2.TabIndex = 1
        Me.lblText2.Text = "Text Box 2"
        '
        'txtText1
        '
        Me.txtText1.Location = New System.Drawing.Point(3, 46)
        Me.txtText1.Multiline = True
        Me.txtText1.Name = "txtText1"
        Me.txtText1.Size = New System.Drawing.Size(259, 164)
        Me.txtText1.TabIndex = 2
        Me.txtText1.Text = "This is the first text box"
        '
        'txtText2
        '
        Me.txtText2.Location = New System.Drawing.Point(268, 46)
        Me.txtText2.Multiline = True
        Me.txtText2.Name = "txtText2"
        Me.txtText2.Size = New System.Drawing.Size(257, 163)
        Me.txtText2.TabIndex = 3
        Me.txtText2.Text = "This is the second text box"
        '
        'grbForeColour
        '
        Me.grbForeColour.Controls.Add(Me.radForeGreen)
        Me.grbForeColour.Controls.Add(Me.radForeBlue)
        Me.grbForeColour.Controls.Add(Me.radForeYellow)
        Me.grbForeColour.Controls.Add(Me.radForeRed)
        Me.grbForeColour.Location = New System.Drawing.Point(47, 238)
        Me.grbForeColour.Name = "grbForeColour"
        Me.grbForeColour.Size = New System.Drawing.Size(113, 134)
        Me.grbForeColour.TabIndex = 4
        Me.grbForeColour.TabStop = False
        Me.grbForeColour.Text = "ForeColor"
        '
        'radForeGreen
        '
        Me.radForeGreen.AutoSize = True
        Me.radForeGreen.Location = New System.Drawing.Point(16, 92)
        Me.radForeGreen.Name = "radForeGreen"
        Me.radForeGreen.Size = New System.Drawing.Size(54, 17)
        Me.radForeGreen.TabIndex = 3
        Me.radForeGreen.TabStop = True
        Me.radForeGreen.Text = "Green"
        Me.radForeGreen.UseVisualStyleBackColor = True
        '
        'radForeBlue
        '
        Me.radForeBlue.AutoSize = True
        Me.radForeBlue.Location = New System.Drawing.Point(16, 68)
        Me.radForeBlue.Name = "radForeBlue"
        Me.radForeBlue.Size = New System.Drawing.Size(46, 17)
        Me.radForeBlue.TabIndex = 2
        Me.radForeBlue.TabStop = True
        Me.radForeBlue.Text = "Blue"
        Me.radForeBlue.UseVisualStyleBackColor = True
        '
        'radForeYellow
        '
        Me.radForeYellow.AutoSize = True
        Me.radForeYellow.Location = New System.Drawing.Point(16, 44)
        Me.radForeYellow.Name = "radForeYellow"
        Me.radForeYellow.Size = New System.Drawing.Size(56, 17)
        Me.radForeYellow.TabIndex = 1
        Me.radForeYellow.TabStop = True
        Me.radForeYellow.Text = "Yellow"
        Me.radForeYellow.UseVisualStyleBackColor = True
        '
        'radForeRed
        '
        Me.radForeRed.AutoSize = True
        Me.radForeRed.Location = New System.Drawing.Point(16, 20)
        Me.radForeRed.Name = "radForeRed"
        Me.radForeRed.Size = New System.Drawing.Size(45, 17)
        Me.radForeRed.TabIndex = 0
        Me.radForeRed.TabStop = True
        Me.radForeRed.Text = "Red"
        Me.radForeRed.UseVisualStyleBackColor = True
        '
        'grbBackColour
        '
        Me.grbBackColour.Controls.Add(Me.radBackGreen)
        Me.grbBackColour.Controls.Add(Me.radBackBlue)
        Me.grbBackColour.Controls.Add(Me.radBackYellow)
        Me.grbBackColour.Controls.Add(Me.radBackRed)
        Me.grbBackColour.Location = New System.Drawing.Point(176, 238)
        Me.grbBackColour.Name = "grbBackColour"
        Me.grbBackColour.Size = New System.Drawing.Size(111, 134)
        Me.grbBackColour.TabIndex = 5
        Me.grbBackColour.TabStop = False
        Me.grbBackColour.Text = "BackColor"
        '
        'radBackGreen
        '
        Me.radBackGreen.AutoSize = True
        Me.radBackGreen.Location = New System.Drawing.Point(6, 91)
        Me.radBackGreen.Name = "radBackGreen"
        Me.radBackGreen.Size = New System.Drawing.Size(54, 17)
        Me.radBackGreen.TabIndex = 7
        Me.radBackGreen.TabStop = True
        Me.radBackGreen.Text = "Green"
        Me.radBackGreen.UseVisualStyleBackColor = True
        '
        'radBackBlue
        '
        Me.radBackBlue.AutoSize = True
        Me.radBackBlue.Location = New System.Drawing.Point(6, 67)
        Me.radBackBlue.Name = "radBackBlue"
        Me.radBackBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBackBlue.TabIndex = 6
        Me.radBackBlue.TabStop = True
        Me.radBackBlue.Text = "Blue"
        Me.radBackBlue.UseVisualStyleBackColor = True
        '
        'radBackYellow
        '
        Me.radBackYellow.AutoSize = True
        Me.radBackYellow.Location = New System.Drawing.Point(6, 43)
        Me.radBackYellow.Name = "radBackYellow"
        Me.radBackYellow.Size = New System.Drawing.Size(56, 17)
        Me.radBackYellow.TabIndex = 5
        Me.radBackYellow.TabStop = True
        Me.radBackYellow.Text = "Yellow"
        Me.radBackYellow.UseVisualStyleBackColor = True
        '
        'radBackRed
        '
        Me.radBackRed.AutoSize = True
        Me.radBackRed.Location = New System.Drawing.Point(6, 19)
        Me.radBackRed.Name = "radBackRed"
        Me.radBackRed.Size = New System.Drawing.Size(45, 17)
        Me.radBackRed.TabIndex = 4
        Me.radBackRed.TabStop = True
        Me.radBackRed.Text = "Red"
        Me.radBackRed.UseVisualStyleBackColor = True
        '
        'cmdFont
        '
        Me.cmdFont.Location = New System.Drawing.Point(385, 247)
        Me.cmdFont.Name = "cmdFont"
        Me.cmdFont.Size = New System.Drawing.Size(85, 39)
        Me.cmdFont.TabIndex = 6
        Me.cmdFont.Text = "Font"
        Me.cmdFont.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(385, 293)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 40)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'chkTextbox1
        '
        Me.chkTextbox1.AutoSize = True
        Me.chkTextbox1.Location = New System.Drawing.Point(53, 407)
        Me.chkTextbox1.Name = "chkTextbox1"
        Me.chkTextbox1.Size = New System.Drawing.Size(74, 17)
        Me.chkTextbox1.TabIndex = 8
        Me.chkTextbox1.Text = "Text Box1"
        Me.chkTextbox1.UseVisualStyleBackColor = True
        '
        'chkTextbox2
        '
        Me.chkTextbox2.AutoSize = True
        Me.chkTextbox2.Location = New System.Drawing.Point(178, 407)
        Me.chkTextbox2.Name = "chkTextbox2"
        Me.chkTextbox2.Size = New System.Drawing.Size(74, 17)
        Me.chkTextbox2.TabIndex = 9
        Me.chkTextbox2.Text = "Text Box2"
        Me.chkTextbox2.UseVisualStyleBackColor = True
        '
        'frmTaskA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 444)
        Me.Controls.Add(Me.chkTextbox2)
        Me.Controls.Add(Me.chkTextbox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFont)
        Me.Controls.Add(Me.grbBackColour)
        Me.Controls.Add(Me.grbForeColour)
        Me.Controls.Add(Me.txtText2)
        Me.Controls.Add(Me.txtText1)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Name = "frmTaskA"
        Me.Text = "Task A"
        Me.grbForeColour.ResumeLayout(False)
        Me.grbForeColour.PerformLayout()
        Me.grbBackColour.ResumeLayout(False)
        Me.grbBackColour.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents lblText2 As System.Windows.Forms.Label
    Friend WithEvents txtText1 As System.Windows.Forms.TextBox
    Friend WithEvents txtText2 As System.Windows.Forms.TextBox
    Friend WithEvents grbForeColour As System.Windows.Forms.GroupBox
    Friend WithEvents grbBackColour As System.Windows.Forms.GroupBox
    Friend WithEvents radForeGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radForeBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radForeYellow As System.Windows.Forms.RadioButton
    Friend WithEvents radForeRed As System.Windows.Forms.RadioButton
    Friend WithEvents radBackGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radBackBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radBackYellow As System.Windows.Forms.RadioButton
    Friend WithEvents radBackRed As System.Windows.Forms.RadioButton
    Friend WithEvents cmdFont As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents chkTextbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTextbox2 As System.Windows.Forms.CheckBox
End Class
