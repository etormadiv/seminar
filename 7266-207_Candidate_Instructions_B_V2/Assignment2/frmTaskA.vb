'Author: Mohamed sedig
Public Class frmTaskA
    Dim username As String
    Dim strFileName As String

    Private Sub frmTaskA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username = InputBox("Enter Your name:")
        Text = username

        strFileName = "Sales.txt"
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim prodName As String
        Dim quantity As Byte
        Dim price As Decimal

        Dim Total As Decimal


        prodName = txtProdName.Text
        quantity = Byte.Parse(txtQuantity.Text)
        price = Decimal.Parse(txtPrice.Text)

        Total = price * quantity

        If radAppend.Checked Then
            FileOpen(1, strFileName, OpenMode.Append)
        Else
            FileOpen(1, strFileName, OpenMode.Output)
        End If

        PrintLine(1, prodName, quantity, price, Total)
        FileClose(1)

        txtPrice.Clear()
        txtProdName.Clear()
        txtQuantity.Clear()

        cmdDisplay.Enabled = True

    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
        Dim DataRecord As String
        FileOpen(1, strFileName, OpenMode.Input)
        lstDisplay.Items.Clear()

        While Not EOF(1)
            DataRecord = LineInput(1)
            If Not String.IsNullOrWhiteSpace(DataRecord) Then
                lstDisplay.Items.Add(DataRecord)
            End If
        End While

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class