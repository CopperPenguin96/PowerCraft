Imports JetBrains.Annotations
Imports PowerLib.PlayerDB
Imports PowerLib.PowerCraft.Network
Imports PowerLib.PowerCraft.Tools
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports PowerLib.Tools

Namespace PowerCraft
    Public Class Config
#Region "ServerName"
        Private Shared ServerName As [String]
        Public Shared Function GetServerName() As [String]
            Return ServerName
        End Function
        Public Shared Sub SetServerName(s As [String])
            ServerName = s
        End Sub
#End Region

#Region "HeartbeatURL"
        Private Shared hbLocation As HeartbeatLocation = HeartbeatLocation.ClassiCube
        Public Shared Function GetHBLocation() As HeartbeatLocation
            Return hbLocation
        End Function
        Public Shared Sub SetHeartBeatLocation(hb As HeartbeatLocation)
            hbLocation = hb
        End Sub
        Public Shared Function heartbeatURL() As [String]
            Select Case GetHBLocation()
                Case HeartbeatLocation.ClassiCube
                    Return "http://www.classicube.net/heartbeat.jsp"
                Case Else
                    Return "https://minecraft.net/heartbeat.jsp"
            End Select
        End Function
#End Region

#Region "Privacy"
        Private Shared Privacy As Boolean
        Public Shared Function GetPrivacy() As Boolean
            Return Privacy
        End Function
        Public Shared Sub SetPrivacy(priv As Boolean)
            Privacy = priv
        End Sub
#End Region

#Region "MaxPlayers"
        Private Shared MaxPlayers As Integer
        Public Shared Function GetMaxPlayers() As Integer
            Return MaxPlayers
        End Function
        Public Shared Sub SetMaxPlayers(i As Integer)
            MaxPlayers = i
        End Sub
#End Region

#Region "Port"
        Private Shared Port As Integer
        Public Shared Function GetPort() As Integer
            Return Port
        End Function
        Public Shared Sub SetPort(i As Integer)
            Port = i
        End Sub
#End Region

#Region "IP"
        Public Shared Function GetIP() As [String]
            Dim request = DirectCast(WebRequest.Create("http://ifconfig.me"), HttpWebRequest)
            request.UserAgent = "curl"
            ' this simulate curl linux command
            Dim publicIPAddress As String
            request.Method = "GET"
            Using response As WebResponse = request.GetResponse()
                Using reader = New StreamReader(response.GetResponseStream())
                    publicIPAddress = reader.ReadToEnd()
                End Using
            End Using
            Return publicIPAddress.Replace(vbLf, "")
        End Function
#End Region

#Region "DefaultRank"
        Private Shared DefaultRank As Rank
        Public Shared Function GetDefaultRank() As Rank
            Return DefaultRank
        End Function
        Public Shared Sub SetDefaultRank(r As Rank)
            DefaultRank = r
        End Sub
#End Region

#Region "Saving/Loading"
        Public Shared Sub Save()
            Dim [cObj] As New ConfigObj() With { _
                .ServerName = GetServerName(), _
                .HeartBeatURL = heartbeatURL(), _
                .Privacy = GetPrivacy(), _
                .MaxPlayers = GetMaxPlayers(), _
                .Port = GetPort(), _
                .IP = GetIP() _
            }
            JSONWriter.SaveConfig([cObj])
        End Sub
        Private Shared Function ToHBEnumObj(url As [String]) As HeartbeatLocation
            Select Case url
                Case "http://www.classicube.net/heartbeat.jsp"
                    Return HeartbeatLocation.ClassiCube
                Case Else
                    Return HeartbeatLocation.MinecraftNet
            End Select
        End Function
        Public Shared Sub Load()
            Dim [cObj] As ConfigObj = JSONReader.[cObj]()
            SetHeartBeatLocation(ToHBEnumObj([cObj].HeartBeatURL))
            SetMaxPlayers([cObj].MaxPlayers)
            SetPort([cObj].Port)
            SetPrivacy([cObj].Privacy)
            SetServerName([cObj].ServerName)
        End Sub
#End Region


    End Class
    Public Class ConfigObj
        Public Shared Function Defaults() As ConfigObj
            Dim x As New ConfigObj
            x.ServerName = "PowerCraft Default"
            x.HeartBeatURL = "http://www.classicube.net/heartbeat.jsp"
            x.Privacy = True
            x.MaxPlayers = 20
            x.Port = 25565
            x.DefaultRankID = 0
        End Function
        Public ServerName As [String]
        Public HeartBeatURL As [String]
        Public Privacy As Boolean
        Public MaxPlayers As Integer
        Public Port As Integer
        Public IP As [String]
        Public DefaultRankID As Integer
    End Class

    Public Class RankObj
        Public ArrayOfRanks() As Rank
    End Class
    Public Class RankConfig
        Private Shared Ranks() As Rank
        Public Shared Function GetRanks() As Rank()
            Return Ranks
            'If Ranks is Null, return file and then Do SetRanks(Get From json Reader)
        End Function
        Public Shared Sub SetRanks(r As Rank())
            Ranks = r
        End Sub

        Public Shared Sub Save()
            Dim rObj As New RankObj()
            rObj.ArrayOfRanks = GetRanks()
            JSONWriter.SaveRankConfig(rObj) ' Saves our ranks to config file
        End Sub

        Public Shared Sub Load()
            Dim MyRObj As RankObj = JSONReader.rObj()
            SetRanks(MyRObj.ArrayOfRanks) ' Ranks are loaded finally. Congratulations!
        End Sub
    End Class
End Namespace
