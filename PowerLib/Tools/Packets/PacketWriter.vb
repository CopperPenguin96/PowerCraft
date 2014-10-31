' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org> | See LICENSE.txt
Imports System.IO
Imports System.Net
Imports System.Text
Imports JetBrains.Annotations
Imports PowerLib.Tools.Packets.FemtoCraft

Namespace Tools.Packets
    NotInheritable Class PacketWriter
        Inherits BinaryWriter
        Public Sub New(<NotNull> stream As Stream)
            MyBase.New(stream)
        End Sub


        Public Overloads Sub Write(value As OpCode)
            Write(CByte(value))
        End Sub


        Public Overrides Sub Write(value As Short)
            MyBase.Write(IPAddress.HostToNetworkOrder(value))
        End Sub


        Public Overrides Sub Write(value As String)
            If value Is Nothing Then
                Throw New ArgumentNullException("value")
            End If
            MyBase.Write(Encoding.ASCII.GetBytes(value.PadRight(64).Substring(0, 64)))
        End Sub


    End Class
    ' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org> | See LICENSE.txt

    Namespace FemtoCraft
        Enum OpCode As Byte
            Handshake = 0
            Ping = 1
            MapBegin = 2
            MapChunk = 3
            MapEnd = 4
            SetBlockClient = 5
            SetBlockServer = 6
            AddEntity = 7
            Teleport = 8
            MoveRotate = 9
            Move = 10
            Rotate = 11
            RemoveEntity = 12
            Message = 13
            Kick = 14
            SetPermission = 15

            ' CPE
            ExtInfo = 16
            ExtEntry = 17
            CustomBlockSupportLevel = 19
            SetBlockPermission = 28
        End Enum
    End Namespace

End Namespace