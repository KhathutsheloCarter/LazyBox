Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Advice1 As String
        Dim Advice2 As String
        Dim Advice3 As String


        Advice1 = txtAdvice1.Text

        Advice2 = txtAdvice2.Text

        Advice3 = txtAdvice3.Text

        MsgBox(Advice1 & vbNewLine & Advice2 & vbNewLine & Advice3)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        MsgBox("have a nice Day")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
