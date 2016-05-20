Public Class frmEstimate
    Const VAT As Decimal = 17.5

    Private Sub lstMaterials_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMaterials.SelectedIndexChanged

        lblFirstMsg.Visible = False
        lblHint.Visible = True

        lblLength.Visible = False
        txtLength.Visible = False
        lblLengthUnit.Visible = False

        lblHeight.Visible = False
        txtHeight.Visible = False
        lblHeightUnit.Visible = False

        lblDepth.Visible = False
        txtDepth.Visible = False
        lblDepthUnit.Visible = False

        lblWidth.Visible = False
        txtWidth.Visible = False
        lblWidthUnit.Visible = False

        lblArea.Visible = False
        txtArea.Visible = False
        lblAreaUnit.Visible = False

        Select Case lstMaterials.SelectedIndex
            Case 0
                lblLength.Visible = True
                txtLength.Visible = True
                lblLengthUnit.Visible = True

                lblHeight.Visible = True
                txtHeight.Visible = True
                lblHeightUnit.Visible = True
            Case 1, 2
                lblLength.Visible = True
                txtLength.Visible = True
                lblLengthUnit.Visible = True

                lblHeight.Visible = True
                txtHeight.Visible = True
                lblHeightUnit.Visible = True

                lblArea.Visible = True
                txtArea.Visible = True
                lblAreaUnit.Visible = True

                lblAreaUnit.Text = "sq mtrs"
            Case 3
                lblLength.Visible = True
                txtLength.Visible = True
                lblLengthUnit.Visible = True

                lblDepth.Visible = True
                txtDepth.Visible = True
                lblDepthUnit.Visible = True

                lblWidth.Visible = True
                txtWidth.Visible = True
                lblWidthUnit.Visible = True

                lblArea.Visible = True
                txtArea.Visible = True
                lblAreaUnit.Visible = True

                lblAreaUnit.Text = "cu mtrs"
            Case 4
                lblLength.Visible = True
                txtLength.Visible = True
                lblLengthUnit.Visible = True

            Case Else

        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Close()
    End Sub
End Class
