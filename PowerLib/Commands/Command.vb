Imports PowerLib.PowerCraft.PlayerDB

Namespace Commands
    Public Class Command
        Public Name As String

        Public Aliases() As String

        Public Permissions() As Permission

        Public IsConsoleSafe As Boolean

        Public Sub New(cName As String, aliasesC() As String, perms() As Permission, isSafeForConsole As Boolean)
            Name = cName
            Aliases = aliasesC
            Permissions = perms
            IsConsoleSafe = isSafeForConsole
        End Sub
        Public Overridable Sub Run(player As Player)
            'Run the command
        End Sub
    End Class
End Namespace