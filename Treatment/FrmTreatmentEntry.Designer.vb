<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTreatmentEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTreatmentEntry))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CmbBodyScore = New System.Windows.Forms.ComboBox()
        Me.CmbTemperament = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFindings = New System.Windows.Forms.TextBox()
        Me.TxtBodyWeight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTemperature = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtTestTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTestQuantity = New System.Windows.Forms.TextBox()
        Me.TxtTestItem = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSearchTestItem = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTestUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnAddTest = New System.Windows.Forms.Button()
        Me.DgvSelectedTest = New System.Windows.Forms.DataGridView()
        Me.BtnTestDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TestRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtTreatmentTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtTreatmentUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtTreatmentQuantity = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.BtnTreatmentItem = New System.Windows.Forms.Button()
        Me.DgvSelectedTreatment = New System.Windows.Forms.DataGridView()
        Me.BtnTreatmentDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TreatmentRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTreatmentItem = New System.Windows.Forms.TextBox()
        Me.BtnClearItem = New System.Windows.Forms.Button()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBillPayment = New System.Windows.Forms.Button()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPetID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.PnlActionBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.BtnSearch)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(750, 61)
        Me.PnlActionBar.TabIndex = 85
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(381, 3)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(442, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 56)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(686, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(564, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 56)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(625, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 56)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(503, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 56)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 162)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 468)
        Me.TabControl1.TabIndex = 86
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmbBodyScore)
        Me.TabPage1.Controls.Add(Me.CmbTemperament)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtFindings)
        Me.TabPage1.Controls.Add(Me.TxtBodyWeight)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtTemperature)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Physical Examination Findings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CmbBodyScore
        '
        Me.CmbBodyScore.FormattingEnabled = True
        Me.CmbBodyScore.Location = New System.Drawing.Point(88, 64)
        Me.CmbBodyScore.Name = "CmbBodyScore"
        Me.CmbBodyScore.Size = New System.Drawing.Size(121, 22)
        Me.CmbBodyScore.TabIndex = 14
        '
        'CmbTemperament
        '
        Me.CmbTemperament.FormattingEnabled = True
        Me.CmbTemperament.Location = New System.Drawing.Point(88, 39)
        Me.CmbTemperament.Name = "CmbTemperament"
        Me.CmbTemperament.Size = New System.Drawing.Size(121, 22)
        Me.CmbTemperament.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(165, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 14)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "kg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ºC"
        '
        'TxtFindings
        '
        Me.TxtFindings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFindings.Location = New System.Drawing.Point(13, 139)
        Me.TxtFindings.Multiline = True
        Me.TxtFindings.Name = "TxtFindings"
        Me.TxtFindings.Size = New System.Drawing.Size(596, 146)
        Me.TxtFindings.TabIndex = 10
        '
        'TxtBodyWeight
        '
        Me.TxtBodyWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBodyWeight.Location = New System.Drawing.Point(88, 89)
        Me.TxtBodyWeight.Name = "TxtBodyWeight"
        Me.TxtBodyWeight.Size = New System.Drawing.Size(74, 20)
        Me.TxtBodyWeight.TabIndex = 9
        Me.TxtBodyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 14)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Body Weight"
        '
        'TxtTemperature
        '
        Me.TxtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTemperature.Location = New System.Drawing.Point(88, 16)
        Me.TxtTemperature.Name = "TxtTemperature"
        Me.TxtTemperature.Size = New System.Drawing.Size(74, 20)
        Me.TxtTemperature.TabIndex = 5
        Me.TxtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Write Up/Case Hisory/PE Findings:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Body Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temperament"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temperature"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.TxtTestTotalPrice)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TxtTestQuantity)
        Me.TabPage2.Controls.Add(Me.TxtTestItem)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.BtnSearchTestItem)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.TxtTestUnitPrice)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.BtnAddTest)
        Me.TabPage2.Controls.Add(Me.DgvSelectedTest)
        Me.TabPage2.Controls.Add(Me.TxtDiagnosis)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diagnostic & Tests"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 14)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "Total Price"
        '
        'TxtTestTotalPrice
        '
        Me.TxtTestTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestTotalPrice.Location = New System.Drawing.Point(72, 90)
        Me.TxtTestTotalPrice.Name = "TxtTestTotalPrice"
        Me.TxtTestTotalPrice.ReadOnly = True
        Me.TxtTestTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestTotalPrice.TabIndex = 170
        Me.TxtTestTotalPrice.Text = "0.00"
        Me.TxtTestTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Quantity"
        '
        'TxtTestQuantity
        '
        Me.TxtTestQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTestQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestQuantity.Location = New System.Drawing.Point(72, 65)
        Me.TxtTestQuantity.Name = "TxtTestQuantity"
        Me.TxtTestQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestQuantity.TabIndex = 168
        Me.TxtTestQuantity.Text = "1.00"
        Me.TxtTestQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTestItem
        '
        Me.TxtTestItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTestItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestItem.Location = New System.Drawing.Point(72, 14)
        Me.TxtTestItem.Name = "TxtTestItem"
        Me.TxtTestItem.ReadOnly = True
        Me.TxtTestItem.Size = New System.Drawing.Size(374, 21)
        Me.TxtTestItem.TabIndex = 164
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(489, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 25)
        Me.Button3.TabIndex = 166
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnSearchTestItem
        '
        Me.BtnSearchTestItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchTestItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchTestItem.Location = New System.Drawing.Point(451, 12)
        Me.BtnSearchTestItem.Name = "BtnSearchTestItem"
        Me.BtnSearchTestItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchTestItem.TabIndex = 165
        Me.BtnSearchTestItem.Text = "..."
        Me.BtnSearchTestItem.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 14)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Item"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 14)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Unit Price"
        '
        'TxtTestUnitPrice
        '
        Me.TxtTestUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestUnitPrice.Location = New System.Drawing.Point(72, 40)
        Me.TxtTestUnitPrice.Name = "TxtTestUnitPrice"
        Me.TxtTestUnitPrice.ReadOnly = True
        Me.TxtTestUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestUnitPrice.TabIndex = 162
        Me.TxtTestUnitPrice.Text = "0.00"
        Me.TxtTestUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Selected Test(s) :"
        '
        'BtnAddTest
        '
        Me.BtnAddTest.Location = New System.Drawing.Point(72, 118)
        Me.BtnAddTest.Name = "BtnAddTest"
        Me.BtnAddTest.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddTest.TabIndex = 19
        Me.BtnAddTest.Text = "Add Test"
        Me.BtnAddTest.UseVisualStyleBackColor = True
        '
        'DgvSelectedTest
        '
        Me.DgvSelectedTest.AllowUserToAddRows = False
        Me.DgvSelectedTest.AllowUserToDeleteRows = False
        Me.DgvSelectedTest.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTestDeleteItem, Me.TestRowNo, Me.TestItemCode, Me.TestItemDescription, Me.TestUnitPrice, Me.TestQuantity, Me.TestTotalPrice})
        Me.DgvSelectedTest.Location = New System.Drawing.Point(12, 165)
        Me.DgvSelectedTest.Name = "DgvSelectedTest"
        Me.DgvSelectedTest.ReadOnly = True
        Me.DgvSelectedTest.Size = New System.Drawing.Size(712, 115)
        Me.DgvSelectedTest.TabIndex = 18
        '
        'BtnTestDeleteItem
        '
        Me.BtnTestDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnTestDeleteItem.HeaderText = "Delete?"
        Me.BtnTestDeleteItem.Name = "BtnTestDeleteItem"
        Me.BtnTestDeleteItem.ReadOnly = True
        Me.BtnTestDeleteItem.Text = "Delete"
        Me.BtnTestDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnTestDeleteItem.Width = 49
        '
        'TestRowNo
        '
        Me.TestRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestRowNo.HeaderText = "No."
        Me.TestRowNo.Name = "TestRowNo"
        Me.TestRowNo.ReadOnly = True
        Me.TestRowNo.Width = 48
        '
        'TestItemCode
        '
        Me.TestItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestItemCode.HeaderText = "Item Code"
        Me.TestItemCode.Name = "TestItemCode"
        Me.TestItemCode.ReadOnly = True
        Me.TestItemCode.Width = 79
        '
        'TestItemDescription
        '
        Me.TestItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TestItemDescription.HeaderText = "Item Description"
        Me.TestItemDescription.Name = "TestItemDescription"
        Me.TestItemDescription.ReadOnly = True
        '
        'TestUnitPrice
        '
        Me.TestUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestUnitPrice.HeaderText = "Unit Price"
        Me.TestUnitPrice.Name = "TestUnitPrice"
        Me.TestUnitPrice.ReadOnly = True
        Me.TestUnitPrice.Width = 77
        '
        'TestQuantity
        '
        Me.TestQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestQuantity.HeaderText = "Quantity"
        Me.TestQuantity.Name = "TestQuantity"
        Me.TestQuantity.ReadOnly = True
        Me.TestQuantity.Width = 72
        '
        'TestTotalPrice
        '
        Me.TestTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestTotalPrice.HeaderText = "Total Price"
        Me.TestTotalPrice.Name = "TestTotalPrice"
        Me.TestTotalPrice.ReadOnly = True
        Me.TestTotalPrice.Width = 81
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosis.Location = New System.Drawing.Point(12, 304)
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(712, 124)
        Me.TxtDiagnosis.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Diagnosis && Planning :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentTotalPrice)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentUnitPrice)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentQuantity)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.TxtPrescription)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.TxtNotes)
        Me.TabPage3.Controls.Add(Me.BtnTreatmentItem)
        Me.TabPage3.Controls.Add(Me.DgvSelectedTreatment)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentItem)
        Me.TabPage3.Controls.Add(Me.BtnClearItem)
        Me.TabPage3.Controls.Add(Me.BtnSearchItem)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Treatment & Medication"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "Total Price"
        '
        'TxtTreatmentTotalPrice
        '
        Me.TxtTreatmentTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentTotalPrice.Location = New System.Drawing.Point(75, 188)
        Me.TxtTreatmentTotalPrice.Name = "TxtTreatmentTotalPrice"
        Me.TxtTreatmentTotalPrice.ReadOnly = True
        Me.TxtTreatmentTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentTotalPrice.TabIndex = 176
        Me.TxtTreatmentTotalPrice.Text = "0.00"
        Me.TxtTreatmentTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 141)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 14)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Unit Price"
        '
        'TxtTreatmentUnitPrice
        '
        Me.TxtTreatmentUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentUnitPrice.Location = New System.Drawing.Point(75, 138)
        Me.TxtTreatmentUnitPrice.Name = "TxtTreatmentUnitPrice"
        Me.TxtTreatmentUnitPrice.ReadOnly = True
        Me.TxtTreatmentUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentUnitPrice.TabIndex = 172
        Me.TxtTreatmentUnitPrice.Text = "0.00"
        Me.TxtTreatmentUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 166)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 14)
        Me.Label36.TabIndex = 159
        Me.Label36.Text = "Quantity"
        '
        'TxtTreatmentQuantity
        '
        Me.TxtTreatmentQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentQuantity.Location = New System.Drawing.Point(75, 163)
        Me.TxtTreatmentQuantity.Name = "TxtTreatmentQuantity"
        Me.TxtTreatmentQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentQuantity.TabIndex = 160
        Me.TxtTreatmentQuantity.Text = "1.00"
        Me.TxtTreatmentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 44)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 155
        Me.Label34.Text = "Prescription"
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(75, 44)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(416, 43)
        Me.TxtPrescription.TabIndex = 156
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 91)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 14)
        Me.Label35.TabIndex = 157
        Me.Label35.Text = "Notes"
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(75, 91)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(416, 43)
        Me.TxtNotes.TabIndex = 158
        '
        'BtnTreatmentItem
        '
        Me.BtnTreatmentItem.Location = New System.Drawing.Point(75, 215)
        Me.BtnTreatmentItem.Name = "BtnTreatmentItem"
        Me.BtnTreatmentItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnTreatmentItem.TabIndex = 154
        Me.BtnTreatmentItem.Text = "Add Item"
        Me.BtnTreatmentItem.UseVisualStyleBackColor = True
        '
        'DgvSelectedTreatment
        '
        Me.DgvSelectedTreatment.AllowUserToAddRows = False
        Me.DgvSelectedTreatment.AllowUserToDeleteRows = False
        Me.DgvSelectedTreatment.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTreatmentDeleteItem, Me.TreatmentRowNo, Me.TreatmentItemCode, Me.TreatmentItemDescription, Me.Prescription, Me.Notes, Me.TreatmentUnitPrice, Me.TreatmentQuantity, Me.TreatmentTotalPrice})
        Me.DgvSelectedTreatment.Location = New System.Drawing.Point(9, 244)
        Me.DgvSelectedTreatment.Name = "DgvSelectedTreatment"
        Me.DgvSelectedTreatment.ReadOnly = True
        Me.DgvSelectedTreatment.Size = New System.Drawing.Size(724, 170)
        Me.DgvSelectedTreatment.TabIndex = 153
        '
        'BtnTreatmentDeleteItem
        '
        Me.BtnTreatmentDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnTreatmentDeleteItem.HeaderText = "Delete?"
        Me.BtnTreatmentDeleteItem.Name = "BtnTreatmentDeleteItem"
        Me.BtnTreatmentDeleteItem.ReadOnly = True
        Me.BtnTreatmentDeleteItem.Text = "Delete"
        Me.BtnTreatmentDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnTreatmentDeleteItem.Width = 49
        '
        'TreatmentRowNo
        '
        Me.TreatmentRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentRowNo.HeaderText = "No."
        Me.TreatmentRowNo.Name = "TreatmentRowNo"
        Me.TreatmentRowNo.ReadOnly = True
        Me.TreatmentRowNo.Width = 48
        '
        'TreatmentItemCode
        '
        Me.TreatmentItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentItemCode.HeaderText = "Item Code"
        Me.TreatmentItemCode.Name = "TreatmentItemCode"
        Me.TreatmentItemCode.ReadOnly = True
        Me.TreatmentItemCode.Width = 79
        '
        'TreatmentItemDescription
        '
        Me.TreatmentItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentItemDescription.HeaderText = "Item Description"
        Me.TreatmentItemDescription.Name = "TreatmentItemDescription"
        Me.TreatmentItemDescription.ReadOnly = True
        '
        'Prescription
        '
        Me.Prescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Prescription.HeaderText = "Prescription"
        Me.Prescription.Name = "Prescription"
        Me.Prescription.ReadOnly = True
        Me.Prescription.Width = 89
        '
        'Notes
        '
        Me.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 60
        '
        'TreatmentUnitPrice
        '
        Me.TreatmentUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentUnitPrice.HeaderText = "Unit Price"
        Me.TreatmentUnitPrice.Name = "TreatmentUnitPrice"
        Me.TreatmentUnitPrice.ReadOnly = True
        Me.TreatmentUnitPrice.Width = 77
        '
        'TreatmentQuantity
        '
        Me.TreatmentQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentQuantity.HeaderText = "Quantity"
        Me.TreatmentQuantity.Name = "TreatmentQuantity"
        Me.TreatmentQuantity.ReadOnly = True
        Me.TreatmentQuantity.Width = 72
        '
        'TreatmentTotalPrice
        '
        Me.TreatmentTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentTotalPrice.HeaderText = "Total Price"
        Me.TreatmentTotalPrice.Name = "TreatmentTotalPrice"
        Me.TreatmentTotalPrice.ReadOnly = True
        Me.TreatmentTotalPrice.Width = 81
        '
        'TxtTreatmentItem
        '
        Me.TxtTreatmentItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentItem.Location = New System.Drawing.Point(75, 17)
        Me.TxtTreatmentItem.Name = "TxtTreatmentItem"
        Me.TxtTreatmentItem.ReadOnly = True
        Me.TxtTreatmentItem.Size = New System.Drawing.Size(387, 21)
        Me.TxtTreatmentItem.TabIndex = 150
        '
        'BtnClearItem
        '
        Me.BtnClearItem.Location = New System.Drawing.Point(504, 15)
        Me.BtnClearItem.Name = "BtnClearItem"
        Me.BtnClearItem.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearItem.TabIndex = 152
        Me.BtnClearItem.Text = "Clear"
        Me.BtnClearItem.UseVisualStyleBackColor = True
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(466, 15)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 151
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Item"
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(113, 84)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(87, 21)
        Me.TxtVisitID.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Visit ID"
        '
        'BtnBillPayment
        '
        Me.BtnBillPayment.Location = New System.Drawing.Point(456, 128)
        Me.BtnBillPayment.Name = "BtnBillPayment"
        Me.BtnBillPayment.Size = New System.Drawing.Size(186, 23)
        Me.BtnBillPayment.TabIndex = 89
        Me.BtnBillPayment.Text = "Bill && Payment..."
        Me.BtnBillPayment.UseVisualStyleBackColor = True
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerID.Location = New System.Drawing.Point(113, 107)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(87, 21)
        Me.TxtCustomerID.TabIndex = 91
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(203, 107)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(224, 21)
        Me.TxtCustomerName.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 15)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Customer Name"
        '
        'TxtPetID
        '
        Me.TxtPetID.BackColor = System.Drawing.Color.Beige
        Me.TxtPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetID.Location = New System.Drawing.Point(113, 130)
        Me.TxtPetID.Name = "TxtPetID"
        Me.TxtPetID.ReadOnly = True
        Me.TxtPetID.Size = New System.Drawing.Size(87, 21)
        Me.TxtPetID.TabIndex = 95
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 15)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Pet Name"
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.Beige
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.Location = New System.Drawing.Point(203, 130)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(224, 21)
        Me.TxtPetName.TabIndex = 96
        '
        'FrmTreatmentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 642)
        Me.Controls.Add(Me.TxtPetName)
        Me.Controls.Add(Me.TxtPetID)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtCustomerID)
        Me.Controls.Add(Me.BtnBillPayment)
        Me.Controls.Add(Me.TxtVisitID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTreatmentEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment Entry"
        Me.PnlActionBar.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTemperature As TextBox
    Friend WithEvents TxtBodyWeight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtFindings As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBillPayment As Button
    Friend WithEvents TxtDiagnosis As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvSelectedTest As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnAddTest As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTreatmentItem As TextBox
    Friend WithEvents BtnClearItem As Button
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents BtnTreatmentItem As Button
    Friend WithEvents DgvSelectedTreatment As DataGridView
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TxtTreatmentQuantity As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTestUnitPrice As TextBox
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPetID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTestItem As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSearchTestItem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtTestTotalPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTestQuantity As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTreatmentTotalPrice As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtTreatmentUnitPrice As TextBox
    Friend WithEvents CmbBodyScore As ComboBox
    Friend WithEvents CmbTemperament As ComboBox
    Friend WithEvents BtnTestDeleteItem As DataGridViewButtonColumn
    Friend WithEvents TestRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TestItemCode As DataGridViewTextBoxColumn
    Friend WithEvents TestItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents TestUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TestQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TestTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents BtnTreatmentDeleteItem As DataGridViewButtonColumn
    Friend WithEvents TreatmentRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemCode As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents Prescription As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentTotalPrice As DataGridViewTextBoxColumn
End Class
