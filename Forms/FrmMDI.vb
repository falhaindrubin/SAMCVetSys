Imports System.IO

Public Class FrmMDI

    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "SAMC Veterinary Management System " & SOFTWARE_VERSION & " - " & CURR_USER
        'TimerMain.Interval = 1000
        TimerMain.Start()

        AddHandler System.Windows.Forms.Application.Idle, AddressOf Application_Idle
        ' TODO: Create the 10-minute timer.
    End Sub

    Private Sub FrmMDI_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        TerminateExternalExe()
        Me.Dispose()
        FrmLogin.Dispose()
        FrmLogin.Close()
    End Sub

#Region "Application_Idle"

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        ' TODO: Restart the 10-minute timer.
        TimerMain.Stop()
        TimerMain.Start()
    End Sub

    'This assumes your TenMinuteTimer Object has an Expire Event.  Do what works For you instead.
    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick

        'Static s As Integer

        's += 1
        'If s > 60 Then 'Close after one minute

        '    TimerMain.Stop()
        '    TimerMain.Enabled = False
        '    RemoveHandler Application.Idle, AddressOf Me.Application_Idle
        '    MsgBox("Time's out! Please login to continue.")

        '    ' TODO: Close the application safely.
        '    For Each frm As Form In Me.MdiChildren
        '        frm.Close()
        '    Next

        '    TerminateExternalExe()

        '    Me.Dispose()
        '    Me.Close()

        '    FrmLogin.Show()

        'End If

    End Sub

#End Region

#Region "TerminatExternalExe"

    'Private Function TerminateExternalExe() As Boolean

    '    Try
    '        Dim StrReportTxt As String = My.Application.Info.DirectoryPath & "\Reports.txt"

    '        If System.IO.File.Exists(StrReportTxt) Then

    '            'The file exists
    '            Dim PsList() As Process
    '            Dim StrReportExe As String = File.ReadAllText(StrReportTxt)
    '            Dim StrReportExeExtracted As String() = StrReportExe.Split(";")
    '            Dim ReportList As New List(Of String)
    '            Dim la, lb As String

    '            For Each a In StrReportExeExtracted
    '                la = a.Replace(Environment.NewLine, "")
    '                lb = la.Replace(".exe", "")
    '                ReportList.Add(lb)
    '            Next

    '            PsList = Process.GetProcesses()
    '            For i As Integer = 0 To ReportList.Count - 1
    '                Dim ExeName As String = ReportList(i).ToString
    '                For Each p As Process In PsList

    '                    If (p.ProcessName = ExeName) Then
    '                        'MsgBox(p.ProcessName)
    '                        p.Kill()
    '                    End If

    '                Next p

    '            Next

    '        Else
    '            'the file doesn't exist

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmMDI.TerminateExternalExe()")
    '        Return False
    '    End Try

    '    Return True

    'End Function

#End Region

#Region "Customer"

    Private Sub MnuRegister_Click(sender As Object, e As EventArgs) Handles MnuRegister.Click

        Dim frm As New FrmCustomerRecords
        'Static intCount As Integer

        For Each f As Form In Application.OpenForms
            If TypeOf f Is FrmCustomerRecords Then
                f.Activate()
                Exit Sub
            End If
        Next

        '' Increment the caption counter.
        'intCount += 1

        '' Set the caption to be unique.
        'frm.Text = frm.Text & " " & intCount.ToString()

        frm = New FrmCustomerRecords With {
            .MdiParent = Me
        }
        frm.Show()
    End Sub

    Private Sub MnuVisit_Click(sender As Object, e As EventArgs) Handles MnuVisit.Click
        Try
            Dim Frm As New FrmVisitRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmVisitRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmVisitRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MnuAppointment_Click(sender As Object, e As EventArgs) Handles MnuAppointment.Click

        Dim Frm As New FrmAppointmentRecords
        'Static intCount As Integer

        For Each F As Form In Application.OpenForms
            If TypeOf F Is FrmAppointmentRecords Then
                F.Activate()
                Exit Sub
            End If
        Next

        '' Increment the caption counter.
        'intCount += 1

        '' Set the caption to be unique.
        'frm.Text = frm.Text & " " & intCount.ToString()

        Frm = New FrmAppointmentRecords With {
            .MdiParent = Me
        }
        Frm.Show()

    End Sub

#End Region

#Region "Treatment"

    Private Sub MnuTreatment_Click(sender As Object, e As EventArgs) Handles MnuTreatment.Click
        Try
            Dim Frm As New FrmTreatmentRecords
            'Static intCount As Integer

            For Each F As Form In Application.OpenForms
                If TypeOf F Is FrmTreatmentRecords Then
                    F.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmTreatmentRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Surgery"

    Private Sub MnuSurgery_Click(sender As Object, e As EventArgs) Handles MnuSurgery.Click
        Try
            Dim Frm As New FrmSurgeryRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmSurgeryRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmSurgeryRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Ward"

    Private Sub MnuWard_Click(sender As Object, e As EventArgs) Handles MnuWard.Click

        Try
            Dim Frm As New FrmWardRecords
            'Static intCount As Integer

            For Each F As Form In Application.OpenForms
                If TypeOf F Is FrmWardRecords Then
                    F.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmWardRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Pharmacy"

    Private Sub MnuPharmacy_Click(sender As Object, e As EventArgs) Handles MnuPharmacy.Click

        Try
            Dim Frm As New FrmPharmacyRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmPharmacyRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmPharmacyRecords With {
                .MdiParent = Me
            }
            Frm.Show()

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Billing"

    Private Sub MnuBilling_Click(sender As Object, e As EventArgs) Handles MnuBilling.Click
        Try
            Dim Frm As New FrmPaymentRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmPaymentRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmPaymentRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Management"

    Private Sub MnuEmployee_Click(sender As Object, e As EventArgs) Handles MnuEmployee.Click
        Try
            Dim Frm As New FrmEmployeeRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmEmployeeRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmEmployeeRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MnuUser_Click(sender As Object, e As EventArgs) Handles MnuUser.Click

        Try
            Dim Frm As New FrmUserRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmUserRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmUserRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MnuRoles_Click(sender As Object, e As EventArgs) Handles MnuRoles.Click

        Try
            Dim Frm As New FrmRoleRecords()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmRoleRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmRoleRecords With {
                .MdiParent = Me
            }
            Frm.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MnuProductServices_Click(sender As Object, e As EventArgs) Handles MnuProductServices.Click
        Try
            Dim Frm As New FrmItemRecords()
            'Static intCount As Integer
            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmItemRecords Then
                    f.Activate()
                    Exit Sub
                End If
            Next
            Frm = New FrmItemRecords With {
                .MdiParent = Me
            }
            Frm.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MnuManagementSurgery_Click(sender As Object, e As EventArgs) Handles MnuManagementSurgery.Click

        Try
            Dim Frm As New FrmSurgeryManagement()
            'Static intCount As Integer

            For Each f As Form In Application.OpenForms
                If TypeOf f Is FrmSurgeryManagement Then
                    f.Activate()
                    Exit Sub
                End If
            Next

            Frm = New FrmSurgeryManagement With {
                .MdiParent = Me
            }
            Frm.Show()

        Catch ex As Exception

        End Try

    End Sub

#End Region

    'Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
    '    Throw New NotImplementedException()
    'End Function

End Class
