Imports System.Net.Sockets
Imports System.Net
Imports PowerLib.PlayerDB

Namespace PowerCraft.Network
    Public Class ReceiveSocket
        'TODO Modify to check for incoming connections based on IP and Port
        'Send it back to a new Player Object (Create that class to hold this new info!)
        Public Shared Sub ListenForConnections()
            ' create the socket 
            Dim listenSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim ep As New IPEndPoint(Config.GetIP, Config.GetPort)
            listenSocket.Bind(ep)
            ' start listening
            listenSocket.Listen(Config.GetMaxPlayers)
            listenSocket.Accept()

            'Get PlayerDB info based on listenSocket information
            Dim dBase As New Database
            'dBase.CreatePlayer(PlayerNameStr, IPOfPlayer) ' Modify to matchy listenSocket info
        End Sub
    End Class
End Namespace