Public Class Form6
    Dim sub1, sub2, sub3, sub4, sub5, sub6 As Integer
    Dim sub7, gr1, gr2, gr3, gr4, gr5, gr6, gr7, sgpa As Decimal
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Or _
            ComboBox1.SelectedIndex = 1 Or _
            ComboBox1.SelectedIndex = 2 Or _
            ComboBox1.SelectedIndex = 3 Or _
            ComboBox1.SelectedIndex = 4 Then
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Show()
            TextBox4.Show()
            TextBox5.Show()
            TextBox6.Show()
            TextBox7.Show()
            TextBox8.Show()
            TextBox9.Show()
            TextBox10.Show()
            TextBox11.Show()
            TextBox12.Show()
            TextBox13.Show()
            Label7.Show()
            Label8.Show()
            Label9.Show()
            Button1.Show()
        Else
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Show()
            TextBox4.Show()
            TextBox5.Show()
            TextBox6.Show()
            Label8.Show()
            Label9.Show()
            Button1.Show()
            TextBox13.Show()
            Label7.Show()
        End If
        If ComboBox1.SelectedIndex = 0 Then
            Label1.Text = "101 - Communication Skills"
            Label1.Show()
            Label2.Text = "102 - Mathematics I"
            Label2.Show()
            Label3.Text = "103 - Introduction To Computers"
            Label3.Show()
            Label4.Text = "104 - Computer Programming And Programming Methodology"
            Label4.Show()
            Label5.Text = "105 - PC Software I"
            Label5.Show()
            Label6.Text = "106 - Practical"
            Label6.Show()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label1.Text = "201 - Financial Accounting"
            Label1.Show()
            Label2.Text = "202 - Organization Structure and Behaviour"
            Label2.Show()
            Label3.Text = "203 - Operating System I"
            Label3.Show()
            Label4.Text = "204 - Programming Language I"
            Label4.Show()
            Label5.Text = "205 - Database Management Systems"
            Label5.Show()
            Label6.Text = "206 - Practical"
            Label6.Show()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label1.Text = "301 - Statistical Methods"
            Label1.Show()
            Label2.Text = "302 - Software Engineering I"
            Label2.Show()
            Label3.Text = "303 - Relational Database Management System"
            Label3.Show()
            Label4.Text = "304 - Data Structures"
            Label4.Show()
            Label5.Text = "305 - Object Oriented Programming"
            Label5.Show()
            Label6.Text = "306 - Practical"
            Label6.Show()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label1.Text = "401 - Infromation Systems"
            Label1.Show()
            Label2.Text = "402 - Software Engineering II"
            Label2.Show()
            Label3.Text = "403 - Java Programming Language"
            Label3.Show()
            Label4.Text = "404 - .NET Programming"
            Label4.Show()
            Label5.Text = "405 - Web Designing"
            Label5.Show()
            Label6.Text = "406 - Practical"
            Label6.Show()
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Label1.Text = "501 - PHP MySQL"
            Label1.Show()
            Label2.Text = "502 - Unix & Shell Programming"
            Label2.Show()
            Label3.Text = "503 - Information System Application Development"
            Label3.Show()
            Label4.Text = "504 - Operating System II"
            Label4.Show()
            Label5.Text = "505 - ASP .NET"
            Label5.Show()
            Label6.Text = "506 - Practical"
            Label6.Show()
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Label1.Text = "601 - Computer Graphics"
            Label1.Show()
            Label2.Text = "602 - E-Commerce & Cyber Security"
            Label2.Show()
            Label3.Text = "603 - Project"
            Label3.Show()
            Label4.Hide()
            Label5.Hide()
            Label6.Hide()
            TextBox7.Hide()
            TextBox8.Hide()
            TextBox9.Hide()
            TextBox10.Hide()
            TextBox11.Hide()
            TextBox12.Hide()
        End If
        If ComboBox1.SelectedIndex = 0 Then
            Dim p1 As String = "\sem1.txt"
            If System.IO.File.Exists(p1) Then
                Dim re = New System.IO.StreamReader("\sem1.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p1)
            End If
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Dim p2 As String = "\sem2.txt"
            If System.IO.File.Exists(p2) Then
                Dim re = New System.IO.StreamReader("\sem2.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p2)
            End If
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Dim p3 As String = "\sem3.txt"
            If System.IO.File.Exists(p3) Then
                Dim re = New System.IO.StreamReader("\sem3.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p3)
            End If
        End If
        If ComboBox1.SelectedIndex = 3 Then
            Dim p4 As String = "\sem4.txt"
            If System.IO.File.Exists(p4) Then
                Dim re = New System.IO.StreamReader("\sem4.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p4)
            End If
        End If
        If ComboBox1.SelectedIndex = 4 Then
            Dim p5 As String = "\sem5.txt"
            If System.IO.File.Exists(p5) Then
                Dim re = New System.IO.StreamReader("\sem5.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p5)
            End If
        End If
        If ComboBox1.SelectedIndex = 5 Then
            Dim p6 As String = "\sem6.txt"
            If System.IO.File.Exists(p6) Then
                Dim re = New System.IO.StreamReader("\sem6.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p6)
            End If
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label7.Text = "Physical Training (Credits out of 2)"
        Label8.Text = "Internal"
        Label9.Text = "External"
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        TextBox10.Hide()
        TextBox11.Hide()
        TextBox12.Hide()
        TextBox13.Hide()
        Button1.Hide()
        Label10.Hide()
        TextBox14.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Or _
           ComboBox1.SelectedIndex = 1 Or _
           ComboBox1.SelectedIndex = 2 Or _
           ComboBox1.SelectedIndex = 3 Or _
           ComboBox1.SelectedIndex = 4 Then
            If IsNumeric(TextBox1.Text) And _
                IsNumeric(TextBox2.Text) And _
                IsNumeric(TextBox3.Text) And _
                IsNumeric(TextBox4.Text) And _
                IsNumeric(TextBox5.Text) And _
                IsNumeric(TextBox6.Text) And _
                IsNumeric(TextBox7.Text) And _
                IsNumeric(TextBox8.Text) And _
                IsNumeric(TextBox9.Text) And _
                IsNumeric(TextBox10.Text) And _
                IsNumeric(TextBox11.Text) And _
                IsNumeric(TextBox12.Text) And _
                IsNumeric(TextBox13.Text) Then
                Button1.Enabled = False
                sub1 = CType(TextBox1.Text, Integer) + CType(TextBox2.Text, Integer)
                sub2 = CType(TextBox3.Text, Integer) + CType(TextBox4.Text, Integer)
                sub3 = CType(TextBox5.Text, Integer) + CType(TextBox6.Text, Integer)
                sub4 = CType(TextBox7.Text, Integer) + CType(TextBox8.Text, Integer)
                sub5 = CType(TextBox9.Text, Integer) + CType(TextBox10.Text, Integer)
                sub6 = (CType(TextBox11.Text, Integer) + CType(TextBox12.Text, Integer)) / 2
                sub7 = CType(TextBox13.Text, Decimal)
                If sub1 > 100 Or _
                    sub2 > 100 Or _
                    sub3 > 100 Or _
                    sub4 > 100 Or _
                    sub5 > 100 Or _
                    sub6 > 100 Or _
                    sub7 > 2 Then
                    MsgBox("Wrong Data Entered! Check Again!")
                Else
                    If sub1 >= 90 Then
                        gr1 = 10 * 2 / 25
                    ElseIf sub1 >= 80 Then
                        gr1 = 9 * 2 / 25
                    ElseIf sub1 >= 70 Then
                        gr1 = 8 * 2 / 25
                    ElseIf sub1 >= 60 Then
                        gr1 = 7 * 2 / 25
                    ElseIf sub1 >= 50 Then
                        gr1 = 6 * 2 / 25
                    ElseIf sub1 >= 36 Then
                        gr1 = 5 * 2 / 25
                    Else
                        gr1 = 4 * 2 / 25
                    End If
                    If sub2 >= 90 Then
                        gr2 = 10 * 3 / 25
                    ElseIf sub2 >= 80 Then
                        gr2 = 9 * 3 / 25
                    ElseIf sub2 >= 70 Then
                        gr2 = 8 * 3 / 25
                    ElseIf sub2 >= 60 Then
                        gr2 = 7 * 3 / 25
                    ElseIf sub2 >= 50 Then
                        gr2 = 6 * 3 / 25
                    ElseIf sub2 >= 36 Then
                        gr2 = 5 * 3 / 25
                    Else
                        gr2 = 4 * 3 / 25
                    End If
                    If sub3 >= 90 Then
                        gr3 = 10 * 4 / 25
                    ElseIf sub3 >= 80 Then
                        gr3 = 9 * 4 / 25
                    ElseIf sub3 >= 70 Then
                        gr3 = 8 * 4 / 25
                    ElseIf sub3 >= 60 Then
                        gr3 = 7 * 4 / 25
                    ElseIf sub3 >= 50 Then
                        gr3 = 6 * 4 / 25
                    ElseIf sub3 >= 36 Then
                        gr3 = 5 * 4 / 25
                    Else
                        gr3 = 4 * 4 / 25
                    End If
                    If sub4 >= 90 Then
                        gr4 = 10 * 4 / 25
                    ElseIf sub4 >= 80 Then
                        gr4 = 9 * 4 / 25
                    ElseIf sub4 >= 70 Then
                        gr4 = 8 * 4 / 25
                    ElseIf sub4 >= 60 Then
                        gr4 = 7 * 4 / 25
                    ElseIf sub4 >= 50 Then
                        gr4 = 6 * 4 / 25
                    ElseIf sub4 >= 36 Then
                        gr4 = 5 * 4 / 25
                    Else
                        gr4 = 4 * 4 / 25
                    End If
                    If sub5 >= 90 Then
                        gr5 = 10 * 4 / 25
                    ElseIf sub5 >= 80 Then
                        gr5 = 9 * 4 / 25
                    ElseIf sub5 >= 70 Then
                        gr5 = 8 * 4 / 25
                    ElseIf sub5 >= 60 Then
                        gr5 = 7 * 4 / 25
                    ElseIf sub5 >= 50 Then
                        gr5 = 6 * 4 / 25
                    ElseIf sub5 >= 36 Then
                        gr5 = 5 * 4 / 25
                    Else
                        gr5 = 4 * 4 / 25
                    End If
                    If sub6 >= 90 Then
                        gr6 = 10 * 6 / 25
                    ElseIf sub6 >= 80 Then
                        gr6 = 9 * 6 / 25
                    ElseIf sub6 >= 70 Then
                        gr6 = 8 * 6 / 25
                    ElseIf sub6 >= 60 Then
                        gr6 = 7 * 6 / 25
                    ElseIf sub6 >= 50 Then
                        gr6 = 6 * 6 / 25
                    ElseIf sub6 >= 36 Then
                        gr6 = 5 * 6 / 25
                    Else
                        gr6 = 4 * 6 / 25
                    End If
                    gr7 = sub7 * 10 / 25
                    sgpa = gr1 + gr2 + gr3 + gr4 + gr5 + gr6 + gr7
                    Label10.Show()
                    TextBox14.Text = sgpa
                    TextBox14.Show()
                    TextBox14.ReadOnly = True
                End If
            Else
                MsgBox("Wrong Data Entered! Check Again!")
            End If
        Else
            If IsNumeric(TextBox1.Text) And _
                IsNumeric(TextBox2.Text) And _
                IsNumeric(TextBox3.Text) And _
                IsNumeric(TextBox4.Text) And _
                IsNumeric(TextBox5.Text) And _
                IsNumeric(TextBox6.Text) And _
                IsNumeric(TextBox13.Text) Then
                Button1.Enabled = False
                sub1 = CType(TextBox1.Text, Integer) + CType(TextBox2.Text, Integer)
                sub2 = CType(TextBox3.Text, Integer) + CType(TextBox4.Text, Integer)
                sub3 = CType(TextBox5.Text, Integer) + CType(TextBox6.Text, Integer)
                sub4 = CType(TextBox13.Text, Decimal)
                If sub1 > 100 Or _
                    sub2 > 100 Or _
                    sub3 > 300 Or _
                    sub4 > 2 Then
                    MsgBox("Wrong Data Entered! Check Again!")
                Else
                    If sub1 >= 90 Then
                        gr1 = 10 * 4 / 25
                    ElseIf sub1 >= 80 Then
                        gr1 = 9 * 4 / 25
                    ElseIf sub1 >= 70 Then
                        gr1 = 8 * 4 / 25
                    ElseIf sub1 >= 60 Then
                        gr1 = 7 * 4 / 25
                    ElseIf sub1 >= 50 Then
                        gr1 = 6 * 4 / 25
                    ElseIf sub1 >= 36 Then
                        gr1 = 5 * 4 / 25
                    Else
                        gr1 = 4 * 4 / 25
                    End If
                    If sub2 >= 90 Then
                        gr2 = 10 * 4 / 25
                    ElseIf sub2 >= 80 Then
                        gr2 = 9 * 4 / 25
                    ElseIf sub2 >= 70 Then
                        gr2 = 8 * 4 / 25
                    ElseIf sub2 >= 60 Then
                        gr2 = 7 * 4 / 25
                    ElseIf sub2 >= 50 Then
                        gr2 = 6 * 4 / 25
                    ElseIf sub2 >= 36 Then
                        gr2 = 5 * 4 / 25
                    Else
                        gr2 = 4 * 4 / 25
                    End If
                    If sub3 >= 90 Then
                        gr3 = 10 * 15 / 25
                    ElseIf sub3 >= 80 Then
                        gr3 = 9 * 15 / 25
                    ElseIf sub3 >= 70 Then
                        gr3 = 8 * 15 / 25
                    ElseIf sub3 >= 60 Then
                        gr3 = 7 * 15 / 25
                    ElseIf sub3 >= 50 Then
                        gr3 = 6 * 15 / 25
                    ElseIf sub3 >= 36 Then
                        gr3 = 5 * 15 / 25
                    Else
                        gr3 = 4 * 15 / 25
                    End If
                End If
                gr4 = sub4 * 10 / 25
                sgpa = gr1 + gr2 + gr3 + gr4
                Label10.Show()
                TextBox14.Text = sgpa
                TextBox14.Show()
                TextBox14.ReadOnly = True
            Else
                MsgBox("Wrong Data Entered! Check Again!")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        Button1.Enabled = True
        TextBox14.Text = ""
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
        If ComboBox1.SelectedIndex = 0 Then
                Dim p1 As String = "\sem1.txt"
                Dim wr = New System.IO.StreamWriter("\sem1.txt")
                wr.WriteLine(TextBox1.Text)
                wr.WriteLine(TextBox2.Text)
                wr.WriteLine(TextBox3.Text)
                wr.WriteLine(TextBox4.Text)
                wr.WriteLine(TextBox5.Text)
                wr.WriteLine(TextBox6.Text)
                wr.WriteLine(TextBox7.Text)
                wr.WriteLine(TextBox8.Text)
                wr.WriteLine(TextBox9.Text)
                wr.WriteLine(TextBox10.Text)
                wr.WriteLine(TextBox11.Text)
                wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
            wr.WriteLine(TextBox14.Text)

            wr.Close()
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Dim p2 As String = "\sem2.txt"
            Dim wr = New System.IO.StreamWriter("\sem2.txt")
            wr.WriteLine(TextBox1.Text)
            wr.WriteLine(TextBox2.Text)
            wr.WriteLine(TextBox3.Text)
            wr.WriteLine(TextBox4.Text)
            wr.WriteLine(TextBox5.Text)
            wr.WriteLine(TextBox6.Text)
            wr.WriteLine(TextBox7.Text)
            wr.WriteLine(TextBox8.Text)
            wr.WriteLine(TextBox9.Text)
            wr.WriteLine(TextBox10.Text)
            wr.WriteLine(TextBox11.Text)
            wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
            wr.WriteLine(TextBox14.Text)
            wr.Close()
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Dim p3 As String = "\sem3.txt"
            Dim wr = New System.IO.StreamWriter("\sem3.txt")
            wr.WriteLine(TextBox1.Text)
            wr.WriteLine(TextBox2.Text)
            wr.WriteLine(TextBox3.Text)
            wr.WriteLine(TextBox4.Text)
            wr.WriteLine(TextBox5.Text)
            wr.WriteLine(TextBox6.Text)
            wr.WriteLine(TextBox7.Text)
            wr.WriteLine(TextBox8.Text)
            wr.WriteLine(TextBox9.Text)
            wr.WriteLine(TextBox10.Text)
            wr.WriteLine(TextBox11.Text)
            wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
           wr.WriteLine(TextBox14.Text)
            wr.Close()
        End If
        If ComboBox1.SelectedIndex = 3 Then
            Dim p4 As String = "\sem4.txt"
            Dim wr = New System.IO.StreamWriter("\sem4.txt")
            wr.WriteLine(TextBox1.Text)
            wr.WriteLine(TextBox2.Text)
            wr.WriteLine(TextBox3.Text)
            wr.WriteLine(TextBox4.Text)
            wr.WriteLine(TextBox5.Text)
            wr.WriteLine(TextBox6.Text)
            wr.WriteLine(TextBox7.Text)
            wr.WriteLine(TextBox8.Text)
            wr.WriteLine(TextBox9.Text)
            wr.WriteLine(TextBox10.Text)
            wr.WriteLine(TextBox11.Text)
            wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
           wr.WriteLine(TextBox14.Text)
            wr.Close()
        End If
        If ComboBox1.SelectedIndex = 4 Then
            Dim p5 As String = "\sem5.txt"
            Dim wr = New System.IO.StreamWriter("\sem5.txt")
            wr.WriteLine(TextBox1.Text)
            wr.WriteLine(TextBox2.Text)
            wr.WriteLine(TextBox3.Text)
            wr.WriteLine(TextBox4.Text)
            wr.WriteLine(TextBox5.Text)
            wr.WriteLine(TextBox6.Text)
            wr.WriteLine(TextBox7.Text)
            wr.WriteLine(TextBox8.Text)
            wr.WriteLine(TextBox9.Text)
            wr.WriteLine(TextBox10.Text)
            wr.WriteLine(TextBox11.Text)
            wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
           wr.WriteLine(TextBox14.Text)
            wr.Close()
        End If
        If ComboBox1.SelectedIndex = 5 Then
            Dim p6 As String = "\sem6.txt"
            Dim wr = New System.IO.StreamWriter("\sem6.txt")
            wr.WriteLine(TextBox1.Text)
            wr.WriteLine(TextBox2.Text)
            wr.WriteLine(TextBox3.Text)
            wr.WriteLine(TextBox4.Text)
            wr.WriteLine(TextBox5.Text)
            wr.WriteLine(TextBox6.Text)
            wr.WriteLine(TextBox7.Text)
            wr.WriteLine(TextBox8.Text)
            wr.WriteLine(TextBox9.Text)
            wr.WriteLine(TextBox10.Text)
            wr.WriteLine(TextBox11.Text)
            wr.WriteLine(TextBox12.Text)
            wr.WriteLine(TextBox13.Text)
           wr.WriteLine(TextBox14.Text)
            wr.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        If Button1.Enabled = False Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ComboBox1.SelectedIndex = 0 Then
            Dim p1 As String = "\sem1.txt"
            If System.IO.File.Exists(p1) Then
                Dim re = New System.IO.StreamReader("\sem1.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p1)
            End If
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Dim p2 As String = "\sem2.txt"
            If System.IO.File.Exists(p2) Then
                Dim re = New System.IO.StreamReader("\sem2.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p2)
            End If
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Dim p3 As String = "\sem3.txt"
            If System.IO.File.Exists(p3) Then
                Dim re = New System.IO.StreamReader("\sem3.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p3)
            End If
        End If
        If ComboBox1.SelectedIndex = 3 Then
            Dim p4 As String = "\sem4.txt"
            If System.IO.File.Exists(p4) Then
                Dim re = New System.IO.StreamReader("\sem4.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p4)
            End If
        End If
        If ComboBox1.SelectedIndex = 4 Then
            Dim p5 As String = "\sem5.txt"
            If System.IO.File.Exists(p5) Then
                Dim re = New System.IO.StreamReader("\sem5.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p5)
            End If
        End If
        If ComboBox1.SelectedIndex = 5 Then
            Dim p6 As String = "\sem6.txt"
            If System.IO.File.Exists(p6) Then
                Dim re = New System.IO.StreamReader("\sem6.txt")
                TextBox1.Text = re.ReadLine
                TextBox2.Text = re.ReadLine
                TextBox3.Text = re.ReadLine
                TextBox4.Text = re.ReadLine
                TextBox5.Text = re.ReadLine
                TextBox6.Text = re.ReadLine
                TextBox7.Text = re.ReadLine
                TextBox8.Text = re.ReadLine
                TextBox9.Text = re.ReadLine
                TextBox10.Text = re.ReadLine
                TextBox11.Text = re.ReadLine
                TextBox12.Text = re.ReadLine
                TextBox13.Text = re.ReadLine
                TextBox14.Text = re.ReadLine
                re.Close()
            Else
                System.IO.File.Create(p6)
            End If
        End If
    End Sub
End Class