Public Class emp
    Private Sub emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me._24_25_DatabaseDataSet.employee)
    End Sub
    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        EmployeeBindingSource.MoveNext()
    End Sub
    Private Sub Delete_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_BTN.Click
        Dim choice As Integer
        choice = MsgBox("Do you really want to Delete selected record?", MsgBoxStyle.YesNo, "Delete")
        If choice = 6 Then
            EmployeeBindingSource.RemoveCurrent()
            EmployeeTableAdapter.Update(_24_25_DatabaseDataSet.employee)
        End If
    End Sub

    Private Sub Add_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_BTN.Click
        If Add_BTN.Text = "ADD" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")
            EmployeeBindingSource.AddNew()

            Add_BTN.Text = "SAVE"
            Add_BTN.FillColor = Color.SpringGreen
            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            EmpID_TB.ReadOnly = True
            EmpID_TB.Text = "10" & EmployeeBindingSource.Count
            EmpID_TB.ForeColor = Color.Red

            DOJ_TB.Text = DateTime.Now.ToString("dd/MM/yyyy")
            DOJ_TB.ReadOnly = True
            DOJ_TB.ForeColor = Color.Red
        ElseIf Add_BTN.Text = "SAVE" Then
            If EmpName_TB.Text <> "" And EmpAddr_TB.Text <> "" And EmpCNO_TB.Text <> "" And EmpEMail_TB.Text <> "" And EmpPost_TB.Text <> "" And DOB_TB.Text <> "" And EmpSal_TB.Text <> "" Then
                If IsNumeric(EmpCNO_TB.Text) And EmpCNO_TB.Text.Length = 9 Then
                    If EmpEMail_TB.Text.Contains("@") And EmpEMail_TB.Text.Contains(".") Then
                        If IsNumeric(EmpSal_TB.Text) Then

                            Add_BTN.Text = "ADD"
                            Add_BTN.FillColor = Color.DarkOrchid
                            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            EmpID_TB.ForeColor = Color.White
                            DOJ_TB.ForeColor = Color.White

                            Try
                                EmployeeBindingSource.EndEdit()
                                EmployeeTableAdapter.Update(_24_25_DatabaseDataSet.employee)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Enter Salary correctly")
                        End If
                    Else
                        MsgBox("Fill Email ID correctly")
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
            EmpID_TB.ReadOnly = True
            EmpID_TB.ForeColor = Color.Red

            DOJ_TB.ReadOnly = True
            DOJ_TB.ForeColor = Color.Red
        ElseIf Edit_BTN.Text = "SAVE" Then
            If EmpName_TB.Text <> "" And EmpAddr_TB.Text <> "" And EmpCNO_TB.Text <> "" And EmpEMail_TB.Text <> "" And EmpPost_TB.Text <> "" And DOB_TB.Text <> "" And EmpSal_TB.Text <> "" Then
                If IsNumeric(EmpCNO_TB.Text) And EmpCNO_TB.Text.Length = 9 Then
                    If EmpEMail_TB.Text.Contains("@") And EmpEMail_TB.Text.Contains(".") Then
                        If IsNumeric(EmpSal_TB.Text) Then

                            Edit_BTN.Text = "EDIT"
                            Edit_BTN.FillColor = Color.DarkOrchid
                            Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                            EmpID_TB.ForeColor = Color.white
                            DOJ_TB.ForeColor = Color.white

                            Try
                                EmployeeBindingSource.EndEdit()
                                EmployeeTableAdapter.Update(_24_25_DatabaseDataSet.employee)
                                MsgBox("Record Saved!")

                            Catch
                                MsgBox("Error on Saving Record")
                                Exit Sub

                            End Try

                        Else
                            MsgBox("Enter Salary correctly")
                        End If
                    Else
                        MsgBox("Fill Email ID correctly")
                    End If
                Else
                    MsgBox("Fill Contact Number correctly")
                End If
            Else
                MsgBox("Fill All Details!")
            End If
        End If
    End Sub

    Private Sub Prev_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev_BTN.Click
        EmployeeBindingSource.MovePrevious()
    End Sub

    Private Sub First_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_BTN.Click
        EmployeeBindingSource.MoveFirst()
    End Sub

    Private Sub Last_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_BTN.Click
        EmployeeBindingSource.MoveLast()
    End Sub

    Private Sub Search_TB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Search_TB.TextChanged
        EmployeeBindingSource.Filter = "ename LIKE '" & Search_TB.Text & "%'"
        If EmpID_TB.Text = "" Then
            EmployeeBindingSource.Filter = "eaddr LIKE '" & Search_TB.Text & "%'"
            If EmpAddr_TB.Text = "" Then
                EmployeeBindingSource.Filter = "empmail LIKE '" & Search_TB.Text & "%'"
            End If
            If EmpPost_TB.Text = "" Then
                EmployeeBindingSource.Filter = "epost LIKE '" & Search_TB.Text & "%'"
            End If
        End If
        If IsNumeric(Search_TB.Text) Then
            EmployeeBindingSource.Filter = "(Convert(eid,'System.String') LIKE '" & Search_TB.Text & "%')"
            If EmpCNO_TB.Text = "" Then
                EmployeeBindingSource.Filter = "(Convert(ephno,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
            If EmpSal_TB.Text = "" Then
                EmployeeBindingSource.Filter = "(Convert(esal,'System.String') LIKE '" & Search_TB.Text & "%')"
            End If
        End If
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        EmpReportForm.Show()
    End Sub
End Class