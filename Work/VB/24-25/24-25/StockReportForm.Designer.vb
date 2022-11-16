<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._24_25_DatabaseDataSet = New WindowsApplication1._24_25_DatabaseDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.stockTableAdapter = New WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter()
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stockBindingSource
        '
        Me.stockBindingSource.DataMember = "stock"
        Me.stockBindingSource.DataSource = Me._24_25_DatabaseDataSet
        '
        '_24_25_DatabaseDataSet
        '
        Me._24_25_DatabaseDataSet.DataSetName = "_24_25_DatabaseDataSet"
        Me._24_25_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Top
        ReportDataSource1.Name = "StockReport"
        ReportDataSource1.Value = Me.stockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.StockReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1350, 768)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'stockTableAdapter
        '
        Me.stockTableAdapter.ClearBeforeFill = True
        '
        'StockReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "StockReportForm"
        Me.Text = "Stock Report"
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._24_25_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _24_25_DatabaseDataSet As WindowsApplication1._24_25_DatabaseDataSet
    Friend WithEvents stockTableAdapter As WindowsApplication1._24_25_DatabaseDataSetTableAdapters.stockTableAdapter
End Class
