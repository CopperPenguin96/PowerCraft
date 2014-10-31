' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org> | See LICENSE.txt
Imports System.Text
Imports JetBrains.Annotations
Imports PowerLib.PlayerDB
Imports PowerLib.Tools.Packets.FemtoCraft
Imports PowerLib.PowerCraft

Namespace Tools.Packets
    Partial Structure Packet
        Public Const ProtocolVersion As Byte = 7
        Public ReadOnly Bytes As Byte()


        Public ReadOnly Property OpCode() As OpCode
            Get
                Return DirectCast(Bytes(0), OpCode)
            End Get
        End Property


        Public Sub New(opCode As OpCode)
            Bytes = New Byte(GetPacketSize(opCode) - 1) {}
            Bytes(0) = CByte(opCode)
        End Sub


        Public Sub New(<NotNull> bytes__1 As Byte())
            Bytes = bytes__1
        End Sub


#Region "Packet-Making"

        <Pure> _
        Public Shared Function MakeHandshake(isOp As Boolean) As Packet
            'Logger.Log( "Send: Handshake({0},{1},{2})", Config.ServerName, Config.MOTD, isOp ? (byte)100 : (byte)0 );
            Dim packet As New Packet(OpCode.Handshake)
            packet.Bytes(1) = ProtocolVersion
            Encoding.ASCII.GetBytes(Config.GetServerName().PadRight(64), 0, 64, packet.Bytes, 2)
            Encoding.ASCII.GetBytes(Config.GetMOTD().PadRight(64), 0, 64, packet.Bytes, 66)
            packet.Bytes(130) = If(isOp, CByte(100), CByte(0))
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeSetBlock(x As Integer, y As Integer, z As Integer, type As Block) As Packet
            Dim packet As New Packet(OpCode.SetBlockServer)
            ToNetOrder(CShort(x), packet.Bytes, 1)
            ToNetOrder(CShort(z), packet.Bytes, 3)
            ToNetOrder(CShort(y), packet.Bytes, 5)
            'packet.Bytes(7) = CByte(type)
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeAddEntity(id As Byte, <NotNull> name As String, pos As Position) As Packet
            If name Is Nothing Then
                Throw New ArgumentNullException("name")
            End If
            Dim packet As New Packet(OpCode.AddEntity)
            packet.Bytes(1) = id
            Encoding.ASCII.GetBytes(name.PadRight(64), 0, 64, packet.Bytes, 2)
            ToNetOrder(pos.X, packet.Bytes, 66)
            ToNetOrder(pos.Z, packet.Bytes, 68)
            ToNetOrder(pos.Y, packet.Bytes, 70)
            packet.Bytes(72) = pos.R
            packet.Bytes(73) = pos.L
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeTeleport(id As Byte, pos As Position) As Packet
            Dim packet As New Packet(OpCode.Teleport)
            packet.Bytes(1) = id
            ToNetOrder(pos.X, packet.Bytes, 2)
            ToNetOrder(pos.Z, packet.Bytes, 4)
            ToNetOrder(pos.Y, packet.Bytes, 6)
            packet.Bytes(8) = pos.R
            packet.Bytes(9) = pos.L
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeSelfTeleport(pos As Position) As Packet
            Return MakeTeleport(255, pos.GetFixed())
        End Function


        <Pure> _
        Public Shared Function MakeMoveRotate(id As Integer, pos As Position) As Packet
            Dim packet As New Packet(OpCode.MoveRotate)
            packet.Bytes(1) = CByte(id)
            packet.Bytes(2) = CByte(pos.X And &HFF)
            packet.Bytes(3) = CByte(pos.Z And &HFF)
            packet.Bytes(4) = CByte(pos.Y And &HFF)
            packet.Bytes(5) = pos.R
            packet.Bytes(6) = pos.L
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeMove(id As Integer, pos As Position) As Packet
            Dim packet As New Packet(OpCode.Move)
            packet.Bytes(1) = CByte(id)
            packet.Bytes(2) = CByte(pos.X)
            packet.Bytes(3) = CByte(pos.Z)
            packet.Bytes(4) = CByte(pos.Y)
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeRotate(id As Integer, pos As Position) As Packet
            Dim packet As New Packet(OpCode.Rotate)
            packet.Bytes(1) = CByte(id)
            packet.Bytes(2) = pos.R
            packet.Bytes(3) = pos.L
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeRemoveEntity(id As Integer) As Packet
            Dim packet As New Packet(OpCode.RemoveEntity)
            packet.Bytes(1) = CByte(id)
            Return packet
        End Function


        Public Shared Function MakeKick(<NotNull> reason As String) As Packet
            If reason Is Nothing Then
                Throw New ArgumentNullException("reason")
            End If
            Dim packet As New Packet(OpCode.Kick)
            Encoding.ASCII.GetBytes(reason.PadRight(64), 0, 64, packet.Bytes, 1)
            Return packet
        End Function


        <Pure> _
        Public Shared Function MakeSetPermission(isOp As Boolean) As Packet
            Dim packet As New Packet(OpCode.SetPermission)
            If isOp Then
                packet.Bytes(1) = 100
            End If
            Return packet
        End Function

#End Region


        Private Shared Sub ToNetOrder(number As Short, <NotNull> arr As Byte(), offset As Integer)
            If arr Is Nothing Then
                Throw New ArgumentNullException("arr")
            End If
            arr(offset) = CByte((number And &HFF00) >> 8)
            arr(offset + 1) = CByte(number And &HFF)
        End Sub


        Private Shared Sub ToNetOrder(number As Integer, <NotNull> arr As Byte(), offset As Integer)
            If arr Is Nothing Then
                Throw New ArgumentNullException("arr")
            End If
            arr(offset) = CByte((number And &HFF000000UI) >> 24)
            arr(offset + 1) = CByte((number And &HFF0000) >> 16)
            arr(offset + 2) = CByte((number And &HFF00) >> 8)
            arr(offset + 3) = CByte(number And &HFF)
        End Sub


        Private Shared Function GetPacketSize(opCode As OpCode) As Integer
            Return PacketSizes(CInt(opCode))
        End Function


        ' Handshake
        ' Ping
        ' MapBegin
        ' MapChunk
        ' MapEnd
        ' SetBlockClient
        ' SetBlockServer
        ' AddEntity
        ' Teleport
        ' MoveRotate
        ' Move
        ' Rotate
        ' RemoveEntity
        ' Message
        ' Kick
        ' SetPermission
        ' ExtInfo
        ' ExtEntry
        ' CustomBlockSupportLevel
        ' SetBlockPermission
        Shared ReadOnly PacketSizes As Integer() = {131, 1, 1, 1028, 7, 9, _
            8, 74, 10, 7, 5, 4, _
            2, 66, 65, 2, 67, 69, _
            0, 2, 0, 0, 0, 0, _
            0, 0, 0, 0, 4}
    End Structure
End Namespace