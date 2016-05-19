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
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.grpEditMode = New System.Windows.Forms.GroupBox()
        Me.radAppend = New System.Windows.Forms.RadioButton()
        Me.radOverwrite = New System.Windows.Forms.RadioButton()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDisplay = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpEditMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Location = New System.Drawing.Point(40, 33)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(75, 13)
        Me.lblProdName.TabIndex = 0
        Me.lblProdName.Text = "Product Name"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(40, 61)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(40, 89)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(139, 30)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(132, 20)
        Me.txtProdName.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(139, 58)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(132, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(139, 86)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 20)
        Me.txtPrice.TabIndex = 5
        '
        'grpEditMode
        '
        Me.grpEditMode.Controls.Add(Me.radOverwrite)
        Me.grpEditMode.Controls.Add(Me.radAppend)
        Me.grpEditMode.Location = New System.Drawing.Point(373, 31)
        Me.grpEditMode.Name = "grpEditMode"
        Me.grpEditMode.Size = New System.Drawing.Size(177, 75)
        Me.grpEditMode.TabIndex = 6
        Me.grpEditMode.TabStop = False
        Me.grpEditMode.Text = "Edit Mode"
        '
        'radAppend
        '
        Me.radAppend.AutoSize = True
        Me.radAppend.Checked = True
        Me.radAppend.Location = New System.Drawing.Point(12, 19)
        Me.radAppend.Name = "radAppend"
        Me.radAppend.Size = New System.Drawing.Size(81, 17)
        Me.radAppend.TabIndex = 0
        Me.radAppend.TabStop = True
        Me.radAppend.Text = "Append File"
        Me.radAppend.UseVisualStyleBackColor = True
        '
        'radOverwrite
        '
        Me.radOverwrite.AutoSize = True
        Me.radOverwrite.Location = New System.Drawing.Point(12, 44)
        Me.radOverwrite.Name = "radOverwrite"
        Me.radOverwrite.Size = New System.Drawing.Size(89, 17)
        Me.radOverwrite.TabIndex = 1
        Me.radOverwrite.Text = "Overwrite File"
        Me.radOverwrite.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(373, 117)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(112, 23)
        Me.cmdUpdate.TabIndex = 7
        Me.cmdUpdate.Text = "Update File"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDisplay
        '
        Me.cmdDisplay.Enabled = False
        Me.cmdDisplay.Location = New System.Drawing.Point(26, 325)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(112, 23)
        Me.cmdDisplay.TabIndex = 8
        Me.cmdDisplay.Text = "Display Records"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(457, 325)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(112, 23)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 154)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(583, 160)
        Me.lstDisplay.TabIndex = 10
        '
        'frmTaskA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 357)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdDisplay)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.grpEditMode)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblProdName)
        Me.Name = "frmTaskA"
        Me.Text = "Task A"
        Me.grpEditMode.ResumeLayout(False)
        Me.grpEditMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProdName As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtProdName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents grpEditMode As System.Windows.Forms.GroupBox
    Friend WithEvents radOverwrite As System.Windows.Forms.RadioButton
    Friend WithEvents radAppend As System.Windows.Forms.RadioButton
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDisplay As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
End Class
