Imports System.IO

Namespace PowerCraft.Tools
    Public Class Writer
        Public Shared Sub WriteToTextFile(text As String, files As String)
            Dim x As StreamWriter = File.CreateText(files)
            x.Write(text)
            x.Close()
        End Sub
    End Class
End Namespace