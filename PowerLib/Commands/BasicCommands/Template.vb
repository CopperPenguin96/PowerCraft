
Imports PowerLib.PlayerDB
Imports PowerLib.Commands
Imports PowerLib.PowerCraft.Tools

Public Class Template
    Inherits Command
    Public Sub New(cName As String, aliasesC() As String, perms() As Permission, isSafeForConsole As Boolean)
        MyBase.New(cName, aliasesC, perms, isSafeForConsole) ' Inits into the object what was defined
    End Sub
    Public Overrides Sub Run(player As Player)
        Logger.Log("The template command has been run with paremters " & _
                   MyBase.Name)
    End Sub
End Class
