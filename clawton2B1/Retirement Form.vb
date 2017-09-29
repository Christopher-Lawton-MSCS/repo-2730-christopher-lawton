'Name:          Retirement Form
'Purpose:       Calculates Retirement Contributions 
'Programmer:    Chris Lawton 9-28-17

Option Explicit On
Option Infer Off
Option Strict On



Public Class frmRetirement
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
        'Closes Form and shows Berries

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Calculates the annual contribution rates for retirement fund

        Static decGrossYear As Decimal
        Dim decGross As Decimal
        Dim decEmpConRate As Decimal
        Dim decEmployConRate As Decimal
        Dim decEmpAnnCon As Decimal
        Dim decEmployAnnCon As Decimal
        Dim decTotalAnnCon As Decimal

        'convert text into decimal form
        Decimal.TryParse(txtGross.Text, decGross)
        Decimal.TryParse(txtEmpConRate.Text, decEmpConRate)
        Decimal.TryParse(txtEmployConRate.Text, decEmployConRate)
        Decimal.TryParse(lblEmpAnnCon.Text, decEmpAnnCon)
        Decimal.TryParse(lblEmployAnnCon.Text, decEmployAnnCon)
        Decimal.TryParse(lblTotalAnnCon.Text, decTotalAnnCon)

        'calculate the gross pay for a year
        decGrossYear = decGross * 52

        'calculate the employee's annual contribution
        decEmpAnnCon = decEmpConRate * decGrossYear

        'calculate the employer's annual contribution 
        decEmployAnnCon = decEmployConRate * decGrossYear

        'calculate the total annual contribution
        decTotalAnnCon = decEmpAnnCon + decEmployAnnCon

        'Display employee, employer, and total annual amounts as currency
        lblEmpAnnCon.Text = decEmpAnnCon.ToString("C2")
        lblEmployAnnCon.Text = decEmployAnnCon.ToString("C2")
        lblTotalAnnCon.Text = decTotalAnnCon.ToString("C2")

        'Focus gross pay text box
        txtGross.Focus()

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtGross.TextChanged, txtEmpConRate.TextChanged, txtEmployConRate.TextChanged
        ' clear all Annual text values when any editable text is changed and focus Gross Pay 
        lblEmpAnnCon.Text = String.Empty
        lblEmployAnnCon.Text = String.Empty
        lblTotalAnnCon.Text = String.Empty


    End Sub

End Class