Imports System.Xml
Imports System.IO

Public Class UpdateSsis

    Shared Function getDataFlowTasks(file As String)
        Dim dft As List(Of String) : dft = New List(Of String)
        Dim read As XmlReader
        'Create an XML Reader 
        read = XmlReader.Create(file)
        'While there is more to read (This also advances the reader to the next item to read)
        Do While read.Read()
            'If the name of the current line is DTS:Executable and it has an attribute of DTS:Description equal to Data Flow Task
            '       The format is <name attribute:value> blah </name>
            If read.Name = "DTS:Executable" And read.GetAttribute("DTS:ExecutableType") = "Microsoft.Pipeline" Then
                'Add the refId to the list of Data Flow Tasks
                dft.Add(read.GetAttribute("DTS:refId") + " (" + read.GetAttribute("DTS:Description") + ")")
            End If
        Loop
        Return dft
    End Function

    Shared Function findDataFlowTask(search As String, file As String) As XmlReader
        Dim read As XmlReader = XmlReader.Create(file)
        Do While read.ReadToFollowing("DTS:Executable")
            If search = read.GetAttribute("DTS:refId") Then
                Return read.ReadSubtree
            End If
        Loop
        'Nothing found. TODO? Null?
        Return XmlReader.Create(file)
    End Function

    Shared Function findSourceDestination(search As String, file As String) As XmlReader
        Dim read As XmlReader = XmlReader.Create(file)
        Do While read.ReadToFollowing("component")
            If search = read.GetAttribute("name") Then
                Return read
            End If
        Loop
    End Function

    Shared Function getPackagesFromProject(dir As DirectoryInfo) As List(Of String)
        getPackagesFromProject = New List(Of String)
        'For each file in the directory with the extension .dtsx
        For Each c In dir.GetFiles("*.dtsx")
            'Add it to the list
            If Right(dir.ToString, 1) = "\" Then
                getPackagesFromProject.Add(dir.ToString + c.ToString)
            Else
                getPackagesFromProject.Add(dir.ToString + "\" + c.ToString)
            End If
        Next
        Return getPackagesFromProject
    End Function

    'Reads the attributes of the current element in the xmlreader
    Shared Function readAttributes(read As XmlReader) As List(Of String)
        readAttributes = New List(Of String)
        If read.AttributeCount = 0 Then read.Read()
        'for each attribute
        For i = 0 To read.AttributeCount - 1
            'Moves to the attribute
            read.MoveToAttribute(i)
            'Add to list
            readAttributes.AddRange({read.Name, read.GetAttribute(i)})
        Next
        'Add the value of the node if it isn't blank or a new line
        Dim value = Trim(read.ReadString).Replace(vbCr, "").Replace(vbLf, "")
        If value <> "" Then readAttributes.AddRange({"Value", value})
        Return readAttributes
    End Function

    Shared Function getExecuteSQLTasks(file As String) As List(Of String)
        getExecuteSQLTasks = New List(Of String)
        Dim read As XmlReader = XmlReader.Create(file)
        Do While read.ReadToFollowing("DTS:Executable")
            If read.GetAttribute("DTS:ExecutableType") = "Microsoft.ExecuteSQLTask" Then
                getExecuteSQLTasks.Add(read.GetAttribute("DTS:ObjectName") + " (" + read.GetAttribute("DTS:Description") + ")")
            End If
        Loop
        Return getExecuteSQLTasks
    End Function

    Shared Function findExecuteSqlTask(search As String, file As String) As XmlReader
        Dim read As XmlReader = XmlReader.Create(file)
        Do While read.ReadToFollowing("DTS:Executable")
            If read.GetAttribute("DTS:ExecutableType") = "Microsoft.ExecuteSQLTask" Then
                If read.GetAttribute("DTS:ObjectName") = search Then
                    Return read
                End If
            End If
        Loop
    End Function

    Shared Function getExecuteSQLTaskText(search As String, file As String) As String
        Dim read As XmlReader = findExecuteSqlTask(search, file)
        Do While read.Read
            If read.GetAttribute("SQLTask:SqlStatementSource") <> "" Then
                Return read.GetAttribute("SQLTask:SqlStatementSource")
            ElseIf read.Name = "DTS:Executable" And read.NodeType = XmlNodeType.EndElement Then
                Return ""
            End If
        Loop
    End Function

    Shared Function setupColumnMaps(srcProp As SqlSourceProperties, destProp As SqlDestProperties)
        Dim found As Boolean
        Dim match As Integer = 0
        Dim srcName As String = ""
        Dim destName As String = ""
        '----------------  Setup column mapping  ----------------------
        'If the variables aren't null
        If srcProp IsNot Nothing And destProp IsNot Nothing Then
            'For each source column
            For src = 0 To srcProp._outputs.Count - 1
                'New column, clear if the match was FOUND
                found = False
                'For each destination column
                For dest = 0 To destProp._inputs.Count - 1
                    'If a match hasn't been found
                    If Not found Then
                        'If the column references match match
                        If srcProp._refIdColumn(src) = destProp._lineageID(dest) Then

                            'Make the match found
                            found = True
                            'Add 1 to match
                            match = match + 1

                            '----SOURCE-----
                            moveItem(srcProp._outputs, src, match)
                            moveItem(srcProp._outputLength, src, match)
                            moveItem(srcProp._outputPrecision, src, match)
                            moveItem(srcProp._outputType, src, match)

                            '----DESTINATION-----
                            moveItem(destProp._inputs, dest, match)
                            moveItem(destProp._inputLength, dest, match)
                            moveItem(destProp._inputPrecision, dest, match)
                            moveItem(destProp._inputType, dest, match)
                            Exit For
                        End If
                    End If
                Next
            Next
            If Not match = destProp._inputs.Count Then
                'For each extra column
                For i = 0 To srcProp._outputs.Count - match - 1
                    'Add a blank value to the destination
                    destProp._inputs.Insert(i, "")
                    destProp._inputLength.Insert(i, "")
                    destProp._inputPrecision.Insert(i, "")
                    destProp._inputType.Insert(i, "")
                Next
                For i = 0 To destProp._inputs.Count - srcProp._outputs.Count - match - 2
                    srcProp._outputs.Add("")
                    srcProp._outputLength.Add("")
                    srcProp._outputPrecision.Add("")
                    srcProp._outputType.Add("")
                Next
            End If
        End If
    End Function

    'Takes a list of string and inserts and deletes the item 
    Shared Sub moveItem(ByRef myList As List(Of String), from As Integer, destination As Integer)
        'Insert it into the correct location
        myList.Insert(destination, myList(from))
        'If moving from high to low, then from will move up one
        If from > destination Then from = from + 1
        'Remove from
        myList.RemoveAt(from)
    End Sub
End Class
