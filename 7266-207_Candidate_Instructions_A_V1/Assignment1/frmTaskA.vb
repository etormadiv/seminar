'Task A
Public Class frmTaskA
    'Handles the exit button click event
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Close this form
        Close()
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
    'This member handles all radio buttons checked changed event
    Private Sub AllRadioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radForeYellow.CheckedChanged, radForeRed.CheckedChanged, radForeGreen.CheckedChanged, radForeBlue.CheckedChanged, radBackYellow.CheckedChanged, radBackRed.CheckedChanged, radBackGreen.CheckedChanged, radBackBlue.CheckedChanged
        'Declare forecolor & backcolor references
        Dim forecolor As Color
        Dim backcolor As Color
        'Test for a checked radio (int forecolor group box) button and assign the appropriate color
        If radForeBlue.Checked Then
            forecolor = Color.Blue
        ElseIf radForeGreen.Checked Then
            forecolor = Color.Green
        ElseIf radForeRed.Checked Then
            forecolor = Color.Red
        Else
            forecolor = Color.Yellow
        End If
        'Test for a checked radio (int backcolor group box) button and assign the appropriate color
        If radBackBlue.Checked Then
            backcolor = Color.Blue
        ElseIf radBackGreen.Checked Then
            backcolor = Color.Green
        ElseIf radBackRed.Checked Then
            backcolor = Color.Red
        Else
            backcolor = Color.Yellow
        End If
        'Check whether we should alter the forecolor/backcolor for Text Box 1
        If chkTextbox1.Checked Then
            txtText1.BackColor = backcolor
            txtText1.ForeColor = forecolor
        End If
        'Check whether we should alter the forecolor/backcolor for Text Box 2
        If chkTextbox2.Checked Then
            txtText2.BackColor = backcolor
            txtText2.ForeColor = forecolor
        End If
    End Sub
End Class