'Name:          Cranston Berries
'Purpose:       Calculates Projected Sales
'Programmer:    Chris Lawton 9-28-17

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Close Application

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decProjectedincrease As Decimal
        Dim decStrawberriesCurrent As Decimal
        Dim decBlueberriesCurrent As Decimal
        Dim decRaspberriesCurrent As Decimal
        Dim decStrawberriesProjected As Decimal
        Dim decBlueberriesProjected As Decimal
        Dim decRaspberriesProjected As Decimal

        'convert text into decimal form
        Decimal.TryParse(txtProjectedincrease.Text, decProjectedincrease)
        Decimal.TryParse(txtStrawberriesCurrent.Text, decStrawberriesCurrent)
        Decimal.TryParse(txtBlueberriesCurrent.Text, decBlueberriesCurrent)
        Decimal.TryParse(txtRaspberriesCurrent.Text, decRaspberriesCurrent)
        Decimal.TryParse(lblStrawberriesProjected.Text, decStrawberriesProjected)
        Decimal.TryParse(lblBlueberriesProjected.Text, decBlueberriesProjected)
        Decimal.TryParse(lblRaspberriesProjected.Text, decRaspberriesProjected)

        'calculate the projected sales
        decStrawberriesProjected = decProjectedincrease * decStrawberriesCurrent + decStrawberriesCurrent
        decBlueberriesProjected = decProjectedincrease * decBlueberriesCurrent + decBlueberriesCurrent
        decRaspberriesProjected = decProjectedincrease * decRaspberriesCurrent + decRaspberriesCurrent

        'Display projected berry values as currency
        lblStrawberriesProjected.Text = decStrawberriesProjected.ToString("C2")
        lblBlueberriesProjected.Text = decBlueberriesProjected.ToString("C2")
        lblRaspberriesProjected.Text = decRaspberriesProjected.ToString("C2")


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

    Private Sub btnRetireForm_Click(sender As Object, e As EventArgs) Handles btnRetireForm.Click
        frmRetirement.Show()
        Me.Hide()

        'send to Retirement Form and Hide Berries
    End Sub

End Class
