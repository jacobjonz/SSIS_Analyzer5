Imports System.Xml

Public Class SqlSourceProperties
    Public _dataFlowTask As String = ""
    Public _path As String = ""
    Public _propertysqlCommand As String = ""
    Public _sqlCommand As String = ""
    Public _sqlCommandVariable As String = ""
    Public _openRowset As String = ""
    Public _openRowsetVariable As String = ""
    Public _connectionManagerId As String = ""
    Public _connectionManagerRefId As String = ""
    Public _name As String = ""
    Public _refId As String = ""
    Public _outputs As New List(Of String)
    Public _outputType As New List(Of String)
    Public _outputLength As New List(Of String)
    Public _outputPrecision As New List(Of String)
    Public _refIdColumn As New List(Of String)

    ''' <summary>
    ''' Takes an XmlReader at the location of the Source
    ''' </summary>
    ''' <param name="reader"></param>
    Public Sub setup(reader As XmlReader)
        Dim export As New Export
        Dim dataTypes As Dictionary(Of String, String) = export.dataTypes
        _path = reader.GetAttribute("refId")
        _name = reader.GetAttribute("name")
        _refId = reader.GetAttribute("refId")
        'Read properties
        Do
            Dim c = reader.GetAttribute("name")
            Select Case c
                Case "OpenRowset"
                    _openRowset = reader.ReadString()
                Case "OpenRowsetVariable"
                    _openRowsetVariable = reader.ReadString()
                Case "SqlCommand"
                    _sqlCommand = reader.ReadString()
                Case "SqlCommandVariable"
                    _sqlCommandVariable = reader.ReadString()
                    'Case Nothing
                    'No attribute(name)
                Case Else
                    Select Case reader.Name
                        Case "component"
                            If reader.NodeType = XmlNodeType.EndElement Then
                                Exit Do
                            End If
                        Case "outputColumn"
                            _outputs.Add(reader.GetAttribute("name"))
                            _refIdColumn.Add(reader.GetAttribute("refId"))
                            If dataTypes.ContainsKey(reader.GetAttribute("dataType")) Then
                                Dim temp As String = ""
                                dataTypes.TryGetValue(reader.GetAttribute("dataType"), temp)
                                _outputType.Add(temp)
                            End If
                            _outputLength.Add(reader.GetAttribute("length") + "" + reader.GetAttribute("precision"))
                            _outputPrecision.Add((reader.GetAttribute("scale")))
                        Case "connection"
                            _connectionManagerId = reader.GetAttribute("connectionManagerID")
                            _connectionManagerRefId = reader.GetAttribute("connectionManagerRefId")
                        Case "output"
                            If reader.GetAttribute("isErrorOut") = "true" Then reader.ReadToFollowing("output")
                        Case "externalMetadataColumns"
                            reader.ReadToFollowing("externalMetadataColumns")
                    End Select
            End Select
        Loop While reader.Read
        If Len(_refId) <> 0 Then
            _dataFlowTask = Left(_refId, InStrRev(_refId, "\") - 1)
            _dataFlowTask = Right(_dataFlowTask, Len(_dataFlowTask) - InStrRev(_dataFlowTask, "\"))
        End If
    End Sub
    ''' <summary>
    ''' Accepts a blank XmlReader and finds the destination attached to this source
    ''' </summary>
    ''' <param name="read"></param>
    ''' <param name="file"></param>
    ''' <returns></returns>
    Public Function findDestination(read As XmlReader, file As String) As XmlReader
        Dim blankRead = XmlReader.Create(file)
        Do While read.ReadToFollowing("component")
            blankRead.ReadToFollowing("component")
            'If it's a destination
            If InStr(read.GetAttribute("componentClassID"), "Destination") <> 0 Then
                If checkSubTree(blankRead.ReadSubtree()) Then
                    Return read
                End If
            End If
        Loop
        Return read
    End Function

    Private Function checkSubTree(read As XmlReader)
        If Not read.NodeType = XmlNodeType.EndElement Then
            read.ReadToFollowing("inputColumn")
            If read.GetAttribute("lineageId") <> "" Then
                If Strings.Left(read.GetAttribute("lineageId"), InStr(read.GetAttribute("lineageId"), ".Outputs") - 1) = _refId Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function
End Class
