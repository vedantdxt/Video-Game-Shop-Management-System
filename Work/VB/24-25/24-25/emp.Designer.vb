<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emp
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter()
        Me.Search_Panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Search_TB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Add_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.EmployeeTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.employeeTableAdapter()
        Me.Edit_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Report_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Delete_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Next_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpSal_TB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DOJ_TB = New System.Windows.Forms.TextBox()
        Me.DOB_TB = New System.Windows.Forms.TextBox()
        Me.EmpEMail_TB = New System.Windows.Forms.TextBox()
        Me.EmpCNO_TB = New System.Windows.Forms.TextBox()
        Me.EmpPost_TB = New System.Windows.Forms.TextBox()
        Me.EmpAddr_TB = New System.Windows.Forms.TextBox()
        Me.EmpName_TB = New System.Windows.Forms.TextBox()
        Me.EmpID_TB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EpostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EphnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdojDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prev_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.First_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Last_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me._24_25_DatabaseDataSet
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
        Me.Search_Panel.Location = New System.Drawing.Point(85, 24)
        Me.Search_Panel.Name = "Search_Panel"
        Me.Search_Panel.ShadowDecoration.Parent = Me.Search_Panel
        Me.Search_Panel.Size = New System.Drawing.Size(1047, 46)
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
        Me.Search_TB.Location = New System.Drawing.Point(58, 12)
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
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EmpSal_TB)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DOJ_TB)
        Me.Panel1.Controls.Add(Me.DOB_TB)
        Me.Panel1.Controls.Add(Me.EmpEMail_TB)
        Me.Panel1.Controls.Add(Me.EmpCNO_TB)
        Me.Panel1.Controls.Add(Me.EmpPost_TB)
        Me.Panel1.Controls.Add(Me.EmpAddr_TB)
        Me.Panel1.Controls.Add(Me.EmpName_TB)
        Me.Panel1.Controls.Add(Me.EmpID_TB)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(85, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 308)
        Me.Panel1.TabIndex = 35
        '
        'EmpSal_TB
        '
        Me.EmpSal_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpSal_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpSal_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "esal", True))
        Me.EmpSal_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpSal_TB.ForeColor = System.Drawing.Color.White
        Me.EmpSal_TB.Location = New System.Drawing.Point(798, 254)
        Me.EmpSal_TB.Name = "EmpSal_TB"
        Me.EmpSal_TB.Size = New System.Drawing.Size(200, 29)
        Me.EmpSal_TB.TabIndex = 17
        Me.EmpSal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(732, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Salary :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DOJ_TB
        '
        Me.DOJ_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DOJ_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOJ_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "edoj", True))
        Me.DOJ_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOJ_TB.ForeColor = System.Drawing.Color.White
        Me.DOJ_TB.Location = New System.Drawing.Point(517, 254)
        Me.DOJ_TB.Name = "DOJ_TB"
        Me.DOJ_TB.Size = New System.Drawing.Size(197, 29)
        Me.DOJ_TB.TabIndex = 15
        Me.DOJ_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DOB_TB
        '
        Me.DOB_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DOB_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOB_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "edob", True))
        Me.DOB_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB_TB.ForeColor = System.Drawing.Color.White
        Me.DOB_TB.Location = New System.Drawing.Point(172, 254)
        Me.DOB_TB.Name = "DOB_TB"
        Me.DOB_TB.Size = New System.Drawing.Size(197, 29)
        Me.DOB_TB.TabIndex = 6
        Me.DOB_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpEMail_TB
        '
        Me.EmpEMail_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpEMail_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpEMail_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empmail", True))
        Me.EmpEMail_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEMail_TB.ForeColor = System.Drawing.Color.White
        Me.EmpEMail_TB.Location = New System.Drawing.Point(608, 198)
        Me.EmpEMail_TB.Name = "EmpEMail_TB"
        Me.EmpEMail_TB.Size = New System.Drawing.Size(390, 29)
        Me.EmpEMail_TB.TabIndex = 5
        Me.EmpEMail_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpCNO_TB
        '
        Me.EmpCNO_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpCNO_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpCNO_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ephno", True))
        Me.EmpCNO_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpCNO_TB.ForeColor = System.Drawing.Color.White
        Me.EmpCNO_TB.Location = New System.Drawing.Point(172, 198)
        Me.EmpCNO_TB.Name = "EmpCNO_TB"
        Me.EmpCNO_TB.Size = New System.Drawing.Size(336, 29)
        Me.EmpCNO_TB.TabIndex = 3
        Me.EmpCNO_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpPost_TB
        '
        Me.EmpPost_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpPost_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPost_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "epost", True))
        Me.EmpPost_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPost_TB.ForeColor = System.Drawing.Color.White
        Me.EmpPost_TB.Location = New System.Drawing.Point(459, 30)
        Me.EmpPost_TB.Name = "EmpPost_TB"
        Me.EmpPost_TB.Size = New System.Drawing.Size(539, 29)
        Me.EmpPost_TB.TabIndex = 4
        Me.EmpPost_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpAddr_TB
        '
        Me.EmpAddr_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpAddr_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpAddr_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "eaddr", True))
        Me.EmpAddr_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddr_TB.ForeColor = System.Drawing.Color.White
        Me.EmpAddr_TB.Location = New System.Drawing.Point(172, 142)
        Me.EmpAddr_TB.Name = "EmpAddr_TB"
        Me.EmpAddr_TB.Size = New System.Drawing.Size(826, 29)
        Me.EmpAddr_TB.TabIndex = 2
        Me.EmpAddr_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpName_TB
        '
        Me.EmpName_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpName_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpName_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ename", True))
        Me.EmpName_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName_TB.ForeColor = System.Drawing.Color.White
        Me.EmpName_TB.Location = New System.Drawing.Point(172, 86)
        Me.EmpName_TB.Name = "EmpName_TB"
        Me.EmpName_TB.Size = New System.Drawing.Size(826, 29)
        Me.EmpName_TB.TabIndex = 1
        Me.EmpName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpID_TB
        '
        Me.EmpID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EmpID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "eid", True))
        Me.EmpID_TB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID_TB.ForeColor = System.Drawing.Color.White
        Me.EmpID_TB.Location = New System.Drawing.Point(172, 30)
        Me.EmpID_TB.Name = "EmpID_TB"
        Me.EmpID_TB.Size = New System.Drawing.Size(182, 29)
        Me.EmpID_TB.TabIndex = 8
        Me.EmpID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(387, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Date of Joining :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(44, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Birth :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(523, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "E-mail :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(44, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No. :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(387, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Post :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(44, 144)
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
        Me.Label2.Location = New System.Drawing.Point(44, 88)
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
        Me.Label1.Location = New System.Drawing.Point(44, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EidDataGridViewTextBoxColumn, Me.EnameDataGridViewTextBoxColumn, Me.EaddrDataGridViewTextBoxColumn, Me.EpostDataGridViewTextBoxColumn, Me.EsalDataGridViewTextBoxColumn, Me.EphnoDataGridViewTextBoxColumn, Me.EmpmailDataGridViewTextBoxColumn, Me.EdobDataGridViewTextBoxColumn, Me.EdojDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(67, 494)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1096, 196)
        Me.DataGridView1.TabIndex = 45
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "eid"
        Me.EidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "ename"
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        '
        'EaddrDataGridViewTextBoxColumn
        '
        Me.EaddrDataGridViewTextBoxColumn.DataPropertyName = "eaddr"
        Me.EaddrDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.EaddrDataGridViewTextBoxColumn.Name = "EaddrDataGridViewTextBoxColumn"
        '
        'EpostDataGridViewTextBoxColumn
        '
        Me.EpostDataGridViewTextBoxColumn.DataPropertyName = "epost"
        Me.EpostDataGridViewTextBoxColumn.HeaderText = "Post"
        Me.EpostDataGridViewTextBoxColumn.Name = "EpostDataGridViewTextBoxColumn"
        '
        'EsalDataGridViewTextBoxColumn
        '
        Me.EsalDataGridViewTextBoxColumn.DataPropertyName = "esal"
        Me.EsalDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.EsalDataGridViewTextBoxColumn.Name = "EsalDataGridViewTextBoxColumn"
        '
        'EphnoDataGridViewTextBoxColumn
        '
        Me.EphnoDataGridViewTextBoxColumn.DataPropertyName = "ephno"
        Me.EphnoDataGridViewTextBoxColumn.HeaderText = "Contact No."
        Me.EphnoDataGridViewTextBoxColumn.Name = "EphnoDataGridViewTextBoxColumn"
        '
        'EmpmailDataGridViewTextBoxColumn
        '
        Me.EmpmailDataGridViewTextBoxColumn.DataPropertyName = "empmail"
        Me.EmpmailDataGridViewTextBoxColumn.HeaderText = "E-Mail"
        Me.EmpmailDataGridViewTextBoxColumn.Name = "EmpmailDataGridViewTextBoxColumn"
        '
        'EdobDataGridViewTextBoxColumn
        '
        Me.EdobDataGridViewTextBoxColumn.DataPropertyName = "edob"
        Me.EdobDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.EdobDataGridViewTextBoxColumn.Name = "EdobDataGridViewTextBoxColumn"
        '
        'EdojDataGridViewTextBoxColumn
        '
        Me.EdojDataGridViewTextBoxColumn.DataPropertyName = "edoj"
        Me.EdojDataGridViewTextBoxColumn.HeaderText = "Date of Joining"
        Me.EdojDataGridViewTextBoxColumn.Name = "EdojDataGridViewTextBoxColumn"
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
        Me.Panel2.Location = New System.Drawing.Point(85, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 48)
        Me.Panel2.TabIndex = 52
        '
        'emp
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
        Me.Name = "emp"
        Me.Text = "Employee"
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Add_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents Edit_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Report_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Delete_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Next_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmpID_TB As System.Windows.Forms.TextBox
    Friend WithEvents DOJ_TB As System.Windows.Forms.TextBox
    Friend WithEvents DOB_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpEMail_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpCNO_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpPost_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpAddr_TB As System.Windows.Forms.TextBox
    Friend WithEvents EmpName_TB As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmpSal_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Prev_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents First_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Last_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EpostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EphnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdojDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
