Public Class report

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        CustReportForm.Show()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        EmpReportForm.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        StockReportForm.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        BillReportForm.Show()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ProdReportForm.Show()
    End Sub
End Class