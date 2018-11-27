Public Class FrmMDI

    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "SAMC Veterinary System" & SOFTWARE_VERSION & " - " & CURR_USER
    End Sub

    Private Sub FrmMDI_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Me.Dispose()
        FrmLogin.Dispose()
        FrmLogin.Close()
    End Sub

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

    Private Sub MnuAppointment_Click(sender As Object, e As EventArgs)

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


    Private Sub EmployeeUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeUserToolStripMenuItem.Click
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

    Private Sub ConsultationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultationToolStripMenuItem.Click
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

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub ProductsServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsServicesToolStripMenuItem.Click
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

    Private Sub AppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentToolStripMenuItem.Click

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

    Private Sub TreatmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreatmentToolStripMenuItem.Click
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

    Private Sub WardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WardToolStripMenuItem.Click

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

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click
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

    Private Sub SurgeryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurgeryToolStripMenuItem.Click
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

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

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

    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click

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

End Class
