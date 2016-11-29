Public Class Form1
    'Nic Bailey
    '2nd Period 
    'September 8, 2016
    'To start learning how to code through a Slot Macine
    Dim myMoney As Integer = 10000, myBid As Integer = 100
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Text = myMoney
        TextBox4.Text = myBid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Integer.Parse(TextBox4.Text) >= Integer.Parse(TextBox5.Text)) Then
            MsgBox("You cannot bid more money than you have!")
        Else
            myBid = Integer.Parse(TextBox4.Text)
            updateSlots()
            checkSlots()
            TextBox5.Text = myMoney
        End If
    End Sub
    Private Function updateSlots()
        Dim rand As Random = New Random()
        Dim slots As New List(Of TextBox)
        slots.Add(TextBox1)
        slots.Add(TextBox2)
        slots.Add(TextBox3)
        For i As Integer = 0 To 2
            Dim r As Integer = rand.Next(9)
            slots(i).Text = r
            r = Nothing
        Next
    End Function
    Private Function checkSlots()
        Dim t1 As Integer = TextBox1.Text, t2 As Integer = TextBox2.Text, t3 As Integer = TextBox3.Text
        If ((t1 = t2) And t2 = t3) Then
            Label4.Text = "Triple Money!"
            myMoney += (myBid * 2)
        ElseIf ((t1 = t2) Or (t1 = t3) Or (t2 = t3)) Then
            Label4.Text = "Double Money!"
            myMoney += (myBid * 2)
        Else
            Label4.Text = "Bid Lost."
            myMoney -= myBid
        End If
    End Function
End Class

