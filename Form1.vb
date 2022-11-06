Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Label1 = TextBox1.Text
        Dim Label2 = TextBox2.Text
        Dim Label3 = TextBox3.Text
        Dim Label4 = TextBox4.Text
        Dim Label5 = TextBox5.Text
        Dim Label6 = TextBox6.Text
        Dim Label7 = TextBox7.Text
        Dim Label8 = TextBox8.Text
        Dim Label9 = TextBox9.Text
        Dim Label10 = TextBox10.Text
        TextBox6.Text = (TextBox3.Text * 0.2 + TextBox4.Text * 0.3 + TextBox5.Text * 0.5)
        TextBox9.Text = (TextBox6.Text / TextBox7.Text)
        TextBox10.Text = ((TextBox6.Text * TextBox8.Text) / (TextBox7.Text * TextBox8.Text))
        TextBox9.Text = TextBox9.Text.Substring(0, 3)
        TextBox10.Text = TextBox10.Text.Substring(0, 3)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub
    

End Class
