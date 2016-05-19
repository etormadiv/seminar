'Mohamed sedig
'Task B
Public Class frmTaskB
    'This member handles the forecolor button click event
    Private Sub cmdForeColour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdForeColour.Click
        'Create a color dialog instance
        Dim cd As New ColorDialog
        'Check if the user selected a color and clicked OK
        If cd.ShowDialog = DialogResult.OK Then
            'Check if Text Box 1 forecolor must be altered
            If chkTextbox1.Checked Then
                txtText1.ForeColor = cd.Color
            End If
            'Check if Text Box 2 forecolor must be altered
            If chkTextbox2.Checked Then
                txtText2.ForeColor = cd.Color
            End If
        End If
    End Sub
    'Handles the exit button click event
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Close this form
        Close()
    End Sub
    'This member handles the backcolor button click event
    Private Sub cmdBackColour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackColour.Click
        'Create a color dialog instance
        Dim cd As New ColorDialog
        'Check if the user selected a color and clicked OK
        If cd.ShowDialog = DialogResult.OK Then
            'Check if Text Box 1 backcolor must be altered
            If chkTextbox1.Checked Then
                txtText1.BackColor = cd.Color
            End If
            'Check if Text Box 2 backcolor must be altered
            If chkTextbox2.Checked Then
                txtText2.BackColor = cd.Color
            End If
        End If
    End Sub
    'This member handles the font button click event
    Private Sub cmdFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFont.Click
        'Create a font dialog instance
        Dim fd As New FontDialog
        'Check if the user selected a font and clicked OK
        If fd.ShowDialog = DialogResult.OK Then
            'Check if Text Box 1 font must be altered
            If chkTextbox1.Checked Then
                txtText1.Font = fd.Font
            End If
            'Check if Text Box 2 font must be altered
            If chkTextbox2.Checked Then
                txtText2.Font = fd.Font
            End If
        End If
    End Sub
End Class