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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblProjectedIncrease = New System.Windows.Forms.Label()
        Me.txtProjectedincrease = New System.Windows.Forms.TextBox()
        Me.lblStrawberries = New System.Windows.Forms.Label()
        Me.lblBlueberries = New System.Windows.Forms.Label()
        Me.lblRaspberries = New System.Windows.Forms.Label()
        Me.lblCurrentSales = New System.Windows.Forms.Label()
        Me.lblProjectedSales = New System.Windows.Forms.Label()
        Me.txtStrawberriesCurrent = New System.Windows.Forms.TextBox()
        Me.txtBlueberriesCurrent = New System.Windows.Forms.TextBox()
        Me.txtRaspberriesCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStrawberriesProjected = New System.Windows.Forms.Label()
        Me.lblBlueberriesProjected = New System.Windows.Forms.Label()
        Me.lblRaspberriesProjected = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.StrawBlueRaspberries
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblProjectedIncrease
        '
        Me.LblProjectedIncrease.AutoSize = True
        Me.LblProjectedIncrease.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProjectedIncrease.Location = New System.Drawing.Point(279, 82)
        Me.LblProjectedIncrease.Name = "LblProjectedIncrease"
        Me.LblProjectedIncrease.Size = New System.Drawing.Size(348, 28)
        Me.LblProjectedIncrease.TabIndex = 0
        Me.LblProjectedIncrease.Text = "Projected &increase % (in decimal form):"
        '
        'txtProjectedincrease
        '
        Me.txtProjectedincrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectedincrease.Location = New System.Drawing.Point(652, 81)
        Me.txtProjectedincrease.Name = "txtProjectedincrease"
        Me.txtProjectedincrease.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProjectedincrease.Size = New System.Drawing.Size(116, 30)
        Me.txtProjectedincrease.TabIndex = 1
        Me.txtProjectedincrease.Text = "0.05"
        Me.txtProjectedincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStrawberries
        '
        Me.lblStrawberries.AutoSize = True
        Me.lblStrawberries.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrawberries.Location = New System.Drawing.Point(186, 209)
        Me.lblStrawberries.Name = "lblStrawberries"
        Me.lblStrawberries.Size = New System.Drawing.Size(149, 32)
        Me.lblStrawberries.TabIndex = 2
        Me.lblStrawberries.Text = "&Strawberries:"
        '
        'lblBlueberries
        '
        Me.lblBlueberries.AutoSize = True
        Me.lblBlueberries.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlueberries.Location = New System.Drawing.Point(192, 278)
        Me.lblBlueberries.Name = "lblBlueberries"
        Me.lblBlueberries.Size = New System.Drawing.Size(139, 32)
        Me.lblBlueberries.TabIndex = 4
        Me.lblBlueberries.Text = "&Blueberries:"
        '
        'lblRaspberries
        '
        Me.lblRaspberries.AutoSize = True
        Me.lblRaspberries.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaspberries.Location = New System.Drawing.Point(189, 347)
        Me.lblRaspberries.Name = "lblRaspberries"
        Me.lblRaspberries.Size = New System.Drawing.Size(142, 32)
        Me.lblRaspberries.TabIndex = 6
        Me.lblRaspberries.Text = "&Raspberries:"
        '
        'lblCurrentSales
        '
        Me.lblCurrentSales.AutoSize = True
        Me.lblCurrentSales.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSales.Location = New System.Drawing.Point(392, 146)
        Me.lblCurrentSales.Name = "lblCurrentSales"
        Me.lblCurrentSales.Size = New System.Drawing.Size(156, 32)
        Me.lblCurrentSales.TabIndex = 12
        Me.lblCurrentSales.Text = "Current Sales"
        '
        'lblProjectedSales
        '
        Me.lblProjectedSales.AutoSize = True
        Me.lblProjectedSales.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedSales.Location = New System.Drawing.Point(592, 146)
        Me.lblProjectedSales.Name = "lblProjectedSales"
        Me.lblProjectedSales.Size = New System.Drawing.Size(176, 32)
        Me.lblProjectedSales.TabIndex = 13
        Me.lblProjectedSales.Text = "Projected Sales"
        '
        'txtStrawberriesCurrent
        '
        Me.txtStrawberriesCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrawberriesCurrent.Location = New System.Drawing.Point(389, 206)
        Me.txtStrawberriesCurrent.Name = "txtStrawberriesCurrent"
        Me.txtStrawberriesCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStrawberriesCurrent.Size = New System.Drawing.Size(159, 34)
        Me.txtStrawberriesCurrent.TabIndex = 3
        '
        'txtBlueberriesCurrent
        '
        Me.txtBlueberriesCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlueberriesCurrent.Location = New System.Drawing.Point(389, 275)
        Me.txtBlueberriesCurrent.Name = "txtBlueberriesCurrent"
        Me.txtBlueberriesCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBlueberriesCurrent.Size = New System.Drawing.Size(159, 34)
        Me.txtBlueberriesCurrent.TabIndex = 5
        '
        'txtRaspberriesCurrent
        '
        Me.txtRaspberriesCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaspberriesCurrent.Location = New System.Drawing.Point(389, 344)
        Me.txtRaspberriesCurrent.Name = "txtRaspberriesCurrent"
        Me.txtRaspberriesCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRaspberriesCurrent.Size = New System.Drawing.Size(159, 34)
        Me.txtRaspberriesCurrent.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(33, 478)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 51)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(225, 478)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 51)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(417, 478)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 51)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(609, 478)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 51)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStrawberriesProjected
        '
        Me.lblStrawberriesProjected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStrawberriesProjected.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrawberriesProjected.Location = New System.Drawing.Point(609, 208)
        Me.lblStrawberriesProjected.Name = "lblStrawberriesProjected"
        Me.lblStrawberriesProjected.Size = New System.Drawing.Size(159, 34)
        Me.lblStrawberriesProjected.TabIndex = 14
        Me.lblStrawberriesProjected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlueberriesProjected
        '
        Me.lblBlueberriesProjected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlueberriesProjected.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlueberriesProjected.Location = New System.Drawing.Point(609, 277)
        Me.lblBlueberriesProjected.Name = "lblBlueberriesProjected"
        Me.lblBlueberriesProjected.Size = New System.Drawing.Size(159, 34)
        Me.lblBlueberriesProjected.TabIndex = 15
        Me.lblBlueberriesProjected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaspberriesProjected
        '
        Me.lblRaspberriesProjected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRaspberriesProjected.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaspberriesProjected.Location = New System.Drawing.Point(609, 346)
        Me.lblRaspberriesProjected.Name = "lblRaspberriesProjected"
        Me.lblRaspberriesProjected.Size = New System.Drawing.Size(159, 34)
        Me.lblRaspberriesProjected.TabIndex = 16
        Me.lblRaspberriesProjected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 582)
        Me.Controls.Add(Me.lblRaspberriesProjected)
        Me.Controls.Add(Me.lblBlueberriesProjected)
        Me.Controls.Add(Me.lblStrawberriesProjected)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtRaspberriesCurrent)
        Me.Controls.Add(Me.txtBlueberriesCurrent)
        Me.Controls.Add(Me.txtStrawberriesCurrent)
        Me.Controls.Add(Me.lblProjectedSales)
        Me.Controls.Add(Me.lblCurrentSales)
        Me.Controls.Add(Me.lblRaspberries)
        Me.Controls.Add(Me.lblBlueberries)
        Me.Controls.Add(Me.lblStrawberries)
        Me.Controls.Add(Me.txtProjectedincrease)
        Me.Controls.Add(Me.LblProjectedIncrease)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "Cranston Berries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblProjectedIncrease As Label
    Friend WithEvents txtProjectedincrease As TextBox
    Friend WithEvents lblStrawberries As Label
    Friend WithEvents lblBlueberries As Label
    Friend WithEvents lblRaspberries As Label
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents lblProjectedSales As Label
    Friend WithEvents txtStrawberriesCurrent As TextBox
    Friend WithEvents txtBlueberriesCurrent As TextBox
    Friend WithEvents txtRaspberriesCurrent As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStrawberriesProjected As Label
    Friend WithEvents lblBlueberriesProjected As Label
    Friend WithEvents lblRaspberriesProjected As Label
End Class
