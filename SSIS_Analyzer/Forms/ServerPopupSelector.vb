Imports System.ComponentModel

Public Class ServerPopupSelector

    Public result As SqlClient.SqlConnectionStringBuilder
    Public jobResult As Microsoft.SqlServer.Management.Smo.Agent.Job
    Dim expandedSize As Integer = 475
    Dim shrunkSize As Integer = 300
    Dim configFile As Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)
    Dim config As Configuration.KeyValueConfigurationCollection = configFile.AppSettings.Settings
    Dim defaultLogin As String
    Public jobPanelVisible As Boolean = False
    Public packagePanelVisible As Boolean = False

    Private Sub okBttn_Click(sender As Object, e As EventArgs) Handles okBttn.Click
        'If there is something in the server textbox
        If Me.serverComboBox.Text <> "" Then
            'If they asked me to save their preferences
            If saveCheckBox.Checked Then
                'Get the server login
                config("default_server_login").Value = IIf(windowsAuthRadioButton.Checked, "Windows Auth", userNameTextBox.Text)
                'Save the configuration file
                configFile.Save()
            End If
            Dim sqlConnectionString As New System.Data.SqlClient.SqlConnectionStringBuilder
            With sqlConnectionString
                .DataSource = serverComboBox.Text
                .IntegratedSecurity = windowsAuthRadioButton.Checked
                If Not windowsAuthRadioButton.Checked Then
                    .UserID = userNameTextBox.Text
                    .Password = passwordTextBox.Text
                End If
                .PersistSecurityInfo = True
            End With
            If jobPanelVisible Then
                'set the job result to the selected job

            Else
                'Set the result to the server
                result = sqlConnectionString
            End If
            'Set the result of this form to vbOk
            Me.DialogResult = vbOK
            'Minimize this form (Next form needs to use result and close it)
            Me.WindowState = FormWindowState.Minimized
            'Open the SSIS Viewer back up
            'Application.OpenForms.Item("SsisViewer").Activate()
        Else
            MsgBox("Please select or type a server", Title:="Add Project From Server")
        End If
    End Sub

    Private Sub serverComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles serverComboBox.KeyPress
        'If the key pressed was Chr(13) [enter]
        If (e.KeyChar = Chr(13)) Then
            'Press OK for the user
            okBttn_Click(Me, EventArgs.Empty)
            'Enter isn't actually needed in the comboBox, so we 'handled' it
            e.Handled = True 'Makes it not print enter in the comboBox.text
        End If
    End Sub

    Private Sub ServerConnection_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If result Is Nothing Then
            Me.DialogResult = vbCancel
            Me.Dispose()
        Else
            Me.DialogResult = vbOK
        End If
    End Sub

    Private Sub folderComboBox_DropDown(sender As Object, e As EventArgs) Handles folderComboBox.DropDown
        'If the Server is something
        If serverComboBox.Text <> "" Then
            Dim sqlConnectionString As New SqlClient.SqlConnectionStringBuilder
            sqlConnectionString = getSqlConnectionString(serverComboBox.Text, windowsAuthRadioButton.Checked, userNameTextBox.Text, passwordTextBox.Text)
            'Get a list of folders from the Server
            Dim folders As List(Of String) = Import.getFolders(sqlConnectionString)
            'If the result is empty
            If folders.Count = 1 Then
                If folders(0) = "Exception: login" Then
                    Dim cust As New MyMsgBox
                    cust.title = "Error: Unable to Login"
                    'TODO: Error number? Error picture?
                    cust.msg = "Unable to retrieve data from this server. Check your permissions and spelling."
                    'TODO: Show vs ShowDialog? Looked at this before, forgot already
                    cust.ShowDialog()
                ElseIf folders(0) = "Exception: catalog" Then
                    Dim cust As New MyMsgBox
                    cust.title = "Error: No SSISDB catalog"
                    'TODO: Error number? Error picture?
                    cust.msg = "Unable to find catalog named SSISDB. There might not be a 'SSISDB' Catalog, or you might not have permission to view it with this account."
                    'TODO: Show vs ShowDialog? Looked at this before, forgot already
                    cust.ShowDialog()
                End If
            Else
                'Clear the list
                folderComboBox.Items.Clear()
                'Add them all at once to the list of folders
                folderComboBox.Items.AddRange(folders.ToArray)
            End If
        End If
    End Sub

    Private Sub projectComboBox_DropDown(sender As Object, e As EventArgs) Handles projectComboBox.DropDown
        'If the server and folder are filled out
        If serverComboBox.Text <> "" And folderComboBox.Text <> "" Then
            'Get projects from the Server name + Folder name
            Dim documents As List(Of String) = Import.getProjects(serverComboBox.Text, folderComboBox.Text)
            'Clear the current list
            projectComboBox.Items.Clear()
            'Add them to the project list
            projectComboBox.Items.AddRange(documents.ToArray)
        End If
    End Sub

    Private Sub serverComboBox_DropDown(sender As Object, e As EventArgs) Handles serverComboBox.DropDown
        If config("server_list_of_strings") IsNot Nothing Then
            serverComboBox.Items.Clear()
            For Each usedServer As String In config("server_list_of_strings").Value.Split(",")
                'Debug.Print(usedServer)
                serverComboBox.Items.Add(usedServer)
            Next
        End If
    End Sub

    Private Sub expandButton_Click(sender As Object, e As EventArgs) Handles expandButton.Click
        If expandButton.Text = "+" Then
            Me.Height = expandedSize
            expandButton.Text = "-"
        Else
            Me.Height = shrunkSize
            expandButton.Text = "+"
        End If
    End Sub

    Private Sub windowsAuthRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles windowsAuthRadioButton.CheckedChanged
        userNameTextBox.Enabled = False
        passwordTextBox.Enabled = False
    End Sub

    Private Sub otherLoginRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles otherLoginRadioButton.CheckedChanged
        userNameTextBox.Enabled = True
        passwordTextBox.Enabled = True
    End Sub

    Private Sub ServerPopupSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Make sure I didn't forget to shrink it (Nice to edit in maximized size)
        Me.Height = shrunkSize
        jobPanel.Visible = jobPanelVisible
        packagePanel.Visible = packagePanelVisible
        'If there is a config setting
        If config("default_server_login") IsNot Nothing Then
            'Get the value
            defaultLogin = config("default_server_login").Value
            'If it's Windows Auth
            If defaultLogin = "Windows Auth" Then
                'Set default label
                defaultLabel.Text = defaultLogin
            Else
                'Check custom
                otherLoginRadioButton.Checked = True
                'Set username (TODO: Maybe?: No passwords saved?)
                userNameTextBox.Text = defaultLogin
                'Set default label
                defaultLabel.Text = "Saved Username"
            End If
            'Else no config setting
        Else
            'Add config with value of Windows Auth
            config.Add("default_server_login", "Windows Auth")
            'Save the configFile
            configFile.Save()
            'Set default label
            defaultLabel.Text = "Windows Auth"
        End If

    End Sub

    Private Sub useDefaultCheckBox_Click(sender As Object, e As EventArgs) Handles useDefaultCheckBox.Click
        'Toggle enabled status (opposite of checked --> If use default, disable radio buttons)
        windowsAuthRadioButton.Enabled = Not useDefaultCheckBox.Checked
        otherLoginRadioButton.Enabled = Not useDefaultCheckBox.Checked
        If useDefaultCheckBox.Checked Then
            'Setup default
            If defaultLogin = "Windows Auth" Then
                windowsAuthRadioButton.Checked = True
            Else
                otherLoginRadioButton.Checked = True
                userNameTextBox.Text = defaultLogin
            End If

        End If
    End Sub

    Private Sub jobComboBox_DropDown(sender As Object, e As EventArgs) Handles jobComboBox.DropDown
        If serverComboBox.Text <> "" Then
            'Clear previous options
            jobComboBox.Items.Clear()
            Dim sqlConnectionString As SqlClient.SqlConnectionStringBuilder
            sqlConnectionString = getSqlConnectionString(serverComboBox.Text, windowsAuthRadioButton.Checked, userNameTextBox.Text, passwordTextBox.Text)
            Dim sqlConnection As SqlClient.SqlConnection = New SqlClient.SqlConnection(sqlConnectionString.ConnectionString)
            'Get jobs from server
            Dim conn As Microsoft.SqlServer.Management.Common.ServerConnection = New Microsoft.SqlServer.Management.Common.ServerConnection(sqlConnection)

            Dim test = getJobsFromServerConnection(conn)
            Dim myArr(test.Count - 1) As Microsoft.SqlServer.Management.Smo.Agent.Job
            test.CopyTo(myArr, 0)
            'Debug.Print("Jobs got: " & getJobsFromServerConnection(conn).ToString)
            jobComboBox.Items.AddRange(myArr)
        End If
    End Sub

    Private Function getJobsFromServerConnection(conn As Microsoft.SqlServer.Management.Common.ServerConnection) As Microsoft.SqlServer.Management.Smo.Agent.JobCollection
        Try
            conn.Connect()
            Dim server As Microsoft.SqlServer.Management.Smo.Server = New Microsoft.SqlServer.Management.Smo.Server(conn)
            getJobsFromServerConnection = server.JobServer.Jobs
            Return getJobsFromServerConnection
        Catch ex As Exception
            Debug.Print("Error in conection: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Function getSqlConnectionString(dataSource As String, integratedSecurity As Boolean, Optional username As String = "", Optional password As String = "") As SqlClient.SqlConnectionStringBuilder
        getSqlConnectionString = New SqlClient.SqlConnectionStringBuilder
        With getSqlConnectionString
            .DataSource = dataSource
            If integratedSecurity Then
                .IntegratedSecurity = integratedSecurity
            Else
                .UserID = username
                .Password = password
            End If
            .PersistSecurityInfo = True
        End With
        Return getSqlConnectionString
    End Function
End Class