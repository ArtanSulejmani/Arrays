Imports System.Drawing
Public Class Form1

    Dim g As Graphics
    Dim StrArray(2, 2)
    Dim IntArray(3, 3)

    Dim rnd As New Random

    'Dim ListofHorses As New List(Of Animal)

    Dim MyAnimals(4) As Animal

    Dim MyArray(9) As String
    Dim IndexPos As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()

        StrArray(0, 0) = "Hello"
        StrArray(1, 0) = "Youtube!"
        StrArray(2, 0) = "This"
        StrArray(2, 1) = "is"
        StrArray(2, 2) = "fun!"


        MyArray(0) = "Hello guys!"
        MyArray(1) = "How are you?"
        MyArray(2) = "Something new?"
        MyArray(3) = "Do you like programming?"
        MyArray(4) = "If Yes , why you chosse to learn VB.Net"
        MyArray(5) = "Terrible"
        MyArray(6) = "How about SQL"
        MyArray(7) = "And DataBase"
        MyArray(8) = "Good Luck!!!!"
        MyArray(9) = "BYE!"

        MyAnimals(0) = New Animal With {.AnimalType = "Horse", .Color = "Brown", .Quantity = 2}

        MsgBox(MyAnimals(0).AnimalType)

        NextArrayItem(0)
    End Sub

    Private Sub NextArrayItem(Index As Integer)
        IndexPos += Index

        If IndexPos < 0 Then
            IndexPos = 9
        ElseIf IndexPos > 9 Then
            IndexPos = 0
        End If

        Label1.Text = "Index: " & IndexPos

        TextBox1.Text = MyArray(IndexPos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NextArrayItem(-1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NextArrayItem(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        g.Clear(Color.FromName("Control"))


        For x = 0 To 2
            For y = 0 To 2
                g.DrawRectangle(Pens.Black, New Rectangle(x * 64, y * 64, 64, 64))
                g.DrawString(x & ":" & y & vbCrLf & StrArray(x, y), Me.Font, Brushes.Blue, New Point(x * 64, y * 64))
            Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        g.Clear(Color.FromName("Control"))

        For x = 0 To 3
            For y = 0 To 3
                IntArray(x, y) = rnd.Next(0, 100)
            Next
        Next
        For x = 0 To 3
            For y = 0 To 3
                g.DrawRectangle(Pens.Black, New Rectangle(x * 64, y * 64, 64, 64))
                g.DrawString(IntArray(x, y), Me.Font, Brushes.Blue, New Point(x * 64, y * 64))
            Next
        Next
    End Sub
End Class
