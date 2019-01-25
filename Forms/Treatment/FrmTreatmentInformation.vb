Imports SAMCVetSys.ModUtility

Public Class FrmTreatmentInformation

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

    Private Sub FrmTreatmentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        FORM_SOURCE = "TREATMENT"
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateTemperament()
        PopulateBodyScore()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateForm(UserCommand As String)

        Dim DtVisit As New DataTable
        Dim DtPEF As New DataTable
        Dim DtDiagnosis As New DataTable
        Dim DtTreatment As New DataTable
        Dim DtInvoice As New DataTable
        Dim ClsVisit As New ClsVisit
        Dim ClsPEFindings As New ClsPEFindings
        Dim ClsDiagnosis As New ClsDiagnosis
        Dim ClsTreatmentDetail As New ClsTreatmentDetail
        Dim ClsTreatment As New ClsTreatment
        Dim ClsBill As New ClsBill

        Try
            'Get pet info from VisitID
            If VisitID <> "" Then

                'Get invoice info
                ClsBill.VisitID = VisitID
                DtInvoice = ClsBill.GetBillHeader(ClsBill)
                If DtInvoice.Rows.Count > 0 Then
                    LblInvoiceNo.Text = CStr(DtInvoice.Rows(0).Item("InvoiceNo"))
                    'BtnBillPayment.Text = CStr(DtInvoice.Rows(0).Item("InvoiceNo"))
                    'BtnBillPayment.Tag = CStr(DtInvoice.Rows(0).Item("InvoiceNo"))
                End If

                'Get Visit
                ClsVisit.VisitID = VisitID
                DtVisit = ClsVisit.GetVisitDetail(ClsVisit)
                If DtVisit.Rows.Count > 0 Then
                    TxtVisitID.Text = DtVisit.Rows(0).Item("VisitID")
                    TxtCustomerName.Tag = DtVisit.Rows(0).Item("CustomerID")
                    TxtCustomerName.Text = DtVisit.Rows(0).Item("CustomerName")
                    TxtPetName.Tag = DtVisit.Rows(0).Item("PetID")
                    TxtPetName.Text = DtVisit.Rows(0).Item("PetName")
                End If

                'Get Diagnosis
                ClsDiagnosis.VisitID = VisitID
                DtDiagnosis = ClsDiagnosis.GetDiagnosisDetail(ClsDiagnosis)
                If DtDiagnosis.Rows.Count > 0 Then
                    For i As Integer = 0 To DtDiagnosis.Rows.Count - 1
                        With DgvSelectedTest
                            .Rows.Add()
                            .Rows(i).Cells("TestRowNo").Value = DtDiagnosis.Rows(i).Item("RowNo")
                            .Rows(i).Cells("TestItemCode").Value = DtDiagnosis.Rows(i).Item("ItemCode")
                            .Rows(i).Cells("TestItemDescription").Value = DtDiagnosis.Rows(i).Item("ItemDescription")
                            .Rows(i).Cells("TestUnitPrice").Value = DtDiagnosis.Rows(i).Item("UnitPrice")
                            .Rows(i).Cells("TestQuantity").Value = DtDiagnosis.Rows(i).Item("Quantity")
                            .Rows(i).Cells("TestTotalPrice").Value = DtDiagnosis.Rows(i).Item("TotalPrice")
                            .Rows(i).Cells("TestItemGroup").Value = DtDiagnosis.Rows(i).Item("ItemGroup")
                            .Rows(i).Cells("TestItemTypeCode").Value = DtDiagnosis.Rows(i).Item("ItemTypeCode")
                            .Rows(i).Cells("TestItemTypeDescription").Value = DtDiagnosis.Rows(i).Item("ItemTypeDescription")
                        End With
                    Next

                    TxtDiagnosis.Text = CStr(DtDiagnosis.Rows(0).Item("Diagnosis"))

                    TxtDxCreatedBy.Text = IIf(DtDiagnosis.Rows.Count > 0, DtDiagnosis.Rows(0).Item("CreatedBy"), "")
                    TxtDxDateCreated.Text = IIf(DtDiagnosis.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("DateCreated")), "")
                    TxtDxModifiedBy.Text = IIf(DtDiagnosis.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("ModifiedBy")), "")
                    TxtDxDateModified.Text = IIf(DtDiagnosis.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("DateModified")), "")

                End If

                'Get Treatment
                ClsTreatment.VisitID = VisitID
                DtTreatment = ClsTreatment.GetTreatmentDetail(ClsTreatment)
                If DtTreatment.Rows.Count > 0 Then
                    For i As Integer = 0 To DtTreatment.Rows.Count - 1
                        With DgvSelectedTreatment
                            .Rows.Add()
                            .Rows(i).Cells("TreatmentRowNo").Value = DtTreatment.Rows(i).Item("RowNo")
                            .Rows(i).Cells("TreatmentItemCode").Value = DtTreatment.Rows(i).Item("ItemCode")
                            .Rows(i).Cells("TreatmentItemDescription").Value = DtTreatment.Rows(i).Item("ItemDescription")
                            .Rows(i).Cells("TreatmentPrescription").Value = DtTreatment.Rows(i).Item("Prescription")
                            .Rows(i).Cells("TreatmentNotes").Value = DtTreatment.Rows(i).Item("Notes")
                            .Rows(i).Cells("TreatmentUnitPrice").Value = DtTreatment.Rows(i).Item("UnitPrice")
                            .Rows(i).Cells("TreatmentQuantity").Value = DtTreatment.Rows(i).Item("Quantity")
                            .Rows(i).Cells("TreatmentTotalPrice").Value = DtTreatment.Rows(i).Item("TotalPrice")
                            .Rows(i).Cells("TreatmentItemGroup").Value = DtTreatment.Rows(i).Item("ItemGroup")
                            .Rows(i).Cells("TreatmentItemTypeCode").Value = DtTreatment.Rows(i).Item("ItemTypeCode")
                            .Rows(i).Cells("TreatmentItemTypeDescription").Value = DtTreatment.Rows(i).Item("ItemTypeDescription")
                            .Rows(i).Cells("TreatmentPhRequestID").Value = DtTreatment.Rows(i).Item("PhRequestID")
                            .Rows(i).Cells("IsDb").Value = "1"
                        End With
                    Next

                    TxtDxCreatedBy.Text = IIf(DtTreatment.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("CreatedBy")), "")
                    TxtDxDateCreated.Text = IIf(DtTreatment.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("DateCreated")), "")
                    TxtDxModifiedBy.Text = IIf(DtTreatment.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("ModifiedBy")), "")
                    TxtDxDateModified.Text = IIf(DtTreatment.Rows.Count > 0, CStrNull(DtDiagnosis.Rows(0).Item("DateModified")), "")

                End If

            Else
                TxtVisitID.Text = VisitID
                TxtCustomerName.Tag = CustomerID
                TxtCustomerName.Text = CustomerName
                TxtPetName.Tag = PetID
                TxtPetName.Text = PetName

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub PopulateTemperament()

        Dim DtTemperament As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtTemperament = ClsPet.GetPetTemperament(ClsPet)
            If DtTemperament.Rows.Count > 0 Then

                For i As Integer = 0 To DtTemperament.Rows.Count - 1
                    CmbSource.Add(DtTemperament.Rows(i).Item("TemperamentCode"), DtTemperament.Rows(i).Item("TemperamentCode") & " - " & DtTemperament.Rows(i).Item("TemperamentName"))
                Next

                'If CmbTemperament.Items.Count > 0 Then
                '    CmbTemperament.DataSource = Nothing
                '    CmbTemperament.Items.Clear()
                'End If

                'CmbTemperament.DataSource = New BindingSource(CmbSource, Nothing)
                'CmbTemperament.DisplayMember = "Value"
                'CmbTemperament.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateTemperament()")
        End Try

    End Sub

    Private Sub PopulateBodyScore()

        Dim DtBodyScore As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtBodyScore = ClsPet.GetPetBodyScore(ClsPet)
            If DtBodyScore.Rows.Count > 0 Then

                For i As Integer = 0 To DtBodyScore.Rows.Count - 1
                    CmbSource.Add(DtBodyScore.Rows(i).Item("BodyScoreCode"), DtBodyScore.Rows(i).Item("BodyScoreCode") & " - " & DtBodyScore.Rows(i).Item("BodyScoreName"))
                Next

                'If CmbBodyScore.Items.Count > 0 Then
                '    CmbBodyScore.DataSource = Nothing
                '    CmbBodyScore.Items.Clear()
                'End If

                'CmbBodyScore.DataSource = New BindingSource(CmbSource, Nothing)
                'CmbBodyScore.DisplayMember = "Value"
                'CmbBodyScore.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateBodyScore()")
        End Try

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            With FrmSearchVisit
                .Source = "TREATMENT"
                .UserCommand = "ADD_NEW_TREATMENT"
                .ShowDialog()
                VisitID = .VisitID
                CustomerID = .CustomerID
                CustomerName = .CustomerName
                PetID = .PetID
                PetName = .PetName
                UserCommand = .UserCommand
            End With

            PopulateForm(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearch_Click")
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnBillPayment_Click(sender As Object, e As EventArgs) Handles BtnBillPayment.Click
        With FrmPaymentInformation
            .InvoiceNo = BtnBillPayment.Tag
            .UserCommand = "SHOW_BILLING_INFO"
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnSearchTestItem_Click(sender As Object, e As EventArgs) Handles BtnSearchTestItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTestItem.Tag = .ItemCode
            TxtTestItem.Text = .ItemDescription
            TxtTestUnitPrice.Text = .UnitPrice
            TxtTestTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTestQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTreatmentItem.Tag = .ItemCode
            TxtTreatmentItem.Text = .ItemDescription
            TxtTreatmentUnitPrice.Text = .UnitPrice
            TxtTreatmentTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTreatmentQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnAddTest_Click(sender As Object, e As EventArgs) Handles BtnAddTest.Click
        AddTest()
    End Sub

    Private Sub AddTest()

        Dim DtTest As New DataTable

        Try
            'Check if user trying to insert empty item
            If Not CheckFields("DX") Then Exit Sub

            DtTest = InitSelectedItemDt()
            If DgvSelectedTest.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTest.NewRow

                    DgvRow("RowNo") = DgvSelectedTest.Rows(i).Cells("TestRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
                    DgvRow("Quantity") = DgvSelectedTest.Rows(i).Cells("TestQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedTest.Rows(i).Cells("TestUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedTest.Rows(i).Cells("TestTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedTest.Rows(i).Cells("TestItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedTest.Rows(i).Cells("TestItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedTest.Rows(i).Cells("TestItemTypeDescription").Value

                    DtTest.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtTest.NewRow

            Row("RowNo") = IIf(DtTest.Rows.Count = 0, 1, DtTest.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtTestItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtTestItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtTestUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTestQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTestTotalPrice.Text) * CDec(TxtTestQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeCode") = ItemTypeCode
            Row("ItemTypeDescription") = ItemTypeDescription

            DtTest.Rows.Add(Row)

            If DtTest.Rows.Count > 0 Then

                DgvSelectedTest.Rows.Clear()

                For i As Integer = 0 To DtTest.Rows.Count - 1
                    With DgvSelectedTest
                        .Rows.Add()
                        .Rows(i).Cells("TestRowNo").Value = DtTest.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TestItemCode").Value = DtTest.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TestItemDescription").Value = DtTest.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("TestUnitPrice").Value = DtTest.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("TestQuantity").Value = DtTest.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TestTotalPrice").Value = DtTest.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("TestItemGroup").Value = DtTest.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("TestItemTypeCode").Value = DtTest.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("TestItemTypeDescription").Value = DtTest.Rows(i).Item("ItemTypeDescription")
                    End With
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTest()")
        End Try

    End Sub

    Private Sub BtnTreatmentItem_Click(sender As Object, e As EventArgs) Handles BtnAddTreatment.Click
        If BtnAddTreatment.Tag = "" Then
            AddTreatment()
        ElseIf BtnAddTreatment.Tag = "UPDATE" Then
            UpdateTreatment()
        End If

    End Sub

    Private Sub UpdateTreatment()

        Try
            Dim RowIndex As Integer = CInt(LblRowNo.Text)

            With DgvSelectedTreatment
                .Rows(RowIndex).Cells("TreatmentItemCode").Value = Trim(TxtTreatmentItem.Tag)
                .Rows(RowIndex).Cells("TreatmentItemDescription").Value = Trim(TxtTreatmentItem.Text)
                .Rows(RowIndex).Cells("TreatmentPrescription").Value = Trim(TxtPrescription.Text)
                .Rows(RowIndex).Cells("TreatmentNotes").Value = Trim(TxtNotes.Text)
                .Rows(RowIndex).Cells("TreatmentUnitPrice").Value = Trim(TxtTreatmentUnitPrice.Text)
                .Rows(RowIndex).Cells("TreatmentQuantity").Value = Trim(TxtTreatmentQuantity.Text)
                .Rows(RowIndex).Cells("TreatmentTotalPrice").Value = Trim(TxtTreatmentTotalPrice.Text)
            End With

            TxtTreatmentItem.Text = ""
            TxtTreatmentItem.Tag = ""
            TxtPrescription.Text = ""
            TxtNotes.Text = ""
            TxtTreatmentUnitPrice.Text = ""
            TxtTreatmentQuantity.Text = ""
            TxtTreatmentTotalPrice.Text = ""

            BtnAddTreatment.Text = "Add Item"
            BtnAddTreatment.Tag = ""

            MsgBox("Selected item has been updated!", MsgBoxStyle.Information, "Item Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateTreatment()")
        End Try

    End Sub

    Private Sub AddTreatment()

        Dim DtTreatment As New DataTable

        Try
            'Check user input; fields validity
            If Not CheckFields("TX") Then Exit Sub

            DtTreatment = InitSelectedItemDt()
            If DgvSelectedTreatment.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTreatment.NewRow

                    DgvRow("RowNo") = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                    DgvRow("PhRequestID") = DgvSelectedTreatment.Rows(i).Cells("TreatmentPhRequestID").Value
                    DgvRow("ItemCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                    DgvRow("Prescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value
                    DgvRow("Notes") = DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value
                    DgvRow("Quantity") = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                    DgvRow("IsDb") = DgvSelectedTreatment.Rows(i).Cells("IsDb").Value

                    DtTreatment.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtTreatment.NewRow

            Row("RowNo") = IIf(DtTreatment.Rows.Count = 0, 1, DtTreatment.Rows.Count + 1)
            Row("PhRequestID") = DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value
            Row("ItemCode") = UCase(Trim(TxtTreatmentItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtTreatmentItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtTreatmentUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTreatmentQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTreatmentTotalPrice.Text) * CDec(TxtTreatmentQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode
            Row("Prescription") = Trim(TxtPrescription.Text)
            Row("Notes") = Trim(TxtNotes.Text)
            Row("IsDb") = "0"

            DtTreatment.Rows.Add(Row)

            If DtTreatment.Rows.Count > 0 Then

                DgvSelectedTreatment.Rows.Clear()

                For i As Integer = 0 To DtTreatment.Rows.Count - 1
                    With DgvSelectedTreatment
                        .Rows.Add()
                        .Rows(i).Cells("TreatmentRowNo").Value = DtTreatment.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TreatmentPhRequestID").Value = DtTreatment.Rows(i).Item("PhRequestID")
                        .Rows(i).Cells("TreatmentItemCode").Value = DtTreatment.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TreatmentItemDescription").Value = DtTreatment.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("TreatmentUnitPrice").Value = DtTreatment.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("TreatmentQuantity").Value = DtTreatment.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TreatmentTotalPrice").Value = DtTreatment.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("TreatmentItemGroup").Value = DtTreatment.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("TreatmentItemTypeCode").Value = DtTreatment.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("TreatmentItemTypeDescription").Value = DtTreatment.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("TreatmentPrescription").Value = DtTreatment.Rows(i).Item("Prescription")
                        .Rows(i).Cells("TreatmentNotes").Value = DtTreatment.Rows(i).Item("Notes")
                        .Rows(i).Cells("IsDb").Value = DtTreatment.Rows(i).Item("IsDb")
                    End With
                Next

            End If

            TxtTreatmentItem.Text = ""
            TxtTreatmentItem.Tag = ""
            TxtPrescription.Text = ""
            TxtNotes.Text = ""
            TxtTreatmentUnitPrice.Text = "0.00"
            TxtTreatmentQuantity.Text = "1.00"
            TxtTreatmentTotalPrice.Text = "0.00"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTreatment()")
        End Try

    End Sub

    Private Function InitSelectedItemDt() As DataTable

        Dim DtTreatment As New DataTable

        Try
            With DtTreatment
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("PhRequestID", GetType(String))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("ItemGroup", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
                .Columns.Add("ItemTypeDescription", GetType(String))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
                .Columns.Add("IsDb", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitTreatmentDt()")
        End Try

        Return DtTreatment

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckFields("") Then Exit Sub
        If Not SaveTreatmentToDb() Then Exit Sub
        'If Not UpdateBill() Then Exit Sub
    End Sub

    Private Function SaveTreatmentToDb()

        Dim ClsPEFindings As New ClsPEFindings
        Dim ClsDiagnosis As New ClsDiagnosis
        Dim ClsDiagnosisDetail As New ClsDiagnosisDetail
        Dim ClsTreatment As New ClsTreatment
        Dim ClsTreatmentDetail As New ClsTreatmentDetail
        Dim ClsVisit As New ClsVisit

        Try
            'Get visit information to be saved into treatment header
            Dim DtVisit As New DataTable

            With ClsVisit
                .VisitID = VisitID
                DtVisit = .GetVisit(ClsVisit)
            End With

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Add new diagnosis
            'Diagnosis header
            With ClsDiagnosis
                .VisitID = Trim(TxtVisitID.Text)
                .PetID = Trim(TxtPetName.Tag)
                .PetName = Trim(TxtPetName.Text)
                .Diagnosis = Trim(TxtDiagnosis.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewDiagnosis(ClsDiagnosis, DbConn, DbTrans) Then
                    MsgBox("Failed to add new diagnosis.", MsgBoxStyle.Critical, "Add New Diagnosis Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            'Add new diagnosis detail
            For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1

                With ClsDiagnosisDetail
                    .VisitID = Trim(TxtVisitID.Text)
                    .RowNo = DgvSelectedTest.Rows(i).Cells("TestRowNo").Value
                    .ItemCode = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    .ItemDescription = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
                    .ItemGroup = DgvSelectedTest.Rows(i).Cells("TestItemGroup").Value
                    .ItemTypeCode = DgvSelectedTest.Rows(i).Cells("TestItemTypeCode").Value
                    .ItemTypeDescription = DgvSelectedTest.Rows(i).Cells("TestItemTypeDescription").Value
                    .UnitPrice = DgvSelectedTest.Rows(i).Cells("TestUnitPrice").Value
                    .Quantity = DgvSelectedTest.Rows(i).Cells("TestQuantity").Value
                    .TotalPrice = DgvSelectedTest.Rows(i).Cells("TestTotalPrice").Value
                End With

                If Not ClsDiagnosisDetail.AddNewDiagnosisDetail(ClsDiagnosisDetail, DbConn, DbTrans) Then
                    MsgBox("Failed to add new diagnosis detail.", MsgBoxStyle.Critical, "Add New Diagnosis Detail Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            Next

            'Add new treatment
            If DgvSelectedTreatment.Rows.Count > 0 Then

                With ClsTreatment
                    .VisitID = TxtVisitID.Text
                    .TreatmentDate = Now
                    .EmployeeID = CURR_EMPLOYEE_ID
                    .EmployeeName = CURR_EMPLOYEE_NAME
                    .CustomerID = TxtCustomerName.Tag
                    .CustomerName = TxtCustomerName.Text
                    .TelNo = CStrNull(DtVisit.Rows(0).Item("TelNo"))
                    .MobileNo = CStrNull(DtVisit.Rows(0).Item("MobileNo"))
                    '.Email = CStrNull(DtVisit.Rows(0).Item("Email"))
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now

                    If Not .AddNewTreatment(ClsTreatment, DbConn, DbTrans) Then
                        MsgBox("Failed to add new treatment.", MsgBoxStyle.Critical, "Add New Treatment Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    With ClsTreatmentDetail
                        .VisitID = Trim(TxtVisitID.Text)
                        .PhRequestID = DgvSelectedTreatment.Rows(i).Cells("TreatmentPhRequestID").Value
                        .TreatmentDate = Now
                        .RowNo = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                        .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                        .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                        .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                        .Prescription = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value)
                        .Notes = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value)
                        .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                        .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                        .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewTreatmentDetail(ClsTreatmentDetail, DbConn, DbTrans) Then
                            MsgBox("Failed to add new treatment.", MsgBoxStyle.Critical, "Add New Treatment Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            'Set items to IsDb = "1" after items has been saved into the database
            With DgvSelectedTreatment

                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Cells("IsDb").Value = "1"
                Next

            End With

            With ClsDiagnosis

                If TxtDxCreatedBy.Text = "" Then
                    TxtDxCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDxDateModified.Text = "" Then
                    TxtDxDateCreated.Text = .Ref.DateCreated
                End If

                TxtDxModifiedBy.Text = .Ref.ModifiedBy
                TxtDxDateModified.Text = .Ref.DateModified

            End With

            With ClsTreatment

                If TxtTxCreatedBy.Text = "" Then
                    TxtTxCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtTxDateModified.Text = "" Then
                    TxtTxDateCreated.Text = .Ref.DateCreated
                End If

                TxtTxModifiedBy.Text = .Ref.ModifiedBy
                TxtTxDateModified.Text = .Ref.DateModified

            End With

            MsgBox("Your treatment has been successfully added!", MsgBoxStyle.Information, "New Treatment Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveTreatmentToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function UpdateBill()

        Dim DtBillHeader As New DataTable
        Dim DtBillDetail As New DataTable
        Dim DtDiagnosis As New DataTable
        Dim DtTreatment As New DataTable
        Dim DtPayment As New DataTable
        Dim DtUpdateBill As New DataTable
        Dim ClsDiagnosis As New ClsDiagnosis
        Dim ClsTreatment As New ClsTreatment
        Dim ClsTreatmentDetail As New ClsTreatmentDetail
        Dim ClsBill As New ClsBill
        Dim ClsBillDetail As New ClsBillDetail

        Try
            DtPayment = InitBillItemDt()

            'Retrieve existing item from bill detail;
            ClsBill.VisitID = Trim(TxtVisitID.Text)
            DtBillHeader = ClsBill.GetBillHeader(ClsBill)
            If DtBillHeader.Rows.Count > 0 Then
                ClsBill.InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                DtBillDetail = ClsBill.GetBillDetail(ClsBill)
                If DtBillDetail.Rows.Count > 0 Then
                    For i As Integer = 0 To DtBillDetail.Rows.Count - 1
                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtBillDetail.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtBillDetail.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtBillDetail.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtBillDetail.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtBillDetail.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtBillDetail.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = DtBillDetail.Rows(i).Item("Prescription")
                        Row("Notes") = DtBillDetail.Rows(i).Item("Notes")
                        Row("UnitPrice") = DtBillDetail.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtBillDetail.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtBillDetail.Rows(i).Item("TotalPrice")
                        DtPayment.Rows.Add(Row)
                    Next
                    'Else
                    '    Return False
                End If
                'Else
                '    Return False
            End If

            'Retrieve items from diagnosis
            ClsDiagnosis.VisitID = Trim(TxtVisitID.Text)
            DtDiagnosis = ClsDiagnosis.GetDiagnosisDetail(ClsDiagnosis)
            If DtDiagnosis.Rows.Count > 0 Then
                For i As Integer = 0 To DtDiagnosis.Rows.Count - 1

                    If AddItemToBill(DtDiagnosis.Rows(i).Item("ItemCode"), DtPayment) = True Then

                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtDiagnosis.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtDiagnosis.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtDiagnosis.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtDiagnosis.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtDiagnosis.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtDiagnosis.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = ""
                        Row("Notes") = ""
                        Row("UnitPrice") = DtDiagnosis.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtDiagnosis.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtDiagnosis.Rows(i).Item("TotalPrice")

                        DtPayment.Rows.Add(Row)

                    End If

                Next
                'Else
                '    Return False
            End If

            'Retrieve items from treatment

            ClsTreatment.VisitID = Trim(TxtVisitID.Text)
            DtTreatment = ClsTreatment.GetTreatmentDetail(ClsTreatment)
            If DtTreatment.Rows.Count > 0 Then
                For i As Integer = 0 To DtTreatment.Rows.Count - 1

                    If AddItemToBill(DtTreatment.Rows(i).Item("ItemCode"), DtPayment) = True Then

                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtTreatment.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtTreatment.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtTreatment.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtTreatment.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtTreatment.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtTreatment.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = DtTreatment.Rows(i).Item("Prescription")
                        Row("Notes") = DtTreatment.Rows(i).Item("Notes")
                        Row("UnitPrice") = DtTreatment.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtTreatment.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtTreatment.Rows(i).Item("TotalPrice")
                        DtPayment.Rows.Add(Row)

                    End If

                Next
                'Else
                '    Return False
            End If

            If DtPayment.Rows.Count > 0 Then

                Dim GrossTotal As Decimal

                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                'Update RowNo for each item and total price
                For i As Integer = 0 To DtPayment.Rows.Count - 1
                    DtPayment.Rows(i).Item("RowNo") = i + 1
                    GrossTotal = GrossTotal + DtPayment.Rows(i).Item("TotalPrice")
                Next

                'Check if bill is already created during register consultation/visit
                If DtBillHeader.Rows.Count = 0 Then
                    MsgBox("Billing has not been created. Please create customer biling in Customer > Visit.", MsgBoxStyle.Critical, "Billing & Payment Update Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Delete previous items in the bill; insert new billing
                ClsBill.InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                If Not ClsBill.DeleteBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to update billing details.", MsgBoxStyle.Critical, "Bill Update Reset Details Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                ClsBill = New ClsBill
                With ClsBill
                    .InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                    .VisitID = VisitID
                    .InvoiceDate = Now
                    .CustomerID = CustomerID
                    .CustomerName = CustomerName
                    .GrossTotal = GrossTotal
                    .Discount = DtBillHeader.Rows(0).Item("Discount")
                    .GrandTotal = GrossTotal - DtBillHeader.Rows(0).Item("Discount")
                    .Deposit = DtBillHeader.Rows(0).Item("Deposit")
                    .TotalDue = .GrandTotal - .Deposit
                    .IsPaymentComplete = DtBillHeader.Rows(0).Item("IsPaymentComplete")
                    .Ref.CreatedBy = DtBillHeader.Rows(0).Item("CreatedBy")
                    .Ref.DateCreated = DtBillHeader.Rows(0).Item("DateCreated")
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                If Not ClsBill.AddNewBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to create bill header.", MsgBoxStyle.Critical, "Create Bill Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Create bill details
                For i As Integer = 0 To DtPayment.Rows.Count - 1

                    ClsBillDetail = New ClsBillDetail
                    With ClsBillDetail
                        .InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                        .RowNo = DtPayment.Rows(i).Item("RowNo")
                        .ItemCode = DtPayment.Rows(i).Item("ItemCode")
                        .ItemDescription = DtPayment.Rows(i).Item("ItemDescription")
                        .ItemGroup = CStrNull(DtPayment.Rows(i).Item("ItemGroup"))
                        .ItemTypeCode = CStrNull(DtPayment.Rows(i).Item("ItemTypeCode"))
                        .ItemTypeDescription = CStrNull(DtPayment.Rows(i).Item("ItemTypeDescription"))
                        .Prescription = DtPayment.Rows(i).Item("Prescription")
                        .Notes = DtPayment.Rows(i).Item("Notes")
                        .UnitPrice = DtPayment.Rows(i).Item("UnitPrice")
                        .Quantity = DtPayment.Rows(i).Item("Quantity")
                        .TotalPrice = DtPayment.Rows(i).Item("TotalPrice")
                    End With

                    If Not ClsBillDetail.AddNewBillDetail(ClsBillDetail, DbConn, DbTrans) Then
                        MsgBox("Failed to create billing details.", MsgBoxStyle.Critical, "Create Bill Details Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next

                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing

                MsgBox("Customer billing and payment has been successfully updated!", MsgBoxStyle.Information, "Billing & Payment Updated")
            Else
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateBill()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddItemToBill(ItemCode As String, DtPayment As DataTable) As Boolean

        Try
            If DtPayment.Rows.Count > 0 Then
                For i As Integer = 0 To DtPayment.Rows.Count - 1
                    If ItemCode = DtPayment.Rows(i).Item("ItemCode") Then
                        Return False
                    End If
                Next
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddItemToBill()")
            Return False
        End Try

        Return True

    End Function

    Private Function InitBillItemDt() As DataTable

        Dim DtBill As New DataTable

        Try
            With DtBill
                .Columns.Add("InvoiceNo", GetType(String))
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("ItemGroup", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
                .Columns.Add("ItemTypeDescription", GetType(String))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitBillItemDt()")
        End Try

        Return DtBill

    End Function

    Private Function CheckFields(FieldSource As String) As Boolean

        Try
            If TxtVisitID.Text = "" Then
                MsgBox("Please select customer visit.", MsgBoxStyle.Exclamation, "No Customer Visit Selected")
                Return False
            End If

            Select Case FieldSource
                Case "DX"
                    If TxtTestItem.Text = "" Then
                        MsgBox("Please select item.", MsgBoxStyle.Exclamation, "No Item Selected")
                        Return False
                    End If

                Case "TX"
                    If TxtTreatmentItem.Text = "" Then
                        MsgBox("Please select item.", MsgBoxStyle.Exclamation, "No Item Selected")
                        Return False
                    End If

                    For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                        If TxtTreatmentItem.Tag = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value Then
                            MsgBox("You are trying to add same item(s) to the list. Update selected item quantity's instead.", MsgBoxStyle.Exclamation, "Duplicate Item")
                            Return False
                        End If

                    Next

            End Select


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
            Return False
        End Try

        Return True

    End Function

    Private Sub CbIsAdmittedToWard_Click(sender As Object, e As EventArgs) Handles CbIsAdmittedToWard.Click
        If Not IsAdmittedToWard() Then Exit Sub
    End Sub

    Private Function IsAdmittedToWard() As Boolean

        Dim UserResponse As MsgBoxResult
        Dim ClsVisit As New ClsVisit

        Try
            If TxtVisitID.Text = "" Then
                MsgBox("Please select your visit.", MsgBoxStyle.Exclamation, "No Visit Selected")
                Return False
            End If

            UserResponse = MsgBox("Are sure you want to complete this consultation?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Complete Consultation?")
            If UserResponse = MsgBoxResult.Yes Then

                'Update IsCompleted from 0 to 1 if consultation is already completed
                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                With ClsVisit
                    .VisitID = Trim(TxtVisitID.Text)
                    .IsVisitCompleted = IIf(CbIsAdmittedToWard.Checked = True, "1", "0")
                End With

                If Not ClsVisit.UpdateIsVisitCompleted(ClsVisit, DbConn, DbTrans) Then
                    MsgBox("Failed to update visit completion.", MsgBoxStyle.Critical, "Failed to Update Visit Completion")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing

                MsgBox("Your visit has been successfully completed.", MsgBoxStyle.Information, "Visit Completed")

                CbIsAdmittedToWard.Checked = True
                CbIsAdmittedToWard.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".IsVisitCompleted()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub DgvSelectedTreatment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedTreatment.CellDoubleClick

        Try
            With DgvSelectedTreatment

                TxtTreatmentItem.Text = .Rows(e.RowIndex).Cells("TreatmentItemDescription").Value
                TxtTreatmentItem.Tag = .Rows(e.RowIndex).Cells("TreatmentItemCode").Value
                TxtPrescription.Text = .Rows(e.RowIndex).Cells("Prescription").Value
                TxtNotes.Text = .Rows(e.RowIndex).Cells("Notes").Value
                TxtTreatmentUnitPrice.Text = .Rows(e.RowIndex).Cells("TreatmentUnitPrice").Value
                TxtTreatmentQuantity.Text = .Rows(e.RowIndex).Cells("TreatmentQuantity").Value
                TxtTreatmentTotalPrice.Text = .Rows(e.RowIndex).Cells("TreatmentTotalPrice").Value
                BtnAddTreatment.Text = "Update Item" '.Rows(e.RowIndex).Cells("TreatmentUnitPrice").Value
                BtnAddTreatment.Tag = "UPDATE" '.Rows(e.RowIndex).Cells("TreatmentUnitPrice").Value

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSelectedTreatment_CellDoubleClick()")
        End Try

    End Sub

    Private Sub DgvSelectedTreatment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedTreatment.CellContentClick

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedTreatment

                            If .Rows(e.RowIndex).Cells("IsDb").Value = "0" Then
                                .Rows.RemoveAt(e.RowIndex)
                            Else
                                MsgBox("Unable to delete item that has been saved into the database.", MsgBoxStyle.Exclamation, "Read-Only Item")
                            End If

                        End With

                    End If

                ElseIf e.ColumnIndex = 1 Then

                        'UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                        'If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedTreatment

                        TxtTreatmentItem.Text = .Rows(e.RowIndex).Cells("TreatmentItemDescription").Value
                        TxtTreatmentItem.Tag = .Rows(e.RowIndex).Cells("TreatmentItemCode").Value
                        TxtPrescription.Text = CStrNull(.Rows(e.RowIndex).Cells("TreatmentPrescription").Value)
                        TxtNotes.Text = CStrNull(.Rows(e.RowIndex).Cells("TreatmentNotes").Value)
                        TxtTreatmentUnitPrice.Text = .Rows(e.RowIndex).Cells("TreatmentUnitPrice").Value
                        TxtTreatmentQuantity.Text = .Rows(e.RowIndex).Cells("TreatmentQuantity").Value
                        TxtTreatmentTotalPrice.Text = .Rows(e.RowIndex).Cells("TreatmentTotalPrice").Value

                    End With

                    BtnAddTreatment.Text = "Update Item"
                    BtnAddTreatment.Tag = "UPDATE"
                    LblRowNo.Text = e.RowIndex

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPetListing_CellContentClick()")
        End Try
    End Sub

    Private Sub DgvSelectedTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedTest.CellContentClick

        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedTest

                            Dim RowIndex As Integer = .Rows(e.RowIndex).Cells("TestRowNo").Value

                            If LblInvoiceNo.Text = "" Then
                                .Rows.RemoveAt(e.RowIndex)
                            Else
                                Exit Sub
                            End If

                            'If TxtInvoiceNo.Text <> "" Then
                            '    If Not DeleteBillItems(RowIndex, TxtInvoiceNo.Text) Then
                            '        MsgBox("Failed to delete bill's items(s). Please try again.", MsgBoxStyle.Critical, "Delete Bill Item(s)")
                            '    End If
                            'End If

                            'Re-populate bill items
                            'PopulateForm("SHOW_BILLING_INFO")

                            If .Rows.Count = 0 Then
                                .DataSource = Nothing
                                .Show()
                            End If

                        End With

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSelectedTest_CellContentClick()")
        End Try

    End Sub

    Private Sub BtnSendToPharmacy_Click(sender As Object, e As EventArgs) Handles BtnSendToPharmacy.Click
        If Not SendRequestToPharmacy() Then Exit Sub
    End Sub

    Private Function SendRequestToPharmacy() As Boolean

        Dim GenRequestID As String = ""

        Try
            Dim UserResponse As MsgBoxResult
            UserResponse = MsgBox("Are sure you want to send request to pharmacy?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Send Request To Pharmacy?")

            If UserResponse = MsgBoxResult.Yes Then

                If DgvSelectedTreatment.Rows.Count = 0 Then
                    MsgBox("Please complete your medication list before requesting.", MsgBoxStyle.Exclamation, "No Medication Request Specified")
                    Return False
                End If

                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                Dim ClsPharmacy As New ClsPharmacy
                Dim ClsPharmacyDetail As New ClsPharmacyDetail

                If DgvSelectedTreatment.Rows.Count > 0 Then

                    GenRequestID = IIf(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value <> "",
                                       DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value,
                                       GenerateRunningNo("RQ", DbConn, DbTrans, ""))

                    If GenRequestID = "" Then
                        MsgBox("Failed to generate Request ID.", MsgBoxStyle.Critical, "Request ID Generation Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                    With ClsPharmacy
                        .RequestID = GenRequestID
                        .VisitID = TxtVisitID.Text
                        .RequestDate = Now
                        .Source = FORM_SOURCE
                        .RqEmpID = CURR_EMPLOYEE_ID
                        .RqEmpName = CURR_EMPLOYEE_NAME
                        .PhEmpID = ""
                        .PhEmpName = ""
                        .ApprovalDate = Nothing
                        .IsCompleted = "0"
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewPharmacyRequest(ClsPharmacy, DbConn, DbTrans) Then
                            MsgBox("Failed to update pharmacy request.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With


                    For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                        With ClsPharmacyDetail
                            .RequestID = GenRequestID
                            .VisitID = TxtVisitID.Text
                            .RowNo = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                            .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                            .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                            .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                            .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                            .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                            .Prescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value
                            .Notes = DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value
                            .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                            .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                            .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                            .Ref.CreatedBy = CURR_USER
                            .Ref.DateCreated = Now
                            .Ref.ModifiedBy = CURR_USER
                            .Ref.DateModified = Now

                            If Not .AddNewPharmacyRequestDetail(ClsPharmacyDetail, DbConn, DbTrans) Then
                                MsgBox("Failed to update pharmacy request details.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
                                DbTrans.Rollback()
                                DbTrans.Dispose()
                                DbTrans = Nothing
                                Return False
                            End If
                        End With

                    Next

                End If

            End If

            'BtnSendToPharmacy.Tag = GenRequestID
            'RequestID = GenRequestID

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            If DgvSelectedTreatment.Rows.Count > 0 Then
                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1
                    DgvSelectedTreatment.Rows(i).Cells("TreatmentPhRequestID").Value = GenRequestID
                Next
            End If

            MsgBox("Your pharmacy request has been successfully sent!", MsgBoxStyle.Information, "Pharmacy Request Sent")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SendRequestToPharmacy()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

End Class