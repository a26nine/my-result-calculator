Public Class Form8
    Dim cnt As Integer = 0
    Dim remain As Integer = 6
    Dim s1, s2, s3, s4, s5, s6, ndt, nd, tot, dr, remaind As Decimal
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim l1 As String = System.IO.File.ReadAllLines("\sem1.txt")(13)

            s1 = CType(l1, Decimal)
            If s1 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s1 = 0
        End Try

        Try
            Dim l2 As String = System.IO.File.ReadAllLines("\sem2.txt")(13)

            s2 = CType(l2, Decimal)
            If s2 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s2 = 0
        End Try
        Try
            Dim l3 As String = System.IO.File.ReadAllLines("\sem3.txt")(13)

            s3 = CType(l3, Decimal)
            If s3 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s3 = 0
        End Try
        Try
            Dim l4 As String = System.IO.File.ReadAllLines("\sem4.txt")(13)

            s4 = CType(l4, Decimal)
            If s4 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s4 = 0
        End Try
        Try
            Dim l5 As String = System.IO.File.ReadAllLines("\sem5.txt")(13)

            s5 = CType(l5, Decimal)
            If s5 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s5 = 0
        End Try
        Try
            Dim l6 As String = System.IO.File.ReadAllLines("\sem6.txt")(13)

            s6 = CType(l6, Decimal)
            If s6 > 0 Then
                cnt += 1
            End If
        Catch ex As Exception
            s6 = 0
        End Try
        tot = s1 + s3 + s4 + s5 + s6
        remain -= cnt
        remaind = CType(remain, Decimal)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value > 0 And NumericUpDown1.Value <= 5 Then
            NumericUpDown1.BackColor = Color.Red
        ElseIf NumericUpDown1.Value < 7 Then
            NumericUpDown1.BackColor = Color.DarkGreen
        ElseIf NumericUpDown1.Value <= 9 Then
            NumericUpDown1.BackColor = Color.DarkOrchid
        Else
            NumericUpDown1.BackColor = Color.LightSkyBlue
        End If
        dr = CType(NumericUpDown1.Value, Decimal)
        ndt = dr * 6.0
        nd = (ndt - tot) / remaind
        If nd > 0 Then
        If nd <= 10 Then
            TextBox1.Text = nd
            TextBox2.Text = dr
        Else
            MsgBox("This is not possible! :(")
            NumericUpDown1.Value -= 1
            End If
        Else
            TextBox1.Text = "-"
            TextBox2.Text = "-"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class