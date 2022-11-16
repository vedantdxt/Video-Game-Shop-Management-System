Public Class prod
    Dim rnd = New Random()

    Private Sub prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_24_25_DatabaseDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me._24_25_DatabaseDataSet.product)
    End Sub

    Private Sub Add_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_BTN.Click
        Dim location As String
        If Add_BTN.Text = "ADD" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")
            ProductBindingSource.AddNew()

            Add_BTN.Text = "SAVE"
            Add_BTN.FillColor = Color.SpringGreen
            Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            ProdID_TB.ReadOnly = True
            ProdID_TB.Text = "20" & ProductBindingSource.Count
            ProdID_TB.ForeColor = Color.SpringGreen

        ElseIf Add_BTN.Text = "SAVE" Then
            If ProdTitle_TB.Text <> "" And ProdGerne_TB.Text <> "" And ProdAvail_TB.Text <> "" And ProdPrice_TB.Text <> "" And ProdPub_TB.Text <> "" And ProdYear_TB.Text <> "" Then
                location = InputBox("Enter Location of Picture", "Location")
                PictureBox1.ImageLocation = location
                Try
                    ProductBindingSource.EndEdit()
                    ProductTableAdapter.Update(_24_25_DatabaseDataSet.product)
                    MsgBox("Record Saved!")

                Catch
                    Add_BTN.Text = "ADD"
                    Add_BTN.FillColor = Color.Crimson
                    Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                    ProdID_TB.ForeColor = Color.White
                    MsgBox("Error on Saving Record")
                    Exit Sub

                End Try
                Add_BTN.Text = "ADD"
                Add_BTN.FillColor = Color.Crimson
                Add_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                ProdID_TB.ForeColor = Color.White

            Else
                MsgBox("Fill All Details!")
            End If
        End If
    End Sub

    Private Sub Edit_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_BTN.Click
        Dim location As String
        If Edit_BTN.Text = "EDIT" Then
            Dim dateAsString = DateTime.Now.ToString("dd/MM/yyyy")

            Edit_BTN.Text = "SAVE"
            Edit_BTN.FillColor = Color.SpringGreen
            Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
            ProdID_TB.ReadOnly = True
            ProdID_TB.ForeColor = Color.Red
            location = InputBox("Enter Location of Picture", "Location")
            PictureBox1.ImageLocation = location

        ElseIf Edit_BTN.Text = "SAVE" Then
            If ProdTitle_TB.Text <> "" And ProdGerne_TB.Text <> "" And ProdAvail_TB.Text <> "" And ProdPrice_TB.Text <> "" And ProdPub_TB.Text <> "" And ProdYear_TB.Text <> "" Then
                Try
                    ProductBindingSource.EndEdit()
                    ProductTableAdapter.Update(_24_25_DatabaseDataSet.product)
                    MsgBox("Record Saved!")

                Catch
                    Edit_BTN.Text = "EDIT"
                    Edit_BTN.FillColor = Color.Crimson
                    Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                    ProdID_TB.ForeColor = Color.White
                    MsgBox("Error on Saving Record")
                    Exit Sub

                End Try
                Edit_BTN.Text = "EDIT"
                Edit_BTN.FillColor = Color.Crimson
                Edit_BTN.FillColor2 = Color.FromArgb(54, 57, 76)
                ProdID_TB.ForeColor = Color.White

            Else
                MsgBox("Fill all details!")
            End If
        End If
    End Sub

    Private Sub Prev_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev_BTN.Click
        ProductBindingSource.MovePrevious()
    End Sub

    Private Sub First_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_BTN.Click
        ProductBindingSource.MoveFirst()
    End Sub

    Private Sub Last_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_BTN.Click
        ProductBindingSource.MoveLast()
    End Sub

    Private Sub Delete_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_BTN.Click
        Dim choice As Integer
        choice = MsgBox("Do you really want to Delete selected record?", MsgBoxStyle.YesNo, "Delete")
        If choice = 6 Then
            ProductBindingSource.RemoveCurrent()
            ProductTableAdapter.Update(_24_25_DatabaseDataSet.product)
        End If
    End Sub

    Private Sub Next_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_BTN.Click
        ProductBindingSource.MoveNext()
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        ProdReportForm.Show()
    End Sub
End Class