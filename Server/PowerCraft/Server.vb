﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace PowerCraft
    Public Class Server
#Region "PlayerList"
        Private Shared playerList As Player()
        Public Shared Function GetPlayerList() As Player()
            Return playerList
        End Function
        Public Shared Sub SetPlayerList(pList As Player())
            playerList = pList
        End Sub
#End Region
    End Class
End Namespace