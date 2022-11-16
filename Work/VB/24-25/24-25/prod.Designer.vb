<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prod
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProdGerne_TB = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.ProdID_TB = New System.Windows.Forms.TextBox()
        Me.ProdYear_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProdTitle_TB = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProdPub_TB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProdAvail_TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdPrice_TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProductTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.productTableAdapter()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Delete_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Last_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Add_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.First_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Report_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Edit_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Prev_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Next_BTN = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genre :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdGerne_TB
        '
        Me.ProdGerne_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdGerne_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdGerne_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pgenre", True))
        Me.ProdGerne_TB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdGerne_TB.ForeColor = System.Drawing.Color.White
        Me.ProdGerne_TB.Location = New System.Drawing.Point(456, 31)
        Me.ProdGerne_TB.Name = "ProdGerne_TB"
        Me.ProdGerne_TB.Size = New System.Drawing.Size(152, 33)
        Me.ProdGerne_TB.TabIndex = 8
        Me.ProdGerne_TB.TabStop = False
        Me.ProdGerne_TB.Text = "First Person Shooter"
        Me.ProdGerne_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me._24_25_DatabaseDataSet
        '
        '_24_25_DatabaseDataSet
        '
        Me._24_25_DatabaseDataSet.DataSetName = "_24_25_DatabaseDataSet"
        Me._24_25_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdID_TB
        '
        Me.ProdID_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdID_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pid", True))
        Me.ProdID_TB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdID_TB.ForeColor = System.Drawing.Color.White
        Me.ProdID_TB.Location = New System.Drawing.Point(152, 31)
        Me.ProdID_TB.Name = "ProdID_TB"
        Me.ProdID_TB.Size = New System.Drawing.Size(152, 33)
        Me.ProdID_TB.TabIndex = 3
        Me.ProdID_TB.TabStop = False
        Me.ProdID_TB.Text = "2001"
        Me.ProdID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProdYear_TB
        '
        Me.ProdYear_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdYear_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdYear_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pyear", True))
        Me.ProdYear_TB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdYear_TB.ForeColor = System.Drawing.Color.White
        Me.ProdYear_TB.Location = New System.Drawing.Point(153, 332)
        Me.ProdYear_TB.Name = "ProdYear_TB"
        Me.ProdYear_TB.Size = New System.Drawing.Size(152, 33)
        Me.ProdYear_TB.TabIndex = 10
        Me.ProdYear_TB.TabStop = False
        Me.ProdYear_TB.Text = "2011"
        Me.ProdYear_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Launch Year :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ProdYear_TB)
        Me.Panel1.Controls.Add(Me.ProdTitle_TB)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(542, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 531)
        Me.Panel1.TabIndex = 54
        '
        'ProdTitle_TB
        '
        Me.ProdTitle_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdTitle_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProdTitle_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pname", True))
        Me.ProdTitle_TB.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTitle_TB.ForeColor = System.Drawing.Color.White
        Me.ProdTitle_TB.Location = New System.Drawing.Point(3, 21)
        Me.ProdTitle_TB.Name = "ProdTitle_TB"
        Me.ProdTitle_TB.Size = New System.Drawing.Size(626, 54)
        Me.ProdTitle_TB.TabIndex = 1
        Me.ProdTitle_TB.TabStop = False
        Me.ProdTitle_TB.Text = "Title"
        Me.ProdTitle_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ProdPub_TB)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(633, 202)
        Me.Panel3.TabIndex = 14
        '
        'ProdPub_TB
        '
        Me.ProdPub_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdPub_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProdPub_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pcomp", True))
        Me.ProdPub_TB.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPub_TB.ForeColor = System.Drawing.Color.White
        Me.ProdPub_TB.Location = New System.Drawing.Point(43, 136)
        Me.ProdPub_TB.Name = "ProdPub_TB"
        Me.ProdPub_TB.Size = New System.Drawing.Size(550, 39)
        Me.ProdPub_TB.TabIndex = 2
        Me.ProdPub_TB.TabStop = False
        Me.ProdPub_TB.Text = "Activision"
        Me.ProdPub_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Published by"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ProdAvail_TB)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.ProdID_TB)
        Me.Panel4.Controls.Add(Me.ProdGerne_TB)
        Me.Panel4.Location = New System.Drawing.Point(0, 230)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 166)
        Me.Panel4.TabIndex = 15
        '
        'ProdAvail_TB
        '
        Me.ProdAvail_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdAvail_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdAvail_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pavail", True))
        Me.ProdAvail_TB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdAvail_TB.ForeColor = System.Drawing.Color.White
        Me.ProdAvail_TB.Location = New System.Drawing.Point(456, 108)
        Me.ProdAvail_TB.Name = "ProdAvail_TB"
        Me.ProdAvail_TB.Size = New System.Drawing.Size(152, 33)
        Me.ProdAvail_TB.TabIndex = 11
        Me.ProdAvail_TB.TabStop = False
        Me.ProdAvail_TB.Text = "10"
        Me.ProdAvail_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Availability :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.ProdPrice_TB)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(1, 388)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(632, 140)
        Me.Panel5.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "₹"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdPrice_TB
        '
        Me.ProdPrice_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ProdPrice_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdPrice_TB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "pprice", True))
        Me.ProdPrice_TB.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice_TB.ForeColor = System.Drawing.Color.White
        Me.ProdPrice_TB.Location = New System.Drawing.Point(247, 83)
        Me.ProdPrice_TB.Name = "ProdPrice_TB"
        Me.ProdPrice_TB.Size = New System.Drawing.Size(152, 43)
        Me.ProdPrice_TB.TabIndex = 12
        Me.ProdPrice_TB.TabStop = False
        Me.ProdPrice_TB.Text = "- -"
        Me.ProdPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Price :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(1236, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(114, 729)
        Me.SidePanel.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.ProductBindingSource, "pphoto", True))
        Me.PictureBox1.Location = New System.Drawing.Point(37, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 651)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Delete_BTN)
        Me.Panel2.Controls.Add(Me.Last_BTN)
        Me.Panel2.Controls.Add(Me.Add_BTN)
        Me.Panel2.Controls.Add(Me.First_BTN)
        Me.Panel2.Controls.Add(Me.Report_BTN)
        Me.Panel2.Controls.Add(Me.Edit_BTN)
        Me.Panel2.Controls.Add(Me.Prev_BTN)
        Me.Panel2.Controls.Add(Me.Next_BTN)
        Me.Panel2.Location = New System.Drawing.Point(600, 594)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 95)
        Me.Panel2.TabIndex = 55
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
        Me.Delete_BTN.Location = New System.Drawing.Point(264, 51)
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
        Me.Add_BTN.Location = New System.Drawing.Point(24, 51)
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
        Me.Report_BTN.Location = New System.Drawing.Point(384, 51)
        Me.Report_BTN.Name = "Report_BTN"
        Me.Report_BTN.ShadowDecoration.Parent = Me.Report_BTN
        Me.Report_BTN.Size = New System.Drawing.Size(114, 42)
        Me.Report_BTN.TabIndex = 32
        Me.Report_BTN.Text = "REPORT"
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
        Me.Edit_BTN.Location = New System.Drawing.Point(144, 51)
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
        'prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "prod"
        Me.Text = "Product"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProdGerne_TB As System.Windows.Forms.TextBox
    Friend WithEvents ProdID_TB As System.Windows.Forms.TextBox
    Friend WithEvents ProdYear_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProdAvail_TB As System.Windows.Forms.TextBox
    Friend WithEvents ProdTitle_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ProdPrice_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProdPub_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.productTableAdapter
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents _24_25_DatabaseDataSet As WindowsApplication1._24_25_DatabaseDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Delete_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Last_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Add_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents First_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Edit_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Prev_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Report_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Next_BTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
