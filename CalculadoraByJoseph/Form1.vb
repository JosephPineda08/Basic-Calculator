Public Class Form1
    'Declaration of Variables
    Dim data1 As Nullable(Of Double) = Nothing ' The nullable function says that the value can be null.
    Dim data2 As Nullable(Of Double) = Nothing
    Dim ClickOpera As Boolean
    Dim operation As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click
        evaluation()
        TextBox1.Text &= "."
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        evaluation()
        TextBox1.Text &= "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        evaluation()
        TextBox1.Text &= "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        evaluation()
        TextBox1.Text &= "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        evaluation()
        TextBox1.Text &= "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        evaluation()
        TextBox1.Text &= "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        evaluation()
        TextBox1.Text &= "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        evaluation()
        TextBox1.Text &= "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        evaluation()
        TextBox1.Text &= "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        evaluation()
        TextBox1.Text &= "9"
    End Sub

    Public Sub PerformOperation() 'Evaluation of the operations
        ClickOpera = True
        data2 = Val(TextBox1.Text)
        If data1 IsNot Nothing Then
            Select Case operation
                Case "+"
                    data1 += data2
                Case "-"
                    data1 -= data2
                Case "*"
                    data1 *= data2
                Case "/"
                    data1 /= data2
                Case "%"
                    data1 = (data1 / 100) * data2
                Case "√"
                    data1 ^= 0.5

            End Select
            TextBox1.Text = data1
        Else
            data1 = data2
        End If
    End Sub
    Public Sub evaluation() 'Evaluation that allows us to concatenate more digits in the text box 
        If ClickOpera = True Then
            TextBox1.Text = ""
            ClickOpera = False
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBox1.Text = "0"
        data1 = Nothing
        data2 = Nothing

    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        PerformOperation()
        operation = "/"
    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles BtnMult.Click
        PerformOperation()
        operation = "*"
    End Sub

    Private Sub Btnsubstract_Click(sender As Object, e As EventArgs) Handles Btnsubstract.Click
        PerformOperation()
        operation = "-"
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        PerformOperation()
        operation = "+"
    End Sub

    Private Sub BtnRaiz_Click(sender As Object, e As EventArgs) Handles BtnRaiz.Click
        PerformOperation()
        operation = "√"
    End Sub

    Private Sub BtnPorc_Click(sender As Object, e As EventArgs) Handles BtnPorc.Click
        PerformOperation()
        operation = "%"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PerformOperation()
        operation = ""
    End Sub
End Class
