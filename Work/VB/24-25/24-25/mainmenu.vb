
Public Class mainmenu
    Dim rnd = New Random()
    Function backcolr()
        Home_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Emp_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Prod_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Cust_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Stock_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Bill_BTN.BackColor = Color.FromArgb(37, 39, 53)
        About_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Report_BTN.BackColor = Color.FromArgb(37, 39, 53)
        Return (0)
    End Function
    Function unloadform()
        about.Hide()
        cust.Hide()
        emp.Hide()
        prod.Hide()
        stock.Hide()
        report.Hide()
        teguna.Hide()
        Return (0)
    End Function

    Private Sub Home_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = True
        Home_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        cust.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        cust.TopLevel = False
        cust.TopMost = True
        MidPanel.Controls.Add(cust)
        cust.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.Home
        ActiveMenu_BTN.Text = "   Dashboard"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.Home
    End Sub

    Private Sub Prod_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prod_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Prod_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        prod.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        prod.TopLevel = False
        prod.TopMost = True
        MidPanel.Controls.Add(prod)
        prod.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        ActiveMenu_BTN.Text = "   Products"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        prod.Refresh()
    End Sub

    Private Sub Cust_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cust_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Cust_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        cust.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        cust.TopLevel = False
        cust.TopMost = True
        MidPanel.Controls.Add(cust)
        cust.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        ActiveMenu_BTN.Text = "   Customer"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.UserFriends
    End Sub

    Private Sub Emp_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Emp_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Emp_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        emp.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        emp.TopLevel = False
        emp.TopMost = True
        MidPanel.Controls.Add(emp)
        emp.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        ActiveMenu_BTN.Text = "   Employee"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
    End Sub

    Private Sub Stock_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Stock_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        stock.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        stock.TopLevel = False
        stock.TopMost = True
        MidPanel.Controls.Add(stock)
        stock.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.LayerGroup
        ActiveMenu_BTN.Text = "   Stock"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.LayerGroup
        stock.Refresh()
    End Sub

    Private Sub Bill_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bill_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Bill_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        teguna.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        teguna.TopLevel = False
        teguna.TopMost = True
        MidPanel.Controls.Add(teguna)
        teguna.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        ActiveMenu_BTN.Text = "   Bill"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
    End Sub

    Private Sub About_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        About_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        about.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        about.TopLevel = False
        about.TopMost = True
        MidPanel.Controls.Add(about)
        about.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        ActiveMenu_BTN.Text = "   About Us"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.AddressCard
    End Sub

    Private Sub Close_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_BTN.Click
        Me.Close()
    End Sub

    Private Sub mainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Date_LB.Text = Date.Now.ToString("dd")
        Month_LB.Text = Date.Now.ToString("MMMM")
        Year_LB.Text = Date.Now.ToString("yyyy")
        Day_LB.Text = Date.Now.ToString("dddd")

        Dim sum, cnt, cnt2 As Integer
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Work\VB\24-25\24-25 Database.accdb"
        con.Open()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        'Customer Count
        sql = "SELECT * FROM customer"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "customer")
        CustCounter_LB.Text = ds.Tables("customer").Rows.Count

        'Stock Count
        sql = "SELECT * FROM stock"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "stock")
        For counter = 0 To ds.Tables("stock").Rows.Count - 1
            sum = sum + ds.Tables("stock").Rows(counter).Item(3)
        Next
        StockLeft_CPB.Value = sum / (ds.Tables("stock").Rows.Count * 10) * 100
        'MsgBox(sum / (ds.Tables("stock").Rows.Count * 10) * 100)

        'Sales Count
        sql = "SELECT * FROM bill"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bill")
        For counter = 0 To ds.Tables("bill").Rows.Count - 1
            If ds.Tables("bill").Rows(counter).Item(2) = Month_LB.Text & "-" & Date_LB.Text & "-21" Then
                cnt = cnt + 1
            End If

            If ds.Tables("bill").Rows(counter).Item(2) = Month_LB.Text & "-" & Date_LB.Text - 1 & "-21" Then
                cnt2 = cnt2 + 1
            End If
        Next
        TodaySalesPB.Value = cnt
        YesterdaySalesPB.Value = cnt2
        AverageSalesPB.Value = cnt + cnt2 / ds.Tables("bill").Rows.Count

        'Revenue Count
        Dim revenue As Integer
        For counter = 0 To ds.Tables("bill").Rows.Count - 1
            revenue = revenue + ds.Tables("bill").Rows(counter).Item(3)
        Next
        Revenue_LB.Text = "₹" & revenue

        'Order Count
        Dim order As Integer
        For counter = 0 To ds.Tables("bill").Rows.Count - 1
            order = order + 1
        Next
        Orders_LB.Text = order

        'Staff Count
        sql = "SELECT * FROM employee"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "employee")
        Dim staff As Integer
        For counter = 0 To ds.Tables("employee").Rows.Count - 1
            staff = staff + 1
        Next
        StaffToday_CPB.Value = staff / 10 * 100

        con.Close()
    End Sub

    Private Sub Logout_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout_BTN.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Report_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report_BTN.Click
        Dim un, col As Integer
        col = backcolr()
        Dashboard_Panel.Visible = False
        Report_BTN.BackColor = Color.FromArgb(47, 55, 74)
        un = unloadform()
        report.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        report.TopLevel = False
        report.TopMost = True
        MidPanel.Controls.Add(report)
        report.Show()
        ActiveMenu_BTN.IconChar = FontAwesome.Sharp.IconChar.Readme
        ActiveMenu_BTN.Text = "   Reports"
        ActiveIcon_PB.IconChar = FontAwesome.Sharp.IconChar.Readme
    End Sub
End Class