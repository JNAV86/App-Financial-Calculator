Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtRevenue.Text >= txtExpense.Text Then
            lblProfit.Text = txtRevenue.Text - txtExpense.Text
            lblLoss.Text = 0
        ElseIf txtExpense.Text >= txtRevenue.Text Then
            lblLoss.Text = txtExpense.Text - txtRevenue.Text
            lblProfit.Text = 0
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRevenue.Text = String.Empty
        txtExpense.Text = String.Empty
        lblProfit.Text = String.Empty
        lblLoss.Text = String.Empty
        txtRevenue.Focus()
    End Sub

    Private Sub lblLoss_Click(sender As Object, e As EventArgs) Handles lblLoss.Click

    End Sub



End Class
