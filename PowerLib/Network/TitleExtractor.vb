Imports PowerCraft.Tools
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Server.PowerCraft.Tools
Imports PowerLib.PowerCraft.Tools

Namespace PowerCraft.Network
    Public Class TitleExtractor
        Public Shared Function pageTitle(url As [String]) As [String]
            Dim title As String = ""
            Try
                Dim request As HttpWebRequest = TryCast(HttpWebRequest.Create(url), HttpWebRequest)
                Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)

                Using stream As Stream = response.GetResponseStream()
                    ' compiled regex to check for <title></title> block
                    Dim titleCheck As New Regex("<title>\s*(.+?)\s*</title>", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    Dim bytesToRead As Integer = 8092
                    Dim buffer As Byte() = New Byte(bytesToRead - 1) {}
                    Dim contents As String = ""
                    Dim length As Integer = 0
                    While (InlineAssignHelper(length, stream.Read(buffer, 0, bytesToRead))) > 0
                        ' convert the byte-array to a string and add it to the rest of the
                        ' contents that have been downloaded so far
                        contents += Encoding.UTF8.GetString(buffer, 0, length)

                        Dim m As Match = titleCheck.Match(contents)
                        If m.Success Then
                            ' we found a <title></title> match =]
                            title = m.Groups(1).Value.ToString()
                            Exit While
                        ElseIf contents.Contains("</head>") Then
                            ' reached end of head-block; no title found =[
                            Exit While
                        End If
                    End While
                End Using
                Return title
            Catch e As Exception
                Logger.Log("Failed to catch page title for " + url)
                Return "Error"
            End Try
        End Function
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace