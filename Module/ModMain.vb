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
    'Public CURR_USER_EMPID As String
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

            Select Case Prefix
                'Generate invoice
                Case "INV" '--INVOICE
                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT LastNo, Prefix2 ")
                        .Append("FROM samc_runningno ")
                        .Append("WHERE Prefix = '" & Prefix & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

                    If DtRunningNo.Rows.Count > 0 Then
                        'Dim LastNo As Integer
                        RunningNo = DtRunningNo.Rows(0).Item("LastNo") + 1
                        If RunningNo.ToString.Length < 8 Then
                            NewRunningNo = DtRunningNo.Rows(0).Item("Prefix2") & "-" & RunningNo.ToString.PadLeft(8, "0"c)
                        Else
                            NewRunningNo = DtRunningNo.Rows(0).Item("Prefix2") & "-" & RunningNo.ToString
                        End If

                        'Update CustomerNo
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    End If

                Case "CT" '--CUSTOMER
                    'Generate CustomerID

                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT LastNo, Prefix2 ")
                        .Append("FROM samc_runningno ")
                        .Append("WHERE Prefix = '" & Prefix & "' ")

                        If Prefix = "CT" Then
                            .Append("AND Prefix2 = '" & Prefix2 & "' ")
                        End If

                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

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
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")

                            If Prefix = "CT" Then
                                .Append("AND Prefix2 = '" & Prefix2 & "' ")
                            End If

                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    Else
                        MsgBox("Failed to generate running number [" & Prefix & "].", MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")

                    End If

                Case "PT"

                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT LastNo, Prefix2 ")
                        .Append("FROM samc_runningno ")
                        .Append("WHERE Prefix = '" & Prefix & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

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
                            NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                            'If Prefix = "PT" Then
                            '    NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                            'Else
                            '    NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                            'End If
                        Else
                            If Prefix = "PT" Then
                                NewRunningNo = Prefix2 & RunningNo.ToString
                            Else
                                NewRunningNo = Prefix & RunningNo.ToString
                            End If
                            NewRunningNo = Prefix & RunningNo.ToString
                        End If

                        'Update PetID
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    Else
                        MsgBox("Failed to generate running number [" & Prefix & "].", MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")

                    End If


                Case "VS"
                    'Create VisitID
                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT LastNo, Prefix2 ")
                        .Append("FROM samc_runningno ")
                        .Append("WHERE Prefix = '" & Prefix & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

                    If DtRunningNo.Rows.Count > 0 Then

                        RunningNo = CInt(DtRunningNo.Rows(0).Item("LastNo")) + 1

                        If RunningNo.ToString.Length < 8 Then
                            NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                        Else
                            NewRunningNo = Prefix & RunningNo.ToString
                        End If

                        'Update VisitID
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    Else
                        MsgBox("Failed to generate running number [" & Prefix & "].", MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")

                    End If

                Case "WD" '--Ward
                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT LastNo, Prefix2 ")
                        .Append("FROM samc_runningno ")
                        .Append("WHERE Prefix = '" & Prefix & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

                    If DtRunningNo.Rows.Count > 0 Then

                        RunningNo = CInt(DtRunningNo.Rows(0).Item("LastNo")) + 1

                        If RunningNo.ToString.Length < 8 Then
                            NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                        Else
                            NewRunningNo = Prefix & RunningNo.ToString
                        End If

                        'Update VisitID
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    Else
                        MsgBox("Failed to generate running number [" & Prefix & "].", MsgBoxStyle.Critical, "ModMain.GenerateRunningNo()")

                    End If

            End Select

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

    Public Function GenerateItemRunningNo(ByVal ItemTypeCode As String, ByVal ItemGroup As String, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As String

        Dim NewRunningNo As String = ""
        Dim LastNo As Integer
        Dim RunningNo As Integer
        Dim DtRunningNo As New DataTable

        Try
            Select Case ItemGroup
                Case "SVC"

                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT ItemTypeCode, LastNo ")
                        .Append("FROM samc_runningno_svc ")
                        .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

                    If DtRunningNo.Rows.Count > 0 Then
                        LastNo = CInt(DtRunningNo.Rows(0).Item("LastNo"))
                        RunningNo = LastNo + 1

                        If RunningNo.ToString.Length <= 3 Then
                            NewRunningNo = ItemTypeCode & RunningNo.ToString.PadLeft(3, "0"c)
                        End If

                        'Update LastNo
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno_svc ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()
                    End If

                Case "PRD"

                    Sb = New StringBuilder
                    With Sb
                        .Append("SELECT ItemTypeCode, LastNo ")
                        .Append("FROM samc_runningno_prd ")
                        .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
                    End With

                    Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtRunningNo)

                    If DtRunningNo.Rows.Count > 0 Then
                        LastNo = CInt(DtRunningNo.Rows(0).Item("LastNo"))
                        RunningNo = LastNo + 1

                        If RunningNo.ToString.Length <= 4 Then
                            NewRunningNo = ItemTypeCode & RunningNo.ToString.PadLeft(4, "0"c)
                        End If

                        'Update LastNo
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno_prd ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE ItemTypeCode = '" & ItemTypeCode & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()
                    End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ModMain.GenerateItemRunningNo()")
        End Try

        Return NewRunningNo

    End Function

End Module
