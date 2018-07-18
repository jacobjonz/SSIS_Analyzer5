Public Class launcher
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SsisViewer.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        JobViewer.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class