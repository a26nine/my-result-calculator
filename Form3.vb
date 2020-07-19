Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newform As New Form4
        newform.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim o1 = System.IO.File.Open("\sem1.txt", IO.FileMode.OpenOrCreate)
        Dim o2 = System.IO.File.Open("\sem2.txt", IO.FileMode.OpenOrCreate)
        Dim o3 = System.IO.File.Open("\sem3.txt", IO.FileMode.OpenOrCreate)
        Dim o4 = System.IO.File.Open("\sem4.txt", IO.FileMode.OpenOrCreate)
        Dim o5 = System.IO.File.Open("\sem5.txt", IO.FileMode.OpenOrCreate)
        Dim o6 = System.IO.File.Open("\sem6.txt", IO.FileMode.OpenOrCreate)
        o1.Close()
        o2.Close()
        o3.Close()
        o4.Close()
        o5.Close()
        o6.Close()
        Dim newform1 As New Form5
        newform1.show()
        Me.Close()
    End Sub
End Class