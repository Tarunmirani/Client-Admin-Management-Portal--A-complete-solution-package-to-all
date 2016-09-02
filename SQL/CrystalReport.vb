Public Class CrystalReport

    Private Sub CrystalReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydatabaseDataSet.Table_1' table. You can move, or remove it, as needed.
        Me.Table_1TableAdapter.Fill(Me.MydatabaseDataSet.Table_1)
        'TODO: This line of code loads data into the 'BioDataDataSet1.Biodata' table. You can move, or remove it, as needed.
        Me.BiodataTableAdapter1.Fill(Me.BioDataDataSet1.Biodata)
        'TODO: This line of code loads data into the 'BioDataDataSet.Biodata' table. You can move, or remove it, as needed.
        'Me.BiodataTableAdapter.Fill(Me.BioDataDataSet.Biodata)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class