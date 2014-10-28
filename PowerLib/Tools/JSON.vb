
Imports System.IO
Imports Newtonsoft.Json
Imports PowerLib.PowerCraft
Imports PowerLib.PowerCraft.Tools

Namespace Tools
    Public Class JSONWriter
        Public Shared Sub SaveConfig([cObj] As ConfigObj)
            Dim text As [String] = JsonConvert.SerializeObject([cObj])
            Writer.WriteToTextFile(text, "config.json")
        End Sub

        Public Shared Sub SaveRankConfig(rObj As RankObj)
            Dim text As [String] = JsonConvert.SerializeObject(rObj)
            Writer.WriteToTextFile(text, "ranks.json")
        End Sub
    End Class

    Public Class JSONReader
        Public Shared Function [cObj]() As ConfigObj
            Dim json As String = File.ReadAllText("config.json")
            Return JsonConvert.DeserializeObject(Of ConfigObj)(json)
        End Function

        Public Shared Function rObj() As RankObj
            Dim json As String = File.ReadAllText("ranks.json")
            Return JsonConvert.DeserializeObject(Of RankObj)(json)
        End Function
    End Class

End Namespace