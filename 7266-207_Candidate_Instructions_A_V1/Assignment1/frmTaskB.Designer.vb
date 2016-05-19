<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskB
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
        Me.txtText2 = New System.Windows.Forms.TextBox()
        Me.txtText1 = New System.Windows.Forms.TextBox()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.chkTextbox2 = New System.Windows.Forms.CheckBox()
        Me.chkTextbox1 = New System.Windows.Forms.CheckBox()
        Me.cmdForeColour = New System.Windows.Forms.Button()
        Me.cmdBackColour = New System.Windows.Forms.Button()
        Me.cmdFont = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtText2
        '
        Me.txtText2.Location = New System.Drawing.Point(277, 42)
        Me.txtText2.Multiline = True
        Me.txtText2.Name = "txtText2"
        Me.txtText2.Size = New System.Drawing.Size(257, 163)
        Me.txtText2.TabIndex = 7
        Me.txtText2.Text = "This is the second text box"
        Me.txtText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtText1
        '
        Me.txtText1.Location = New System.Drawing.Point(12, 42)
        Me.txtText1.Multiline = True
        Me.txtText1.Name = "txtText1"
        Me.txtText1.Size = New System.Drawing.Size(259, 164)
        Me.txtText1.TabIndex = 6
        Me.txtText1.Text = "This is the first text box"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(375, 16)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(58, 13)
        Me.lblText2.TabIndex = 5
        Me.lblText2.Text = "Text Box 2"
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(111, 16)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(58, 13)
        Me.lblText1.TabIndex = 4
        Me.lblText1.Text = "Text Box 1"
        '
        'chkTextbox2
        '
        Me.chkTextbox2.AutoSize = True
        Me.chkTextbox2.Location = New System.Drawing.Point(174, 369)
        Me.chkTextbox2.Name = "chkTextbox2"
        Me.chkTextbox2.Size = New System.Drawing.Size(74, 17)
        Me.chkTextbox2.TabIndex = 11
        Me.chkTextbox2.Text = "Text Box2"
        Me.chkTextbox2.UseVisualStyleBackColor = True
        '
        'chkTextbox1
        '
        Me.chkTextbox1.AutoSize = True
        Me.chkTextbox1.Location = New System.Drawing.Point(49, 369)
        Me.chkTextbox1.Name = "chkTextbox1"
        Me.chkTextbox1.Size = New System.Drawing.Size(74, 17)
        Me.chkTextbox1.TabIndex = 10
        Me.chkTextbox1.Text = "Text Box1"
        Me.chkTextbox1.UseVisualStyleBackColor = True
        '
        'cmdForeColour
        '
        Me.cmdForeColour.Location = New System.Drawing.Point(419, 223)
        Me.cmdForeColour.Name = "cmdForeColour"
        Me.cmdForeColour.Size = New System.Drawing.Size(88, 30)
        Me.cmdForeColour.TabIndex = 12
        Me.cmdForeColour.Text = "Forecolor"
        Me.cmdForeColour.UseVisualStyleBackColor = True
        '
        'cmdBackColour
        '
        Me.cmdBackColour.Location = New System.Drawing.Point(419, 267)
        Me.cmdBackColour.Name = "cmdBackColour"
        Me.cmdBackColour.Size = New System.Drawing.Size(88, 30)
        Me.cmdBackColour.TabIndex = 13
        Me.cmdBackColour.Text = "Backcolor"
        Me.cmdBackColour.UseVisualStyleBackColor = True
        '
        'cmdFont
        '
        Me.cmdFont.Location = New System.Drawing.Point(419, 309)
        Me.cmdFont.Name = "cmdFont"
        Me.cmdFont.Size = New System.Drawing.Size(88, 30)
        Me.cmdFont.TabIndex = 14
        Me.cmdFont.Text = "Font"
        Me.cmdFont.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(419, 353)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(88, 30)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmTaskB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 398)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFont)
        Me.Controls.Add(Me.cmdBackColour)
        Me.Controls.Add(Me.cmdForeColour)
        Me.Controls.Add(Me.chkTextbox2)
        Me.Controls.Add(Me.chkTextbox1)
        Me.Controls.Add(Me.txtText2)
        Me.Controls.Add(Me.txtText1)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Name = "frmTaskB"
        Me.Text = "Task B Mohamed sedig 2016-05-19"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtText2 As System.Windows.Forms.TextBox
    Friend WithEvents txtText1 As System.Windows.Forms.TextBox
    Friend WithEvents lblText2 As System.Windows.Forms.Label
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents chkTextbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTextbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdForeColour As System.Windows.Forms.Button
    Friend WithEvents cmdBackColour As System.Windows.Forms.Button
    Friend WithEvents cmdFont As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
