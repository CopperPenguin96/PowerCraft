Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Net.Cache
Imports PowerCraft.Tools
Imports Server.PowerCraft.Tools

' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org>
Namespace PowerCraft.Network
    Public Enum HeartbeatLocation
        ClassiCube
        MinecraftNet
    End Enum
    Public Class UnsupportedHeartbeatException
        Inherits Exception
        Public Sub New()
        End Sub

        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(message As String, inner As Exception)
            MyBase.New(message, inner)
        End Sub
    End Class

    Public Class Heartbeat

        Public Shared Function GenerateSalt() As String
            Dim prng As RandomNumberGenerator = RandomNumberGenerator.Create()
            Dim sb As New StringBuilder()
            Dim oneChar As Byte() = New Byte(0) {}
            While sb.Length < 32
                prng.GetBytes(oneChar)
                If oneChar(0) >= 48 AndAlso oneChar(0) <= 57 OrElse oneChar(0) >= 65 AndAlso oneChar(0) <= 90 OrElse oneChar(0) >= 97 AndAlso oneChar(0) <= 122 Then
                    sb.Append(CChar(ChrW(oneChar(0))))
                End If
            End While
            Return sb.ToString()
        End Function
        Shared ReadOnly Timeout As TimeSpan = TimeSpan.FromSeconds(10)
        Shared ReadOnly Delay As TimeSpan = TimeSpan.FromSeconds(25)
        Const UrlFileName As String = "externalurl.txt"

        Public Shared ReadOnly Salt As String = GenerateSalt()
        Shared uri As Uri


        Public Shared Sub Start()
            Dim heartbeatThread As New Thread(AddressOf Beat) With { _
                .IsBackground = True _
            }
            heartbeatThread.Start()
        End Sub

        Shared IsShown As Boolean = False
        Private Shared Sub Beat()
            While True
                Try
                    Dim requestUri As String = [String].Format("{0}?public={1}&max={2}&users={3}&port={4}&version=7&salt={5}&name={6}", Config.heartbeatURL(), Config.GetPrivacy(), Config.GetMaxPlayers(), Server.GetPlayerList().ToString(), Config.GetPort(), _
                        uri.EscapeDataString(Salt), uri.EscapeDataString(Config.GetServerName()))
                    Dim request As HttpWebRequest = DirectCast(WebRequest.Create(requestUri), HttpWebRequest)
                    request.Method = "GET"
                    request.Timeout = CInt(Timeout.TotalMilliseconds)
                    request.CachePolicy = New HttpRequestCachePolicy(HttpRequestCacheLevel.BypassCache)
                    request.UserAgent = Updater.VersionString()


                    request.ServicePoint.BindIPEndPointDelegate = AddressOf BindIPEndPointCallback

                    Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                        Dim rs = response.GetResponseStream()
                        If rs Is Nothing Then
                            Continue While
                        End If
                        Using responseReader As New StreamReader(rs)
                            Dim responseText As String = responseReader.ReadToEnd().Trim()
                            Dim newUri As Uri
                            If uri.TryCreate(responseText, UriKind.Absolute, newUri) Then
                                If newUri <> uri Then
                                    File.WriteAllText(UrlFileName, newUri.ToString())
                                    uri = newUri
                                    Dim writerArray As Writer() = New Writer() {New Writer([String].Format("Heartbeat: {0}", newUri)), New Writer([String].Format("Heartbeat URL also saved to {0} file.", UrlFileName))}
                                    For Each w As Writer In writerArray
                                        w.WriteToConsole(LogType.Normal)
                                    Next
                                End If
                            Else
                                Dim w As New Writer([String].Format("Heartbeat: Minecraft.net replied with: {0}", responseText))
                                w.WriteToConsole(LogType.Warning)
                            End If
                        End Using
                    End Using

                    Thread.Sleep(Delay)
                Catch ex As Exception
                    If Not IsShown Then
                        Dim w As New Writer([String].Format("Heartbeat: {0}: {1}", ex.[GetType]().Name, ex.Message))
                        w.WriteToConsole(LogType.Serious)
                        IsShown = True
                    End If
                End Try
            End While
        End Sub


        Private Shared Function BindIPEndPointCallback(servicePoint As ServicePoint, remoteEndPoint As IPEndPoint, retryCount As Integer) As IPEndPoint
            Return New IPEndPoint(IPAddress.Any, 0)
        End Function
    End Class
End Namespace