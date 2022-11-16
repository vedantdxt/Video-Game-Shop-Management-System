<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
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
        Me.SidePanel.TabIndex = 24
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 100
        Me.IconButton1.Location = New System.Drawing.Point(78, 14)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(340, 200)
        Me.IconButton1.TabIndex = 25
        Me.IconButton1.Text = "Customer Report"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 100
        Me.IconButton3.Location = New System.Drawing.Point(769, 492)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(340, 200)
        Me.IconButton3.TabIndex = 27
        Me.IconButton3.Text = "Billing Report"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.LayerGroup
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 100
        Me.IconButton4.Location = New System.Drawing.Point(78, 492)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(340, 200)
        Me.IconButton4.TabIndex = 28
        Me.IconButton4.Text = "Stock Report"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton6
        '
        Me.IconButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.White
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 100
        Me.IconButton6.Location = New System.Drawing.Point(769, 14)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(340, 200)
        Me.IconButton6.TabIndex = 30
        Me.IconButton6.Text = "Product Report"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconButton6)
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton5)
        Me.Panel1.Controls.Add(Me.IconButton4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 705)
        Me.Panel1.TabIndex = 31
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.IconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 100
        Me.IconButton5.Location = New System.Drawing.Point(424, 255)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(340, 200)
        Me.IconButton5.TabIndex = 29
        Me.IconButton5.Text = "Employee Report"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "report"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
End Class
