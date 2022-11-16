Public Class StockReportForm

    Private Sub StockReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me._24_25_DatabaseDataSet.stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class