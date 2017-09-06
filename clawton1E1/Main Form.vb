'Name               Richardson County
'Purpose            Calculates the property tax
'
'Programmer         Chris Lawton on 9/6/17

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepare form for next Calculation
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        'Send focus to Assessed Value
        txtAssessed.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculates tax on Assessed Value
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub
End Class
