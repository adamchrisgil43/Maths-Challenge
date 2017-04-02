<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Division
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Division))
        Me.lblEasy = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.lblHard = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnNewSum = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lbl2DP = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasy.Location = New System.Drawing.Point(10, 330)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(57, 29)
        Me.lblEasy.TabIndex = 22
        Me.lblEasy.Text = "Easy"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedium.Location = New System.Drawing.Point(351, 330)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(97, 29)
        Me.lblMedium.TabIndex = 23
        Me.lblMedium.Text = "Medium"
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.SystemColors.Desktop
        Me.TrackBar2.LargeChange = 1
        Me.TrackBar2.Location = New System.Drawing.Point(25, 282)
        Me.TrackBar2.Maximum = 2
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(749, 45)
        Me.TrackBar2.TabIndex = 25
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHard.Location = New System.Drawing.Point(732, 330)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(61, 29)
        Me.lblHard.TabIndex = 26
        Me.lblHard.Text = "Hard"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(300, 250)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(202, 29)
        Me.lblSelect.TabIndex = 29
        Me.lblSelect.Text = "Select Sum Difficult"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMenu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Location = New System.Drawing.Point(15, 362)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(173, 51)
        Me.btnMenu.TabIndex = 30
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnNewSum
        '
        Me.btnNewSum.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNewSum.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSum.Location = New System.Drawing.Point(618, 362)
        Me.btnNewSum.Name = "btnNewSum"
        Me.btnNewSum.Size = New System.Drawing.Size(173, 51)
        Me.btnNewSum.TabIndex = 31
        Me.btnNewSum.Text = "New Sum"
        Me.btnNewSum.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(315, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 51)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(347, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(108, 36)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Text = "Division"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(691, 209)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(67, 29)
        Me.lblScore.TabIndex = 55
        Me.lblScore.Text = "Score"
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(674, 238)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 38)
        Me.txtScore.TabIndex = 56
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl2DP
        '
        Me.lbl2DP.AutoSize = True
        Me.lbl2DP.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2DP.Location = New System.Drawing.Point(463, 128)
        Me.lbl2DP.Name = "lbl2DP"
        Me.lbl2DP.Size = New System.Drawing.Size(279, 29)
        Me.lbl2DP.TabIndex = 109
        Me.lbl2DP.Text = "Answer to 2 decimal places"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(357, 122)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 38)
        Me.txtAnswer.TabIndex = 108
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 45)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 45)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "÷"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(57, 122)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 38)
        Me.txtNum1.TabIndex = 105
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(207, 122)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 38)
        Me.txtNum2.TabIndex = 104
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCheck.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.Location = New System.Drawing.Point(544, 236)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(124, 40)
        Me.btnCheck.TabIndex = 114
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'Division
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(803, 419)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lbl2DP)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewSum)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblHard)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Division"
        Me.Text = "Maths Challenge"
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEasy As Label
    Friend WithEvents lblMedium As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents lblHard As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnNewSum As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents txtScore As TextBox
    Friend WithEvents lbl2DP As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnCheck As Button
End Class
