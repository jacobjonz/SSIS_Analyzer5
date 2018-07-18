Public Class ExecutionId
    Public myExecutionId As Integer
    Public myDataTable As DataTable

    Private Sub ExecutionId_Load(sender As Object, e As EventArgs) Handles Me.Load
        executionDataGridView.DataSource = myDataTable
        titleLabel.Text = titleLabel.Text & myExecutionId.ToString
    End Sub

    Private Sub executionDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles executionDataGridView.SelectionChanged
        If executionDataGridView.SelectedCells.Count <> 0 Then
            If Not executionDataGridView.SelectedRows(0).Index = executionDataGridView.RowCount - 1 Then
                messageTextBox.Text = executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(3).Value
                msgTimeTextBox.Text = executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(0).Value
                msgTypeTextBox.Text = executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(1).Value
                msgSrcNameTextBox.Text = executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(2).Value
                execPathTextBox.Text = executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(4).Value
                isErrorTextBox.Text = CType(executionDataGridView.Rows(executionDataGridView.SelectedCells(0).RowIndex).Cells.Item(5).Value, Boolean)
            End If
        End If
    End Sub
End Class