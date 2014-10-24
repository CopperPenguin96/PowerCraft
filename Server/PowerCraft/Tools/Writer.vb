Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace PowerCraft.Tools

    Public Enum LogType
        Normal
        Warning
        Serious
    End Enum
    Public Class WriterAdapter
        Private Function Time() As [String]
            Return "<" + DateTime.Now.ToString("h:mm:ss tt") + ">"
        End Function

    End Class
    Public Class Writer
        Private text As [String]
        Public Sub New(textTobeWritten As [String])
            text = textTobeWritten
        End Sub
        Public Sub WriteToTextFile(filePath As [String])
            Dim sWriter As StreamWriter = File.CreateText(filePath)
            sWriter.Write(text)
            sWriter.Close()
        End Sub
        Public Shared wAdapter As WriterAdapter = Nothing
        Public Sub WriteToConsole(lType As LogType)
            If text Is Nothing Then
                Throw New ArgumentNullException("message")
            End If
            If text.Contains(ControlChars.Lf) Then
                For Each line As String In text.Split(ControlChars.Lf)
                    Dim w As New Writer(line)
                    w.WriteToConsole(lType)
                Next
                Return
            End If
            Dim processedMessage As String = "# "
            For i As Integer = 0 To text.Length - 1
                If text(i) = "&"c Then
                    i += 1
                Else
                    processedMessage += text(i)
                End If
            Next
            Log(lType, processedMessage)
        End Sub
        Public Sub Log(l As LogType, message As [String])

        End Sub
    End Class
End Namespace
