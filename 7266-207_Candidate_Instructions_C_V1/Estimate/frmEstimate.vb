Public Class frmEstimate

    Private Sub lstMaterials_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMaterials.SelectedIndexChanged

        lblLength.Visible = False
        lblHeight.Visible = False

        txtLength.Visible = False
        txtHeight.Visible = False

        lblLengthUnit.Visible = False
        lblHeightUnit.Visible = False

        Select Case lstMaterials.SelectedIndex
            Case 0 To 2
                lblLength.Visible = True
                lblHeight.Visible = True

                txtLength.Visible = True
                txtHeight.Visible = True

                lblLengthUnit.Visible = True
                lblHeightUnit.Visible = True
            Case 4
                lblLength.Visible = True

                txtLength.Visible = True

                lblLengthUnit.Visible = True

            Case Else

        End Select

    End Sub
End Class
