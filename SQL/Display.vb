Public Class Display

    Private Sub Display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = (Designing.TextBox1.Text)
        Label3.Text = (Designing.TextBox2.Text)
        Label4.Text = (Designing.TextBox3.Text)
        Label5.Text = (Designing.DateTimePicker1.Text)
        Label6.Text = (Designing.TextBox4.Text)
        Label7.Text = (Designing.TextBox5.Text)
        Label11.Text = (Designing.TextBox6.Text)
        Label9.Text = (Designing.TextBox7.Text)
        Label26.Text = (Designing.TextBox8.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Designing.TextBox1.Text = ""
        Designing.TextBox2.Text = ""
        Designing.TextBox3.Text = ""
        Designing.TextBox4.Text = ""
        Designing.TextBox5.Text = ""
        Designing.TextBox6.Text = ""
        Designing.TextBox7.Text = ""
        Designing.TextBox8.Text = ""
        Me.Hide()
        Designing.Refresh()
        Designing.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BiodataMain.Show()
        Me.Close()

    End Sub
End Class