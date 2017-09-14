<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTestScore1 = New System.Windows.Forms.Label()
        Me.lblTestScore2 = New System.Windows.Forms.Label()
        Me.lblTestScore3 = New System.Windows.Forms.Label()
        Me.lblAverageTestScore = New System.Windows.Forms.Label()
        Me.txtTestScore1 = New System.Windows.Forms.TextBox()
        Me.txtTestScore2 = New System.Windows.Forms.TextBox()
        Me.txtTestScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverageTestScoreResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTestScore1
        '
        Me.lblTestScore1.AutoSize = True
        Me.lblTestScore1.Location = New System.Drawing.Point(48, 43)
        Me.lblTestScore1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestScore1.Name = "lblTestScore1"
        Me.lblTestScore1.Size = New System.Drawing.Size(115, 25)
        Me.lblTestScore1.TabIndex = 0
        Me.lblTestScore1.Text = "Test Score &1:"
        '
        'lblTestScore2
        '
        Me.lblTestScore2.AutoSize = True
        Me.lblTestScore2.Location = New System.Drawing.Point(48, 134)
        Me.lblTestScore2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestScore2.Name = "lblTestScore2"
        Me.lblTestScore2.Size = New System.Drawing.Size(115, 25)
        Me.lblTestScore2.TabIndex = 2
        Me.lblTestScore2.Text = "Test Score &2:"
        '
        'lblTestScore3
        '
        Me.lblTestScore3.AutoSize = True
        Me.lblTestScore3.Location = New System.Drawing.Point(48, 225)
        Me.lblTestScore3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestScore3.Name = "lblTestScore3"
        Me.lblTestScore3.Size = New System.Drawing.Size(115, 25)
        Me.lblTestScore3.TabIndex = 4
        Me.lblTestScore3.Text = "Test Score &3:"
        '
        'lblAverageTestScore
        '
        Me.lblAverageTestScore.AutoSize = True
        Me.lblAverageTestScore.Location = New System.Drawing.Point(120, 350)
        Me.lblAverageTestScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAverageTestScore.Name = "lblAverageTestScore"
        Me.lblAverageTestScore.Size = New System.Drawing.Size(170, 25)
        Me.lblAverageTestScore.TabIndex = 9
        Me.lblAverageTestScore.Text = "Average test score:"
        '
        'txtTestScore1
        '
        Me.txtTestScore1.Location = New System.Drawing.Point(232, 40)
        Me.txtTestScore1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTestScore1.Name = "txtTestScore1"
        Me.txtTestScore1.Size = New System.Drawing.Size(124, 31)
        Me.txtTestScore1.TabIndex = 1
        Me.txtTestScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTestScore2
        '
        Me.txtTestScore2.Location = New System.Drawing.Point(232, 131)
        Me.txtTestScore2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTestScore2.Name = "txtTestScore2"
        Me.txtTestScore2.Size = New System.Drawing.Size(124, 31)
        Me.txtTestScore2.TabIndex = 3
        Me.txtTestScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTestScore3
        '
        Me.txtTestScore3.Location = New System.Drawing.Point(232, 222)
        Me.txtTestScore3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTestScore3.Name = "txtTestScore3"
        Me.txtTestScore3.Size = New System.Drawing.Size(124, 31)
        Me.txtTestScore3.TabIndex = 5
        Me.txtTestScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(425, 37)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(115, 36)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(425, 128)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 219)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverageTestScoreResult
        '
        Me.lblAverageTestScoreResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAverageTestScoreResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageTestScoreResult.Location = New System.Drawing.Point(345, 348)
        Me.lblAverageTestScoreResult.Name = "lblAverageTestScoreResult"
        Me.lblAverageTestScoreResult.Size = New System.Drawing.Size(124, 31)
        Me.lblAverageTestScoreResult.TabIndex = 10
        Me.lblAverageTestScoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 404)
        Me.Controls.Add(Me.lblAverageTestScoreResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTestScore3)
        Me.Controls.Add(Me.txtTestScore2)
        Me.Controls.Add(Me.txtTestScore1)
        Me.Controls.Add(Me.lblAverageTestScore)
        Me.Controls.Add(Me.lblTestScore3)
        Me.Controls.Add(Me.lblTestScore2)
        Me.Controls.Add(Me.lblTestScore1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Average Test Score Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTestScore1 As Label
    Friend WithEvents lblTestScore2 As Label
    Friend WithEvents lblTestScore3 As Label
    Friend WithEvents lblAverageTestScore As Label
    Friend WithEvents txtTestScore1 As TextBox
    Friend WithEvents txtTestScore2 As TextBox
    Friend WithEvents txtTestScore3 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverageTestScoreResult As Label
End Class
