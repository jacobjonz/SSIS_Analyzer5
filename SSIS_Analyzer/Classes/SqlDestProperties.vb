Imports System.Xml

Public Class SqlDestProperties
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
    Public _srcName As String = ""
    Public _inputs As New List(Of String)
    Public _inputType As New List(Of String)
    Public _inputLength As New List(Of String)
    Public _inputPrecision As New List(Of String)
    Public _lineageID As New List(Of String)

    Public Sub setup(reader As XmlReader)
        Dim export As New Export
        Dim dataTypes As Dictionary(Of String, String) = export.dataTypes
        _path = reader.GetAttribute("refId")
        _name = reader.GetAttribute("name")
        _inputs = New List(Of String)
        _lineageID = New List(Of String)

        'Read properties from XML
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

                    'No attribute(name)
                Case Else
                    'If it's a component without a componentClassID then it's the end         (of the world as we know it)
                    If reader.Name = "component" And reader.GetAttribute("componentClassID") = "" Then
                        Exit Do
                    ElseIf reader.Name = "connection" Then
                        _connectionManagerId = reader.GetAttribute("connectionManagerId")
                        _connectionManagerRefId = reader.GetAttribute("connectionManagerRefId")
                    ElseIf reader.Name = "inputColumn" Then
                        _inputs.Add(reader.GetAttribute("cachedName"))
                        _lineageID.Add(reader.GetAttribute("lineageId"))
                        'Gets the name of the source from the first column!
                        If Len(_srcName) = 0 Then _srcName = Strings.Left(reader.GetAttribute("lineageId"), InStr(reader.GetAttribute("lineageId"), ".Outputs") - 1)
                        If dataTypes.ContainsKey(reader.GetAttribute("cachedDataType")) Then
                            Dim temp As String = ""
                            dataTypes.TryGetValue(reader.GetAttribute("cachedDataType"), temp)
                            _inputType.Add(temp)
                        End If
                        _inputLength.Add(reader.GetAttribute("cachedLength") + "" + reader.GetAttribute("cachedPrecision"))
                        _inputPrecision.Add(reader.GetAttribute("cachedScale"))
                    End If
            End Select
        Loop While reader.Read
    End Sub

    ''' <summary>
    ''' Accepts a blank XmlReader and finds the source attached to this destination
    ''' </summary>
    ''' <param name="read"></param>
    ''' <returns></returns>
    Public Function findSource(read As XmlReader)
        Do While read.ReadToFollowing("component")
            If Not read.NodeType = XmlNodeType.EndElement Then
                If _srcName = read.GetAttribute("refId") Then
                    Return read
                End If
            End If
        Loop
        Return read
    End Function
End Class
