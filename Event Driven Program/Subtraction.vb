Public Class Subtraction
    Dim rand As New Random 'Declares that this is a random between two intervals
    Dim score As Integer = 0 'Declares the score, the score is preset at 0
    Dim answer As String
    Dim answer2 As String = 1

    Private Sub btnNewSum_Click(sender As Object, e As EventArgs) Handles btnNewSum.Click
        newSum()
    End Sub

    Private Sub newSum()
        'Track Bar Value will determin difficult of question
        If TrackBar2.Value = 0 Then
            'If the track bar is at the point furthest to the left then the easy sums will run
            easySum()
        ElseIf TrackBar2.Value = 1 Then
            'if trackbar is in the middle then the medium sums will run
            mediumSum()
        ElseIf TrackBar2.Value = 2 Then
            'If trackbar value is the highest point then it will run the hardest question
            hardSum()
        End If
    End Sub

    'Easy Sum 
    Private Sub easySum()
        Dim num1 As Double
        Dim num2 As Double
        num1 = rand.Next(100, 200)             'Generate random number between 1 and 12 for num1
        num2 = rand.Next(1, 20)             'Generate random number between 2 and 20 for num2
        txtNum1.Text = num1                 'Display the value of num2 in txtNum1
        txtNum2.Text = num2                 'Display the value of num2 in txtNum2
        answer = num1 - num2                'The answer of num1 - num2, will always be positive
    End Sub
    'medium Sum
    Private Sub mediumSum()
        Dim num1 As Double
        Dim num2 As Double
        num1 = rand.Next(1, 100)          'Generate random number between 100 and 200 for num1
        num2 = rand.Next(100, 200)             'Generate random number between 2 and 20 for num2
        txtNum1.Text = num1                 'Display the value of num2 in txtNum1
        txtNum2.Text = num2                 'Display the value of num2 in txtNum2
        answer = num1 - num2                'The answer of num1 - num2, will always be negative
    End Sub
    'Hard Sum
    Private Sub hardSum()
        Dim num1 As Double
        Dim num2 As Double
        num1 = rand.Next(1000, 2000) / 10   'Generate random number between 100.0 and 200.0 for num1
        num2 = rand.Next(500, 3000) / 10   'Generate random number between 50.0 and 300.0 for num2
        txtNum1.Text = num1                 'Display the value of num2 in txtNum1
        txtNum2.Text = num2                 'Display the value of num2 in txtNum2
        answer = num1 - num2                'The answer of num1 - num2, will be either positive, negative or decimal 
    End Sub
    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged
        'Answer will be entered by the user
        'Answer 2 will be the answer the user put it
        answer2 = txtAnswer.Text
    End Sub
    'Button to check if the answer of the calculation is correct
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        btnCheck.Enabled = True
        checkAnswer()
    End Sub
    'check that the answer is correct
    'display message if not correct
    'display different message if correct
    'if correct score = last score + 1
    'if incorrect score = last score + 0
    'Display score in a txtbox
    Private Sub checkAnswer()
        If answer2 = answer Then
            MessageBox.Show("Well Done! That is Correct!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            score = score + 1
            txtScore.Text = score
            newSum()
        ElseIf answer2 <> answer Then
            MessageBox.Show("That is Incorrect! Please Try Again!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            score = score + 0
            txtScore.Text = score
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ask person if they are sure that they want to quit
        Dim result As Integer = MessageBox.Show("Are you sure you want to close?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If yes is pressed then close, if no is pressed tehn stay open.
        If result = DialogResult.Yes Then       'If dialogue box says yes then close the program
            Close()                             'Closes this form
            Division.Close()                    'Close Addition if hidden
            Multiplication.Close()                 'Close Subtraction if Hidden
            Addition.Close()              'Close Multiplication if hidden
            frmMainMenu.Close()                 'Close Division if Open
        ElseIf result = DialogResult.No Then    'If dialogue box answer is no the return back to the form
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub

End Class