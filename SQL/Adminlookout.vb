Imports System.Data.SqlClient
Imports System.Data

Public Class Adminlookout
    Dim con As New SqlConnection("server=XCOMSTORE-PC;user id=sa;password=killerkid;database=mydatabase")
    'Represents An Open Connection To a DataSopurce
    Dim com As SqlCommand
    Dim adap As New SqlDataAdapter   'Represents a set of commands & Connection to DB, that are used to fil & update the Data Source.(As a OLEDBCommand)
    Dim ds As DataSet 'Represents as In-Memory cache ofdata.
    Dim dv As DataView 'represents a customised view of table for searching,sorting,navigation...etc
    Dim cm As CurrencyManager 'for navigation
    Private Sub Adminlookout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydatabaseDataSet.Table_1' table. You can move, or remove it, as needed.
        Me.Table_1TableAdapter.Fill(Me.MydatabaseDataSet.Table_1)
        'TODO: This line of code loads data into the 'BioDataDataSet.Biodata' table. You can move, or remove it, as needed.
        ' Me.BiodataTableAdapter.Fill(Me.BioDataDataSet.Biodata)
        con = New SqlConnection("server=XCOMSTORE-PC;user id=sa;password=killerkid;database=mydatabase")
        adap = New SqlDataAdapter("select * from table_1", con)
        filldatasetanddataview()
        bindingFields()
        showPosition()

        ''Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adap.Fill(ds, "table_1") 'used to fill or refreshes row in table.
        dv = New DataView(ds.Tables("table_1")) 'Since in DataSet more than 1 table can be stored, so to view any of them DataView is used, & hence the currencyManager can't C directly with DataSet|Adapter, it has to manage the navigation's with the help of DataView.
        cm = CType(Me.BindingContext(dv), CurrencyManager)
    End Sub
    Private Sub bindingFields()
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()


        TextBox1.DataBindings.Add("text", dv, "Name")
        TextBox2.DataBindings.Add("text", dv, "Surname")
        TextBox3.DataBindings.Add("text", dv, "Gender")
        DateTimePicker1.DataBindings.Add("text", dv, "Dateofbirth")
        TextBox4.DataBindings.Add("text", dv, "Martialstatus")
        TextBox5.DataBindings.Add("text", dv, "Address")
        TextBox6.DataBindings.Add("text", dv, "Communitysiteused")
        TextBox7.DataBindings.Add("text", dv, "Hobbies")
        TextBox8.DataBindings.Add("text", dv, "Qualification")

    End Sub
    Private Sub showPosition()
        Label15.Text = cm.Position + 1 & " Of " & cm.Count
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim str As String = "insert into table_1 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        'Dim com As OleDbCommand
        adap = New SqlDataAdapter (str, con)

        con.Open()
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Inserted")
        Label15.Text = cm.Position + 1 & " Of " & cm.Count
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportViewer1.PrintDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String = "delete from table_1 where Name='" & TextBox1.Text & "'"
        con.Open()
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("RecordDeleted")
        con.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cm.Position = 0
        showPosition()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cm.Position = cm.Position - 1
        showPosition()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cm.Position += 1
        showPosition()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cm.Position = cm.Count - 1
        showPosition()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        DateTimePicker1.Text = ""
        Label15.Text = cm.Count + 1
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        CrystalReport.Show()


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        BiodataMain.Show()
        Me.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        PreviewData.Show()
    End Sub
    
End Class