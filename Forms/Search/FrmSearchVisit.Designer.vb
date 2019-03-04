<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearchVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearchVisit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbIsVisitCompleted = New System.Windows.Forms.CheckBox()
        Me.CbIsWarded = New System.Windows.Forms.CheckBox()
        Me.CbNotAssigned = New System.Windows.Forms.CheckBox()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DgvVisit = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvSearchVisitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchVisitTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchEmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchEmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchPetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchIsCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchIsWarded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvSearchDateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label1)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(839, 68)
        Me.PnlActionBar.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search Visit"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(775, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbIsVisitCompleted)
        Me.GroupBox1.Controls.Add(Me.CbIsWarded)
        Me.GroupBox1.Controls.Add(Me.CbNotAssigned)
        Me.GroupBox1.Controls.Add(Me.TxtSearchText)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 109)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'CbIsVisitCompleted
        '
        Me.CbIsVisitCompleted.AutoSize = True
        Me.CbIsVisitCompleted.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbIsVisitCompleted.Location = New System.Drawing.Point(137, 28)
        Me.CbIsVisitCompleted.Name = "CbIsVisitCompleted"
        Me.CbIsVisitCompleted.Size = New System.Drawing.Size(100, 18)
        Me.CbIsVisitCompleted.TabIndex = 5
        Me.CbIsVisitCompleted.Text = "Visit Completed"
        Me.CbIsVisitCompleted.UseVisualStyleBackColor = False
        '
        'CbIsWarded
        '
        Me.CbIsWarded.AutoSize = True
        Me.CbIsWarded.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbIsWarded.Location = New System.Drawing.Point(20, 28)
        Me.CbIsWarded.Name = "CbIsWarded"
        Me.CbIsWarded.Size = New System.Drawing.Size(111, 18)
        Me.CbIsWarded.TabIndex = 4
        Me.CbIsWarded.Text = "Admitted To Ward"
        Me.CbIsWarded.UseVisualStyleBackColor = False
        '
        'CbNotAssigned
        '
        Me.CbNotAssigned.AutoSize = True
        Me.CbNotAssigned.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNotAssigned.Location = New System.Drawing.Point(402, 28)
        Me.CbNotAssigned.Name = "CbNotAssigned"
        Me.CbNotAssigned.Size = New System.Drawing.Size(90, 18)
        Me.CbNotAssigned.TabIndex = 3
        Me.CbNotAssigned.Text = "Not Assigned"
        Me.CbNotAssigned.UseVisualStyleBackColor = False
        Me.CbNotAssigned.Visible = False
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BackColor = System.Drawing.Color.White
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(20, 58)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(518, 26)
        Me.TxtSearchText.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(542, 43)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'DgvVisit
        '
        Me.DgvVisit.AllowUserToAddRows = False
        Me.DgvVisit.AllowUserToDeleteRows = False
        Me.DgvVisit.AllowUserToOrderColumns = True
        Me.DgvVisit.AllowUserToResizeRows = False
        Me.DgvVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvVisit.BackgroundColor = System.Drawing.Color.White
        Me.DgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVisit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvSearchVisitID, Me.DgvSearchVisitTime, Me.DgvSearchEmployeeID, Me.DgvSearchEmployeeName, Me.DgvSearchCustomerID, Me.DgvSearchCustomerName, Me.DgvSearchPetName, Me.DgvSearchIsCompleted, Me.DgvSearchIsWarded, Me.DgvSearchCreatedBy, Me.DgvSearchDateCreated})
        Me.DgvVisit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVisit.Location = New System.Drawing.Point(3, 16)
        Me.DgvVisit.MultiSelect = False
        Me.DgvVisit.Name = "DgvVisit"
        Me.DgvVisit.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvVisit.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVisit.Size = New System.Drawing.Size(829, 366)
        Me.DgvVisit.TabIndex = 77
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvVisit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(835, 385)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visit List(s)"
        '
        'DgvSearchVisitID
        '
        Me.DgvSearchVisitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchVisitID.HeaderText = "Visit ID"
        Me.DgvSearchVisitID.Name = "DgvSearchVisitID"
        Me.DgvSearchVisitID.ReadOnly = True
        Me.DgvSearchVisitID.Width = 65
        '
        'DgvSearchVisitTime
        '
        Me.DgvSearchVisitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchVisitTime.HeaderText = "VisitTime"
        Me.DgvSearchVisitTime.Name = "DgvSearchVisitTime"
        Me.DgvSearchVisitTime.ReadOnly = True
        Me.DgvSearchVisitTime.Width = 75
        '
        'DgvSearchEmployeeID
        '
        Me.DgvSearchEmployeeID.HeaderText = "EmployeeID"
        Me.DgvSearchEmployeeID.Name = "DgvSearchEmployeeID"
        Me.DgvSearchEmployeeID.ReadOnly = True
        Me.DgvSearchEmployeeID.Visible = False
        Me.DgvSearchEmployeeID.Width = 87
        '
        'DgvSearchEmployeeName
        '
        Me.DgvSearchEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchEmployeeName.HeaderText = "Vet"
        Me.DgvSearchEmployeeName.Name = "DgvSearchEmployeeName"
        Me.DgvSearchEmployeeName.ReadOnly = True
        Me.DgvSearchEmployeeName.Width = 48
        '
        'DgvSearchCustomerID
        '
        Me.DgvSearchCustomerID.HeaderText = "CustomerID"
        Me.DgvSearchCustomerID.Name = "DgvSearchCustomerID"
        Me.DgvSearchCustomerID.ReadOnly = True
        Me.DgvSearchCustomerID.Visible = False
        Me.DgvSearchCustomerID.Width = 87
        '
        'DgvSearchCustomerName
        '
        Me.DgvSearchCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DgvSearchCustomerName.HeaderText = "Customer Name"
        Me.DgvSearchCustomerName.Name = "DgvSearchCustomerName"
        Me.DgvSearchCustomerName.ReadOnly = True
        '
        'DgvSearchPetName
        '
        Me.DgvSearchPetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchPetName.HeaderText = "Pet Name"
        Me.DgvSearchPetName.Name = "DgvSearchPetName"
        Me.DgvSearchPetName.ReadOnly = True
        Me.DgvSearchPetName.Width = 77
        '
        'DgvSearchIsCompleted
        '
        Me.DgvSearchIsCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchIsCompleted.HeaderText = "Status"
        Me.DgvSearchIsCompleted.Name = "DgvSearchIsCompleted"
        Me.DgvSearchIsCompleted.ReadOnly = True
        Me.DgvSearchIsCompleted.Width = 63
        '
        'DgvSearchIsWarded
        '
        Me.DgvSearchIsWarded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchIsWarded.HeaderText = "Warded?"
        Me.DgvSearchIsWarded.Name = "DgvSearchIsWarded"
        Me.DgvSearchIsWarded.ReadOnly = True
        Me.DgvSearchIsWarded.Width = 76
        '
        'DgvSearchCreatedBy
        '
        Me.DgvSearchCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchCreatedBy.HeaderText = "Created By"
        Me.DgvSearchCreatedBy.Name = "DgvSearchCreatedBy"
        Me.DgvSearchCreatedBy.ReadOnly = True
        Me.DgvSearchCreatedBy.Visible = False
        Me.DgvSearchCreatedBy.Width = 86
        '
        'DgvSearchDateCreated
        '
        Me.DgvSearchDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvSearchDateCreated.HeaderText = "Date Created"
        Me.DgvSearchDateCreated.Name = "DgvSearchDateCreated"
        Me.DgvSearchDateCreated.ReadOnly = True
        Me.DgvSearchDateCreated.Visible = False
        Me.DgvSearchDateCreated.Width = 95
        '
        'FrmSearchVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSearchVisit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Visit"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvVisit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents DgvVisit As DataGridView
    Friend WithEvents CbNotAssigned As CheckBox
    Friend WithEvents CbIsWarded As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbIsVisitCompleted As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvSearchVisitID As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchVisitTime As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchEmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchEmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchPetName As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchIsCompleted As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchIsWarded As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents DgvSearchDateCreated As DataGridViewTextBoxColumn
End Class
