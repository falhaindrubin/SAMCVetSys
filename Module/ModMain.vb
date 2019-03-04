'Imports System.Data.Odbc
'Imports System.Globalization
Imports System.IO
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
    Public CURR_EMPLOYEE_NAME As String
    Public CURR_EMPLOYEE_ID As String
    Public CURR_EMPLOYEE_POS As String

    Public FORM_NAME As String
    Public SOFTWARE_VERSION As String

    Public FORM_SOURCE As String
    'TREATMENT, WARD-TREATMENT, WARD-DISCHARGE, 

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
            PWD = "root" '015015dr

            DbConn.ConnectionString =
                "DRIVER={MySQL ODBC 8.0 UNICODE Driver};" &
                "SERVER=" & SERVER & ";" &
                "PORT=" & PORT & ";" &
                "DATABASE=" & DATABASE & ";" &
                "USER=" & UID & ";" &
                "PASSWORD=" & PWD & ";"

            DbConn.Open()

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

                'Generate EmployeeID
                Case "EMP"

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

                        If RunningNo.ToString.Length < 5 Then
                            NewRunningNo = RunningNo.ToString.PadLeft(5, "0"c) 'DtRunningNo.Rows(0).Item("Prefix2") & "-" & RunningNo.ToString.PadLeft(5, "0"c)
                        Else
                            NewRunningNo = RunningNo.ToString 'DtRunningNo.Rows(0).Item("Prefix2") & "-" & RunningNo.ToString
                        End If

                        'Update EmployeeID
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    End If

                Case "AP"

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

                        If RunningNo.ToString.Length < 5 Then
                            NewRunningNo = Prefix & RunningNo.ToString.PadLeft(8, "0"c)
                        Else
                            NewRunningNo = Prefix & RunningNo.ToString
                        End If

                        'Update EmployeeID
                        Sb = New StringBuilder
                        With Sb
                            .Append("UPDATE samc_runningno ")
                            .Append("SET LastNo = '" & RunningNo & "' ")
                            .Append("WHERE Prefix = '" & Prefix & "' ")
                        End With

                        Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
                        Cmd.ExecuteNonQuery()

                    End If

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

                Case "RQ"
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

                        'Update RequestID
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

            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_runningno ")
                .Append("SET LastNo = '0' ")
                .Append("WHERE Prefix = '" & Prefix & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Cmd.ExecuteNonQuery()

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

    Public Sub PopulateYear(StartDate As Date, EndDate As Date, ByRef CmbYear As ComboBox)

        Try
            While StartDate <= EndDate
                CmbYear.Items.Add(EndDate.Year.ToString())
                EndDate = EndDate.AddYears(-1)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Modmain.PopulateYear()")
        End Try

    End Sub

    Public Enum Month
        January = 1
        February = 2
        March = 3
        April = 4
        May = 5
        June = 6
        July = 7
        August = 8
        September = 9
        October = 10
        November = 11
        December = 12
    End Enum

    Public Enum IsEmpActive
        Active = 1
        Inactive = 0
    End Enum

    Public Function TerminateExternalExe() As Boolean

        Try
            Dim StrReportTxt As String = My.Application.Info.DirectoryPath & "\Reports.txt"

            If System.IO.File.Exists(StrReportTxt) Then

                'The file exists
                Dim PsList() As Process
                Dim StrReportExe As String = File.ReadAllText(StrReportTxt)
                Dim StrReportExeExtracted As String() = StrReportExe.Split(";")
                Dim ReportList As New List(Of String)
                Dim la, lb As String

                For Each a In StrReportExeExtracted
                    la = a.Replace(Environment.NewLine, "")
                    lb = la.Replace(".exe", "")
                    ReportList.Add(lb)
                Next

                PsList = Process.GetProcesses()
                For i As Integer = 0 To ReportList.Count - 1
                    Dim ExeName As String = ReportList(i).ToString
                    For Each p As Process In PsList

                        If (p.ProcessName = ExeName) Then
                            'MsgBox(p.ProcessName)
                            p.Kill()
                        End If

                    Next p

                Next

            Else
                'the file doesn't exist

            End If

            ' TODO: Close the application safely.
            If DbConn.State = ConnectionState.Open Then
                DbConn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ModMain.TerminateExternalExe()")
            Return False
        End Try

        Return True

    End Function



End Module
