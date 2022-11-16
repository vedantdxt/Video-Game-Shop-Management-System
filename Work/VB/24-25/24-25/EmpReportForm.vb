Public Class EmpReportForm

    Private Sub EmpReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.employee' table. You can move, or remove it, as needed.
        Me.employeeTableAdapter.Fill(Me._24_25_DatabaseDataSet.employee)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class