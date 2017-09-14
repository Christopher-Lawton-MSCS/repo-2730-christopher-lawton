'Name:          Average Test Score Calculator
'Purpose:       Average Test Scores
'Programmer:    Chris Lawton 9-13-17

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAverageTestScoreResult.Text = Format(Val(Val(txtTestScore1.Text) + Val(txtTestScore2.Text) + Val(txtTestScore3.Text)) / 3, "Fixed")
        'Calculate Average Test Score
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Text = String.Empty
        txtTestScore2.Text = String.Empty
        txtTestScore3.Text = String.Empty
        lblAverageTestScoreResult.Text = String.Empty
        txtTestScore1.Text = CType(0, String)
        txtTestScore2.Text = CType(0, String)
        txtTestScore3.Text = CType(0, String)
        txtTestScore1.Focus()
        'Clear Form, Put 0 in Test Score Value, and Focus Test Score 1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Make Application Close
    End Sub
End Class
