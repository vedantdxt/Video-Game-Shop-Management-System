<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cust
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
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter()
        Me.Search_Panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Search_TB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.CustomerTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.customerTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DOJ_TB = New System.Windows.Forms.TextBox()
        Me.CustEMail_TB = New System.Windows.Forms.TextBox()
        Me.CustCNO_TB = New System.Windows.Forms.TextBox()
        Me.CustRegBy_TB = New System.Windows.Forms.TextBox()
        Me.CustAddr_TB = New System.Windows.Forms.TextBox()
        Me.CustName_TB = New System.Windows.Forms.TextBox()
        Me.CustID_TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CphnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CdorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Delete_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Last_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Add_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.First_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Edit_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Prev_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Report_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Next_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search_Panel.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SidePanel.TabIndex = 27
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
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 12
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me._24_25_DatabaseDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'Search_Panel
        '
        Me.Search_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.Controls.Add(Me.Search_TB)
        Me.Search_Panel.Controls.Add(Me.IconPictureBox1)
        Me.Search_Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Search_Panel.Location = New System.Drawing.Point(85, 29)
        Me.Search_Panel.Name = "Search_Panel"
        Me.Search_Panel.ShadowDecoration.Parent = Me.Search_Panel
        Me.Search_Panel.Size = New System.Drawing.Size(1035, 46)
        Me.Search_Panel.TabIndex = 28
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
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 50
        Me.Guna2Elipse1.TargetControl = Me.Search_Panel
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DOJ_TB)
        Me.Panel1.Controls.Add(Me.CustEMail_TB)
        Me.Panel1.Controls.Add(Me.CustCNO_TB)
        Me.Panel1.Controls.Add(Me.CustRegBy_TB)
        Me.Panel1.Controls.Add(Me.CustAddr_TB)
        Me.Panel1.Controls.Add(Me.CustName_TB)
        Me.Panel1.Controls.Add(Me.CustID_TB)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(85, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 258)
        Me.Panel1.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(343, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Registered by :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DOJ_TB
        '
        Me.DOJ_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DOJ_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOJ_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cdor", True))
        Me.DOJ_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOJ_TB.ForeColor = System.Drawing.Color.White
        Me.DOJ_TB.Location = New System.Drawing.Point(780, 26)
        Me.DOJ_TB.Name = "DOJ_TB"
        Me.DOJ_TB.Size = New System.Drawing.Size(192, 29)
        Me.DOJ_TB.TabIndex = 0
        Me.DOJ_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustEMail_TB
        '
        Me.CustEMail_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustEMail_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustEMail_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "custmail", True))
        Me.CustEMail_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustEMail_TB.ForeColor = System.Drawing.Color.White
        Me.CustEMail_TB.Location = New System.Drawing.Point(630, 201)
        Me.CustEMail_TB.Name = "CustEMail_TB"
        Me.CustEMail_TB.Size = New System.Drawing.Size(342, 29)
        Me.CustEMail_TB.TabIndex = 5
        Me.CustEMail_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustCNO_TB
        '
        Me.CustCNO_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustCNO_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustCNO_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cphno", True))
        Me.CustCNO_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustCNO_TB.ForeColor = System.Drawing.Color.White
        Me.CustCNO_TB.Location = New System.Drawing.Point(176, 200)
        Me.CustCNO_TB.Name = "CustCNO_TB"
        Me.CustCNO_TB.Size = New System.Drawing.Size(340, 29)
        Me.CustCNO_TB.TabIndex = 3
        Me.CustCNO_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustRegBy_TB
        '
        Me.CustRegBy_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustRegBy_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustRegBy_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "eid", True))
        Me.CustRegBy_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustRegBy_TB.ForeColor = System.Drawing.Color.White
        Me.CustRegBy_TB.Location = New System.Drawing.Point(475, 26)
        Me.CustRegBy_TB.Name = "CustRegBy_TB"
        Me.CustRegBy_TB.Size = New System.Drawing.Size(145, 29)
        Me.CustRegBy_TB.TabIndex = 4
        Me.CustRegBy_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustAddr_TB
        '
        Me.CustAddr_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustAddr_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustAddr_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "caddr", True))
        Me.CustAddr_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustAddr_TB.ForeColor = System.Drawing.Color.White
        Me.CustAddr_TB.Location = New System.Drawing.Point(176, 143)
        Me.CustAddr_TB.Name = "CustAddr_TB"
        Me.CustAddr_TB.Size = New System.Drawing.Size(796, 29)
        Me.CustAddr_TB.TabIndex = 2
        Me.CustAddr_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustName_TB
        '
        Me.CustName_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustName_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustName_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cname", True))
        Me.CustName_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustName_TB.ForeColor = System.Drawing.Color.White
        Me.CustName_TB.Location = New System.Drawing.Point(176, 85)
        Me.CustName_TB.Name = "CustName_TB"
        Me.CustName_TB.Size = New System.Drawing.Size(796, 29)
        Me.CustName_TB.TabIndex = 1
        Me.CustName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustID_TB
        '
        Me.CustID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CustID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cid", True))
        Me.CustID_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustID_TB.ForeColor = System.Drawing.Color.White
        Me.CustID_TB.Location = New System.Drawing.Point(176, 26)
        Me.CustID_TB.Name = "CustID_TB"
        Me.CustID_TB.Size = New System.Drawing.Size(145, 29)
        Me.CustID_TB.TabIndex = 0
        Me.CustID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(637, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date of Joining :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(545, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-mail :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(38, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact No. :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(38, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(38, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CidDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.CaddrDataGridViewTextBoxColumn, Me.CphnoDataGridViewTextBoxColumn, Me.CustmailDataGridViewTextBoxColumn, Me.EidDataGridViewTextBoxColumn, Me.CdorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(58, 459)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 238)
        Me.DataGridView1.TabIndex = 44
        '
        'CidDataGridViewTextBoxColumn
        '
        Me.CidDataGridViewTextBoxColumn.DataPropertyName = "cid"
        Me.CidDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CidDataGridViewTextBoxColumn.Name = "CidDataGridViewTextBoxColumn"
        Me.CidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "cname"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        Me.CnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaddrDataGridViewTextBoxColumn
        '
        Me.CaddrDataGridViewTextBoxColumn.DataPropertyName = "caddr"
        Me.CaddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.CaddrDataGridViewTextBoxColumn.Name = "CaddrDataGridViewTextBoxColumn"
        Me.CaddrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CphnoDataGridViewTextBoxColumn
        '
        Me.CphnoDataGridViewTextBoxColumn.DataPropertyName = "cphno"
        Me.CphnoDataGridViewTextBoxColumn.HeaderText = "Contact No."
        Me.CphnoDataGridViewTextBoxColumn.Name = "CphnoDataGridViewTextBoxColumn"
        Me.CphnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustmailDataGridViewTextBoxColumn
        '
        Me.CustmailDataGridViewTextBoxColumn.DataPropertyName = "custmail"
        Me.CustmailDataGridViewTextBoxColumn.HeaderText = "E-Mail"
        Me.CustmailDataGridViewTextBoxColumn.Name = "CustmailDataGridViewTextBoxColumn"
        Me.CustmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "eid"
        Me.EidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        Me.EidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CdorDataGridViewTextBoxColumn
        '
        Me.CdorDataGridViewTextBoxColumn.DataPropertyName = "cdor"
        Me.CdorDataGridViewTextBoxColumn.HeaderText = "Date of Registration"
        Me.CdorDataGridViewTextBoxColumn.Name = "CdorDataGridViewTextBoxColumn"
        Me.CdorDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.Panel2.Location = New System.Drawing.Point(85, 386)
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.Search_Panel)
        Me.Name = "cust"
        Me.Text = "Customer"
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search_Panel.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _24_25_DatabaseDataSet As WindowsApplication1._24_25_DatabaseDataSet
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents StockTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter
    Friend WithEvents Search_Panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Search_TB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CaddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CcontDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DOJ_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustEMail_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustCNO_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustRegBy_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustAddr_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustName_TB As System.Windows.Forms.TextBox
    Friend WithEvents CustID_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CphnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CdorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Delete_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Last_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Add_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents First_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Edit_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Prev_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Report_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Next_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
