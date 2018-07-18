Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo.Agent

Public Class JobViewer

    Dim currentJob As Job

    Private Sub JobViewer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        launcher.WindowState = FormWindowState.Normal
    End Sub

    ''' <summary>
    ''' Creates a DataTable filled from the results of SQL command
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    Private Function GetDataTable(SQL As String) As DataTable

        Dim objConnString As New SqlConnectionStringBuilder

        With objConnString
            .DataSource = serverComboBox.Text
            .InitialCatalog = "msdb"
            .IntegratedSecurity = True
            .PersistSecurityInfo = True
        End With

        Using objSQLConn As New SqlConnection(objConnString.ConnectionString)

            Using objSQLCmd As New SqlCommand(SQL, objSQLConn)
                objSQLConn.Open()
                Using objSQLData As New SqlDataAdapter(objSQLCmd)
                    Dim mydatatable = New DataTable()
                    objSQLData.Fill(mydatatable)
                    Return mydatatable
                End Using
            End Using
        End Using

    End Function

    Private Sub jobNameComboBox_DropDown(sender As Object, e As EventArgs) Handles jobNameComboBox.DropDown
        If serverComboBox.Text <> "" Then
            'Clear previous options
            jobNameComboBox.Items.Clear()
            'Get jobs from server
            Dim conn As ServerConnection = New ServerConnection(serverComboBox.Text)
            Dim server As Microsoft.SqlServer.Management.Smo.Server = New Microsoft.SqlServer.Management.Smo.Server(conn)
            Try
                conn.Connect()
                For i = 0 To server.JobServer.Jobs.Count - 1
                    'Add to comboBox
                    jobNameComboBox.Items.Add(server.JobServer.Jobs.Item(i))
                Next
            Catch ex As Exception
                Debug.Print("Error in conection: " & ex.GetBaseException.ToString)
            End Try
        End If
    End Sub

    Private Sub jobNameComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles jobNameComboBox.SelectedValueChanged
        'If there is something in both boxes
        If serverComboBox.Text <> "" And jobNameComboBox.Text <> "" Then
            'statusLabel.Text = "Loading job. . ."
            scheduleListBox.Items.Clear()
            'Get jobs from server
            Dim conn As ServerConnection = New ServerConnection(serverComboBox.Text)
            Dim server As Microsoft.SqlServer.Management.Smo.Server = New Microsoft.SqlServer.Management.Smo.Server(conn)
            currentJob = server.JobServer.Jobs(jobNameComboBox.Text)
            'statusLabel.Text = "Job loaded"
            updateOverview()
        End If
    End Sub

    ''' <summary>
    ''' Returns the ExecutionID from the row of the current job's Enum History
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Function getExecutionID(row As Integer)
        Dim cellValue As String = ""

        'Get the message of the current job's enum history
        cellValue = jobHistoryDataGridView.Rows.Item(row).Cells.Item(2).Value

        '
        If InStr(cellValue, "Execution ID:") <> 0 Then
            cellValue = Strings.Right(cellValue, Len(cellValue) - InStr(cellValue, "Execution ID:") - Len("Execution ID:"))
            cellValue = Strings.Left(cellValue, InStr(cellValue, ",") - 1)
        Else
            cellValue = ""
        End If
        Return cellValue
    End Function

    ''' <summary>
    ''' Update the form for the current job
    ''' </summary>
    Sub updateOverview()
        'Enabled
        enabledTextBox.Text = currentJob.IsEnabled.ToString
        'Description
        descriptionTextBox.Text = currentJob.Description
        'Last run date
        lastRunDateTextBox.Text = currentJob.LastRunDate
        'last run outcome
        lastRunOutcomeTextBox.Text = currentJob.LastRunOutcome.ToString
        'last run duration
        Dim total As TimeSpan
        For Each mystep As JobStep In currentJob.JobSteps
            Dim temp As TimeSpan
            TimeSpan.TryParse(Format(mystep.LastRunDuration, "00:00:00"), temp)
            total = total + temp
        Next
        lastRunDurationTextBox.Text = total.ToString
        'Next run date
        nextRunDateTextBox.Text = currentJob.NextRunDate
        'current run status
        currentRunStatusTextBox.Text = currentJob.CurrentRunStatus.ToString
        'Proxy
        proxyTextBox.Text = IIf(currentJob.HasStep, currentJob.JobSteps(0).ProxyName, "")
        'Owner ID
        ownerTextBox.Text = currentJob.OwnerLoginName
        'Getting Schedule
        scheduleListBox.Items.Clear()

        For Each schedule As JobSchedule In currentJob.JobSchedules
            Dim myDataTable As DataTable = GetDataTable("dbo.sp_help_jobschedule @job_id='" & currentJob.JobID.ToString & "', @schedule_name='" & schedule.Name & "', @include_description=1")
            Dim badSchedule As String = myDataTable.Rows(0).Item("schedule_description")
            Dim niceSchedule As String = ""
            For Each c In Strings.Split(badSchedule, " ")
                If IsNumeric(c) <> 0 And Len(c) > 4 Then
                    niceSchedule = niceSchedule & " " & IIf(Len(c) = 5, "0" & Strings.Left(c, 1), Strings.Left(c, 2)) & ":" & Strings.Mid(c, 3, 2) & ":" & Strings.Right(c, 2)
                Else
                    niceSchedule = niceSchedule & " " & c
                End If

            Next
            scheduleListBox.Items.Add(IIf(schedule.IsEnabled, "Enabled: ", "Disabled: ") & niceSchedule)
        Next
        'Getting Commands
        commandsListBox.Items.Clear()

        For Each steps As JobStep In currentJob.JobSteps
            commandsListBox.Items.Add(steps.Command)
        Next
        jobHistoryDataGridView.DataSource = currentJob.EnumHistory

        'Top execution id
        'Reset ExecutionId
        lastExecutionIDTextBox.Text = ""
        Dim myrow As Integer    'A row counter
        'While there is no executionid and the row is less than the number of rows
        Do While lastExecutionIDTextBox.Text = "" And myrow < jobHistoryDataGridView.Rows.Count
            'Set the execution id equal to getExecutionId
            lastExecutionIDTextBox.Text = getExecutionID(myrow).ToString
            'Increase the row count
            myrow = myrow + 1
        Loop
    End Sub

    Private Sub scheduleListBox_DoubleClick(sender As Object, e As EventArgs) Handles scheduleListBox.DoubleClick
        'If there is a selected schedule
        If scheduleListBox.SelectedItem IsNot Nothing Then
            'Display it in my msgbox
            Dim custMsg As New MyMsgBox
            custMsg.title = "Schedule #" & (scheduleListBox.SelectedIndex + 1).ToString
            custMsg.msg = scheduleListBox.SelectedItem.ToString
            custMsg.Show()
        End If
    End Sub

    Private Sub commandsListBox_DoubleClick(sender As Object, e As EventArgs) Handles commandsListBox.DoubleClick
        'If there is a command selected
        If commandsListBox.SelectedItem IsNot Nothing Then
            'Display it in my msgbox
            Dim custMsg As New MyMsgBox
            custMsg.msg = commandsListBox.SelectedItem.ToString
            custMsg.title = "Command #" & (commandsListBox.SelectedIndex + 1).ToString
            custMsg.Show()
        End If
    End Sub

    ''' <summary>
    ''' Returns the SQL statement from #Chris_Waller for execution history.
    ''' Adds each execution id to the SQL.
    ''' </summary>
    ''' <param name="execId"></param>
    ''' <returns></returns>
    Function sqlExecutionInfoStatement(execId() As Integer) As Text.StringBuilder
        sqlExecutionInfoStatement = New Text.StringBuilder
        With sqlExecutionInfoStatement
            .Append("Select  CONVERT(DATETIME, a.message_time) As message_time , ")
            .Append("CASE a.message_type ")
            .Append("When -1 Then 'Unknown' ")
            .Append("WHEN 10 THEN 'Pre-validate' ")
            .Append("WHEN 20 THEN 'Post-validate' ")
            .Append("WHEN 30 THEN 'Pre-execute' ")
            .Append("WHEN 40 THEN 'Post-execute' ")
            .Append("WHEN 50 THEN 'StatusChange' ")
            .Append("WHEN 60 THEN 'Progress' ")
            .Append("WHEN 70 THEN 'Information' ")
            .Append("WHEN 80 THEN 'VariableValueChanged' ")
            .Append("WHEN 90 THEN 'Diagnostic' ")
            .Append("WHEN 100 THEN 'QueryCancel' ")
            .Append("WHEN 110 THEN 'Warning' ")
            .Append("WHEN 120 THEN 'Error' ")
            .Append("WHEN 130 THEN 'TaskFailed' ")
            .Append("WHEN 140 THEN 'DiagnosticEx' ")
            .Append("WHEN 200 THEN 'Custom' ")
            .Append("WHEN 400 THEN 'NonDiagnostic' ")
            .Append("END AS message_type, ")
            .Append("a.message_source_name, ")
            .Append("a.message, ")
            .Append("a.execution_path, ")
            .Append("IIF(a.message_type IN (120, 130), 1, 0) AS is_error ")
            .Append("FROM SSISDB.catalog.event_messages a WITH ( READUNCOMMITTED ) ")
            .Append("WHERE a.operation_id = ")
            'For each execution ID (minus the last one)
            For c = 0 To execId.Count - 2
                'Append it with a comma and space (2, 3, 4, )
                .Append(execId(c).ToString)
                .Append(", ")
            Next
            'Append the last execution id... now it looks like(2, 3, 4, 5)
            .Append(execId(execId.Count - 1).ToString & " ")
            .Append("ORDER BY a.message_time DESC")
        End With
        Return sqlExecutionInfoStatement
    End Function

    Private Sub jobHistoryDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles jobHistoryDataGridView.SelectionChanged
        If jobHistoryDataGridView.SelectedCells.Count <> 0 Then
            If jobHistoryDataGridView.Rows.Item(0).Cells.Item(0).Value.ToString <> "" Then
                jobDateTextBox.Text = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(9).Value
                Dim jobMessage As String = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(2).Value
                If Not InStr(jobMessage, "The job ") <> 0 Then
                    jobMessage = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(2).Value
                End If
                jobOutcomeTextBox.Text = Strings.Left(jobMessage, InStr(Len("The job "), jobMessage, "."))
                jobDurationTextBox.Text = Format(jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(10).Value, "00:00:00")
                jobMessageTextBox.Text = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(2).Value.ToString.Replace("  ", vbCrLf)
                stepIdTextBox.Text = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(3).Value
                stepNameTextBox.Text = jobHistoryDataGridView.Rows.Item(jobHistoryDataGridView.SelectedCells(0).RowIndex).Cells.Item(4).Value
                executionIdTextBox.Text = getExecutionID(jobHistoryDataGridView.SelectedCells(0).RowIndex)
            End If
        End if
    End Sub

    Private Sub lastExecutionIdLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lastExecutionIdLinkLabel.LinkClicked
        If IsNumeric(lastExecutionIDTextBox.Text) Then
            Dim viewer As New ExecutionId
            viewer.myDataTable = GetDataTable(sqlExecutionInfoStatement({CType(lastExecutionIDTextBox.Text, Integer)}).ToString)
            viewer.myExecutionId = lastExecutionIDTextBox.Text
            viewer.Show()
        End If
    End Sub

    Private Sub executionIdLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles executionIdLinkLabel.LinkClicked
        If IsNumeric(executionIdTextBox.Text) Then
            Dim viewer As New ExecutionId
            viewer.myDataTable = GetDataTable(sqlExecutionInfoStatement({CType(executionIdTextBox.Text, Integer)}).ToString)
            viewer.myExecutionId = executionIdTextBox.Text
            viewer.Show()
        End If
    End Sub

    Private Sub viewExecutionRprtBtn_Click(sender As Object, e As EventArgs) Handles viewExecutionRprtBtn.Click
        executionIdLinkLabel_LinkClicked(Me, New LinkLabelLinkClickedEventArgs(executionIdLinkLabel.Links(0)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As New ServerPopupSelector
        test.jobPanelVisible = True
        test.Show()
    End Sub

    Private Sub jobNameComboBox_DoubleClick(sender As Object, e As EventArgs) Handles jobNameComboBox.DoubleClick

    End Sub
End Class