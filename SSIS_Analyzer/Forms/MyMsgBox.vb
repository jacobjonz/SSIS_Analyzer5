Public Class MyMsgBox

    Public title As String
    Public msg As String

    Private Sub MyMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = title
        Me.TextBox1.Text = msg
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class