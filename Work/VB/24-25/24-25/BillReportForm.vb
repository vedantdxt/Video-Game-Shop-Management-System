Public Class BillReportForm

    Private Sub BillReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.bill' table. You can move, or remove it, as needed.
        Me.billTableAdapter.Fill(Me._24_25_DatabaseDataSet.bill)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class