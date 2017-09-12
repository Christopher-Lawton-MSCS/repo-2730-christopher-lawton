'Name:          Cranston Berries
'Purpose:       Calculates Projected Sales
'Programmer:    Chris Lawton 9-11-17

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Close Application

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblStrawberriesProjected.Text = Format(Val(txtStrawberriesCurrent.Text) + (Val(txtProjectedincrease.Text) * Val(txtStrawberriesCurrent.Text)), "currency")
        lblBlueberriesProjected.Text = Format(Val(txtBlueberriesCurrent.Text) + (Val(txtProjectedincrease.Text) * Val(txtBlueberriesCurrent.Text)), "currency")
        lblRaspberriesProjected.Text = Format(Val(txtRaspberriesCurrent.Text) + (Val(txtProjectedincrease.Text) * Val(txtRaspberriesCurrent.Text)), "currency")
        'Calculate Projected Sales for Strawberries, Blueberries and Raspberries

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProjectedincrease.Text = String.Empty
        txtProjectedincrease.Text = CType(0.05, String)
        txtStrawberriesCurrent.Text = String.Empty
        txtBlueberriesCurrent.Text = String.Empty
        txtRaspberriesCurrent.Text = String.Empty
        lblStrawberriesProjected.Text = String.Empty
        lblBlueberriesProjected.Text = String.Empty
        lblRaspberriesProjected.Text = String.Empty
        txtProjectedincrease.Focus()
        'Clear form and reset Projected increase to 0.05 and shift focus back that text box

    End Sub
End Class
