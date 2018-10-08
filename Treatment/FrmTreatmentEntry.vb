Public Class FrmTreatmentEntry

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

    Private Sub FrmTreatmentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateTemperament()
        PopulateBodyScore()
        PopulateForm(UserCommand)
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

                If CmbTemperament.Items.Count > 0 Then
                    CmbTemperament.DataSource = Nothing
                    CmbTemperament.Items.Clear()
                End If

                CmbTemperament.DataSource = New BindingSource(CmbSource, Nothing)
                CmbTemperament.DisplayMember = "Value"
                CmbTemperament.ValueMember = "Key"

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

                If CmbBodyScore.Items.Count > 0 Then
                    CmbBodyScore.DataSource = Nothing
                    CmbBodyScore.Items.Clear()
                End If

                CmbBodyScore.DataSource = New BindingSource(CmbSource, Nothing)
                CmbBodyScore.DisplayMember = "Value"
                CmbBodyScore.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateBodyScore()")
        End Try

    End Sub

    Private Sub PopulateForm(UserCommand As String)

        Dim DtVisit As New DataTable
        Dim DtPEF As New DataTable
        Dim DtTreatment As New DataTable
        Dim DtDiagnosis As New DataTable
        Dim ClsVisit As New ClsVisit

        Try
            'Get pet info from VisitID
            Select Case UserCommand
                Case "POPULATE_CUSTOMER_INFO"
                    TxtVisitID.Text = VisitID
                    TxtCustomerID.Text = CustomerID
                    TxtCustomerName.Text = CustomerName
                    TxtPetID.Text = PetID
                    TxtPetName.Text = PetName

                Case "SHOW_TREATMENT_INFO"
                    'DtVisit = ClsVisit.GetConsultationDetail(ClsVisit)

                Case ""


            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            With FrmSearchVisit
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
        FrmPaymentEntry.ShowDialog()
    End Sub

    Private Sub BtnSearchTestItem_Click(sender As Object, e As EventArgs) Handles BtnSearchTestItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTestItem.Tag = .ItemCode
            TxtTestItem.Text = .ItemDescription
            TxtTestUnitPrice.Text = .UnitPrice
            TxtTestTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTestQuantity.Text), 2)
        End With
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTreatmentItem.Tag = .ItemCode
            TxtTreatmentItem.Text = .ItemDescription
            TxtTreatmentUnitPrice.Text = .UnitPrice
            TxtTreatmentTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTreatmentQuantity.Text), 2)
        End With
    End Sub

    Private Sub BtnAddTest_Click(sender As Object, e As EventArgs) Handles BtnAddTest.Click
        AddTest()
    End Sub

    Private Sub AddTest()

        Dim DtTest As New DataTable

        Try
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
                    End With
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTest()")
        End Try

    End Sub

    Private Sub BtnTreatmentItem_Click(sender As Object, e As EventArgs) Handles BtnTreatmentItem.Click
        AddTreatment()
    End Sub

    Private Sub AddTreatment()

        Dim DtTreatment As New DataTable

        Try
            DtTreatment = InitSelectedItemDt()
            If DgvSelectedTreatment.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTreatment.NewRow

                    DgvRow("RowNo") = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                    DgvRow("Prescription") = DgvSelectedTreatment.Rows(i).Cells("Prescription").Value
                    DgvRow("Notes") = DgvSelectedTreatment.Rows(i).Cells("Notes").Value
                    DgvRow("Quantity") = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value

                    DtTreatment.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtTreatment.NewRow

            Row("RowNo") = IIf(DtTreatment.Rows.Count = 0, 1, DtTreatment.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtTreatmentItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtTreatmentItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtTreatmentUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTreatmentQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTreatmentTotalPrice.Text) * CDec(TxtTreatmentQuantity.Text), 2)

            DtTreatment.Rows.Add(Row)

            If DtTreatment.Rows.Count > 0 Then

                DgvSelectedTreatment.Rows.Clear()

                For i As Integer = 0 To DtTreatment.Rows.Count - 1
                    With DgvSelectedTreatment
                        .Rows.Add()
                        .Rows(i).Cells("TreatmentRowNo").Value = DtTreatment.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TreatmentItemCode").Value = DtTreatment.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TreatmentItemDescription").Value = DtTreatment.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("TreatmentUnitPrice").Value = DtTreatment.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("TreatmentQuantity").Value = DtTreatment.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TreatmentTotalPrice").Value = DtTreatment.Rows(i).Item("TotalPrice")
                    End With
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTreatment()")
        End Try

    End Sub

    Private Function InitSelectedItemDt() As DataTable

        Dim DtTreatment As New DataTable

        Try
            With DtTreatment
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("ItemType", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitTreatmentDt()")
        End Try

        Return DtTreatment

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckFields() Then Exit Sub
        If Not SaveTreatmentToDb() Then Exit Sub
    End Sub

    Private Function SaveTreatmentToDb()

        Dim ClsPEFindings As New ClsPEFindings
        Dim ClsDiagnosis As New ClsDiagnosis
        Dim ClsDiagnosisDetail As New ClsDiagnosisDetail
        Dim ClsTreatment As New ClsTreatment

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Add new PE findings
            Dim StrTemperamentName As String = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Dim StrBodyScoreName As String = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Dim TemperamentName As String = StrTemperamentName.Replace(StrTemperamentName.Substring(0, 4), "")
            Dim BodyScoreName As String = StrBodyScoreName.Replace(StrBodyScoreName.Substring(0, 4), "")

            With ClsPEFindings
                .VisitID = Trim(TxtVisitID.Text)
                .PetID = Trim(TxtPetID.Text)
                .PetName = Trim(TxtPetName.Text)
                .Temperature = CDec(TxtTemperature.Text)
                .TemperamentCode = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .TemperamentName = TemperamentName
                .BodyScoreCode = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .BodyScoreName = BodyScoreName
                .PEFindings = Trim(TxtFindings.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsPEFindings.AddNewPEFindings(ClsPEFindings, DbConn, DbTrans) Then
                MsgBox("Failed to add new physical examination findings.", MsgBoxStyle.Critical, "Add New PE Findings Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Add new diagnosis
            'Diagnosis header
            With ClsDiagnosis
                .VisitID = Trim(TxtVisitID.Text)
                .PetID = Trim(TxtPetID.Text)
                .PetName = Trim(TxtPetName.Text)
                .Diagnosis = Trim(TxtDiagnosis.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsDiagnosis.AddNewDiagnosis(ClsDiagnosis, DbConn, DbTrans) Then
                MsgBox("Failed to add new diagnosis.", MsgBoxStyle.Critical, "Add New Diagnosis Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Add new diagnosis detail
            For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1

                With ClsDiagnosisDetail
                    .VisitID = Trim(TxtVisitID.Text)
                    .RowNo = DgvSelectedTest.Rows(i).Cells("TestRowNo").Value
                    .ItemCode = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    .ItemDescription = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
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
            For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                With ClsTreatment
                    .VisitID = Trim(TxtVisitID.Text)
                    .RowNo = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                    .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                    .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                    .ItemTypeCode = ""
                    .Prescription = DgvSelectedTreatment.Rows(i).Cells("Prescription").Value
                    .Notes = DgvSelectedTreatment.Rows(i).Cells("Notes").Value
                    .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                    .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                    .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                If Not ClsTreatment.AddNewTreatment(ClsTreatment, DbConn, DbTrans) Then
                    MsgBox("Failed to add new treatment.", MsgBoxStyle.Critical, "Add New Treatment Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            Next

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

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

        Dim DtDiagnosis As New DataTable
        Dim DtTreatment As New DataTable
        Dim DtUpdateBill As New DataTable
        Dim ClsDiagnosis As New ClsDiagnosis
        Dim ClsTreatment As New ClsTreatment

        Try
            ClsDiagnosis.VisitID = Trim(TxtVisitID.Text)
            DtDiagnosis = ClsDiagnosis.GetVisitDiagnosisDetail(ClsDiagnosis)

            ClsTreatment.VisitID = Trim(TxtVisitID.Text)
            DtTreatment = ClsTreatment.GetTreatmentDetail(ClsTreatment)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateBill()")
            Return False
        End Try

        Return True

    End Function

    Private Function CheckFields()

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
            Return False
        End Try

        Return True

    End Function


End Class