<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWardRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWardRecords))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewWard = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.DgvWardListing = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.CbIsDischarged = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.WardID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetCase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDischarged = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DischargeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar.SuspendLayout()
        CType(Me.DgvWardListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label2)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewWard)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(1161, 68)
        Me.PnlActionBar.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ward Records"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(1097, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewWard
        '
        Me.BtnAddNewWard.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewWard.BackgroundImage = CType(resources.GetObject("BtnAddNewWard.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewWard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewWard.Location = New System.Drawing.Point(975, 4)
        Me.BtnAddNewWard.Name = "BtnAddNewWard"
        Me.BtnAddNewWard.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewWard.TabIndex = 2
        Me.BtnAddNewWard.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(1036, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Keyword"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(62, 29)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(319, 26)
        Me.TxtSearchText.TabIndex = 6
        '
        'DgvWardListing
        '
        Me.DgvWardListing.AllowUserToAddRows = False
        Me.DgvWardListing.AllowUserToDeleteRows = False
        Me.DgvWardListing.AllowUserToOrderColumns = True
        Me.DgvWardListing.AllowUserToResizeRows = False
        Me.DgvWardListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvWardListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvWardListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvWardListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvWardListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvWardListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardID, Me.AdmissionDate, Me.CustomerID, Me.CustomerName, Me.PetName, Me.PetCase, Me.IsDischarged, Me.DischargeDate})
        Me.DgvWardListing.Location = New System.Drawing.Point(8, 20)
        Me.DgvWardListing.Name = "DgvWardListing"
        Me.DgvWardListing.ReadOnly = True
        Me.DgvWardListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvWardListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvWardListing.Size = New System.Drawing.Size(1146, 525)
        Me.DgvWardListing.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvWardListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1161, 552)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ward Records List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtSearchText)
        Me.GroupBox2.Controls.Add(Me.BtnSearchCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 80)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Ward"
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchCustomer.BackgroundImage = CType(resources.GetObject("BtnSearchCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(383, 15)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(55, 55)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'CbIsDischarged
        '
        Me.CbIsDischarged.AutoSize = True
        Me.CbIsDischarged.Location = New System.Drawing.Point(10, 30)
        Me.CbIsDischarged.Name = "CbIsDischarged"
        Me.CbIsDischarged.Size = New System.Drawing.Size(81, 18)
        Me.CbIsDischarged.TabIndex = 8
        Me.CbIsDischarged.Text = "Discharged"
        Me.CbIsDischarged.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CbIsDischarged)
        Me.GroupBox3.Location = New System.Drawing.Point(464, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 80)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ward Status"
        '
        'WardID
        '
        Me.WardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.WardID.HeaderText = "Ward ID"
        Me.WardID.Name = "WardID"
        Me.WardID.ReadOnly = True
        Me.WardID.Width = 70
        '
        'AdmissionDate
        '
        Me.AdmissionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AdmissionDate.HeaderText = "Admission Date"
        Me.AdmissionDate.Name = "AdmissionDate"
        Me.AdmissionDate.ReadOnly = True
        Me.AdmissionDate.Width = 107
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Visible = False
        Me.CustomerID.Width = 90
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CustomerName.HeaderText = "CustomerName"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 105
        '
        'PetName
        '
        Me.PetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PetName.HeaderText = "PetName"
        Me.PetName.Name = "PetName"
        Me.PetName.ReadOnly = True
        Me.PetName.Width = 74
        '
        'PetCase
        '
        Me.PetCase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PetCase.HeaderText = "PetCase"
        Me.PetCase.Name = "PetCase"
        Me.PetCase.ReadOnly = True
        '
        'IsDischarged
        '
        Me.IsDischarged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsDischarged.HeaderText = "Discharged?"
        Me.IsDischarged.Name = "IsDischarged"
        Me.IsDischarged.ReadOnly = True
        Me.IsDischarged.Width = 93
        '
        'DischargeDate
        '
        Me.DischargeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DischargeDate.HeaderText = "Discharge Date"
        Me.DischargeDate.Name = "DischargeDate"
        Me.DischargeDate.ReadOnly = True
        Me.DischargeDate.Width = 106
        '
        'FrmWardRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 736)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmWardRecords"
        Me.Text = "Ward Records"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        CType(Me.DgvWardListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewWard As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents DgvWardListing As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CbIsDischarged As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents WardID As DataGridViewTextBoxColumn
    Friend WithEvents AdmissionDate As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents PetName As DataGridViewTextBoxColumn
    Friend WithEvents PetCase As DataGridViewTextBoxColumn
    Friend WithEvents IsDischarged As DataGridViewTextBoxColumn
    Friend WithEvents DischargeDate As DataGridViewTextBoxColumn
End Class
