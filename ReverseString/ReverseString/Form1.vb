Option Strict On

Public Class Form1

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        ' Read the input from the user
        Dim st As String
        st = InputBox("Please type the initial string")

        ' Compute the result
        Dim result As String = ""
        Dim length As Integer
        length = st.Length()
        For i = length - 1 To 0 Step -1
            result = result & st.Chars(i)
        Next

        ' Report the output to the user
        MessageBox.Show(result)

    End Sub
End Class
