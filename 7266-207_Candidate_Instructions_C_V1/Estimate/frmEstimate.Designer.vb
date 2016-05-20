<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstimate
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstMsg = New System.Windows.Forms.Label()
        Me.lstMaterials = New System.Windows.Forms.ListBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmdNewEstimate = New System.Windows.Forms.Button()
        Me.cmdCostExcludingVAT = New System.Windows.Forms.Button()
        Me.cmdCostIncludingVAT = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblLengthUnit = New System.Windows.Forms.Label()
        Me.lblHeightUnit = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblTitle.Location = New System.Drawing.Point(68, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(348, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ROBERT’S BUILDERS"
        '
        'lblFirstMsg
        '
        Me.lblFirstMsg.AutoSize = True
        Me.lblFirstMsg.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstMsg.ForeColor = System.Drawing.Color.Red
        Me.lblFirstMsg.Location = New System.Drawing.Point(70, 132)
        Me.lblFirstMsg.Name = "lblFirstMsg"
        Me.lblFirstMsg.Size = New System.Drawing.Size(194, 23)
        Me.lblFirstMsg.TabIndex = 1
        Me.lblFirstMsg.Text = "First select a material!"
        '
        'lstMaterials
        '
        Me.lstMaterials.FormattingEnabled = True
        Me.lstMaterials.Items.AddRange(New Object() {"Bricks", "100mm Blocks", "200mm blocks", "Concrete", "Kerbing"})
        Me.lstMaterials.Location = New System.Drawing.Point(81, 171)
        Me.lstMaterials.Name = "lstMaterials"
        Me.lstMaterials.Size = New System.Drawing.Size(160, 108)
        Me.lstMaterials.TabIndex = 2
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(333, 386)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(71, 18)
        Me.lblSubTotal.TabIndex = 3
        Me.lblSubTotal.Text = "Sub Total"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(369, 424)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(35, 18)
        Me.lblVAT.TabIndex = 4
        Me.lblVAT.Text = "VAT"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(363, 461)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(41, 18)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(410, 386)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(134, 24)
        Me.txtSubTotal.TabIndex = 6
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.SystemColors.Control
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(410, 421)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(134, 24)
        Me.txtVAT.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(410, 458)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(134, 26)
        Me.txtTotal.TabIndex = 8
        '
        'cmdNewEstimate
        '
        Me.cmdNewEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewEstimate.Location = New System.Drawing.Point(229, 529)
        Me.cmdNewEstimate.Name = "cmdNewEstimate"
        Me.cmdNewEstimate.Size = New System.Drawing.Size(114, 44)
        Me.cmdNewEstimate.TabIndex = 9
        Me.cmdNewEstimate.Text = "NEW ESTIMATE"
        Me.cmdNewEstimate.UseVisualStyleBackColor = True
        '
        'cmdCostExcludingVAT
        '
        Me.cmdCostExcludingVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCostExcludingVAT.Location = New System.Drawing.Point(378, 529)
        Me.cmdCostExcludingVAT.Name = "cmdCostExcludingVAT"
        Me.cmdCostExcludingVAT.Size = New System.Drawing.Size(114, 44)
        Me.cmdCostExcludingVAT.TabIndex = 10
        Me.cmdCostExcludingVAT.Text = "COST Excluding VAT"
        Me.cmdCostExcludingVAT.UseVisualStyleBackColor = True
        '
        'cmdCostIncludingVAT
        '
        Me.cmdCostIncludingVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCostIncludingVAT.Location = New System.Drawing.Point(527, 529)
        Me.cmdCostIncludingVAT.Name = "cmdCostIncludingVAT"
        Me.cmdCostIncludingVAT.Size = New System.Drawing.Size(104, 44)
        Me.cmdCostIncludingVAT.TabIndex = 11
        Me.cmdCostIncludingVAT.Text = "COST Including VAT"
        Me.cmdCostIncludingVAT.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(666, 529)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 44)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Navy
        Me.lblHint.Location = New System.Drawing.Point(353, 132)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(240, 23)
        Me.lblHint.TabIndex = 13
        Me.lblHint.Text = "Enter the dimensions below"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Estimate.My.Resources.Resources.worker
        Me.PictureBox1.Location = New System.Drawing.Point(676, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 236)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(372, 190)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 15
        Me.lblLength.Text = "Length:"
        Me.lblLength.Visible = False
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(423, 187)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 16
        Me.txtLength.Visible = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(375, 220)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 17
        Me.lblHeight.Text = "Height:"
        Me.lblHeight.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(423, 220)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 18
        Me.txtHeight.Visible = False
        '
        'lblLengthUnit
        '
        Me.lblLengthUnit.AutoSize = True
        Me.lblLengthUnit.Location = New System.Drawing.Point(530, 190)
        Me.lblLengthUnit.Name = "lblLengthUnit"
        Me.lblLengthUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblLengthUnit.TabIndex = 19
        Me.lblLengthUnit.Text = "mtrs"
        Me.lblLengthUnit.Visible = False
        '
        'lblHeightUnit
        '
        Me.lblHeightUnit.AutoSize = True
        Me.lblHeightUnit.Location = New System.Drawing.Point(530, 223)
        Me.lblHeightUnit.Name = "lblHeightUnit"
        Me.lblHeightUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblHeightUnit.TabIndex = 20
        Me.lblHeightUnit.Text = "mtrs"
        Me.lblHeightUnit.Visible = False
        '
        'frmEstimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 593)
        Me.Controls.Add(Me.lblHeightUnit)
        Me.Controls.Add(Me.lblLengthUnit)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCostIncludingVAT)
        Me.Controls.Add(Me.cmdCostExcludingVAT)
        Me.Controls.Add(Me.cmdNewEstimate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblVAT)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lstMaterials)
        Me.Controls.Add(Me.lblFirstMsg)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmEstimate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFirstMsg As System.Windows.Forms.Label
    Friend WithEvents lstMaterials As System.Windows.Forms.ListBox
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdNewEstimate As System.Windows.Forms.Button
    Friend WithEvents cmdCostExcludingVAT As System.Windows.Forms.Button
    Friend WithEvents cmdCostIncludingVAT As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblLengthUnit As System.Windows.Forms.Label
    Friend WithEvents lblHeightUnit As System.Windows.Forms.Label

End Class
