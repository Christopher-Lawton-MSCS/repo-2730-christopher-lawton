'Name:          Photo Workshop Payroll Calculator
'Purpose:       Calculate Net, Gross, FWT, FICA, State Pay and Taxes For Employee
'Programmer:    Chris Lawton 9-18-17

Option Strict On

Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmployee.Text = String.Empty
        txtHoursWorked.Text = String.Empty
        txtRateofPay.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblGross.Text = String.Empty
        lblNet.Text = String.Empty
        txtHoursWorked.Text = Format(CType(0.00, String), "fixed")
        txtRateofPay.Text = Format(CType(0.00, String), "fixed")
        txtEmployee.Focus()
        'Clear all forms, send focus to Employee Name while also placing 0.00 into Hours and Rate

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Exit Application

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblGross.Text = Format(Val(txtHoursWorked.Text) * Val(txtRateofPay.Text), "fixed")
        lblFWT.Text = Format((Val(txtHoursWorked.Text) * Val(txtRateofPay.Text)) * 0.2, "fixed")
        lblFICA.Text = Format((Val(txtHoursWorked.Text) * Val(txtRateofPay.Text)) * 0.08, "fixed")
        lblState.Text = Format((Val(txtHoursWorked.Text) * Val(txtRateofPay.Text)) * 0.03, "fixed")
        lblNet.Text = Format((Val(txtHoursWorked.Text) * Val(txtRateofPay.Text)) - ((Val(txtHoursWorked.Text) * Val(txtRateofPay.Text)) * 0.31), "fixed")
        'Calculates Federal, Social Security, and State Taxes while also calculating Gross and Net Pay


    End Sub
End Class
