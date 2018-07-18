Imports System.ComponentModel
Imports System.IO
Imports System.Xml
Imports Word = Microsoft.Office.Interop.Word

Public Class Form1

    Dim oWord As Word.Application
    Dim currPackage As String = ""
    Dim currPackagePath As String = ""

    'When the user selects an input Column name, select the matching one from the output
    Sub inputColumnListBoxSelectionChange()
        OutputColumnListBox.SelectedIndex = InputColumnListBox.SelectedIndex
        InputColumnListBox.TopIndex = OutputColumnListBox.TopIndex
    End Sub

    'When the user selects an input Column name, select the matching one from the output
    Sub outputColumnListBoxIndexChange()
        InputColumnListBox.SelectedIndex = OutputColumnListBox.SelectedIndex
        OutputColumnListBox.TopIndex = InputColumnListBox.TopIndex
    End Sub

    'When the user presses Enter
    Sub keyDownPress(e)
        If e.KeyCode = Keys.Enter Then
            'Remove the enter key from the projectPathTextBox
            projectPathTextBox.Text = projectPathTextBox.Text.Replace("\n", "")
            Dim dir As DirectoryInfo : dir = New DirectoryInfo(projectPathTextBox.Text)
            If dir.Exists Then
                'Clear the current packages
                packageComboBox.Items.Clear()
                'Add the packages
                packageComboBox.Items.AddRange(UpdateSsis.getPackagesFromProject(dir).ToArray)
                'If there are any packages
                If packageComboBox.Items.Count <> 0 Then
                    'Select the first one
                    packageComboBox.SelectedIndex = 0
                    'don't cascasde update... hmm TODO?
                    packageComboBoxIndexChanged(False)
                End If
                e.Handled = True
            Else
                MsgBox("That is not a valid project path.")
            End If
        End If
    End Sub

    'Gets file from a folder from dialog (user input) and sets it up
    Sub selectProject()
        'If the user presses 'OK' on the file selector then   (.ShowDialog opens the file selector and returns a value at the same time)
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            'Directory variable
            Dim dir As New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            'Get the selected path
            projectPathTextBox.Text = FolderBrowserDialog1.SelectedPath
            'Clear the package combobox
            packageComboBox.Items.Clear()
            'Add the packages
            packageComboBox.Items.AddRange(UpdateSsis.getPackagesFromProject(dir).ToArray)
        End If
    End Sub

    Sub dataFlowComboBoxRefresh()
        'Delete the items in the dropdown already
        Me.dataFlowComboBox.Items.Clear()
        Dim dft = getDataFlowTasks()
        If Not dft = False Then
            'For each Data Flow Task
            For Each c In getDataFlowTasks()
                'Add it to the ComboBox
                Me.dataFlowComboBox.Items.Add(c)
            Next
        End If
    End Sub

    'Gets and load the properties of a dataFlowTask (dft)
    Sub dftFindProperties(reader As XmlReader)
        Dim srcProp As SqlSourceProperties = New SqlSourceProperties
        Dim destProp As SqlDestProperties = New SqlDestProperties

        Dim srcFound As Boolean : srcFound = False
        Dim destFound As Boolean : destFound = False

        Do While reader.Read
            If reader.NodeType = XmlNodeType.Element Then
                If InStr(reader.GetAttribute("componentClassID"), "Destination") <> 0 Then
                    Dim copy As XmlReader
                    copy = reader
                    destProp = New SqlDestProperties
                    destProp.setup(copy)
                    Me.sqlCommandTextDest.Text = destProp._sqlCommand
                    Me.SqlCommandVariableTextDest.Text = destProp._sqlCommandVariable
                    Me.nameTextDest.Text = destProp._name
                    Me.openRowsetTextDest.Text = destProp._openRowset
                    Me.openRowsetVariableTextDest.Text = destProp._openRowsetVariable
                    Me.itemPathTextDest.Text = destProp._path
                    Me.InputColumnListBox.Items.AddRange(destProp._inputs.ToArray)
                    Me.connectionManagerRefIdTextDest.Text = destProp._connectionManagerRefId
                    destFound = True
                    If destFound And srcFound Then Exit Do
                ElseIf InStr(reader.GetAttribute("componentClassID"), "Source") <> 0 Then
                    Dim copy As XmlReader
                    copy = reader
                    srcProp = New SqlSourceProperties
                    srcProp.setup(copy)
                    Me.sqlCommandText.Text = srcProp._sqlCommand
                    Me.SqlCommandVariableText.Text = srcProp._sqlCommandVariable
                    Me.nameText.Text = srcProp._name
                    Me.openRowsetText.Text = srcProp._openRowset
                    Me.openRowsetVariableText.Text = srcProp._openRowsetVariable
                    Me.itemPathText.Text = srcProp._path
                    Me.OutputColumnListBox.Items.AddRange(srcProp._outputs.ToArray)
                    Me.connectionManagerRefIdText.Text = srcProp._connectionManagerRefId
                    srcFound = True
                    If destFound And srcFound Then Exit Do
                End If
            End If
        Loop
        'Clear the lists of columns
        Me.OutputColumnListBox.Items.Clear()
        Me.InputColumnListBox.Items.Clear()
        'An array of list of strings  (Think of it like two attached lists(of String))
        Dim temp(1) As List(Of String)
        'Get the column mapping
        temp = UpdateSsis.setupColumnMaps(srcProp, destProp)
        'Add them to the column list boxes
        Me.InputColumnListBox.Items.AddRange(temp(0).ToArray)
        Me.OutputColumnListBox.Items.AddRange(temp(1).ToArray)
    End Sub


    'Returns a list of strings of all Data Flow Tasks
    Function getDataFlowTasks(Optional search As String = "")
        Dim dft As List(Of String) : dft = New List(Of String)
        Dim read As XmlTextReader
        If packageComboBox.Text <> "" Then
            'Create an XML Reader using the project path and the package name
            read = New XmlTextReader(packageComboBox.Text)
            'While there is more to read (This also advances the reader to the next item to read)
            Do While read.Read()
                'If the name of the current line is DTS:Executable and it has an attribute of DTS:Description equal to Data Flow Task
                '       The format is <name attribute:value> blah </name>
                If read.Name = "DTS:Executable" And read.GetAttribute("DTS:ExecutableType") = "Microsoft.Pipeline" Then
                    'If the search is something and DTS:refId matches it
                    If Not search = "" And read.GetAttribute("DTS:refId") = search Then
                        'Return an XMLreader at this spot
                        Return read.ReadSubtree
                    Else
                        'Add the refId to the list of Data Flow Tasks
                        dft.Add(read.GetAttribute("DTS:refId"))
                    End If
                End If
            Loop
            Return dft
        End If
        Return False
    End Function

    'When the package is changed (T/F if I want to cascade the updating)
    Sub packageComboBoxIndexChanged(cascade)
        'Refresh the dataFlowTasks
        dataFlowComboBoxRefresh()
        'If there are dft and i want to cascade update
        If dataFlowComboBox.Items.Count <> 0 And cascade Then
            'Select the first dft
            dataFlowComboBox.SelectedIndex = 0
            'Update the Src/Dest stuff
            dataFlowComboBoxIndexChanged()
        End If
    End Sub

    Sub dataFlowComboBoxIndexChanged()
        'Take the selected data flow from the selected data flow dropdown and pass it
        dftFindProperties(UpdateSsis.findDataFlowTask(dataFlowComboBox.Items(dataFlowComboBox.SelectedIndex).ToString, packageComboBox.Text))
    End Sub

    Sub dataFlowComboBox_DropDown(sender As Object, e As EventArgs) Handles dataFlowComboBox.DropDown
        dataFlowComboBoxRefresh()
    End Sub

    Sub selectProjectBttn_Click(sender As Object, e As EventArgs) Handles selectProjectBttn.Click
        selectProject()
    End Sub

    Sub exportWordBttn_Click(sender As Object, e As EventArgs) Handles exportWordBttn.Click
        'exportWord()
    End Sub

    Sub projectPathTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles projectPathTextBox.KeyDown
        keyDownPress(e)
    End Sub

    Sub batchExportBttn_Click(sender As Object, e As EventArgs) Handles batchExportBttn.Click
        Dim export As New Export
        export.batchExportWord(UpdateSsis.getPackagesFromProject(New DirectoryInfo(Me.projectPathTextBox.Text)), Me.projectPathTextBox.Text)
    End Sub

    Sub packageComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packageComboBox.SelectedIndexChanged
        packageComboBoxIndexChanged(True)
    End Sub

    Sub dataFlowComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dataFlowComboBox.SelectedIndexChanged
        dataFlowComboBoxIndexChanged()
    End Sub

    Sub OutputColumnListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputColumnListBox.SelectedIndexChanged
        outputColumnListBoxIndexChange()
    End Sub

    Sub InputColumnListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InputColumnListBox.SelectedIndexChanged
        inputColumnListBoxSelectionChange()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        launcher.WindowState = FormWindowState.Normal
    End Sub
End Class
