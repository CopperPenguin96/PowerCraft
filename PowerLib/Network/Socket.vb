Imports System.Net.Sockets
Imports System.Net
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels.Tcp
Imports PowerLib.PlayerDB
Imports PowerLib.PowerCraft.Tools

Namespace PowerCraft.Network
    Public Class ReceiveSocket
        'TODO Modify to check for incoming connections based on IP and Port
        'Send it back to a new Player Object (Create that class to hold this new info!)
        Public Shared Sub ListenForConnections()
            Try
                Dim listenEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, Config.GetPort())
                Dim tcpServer As Socket = New Socket( _
                    listenEndPoint.AddressFamily, _
                    SocketType.Stream, _
                    ProtocolType.Tcp _
                    )
                tcpServer.Bind(listenEndPoint)
                tcpServer.Listen(Integer.MaxValue)
                Dim tcpClient As Socket
                Dim receiveBuffer(4096) As Byte
                Dim rc As Integer

                While (True)
                    Try
                        tcpClient = tcpServer.Accept()
                        Logger.Log("Accepted connection from: {0}", _
                        tcpClient.RemoteEndPoint.ToString())
                        Try
                            While (True)
                                rc = tcpClient.Receive(receiveBuffer)
                                If (rc = 0) Then

                                    Exit While
                                End If
                            End While
                        Catch err As SocketException
                            Logger.Log("Connection from {0} was closed", _
                                       tcpClient.RemoteEndPoint.ToString())
                        Finally
                            tcpClient.Close()
                        End Try
                    Catch err As SocketException
                        Logger.LogWarning("Accept failed: {0}", err.Message)
                    End Try
                End While
            Catch ex As SocketException
                Logger.LogError("Only one instance of a port may run at at time! " & ex.ToString())
            End Try
        End Sub
        Public Shared Sub AcceptConnections()
            
        End Sub
    End Class
End Namespace