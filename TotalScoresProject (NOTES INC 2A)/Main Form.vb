' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   Chris Lawton on 9/26/17

'Will use this from here on out
'Explicit On = Spellcheck basically,
'Infer Off = Data Type has to be declared,
'Strict On = Conversions must match
Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'THIS IS USED TO RETAIN VALUE UNTIL CLOSED OUT
    Private decTotal As Decimal


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim decScore As Decimal
        'SAME AS ABOVE but stored differently in system
        'Static decTotal As Decimal

        Decimal.TryParse(txtScore.Text, decScore)
        decTotal = decTotal + decScore
        lblTotal.Text = Convert.ToString(decTotal)

        txtScore.Focus()

    End Sub
End Class
