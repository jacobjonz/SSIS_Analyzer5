Imports System.Reflection.Assembly
Imports Microsoft.SqlServer.Management.IntegrationServices
Imports System.IO
Imports System.IO.Compression
Public Class Import


    Shared Function getProjectsFromServer(ssisServer As SqlClient.SqlConnectionStringBuilder, downloadFolder As String, createSubFolders As Boolean, unzipIspac As Boolean, Optional folderName As String = "", Optional projectName As String = "")
        Try
            Dim documents As List(Of String) = New List(Of String)
            If ssisServer.DataSource = "" Then Return documents
            If downloadFolder = "" Then Return documents
            If Not Right(Trim(downloadFolder), 1) = "\" Then downloadFolder = downloadFolder + "\"

            'Dim ssisNamespace = "Microsoft.SqlServer.Management.IntegrationServices"
            'Load(ssisNamespace)     'Load the namespace
            ssisServer.InitialCatalog = "master"
            'Dim sqlConnectionString = "Data Source=" + ssisServer + ";Initial Catalog=master;Integrated Security=SSPI"
            Dim sqlConnection = New SqlClient.SqlConnection(ssisServer.ConnectionString)
            Dim integrationService As New IntegrationServices(sqlConnection)
            Dim catalog As Catalog = integrationService.Catalogs("SSISDB")

            'if neither the project nor the folder were provided
            If folderName = "" And projectName = "" Then
                For Each folder In catalog.Folders
                    For Each project In folder.Projects
                        documents.Add(downloadIspac(downloadFolder, project, createSubFolders, unzipIspac))
                    Next
                Next
                'if both the project and folder were provided
            ElseIf folderName <> "" And projectName <> "" Then
                Dim catalogFolder As CatalogFolder = catalog.Folders(folderName)
                Dim project = catalogFolder.Projects(projectName)
                documents.Add(downloadIspac(downloadFolder, project, createSubFolders, unzipIspac))
                'if the foldername was given with no project
            ElseIf folderName <> "" And projectName = "" Then
                'download all projects in the folder
                For Each project In catalog.Folders(folderName).Projects
                    documents.Add(downloadIspac(downloadFolder, project, createSubFolders, unzipIspac))
                Next

                'if the foldername wasn't given and the project name was
            ElseIf folderName = "" And projectName <> "" Then
                'find the folder
                For Each folder In catalog.Folders
                    If folder.Projects.Contains(projectName) Then
                        documents.Add(downloadIspac(downloadFolder, folder.Projects(projectName), createSubFolders, unzipIspac))
                    End If
                Next
            End If

            Return documents
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Shared Function downloadIspac(downloadFolder As String, project As ProjectInfo, createSubFolders As Boolean, unzipIspac As Boolean)
        If createSubFolders Then
            downloadFolder = downloadFolder + project.Parent.Name
        End If

        'Create directory(s) if they don't already exist
        Directory.CreateDirectory(downloadFolder)

        If File.Exists(downloadFolder + project.Name + ".ispac") Then File.Delete(downloadFolder + project.Name + ".ispac")

        Dim ISPAC = project.GetProjectBytes()
        File.WriteAllBytes(downloadFolder + project.Name + ".ispac", ISPAC)
        If unzipIspac Then

            'if unzipped project already exists then delete it
            If Directory.Exists(downloadFolder + project.Name) Then Directory.Delete(downloadFolder + project.Name + "\", True)

            ZipFile.ExtractToDirectory(downloadFolder + project.Name + ".ispac", downloadFolder + project.Name)
        End If

        If File.Exists(downloadFolder + project.Name + ".ispac") Then File.Delete(downloadFolder + project.Name + ".ispac")

        Return project.Name
    End Function

    Shared Function getFolders(ssisServer As SqlClient.SqlConnectionStringBuilder) As List(Of String)
        getFolders = New List(Of String)
        'Dim ssisNamespace = "Microsoft.SqlServer.Management.IntegrationServices"
        'Load(ssisNamespace)     'Load the namespace
        'Dim sqlConnectionString = "Data Source=" + ssisServer + ";Initial Catalog=master;Integrated Security=SSPI"
        Dim sqlConnection = New SqlClient.SqlConnection(ssisServer.ConnectionString)
        Try
            sqlConnection.Open()
        Catch ex As Exception
            Debug.Print("(Import.vb --> getFolders) Exception in opening connection: " & ex.Message)
            Return {"Exception: login"}.ToList
        End Try
        Dim integrationService As New IntegrationServices(sqlConnection)
        'If there are no catalogs named SSISDB
        If Not integrationService.Catalogs.Contains("SSISDB") Then
            Debug.Print("(Import.vb --> getFolders) No catalog called SSISDB")
            Return {"Exception: catalog"}.ToList
        End If

        Dim catalog As Catalog = integrationService.Catalogs("SSISDB")

        For Each c In catalog.Folders
            getFolders.Add(c.Name)
        Next

        Return getFolders
    End Function

    Shared Function getProjects(ssisServer As String, folder As String) As List(Of String)
        getProjects = New List(Of String)
        'Dim ssisNamespace = "Microsoft.SqlServer.Management.IntegrationServices"
        'Load(ssisNamespace)     'Load the namespace
        Dim sqlConnectionString As New System.Data.SqlClient.SqlConnectionStringBuilder
        With sqlConnectionString
            .DataSource = ssisServer
            .InitialCatalog = "master"
            .IntegratedSecurity = True
            .PersistSecurityInfo = True
        End With
        Dim sqlConnection = New SqlClient.SqlConnection(sqlConnectionString.ConnectionString)
        Dim integrationService As New IntegrationServices(sqlConnection)
        Dim catalog As Catalog = integrationService.Catalogs("SSISDB")
        For Each project In catalog.Folders.Item(folder).Projects
            getProjects.Add(project.Name)
        Next
    End Function
End Class
