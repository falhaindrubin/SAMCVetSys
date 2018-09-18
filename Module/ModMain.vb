'Imports System.Data.Odbc
'Imports System.Globalization
Imports System.Text

Module ModMain

    Public DbConn As New OdbcConnection
    Public DbTrans As OdbcTransaction

    'Database credentials
    Public SERVER As String
    Public DATABASE As String
    Public PORT As String
    Public UID As String
    Public PWD As String
    Public CURR_USER As String
    Public FORM_NAME As String
    Public SOFTWARE_VERSION As String

    Dim sb As StringBuilder
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter

    'Database connection
    Public Function ConnectToDB() As Boolean

        Try
            SERVER = "localhost"
            DATABASE = "samc_db"
            PORT = "3306"
            UID = "root"
            PWD = "015015dr"

            DBConn.ConnectionString =
                "DRIVER={MySQL ODBC 8.0 UNICODE Driver};" &
                "SERVER=" & SERVER & ";" &
                "PORT=" & PORT & ";" &
                "DATABASE=" & DATABASE & ";" &
                "USER=" & UID & ";" &
                "PASSWORD=" & PWD & ";"

            DBConn.Open()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.ConnectToDB()")
            Return False
        End Try

        Return True

    End Function

    Public Function GenerateRunningNo(ByVal Prefix As String, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction, Optional ByVal Prefix2 As String = "") As String

        Dim NewRunningNo As String = ""
        Dim RunningNo As Integer
        Dim DtRunningNo As New DataTable

        Try
            'Create customer number based on customer's first name letter
            'Check prefix = 'CT'
            'If CT, select alphabet prefix in database {A-Z}

            'Get last customer number
            sb = New StringBuilder
            With sb
                .Append("SELECT LastNo, Prefix2 ")
                .Append("FROM samc_runningno ")
                .Append("WHERE Prefix = '" & Prefix & "' ")

                If Prefix = "CT" Then
                    .Append("AND Prefix2 = '" & Prefix2 & "' ")
                End If

            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtRunningNo)

            If DtRunningNo.Rows.Count > 0 Then

                Dim LastNo As Integer
                'Dim ZeroPadLength As Integer

                If Prefix = "PT" And Prefix2 <> "" Then 'Check if running number is to be generated is PetID, use Prefix2 (PetCount) to give PetID running no
                    LastNo = CInt(Prefix2)
                Else
                    LastNo = CInt(DtRunningNo.Rows(0).Item("LastNo"))
                End If

                RunningNo = LastNo + 1
                'ZeroPadLength = 6 - RunningNo.ToString.Length

                If RunningNo.ToString.Length < 8 Then
                    If Prefix = "CT" Then
                        NewRunningNo = Prefix2 & RunningNo.ToString.PadLeft(8, "0"c)
                    Else
                        NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                    End If
                Else
                    If Prefix = "CT" Then
                        NewRunningNo = Prefix2 & RunningNo.ToString
                    Else
                        NewRunningNo = Prefix & RunningNo.ToString
                    End If
                    NewRunningNo = Prefix & RunningNo.ToString
                End If

                'Update CustomerNo
                sb = New StringBuilder
                With sb
                    .Append("UPDATE samc_runningno ")
                    .Append("SET LastNo = '" & RunningNo & "' ")
                    .Append("WHERE Prefix = '" & Prefix & "' ")

                    If Prefix = "CT" Then
                        .Append("AND Prefix2 = '" & Prefix2 & "' ")
                    End If

                End With

                cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
                cmd.ExecuteNonQuery()

            Else
                MsgBox("Failed to generate running number [" & Prefix & "].", MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")
        End Try

        Return NewRunningNo

    End Function

    Public Function ResetPetIDRunningNo(ByVal Prefix As String, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Try
            'Reset Pet ID
            If Prefix <> "PT" Then
                MsgBox("Unable to proceed. Wrong prefix pass detected.", MsgBoxStyle.Critical, "Wrong Prefix Detected.")
                Return False
            End If

            sb = New StringBuilder
            With sb
                .Append("UPDATE samc_runningno ")
                .Append("SET LastNo = '0' ")
                .Append("WHERE Prefix = '" & Prefix & "' ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ModMain.ResetPetIDRunningNo()")
            Return False
        End Try

        Return True

    End Function

    'Public Function CSQLDateTime(ByVal DateValue As DateTime) As String

    '    Dim MySQLDate As String = ""

    '    Try
    '        'MySQLDate = DateTime.ParseExact(DateValue, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture)
    '        MySQLDate = DateValue.ToString("yyyy-MM-dd HH:mm:ss")

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.CSQLDateTime()")
    '    End Try

    '    Return MySQLDate

    'End Function

    'Public Function CSQLDate(ByVal DateValue As DateTime) As String

    '    Dim MySQLDate As String = ""

    '    Try
    '        'MySQLDate = DateTime.ParseExact(DateValue, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture)
    '        MySQLDate = DateValue.ToString("yyyy-MM-dd")

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.CSQLDate()")
    '    End Try

    '    Return MySQLDate

    'End Function

End Module
