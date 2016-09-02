<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewData
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Pratiksha_ahujaDataSet = New WindowsApplication6.pratiksha_ahujaDataSet
        Me.Pratiksha1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pratiksha1TableAdapter = New WindowsApplication6.pratiksha_ahujaDataSetTableAdapters.pratiksha1TableAdapter
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydatabaseDataSet = New WindowsApplication6.mydatabaseDataSet
        Me.BiodataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioDataDataSet = New WindowsApplication6.BioDataDataSet
        Me.BiodataTableAdapter = New WindowsApplication6.BioDataDataSetTableAdapters.BiodataTableAdapter
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_1TableAdapter = New WindowsApplication6.mydatabaseDataSetTableAdapters.Table_1TableAdapter
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateofbirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MartialstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommunitysiteusedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HobbiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pratiksha_ahujaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pratiksha1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiodataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateofbirthDataGridViewTextBoxColumn, Me.MartialstatusDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CommunitysiteusedDataGridViewTextBoxColumn, Me.HobbiesDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 429)
        Me.DataGridView1.TabIndex = 0
        '
        'Pratiksha_ahujaDataSet
        '
        Me.Pratiksha_ahujaDataSet.DataSetName = "pratiksha_ahujaDataSet"
        Me.Pratiksha_ahujaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pratiksha1BindingSource
        '
        Me.Pratiksha1BindingSource.DataMember = "pratiksha1"
        Me.Pratiksha1BindingSource.DataSource = Me.Pratiksha_ahujaDataSet
        '
        'Pratiksha1TableAdapter
        '
        Me.Pratiksha1TableAdapter.ClearBeforeFill = True
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table_1"
        Me.Table1BindingSource1.DataSource = Me.MydatabaseDataSet
        '
        'MydatabaseDataSet
        '
        Me.MydatabaseDataSet.DataSetName = "mydatabaseDataSet"
        Me.MydatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BiodataBindingSource
        '
        Me.BiodataBindingSource.DataMember = "Biodata"
        Me.BiodataBindingSource.DataSource = Me.BioDataDataSet
        '
        'BioDataDataSet
        '
        Me.BioDataDataSet.DataSetName = "BioDataDataSet"
        Me.BioDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BiodataTableAdapter
        '
        Me.BiodataTableAdapter.ClearBeforeFill = True
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
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DateofbirthDataGridViewTextBoxColumn
        '
        Me.DateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Dateofbirth"
        Me.DateofbirthDataGridViewTextBoxColumn.HeaderText = "Dateofbirth"
        Me.DateofbirthDataGridViewTextBoxColumn.Name = "DateofbirthDataGridViewTextBoxColumn"
        '
        'MartialstatusDataGridViewTextBoxColumn
        '
        Me.MartialstatusDataGridViewTextBoxColumn.DataPropertyName = "Martialstatus"
        Me.MartialstatusDataGridViewTextBoxColumn.HeaderText = "Martialstatus"
        Me.MartialstatusDataGridViewTextBoxColumn.Name = "MartialstatusDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CommunitysiteusedDataGridViewTextBoxColumn
        '
        Me.CommunitysiteusedDataGridViewTextBoxColumn.DataPropertyName = "Communitysiteused"
        Me.CommunitysiteusedDataGridViewTextBoxColumn.HeaderText = "Communitysiteused"
        Me.CommunitysiteusedDataGridViewTextBoxColumn.Name = "CommunitysiteusedDataGridViewTextBoxColumn"
        '
        'HobbiesDataGridViewTextBoxColumn
        '
        Me.HobbiesDataGridViewTextBoxColumn.DataPropertyName = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.HeaderText = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.Name = "HobbiesDataGridViewTextBoxColumn"
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        '
        'PreviewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 429)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PreviewData"
        Me.Text = "PreviewData"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pratiksha_ahujaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pratiksha1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiodataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BioDataDataSet As WindowsApplication6.BioDataDataSet
    Friend WithEvents BiodataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BiodataTableAdapter As WindowsApplication6.BioDataDataSetTableAdapters.BiodataTableAdapter
    Friend WithEvents MydatabaseDataSet As WindowsApplication6.mydatabaseDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table_1TableAdapter As WindowsApplication6.mydatabaseDataSetTableAdapters.Table_1TableAdapter
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Pratiksha_ahujaDataSet As WindowsApplication6.pratiksha_ahujaDataSet
    Friend WithEvents Pratiksha1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pratiksha1TableAdapter As WindowsApplication6.pratiksha_ahujaDataSetTableAdapters.pratiksha1TableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofbirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MartialstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommunitysiteusedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HobbiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
