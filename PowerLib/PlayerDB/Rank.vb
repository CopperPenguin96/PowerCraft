Imports System.Runtime.Serialization

Namespace PlayerDB
    Public Class Rank
        Public Overrides Function ToString() As String
            Return Name
        End Function
        Public Shared Function ToRank(ID As Integer) As Rank
            Return Nothing
        End Function

        Public ID As Integer 'Use as Identification for position of rank
        Public Name As String
        Public ReservePlayerSpot As Boolean
        Public KickIfIdle As Boolean
        Public KickIfIdleTime As Integer
        Public GriefDetection As Boolean
        Public GriefDetectionBlocks As Integer
        Public GriefDetectionTimeInSecs As Integer
        Public DrawLimit As Boolean
        Public DrawLimitAmount As Integer
        'TODO - Create permissions
    End Class
    Public Class InvalidRankException
        Inherits Exception
        Sub New()
            MyBase.New()
        End Sub
        Sub New(message As String)
            MyBase.New()
        End Sub
        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New()
        End Sub
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New()
        End Sub
    End Class
End Namespace