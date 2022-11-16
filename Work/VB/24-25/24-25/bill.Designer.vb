<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teguna
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.EmpID_LB = New System.Windows.Forms.Label()
        Me.Date_LB = New System.Windows.Forms.Label()
        Me.BillID_LB = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CustCNO_LB = New System.Windows.Forms.Label()
        Me.CustName_LB = New System.Windows.Forms.Label()
        Me.CustID_LB = New System.Windows.Forms.Label()
        Me.CustID_Title_LB = New System.Windows.Forms.Label()
        Me.CustName_Title_LB = New System.Windows.Forms.Label()
        Me.CustCNO_Title_LB = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProdNo_LB1 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB5 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB4 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB3 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB2 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB1 = New System.Windows.Forms.Label()
        Me.ProdTPrice_LB6 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB5 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB4 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB3 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB2 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB1 = New System.Windows.Forms.Label()
        Me.ProdQuan_LB6 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB5 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB4 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB3 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB2 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB1 = New System.Windows.Forms.Label()
        Me.ProdPrice_LB6 = New System.Windows.Forms.Label()
        Me.ProdName_LB5 = New System.Windows.Forms.Label()
        Me.ProdName_LB4 = New System.Windows.Forms.Label()
        Me.ProdName_LB3 = New System.Windows.Forms.Label()
        Me.ProdName_LB2 = New System.Windows.Forms.Label()
        Me.ProdName_LB1 = New System.Windows.Forms.Label()
        Me.ProdName_LB6 = New System.Windows.Forms.Label()
        Me.ProdNo_LB5 = New System.Windows.Forms.Label()
        Me.ProdNo_LB4 = New System.Windows.Forms.Label()
        Me.ProdNo_LB3 = New System.Windows.Forms.Label()
        Me.ProdNo_LB2 = New System.Windows.Forms.Label()
        Me.ProdNo_LB6 = New System.Windows.Forms.Label()
        Me.GrandTotal_LB = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CreateNew_BTN = New System.Windows.Forms.Button()
        Me.AddProd_BTN = New System.Windows.Forms.Button()
        Me.Cal_BTN = New System.Windows.Forms.Button()
        Me.Purchase_BTN = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalAmt_LB = New System.Windows.Forms.Label()
        Me.Search_BTN = New System.Windows.Forms.Button()
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.BillTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.billTableAdapter()
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Print_BTN = New System.Windows.Forms.Button()
        Me.PrintAction = New System.Windows.Forms.PrintDialog()
        Me.PrintBill = New System.Drawing.Printing.PrintDocument()
        Me.Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.EmpID_LB)
        Me.Panel.Controls.Add(Me.Date_LB)
        Me.Panel.Controls.Add(Me.BillID_LB)
        Me.Panel.Controls.Add(Me.Label20)
        Me.Panel.Controls.Add(Me.Panel4)
        Me.Panel.Controls.Add(Me.Panel3)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Location = New System.Drawing.Point(31, 24)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1141, 222)
        Me.Panel.TabIndex = 0
        '
        'EmpID_LB
        '
        Me.EmpID_LB.AutoSize = True
        Me.EmpID_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID_LB.Location = New System.Drawing.Point(826, 184)
        Me.EmpID_LB.Name = "EmpID_LB"
        Me.EmpID_LB.Size = New System.Drawing.Size(22, 17)
        Me.EmpID_LB.TabIndex = 15
        Me.EmpID_LB.Text = "- -"
        '
        'Date_LB
        '
        Me.Date_LB.AutoSize = True
        Me.Date_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_LB.Location = New System.Drawing.Point(118, 184)
        Me.Date_LB.Name = "Date_LB"
        Me.Date_LB.Size = New System.Drawing.Size(76, 17)
        Me.Date_LB.TabIndex = 14
        Me.Date_LB.Text = "00/00/0000"
        '
        'BillID_LB
        '
        Me.BillID_LB.AutoSize = True
        Me.BillID_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillID_LB.Location = New System.Drawing.Point(95, 28)
        Me.BillID_LB.Name = "BillID_LB"
        Me.BillID_LB.Size = New System.Drawing.Size(36, 17)
        Me.BillID_LB.TabIndex = 13
        Me.BillID_LB.Text = "0000"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(734, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 21)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "BILLED BY :"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(829, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(222, 140)
        Me.Panel4.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PHOENIX GAME STORE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address Line 1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CustCNO_LB)
        Me.Panel3.Controls.Add(Me.CustName_LB)
        Me.Panel3.Controls.Add(Me.CustID_LB)
        Me.Panel3.Controls.Add(Me.CustID_Title_LB)
        Me.Panel3.Controls.Add(Me.CustName_Title_LB)
        Me.Panel3.Controls.Add(Me.CustCNO_Title_LB)
        Me.Panel3.Location = New System.Drawing.Point(72, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 96)
        Me.Panel3.TabIndex = 10
        '
        'CustCNO_LB
        '
        Me.CustCNO_LB.AutoSize = True
        Me.CustCNO_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustCNO_LB.Location = New System.Drawing.Point(148, 63)
        Me.CustCNO_LB.Name = "CustCNO_LB"
        Me.CustCNO_LB.Size = New System.Drawing.Size(31, 17)
        Me.CustCNO_LB.TabIndex = 7
        Me.CustCNO_LB.Text = "- - -"
        '
        'CustName_LB
        '
        Me.CustName_LB.AutoSize = True
        Me.CustName_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustName_LB.Location = New System.Drawing.Point(148, 41)
        Me.CustName_LB.Name = "CustName_LB"
        Me.CustName_LB.Size = New System.Drawing.Size(31, 17)
        Me.CustName_LB.TabIndex = 6
        Me.CustName_LB.Text = "- - -"
        '
        'CustID_LB
        '
        Me.CustID_LB.AutoSize = True
        Me.CustID_LB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustID_LB.Location = New System.Drawing.Point(148, 19)
        Me.CustID_LB.Name = "CustID_LB"
        Me.CustID_LB.Size = New System.Drawing.Size(31, 17)
        Me.CustID_LB.TabIndex = 5
        Me.CustID_LB.Text = "- - -"
        '
        'CustID_Title_LB
        '
        Me.CustID_Title_LB.AutoSize = True
        Me.CustID_Title_LB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustID_Title_LB.Location = New System.Drawing.Point(11, 16)
        Me.CustID_Title_LB.Name = "CustID_Title_LB"
        Me.CustID_Title_LB.Size = New System.Drawing.Size(104, 21)
        Me.CustID_Title_LB.TabIndex = 2
        Me.CustID_Title_LB.Text = "Customer ID :"
        '
        'CustName_Title_LB
        '
        Me.CustName_Title_LB.AutoSize = True
        Me.CustName_Title_LB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustName_Title_LB.Location = New System.Drawing.Point(11, 38)
        Me.CustName_Title_LB.Name = "CustName_Title_LB"
        Me.CustName_Title_LB.Size = New System.Drawing.Size(131, 21)
        Me.CustName_Title_LB.TabIndex = 3
        Me.CustName_Title_LB.Text = "Customer Name :"
        '
        'CustCNO_Title_LB
        '
        Me.CustCNO_Title_LB.AutoSize = True
        Me.CustCNO_Title_LB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustCNO_Title_LB.Location = New System.Drawing.Point(11, 60)
        Me.CustCNO_Title_LB.Name = "CustCNO_Title_LB"
        Me.CustCNO_Title_LB.Size = New System.Drawing.Size(98, 21)
        Me.CustCNO_Title_LB.TabIndex = 4
        Me.CustCNO_Title_LB.Text = "Contact No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "BILL DATE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BILL ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(482, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVOICE"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ProdNo_LB1)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB5)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB4)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB3)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB2)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB1)
        Me.Panel2.Controls.Add(Me.ProdTPrice_LB6)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB5)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB4)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB3)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB2)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB1)
        Me.Panel2.Controls.Add(Me.ProdQuan_LB6)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB5)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB4)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB3)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB2)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB1)
        Me.Panel2.Controls.Add(Me.ProdPrice_LB6)
        Me.Panel2.Controls.Add(Me.ProdName_LB5)
        Me.Panel2.Controls.Add(Me.ProdName_LB4)
        Me.Panel2.Controls.Add(Me.ProdName_LB3)
        Me.Panel2.Controls.Add(Me.ProdName_LB2)
        Me.Panel2.Controls.Add(Me.ProdName_LB1)
        Me.Panel2.Controls.Add(Me.ProdName_LB6)
        Me.Panel2.Controls.Add(Me.ProdNo_LB5)
        Me.Panel2.Controls.Add(Me.ProdNo_LB4)
        Me.Panel2.Controls.Add(Me.ProdNo_LB3)
        Me.Panel2.Controls.Add(Me.ProdNo_LB2)
        Me.Panel2.Controls.Add(Me.ProdNo_LB6)
        Me.Panel2.Controls.Add(Me.GrandTotal_LB)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(31, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 310)
        Me.Panel2.TabIndex = 1
        '
        'ProdNo_LB1
        '
        Me.ProdNo_LB1.AutoSize = True
        Me.ProdNo_LB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB1.Location = New System.Drawing.Point(38, 63)
        Me.ProdNo_LB1.Name = "ProdNo_LB1"
        Me.ProdNo_LB1.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB1.TabIndex = 47
        Me.ProdNo_LB1.Text = " "
        '
        'ProdTPrice_LB5
        '
        Me.ProdTPrice_LB5.AutoSize = True
        Me.ProdTPrice_LB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB5.Location = New System.Drawing.Point(1037, 195)
        Me.ProdTPrice_LB5.Name = "ProdTPrice_LB5"
        Me.ProdTPrice_LB5.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB5.TabIndex = 46
        Me.ProdTPrice_LB5.Text = " "
        '
        'ProdTPrice_LB4
        '
        Me.ProdTPrice_LB4.AutoSize = True
        Me.ProdTPrice_LB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB4.Location = New System.Drawing.Point(1037, 162)
        Me.ProdTPrice_LB4.Name = "ProdTPrice_LB4"
        Me.ProdTPrice_LB4.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB4.TabIndex = 45
        Me.ProdTPrice_LB4.Text = " "
        '
        'ProdTPrice_LB3
        '
        Me.ProdTPrice_LB3.AutoSize = True
        Me.ProdTPrice_LB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB3.Location = New System.Drawing.Point(1037, 129)
        Me.ProdTPrice_LB3.Name = "ProdTPrice_LB3"
        Me.ProdTPrice_LB3.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB3.TabIndex = 44
        Me.ProdTPrice_LB3.Text = " "
        '
        'ProdTPrice_LB2
        '
        Me.ProdTPrice_LB2.AutoSize = True
        Me.ProdTPrice_LB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB2.Location = New System.Drawing.Point(1037, 96)
        Me.ProdTPrice_LB2.Name = "ProdTPrice_LB2"
        Me.ProdTPrice_LB2.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB2.TabIndex = 43
        Me.ProdTPrice_LB2.Text = " "
        '
        'ProdTPrice_LB1
        '
        Me.ProdTPrice_LB1.AutoSize = True
        Me.ProdTPrice_LB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB1.Location = New System.Drawing.Point(1037, 63)
        Me.ProdTPrice_LB1.Name = "ProdTPrice_LB1"
        Me.ProdTPrice_LB1.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB1.TabIndex = 42
        Me.ProdTPrice_LB1.Text = " "
        '
        'ProdTPrice_LB6
        '
        Me.ProdTPrice_LB6.AutoSize = True
        Me.ProdTPrice_LB6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTPrice_LB6.Location = New System.Drawing.Point(1037, 228)
        Me.ProdTPrice_LB6.Name = "ProdTPrice_LB6"
        Me.ProdTPrice_LB6.Size = New System.Drawing.Size(14, 21)
        Me.ProdTPrice_LB6.TabIndex = 41
        Me.ProdTPrice_LB6.Text = " "
        '
        'ProdQuan_LB5
        '
        Me.ProdQuan_LB5.AutoSize = True
        Me.ProdQuan_LB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB5.Location = New System.Drawing.Point(915, 195)
        Me.ProdQuan_LB5.Name = "ProdQuan_LB5"
        Me.ProdQuan_LB5.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB5.TabIndex = 40
        Me.ProdQuan_LB5.Text = " "
        '
        'ProdQuan_LB4
        '
        Me.ProdQuan_LB4.AutoSize = True
        Me.ProdQuan_LB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB4.Location = New System.Drawing.Point(915, 162)
        Me.ProdQuan_LB4.Name = "ProdQuan_LB4"
        Me.ProdQuan_LB4.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB4.TabIndex = 39
        Me.ProdQuan_LB4.Text = " "
        '
        'ProdQuan_LB3
        '
        Me.ProdQuan_LB3.AutoSize = True
        Me.ProdQuan_LB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB3.Location = New System.Drawing.Point(915, 129)
        Me.ProdQuan_LB3.Name = "ProdQuan_LB3"
        Me.ProdQuan_LB3.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB3.TabIndex = 38
        Me.ProdQuan_LB3.Text = " "
        '
        'ProdQuan_LB2
        '
        Me.ProdQuan_LB2.AutoSize = True
        Me.ProdQuan_LB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB2.Location = New System.Drawing.Point(915, 96)
        Me.ProdQuan_LB2.Name = "ProdQuan_LB2"
        Me.ProdQuan_LB2.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB2.TabIndex = 37
        Me.ProdQuan_LB2.Text = " "
        '
        'ProdQuan_LB1
        '
        Me.ProdQuan_LB1.AutoSize = True
        Me.ProdQuan_LB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB1.Location = New System.Drawing.Point(915, 63)
        Me.ProdQuan_LB1.Name = "ProdQuan_LB1"
        Me.ProdQuan_LB1.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB1.TabIndex = 36
        Me.ProdQuan_LB1.Text = " "
        '
        'ProdQuan_LB6
        '
        Me.ProdQuan_LB6.AutoSize = True
        Me.ProdQuan_LB6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQuan_LB6.Location = New System.Drawing.Point(915, 228)
        Me.ProdQuan_LB6.Name = "ProdQuan_LB6"
        Me.ProdQuan_LB6.Size = New System.Drawing.Size(14, 21)
        Me.ProdQuan_LB6.TabIndex = 35
        Me.ProdQuan_LB6.Text = " "
        '
        'ProdPrice_LB5
        '
        Me.ProdPrice_LB5.AutoSize = True
        Me.ProdPrice_LB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB5.Location = New System.Drawing.Point(812, 195)
        Me.ProdPrice_LB5.Name = "ProdPrice_LB5"
        Me.ProdPrice_LB5.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB5.TabIndex = 34
        Me.ProdPrice_LB5.Text = " "
        '
        'ProdPrice_LB4
        '
        Me.ProdPrice_LB4.AutoSize = True
        Me.ProdPrice_LB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB4.Location = New System.Drawing.Point(812, 162)
        Me.ProdPrice_LB4.Name = "ProdPrice_LB4"
        Me.ProdPrice_LB4.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB4.TabIndex = 33
        Me.ProdPrice_LB4.Text = " "
        '
        'ProdPrice_LB3
        '
        Me.ProdPrice_LB3.AutoSize = True
        Me.ProdPrice_LB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB3.Location = New System.Drawing.Point(812, 129)
        Me.ProdPrice_LB3.Name = "ProdPrice_LB3"
        Me.ProdPrice_LB3.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB3.TabIndex = 32
        Me.ProdPrice_LB3.Text = " "
        '
        'ProdPrice_LB2
        '
        Me.ProdPrice_LB2.AutoSize = True
        Me.ProdPrice_LB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB2.Location = New System.Drawing.Point(812, 96)
        Me.ProdPrice_LB2.Name = "ProdPrice_LB2"
        Me.ProdPrice_LB2.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB2.TabIndex = 31
        Me.ProdPrice_LB2.Text = " "
        '
        'ProdPrice_LB1
        '
        Me.ProdPrice_LB1.AutoSize = True
        Me.ProdPrice_LB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB1.Location = New System.Drawing.Point(812, 63)
        Me.ProdPrice_LB1.Name = "ProdPrice_LB1"
        Me.ProdPrice_LB1.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB1.TabIndex = 30
        Me.ProdPrice_LB1.Text = " "
        '
        'ProdPrice_LB6
        '
        Me.ProdPrice_LB6.AutoSize = True
        Me.ProdPrice_LB6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_LB6.Location = New System.Drawing.Point(812, 228)
        Me.ProdPrice_LB6.Name = "ProdPrice_LB6"
        Me.ProdPrice_LB6.Size = New System.Drawing.Size(14, 21)
        Me.ProdPrice_LB6.TabIndex = 29
        Me.ProdPrice_LB6.Text = " "
        '
        'ProdName_LB5
        '
        Me.ProdName_LB5.AutoSize = True
        Me.ProdName_LB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB5.Location = New System.Drawing.Point(190, 195)
        Me.ProdName_LB5.Name = "ProdName_LB5"
        Me.ProdName_LB5.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB5.TabIndex = 28
        Me.ProdName_LB5.Text = " "
        '
        'ProdName_LB4
        '
        Me.ProdName_LB4.AutoSize = True
        Me.ProdName_LB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB4.Location = New System.Drawing.Point(190, 162)
        Me.ProdName_LB4.Name = "ProdName_LB4"
        Me.ProdName_LB4.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB4.TabIndex = 27
        Me.ProdName_LB4.Text = " "
        '
        'ProdName_LB3
        '
        Me.ProdName_LB3.AutoSize = True
        Me.ProdName_LB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB3.Location = New System.Drawing.Point(190, 129)
        Me.ProdName_LB3.Name = "ProdName_LB3"
        Me.ProdName_LB3.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB3.TabIndex = 26
        Me.ProdName_LB3.Text = " "
        '
        'ProdName_LB2
        '
        Me.ProdName_LB2.AutoSize = True
        Me.ProdName_LB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB2.Location = New System.Drawing.Point(190, 96)
        Me.ProdName_LB2.Name = "ProdName_LB2"
        Me.ProdName_LB2.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB2.TabIndex = 25
        Me.ProdName_LB2.Text = " "
        '
        'ProdName_LB1
        '
        Me.ProdName_LB1.AutoSize = True
        Me.ProdName_LB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB1.Location = New System.Drawing.Point(190, 63)
        Me.ProdName_LB1.Name = "ProdName_LB1"
        Me.ProdName_LB1.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB1.TabIndex = 24
        Me.ProdName_LB1.Text = " "
        '
        'ProdName_LB6
        '
        Me.ProdName_LB6.AutoSize = True
        Me.ProdName_LB6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName_LB6.Location = New System.Drawing.Point(190, 228)
        Me.ProdName_LB6.Name = "ProdName_LB6"
        Me.ProdName_LB6.Size = New System.Drawing.Size(14, 21)
        Me.ProdName_LB6.TabIndex = 23
        Me.ProdName_LB6.Text = " "
        '
        'ProdNo_LB5
        '
        Me.ProdNo_LB5.AutoSize = True
        Me.ProdNo_LB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB5.Location = New System.Drawing.Point(38, 195)
        Me.ProdNo_LB5.Name = "ProdNo_LB5"
        Me.ProdNo_LB5.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB5.TabIndex = 22
        Me.ProdNo_LB5.Text = " "
        '
        'ProdNo_LB4
        '
        Me.ProdNo_LB4.AutoSize = True
        Me.ProdNo_LB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB4.Location = New System.Drawing.Point(38, 162)
        Me.ProdNo_LB4.Name = "ProdNo_LB4"
        Me.ProdNo_LB4.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB4.TabIndex = 21
        Me.ProdNo_LB4.Text = " "
        '
        'ProdNo_LB3
        '
        Me.ProdNo_LB3.AutoSize = True
        Me.ProdNo_LB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB3.Location = New System.Drawing.Point(38, 129)
        Me.ProdNo_LB3.Name = "ProdNo_LB3"
        Me.ProdNo_LB3.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB3.TabIndex = 20
        Me.ProdNo_LB3.Text = " "
        '
        'ProdNo_LB2
        '
        Me.ProdNo_LB2.AutoSize = True
        Me.ProdNo_LB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB2.Location = New System.Drawing.Point(38, 96)
        Me.ProdNo_LB2.Name = "ProdNo_LB2"
        Me.ProdNo_LB2.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB2.TabIndex = 19
        Me.ProdNo_LB2.Text = " "
        '
        'ProdNo_LB6
        '
        Me.ProdNo_LB6.AutoSize = True
        Me.ProdNo_LB6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNo_LB6.Location = New System.Drawing.Point(38, 228)
        Me.ProdNo_LB6.Name = "ProdNo_LB6"
        Me.ProdNo_LB6.Size = New System.Drawing.Size(14, 21)
        Me.ProdNo_LB6.TabIndex = 17
        Me.ProdNo_LB6.Text = " "
        '
        'GrandTotal_LB
        '
        Me.GrandTotal_LB.AutoSize = True
        Me.GrandTotal_LB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotal_LB.Location = New System.Drawing.Point(1037, 277)
        Me.GrandTotal_LB.Name = "GrandTotal_LB"
        Me.GrandTotal_LB.Size = New System.Drawing.Size(36, 21)
        Me.GrandTotal_LB.TabIndex = 16
        Me.GrandTotal_LB.Text = "- - -"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1034, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total Price"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(920, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(818, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(421, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Items Purchased"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Item No."
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1140, 308)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 788
        Me.LineShape6.X2 = 788
        Me.LineShape6.Y1 = 0
        Me.LineShape6.Y2 = 310
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 894
        Me.LineShape5.X2 = 894
        Me.LineShape5.Y1 = 1
        Me.LineShape5.Y2 = 311
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 1154
        Me.LineShape4.Y1 = 264
        Me.LineShape4.Y2 = 264
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1006
        Me.LineShape3.X2 = 1006
        Me.LineShape3.Y1 = 0
        Me.LineShape3.Y2 = 310
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 1155
        Me.LineShape2.Y1 = 45
        Me.LineShape2.Y2 = 45
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 167
        Me.LineShape1.X2 = 167
        Me.LineShape1.Y1 = -2
        Me.LineShape1.Y2 = 308
        '
        'CreateNew_BTN
        '
        Me.CreateNew_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateNew_BTN.Location = New System.Drawing.Point(32, 653)
        Me.CreateNew_BTN.Name = "CreateNew_BTN"
        Me.CreateNew_BTN.Size = New System.Drawing.Size(177, 51)
        Me.CreateNew_BTN.TabIndex = 2
        Me.CreateNew_BTN.Text = "CREATE NEW"
        Me.CreateNew_BTN.UseVisualStyleBackColor = True
        '
        'AddProd_BTN
        '
        Me.AddProd_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProd_BTN.Location = New System.Drawing.Point(279, 653)
        Me.AddProd_BTN.Name = "AddProd_BTN"
        Me.AddProd_BTN.Size = New System.Drawing.Size(177, 51)
        Me.AddProd_BTN.TabIndex = 4
        Me.AddProd_BTN.Text = "ADD PRODUCTS"
        Me.AddProd_BTN.UseVisualStyleBackColor = True
        Me.AddProd_BTN.Visible = False
        '
        'Cal_BTN
        '
        Me.Cal_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cal_BTN.Location = New System.Drawing.Point(528, 653)
        Me.Cal_BTN.Name = "Cal_BTN"
        Me.Cal_BTN.Size = New System.Drawing.Size(177, 51)
        Me.Cal_BTN.TabIndex = 5
        Me.Cal_BTN.Text = "CALCULATE TOTAL"
        Me.Cal_BTN.UseVisualStyleBackColor = True
        Me.Cal_BTN.Visible = False
        '
        'Purchase_BTN
        '
        Me.Purchase_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purchase_BTN.Location = New System.Drawing.Point(770, 653)
        Me.Purchase_BTN.Name = "Purchase_BTN"
        Me.Purchase_BTN.Size = New System.Drawing.Size(177, 51)
        Me.Purchase_BTN.TabIndex = 6
        Me.Purchase_BTN.Text = "MAKE PURCHASE"
        Me.Purchase_BTN.UseVisualStyleBackColor = True
        Me.Purchase_BTN.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(890, 614)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 21)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Total Amount Paid : "
        '
        'TotalAmt_LB
        '
        Me.TotalAmt_LB.AutoSize = True
        Me.TotalAmt_LB.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmt_LB.Location = New System.Drawing.Point(1046, 605)
        Me.TotalAmt_LB.Name = "TotalAmt_LB"
        Me.TotalAmt_LB.Size = New System.Drawing.Size(59, 32)
        Me.TotalAmt_LB.TabIndex = 18
        Me.TotalAmt_LB.Text = "- - -"
        '
        'Search_BTN
        '
        Me.Search_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_BTN.Location = New System.Drawing.Point(31, 604)
        Me.Search_BTN.Name = "Search_BTN"
        Me.Search_BTN.Size = New System.Drawing.Size(178, 42)
        Me.Search_BTN.TabIndex = 19
        Me.Search_BTN.Text = "BILL SUMMARY"
        Me.Search_BTN.UseVisualStyleBackColor = True
        '
        '_24_25_DatabaseDataSet
        '
        Me._24_25_DatabaseDataSet.DataSetName = "_24_25_DatabaseDataSet"
        Me._24_25_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "bill"
        Me.BillBindingSource.DataSource = Me._24_25_DatabaseDataSet
        '
        'Print_BTN
        '
        Me.Print_BTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print_BTN.Location = New System.Drawing.Point(996, 653)
        Me.Print_BTN.Name = "Print_BTN"
        Me.Print_BTN.Size = New System.Drawing.Size(177, 51)
        Me.Print_BTN.TabIndex = 20
        Me.Print_BTN.Text = "PRINT RECEIPT"
        Me.Print_BTN.UseVisualStyleBackColor = True
        Me.Print_BTN.Visible = False
        '
        'PrintAction
        '
        Me.PrintAction.UseEXDialog = True
        '
        'teguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Print_BTN)
        Me.Controls.Add(Me.Search_BTN)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.TotalAmt_LB)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Purchase_BTN)
        Me.Controls.Add(Me.Cal_BTN)
        Me.Controls.Add(Me.AddProd_BTN)
        Me.Controls.Add(Me.CreateNew_BTN)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "teguna"
        Me.Text = "Bill"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _24_25_DatabaseDataSet As WindowsApplication1._24_25_DatabaseDataSet
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CustCNO_Title_LB As System.Windows.Forms.Label
    Friend WithEvents CustName_Title_LB As System.Windows.Forms.Label
    Friend WithEvents CustID_Title_LB As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrandTotal_LB As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CreateNew_BTN As System.Windows.Forms.Button
    Friend WithEvents AddProd_BTN As System.Windows.Forms.Button
    Friend WithEvents Cal_BTN As System.Windows.Forms.Button
    Friend WithEvents Purchase_BTN As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TotalAmt_LB As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB5 As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB4 As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB3 As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB2 As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB1 As System.Windows.Forms.Label
    Friend WithEvents ProdQuan_LB6 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB5 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB4 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB3 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB2 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB1 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_LB6 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB5 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB4 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB3 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB2 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB1 As System.Windows.Forms.Label
    Friend WithEvents ProdName_LB6 As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB5 As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB4 As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB3 As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB2 As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB6 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB5 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB4 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB3 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB2 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB1 As System.Windows.Forms.Label
    Friend WithEvents ProdTPrice_LB6 As System.Windows.Forms.Label
    Friend WithEvents CustID_LB As System.Windows.Forms.Label
    Friend WithEvents CustCNO_LB As System.Windows.Forms.Label
    Friend WithEvents CustName_LB As System.Windows.Forms.Label
    Friend WithEvents BillID_LB As System.Windows.Forms.Label
    Friend WithEvents Date_LB As System.Windows.Forms.Label
    Friend WithEvents EmpID_LB As System.Windows.Forms.Label
    Friend WithEvents ProdNo_LB1 As System.Windows.Forms.Label
    Friend WithEvents BillTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.billTableAdapter
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Search_BTN As System.Windows.Forms.Button
    Friend WithEvents Print_BTN As System.Windows.Forms.Button
    Friend WithEvents PrintAction As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintBill As System.Drawing.Printing.PrintDocument
End Class
