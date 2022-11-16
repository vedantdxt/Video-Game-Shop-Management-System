Public Class cust
    Private Sub cust_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._24_25_DatabaseDataSet.customer)
    End Sub

    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        CustomerBindingSource.MoveNext()
    End Sub

    Private Sub Prev_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev_BTN.Click
        CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub First_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_BTN.Click
        CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub Last_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_BTN.Click
        CustomerBindingSource.MoveLast()
    End Sub

    Private Sub Delete_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_BTN.Click
        Dim choice As Integer
        choice = MsgBox("Do you really want to Delete selected record?", MsgBoxStyle.YesNo, "Delete")
        If choice = 6 Then
            CustomerBindingSource.RemoveCurrent()
            CustomerTableAdapter.Update(_24_25_DatabaseDataSet.customer)
        End If
    End Sub

    Private Sub Add_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_BTN.Click
        If Add_BTN.Text = "ADD" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")
            CustomerBindingSource.AddNew()

            Add_BTN.Text = "SAVE"
            Add_BTN.FillColor = Color.SpringGreen
            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            CustID_TB.ReadOnly = True
            CustID_TB.Text = "1" & CustomerBindingSource.Count + 1
            CustID_TB.ForeColor = Color.Red

            DOJ_TB.Text = DateTime.Now.ToString("dd/MM/yyyy")
            DOJ_TB.ReadOnly = True
            DOJ_TB.ForeColor = Color.Red
        ElseIf Add_BTN.Text = "SAVE" Then
            If CustName_TB.Text <> "" And CustAddr_TB.Text <> "" And CustCNO_TB.Text <> "" And CustEMail_TB.Text <> "" And CustRegBy_TB.Text <> "" Then
                If IsNumeric(CustCNO_TB.Text) And CustCNO_TB.Text.Length = 9 Then
                    If IsNumeric(CustRegBy_TB.Text) And CustRegBy_TB.Text.Length = 4 Then
                        If CustEMail_TB.Text.Contains("@") And CustEMail_TB.Text.Contains(".") Then

                            Add_BTN.Text = "ADD"
                            Add_BTN.FillColor = Color.DarkOrchid
                            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            CustID_TB.ForeColor = Color.White
                            DOJ_TB.ForeColor = Color.White

                            Try
                                CustomerBindingSource.EndEdit()
                                CustomerTableAdapter.Update(_24_25_DatabaseDataSet.customer)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Fill Email ID correctly")
                        End If
                    Else
                        MsgBox("Fill Employee ID correctly")
                    End If
                Else
                    MsgBox("Fill Contact Number correctly")
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
            CustID_TB.ReadOnly = True
            CustID_TB.ForeColor = Color.Red

            DOJ_TB.ReadOnly = True
            DOJ_TB.ForeColor = Color.Red
        ElseIf Edit_BTN.Text = "SAVE" Then
            If CustName_TB.Text <> "" And CustAddr_TB.Text <> "" And CustCNO_TB.Text <> "" And CustEMail_TB.Text <> "" And CustRegBy_TB.Text <> "" Then
                If IsNumeric(CustCNO_TB.Text) And CustCNO_TB.Text.Length = 9 Then
                    If IsNumeric(CustRegBy_TB.Text) And CustRegBy_TB.Text.Length = 4 Then
                        If CustEMail_TB.Text.Contains("@") And CustEMail_TB.Text.Contains(".") Then

                            Edit_BTN.Text = "EDIT"
                            Edit_BTN.FillColor = Color.DarkOrchid
                            Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            CustID_TB.ForeColor = Color.White
                            DOJ_TB.ForeColor = Color.White

                            Try
                                CustomerBindingSource.EndEdit()
                                CustomerTableAdapter.Update(_24_25_DatabaseDataSet.customer)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Fill Email ID correctly")
                        End If
                    Else
                        MsgBox("Fill Employee ID correctly")
                    End If
                Else
                    MsgBox("Fill Contact Number correctly")
                End If
            Else
                MsgBox("Fill All Details!")
            End If
        End If
    End Sub

    Private Sub Search_TB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Search_TB.GotFocus
        Delete_BTN.Visible = False
    End Sub

    Private Sub Search_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CustomerBindingSource.Filter = "* LIKE '" & Search_TB.Text & "%'"
    End Sub

    Private Sub Search_TB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Search_TB.TextChanged
        CustomerBindingSource.Filter = "cname LIKE '" & Search_TB.Text & "%'"
        If CustID_TB.Text = "" Then
            CustomerBindingSource.Filter = "caddr LIKE '" & Search_TB.Text & "%'"
            If CustEMail_TB.Text = "" Then
                CustomerBindingSource.Filter = "custmail LIKE '" & Search_TB.Text & "%'"
            End If
        End If

        If IsNumeric(Search_TB.Text) Then
            CustomerBindingSource.Filter = "(Convert(cid,'System.String') LIKE '" & Search_TB.Text & "%')"
            If CustID_TB.Text = "" Then
                CustomerBindingSource.Filter = "(Convert(eid,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
            If CustCNO_TB.Text = "" Then
                CustomerBindingSource.Filter = "(Convert(cphno,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
        End If
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        CustReportForm.Show()
    End Sub
End Class
