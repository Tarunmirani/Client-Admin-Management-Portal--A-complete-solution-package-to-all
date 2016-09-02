Public Class Designing
    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "please enter your name ")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

    End Sub
    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
        If TextBox2.Text = "" Then
            ErrorProvider2.SetError(TextBox2, "please enter your SurName ")
        Else
            ErrorProvider2.SetError(TextBox2, "")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If IsNumeric(TextBox1.Text) = True Then
            MsgBox("Enter textual data")
        ElseIf IsNumeric(TextBox2.Text) = True Then
            MsgBox("Enter textual data")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Enter your name")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter your surname")
        ElseIf TextBox3.Text = "" Then
            MsgBox("please enter ur gender")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Please enter your marital status")
        ElseIf TextBox5.Text = "" Then
            MsgBox("Enter your address")
        ElseIf TextBox6.Text = "" Then
            MsgBox("Enter your favourite community sites")
        ElseIf TextBox7.Text = "" Then
            MsgBox("Enter your hobbies")
        ElseIf TextBox8.Text = "" Then
            MsgBox("Enter your qualifications")
        Else
            MsgBox("your entered data is here")
            Me.Hide()
            Display.Show()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub







    Private Sub Designing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BiodataMain.Show()
        Me.Hide()

    End Sub
End Class

