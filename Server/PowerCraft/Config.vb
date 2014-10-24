Imports PowerCraft.Network
Imports PowerCraft.Tools
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports Server.PowerCraft.Network
Imports Server.PowerCraft.Tools

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
        Private Shared hbLocation As HeartbeatLocation
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
        Private Shared Privacy As Boolean = False
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
        Public ServerName As [String]
        Public HeartBeatURL As [String]
        Public Privacy As Boolean
        Public MaxPlayers As Integer
        Public Port As Integer
        Public IP As [String]
    End Class
End Namespace
