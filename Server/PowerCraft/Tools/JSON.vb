Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO

Namespace PowerCraft.Tools
    Public Class JSONWriter
        Public Shared Sub SaveConfig([cObj] As ConfigObj)
            Dim text As [String] = JsonConvert.SerializeObject([cObj])
            Dim textWriter As New Writer(text)
            textWriter.WriteToTextFile("config.json")
        End Sub
    End Class

    Public Class JSONReader
        Public Shared Function [cObj]() As ConfigObj
            Dim json As String = File.ReadAllText("config.json")
            Return JsonConvert.DeserializeObject(Of ConfigObj)(json)
        End Function
    End Class
End Namespace