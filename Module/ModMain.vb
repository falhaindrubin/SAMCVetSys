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

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

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

    Public Function GenerateItemRunningNo(ByVal ItemTypeCode As String, ByVal ItemType As String, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As String

        Dim NewRunningNo As String = ""
        Dim LastNo As Integer
        Dim RunningNo As Integer
        Dim DtRunningNo As New DataTable

        Try
            'Get item last number by item type number
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemTypeCode, LastNo ")
                If ItemType = "SVC" Then
                    .Append("FROM samc_runningno_svc ")
                ElseIf ItemType = "PRD" Then
                    .Append("FROM samc_runningno_prd ")
                End If
                .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtRunningNo)

            If DtRunningNo.Rows.Count > 0 Then

                LastNo = CInt(DtRunningNo.Rows(0).Item("LastNo"))
                RunningNo = LastNo + 1

                If RunningNo.ToString.Length < 2 Then
                    NewRunningNo = ItemTypeCode & RunningNo.ToString.PadLeft(2, "0"c)
                End If

                'Update LastNo
                Sb = New StringBuilder
                With Sb
                    .Append("UPDATE ")
                    If ItemType = "SVC" Then
                        .Append("samc_runningno_svc ")
                    ElseIf ItemType = "PRD" Then
                        .Append("samc_runningno_prd ")
                    End If
                    .Append("SET LastNo = '" & RunningNo & "' ")
                    .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
                End With

                Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                Cmd.ExecuteNonQuery()

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.GenerateItemRunningNo()")
        End Try

        Return NewRunningNo

    End Function

End Module
