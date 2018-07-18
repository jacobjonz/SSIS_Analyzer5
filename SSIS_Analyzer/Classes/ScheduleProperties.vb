Public Class ScheduleProperties


    Private _activeEndDate As Date
    Private _activeEndTimeOfDay As DateTime
    Private _activeStartDate As Date
    Private _activeStartTimeOfDay As DateTime
    Private _dateCreated As DateTime
    Private _frequencyInterval As String
    Public Property NewProperty() As String
        Get
            Return _frequencyInterval
        End Get
        Set(ByVal value As String)
            _frequencyInterval = value
        End Set
    End Property
    Public Property dateCreated() As DateTime
        Get
            Return _dateCreated
        End Get
        Set(ByVal value As DateTime)
            _dateCreated = value
        End Set
    End Property
    Public Property activeStartTimeOfDay() As DateTime
        Get
            Return _activeStartTimeOfDay
        End Get
        Set(ByVal value As DateTime)
            _activeStartTimeOfDay = value
        End Set
    End Property
    Public Property activeStartDate() As Date
        Get
            Return _activeStartDate
        End Get
        Set(ByVal value As Date)
            _activeStartDate = value
        End Set
    End Property
    Public Property activeEndTimeOfDay() As DateTime
        Get
            Return _activeEndTimeOfDay
        End Get
        Set(ByVal value As DateTime)
            _activeEndTimeOfDay = value
        End Set
    End Property
    Public Property activeEndDate() As Date
        Get
            Return _activeEndDate
        End Get
        Set(ByVal value As Date)
            _activeEndDate = value
        End Set
    End Property
End Class
