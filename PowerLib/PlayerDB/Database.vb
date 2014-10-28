Option Infer On

Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SQLite
Imports System.IO

Namespace PowerCraft.PlayerDB
    ''' <summary>
    ''' Class for interaction with a SQLite Database holding critical user information. Some of this information (Such as IP) is used for logging purposes,
    ''' and may be used for looking up bans.
    ''' </summary>
    Public Class Database
        Implements IDisposable
        Const DatabaseName As String = "Database.s3db"
        Public DBConnection As SQLiteConnection
        ReadOnly _dbLock As New Object()

        Public Sub New()
            If Not File.Exists(Convert.ToString("Settings/") & DatabaseName) Then
                ' -- We need to create the PlayerDB.
                SQLiteConnection.CreateFile(Path.GetFullPath(Convert.ToString("Settings/") & DatabaseName))

                ' -- Now we need to connect and create the table.
                SyncLock _dbLock
                    Dim connection = New SQLiteConnection("Data Source=" + Path.GetFullPath(Convert.ToString("Settings/") & DatabaseName))
                    connection.Open()

                    Dim command = New SQLiteCommand("CREATE TABLE PlayerDB (Number INTEGER PRIMARY KEY, Name TEXT UNIQUE, Rank TEXT, RankStep TEXT, BoundBlock INTEGER, RankChangedBy TEXT, LoginCounter INTEGER, KickCounter INTEGER, Ontime INTEGER, LastOnline INTEGER, IP TEXT, Stopped INTEGER, StoppedBy TEXT, Banned INTEGER, Vanished INTEGER, BannedBy STRING, BannedUntil INTEGER, Global INTEGER, Time_Muted INTEGER, BanMessage TEXT, KickMessage TEXT, MuteMessage TEXT, RankMessage TEXT, StopMessage TEXT)", connection)
                    command.ExecuteNonQuery()

                    command.CommandText = "CREATE INDEX PlayerDB_Index ON PlayerDB (Name COLLATE NOCASE)"
                    command.ExecuteNonQuery()

                    command.CommandText = "CREATE TABLE IPBanDB (Number INTEGER PRIMARY KEY, IP TEXT UNIQUE, Reason TEXT, BannedBy TEXT)"
                    command.ExecuteNonQuery()

                    ' -- All done.
                    DBConnection = connection
                End SyncLock
            Else
                DBConnection = New SQLiteConnection("Data Source=" + Path.GetFullPath(Convert.ToString("Settings/") & DatabaseName))
                DBConnection.Open()
            End If
        End Sub

        ''' <summary>
        ''' Creates a new entry in the PlayerDB for a player.
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="ip"></param>
        Public Sub CreatePlayer(name As String, ip As String)
            Dim myValues = New Dictionary(Of String, String)() From { _
                {"Name", name}, _
                {"IP", ip}, _
                {"Rank", Config.GetDefaultRank().ToString()}, _
                {"RankStep", "0"}, _
                {"Global", "1"}, _
                {"Banned", "0"}, _
                {"Stopped", "0"}, _
                {"Vanished", "0"}, _
                {"BoundBlock", "1"} _
            }

            Insert("PlayerDB", myValues)
        End Sub

        ''' <summary>
        ''' Checks to see if a player by this name already exists for this server.
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function ContainsPlayer(name As String) As Boolean
            Dim dt = GetDataTable((Convert.ToString("SELECT * FROM PlayerDB WHERE Name='") & name) + "'")

            For Each c As DataRow In dt.Rows
                If DirectCast(c("Name"), String).ToLower() = name.ToLower() Then
                    Return True
                End If
            Next

            Return False
        End Function

        ''' <summary>
        ''' Returns the Case-correct version of a player's name.
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function GetPlayerName(name As String) As String
            Dim dt = GetDataTable((Convert.ToString("SELECT * FROM PlayerDB WHERE Name='") & name) + "'")

            For Each c As DataRow In dt.Rows
                If DirectCast(c("Name"), String).ToLower() = name.ToLower() Then
                    Return DirectCast(c("Name"), String)
                End If
            Next


            Return ""
        End Function

        ''' <summary>
        ''' Get a Player's Name from their index in the table.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function GetPlayerName(id As Integer) As String
            Dim dt = GetDataTable("SELECT * FROM PlayerDB WHERE Number=" + id + "")

            For Each c As DataRow In dt.Rows
                If CLng(c("Number")) = id Then
                    Return DirectCast(c("Name"), String)
                End If
            Next

            Return ""
        End Function

        Public Sub BanPlayer(name As String, reason As String, bannedBy As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "Banned", 1)
            SetDatabase(name, "PlayerDB", "BanMessage", reason)
            SetDatabase(name, "PlayerDB", "BannedBy", bannedBy)
        End Sub

        Public Sub UnbanPlayer(name As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "Banned", 0)
        End Sub

        Public Sub StopPlayer(name As String, reason As String, stoppedBy As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "Stopped", 1)
            SetDatabase(name, "PlayerDB", "StopMessage", reason)
            SetDatabase(name, "PlayerDB", "StoppedBy", stoppedBy)
        End Sub

        Public Sub UnstopPlayer(name As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "Stopped", 0)
        End Sub

        Public Sub MutePlayer(name As String, minutes As Integer, reason As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "MuteMessage", reason)
            SetDatabase(name, "PlayerDB", "Time_Muted", minutes)
        End Sub

        Public Sub UnmutePlayer(name As String)
            name = GetPlayerName(name)
            SetDatabase(name, "PlayerDB", "Time_Muted", 0)
        End Sub

        Public Sub IpBan(ip As String, reason As String, bannedby As String)
            Dim values = New Dictionary(Of String, String)() From { _
                {"IP", ip}, _
                {"Reason", reason}, _
                {"BannedBy", bannedby} _
            }
            Insert("IPBanDB", values)
        End Sub

        Public Sub UnIpBan(ip As String)
            If Not IsIpBanned(ip) Then
                Return
            End If

            Delete("IPBanDB", (Convert.ToString("IP='") & ip) + "'")
        End Sub

        Public Function IsIpBanned(ip As String) As Boolean
            Dim dt = GetDataTable((Convert.ToString("SELECT * FROM IPBanDB WHERE IP=='") & ip) + "'")
            Return dt.Rows.Cast(Of DataRow)().Any(Function(c) DirectCast(c("IP"), String) = ip)
        End Function

        ''' <summary>
        ''' Retreives an integer value from the database.
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="field"></param>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function GetDatabaseInt(name As String, table As String, field As String) As Integer
            Dim dt = GetDataTable((Convert.ToString((Convert.ToString("SELECT * FROM ") & table) + " WHERE Name='") & name) + "' LIMIT 1")

            Try
                Return Convert.ToInt32(dt.Rows(0)(field))
            Catch
                Return -1
            End Try
        End Function

        ''' <summary>
        ''' Retreives a string value from the database.
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="field"></param>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function GetDatabaseString(name As String, table As String, field As String) As String
            Dim dt = GetDataTable((Convert.ToString((Convert.ToString("SELECT * FROM ") & table) + " WHERE Name='") & name) + "' LIMIT 1")

            Try
                Return DirectCast(dt.Rows(0)(field), String)
            Catch
                Return ""
            End Try
        End Function

        ''' <summary>
        ''' Sets a value on the player in the database.
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="field"></param>
        ''' <param name="value"></param>
        ''' <param name="name"></param>
        Public Sub SetDatabase(name As String, table As String, field As String, value As Boolean)
            Dim values = New Dictionary(Of String, String)() From { _
                {field, value.ToString()} _
            }

            Update(table, values, (Convert.ToString("Name='") & name) + "'")
        End Sub

        ''' <summary>
        ''' Sets a value on the player in the database.
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="field"></param>
        ''' <param name="value"></param>
        ''' <param name="name"></param>
        Public Sub SetDatabase(name As String, table As String, field As String, value As Integer)
            Dim values = New Dictionary(Of String, String)() From { _
                {field, value.ToString()} _
            }
            Update(table, values, (Convert.ToString("Name='") & name) + "'")
        End Sub

        ''' <summary>
        ''' Sets a value on the player in the database.
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="field"></param>
        ''' <param name="value"></param>
        ''' <param name="name"></param>
        Public Sub SetDatabase(name As String, table As String, field As String, value As String)
            Dim values = New Dictionary(Of String, String)() From { _
                {field, value} _
            }
            Update(table, values, (Convert.ToString("Name='") & name) + "'")
        End Sub

