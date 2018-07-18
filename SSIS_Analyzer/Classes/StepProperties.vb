Public Class StepProperties


    Private _command As String
    Private _commandExecutionSuccessCode As Boolean
    Private _databaseName As String
    Private _databaseUserName As String
    Private _id As Integer
    Private _jobStepFlags As String


    Public Property command() As String
        Get
            Return _command
        End Get
        Set(ByVal value As String)
            _command = value
        End Set
    End Property

    Public Property commandExecutionSuccessCode() As Boolean
        Get
            Return _commandExecutionSuccessCode
        End Get
        Set(ByVal value As Boolean)
            _commandExecutionSuccessCode = value
        End Set
    End Property

    Public Property databaseName() As String
        Get
            Return _databaseName
        End Get
        Set(ByVal value As String)
            _databaseName = value
        End Set
    End Property

    Public Property databaseUserName() As String
        Get
            Return _databaseUserName
        End Get
        Set(ByVal value As String)
            _databaseUserName = value
        End Set
    End Property

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property jobStepFlags() As String
        Get
            Return _jobStepFlags
        End Get
        Set(ByVal value As String)
            _jobStepFlags = value
        End Set
    End Property

End Class
