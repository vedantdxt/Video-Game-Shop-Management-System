<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Search_Panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Search_TB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.StockTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StockDate_TB = New System.Windows.Forms.TextBox()
        Me.StockPrice_TB = New System.Windows.Forms.TextBox()
        Me.ProdID_TB = New System.Windows.Forms.TextBox()
        Me.StockQuan_TB = New System.Windows.Forms.TextBox()
        Me.EmpID_TB = New System.Windows.Forms.TextBox()
        Me.StockID_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SquanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Delete_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Last_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Add_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.First_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Edit_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Prev_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Report_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Next_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Search_Panel.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.White
        Me.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(1236, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(114, 729)
        Me.SidePanel.TabIndex = 23
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 50
        Me.Guna2Elipse1.TargetControl = Me.Search_Panel
        '
        'Search_Panel
        '
        Me.Search_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.Controls.Add(Me.Search_TB)
        Me.Search_Panel.Controls.Add(Me.IconPictureBox1)
        Me.Search_Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.Location = New System.Drawing.Point(96, 29)
        Me.Search_Panel.Name = "Search_Panel"
        Me.Search_Panel.ShadowDecoration.Parent = Me.Search_Panel
        Me.Search_Panel.Size = New System.Drawing.Size(1039, 46)
        Me.Search_Panel.TabIndex = 24
        '
        'Search_TB
        '
        Me.Search_TB.Animated = True
        Me.Search_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_TB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_TB.BorderThickness = 0
        Me.Search_TB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search_TB.DefaultText = ""
        Me.Search_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Search_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Search_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Search_TB.DisabledState.Parent = Me.Search_TB
        Me.Search_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.White
        Me.Search_TB.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_TB.FocusedState.Parent = Me.Search_TB
        Me.Search_TB.FocusedState.PlaceholderForeColor = System.Drawing.Color.White
        Me.Search_TB.ForeColor = System.Drawing.Color.White
        Me.Search_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_TB.HoverState.Parent = Me.Search_TB
        Me.Search_TB.HoverState.PlaceholderForeColor = System.Drawing.Color.White
        Me.Search_TB.Location = New System.Drawing.Point(58, 10)
        Me.Search_TB.Name = "Search_TB"
        Me.Search_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_TB.PlaceholderForeColor = System.Drawing.Color.White
        Me.Search_TB.PlaceholderText = "Search Item"
        Me.Search_TB.SelectedText = ""
        Me.Search_TB.ShadowDecoration.Parent = Me.Search_TB
        Me.Search_TB.Size = New System.Drawing.Size(425, 24)
        Me.Search_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Search_TB.TabIndex = 25
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 24
        Me.IconPictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.IconPictureBox1.TabIndex = 25
        Me.IconPictureBox1.TabStop = False
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me._24_25_DatabaseDataSet
        '
        '_24_25_DatabaseDataSet
        '
        Me._24_25_DatabaseDataSet.DataSetName = "_24_25_DatabaseDataSet"
        Me._24_25_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 12
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.StockDate_TB)
        Me.Panel1.Controls.Add(Me.StockPrice_TB)
        Me.Panel1.Controls.Add(Me.ProdID_TB)
        Me.Panel1.Controls.Add(Me.StockQuan_TB)
        Me.Panel1.Controls.Add(Me.EmpID_TB)
        Me.Panel1.Controls.Add(Me.StockID_TB)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(96, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1039, 201)
        Me.Panel1.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(507, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Product ID :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StockDate_TB
        '
        Me.StockDate_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StockDate_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockDate_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "dos", True))
        Me.StockDate_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockDate_TB.ForeColor = System.Drawing.Color.White
        Me.StockDate_TB.Location = New System.Drawing.Point(678, 144)
        Me.StockDate_TB.Name = "StockDate_TB"
        Me.StockDate_TB.Size = New System.Drawing.Size(264, 29)
        Me.StockDate_TB.TabIndex = 13
        Me.StockDate_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockPrice_TB
        '
        Me.StockPrice_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StockPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockPrice_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "sprice", True))
        Me.StockPrice_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockPrice_TB.ForeColor = System.Drawing.Color.White
        Me.StockPrice_TB.Location = New System.Drawing.Point(220, 144)
        Me.StockPrice_TB.Name = "StockPrice_TB"
        Me.StockPrice_TB.Size = New System.Drawing.Size(239, 29)
        Me.StockPrice_TB.TabIndex = 12
        Me.StockPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProdID_TB
        '
        Me.ProdID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "pid", True))
        Me.ProdID_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdID_TB.ForeColor = System.Drawing.Color.White
        Me.ProdID_TB.Location = New System.Drawing.Point(678, 28)
        Me.ProdID_TB.Name = "ProdID_TB"
        Me.ProdID_TB.Size = New System.Drawing.Size(264, 29)
        Me.ProdID_TB.TabIndex = 11
        Me.ProdID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockQuan_TB
        '
        Me.StockQuan_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StockQuan_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockQuan_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "squan", True))
        Me.StockQuan_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockQuan_TB.ForeColor = System.Drawing.Color.White
        Me.StockQuan_TB.Location = New System.Drawing.Point(678, 86)
        Me.StockQuan_TB.Name = "StockQuan_TB"
        Me.StockQuan_TB.Size = New System.Drawing.Size(264, 29)
        Me.StockQuan_TB.TabIndex = 10
        Me.StockQuan_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpID_TB
        '
        Me.EmpID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "eid", True))
        Me.EmpID_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID_TB.ForeColor = System.Drawing.Color.White
        Me.EmpID_TB.Location = New System.Drawing.Point(220, 85)
        Me.EmpID_TB.Name = "EmpID_TB"
        Me.EmpID_TB.Size = New System.Drawing.Size(239, 29)
        Me.EmpID_TB.TabIndex = 9
        Me.EmpID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockID_TB
        '
        Me.StockID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StockID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "sid", True))
        Me.StockID_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockID_TB.ForeColor = System.Drawing.Color.White
        Me.StockID_TB.Location = New System.Drawing.Point(220, 28)
        Me.StockID_TB.Name = "StockID_TB"
        Me.StockID_TB.Size = New System.Drawing.Size(239, 29)
        Me.StockID_TB.TabIndex = 8
        Me.StockID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(507, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stock Date :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(84, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stock Price :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(507, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock Quanity :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(84, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stocked by :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(84, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DosDataGridViewTextBoxColumn
        '
        Me.DosDataGridViewTextBoxColumn.DataPropertyName = "dos"
        Me.DosDataGridViewTextBoxColumn.HeaderText = "Date of Stock"
        Me.DosDataGridViewTextBoxColumn.Name = "DosDataGridViewTextBoxColumn"
        Me.DosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SquanDataGridViewTextBoxColumn
        '
        Me.SquanDataGridViewTextBoxColumn.DataPropertyName = "squan"
        Me.SquanDataGridViewTextBoxColumn.HeaderText = "Stock Quantity"
        Me.SquanDataGridViewTextBoxColumn.Name = "SquanDataGridViewTextBoxColumn"
        Me.SquanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpriceDataGridViewTextBoxColumn
        '
        Me.SpriceDataGridViewTextBoxColumn.DataPropertyName = "sprice"
        Me.SpriceDataGridViewTextBoxColumn.HeaderText = "Stock Price"
        Me.SpriceDataGridViewTextBoxColumn.Name = "SpriceDataGridViewTextBoxColumn"
        Me.SpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "eid"
        Me.EidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        Me.EidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PidDataGridViewTextBoxColumn
        '
        Me.PidDataGridViewTextBoxColumn.DataPropertyName = "pid"
        Me.PidDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.PidDataGridViewTextBoxColumn.Name = "PidDataGridViewTextBoxColumn"
        Me.PidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SidDataGridViewTextBoxColumn
        '
        Me.SidDataGridViewTextBoxColumn.DataPropertyName = "sid"
        Me.SidDataGridViewTextBoxColumn.HeaderText = "Stock ID"
        Me.SidDataGridViewTextBoxColumn.Name = "SidDataGridViewTextBoxColumn"
        Me.SidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.PidDataGridViewTextBoxColumn, Me.EidDataGridViewTextBoxColumn, Me.SpriceDataGridViewTextBoxColumn, Me.SquanDataGridViewTextBoxColumn, Me.DosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(96, 410)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 257)
        Me.DataGridView1.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Delete_BTN)
        Me.Panel2.Controls.Add(Me.Last_BTN)
        Me.Panel2.Controls.Add(Me.Add_BTN)
        Me.Panel2.Controls.Add(Me.First_BTN)
        Me.Panel2.Controls.Add(Me.Edit_BTN)
        Me.Panel2.Controls.Add(Me.Prev_BTN)
        Me.Panel2.Controls.Add(Me.Report_BTN)
        Me.Panel2.Controls.Add(Me.Next_BTN)
        Me.Panel2.Location = New System.Drawing.Point(85, 333)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1050, 48)
        Me.Panel2.TabIndex = 53
        '
        'Delete_BTN
        '
        Me.Delete_BTN.AutoRoundedCorners = True
        Me.Delete_BTN.BorderRadius = 20
        Me.Delete_BTN.CheckedState.Parent = Me.Delete_BTN
        Me.Delete_BTN.CustomImages.Parent = Me.Delete_BTN
        Me.Delete_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Delete_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Delete_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_BTN.ForeColor = System.Drawing.Color.White
        Me.Delete_BTN.HoverState.Parent = Me.Delete_BTN
        Me.Delete_BTN.Location = New System.Drawing.Point(793, 3)
        Me.Delete_BTN.Name = "Delete_BTN"
        Me.Delete_BTN.ShadowDecoration.Parent = Me.Delete_BTN
        Me.Delete_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Delete_BTN.TabIndex = 33
        Me.Delete_BTN.Text = "DELETE"
        '
        'Last_BTN
        '
        Me.Last_BTN.AutoRoundedCorners = True
        Me.Last_BTN.BorderRadius = 20
        Me.Last_BTN.CheckedState.Parent = Me.Last_BTN
        Me.Last_BTN.CustomImages.Parent = Me.Last_BTN
        Me.Last_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Last_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Last_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_BTN.ForeColor = System.Drawing.Color.White
        Me.Last_BTN.HoverState.Parent = Me.Last_BTN
        Me.Last_BTN.Location = New System.Drawing.Point(384, 3)
        Me.Last_BTN.Name = "Last_BTN"
        Me.Last_BTN.ShadowDecoration.Parent = Me.Last_BTN
        Me.Last_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Last_BTN.TabIndex = 51
        Me.Last_BTN.Text = "LAST"
        '
        'Add_BTN
        '
        Me.Add_BTN.AutoRoundedCorners = True
        Me.Add_BTN.BorderRadius = 20
        Me.Add_BTN.CheckedState.Parent = Me.Add_BTN
        Me.Add_BTN.CustomImages.Parent = Me.Add_BTN
        Me.Add_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Add_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Add_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_BTN.ForeColor = System.Drawing.Color.White
        Me.Add_BTN.HoverState.Parent = Me.Add_BTN
        Me.Add_BTN.Location = New System.Drawing.Point(553, 3)
        Me.Add_BTN.Name = "Add_BTN"
        Me.Add_BTN.ShadowDecoration.Parent = Me.Add_BTN
        Me.Add_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Add_BTN.TabIndex = 30
        Me.Add_BTN.Text = "ADD"
        '
        'First_BTN
        '
        Me.First_BTN.AutoRoundedCorners = True
        Me.First_BTN.BorderRadius = 21
        Me.First_BTN.CheckedState.Parent = Me.First_BTN
        Me.First_BTN.CustomImages.Parent = Me.First_BTN
        Me.First_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.First_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.First_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_BTN.ForeColor = System.Drawing.Color.White
        Me.First_BTN.HoverState.Parent = Me.First_BTN
        Me.First_BTN.Location = New System.Drawing.Point(24, 1)
        Me.First_BTN.Name = "First_BTN"
        Me.First_BTN.ShadowDecoration.Parent = Me.First_BTN
        Me.First_BTN.Size = New System.Drawing.Size(114, 44)
        Me.First_BTN.TabIndex = 50
        Me.First_BTN.Text = "FIRST"
        '
        'Edit_BTN
        '
        Me.Edit_BTN.AutoRoundedCorners = True
        Me.Edit_BTN.BorderRadius = 20
        Me.Edit_BTN.CheckedState.Parent = Me.Edit_BTN
        Me.Edit_BTN.CustomImages.Parent = Me.Edit_BTN
        Me.Edit_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Edit_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Edit_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_BTN.ForeColor = System.Drawing.Color.White
        Me.Edit_BTN.HoverState.Parent = Me.Edit_BTN
        Me.Edit_BTN.Location = New System.Drawing.Point(673, 3)
        Me.Edit_BTN.Name = "Edit_BTN"
        Me.Edit_BTN.ShadowDecoration.Parent = Me.Edit_BTN
        Me.Edit_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Edit_BTN.TabIndex = 31
        Me.Edit_BTN.Text = "EDIT"
        '
        'Prev_BTN
        '
        Me.Prev_BTN.AutoRoundedCorners = True
        Me.Prev_BTN.BorderRadius = 20
        Me.Prev_BTN.CheckedState.Parent = Me.Prev_BTN
        Me.Prev_BTN.CustomImages.Parent = Me.Prev_BTN
        Me.Prev_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Prev_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Prev_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prev_BTN.ForeColor = System.Drawing.Color.White
        Me.Prev_BTN.HoverState.Parent = Me.Prev_BTN
        Me.Prev_BTN.Location = New System.Drawing.Point(144, 3)
        Me.Prev_BTN.Name = "Prev_BTN"
        Me.Prev_BTN.ShadowDecoration.Parent = Me.Prev_BTN
        Me.Prev_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Prev_BTN.TabIndex = 49
        Me.Prev_BTN.Text = "PREVIOUS"
        '
        'Report_BTN
        '
        Me.Report_BTN.AutoRoundedCorners = True
        Me.Report_BTN.BorderRadius = 20
        Me.Report_BTN.CheckedState.Parent = Me.Report_BTN
        Me.Report_BTN.CustomImages.Parent = Me.Report_BTN
        Me.Report_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Report_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Report_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Report_BTN.ForeColor = System.Drawing.Color.White
        Me.Report_BTN.HoverState.Parent = Me.Report_BTN
        Me.Report_BTN.Location = New System.Drawing.Point(913, 3)
        Me.Report_BTN.Name = "Report_BTN"
        Me.Report_BTN.ShadowDecoration.Parent = Me.Report_BTN
        Me.Report_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Report_BTN.TabIndex = 32
        Me.Report_BTN.Text = "REPORT"
        '
        'Next_BTN
        '
        Me.Next_BTN.AutoRoundedCorners = True
        Me.Next_BTN.BorderRadius = 20
        Me.Next_BTN.CheckedState.Parent = Me.Next_BTN
        Me.Next_BTN.CustomImages.Parent = Me.Next_BTN
        Me.Next_BTN.FillColor = System.Drawing.Color.DarkOrchid
        Me.Next_BTN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Next_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_BTN.ForeColor = System.Drawing.Color.White
        Me.Next_BTN.HoverState.Parent = Me.Next_BTN
        Me.Next_BTN.Location = New System.Drawing.Point(264, 3)
        Me.Next_BTN.Name = "Next_BTN"
        Me.Next_BTN.ShadowDecoration.Parent = Me.Next_BTN
        Me.Next_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Next_BTN.TabIndex = 34
        Me.Next_BTN.Text = "NEXT"
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Search_Panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SidePanel)
        Me.Name = "stock"
        Me.Text = "Stock"
        Me.Search_Panel.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Search_Panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Search_TB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents _24_25_DatabaseDataSet As WindowsApplication1._24_25_DatabaseDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents SquantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StockDate_TB As System.Windows.Forms.TextBox
    Friend WithEvents StockPrice_TB As System.Windows.Forms.TextBox
    Friend WithEvents ProdID_TB As System.Windows.Forms.TextBox
    Friend WithEvents StockQuan_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpID_TB As System.Windows.Forms.TextBox
    Friend WithEvents StockID_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SquanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Delete_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Last_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Add_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents First_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Edit_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Prev_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Report_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Next_BTN As Guna.UI2.WinForms.Guna2GradientButton
End Class
