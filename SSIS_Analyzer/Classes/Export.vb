Imports Word = Microsoft.Office.Interop.Word
Imports System.IO
Imports System.Xml

Public Class Export

    ''' <summary>
    ''' Takes a list of packages and their path and exports each destination and it's source to Word
    ''' </summary>
    ''' <param name="packages"></param>
    ''' <param name="currPackagePath"></param>
    Shared Sub batchExportWord(packages As List(Of String), currPackagePath As String)
        Dim folder As String
        Dim folderSelector As New FolderBrowserDialog
        'Ask the user for a folder to save the documentation
        If folderSelector.ShowDialog = DialogResult.OK Then
            'Create variables, it's a go time!
            Dim read As XmlTextReader
            Dim sqlSrc As SqlSourceProperties
            Dim sqlDest As SqlDestProperties
            Dim currPackage As String

            'Get the folder to save to
            folder = folderSelector.SelectedPath

            'Make sure the folder ends with "\"
            If Not Right(folder, 1) = "\" Then folder = folder + "\"

            'Start Word
            Dim oWord = New Word.Application

            'for each package
            For Each package As String In packages

                'Startup the reader
                read = New XmlTextReader(currPackagePath + package)
                'Read to package executable
                read.ReadToFollowing("DTS:Executable")
                'Name of the current package
                currPackage = read.GetAttribute("DTS:ObjectName")

                'For each destination (loop through with do --> while)
                Do
                    'If it a destination
                    If InStr(read.GetAttribute("componentClassID"), "Destination") <> 0 Then

                        'Reset source & destination
                        sqlSrc = New SqlSourceProperties
                        sqlDest = New SqlDestProperties

                        'Create the destination
                        sqlDest.setup(read)
                        'Create the Source
                        sqlSrc.setup(sqlDest.findSource(XmlReader.Create(currPackage)))

                        'Setup column mapping
                        UpdateSsis.setupColumnMaps(sqlSrc, sqlDest)
                        'Export the Src/Dest to Word
                        exportWord(sqlSrc, sqlDest, currPackage, currPackagePath, folder, sqlDest._srcName.Replace("Package\", ""), oWord)
                    End If
                Loop While read.ReadToFollowing("component")
            Next
            'Refresh the screen... seems to prevent more errors
            oWord.ScreenRefresh()
            'Quit Word without saving (Already saved, don't want user prompts)
            oWord.Quit(False)
            If MsgBox("Would you like to open the file location now?", MsgBoxStyle.YesNo, "Export Completed") Then
                Process.Start(folder)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Exports SqlSource/DestProperties and the project and path into a Word document.
    '''     Optionally asks user where to save file
    ''' </summary>
    ''' <param name="sqlSource"></param>
    ''' <param name="sqlDest"></param>
    ''' <param name="curProject"></param>
    ''' <param name="currPath"></param>
    ''' <param name="filepath"></param>
    ''' <param name="fileName"></param>
    ''' <param name="oWord"></param>
    Shared Sub exportWord(sqlSource As SqlSourceProperties, sqlDest As SqlDestProperties, curProject As String, currPath As String, Optional filepath As String = "", Optional fileName As String = "", Optional oWord As Word.Application = Nothing)
        Dim closeWord As Boolean = False
        'If the filename is blank then
        If fileName = "" Then
            'Ask the user to save it
            Dim visStud As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Visual Studio "
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.InitialDirectory = IIf(Directory.Exists(visStud + "2015"), visStud + "2015", visStud + "2010")
            SaveFileDialog1.DefaultExt = "docx"
            SaveFileDialog1.Filter = "Word Documents (*.docx)|*.docx"
            If vbOK = SaveFileDialog1.ShowDialog() Then
                fileName = Right(SaveFileDialog1.FileName, Len(SaveFileDialog1.FileName) - InStrRev(SaveFileDialog1.FileName, "\"))
                filepath = Left(Path.GetFullPath(SaveFileDialog1.FileName), InStrRev(Path.GetFullPath(SaveFileDialog1.FileName), "\"))
            Else
                Return
            End If
        Else
            'replace any \'s with -'s
            fileName.Replace("\", "-")
        End If

        Dim oDoc As Word.Document

        'Start Word if not open
        If oWord Is Nothing Then
            oWord = New Word.Application
            closeWord = True
        End If
        'Make it invisible
        If oWord.Visible = True Then oWord.Visible = False
        'Don't update the screen
        If oWord.ScreenUpdating = True Then oWord.ScreenUpdating = False
        If oWord.Options.Pagination = True Then oWord.Options.Pagination = False
        'Add the template
        oDoc = oWord.Documents.Add(Application.StartupPath & "\Resources\Template.dotx")

        'Add the values to the Word Doc Template
        bkmrk(oDoc, "Project", curProject)
        bkmrk(oDoc, "PackagePath", currPath)
        bkmrk(oDoc, "DataFlowTask", sqlSource._dataFlowTask)
        bkmrk(oDoc, "SrcName", sqlSource._name)
        bkmrk(oDoc, "DestName", sqlDest._name)
        bkmrk(oDoc, "SrcSQLVar", sqlSource._sqlCommandVariable)
        bkmrk(oDoc, "DestSQLVar", sqlDest._sqlCommandVariable)
        bkmrk(oDoc, "SrcConMgr", sqlSource._connectionManagerRefId)
        bkmrk(oDoc, "DestConMgr", sqlDest._connectionManagerRefId)
        bkmrk(oDoc, "SourceSQL", sqlSource._sqlCommand)
        bkmrk(oDoc, "SrcOpenRowset", sqlSource._openRowset)
        bkmrk(oDoc, "DestOpenRowset", sqlDest._openRowset)

        CreateTableFromString(oDoc.Bookmarks.Item("ColumnMapTable").Range, {sqlSource._outputs, sqlSource._outputType, sqlSource._outputLength, sqlSource._outputPrecision, sqlDest._inputs, sqlDest._inputType, sqlDest._inputLength, sqlDest._inputPrecision})

        'Update the screen (Need to in case the user wants to use Word ever again ;D )
        oWord.Application.ScreenUpdating = True
        'if it already has .docx
        If InStr(fileName, ".docx") Then
            'Save the file
            oDoc.SaveAs2(filepath & fileName.Replace("\", "-"))
        Else
            'Save the file
            oDoc.SaveAs2(filepath & fileName.Replace("\", "-") + ".docx")
        End If
        'Close it
        oDoc.Close(True)
        'Garbage
        oDoc = Nothing
        If closeWord Then oWord.Quit()
    End Sub

    ''' <summary>
    ''' Puts the text at a bookmark in the Word document
    ''' </summary>
    ''' <param name="oDoc"></param>
    ''' <param name="bookmark"></param>
    ''' <param name="text"></param>
    Private Shared Sub bkmrk(oDoc As Word.Document, bookmark As String, text As String)
        oDoc.Bookmarks.Item(bookmark).Range.Text = text
    End Sub

    ''' <summary>
    ''' Converts the columns from Source/Destination and saves it as the fileName
    ''' </summary>
    ''' <param name="sqlSource"></param>
    ''' <param name="sqlDest"></param>
    ''' <param name="fileName"></param>
    Shared Sub exportCSV(sqlSource As SqlSourceProperties, sqlDest As SqlDestProperties, fileName As String)
        Dim beforeSrc As New List(Of String)
        Dim beforeDest As New List(Of String)
        beforeSrc.AddRange(sqlSource._outputs.ToArray)
        beforeDest.AddRange(sqlDest._inputs.ToArray)
        Dim after(1) As List(Of String)
        after = UpdateSsis.setupColumnMaps(sqlSource, sqlDest)

        Dim writer As New StreamWriter(fileName)
        Dim total As String = "Source,,,,,Destination" + Chr(10) + "Column Name,Column Type,Column Length,Column Precision,,Column Name,Column Type,Column Length,Column Precision" + Chr(10)
        For c = 0 To beforeSrc.Count - 1
            For x = 0 To after(0).Count - 1
                If beforeSrc(c) = after(0)(x) Then

                    total = total + after(0)(c) + "," + sqlSource._outputType(c) + "," + sqlSource._outputLength(c) + "," + sqlSource._outputPrecision(c) + ",,"
                    total = total + after(1)(c) + "," + sqlDest._inputType(c) + "," + sqlDest._inputLength(c) + "," + sqlDest._inputPrecision(c) + ","
                    total = total + Chr(10)
                End If
            Next
        Next

        writer.Write(total)
        writer.Close()
    End Sub

    ''' <summary>
    ''' Returns a dictionary of T-SQL variable types and a description
    ''' </summary>
    ''' <returns></returns>
    Public Function dataTypes() As Dictionary(Of String, String)
        Dim dict As New Dictionary(Of String, String) From
        {
            {"bool", "Boolean"},
            {"bytes", "Binary: Max 8000B"},
            {"cy", "Currency"},
            {"date", "Date (after 1900) Max 1E-7s"},
            {"dbdate", "Date (without time)"},
            {"dbtime", "Time h,m,s"},
            {"dbtime2", "Time: Max 1E-7s"},
            {"dbTimeStamp", "Date Time: Max 1/1000s"},
            {"dbTimeStamp2", "Date Time: Max 1E-7s"},
            {"dbtimestampoffset", "Date Time Offset: Max 1E-7s"},
            {"decimal", "12B signed Decimal: Max 1e-28"},
            {"filetime", "Time (since 1600) Max 1e-3s"},
            {"guid", "GUID (Globally Unique Identifier)"},
            {"i1", "1B signed Integer"},
            {"i2", "2B signed Integer"},
            {"i4", "4B signed Integer"},
            {"i8", "8B signed Integer"},
            {"numeric", "Numeric: 16B signed Decimal: Max 1e-38"},
            {"r4", "Single precision float"},
            {"r8", "Double precision float"},
            {"str", "ANSI String: Max 8000"},
            {"ui1", "1B unsigned Integer"},
            {"ui2", "2B unsigned Integer"},
            {"ui4", "4B unsigned Integer"},
            {"ui8", "8B unsigned Integer"},
            {"wstr", "Unicode String: Max 4000"},
            {"image", "Image - Binary value: Max 2^31 B"},
            {"ntext", "Unicode String: Max 2^30 B"},
            {"text", "ANSI String: Max 2^31 B"}
        }
        Return dict
    End Function

    ''' <summary>
    ''' Converts a list of data into a table at the Word Range
    ''' </summary>
    ''' <param name="rng"></param>
    ''' <param name="adata"></param>
    Shared Sub CreateTableFromString(ByRef rng As Word.Range, ByRef adata() As List(Of String))
        Dim tbl As Word.Table

        rng.Text = BuildDataString(adata)
        tbl = rng.ConvertToTable(vbTab, AutoFitBehavior:=1, DefaultTableBehavior:=0)
        tbl.Borders.OutsideColorIndex = Word.WdColorIndex.wdBlack
        tbl.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        tbl.Borders.InsideColorIndex = Word.WdColorIndex.wdBlack
        tbl.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
    End Sub

    ''' <summary>
    ''' Builds a delimited table from a list of list of strings
    ''' </summary>
    ''' <param name="aData"></param>
    ''' <returns></returns>
    Shared Function BuildDataString(aData() As List(Of String)) As String
        Dim dataString As String = ""
        Dim nrRow As Long, nrCol As Long

        'Add column headers
        dataString = "Source" & vbTab & vbTab & vbTab & vbTab & "Destination" & vbTab & vbTab & vbTab & vbTab & vbCr
        dataString = dataString & "Column Name" & vbTab & "Column Type" & vbTab & "Column Length" & vbTab & "Column Precision"
        dataString = dataString & vbTab & "Column Name" & vbTab & "Column Type" & vbTab & "Column Length" & vbTab & "Column Precision" & vbCr

        Try
            'For each row (number of mapped columns)
            For nrRow = 0 To aData(0).Count - 1
                'For each column (8)
                For nrCol = 0 To aData.Length - 1
                    If Not aData(nrCol).Count - 1 < nrRow Then
                        'add onto the string
                        dataString = dataString & aData(nrCol)(nrRow)
                    End If
                    'if it's not the last column then 
                    If nrCol < aData.Length - 1 Then
                        'add a tab
                        dataString = dataString & vbTab
                    Else
                        'add a return
                        dataString = dataString & vbCr
                    End If
                Next
            Next
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
        Return dataString
    End Function
End Class
