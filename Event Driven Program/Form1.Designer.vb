<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMulitplication = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(32, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 51)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMulitplication
        '
        Me.btnMulitplication.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMulitplication.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulitplication.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMulitplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMulitplication.Location = New System.Drawing.Point(32, 249)
        Me.btnMulitplication.Name = "btnMulitplication"
        Me.btnMulitplication.Size = New System.Drawing.Size(242, 71)
        Me.btnMulitplication.TabIndex = 23
        Me.btnMulitplication.Text = "Multiplication"
        Me.btnMulitplication.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDivision.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDivision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDivision.Location = New System.Drawing.Point(528, 249)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(242, 71)
        Me.btnDivision.TabIndex = 22
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnSubtraction
        '
        Me.btnSubtraction.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubtraction.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubtraction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubtraction.Location = New System.Drawing.Point(528, 113)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(242, 71)
        Me.btnSubtraction.TabIndex = 21
        Me.btnSubtraction.Text = "Subtraction"
        Me.btnSubtraction.UseVisualStyleBackColor = False
        '
        'btnAddition
        '
        Me.btnAddition.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddition.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddition.Location = New System.Drawing.Point(32, 113)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(242, 71)
        Me.btnAddition.TabIndex = 20
        Me.btnAddition.Text = "Addition"
        Me.btnAddition.UseVisualStyleBackColor = False
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(325, 9)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(152, 36)
        Me.lblMainMenu.TabIndex = 19
        Me.lblMainMenu.Text = "Main Menu"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(803, 419)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMulitplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.lblMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "Maths Challenge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnMulitplication As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents lblMainMenu As Label
End Class
