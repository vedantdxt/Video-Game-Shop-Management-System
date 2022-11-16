Public Class stock

    Private Sub stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me._24_25_DatabaseDataSet.stock)
    End Sub

    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        StockBindingSource.MoveNext()
    End Sub

    Private Sub Last_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_BTN.Click
        StockBindingSource.MoveLast()
    End Sub

    Private Sub First_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_BTN.Click
        StockBindingSource.MoveFirst()
    End Sub

    Private Sub Prev_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev_BTN.Click
        StockBindingSource.MovePrevious()
    End Sub

    Private Sub Delete_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_BTN.Click
        Dim choice As Integer
        choice = MsgBox("Do you really want to Delete selected record?", MsgBoxStyle.YesNo, "Delete")
        If choice = 6 Then
            StockBindingSource.RemoveCurrent()
            StockTableAdapter.Update(_24_25_DatabaseDataSet.stock)
        End If
    End Sub

    Private Sub Add_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_BTN.Click
        If Add_BTN.Text = "ADD" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")
            StockBindingSource.AddNew()

            Add_BTN.Text = "SAVE"
            Add_BTN.FillColor = Color.SpringGreen
            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            StockID_TB.ReadOnly = True
            StockID_TB.Text = "50" & StockBindingSource.Count
            StockID_TB.ForeColor = Color.Red
            StockDate_TB.Text = DateTime.Now.ToString("dd/MM/yyyy")
            StockDate_TB.ReadOnly = True
            StockDate_TB.ForeColor = Color.Red

        ElseIf Add_BTN.Text = "SAVE" Then
            If EmpID_TB.Text <> "" And StockPrice_TB.Text <> "" And ProdID_TB.Text <> "" And StockQuan_TB.Text <> "" And StockDate_TB.Text <> "" Then
                If IsNumeric(EmpID_TB.Text) And EmpID_TB.Text.Length = 4 Then
                    If IsNumeric(ProdID_TB.Text And ProdID_TB.Text.Length = 4) Then
                        If IsNumeric(StockPrice_TB.Text) Then

                            Add_BTN.Text = "ADD"
                            Add_BTN.FillColor = Color.DarkOrchid
                            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            StockID_TB.ForeColor = Color.White

                            Try
                                StockBindingSource.EndEdit()
                                StockTableAdapter.Update(_24_25_DatabaseDataSet.stock)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Enter Stock Price correctly")
                        End If
                    Else
                        MsgBox("Fill Product ID correctly")
                    End If
                Else
                    MsgBox("Fill Employee ID correctly")
                End If
            Else
                MsgBox("Fill All Details!")
            End If
        End If
    End Sub

    Private Sub Edit_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_BTN.Click
        If Edit_BTN.Text = "EDIT" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")

            Edit_BTN.Text = "SAVE"
            Edit_BTN.FillColor = Color.SpringGreen
            Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            StockID_TB.ReadOnly = True
            StockID_TB.ForeColor = Color.Red

        ElseIf Edit_BTN.Text = "SAVE" Then
            If EmpID_TB.Text <> "" And StockPrice_TB.Text <> "" And ProdID_TB.Text <> "" And StockQuan_TB.Text <> "" And StockDate_TB.Text <> "" Then
                If IsNumeric(EmpID_TB.Text) And EmpID_TB.Text.Length = 4 Then
                    If IsNumeric(ProdID_TB.Text And ProdID_TB.Text.Length = 4) Then
                        If IsNumeric(StockPrice_TB.Text) Then

                            Edit_BTN.Text = "EDIT"
                            Edit_BTN.FillColor = Color.DarkOrchid
                            Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            StockID_TB.ForeColor = Color.white

                            Try
                                StockBindingSource.EndEdit()
                                StockTableAdapter.Update(_24_25_DatabaseDataSet.stock)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Enter Stock Price correctly")
                        End If
                    Else
                        MsgBox("Fill Product ID correctly")
                    End If
                Else
                    MsgBox("Fill Employee ID correctly")
                End If
            Else
                MsgBox("Fill All Details!")
            End If
        End If
    End Sub

    Private Sub Search_TB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Search_TB.TextChanged
        If IsNumeric(Search_TB.Text) Then
            StockBindingSource.Filter = "(Convert(sid,'System.String') LIKE '" & Search_TB.Text & "%')"
            If ProdID_TB.Text = "" Then
                StockBindingSource.Filter = "(Convert(pid,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
            If EmpID_TB.Text = "" Then
                StockBindingSource.Filter = "(Convert(eid,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
            If StockPrice_TB.Text = "" Then
                StockBindingSource.Filter = "(Convert(sprice,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
            If StockQuan_TB.Text = "" Then
                StockBindingSource.Filter = "(Convert(squan,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
        End If
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        StockReportForm.Show()
    End Sub
End Class