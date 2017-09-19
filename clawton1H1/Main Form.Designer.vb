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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtRateofPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee &Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Hours Worked:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(590, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Rate of Pay:"
        '
        'txtEmployee
        '
        Me.txtEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(457, 9)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(303, 38)
        Me.txtEmployee.TabIndex = 1
        Me.txtEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursWorked.Location = New System.Drawing.Point(379, 94)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 30)
        Me.txtHoursWorked.TabIndex = 3
        Me.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRateofPay
        '
        Me.txtRateofPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRateofPay.Location = New System.Drawing.Point(599, 94)
        Me.txtRateofPay.Name = "txtRateofPay"
        Me.txtRateofPay.Size = New System.Drawing.Size(100, 30)
        Me.txtRateofPay.TabIndex = 5
        Me.txtRateofPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gross Pay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(606, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Net Pay:"
        '
        'lblGross
        '
        Me.lblGross.BackColor = System.Drawing.SystemColors.Info
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.ForeColor = System.Drawing.Color.Blue
        Me.lblGross.Location = New System.Drawing.Point(349, 192)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(160, 51)
        Me.lblGross.TabIndex = 9
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.Info
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Teal
        Me.lblNet.Location = New System.Drawing.Point(569, 192)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(160, 51)
        Me.lblNet.TabIndex = 11
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(108, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "FWT:"
        '
        'lblFWT
        '
        Me.lblFWT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFWT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWT.Location = New System.Drawing.Point(59, 334)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(160, 51)
        Me.lblFWT.TabIndex = 13
        Me.lblFWT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "FICA:"
        '
        'lblFICA
        '
        Me.lblFICA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(318, 334)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(160, 51)
        Me.lblFICA.TabIndex = 15
        Me.lblFICA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(625, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "State:"
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(577, 334)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(160, 51)
        Me.lblState.TabIndex = 17
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(41, 460)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(197, 59)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(300, 460)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(197, 59)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(559, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(197, 59)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.clawton1H1.My.Resources.Resources.facilities_Darkroom
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 570)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRateofPay)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Photo Workshop Payroll Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents txtRateofPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
