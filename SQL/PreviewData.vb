Public Class PreviewData

    Private Sub PreviewData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pratiksha_ahujaDataSet.pratiksha1' table. You can move, or remove it, as needed.
        Me.Pratiksha1TableAdapter.Fill(Me.Pratiksha_ahujaDataSet.pratiksha1)
        'TODO: This line of code loads data into the 'MydatabaseDataSet.Table_1' table. You can move, or remove it, as needed.
        Me.Table_1TableAdapter.Fill(Me.MydatabaseDataSet.Table_1)
        'TODO: This line of code loads data into the 'BioDataDataSet.Biodata' table. You can move, or remove it, as needed.
        Me.BiodataTableAdapter.Fill(Me.BioDataDataSet.Biodata)

    End Sub
End Class