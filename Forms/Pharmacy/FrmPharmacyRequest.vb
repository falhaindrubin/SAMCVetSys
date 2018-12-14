Public Class FrmPharmacyRequest

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

    Private _RequestID As String
    Public Property RequestID As String
        Get
            Return _RequestID
        End Get
        Set(value As String)
            _RequestID = value
        End Set
    End Property

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
        End Set
    End Property

    Private _ItemTypeDescription As String
    Public Property ItemTypeDescription As String
        Get
            Return _ItemTypeDescription
        End Get
        Set(value As String)
            _ItemTypeDescription = value
        End Set
    End Property

    Private _ItemTypeCode As String
    Public Property ItemTypeCode As String
        Get
            Return _ItemTypeCode
        End Get
        Set(value As String)
            _ItemTypeCode = value
        End Set
    End Property

#End Region

    Private Sub FrmPharmacyRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateForm()
    End Sub

    Private Sub PopulateForm()

        Try
            Dim DtPharmacyRq As New DataTable
            Dim DtPharmacyRqDetail As New DataTable
            Dim ClsPharmacy As New ClsPharmacy

            If RequestID <> "" Then

                With ClsPharmacy

                    .RequestID = RequestID
                    .VisitID = VisitID

                    DtPharmacyRq = .GetPharmacyRequest(ClsPharmacy)
                    DtPharmacyRqDetail = .GetPharmacyRequestDetail(ClsPharmacy)

                    If DtPharmacyRq.Rows.Count > 0 Then

                        'Request information
                        TxtVet.Tag = DtPharmacyRq.Rows(0).Item("RqEmpID")
                        TxtVet.Text = DtPharmacyRq.Rows(0).Item("RqEmpName")
                        TxtRequestDate.Text = IIf(DtPharmacyRq.Rows(0).Item("RequestDate") = Nothing, "", CDate(DtPharmacyRq.Rows(0).Item("RequestDate")))

                        'Pharmacy information
                        TxtInCharge.Tag = IIf(DtPharmacyRq.Rows(0).Item("PhEmpID") <> "", DtPharmacyRq.Rows(0).Item("PhEmpID"), CURR_EMPLOYEE_ID)
                        TxtInCharge.Text = IIf(DtPharmacyRq.Rows(0).Item("PhEmpName") <> "", DtPharmacyRq.Rows(0).Item("PhEmpName"), CURR_EMPLOYEE_NAME)
                        TxtApprovalDate.Text = IIf(DtPharmacyRq.Rows(0).Item("ApprovalDate") = Nothing, "", CDate(DtPharmacyRq.Rows(0).Item("ApprovalDate")))
                        CbIsCompleted.Checked = IIf(DtPharmacyRq.Rows(0).Item("IsCompleted") = "1", True, False)

                    End If

                    If DtPharmacyRqDetail.Rows.Count > 0 Then

                        For i As Integer = 0 To DtPharmacyRqDetail.Rows.Count - 1

                            With DgvPharmacyRequest
                                .Rows.Add()
                                .Rows(i).Cells("RqRowNo").Value = DtPharmacyRqDetail.Rows(i).Item("RowNo")
                                .Rows(i).Cells("RqItemCode").Value = DtPharmacyRqDetail.Rows(i).Item("ItemCode")
                                .Rows(i).Cells("RqItemDescription").Value = DtPharmacyRqDetail.Rows(i).Item("ItemDescription")
                                .Rows(i).Cells("RqItemGroup").Value = DtPharmacyRqDetail.Rows(i).Item("ItemGroup")
                                .Rows(i).Cells("RqItemTypeCode").Value = DtPharmacyRqDetail.Rows(i).Item("ItemTypeCode")
                                .Rows(i).Cells("RqItemTypeDescription").Value = DtPharmacyRqDetail.Rows(i).Item("ItemTypeDescription")
                                .Rows(i).Cells("RqPrescription").Value = DtPharmacyRqDetail.Rows(i).Item("Prescription")
                                .Rows(i).Cells("RqNotes").Value = DtPharmacyRqDetail.Rows(i).Item("Notes")
                                .Rows(i).Cells("RqUnitPrice").Value = DtPharmacyRqDetail.Rows(i).Item("UnitPrice")
                                .Rows(i).Cells("RqQuantity").Value = DtPharmacyRqDetail.Rows(i).Item("Quantity")
                                .Rows(i).Cells("RqTotalPrice").Value = DtPharmacyRqDetail.Rows(i).Item("TotalPrice")
                            End With

                        Next

                    End If

                End With

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Function SaveRequestToDb() As Boolean

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            Dim ClsPharmacy As New ClsPharmacy
            Dim ClsPharmacyDetail As New ClsPharmacyDetail

            With ClsPharmacy

            End With

            If DgvPharmacyRequest.Rows.Count > 0 Then

                For i As Integer = 0 To DgvPharmacyRequest.Rows.Count - 1

                    With ClsPharmacyDetail

                    End With

                Next

            End If

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click

        With FrmSearchItem
            .ShowDialog()
            TxtItem.Tag = .ItemCode
            TxtItem.Text = .ItemDescription
            TxtUnitPrice.Text = .UnitPrice
            TxtTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not SaveRequestToDb() Then Exit Sub
    End Sub

End Class