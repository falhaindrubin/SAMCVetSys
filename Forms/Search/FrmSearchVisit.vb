Public Class FrmSearchVisit
#Region "FormProperty"
    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private _CustomerName As String
    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
        End Set
    End Property

    Private _PetID As String
    Public Property PetID As String
        Get
            Return _PetID
        End Get
        Set(value As String)
            _PetID = value
        End Set
    End Property

    Private _PetName As String
    Public Property PetName As String
        Get
            Return _PetName
        End Get
        Set(value As String)
            _PetName = value
        End Set
    End Property

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private _Source As String
    Public Property Source As String
        Get
            Return _Source
        End Get
        Set(value As String)
            _Source = value
        End Set
    End Property
#End Region

    Private Sub FrmSearchVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateVisitListing()
    End Sub

    Private Sub PopulateVisitListing()

        Dim DtVisit As New DataTable
        Dim ClsVisit As New ClsVisit

        Try
            Select Case Source
                Case "TREATMENT"
                    If Source = "TREATMENT" Then
                        If UserCommand = "ADD_NEW_TREATMENT" Then
                            CbNotAssigned.Checked = True
                            With ClsVisit
                                .IsVisitCompleted = "0"
                                .IsOngoingTreatment = "0"
                            End With
                            DtVisit = ClsVisit.GetUnassignedVisitListing(ClsVisit)
                        End If
                    Else
                        DtVisit = ClsVisit.GetVisitListing(ClsVisit)
                    End If

                    If DtVisit.Rows.Count > 0 Then
                        DgvVisit.DataSource = DtVisit
                        DgvVisit.Show()
                    Else
                        DgvVisit.Rows.Clear()
                        DgvVisit.Show()
                    End If

                Case "WARD"
                    If Source = "WARD" Then
                        If UserCommand = "ADD_NEW_WARD" Then
                            CbIsWarded.Checked = True
                            With ClsVisit
                                .IsAdmittedToWard = "0"
                                .IsOngoingTreatment = "1"
                                .IsVisitCompleted = "0"
                            End With
                            DtVisit = ClsVisit.GetWardedVisitListing(ClsVisit)
                        End If
                    Else
                        DtVisit = ClsVisit.GetVisitListing(ClsVisit)
                    End If

                    If DtVisit.Rows.Count > 0 Then
                        DgvVisit.DataSource = DtVisit
                        DgvVisit.Show()
                    Else
                        DgvVisit.Rows.Clear()
                        DgvVisit.Show()
                    End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateVisitListing()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DgvVisit_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVisit.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    VisitID = DgvVisit.Rows(e.RowIndex).Cells("VisitID").Value
                    CustomerID = DgvVisit.Rows(e.RowIndex).Cells("CustomerID").Value
                    CustomerName = DgvVisit.Rows(e.RowIndex).Cells("CustomerName").Value
                    PetID = DgvVisit.Rows(e.RowIndex).Cells("PetID").Value
                    PetName = DgvVisit.Rows(e.RowIndex).Cells("PetName").Value
                    UserCommand = "POPULATE_CUSTOMER_INFO"
                End If
            End If

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvVisit_CellDoubleClick()")
        End Try

    End Sub

End Class