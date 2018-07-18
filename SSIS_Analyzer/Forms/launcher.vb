Public Class launcher
    Private Sub ssisViewerButton_Click(sender As Object, e As EventArgs) Handles ssisViewerButton.Click
        SsisViewer.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub oldViewerButton_Click(sender As Object, e As EventArgs) Handles oldViewerButton.Click
        Form1.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub jobViewerButton_Click(sender As Object, e As EventArgs) Handles jobViewerButton.Click
        JobViewer.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub jobViewerLabel_Click(sender As Object, e As EventArgs) Handles jobViewerLabel.Click
        jobViewerButton_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ssisViewerLabel_Click(sender As Object, e As EventArgs) Handles ssisViewerLabel.Click
        ssisViewerButton_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub oldViewerLabel_Click(sender As Object, e As EventArgs) Handles oldViewerLabel.Click
        oldViewerButton_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("www.github.com/seadoggie01/SSIS_Analyzer")
    End Sub

    Private Sub oldViewerLabel_MouseHover(sender As Object, e As EventArgs) Handles oldViewerLabel.MouseHover
        oldViewerLabel.BackColor = SystemColors.ButtonShadow
        oldViewerButton.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub oldViewerLabel_MouseLeave(sender As Object, e As EventArgs) Handles oldViewerLabel.MouseLeave
        oldViewerLabel.BackColor = DefaultBackColor
        oldViewerButton.BackColor = DefaultBackColor
    End Sub

    Private Sub oldViewerButton_MouseHover(sender As Object, e As EventArgs) Handles oldViewerButton.MouseHover
        oldViewerLabel.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub oldViewerButton_MouseLeave(sender As Object, e As EventArgs) Handles oldViewerButton.MouseLeave
        oldViewerLabel.BackColor = DefaultBackColor
    End Sub
    Private Sub jobViewerLabel_MouseHover(sender As Object, e As EventArgs) Handles jobViewerLabel.MouseHover
        jobViewerLabel.BackColor = SystemColors.ButtonShadow
        jobViewerButton.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub jobViewerLabel_MouseLeave(sender As Object, e As EventArgs) Handles jobViewerLabel.MouseLeave
        jobViewerLabel.BackColor = DefaultBackColor
        jobViewerButton.BackColor = DefaultBackColor
    End Sub

    Private Sub jobViewerButton_MouseHover(sender As Object, e As EventArgs) Handles jobViewerButton.MouseHover
        jobViewerLabel.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub jobViewerButton_MouseLeave(sender As Object, e As EventArgs) Handles jobViewerButton.MouseLeave
        jobViewerLabel.BackColor = DefaultBackColor
    End Sub
    Private Sub ssisViewerLabel_MouseHover(sender As Object, e As EventArgs) Handles ssisViewerLabel.MouseHover
        ssisViewerLabel.BackColor = SystemColors.ButtonShadow
        ssisViewerButton.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ssisViewerLabel_MouseLeave(sender As Object, e As EventArgs) Handles ssisViewerLabel.MouseLeave
        ssisViewerLabel.BackColor = DefaultBackColor
        ssisViewerButton.BackColor = DefaultBackColor
    End Sub

    Private Sub ssisViewerButton_MouseHover(sender As Object, e As EventArgs) Handles ssisViewerButton.MouseHover
        ssisViewerLabel.BackColor = SystemColors.ButtonShadow
    End Sub

    Private Sub ssisViewerButton_MouseLeave(sender As Object, e As EventArgs) Handles ssisViewerButton.MouseLeave
        ssisViewerLabel.BackColor = DefaultBackColor
    End Sub
End Class