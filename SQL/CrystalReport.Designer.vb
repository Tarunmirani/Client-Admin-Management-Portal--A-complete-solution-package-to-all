<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrystalReport
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioDataDataSet1 = New WindowsApplication6.BioDataDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BiodataTableAdapter1 = New WindowsApplication6.BioDataDataSetTableAdapters.BiodataTableAdapter
        Me.MydatabaseDataSet = New WindowsApplication6.mydatabaseDataSet
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_1TableAdapter = New WindowsApplication6.mydatabaseDataSetTableAdapters.Table_1TableAdapter
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Biodata"
        Me.BindingSource1.DataSource = Me.BioDataDataSet1
        '
        'BioDataDataSet1
        '
        Me.BioDataDataSet1.DataSetName = "BioDataDataSet"
        Me.BioDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BioDataDataSet_Biodata"
        ReportDataSource1.Value = Me.Table1BindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication6.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(973, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'BiodataTableAdapter1
        '
        Me.BiodataTableAdapter1.ClearBeforeFill = True
        '
        'MydatabaseDataSet
        '
        Me.MydatabaseDataSet.DataSetName = "mydatabaseDataSet"
        Me.MydatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table_1"
        Me.Table1BindingSource.DataSource = Me.MydatabaseDataSet
        '
        'Table_1TableAdapter
        '
        Me.Table_1TableAdapter.ClearBeforeFill = True
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table_1"
        Me.Table1BindingSource1.DataSource = Me.MydatabaseDataSet
        '
        'CrystalReport
        '
        Me.ClientSize = New System.Drawing.Size(973, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CrystalReport"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    ' Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BiodataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BioDataDataSet As WindowsApplication6.BioDataDataSet
    Friend WithEvents BiodataTableAdapter As WindowsApplication6.BioDataDataSetTableAdapters.BiodataTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BioDataDataSet1 As WindowsApplication6.BioDataDataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BiodataTableAdapter1 As WindowsApplication6.BioDataDataSetTableAdapters.BiodataTableAdapter
    Friend WithEvents MydatabaseDataSet As WindowsApplication6.mydatabaseDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_1TableAdapter As WindowsApplication6.mydatabaseDataSetTableAdapters.Table_1TableAdapter
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
End Class
