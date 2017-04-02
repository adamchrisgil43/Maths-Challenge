'Menu Form
Public Class frmMainMenu
    'Addition Form Button
    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Me.Hide()               'Hide Menu Form
        Addition.Show()         'Show Addition Form
    End Sub
    'Subtraction Form Button
    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        Me.Hide()               'Hide Menu Form
        Subtraction.Show()      'Show Subtraction Form
    End Sub
    'Multiplication Form Button
    Private Sub btnMulitplication_Click(sender As Object, e As EventArgs) Handles btnMulitplication.Click
        Me.Hide()               'Hide Menu Form
        Multiplication.Show()   'Show Multiplication Form
    End Sub
    'Divison Form Button
    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Me.Hide()               'Hide Menu Form
        Division.Show()         'Show Division Form
    End Sub
    'Exit Form Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ask person if they are sure that they want to quit
        Dim result As Integer = MessageBox.Show("Are you sure you want to close?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If yes is pressed then close, if no is pressed tehn stay open.
        If result = DialogResult.Yes Then
            Close()               'Closes this form
            Addition.Close()        'Close Addition if hidden
            Subtraction.Close()     'Close Subtraction if Hidden
            Multiplication.Close()  'Close Multiplication if hidden
            Division.Close()        'Close Division if Open
        ElseIf result = DialogResult.No Then

        End If

    End Sub
   

End Class
