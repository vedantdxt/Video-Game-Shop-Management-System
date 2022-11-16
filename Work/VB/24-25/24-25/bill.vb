Public Class teguna
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim Tamt, Tquan, p1q, p2q, p3q, p4q, p5q, p6q As Integer
    Dim PrintForm1 As Object

    Private Sub bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()

        sql = "SELECT * FROM bill"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bill")
        For counter = 0 To ds.Tables("bill").Rows.Count - 1
            BillID_LB.Text = "900" & counter + 2
        Next

        Date_LB.Text = Date.Now.ToString("MM") & "/" & Date.Now.ToString("dd") & "/" & Date.Now.ToString("yyyy")
        con.Close()
        Label7.Text = "Shop No. 4, Phoenix Game Store," & vbNewLine & "Super Roadways, Coffee Lane," & vbNewLine & "Nashik - 422068" & vbNewLine & "Landline - (0253)-3693369" & vbNewLine & "Mobile No. - (+91)-9939699693" & vbNewLine & "E-mail - gamestore@phoenix.com" & vbNewLine & "Website - www.phoenixgamestore.com"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNew_BTN.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()

        Dim custID, empID, custflag, empflag As Integer
        custflag = -1
        empflag = -1
        custID = Val(InputBox("Enter Customer ID"))
        sql = "SELECT * FROM customer"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "customer")
        For counter = 0 To ds.Tables("customer").Rows.Count - 1
            If custID = ds.Tables("customer").Rows(counter).Item(0) Then
                CustID_LB.Text = custID
                CustName_LB.Text = ds.Tables("customer").Rows(counter).Item(1)
                CustCNO_LB.Text = ds.Tables("customer").Rows(counter).Item(3)

                custflag = 1
                Exit For
            End If
            custflag = 0
        Next

        If custflag = 0 Then
            MsgBox("Customer Not Found!")
        ElseIf custflag = 1 Then
            sql = "SELECT * FROM employee"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "employee")

            empID = Val(InputBox("Enter Employee ID"))
            For counter = 0 To ds.Tables("employee").Rows.Count - 1
                If empID = ds.Tables("employee").Rows(counter).Item(0) Then
                    EmpID_LB.Text = ds.Tables("employee").Rows(counter).Item(0)
                    AddProd_BTN.Visible = True
                    empflag = 1
                    Exit For
                End If
                empflag = 0
            Next
        End If

        If empflag = 0 Then
            MsgBox("Employee Not Found!")
        ElseIf empflag = 1 Then

        End If
        con.Close()
    End Sub

    Private Sub AddProd_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProd_BTN.Click
        Dim prodID, prodflag, num As Integer

        prodflag = -1
        prodID = Val(InputBox("Enter Product No."))

        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()

        sql = "SELECT * FROM product"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "product")

        For counter = 0 To ds.Tables("product").Rows.Count - 1
            If prodID = ds.Tables("product").Rows(counter).Item(0) Then
                MsgBox("Product Added")
                If ProdNo_LB1.Text = " " Then
                    ProdNo_LB1.Text = prodID
                    ProdName_LB1.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB1.Text = ds.Tables("product").Rows(counter).Item(6)
                    p1q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB1.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB1.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB1.Text = " "
                        ProdName_LB1.Text = " "
                        ProdPrice_LB1.Text = " "
                        ProdQuan_LB1.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB1.Text > p1q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB1.Text = " "
                            ProdName_LB1.Text = " "
                            ProdPrice_LB1.Text = " "
                            ProdQuan_LB1.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB1.Text = ProdPrice_LB1.Text * ProdQuan_LB1.Text
                        End If
                    End If

                ElseIf ProdNo_LB2.Text = " " Then
                    ProdNo_LB2.Text = prodID
                    ProdName_LB2.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB2.Text = ds.Tables("product").Rows(counter).Item(6)
                    p2q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB2.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB2.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB2.Text = " "
                        ProdName_LB2.Text = " "
                        ProdPrice_LB2.Text = " "
                        ProdQuan_LB2.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB2.Text > p2q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB2.Text = " "
                            ProdName_LB2.Text = " "
                            ProdPrice_LB2.Text = " "
                            ProdQuan_LB2.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB2.Text = ProdPrice_LB2.Text * ProdQuan_LB2.Text
                        End If
                    End If

                ElseIf ProdNo_LB3.Text = " " Then
                    ProdNo_LB3.Text = prodID
                    ProdName_LB3.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB3.Text = ds.Tables("product").Rows(counter).Item(6)
                    p3q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB3.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB3.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB3.Text = " "
                        ProdName_LB3.Text = " "
                        ProdPrice_LB3.Text = " "
                        ProdQuan_LB3.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB3.Text > p3q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB3.Text = " "
                            ProdName_LB3.Text = " "
                            ProdPrice_LB3.Text = " "
                            ProdQuan_LB3.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB3.Text = ProdPrice_LB3.Text * ProdQuan_LB3.Text
                        End If
                    End If
                ElseIf ProdNo_LB4.Text = " " Then
                    ProdNo_LB4.Text = prodID
                    ProdName_LB4.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB4.Text = ds.Tables("product").Rows(counter).Item(6)
                    p4q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB4.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB4.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB4.Text = " "
                        ProdName_LB4.Text = " "
                        ProdPrice_LB4.Text = " "
                        ProdQuan_LB4.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB4.Text > p4q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB4.Text = " "
                            ProdName_LB4.Text = " "
                            ProdPrice_LB4.Text = " "
                            ProdQuan_LB4.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB4.Text = ProdPrice_LB4.Text * ProdQuan_LB4.Text
                        End If
                    End If
                ElseIf ProdNo_LB5.Text = " " Then
                    ProdNo_LB5.Text = prodID
                    ProdName_LB5.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB5.Text = ds.Tables("product").Rows(counter).Item(6)
                    p5q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB5.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB5.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB5.Text = " "
                        ProdName_LB5.Text = " "
                        ProdPrice_LB5.Text = " "
                        ProdQuan_LB5.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB5.Text > p5q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB5.Text = " "
                            ProdName_LB5.Text = " "
                            ProdPrice_LB5.Text = " "
                            ProdQuan_LB5.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB5.Text = ProdPrice_LB5.Text * ProdQuan_LB5.Text
                        End If
                    End If
                ElseIf ProdNo_LB6.Text = " " Then
                    ProdNo_LB6.Text = prodID
                    ProdName_LB6.Text = ds.Tables("product").Rows(counter).Item(1)
                    ProdPrice_LB6.Text = ds.Tables("product").Rows(counter).Item(6)
                    p6q = ds.Tables("product").Rows(counter).Item(5)
                    ProdQuan_LB6.Text = Val(InputBox("Enter Product Quantity"))
                    If (ProdQuan_LB6.Text <= 0) Then
                        MsgBox("Quantity can't be less than 0 or 0")
                        ProdNo_LB6.Text = " "
                        ProdName_LB6.Text = " "
                        ProdPrice_LB6.Text = " "
                        ProdQuan_LB6.Text = " "
                        Exit Sub
                    Else
                        If (ProdQuan_LB6.Text > p6q) Then
                            MsgBox("Quantity entered is more than actual quantity available!")
                            ProdNo_LB6.Text = " "
                            ProdName_LB6.Text = " "
                            ProdPrice_LB6.Text = " "
                            ProdQuan_LB6.Text = " "
                            Exit Sub
                        Else
                            ProdTPrice_LB6.Text = ProdPrice_LB6.Text * ProdQuan_LB6.Text
                        End If
                    End If
                End If
                Cal_BTN.Visible = True
                prodflag = 1
                Exit For
            End If
            prodflag = 0
        Next

        If prodflag = 0 Then
            MsgBox("Product Not Found!")
        ElseIf prodflag = 1 Then
            con.Close()
        End If
    End Sub

    Private Sub Cal_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cal_BTN.Click
        GrandTotal_LB.Text = (Val(ProdTPrice_LB1.Text) + Val(ProdTPrice_LB2.Text) + Val(ProdTPrice_LB3.Text) + Val(ProdTPrice_LB4.Text) + Val(ProdTPrice_LB5.Text) + Val(ProdTPrice_LB6.Text))
        Tquan = (Val(ProdQuan_LB1.Text) + Val(ProdQuan_LB2.Text) + Val(ProdQuan_LB3.Text) + Val(ProdQuan_LB4.Text) + Val(ProdQuan_LB5.Text) + Val(ProdQuan_LB6.Text))
        TotalAmt_LB.Text = "₹" & GrandTotal_LB.Text
        Purchase_BTN.Visible = True
    End Sub

    Private Sub Purchase_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase_BTN.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()

        Dim InsertQuery As String
        InsertQuery = "INSERT INTO bill (bid,cid,billdate,billamt,quan,eid) VALUES (" & BillID_LB.Text & "," & CustID_LB.Text & "," & "6/21/2021" & "," & GrandTotal_LB.Text & "," & Tquan & "," & EmpID_LB.Text & ")"

        Dim cmd = New OleDb.OleDbCommand(InsertQuery, con)
        cmd.Parameters.AddWithValue("bid", BillID_LB.Text)
        cmd.Parameters.AddWithValue("cid", CustID_LB.Text)
        cmd.Parameters.AddWithValue("billdate", "6/21/2021")
        cmd.Parameters.AddWithValue("billamt", GrandTotal_LB.Text)
        cmd.Parameters.AddWithValue("quan", Tquan)
        cmd.Parameters.AddWithValue("eid", EmpID_LB.Text)
        cmd.ExecuteNonQuery()


        sql = "SELECT * FROM product"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "product")

        If ProdNo_LB1.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p1q - ProdQuan_LB1.Text & "' WHERE pid = " & ProdNo_LB1.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p1q - ProdQuan_LB1.Text & "' WHERE pid = " & ProdNo_LB1.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()

            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB1.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB1.Text)
            cmd2.ExecuteNonQuery()
        End If

        If ProdNo_LB2.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p2q - ProdQuan_LB2.Text & "' WHERE pid = " & ProdNo_LB2.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p2q - ProdQuan_LB2.Text & "' WHERE pid = " & ProdNo_LB2.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()

            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB2.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB2.Text)
            cmd2.ExecuteNonQuery()
        End If

        If ProdNo_LB3.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p3q - ProdQuan_LB3.Text & "' WHERE pid = " & ProdNo_LB3.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p3q - ProdQuan_LB3.Text & "' WHERE pid = " & ProdNo_LB3.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()

            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB3.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB3.Text)
            cmd2.ExecuteNonQuery()
        End If

        If ProdNo_LB4.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p4q - ProdQuan_LB4.Text & "' WHERE pid = " & ProdNo_LB4.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p4q - ProdQuan_LB4.Text & "' WHERE pid = " & ProdNo_LB4.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()

            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB4.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB4.Text)
            cmd2.ExecuteNonQuery()
        End If

        If ProdNo_LB5.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p5q - ProdQuan_LB5.Text & "' WHERE pid = " & ProdNo_LB5.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p5q - ProdQuan_LB5.Text & "' WHERE pid = " & ProdNo_LB5.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()

            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB5.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB5.Text)
            cmd2.ExecuteNonQuery()
        End If

        If ProdNo_LB6.Text <> " " Then
            Dim UpdateQuery As String
            UpdateQuery = "UPDATE product SET pavail = '" & p6q - ProdQuan_LB6.Text & "' WHERE pid = " & ProdNo_LB6.Text

            Dim cmd1 = New OleDb.OleDbCommand(UpdateQuery, con)
            cmd1.ExecuteNonQuery()

            Dim UpdateQuery2 As String
            UpdateQuery2 = "UPDATE stock SET squan = '" & p6q - ProdQuan_LB6.Text & "' WHERE pid = " & ProdNo_LB6.Text

            Dim cmd3 = New OleDb.OleDbCommand(UpdateQuery2, con)
            cmd3.ExecuteNonQuery()


            Dim InsertQuery2 As String
            InsertQuery2 = "INSERT INTO custprod (cid,pid) VALUES (" & CustID_LB.Text & "," & ProdNo_LB6.Text & ")"
            Dim cmd2 = New OleDb.OleDbCommand(InsertQuery2, con)
            cmd2.Parameters.AddWithValue("cid", CustID_LB.Text)
            cmd2.Parameters.AddWithValue("pid", ProdNo_LB6.Text)
            cmd2.ExecuteNonQuery()
        End If
        Print_BTN.Visible = True
        MsgBox("Purchase Successfull!")
        con.Close()

    End Sub

    Private Sub Search_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search_BTN.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()

        Dim billID, flag As Integer
        flag = 0
        billID = Val(InputBox("Enter Bill ID"))

        sql = "SELECT * FROM bill"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bill")
        For counter = 0 To ds.Tables("bill").Rows.Count - 1
            If billID = ds.Tables("bill").Rows(counter).Item(0) Then
                MsgBox("Bill ID - " & billID & vbNewLine & "Customer ID - " & ds.Tables("bill").Rows(counter).Item(1) & vbNewLine & "Date -" & ds.Tables("bill").Rows(counter).Item(2) & vbNewLine &
                       "Grand Total - " & "₹" & Val(ds.Tables("bill").Rows(counter).Item(3)) & vbNewLine & "Total Amount - " & "₹" & Val(ds.Tables("bill").Rows(counter).Item(3)) & vbNewLine &
                       "Product Quantity - " & ds.Tables("bill").Rows(counter).Item(4) & vbNewLine & "Billed by - " & ds.Tables("bill").Rows(counter).Item(5))
                flag = 1
                Exit For
            End If
        Next

        If flag = 0 Then
            MsgBox("Bill Not Found!")
        End If

        'If flag = 1 Then
        '    sql = "SELECT * FROM customer"
        '    da = New OleDb.OleDbDataAdapter(sql, con)
        '    da.Fill(ds, "customer")

        '    For counter = 0 To ds.Tables("customer").Rows.Count - 1
        '        If CustID_LB.Text = ds.Tables("customer").Rows(counter).Item(0) Then
        '            CustName_LB.Text = ds.Tables("customer").Rows(counter).Item(1)
        '            CustCNO_LB.Text = ds.Tables("customer").Rows(counter).Item(3)
        '        End If
        '    Next
        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Print_BTN.Click
        '    PrintDialog1.Document = PrintDocument1
        '    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        '    PrintDialog1.AllowSomePages = True

        '    If PrintDialog1.ShowDialog = DialogResult.OK Then
        '        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '        PrintDocument1.Print()
        '    End If
    End Sub
End Class