#Region "Basic DB Interaction"
        ' -- Taken / Inspired from.
        ' -- http://www.dreamincode.net/forums/topic/157830-using-sqlite-with-c%23/#/

        Public Function GetDataTable(sql As String) As DataTable
            Dim dt = New DataTable()

            Try
                SyncLock _dbLock
                    Dim command = New SQLiteCommand(DBConnection) With { _
                        .CommandText = sql _
                    }

                    Dim reader = Command.ExecuteReader()
                    dt.Load(reader)
                    reader.Close()
                End SyncLock
            Catch e As SQLiteException
                Throw New Exception(e.Message)
            End Try

            Return dt
        End Function

        Public Function ExecuteNonQuery(sql As String) As Integer
            SyncLock _dbLock
                Dim command = New SQLiteCommand(DBConnection) With { _
                    .CommandText = sql _
                }

                Dim rowsUpdated = Command.ExecuteNonQuery()

                Return rowsUpdated
            End SyncLock
        End Function

        Public Function Update(tableName As [String], data As Dictionary(Of [String], [String]), where As [String]) As Boolean
            Dim vals = ""
            Dim returnCode = True

            If data.Count >= 1 Then
                For Each Value In data
                    vals += [String].Format(" {0} = '{1}',", Value.Key, Value.Value)
                Next

                vals = vals.Substring(0, vals.Length - 1)
            End If

            Try
                ExecuteNonQuery([String].Format("update {0} set {1} where {2};", tableName, vals, where))
            Catch
                returnCode = False
            End Try

            Return returnCode
        End Function

        ''' <summary>
        '''     Allows the programmer to easily delete rows from the DB.
        ''' </summary>
        ''' <param name="tableName">The table from which to delete.</param>
        ''' <param name="where">The where clause for the delete.</param>
        ''' <returns>A boolean true or false to signify success or failure.</returns>
        Public Function Delete(tableName As [String], where As [String]) As Boolean
            Dim returnCode = True

            Try
                ExecuteNonQuery([String].Format("delete from {0} where {1};", tableName, where))
            Catch
                returnCode = False
            End Try

            Return returnCode
        End Function

        ''' <summary>
        '''     Allows the programmer to easily insert into the DB
        ''' </summary>
        ''' <param name="tableName">The table into which we insert the data.</param>
        ''' <param name="data">A dictionary containing the column names and data for the insert.</param>
        ''' <returns>A boolean true or false to signify success or failure.</returns>
        Public Function Insert(tableName As [String], data As Dictionary(Of [String], [String])) As Boolean
            Dim columns = ""
            Dim values = ""
            Dim returnCode = True

            For Each Value In data
                columns += [String].Format(" {0},", Value.Key)
                values += [String].Format(" '{0}',", Value.Value)
            Next

            columns = columns.Substring(0, columns.Length - 1)
            values = values.Substring(0, values.Length - 1)

            Try
                ExecuteNonQuery([String].Format("insert into {0}({1}) values({2});", tableName, columns, values))
            Catch
                returnCode = False
            End Try

            Return returnCode
        End Function

        ''' <summary>
        '''     Allows the programmer to easily delete all data from the DB.
        ''' </summary>
        ''' <returns>A boolean true or false to signify success or failure.</returns>
        Public Function ClearDB() As Boolean
            Try
                Dim tables = GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;")

                For Each table As DataRow In tables.Rows
                    ClearTable(table("NAME").ToString())
                Next

                Return True
            Catch
                Return False
            End Try
        End Function

        Public Function ClearTable(table As [String]) As Boolean
            Try
                ExecuteNonQuery(String.Format("delete from {0};", table))
                Return True
            Catch
                Return False
            End Try
        End Function

#End Region

        Public Sub Dispose()
            DBConnection.Close()
            DBConnection.Dispose()
        End Sub

        Public Sub IDisposable_Dispose() Implements IDisposable.Dispose
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace