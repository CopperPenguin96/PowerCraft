Imports PowerLib.PlayerDB

Namespace PowerCraft
    Public Class Server
#Region "PlayerList"
        Private Shared playerList As Player() = {New Player()}
        Public Shared Function GetPlayerList() As Player()
            Return playerList
        End Function
        Public Shared Sub SetPlayerList(pList As Player())
            playerList = pList
        End Sub
#End Region
    End Class
End Namespace