' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org> | See LICENSE.txt
Imports System.IO
Imports System.Net
Imports System.Text
Imports JetBrains.Annotations
Imports PowerLib.Tools.Packets.FemtoCraft

Namespace Tools.Packets
    NotInheritable Class PacketReader
        Inherits BinaryReader
        Public Sub New(<NotNull> stream As Stream)
            MyBase.New(stream)
        End Sub


        Public Function ReadOpCode() As OpCode
            Return DirectCast(ReadByte(), OpCode)
        End Function


        Public Overrides Function ReadInt16() As Short
            Return IPAddress.NetworkToHostOrder(MyBase.ReadInt16())
        End Function


        Public Overrides Function ReadInt32() As Integer
            Return IPAddress.NetworkToHostOrder(MyBase.ReadInt32())
        End Function


        Public Overrides Function ReadString() As String
            Return Encoding.ASCII.GetString(ReadBytes(64)).Trim()
        End Function
    End Class
End Namespace