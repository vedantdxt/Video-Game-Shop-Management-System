Public Class CustReportForm

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.customer' table. You can move, or remove it, as needed.
        Me.customerTableAdapter.Fill(Me._24_25_DatabaseDataSet.customer)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class