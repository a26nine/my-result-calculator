Public Class Form7
    Dim cgpa, s1, s2, s3, s4, s5, s6 As Decimal
    Dim cnt As Integer = 0
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        Try
            Dim l1 As String = System.IO.File.ReadAllLines("\sem1.txt")(13)
            TextBox1.Text = l1
            cnt += 1
        Catch ex As Exception

        End Try
        
        Try
            Dim l2 As String = System.IO.File.ReadAllLines("\sem2.txt")(13)
            TextBox2.Text = l2
            cnt += 1
        Catch ex As Exception

        End Try
        Try
            Dim l3 As String = System.IO.File.ReadAllLines("\sem3.txt")(13)
            TextBox3.Text = l3
            cnt += 1
        Catch ex As Exception

        End Try
        Try
            Dim l4 As String = System.IO.File.ReadAllLines("\sem4.txt")(13)
            TextBox4.Text = l4
            cnt += 1
        Catch ex As Exception

        End Try
        Try
            Dim l5 As String = System.IO.File.ReadAllLines("\sem5.txt")(13)
            TextBox5.Text = l5
            cnt += 1
        Catch ex As Exception

        End Try
        Try
            Dim l6 As String = System.IO.File.ReadAllLines("\sem6.txt")(13)
            TextBox6.Text = l6
            cnt += 1
        Catch ex As Exception

        End Try
        If cnt = 6 Then
            s1 = CType(TextBox1.Text, Decimal)
            s2 = CType(TextBox2.Text, Decimal)
            s3 = CType(TextBox3.Text, Decimal)
            s4 = CType(TextBox4.Text, Decimal)
            s5 = CType(TextBox5.Text, Decimal)
            s6 = CType(TextBox6.Text, Decimal)
            cgpa = (s1 + s2 + s3 + s4 + s5 + s6) / 6
            TextBox7.Text = cgpa
            Button1.Enabled = False
        Else
            TextBox7.Text = "You haven't completed all the semesters! ;)"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim newform As New Form3
        newform.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim newform1 As New Form5
        newform1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ch As Integer
        ch = MessageBox.Show("Are you sure?", "Clear All Data", MessageBoxButtons.OKCancel)
        If ch = 1 Then
            System.IO.File.Delete("\sem1.txt")
            System.IO.File.Delete("\sem2.txt")
            System.IO.File.Delete("\sem3.txt")
            System.IO.File.Delete("\sem4.txt")
            System.IO.File.Delete("\sem5.txt")
            System.IO.File.Delete("\sem6.txt")
            TextBox1.Text = "-"
            TextBox2.Text = "-"
            TextBox3.Text = "-"
            TextBox4.Text = "-"
            TextBox5.Text = "-"
            TextBox6.Text = "-"
            TextBox7.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newform2 As New Form8
        newform2.Show()
    End Sub
End Class