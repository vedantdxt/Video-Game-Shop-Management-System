Public Class ProdReportForm

    Private Sub ProdReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.product' table. You can move, or remove it, as needed.
        Me.productTableAdapter.Fill(Me._24_25_DatabaseDataSet.product)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class