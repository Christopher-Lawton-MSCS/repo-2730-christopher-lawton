<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.lblGross = New System.Windows.Forms.Label()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.lblEmpConRate = New System.Windows.Forms.Label()
        Me.lblEmployConRate = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtEmpConRate = New System.Windows.Forms.TextBox()
        Me.txtEmployConRate = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblEmpAnnCon = New System.Windows.Forms.Label()
        Me.lblEmployAnnCon = New System.Windows.Forms.Label()
        Me.lblTotalAnnCon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(13, 13)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(180, 25)
        Me.lblGross.TabIndex = 0
        Me.lblGross.Text = "&Gross Weekly Pay:"
        '
        'txtGross
        '
        Me.txtGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(426, 8)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(186, 34)
        Me.txtGross.TabIndex = 1
        Me.txtGross.Text = "1000"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmpConRate
        '
        Me.lblEmpConRate.AutoSize = True
        Me.lblEmpConRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpConRate.Location = New System.Drawing.Point(13, 94)
        Me.lblEmpConRate.Name = "lblEmpConRate"
        Me.lblEmpConRate.Size = New System.Drawing.Size(404, 25)
        Me.lblEmpConRate.TabIndex = 2
        Me.lblEmpConRate.Text = "&Employee Contribution Rate (Decimal Form): "
        '
        'lblEmployConRate
        '
        Me.lblEmployConRate.AutoSize = True
        Me.lblEmployConRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployConRate.Location = New System.Drawing.Point(13, 138)
        Me.lblEmployConRate.Name = "lblEmployConRate"
        Me.lblEmployConRate.Size = New System.Drawing.Size(394, 25)
        Me.lblEmployConRate.TabIndex = 4
        Me.lblEmployConRate.Text = "Employe&r Contribution Rate (Decimal Form):"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(13, 241)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(282, 25)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Employee Annual Contribution:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(13, 292)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(277, 25)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Employer Annual Contribution:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(13, 343)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(239, 25)
        Me.lbl3.TabIndex = 13
        Me.lbl3.Text = "Total Annual Contribution:"
        '
        'txtEmpConRate
        '
        Me.txtEmpConRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpConRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpConRate.Location = New System.Drawing.Point(454, 91)
        Me.txtEmpConRate.Name = "txtEmpConRate"
        Me.txtEmpConRate.Size = New System.Drawing.Size(158, 34)
        Me.txtEmpConRate.TabIndex = 3
        Me.txtEmpConRate.Text = "0.05"
        Me.txtEmpConRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployConRate
        '
        Me.txtEmployConRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployConRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployConRate.Location = New System.Drawing.Point(454, 135)
        Me.txtEmployConRate.Name = "txtEmployConRate"
        Me.txtEmployConRate.Size = New System.Drawing.Size(158, 34)
        Me.txtEmployConRate.TabIndex = 5
        Me.txtEmployConRate.Text = "0.07"
        Me.txtEmployConRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(348, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(188, 52)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(88, 429)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(188, 52)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblEmpAnnCon
        '
        Me.lblEmpAnnCon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblEmpAnnCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpAnnCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpAnnCon.Location = New System.Drawing.Point(454, 241)
        Me.lblEmpAnnCon.Name = "lblEmpAnnCon"
        Me.lblEmpAnnCon.Size = New System.Drawing.Size(158, 34)
        Me.lblEmpAnnCon.TabIndex = 15
        '
        'lblEmployAnnCon
        '
        Me.lblEmployAnnCon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblEmployAnnCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployAnnCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployAnnCon.Location = New System.Drawing.Point(454, 289)
        Me.lblEmployAnnCon.Name = "lblEmployAnnCon"
        Me.lblEmployAnnCon.Size = New System.Drawing.Size(158, 34)
        Me.lblEmployAnnCon.TabIndex = 16
        '
        'lblTotalAnnCon
        '
        Me.lblTotalAnnCon.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalAnnCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAnnCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnnCon.Location = New System.Drawing.Point(454, 339)
        Me.lblTotalAnnCon.Name = "lblTotalAnnCon"
        Me.lblTotalAnnCon.Size = New System.Drawing.Size(158, 34)
        Me.lblTotalAnnCon.TabIndex = 17
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 493)
        Me.Controls.Add(Me.lblTotalAnnCon)
        Me.Controls.Add(Me.lblEmployAnnCon)
        Me.Controls.Add(Me.lblEmpAnnCon)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtEmployConRate)
        Me.Controls.Add(Me.txtEmpConRate)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblEmployConRate)
        Me.Controls.Add(Me.lblEmpConRate)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.lblGross)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGross As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents lblEmpConRate As Label
    Friend WithEvents lblEmployConRate As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtEmpConRate As TextBox
    Friend WithEvents txtEmployConRate As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblEmpAnnCon As Label
    Friend WithEvents lblEmployAnnCon As Label
    Friend WithEvents lblTotalAnnCon As Label
End Class
