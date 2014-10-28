Imports System.IO
Imports PowerLib.PowerCraft.Tools

Public Class Exceptions
    Public Shared Function GetExcString(ex As Exception) As String
        If File.Exists("PowerLib.pdb") Then
            Return ex.StackTrace
        Else
            Return ex.ToString()
        End If
    End Function
End Class
