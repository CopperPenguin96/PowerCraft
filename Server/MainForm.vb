Imports System.IO
Imports System.Net.Configuration
Imports PowerLib.PlayerDB
Imports PowerLib.PowerCraft
Imports PowerLib.PowerCraft.Network
Imports PowerLib.PowerCraft.Tools
Imports PowerLib
Imports Microsoft.VisualBasic.Devices.Network

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PowerLib.PowerCraft.Tools.Logger.AllocConsole()
        Config.Load() 'Let's get that configuration ready!
        Logger.Log("Your server is attempting to start based on " & Updater.VersionString())
        Logger.Log("---Server Details---")
        Logger.Log("If any of this info is incorrect, double " & _
                   "check your Config!")
        Logger.Log("Your server is " & Config.GetServerName() & " running from IP of " & Config.GetIP() & ":" & Config.GetPort() & _
                   " with Max Players of " & Config.GetMaxPlayers() & " on " & Config.GetHBLocation.ToString())
        Heartbeat.Start()
        ReceiveSocket.ListenForConnections()

    End Sub
    Dim LastPost As Integer = -1
    Private Sub LoggerTimer_Tick(sender As Object, e As EventArgs) Handles LoggerTimer.Tick
        If Me.Visible Then
            Me.Hide()
        End If
        'Try
        '   If LastPost < ServerModule.NewLog.Length Then
        '       LastPost += 1
        '       Try
        '           rtbLogBox.AppendText(ServerModule.NewLog(LastPost))
        '       Catch ex2 As IndexOutOfRangeException
        '           rtbLogBox.AppendText(ex2.StackTrace)
        '       Catch ex As NullReferenceException
        '
        '       End Try
        '   End If
        'Catch ex As NullReferenceException
        '   No logs have been intercepted yet
        '   Server must've just started up
        'End Try
    End Sub


End Class
