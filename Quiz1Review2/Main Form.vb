'COMC2730 Quiz 1 Part 2 Review
'Chris Lawton


Option Strict On

Public Class Main
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtEmployee.Text = "MsgA"
        Label6.Text = "MsgB"
        lblNet.Text = Convert.ToString(Convert.ToInt32(txtHoursWorked.Text) + 10)
        lblNet.Text = Convert.ToString(Convert.ToInt32(txtHoursWorked.Text) + PictureBox1.Top)
        PictureBox1.Top = 100
        PictureBox1.Top = PictureBox1.Top + Convert.ToInt32(txtHoursWorked.Text)
        txtEmployee.Text = "MsgC" + "MsgD"
        txtEmployee.Text = "MsgC" & "MsgD"
        'Below statement is the same as the 2 below that just add space then underscore,
        'can do it multiple times to keep line length down
        txtEmployee.Text = "Gross pay:" + Convert.ToString(Convert.ToInt32(txtHoursWorked.Text) * Convert.ToDouble(txtRateofPay.Text))
        txtEmployee.Text = "Gross pay:" _
          + Convert.ToString(Convert.ToInt32(txtHoursWorked.Text) * Convert.ToDouble(txtRateofPay.Text))
        lblNet.Text = Format(1000, "N2")
        lblNet.Text = 1000.ToString("N2")
        lblNet.Text = (1000).ToString("N2")
        txtEmployee.Text = "MsgD: " + (Convert.ToDouble(txtRateofPay.Text) * 100).ToString("N2")


    End Sub

End Class
