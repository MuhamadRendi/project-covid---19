Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            jk = RadioButton1.Text
        Else
            jk = RadioButton2.Text
        End If

        ya = CheckedListBox1.CheckedItems.Count
        yb = CheckedListBox2.CheckedItems.Count
        yc = CheckedListBox3.CheckedItems.Count

        ta = 10 - ya
        tb = 6 - yb
        tc = 5 - yc

        y = ya + yb + yc
        t = ta + tb + tc

        If y >= 0 And y <= 7 Then
            hasil = "Rendah"
            Form2.Label1.Text = "Resiko Anda Terkena Covid - 19 Rendah"
        ElseIf y >= 8 And y <= 14 Then
            hasil = "Sedang"
            Form2.Label1.Text = "Resiko Anda Terkena Covid - 19 Sedang"
        Else
            hasil = "Tinggi"
            Form2.Label1.Text = "Resiko Anda Terkena Covid - 19 Tinggi"
        End If

        sqlnya = "insert into list_covid(nama,umur,alamat,jenis_kelamin,ya,tidak,resiko)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & jk & "','" & y & "','" & t & "','" & hasil & "')"
        Call jalan()
        Call panggildata()

        Form2.Show()
    End Sub
End Class
