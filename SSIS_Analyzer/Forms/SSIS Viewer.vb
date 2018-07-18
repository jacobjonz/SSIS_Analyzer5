Imports System.Xml
Imports System.IO
Imports System.ComponentModel
Imports System.Net.NetworkInformation.NetworkInterface

Public Class SsisViewer
    Dim prevSelectedNode As New TreeNode
    Dim file As String

    ''' <summary>
    ''' Adds a project to the tree node. Returns false if user cancels file save
    ''' </summary>
    ''' <param name="searchDirectory"></param>
    ''' <returns>True or False if user cancels</returns>
    Private Function addFileToTree(Optional searchDirectory As String = "") As Boolean
        Dim node As New TreeNode
        Dim found As Boolean = False
        'If directory wasn't specified, ask the user which file to add
        If searchDirectory = "" Then
            Dim fileDialog As New OpenFileDialog
            fileDialog.DefaultExt() = "sln"
            fileDialog.Filter = "Solution Files (*.sln)|*.sln|All files(*.*)|*.*"
            fileDialog.Title = "Select a solution to anaylze. . ."
            fileDialog.Multiselect = False
            'Go to Visual Studio 2015 or 2010 Projects if it exists
            If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2015\Projects") Then
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2015\Projects"
            ElseIf Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2010\Projects") Then
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2010\Projects"
            End If
            Dim result = fileDialog.ShowDialog()

            'If the user canceled, then return false
            If Not result = DialogResult.OK Then Return False
            'Get the directory the user selected (Don't use the solution file)
            searchDirectory = fileDialog.FileName.Remove(InStrRev(fileDialog.FileName, "\"))
        End If
        Dim dir As New DirectoryInfo(searchDirectory)
        'if there are no packages in this directory
        If UpdateSsis.getPackagesFromProject(dir).Count = 0 Then
            'For each directory in the directory
            For Each c As DirectoryInfo In dir.GetDirectories
                'If it's not hidden
                If Not c.Attributes.HasFlag(FileAttributes.Hidden) Then
                    'Add this directory to the tree
                    node = projectTreeView.Nodes.Add(c.FullName + "\ (Project)")
                    found = True
                End If
            Next
            If Not found Then node = projectTreeView.Nodes.Add(dir.FullName + " (Project)")
        Else
            node = projectTreeView.Nodes.Add(dir.FullName + " (Project)")
        End If
        node.ImageIndex = 0
        treeviewExpansion(node, Strings.Left(node.Text, InStrRev(node.Text, " (Project)") - 1))
        Return True
    End Function

    'TODO: Again, could easily return T/F if successful
    Public Sub getSourceDestination(node As TreeNode, file As String)
        node.Nodes.Clear()
        Dim read As XmlReader = UpdateSsis.findDataFlowTask(removeNodeType(node.Text), file)
        Dim srcFinder As XmlReader = XmlReader.Create(file)
        Dim srcName As String
        Dim destName As String
        Dim destDesc As String
        Dim myNode As TreeNode
        Do While read.ReadToFollowing("component")
            'If it a destination
            If InStr(read.GetAttribute("componentClassID"), "Destination") <> 0 Then
                destName = read.GetAttribute("name")
                destDesc = read.GetAttribute("description")
                read.ReadToFollowing("inputColumn")
                If InStr(read.GetAttribute("lineageId"), ".Outputs") <> 0 Then
                    srcName = Strings.Left(read.GetAttribute("lineageId"), InStr(read.GetAttribute("lineageId"), ".Outputs") - 1)
                    Do
                        If srcFinder.GetAttribute("refId") = srcName Then
                            If Not node.Nodes.ContainsKey(destName + " (" + destDesc + ")") Then
                                'Match found!
                                myNode = node.Nodes.Add(srcFinder.GetAttribute("name") + " (" + srcFinder.GetAttribute("description") + ")")
                                myNode.ImageIndex = 3
                                myNode.SelectedImageIndex = 3
                                myNode = node.Nodes.Add(destName + " (" + destDesc + ")")
                                myNode.ImageIndex = 3
                                myNode.SelectedImageIndex = 3
                                'Move to next destination
                                Exit Do
                            End If
                        End If
                    Loop While srcFinder.ReadToFollowing("component")
                    'Reset the source
                    srcFinder = XmlReader.Create(file)
                End If
            End If
        Loop
    End Sub
    ''' <summary>
    ''' Removes types of nodes from the end of the name
    ''' </summary>
    ''' <param name="nodeName"></param>
    ''' <returns></returns>
    Function removeNodeType(nodeName As String)
        If InStrRev(nodeName, "(") <> 0 Then
            Return Trim(nodeName.Remove(InStrRev(nodeName, "(") - 1))
        Else
            Return Trim(nodeName)
        End If
    End Function

    Public Sub treeviewExpansion(e As TreeNode, Optional projectPath As String = "")
        Dim myNode As TreeNode
        Select Case e.Level
            'Its a project (Launched when adding a project)
            Case 0
                'If the treeview doesn't have children (Poor sterile treeView)
                If Not projectTreeView.HasChildren Then
                    'Get the packages and add them to the node
                    For Each package In UpdateSsis.getPackagesFromProject(New DirectoryInfo(projectPath))
                        If Not e.Nodes.ContainsKey(Strings.Right(package, Len(package) - Len(package.Remove(InStrRev(package, "\"))))) Then
                            myNode = e.Nodes.Add(Strings.Right(package, Len(package) - Len(package.Remove(InStrRev(package, "\")))) + " (Package)")
                            myNode.ImageIndex = 1
                            myNode.SelectedImageIndex = 1
                        End If
                    Next
                End If
            'It's a package or an ExecuteSQLTask
            Case 1
                file = removeNodeType(e.Parent.Text) + removeNodeType(e.Text)
                'Get DFTs ConnMgrs and SQLTasks
                For Each c In UpdateSsis.getDataFlowTasks(file)
                    If Not e.Nodes.Find(c, False).Count > 0 Then
                        myNode = e.Nodes.Add(c, c)
                        myNode.ImageIndex = 2
                        myNode.SelectedImageIndex = 2
                    End If
                Next
                For Each c In UpdateSsis.getExecuteSQLTasks(file)
                    If Not e.Nodes.Find(c, False).Count > 0 Then
                        myNode = e.Nodes.Add(c, c)
                        myNode.ImageIndex = 4
                        myNode.SelectedImageIndex = 4
                    End If
                Next
            'It's a DataFlowTask 
            Case 2
                file = removeNodeType(e.Parent.Parent.Text) + removeNodeType(e.Parent.Text)
                'If the node has Execute Sql Task in it then
                If InStr(e.Text, "Data Flow Task") <> 0 Then
                    'Get Src/Destinations
                    getSourceDestination(e, file)
                End If
            Case Else
                'Its a source/destination
        End Select
    End Sub

    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles projectTreeView.BeforeExpand
        'For each node under the node that is being updated
        For Each node As TreeNode In e.Node.Nodes
            'Try to expand the tree
            treeviewExpansion(node)
        Next
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles projectTreeView.NodeMouseClick
        Dim read As XmlReader
        'If the prevSelectedNode isn't equal to the current node
        If Not prevSelectedNode.Equals(e.Node) Then
            columnDataGridView.Rows.Clear()
            propertiesDataGridView.Rows.Clear()
            sqlTextBox.Text = ""
            If e.Node Is Nothing Then
                Exit Sub
            End If
            'Update the properties
            Select Case e.Node.Level
                'Project
                Case 0
                    'No project level Properties???
                    e.Node.ImageIndex = 0
                    e.Node.SelectedImageIndex = 0
                'Package
                Case 1
                    file = removeNodeType(e.Node.Parent.Text) + removeNodeType(e.Node.Text)
                    read = XmlReader.Create(file)
                    read.ReadToFollowing("DTS:Executable")
                    Dim temp As List(Of String) = UpdateSsis.readAttributes(read)
                    'For every other 0 to temp.count -1  (This for loop double counts, because I set it up to have src,dest,src,dest, etc)
                    For c = 0 To temp.Count - 1 Step 2
                        propertiesDataGridView.Rows.Add({temp(c), temp(c + 1)})
                    Next
                    e.Node.ImageIndex = 1
                    e.Node.SelectedImageIndex = 1
                'Data Flow Task / Execute SQL Task
                Case 2
                    file = removeNodeType(e.Node.Parent.Parent.Text) + removeNodeType(e.Node.Parent.Text)
                    Dim temp As List(Of String)
                    If InStr(e.Node.Text, "Execute") <> 0 Then
                        temp = UpdateSsis.readAttributes(UpdateSsis.findExecuteSqlTask(removeNodeType(e.Node.Text), file))
                        sqlTextBox.Text = UpdateSsis.getExecuteSQLTaskText(removeNodeType(e.Node.Text), file)
                        e.Node.ImageIndex = 4
                        e.Node.SelectedImageIndex = 4
                    Else
                        temp = UpdateSsis.readAttributes(UpdateSsis.findDataFlowTask(removeNodeType(e.Node.Text), file))
                        e.Node.ImageIndex = 2
                        e.Node.SelectedImageIndex = 2
                    End If

                    For c = 0 To temp.Count - 1 Step 2
                        propertiesDataGridView.Rows.Add({temp(c), temp(c + 1)})
                    Next
                'Source/Destinations
                Case 3
                    file = removeNodeType(e.Node.Parent.Parent.Parent.Text) + removeNodeType(e.Node.Parent.Parent.Text)
                    Dim attributeRead As XmlReader
                    attributeRead = XmlReader.Create(file)
                    read = UpdateSsis.findDataFlowTask(removeNodeType(e.Node.Parent.Text), file)
                    attributeRead = UpdateSsis.findDataFlowTask(removeNodeType(e.Node.Parent.Text), file)
                    Do While Not removeNodeType(e.Node.Text) = read.GetAttribute("name")
                        read.ReadToFollowing("component")
                        attributeRead.ReadToFollowing("component")
                    Loop
                    Dim readCopy As XmlReader = XmlReader.Create(file)
                    Dim sqlDest As New SqlDestProperties
                    Dim sqlSrc As New SqlSourceProperties
                    If InStr(read.GetAttribute("description"), "Destination") <> 0 Then
                        sqlDest.setup(read)
                        readCopy = XmlReader.Create(file)
                        sqlSrc.setup(sqlDest.findSource(readCopy))
                        sqlTextBox.Text = ""
                        propertiesDataGridView.Rows.Add({"Connection Mgr", sqlDest._connectionManagerRefId})
                    Else
                        sqlSrc.setup(read)
                        readCopy = XmlReader.Create(file)
                        sqlDest.setup(sqlSrc.findDestination(readCopy, file))
                        sqlTextBox.Text = sqlSrc._sqlCommand
                        propertiesDataGridView.Rows.Add({"Connection Mgr", sqlSrc._connectionManagerRefId})
                    End If
                    UpdateSsis.setupColumnMaps(sqlSrc, sqlDest)
                    Dim toolTip As String = ""
                    For i = 0 To sqlSrc._outputs.Count - 1
                        columnDataGridView.Rows.Add({sqlSrc._outputs(i), sqlDest._inputs(i)})
                        columnDataGridView.ShowCellToolTips = True
                        If Len(sqlSrc._outputType(i)) > 0 Then toolTip = "Type: " & sqlSrc._outputType(i) & vbCr
                        If Len(sqlSrc._outputLength(i)) > 0 Then toolTip = toolTip + "Length: " & sqlSrc._outputLength(i) & vbCr
                        If Len(sqlSrc._outputPrecision(i)) > 0 Then toolTip = toolTip + "Precision: " & sqlSrc._outputPrecision(i) & vbCr
                        columnDataGridView.Rows(i).Cells(0).ToolTipText = Trim(toolTip)
                        toolTip = ""
                        If Len(sqlDest._inputType(i)) > 0 Then toolTip = "Type: " & sqlDest._inputType(i) & vbCr
                        If Len(sqlDest._inputLength(i)) > 0 Then toolTip = toolTip + "Length: " & sqlDest._inputLength(i) & vbCr
                        If Len(sqlDest._inputPrecision(i)) > 0 Then toolTip = toolTip + "Precision: " & sqlDest._inputPrecision(i) & vbCr
                        columnDataGridView.Rows(i).Cells(1).ToolTipText = Trim(toolTip)
                    Next
                    Dim temp As List(Of String) = UpdateSsis.readAttributes(attributeRead)
                    For x = 0 To temp.Count - 1 Step 2
                        propertiesDataGridView.Rows.Add({temp(x), temp(x + 1)})
                    Next
                    e.Node.ImageIndex = 3
                    e.Node.SelectedImageIndex = 3
            End Select
            projectTreeView.SelectedNode = e.Node
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addProjectBttn.Click
        addFileToTree()
    End Sub

    Private Sub SsisViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        launcher.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ProjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If projectTreeView.SelectedNode IsNot Nothing Then
            If (projectTreeView.SelectedNode.Level = 0) Then
                Dim export As New Export
                Dim packages As New List(Of String)
                For Each c As String In UpdateSsis.getPackagesFromProject(New DirectoryInfo(removeNodeType(projectTreeView.SelectedNode.Text)))
                    packages.Add(Strings.Right(c, Len(c) - InStrRev(c, "\")))
                Next
                Export.batchExportWord(packages, removeNodeType(projectTreeView.SelectedNode.Text))
            Else
                MsgBox("Please select a Project to export!", MsgBoxStyle.Exclamation, "No Project Selected")
            End If
        End If
    End Sub

    Private Sub AddProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProjectToolStripMenuItem.Click
        addFileToTree()
    End Sub

    Private Sub PackageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If projectTreeView.SelectedNode IsNot Nothing Then
            If (projectTreeView.SelectedNode.Level = 1) Then
                Dim export As New Export
                Dim temp As New List(Of String)
                temp.Add(removeNodeType(projectTreeView.SelectedNode.Text))
                Export.batchExportWord(temp, removeNodeType(projectTreeView.SelectedNode.Parent.Text))
            Else
                MsgBox("Please select a Package to export!", MsgBoxStyle.Exclamation, "No Package Selected")
            End If
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If projectTreeView.SelectedNode IsNot Nothing Then
            If (projectTreeView.SelectedNode.Level = 0) Then
                projectTreeView.SelectedNode.Remove()
                TreeView1_NodeMouseClick(Me, New TreeNodeMouseClickEventArgs(projectTreeView.SelectedNode, MouseButtons.Left, 0, 0, 0))
            Else
                MsgBox("Please select a Project to remove!", MsgBoxStyle.Exclamation, "No Project Selected")
            End If
        End If
    End Sub

    Private Sub AddProjectFromServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProjectFromServerToolStripMenuItem.Click
        Dim serverSelect = New ServerPopupSelector
        serverSelect.packagePanelVisible = True
        serverSelect.ShowDialog()
        'If the user canceled the form
        If serverSelect.DialogResult = DialogResult.Cancel Then
            Debug.Print("'Add from Server' Dialog canceled.")
        ElseIf Not serverSelect.result.ConnectionString = "" Then
            Dim documents As New List(Of String)
            'Get a list of projects from the server
            documents = Import.getProjectsFromServer(serverSelect.result, System.IO.Path.GetTempPath + "SSIS_Analyzer\", False, True, serverSelect.folderComboBox.Text, serverSelect.projectComboBox.Text)
            'If there are documents
            If documents IsNot Nothing Then
                'For each document
                For Each document In documents
                    'Add it to the Project TreeView
                    addFileToTree(Path.GetTempPath + "SSIS_Analyzer\" + document + "\")
                Next
                'Get the configuration file
                Dim myConfigFile = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)
                'Get the key/values that are saved there
                Dim myAppSettings = myConfigFile.AppSettings.Settings
                'Get a CSV string (lol)
                Dim csvString As New System.Configuration.CommaDelimitedStringCollection
                'If there a key called this exists then
                If myAppSettings("server_list_of_strings") IsNot Nothing Then
                    'Add all the values from the settings into the csvString (splitting it with the char comma and removing empty values)
                    csvString.AddRange(myAppSettings("server_list_of_strings").Value.Split({","c}, StringSplitOptions.RemoveEmptyEntries))
                    'If the csvString doesn't already have the string, then add it
                    If Not csvString.Contains(serverSelect.result.DataSource) Then csvString.Add(serverSelect.result.DataSource)
                    'set the value in the configuration file
                    myAppSettings("server_list_of_strings").Value = csvString.ToString
                Else
                    'There is no key called this, so this is the only result to add
                    myAppSettings.Add("server_list_of_strings", serverSelect.result.DataSource)
                End If
                'Save the config changes
                myConfigFile.Save()
            End If
        End If
        'Destroy the form if it isn't already
        If Not serverSelect.IsDisposed Then serverSelect.Dispose()
    End Sub

    Private Sub ToWordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Do nothing, it should expand the menu (So you can select Project, Package, DFT, Src/Dest, or Selection)
    End Sub

    Private Sub DataFlowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'if there is a selected node
        If projectTreeView.SelectedNode IsNot Nothing Then
            'If the selected node level is 2
            If projectTreeView.SelectedNode.Level = 2 Then
                'If the data flow task has children
                If projectTreeView.SelectedNode.Nodes.Count > 1 Then
                    Dim file As String = removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Text) & removeNodeType(projectTreeView.SelectedNode.Parent.Text)
                    Dim sqlSource As New SqlSourceProperties
                    Dim sqlDest As New SqlDestProperties
                    If InStr(projectTreeView.SelectedNode.Nodes(0).Text, "Source") Then
                        sqlSource.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Nodes(0).Text), file))
                        sqlDest.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Nodes(1).Text), file))
                    Else
                        sqlSource.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Nodes(1).Text), file))
                        sqlDest.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Nodes(0).Text), file))
                    End If
                    Export.exportWord(sqlSource, sqlDest, removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Text), file)
                End If
            Else
                MsgBox("There isn't a source & destination for this data flow. Nothing was exported.")
            End If
        End If
    End Sub

    Private Sub SourceDestinationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'If there is a node selected
        If projectTreeView.SelectedNode IsNot Nothing Then
            'If the node level is 3
            If projectTreeView.SelectedNode.Level = 3 Then
                'Create the file name from the project and package
                Dim file As String = removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Parent.Text) & removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Text)
                Dim sqlSource As New SqlSourceProperties
                Dim sqlDest As New SqlDestProperties
                'If the selected node is a source
                If InStr(projectTreeView.SelectedNode.Text, "Source") <> 0 Then
                    sqlSource.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Text), file))
                    sqlDest.setup(sqlSource.findDestination(XmlReader.Create(file), file))
                    'else if it's a destination
                ElseIf InStr(projectTreeView.SelectedNode.Text, "Destination") <> 0 Then
                    sqlDest.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Text), file))
                    sqlSource.setup(sqlDest.findSource(XmlReader.Create(file)))
                Else
                    MsgBox("This doesn't seem to be a Source or Destination? Please talk to Chandler.")
                End If
                Export.exportWord(sqlSource, sqlDest, removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Parent.Text), file)
            Else
                MsgBox("Please select a Source/Destination to export")
            End If
        End If
    End Sub

    Private Sub CloseAllProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllProjectsToolStripMenuItem.Click
        projectTreeView.Nodes.Clear()
    End Sub

    Private Sub ColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnsToolStripMenuItem.Click
        If projectTreeView.SelectedNode IsNot Nothing Then

            Select Case projectTreeView.SelectedNode.Level
                Case 0
                    file = removeNodeType(projectTreeView.SelectedNode.Text)
                Case 1
                    file = removeNodeType(projectTreeView.SelectedNode.Parent.Text)
                Case 2
                    file = removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Text)
                Case 3
                    file = removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Parent.Text) + removeNodeType(projectTreeView.SelectedNode.Parent.Parent.Text)
            End Select

            Dim sqlSource As New SqlSourceProperties
            Dim sqlDest As New SqlDestProperties
            sqlSource.setup(UpdateSsis.findSourceDestination(removeNodeType(projectTreeView.SelectedNode.Text), file))
            sqlDest.setup(sqlSource.findDestination(XmlReader.Create(file), file))
            Export.exportCSV(sqlSource, sqlDest, "columnMapping.csv")
        End If
    End Sub

    Private Sub DocumentationOfSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationOfSelectionToolStripMenuItem.Click
        'If there is a node selected
        If projectTreeView.SelectedNode IsNot Nothing Then
            Select Case projectTreeView.SelectedNode.Level
                Case 0
                    ProjectToolStripMenuItem_Click(Me, EventArgs.Empty)
                Case 1
                    PackageToolStripMenuItem_Click(Me, EventArgs.Empty)
                Case 2
                    DataFlowToolStripMenuItem_Click(Me, EventArgs.Empty)
                Case 3
                    SourceDestinationToolStripMenuItem_Click(Me, EventArgs.Empty)
            End Select
        End If
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        ProjectToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub
End Class