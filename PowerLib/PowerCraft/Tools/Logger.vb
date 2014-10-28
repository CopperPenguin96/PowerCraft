' Part of FemtoCraft | Copyright 2012-2013 Matvei Stefarov <me@matvei.org> | See LICENSE.txt
Imports System.IO
Imports JetBrains.Annotations
Imports System.Runtime.InteropServices

Namespace PowerCraft.Tools
    Public Class Logger
        <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean

        End Function
        Private Sub New()
        End Sub
        Const LogFileName As String = "server.log"
        Shared ReadOnly LogLock As New Object()


        <StringFormatMethod("message")> _
        Public Shared Sub LogError(<NotNull> message As String, <NotNull> ParamArray formatArgs As Object())
            LogInternal(message, formatArgs, "ERROR ", True)
        End Sub


        <StringFormatMethod("message")> _
        Public Shared Sub LogWarning(<NotNull> message As String, <NotNull> ParamArray formatArgs As Object())
            LogInternal(message, formatArgs, "Warning ", True)
        End Sub


        <StringFormatMethod("message")> _
        Public Shared Sub LogChat(<NotNull> message As String, <NotNull> ParamArray formatArgs As Object())
            LogInternal(message, formatArgs, "Chat ", False)
        End Sub


        <StringFormatMethod("message")> _
        Public Shared Sub LogCommand(<NotNull> message As String, <NotNull> ParamArray formatArgs As Object())
            LogInternal(message, formatArgs, "Command ", False)
        End Sub


        <StringFormatMethod("message")> _
        Public Shared Sub Log(<NotNull> message As String, <NotNull> ParamArray formatArgs As Object())
            LogInternal(message, formatArgs, "", False)
        End Sub
        Shared lineCount As Integer = 0
        Private Shared Sub LogInternal(<NotNull> message As String, <NotNull> formatArgs As Object(), <NotNull> prefix As String, [error] As Boolean)
            If message Is Nothing Then
                Throw New ArgumentNullException("message")
            End If
            If formatArgs Is Nothing Then
                Throw New ArgumentNullException("formatArgs")
            End If
            If prefix Is Nothing Then
                Throw New ArgumentNullException("prefix")
            End If
            SyncLock LogLock
                Dim formattedMessage As String = Nothing
                If formatArgs.Length > 0 Then
                    formattedMessage = String.Format(message, formatArgs)
                Else
                    formattedMessage = message
                End If
                Dim consoleMessage As String = [String].Format("{0} {1}> {2}", ConsoleTimestamp(), prefix, formattedMessage)
                If [error] Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.[Error].WriteLine(consoleMessage)
                    Console.ResetColor()
                Else
                    Console.WriteLine(consoleMessage)
                End If
                Dim fileMessage As String = [String].Format("{0} {1}> {2}{3}", FileTimestamp(), prefix, [String].Format(message, formatArgs), Environment.NewLine)
                File.AppendAllText(LogFileName, fileMessage)
            End SyncLock
        End Sub

        <NotNull, Pure> _
        Private Shared Function FileTimestamp() As String
            Return DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")
        End Function


        <NotNull, Pure> _
        Private Shared Function ConsoleTimestamp() As String
            Return DateTime.Now.ToString("HH':'mm':'ss")
        End Function
    End Class
End Namespace