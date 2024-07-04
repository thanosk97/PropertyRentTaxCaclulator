Imports System

Public Class Home
    Private monthlyRents As New List(Of Double)

    ' Function to calculate the tax based on gross income
    Private Function CalculateTax(grossIncome As Double) As Double
        If grossIncome <= 12000 Then
            Return grossIncome * 0.15
        ElseIf grossIncome <= 35000 Then
            Return 12000 * 0.15 + (grossIncome - 12000) * 0.35
        Else
            Return 12000 * 0.15 + 23000 * 0.35 + (grossIncome - 35000) * 0.45
        End If
    End Function

    ' Function to add a monthly rent to the list
    Private Sub AddMonthlyRent(rent As Double)
        monthlyRents.Add(rent)
        UpdateRentList()
    End Sub

    ' Function to update the DataGridView with the monthly rents
    Private Sub UpdateRentList()
        dgvRents.Rows.Clear()
        For i As Integer = 0 To monthlyRents.Count - 1
            dgvRents.Rows.Add(i + 1, monthlyRents(i))
        Next
        dgvRents.CurrentCell = Nothing ' Clear the current selection

    End Sub

    ' Function to print the results
    Private Sub PrintResults(grossIncome As Double, tax As Double, monthlyRents As List(Of Double))
        Dim monthlyNetIncome = monthlyRents.Select(Function(rent) rent - (rent * tax / grossIncome)).ToList()
        Dim totalMonthlyNetIncome = monthlyNetIncome.Sum()

        rtbResults.Clear()
        rtbResults.AppendText($"Το ακαθάριστο ετήσιο εισόδημά σας είναι: {grossIncome:F2} ευρώ." & vbCrLf)
        rtbResults.AppendText($"Ο φόρος εισοδήματός σας ανέρχεται σε: {tax:F2} ευρώ." & vbCrLf & vbCrLf)
        For i As Integer = 0 To monthlyRents.Count - 1
            rtbResults.AppendText($"Το μινιαίο καθαρό εισόδημα από ενοίκιο για ακίνητο {i + 1} είναι: {monthlyNetIncome(i):F2} ευρώ." & vbCrLf)
        Next
        rtbResults.AppendText(vbCrLf & $"Συνολικό μηνιαίο καθαρό εισόδημα: {totalMonthlyNetIncome:F2} ευρώ.")
    End Sub

    ' Button click event to add a rent to the list
    Private Sub btnAddRent_Click(sender As Object, e As EventArgs) Handles btnAddRent.Click
        Dim rent As Double
        If Double.TryParse(txtRent.Text, rent) Then
            AddMonthlyRent(rent)
            txtRent.Clear()
            txtRent.Focus()
        Else
            MessageBox.Show("Λανθασμένη μορφή εισόδου. Πληκτρολογήστε αριθμό.")
        End If
    End Sub

    ' Enter key press event to add a rent to the list
    Private Sub txtRent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRent.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' This line prevents the system sound from occurring
            Dim rent As Double
            If Double.TryParse(txtRent.Text, rent) Then
                AddMonthlyRent(rent)
                txtRent.Clear()
                txtRent.Focus()
            Else
                MessageBox.Show("Λανθασμένη μορφή εισόδου. Πληκτρολογήστε αριθμό.")
            End If
        End If
    End Sub



    ' Button click event to calculate the tax and net income
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim grossIncome = monthlyRents.Sum() * 12
        Dim tax = CalculateTax(grossIncome)
        PrintResults(grossIncome, tax, monthlyRents)
    End Sub

    ' Button click event to reset the form
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        monthlyRents.Clear()
        txtRent.Clear()
        rtbResults.Clear()
        dgvRents.Rows.Clear()
        txtRent.Focus()
    End Sub

    ' Button click event to exit the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRents.Columns("ColumnProperty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRents.Columns("ColumnRent").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRents.Columns("ColumnRent").DefaultCellStyle.Format = "C0" ' "C2" format displays currency with 2 decimal places
        dgvRents.Columns("ColumnRent").DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("el-GR") ' Set the culture to Greek (Greece) for Euros symbol

    End Sub


End Class
