Public Class FrmMDI

    Private Sub ClientRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientRegistrationToolStripMenuItem.Click
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

    Private Sub PetToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        'Dim frm As New frmAnimalRecords()
        ''Static intCount As Integer

        'For Each f As Form In Application.OpenForms
        '    If TypeOf f Is frmAnimalRecords Then
        '        f.Activate()
        '        Exit Sub
        '    End If
        'Next

        'frm = New frmAnimalRecords With {
        '    .MdiParent = Me
        '}

        'frm.Show()

    End Sub

    Private Sub MnuAppointment_Click(sender As Object, e As EventArgs) Handles mnuAppointment.Click

        Dim frm As New FrmAppointmentRecords()
        'Static intCount As Integer

        For Each f As Form In Application.OpenForms
            If TypeOf f Is FrmAppointmentRecords Then
                f.Activate()
                Exit Sub
            End If
        Next

        frm = New FrmAppointmentRecords With {
            .MdiParent = Me
        }
        frm.Show()

        '' Increment the caption counter.
        'intCount += 1

        '' Set the caption to be unique.
        'frm.Text = frm.Text & " " & intCount.ToString()

    End Sub

    'Private Sub WardExaminationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WardExaminationToolStripMenuItem.Click

    '    Dim frm As New frmWardExamination()
    '    'Static intCount As Integer

    '    For Each f As Form In Application.OpenForms
    '        If TypeOf f Is frmWardExamination Then
    '            f.Activate()
    '            Exit Sub
    '        End If
    '    Next

    '    frm = New frmWardExamination With {
    '        .MdiParent = Me
    '    }
    '    frm.Show()

    'End Sub

    Private Sub FrmMDI_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing

        Me.Dispose()
        FrmLogin.Dispose()
        FrmLogin.Close()

    End Sub

    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "SAMC Animals Centre Vet Management System " & SOFTWARE_VERSION & " - " & CURR_USER
        'Dim FrmMDI As New FrmMDI With {
        '        .Text = "SAMC Animals Centre Vet Management System" & SOFTWARE_VERSION & " - USER: " & CURR_USER
        '}
        ''.Text = "SAMC Animals Centre Vet Sys - " & "Current User: " & CURR_USER,
    End Sub

    Private Sub EmployeeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeUserToolStripMenuItem.Click
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

End Class
