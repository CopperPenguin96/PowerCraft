Imports System.IO
Imports System.Text

Public Class InterceptingWriter
    Inherits TextWriter
    Private _existingWriter As TextWriter
    Private _writeTask As Action(Of String)

    Public Sub New(existing As TextWriter, task As Action(Of String))
        _existingWriter = existing
        _writeTask = task
    End Sub

    Public Overrides Sub WriteLine(value As String)
        ' This outputs to the console. Remove it if you only want output to
        ' appear in your control
        _existingWriter.WriteLine(value)
        ' This calls the delegate you passed in to the constructor, updating 
        ' your textbox or anything else that acts upon the string passed in
        _writeTask(value)
    End Sub

    Public Overrides ReadOnly Property Encoding() As Encoding
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    ' ...other overrides as necessary...
End Class