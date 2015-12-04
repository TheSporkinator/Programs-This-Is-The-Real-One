    'Chapter 4:     Auto Loan Calculator
    'Programmer:    Evan Lopez
    'Date:          12/2/15
    'Purpouse:      This program calaulates the monthly payment for a loan 
    '               based on loan amount, interest rate and length of loan


    Dim globalMonths As Double = 60.0
    Const maxLoanAmountAllowed As Integer = 25000
    Const maxLowCreditAllowed As Integer = 5000

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the maximum value of the loan amount NumericUpDown control
        loanAmount.Maximum = maxLoanAmountAllowed

    End Sub

    Private Sub btn3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threeYears.CheckedChanged
        globalMonths = 36
    End Sub

    Private Sub btn5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fiveYears.CheckedChanged
        globalMonths = 60
    End Sub

    Private Sub btn7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sevenYears.CheckedChanged
        globalMonths = 84
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Reset loan amount and mothley payment to zero
        'teset the interest rate to 5%, and select five years for the length of the loan.
        loanAmount.Value = 0.0
        interestRate.Value = 5.0
        fiveYears.Checked = True
        TextBox1.Text = "$0.00"
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        'Validate inputes and compute the monthly payment using the inputes,
        'Determin the interest Rate to be used based on the input rate divided
        'by at 12.0. Display the result in the TextBox1 text box.
        Dim dblRate, dblMonths, dblPayment As Double
        Dim dblLoanAmount As Double, strPayment As String
        Dim dblAdjustedRate As Double, strErrorMEssage As String

        dblLoanAmount = Convert.ToDouble(loanAmount.Value)

        If ComboBox1.Text = "" Then
            MessageBox.Show("Please enter the customers credit rating in the credit rating box.")
            ComboBox1.Focus()
            Exit Sub
        End If

        'Set the true interest rate based on the inpute rate divided by 12.0
        dblRate = Convert.ToDouble(interestRate.Value) / 100 / 12

        Select Case ComboBox1.SelectedIndex
            Case 0  'credit rating of A
                dblAdjustedRate = dblRate
            Case 1  'credit rating of  B
                dblAdjustedRate = dblRate + 1.1
            Case 2  'credit rating of C
                dblAdjustedRate = dblRate + 1.15
            Case 3  'credit rating of D
                dblAdjustedRate = dblRate + 1.17
            Case 4  'credit rating of E
                dblAdjustedRate = dblRate + 1.25
        End Select

        'Calculate the monthly payment using the .NET PMT dunction. Format the 
        'results as currency and then display the result in the TextBox1 text box
        dblPayment = Pmt(dblAdjustedRate, globalMonths, -dblLoanAmount)
        strPayment = Format$(dblPayment, "Currency")




        TextBox1.Text = strPayment

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        'If ComboBox1.Text = "A - Excellent" Then
        '    interestRate.Value = interestRate.Value + 0
        'End If

        'If ComboBox1.Text = "B - Good" Then
        '    interestRate.Value = interestRate.Value * 0.15
        'End If


    End Sub
End Class
