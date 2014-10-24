Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace PowerCraft.Tools
    Public Class Updater
        Public Shared Function VersionString() As [String]
            Return "PowerCraft " + versionNumber()
        End Function
        Public Shared Function versionNumber() As [String]
            Return "1.0.0.0"
        End Function
    End Class
End Namespace