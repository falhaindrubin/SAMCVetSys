﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreatmentRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTreatmentRecords))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.DgvTreatmentListing = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.VisitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsVisitCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvTreatmentListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(50, 27)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(319, 22)
        Me.TxtSearchText.TabIndex = 6
        '
        'DgvTreatmentListing
        '
        Me.DgvTreatmentListing.AllowUserToAddRows = False
        Me.DgvTreatmentListing.AllowUserToDeleteRows = False
        Me.DgvTreatmentListing.AllowUserToOrderColumns = True
        Me.DgvTreatmentListing.AllowUserToResizeRows = False
        Me.DgvTreatmentListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTreatmentListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvTreatmentListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvTreatmentListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTreatmentListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTreatmentListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitID, Me.VisitTime, Me.CustomerID, Me.CustomerName, Me.PetName, Me.EmployeeID, Me.EmployeeName, Me.IsVisitCompleted})
        Me.DgvTreatmentListing.Location = New System.Drawing.Point(8, 20)
        Me.DgvTreatmentListing.Name = "DgvTreatmentListing"
        Me.DgvTreatmentListing.ReadOnly = True
        Me.DgvTreatmentListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvTreatmentListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTreatmentListing.Size = New System.Drawing.Size(969, 584)
        Me.DgvTreatmentListing.TabIndex = 2
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewCustomer)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(985, 68)
        Me.PnlActionBar.TabIndex = 79
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(247, 32)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Treatment Records"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(921, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewCustomer.BackgroundImage = CType(resources.GetObject("BtnAddNewCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(799, 4)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewCustomer.TabIndex = 2
        Me.BtnAddNewCustomer.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(860, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvTreatmentListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 611)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Treatment Record List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtSearchText)
        Me.GroupBox2.Controls.Add(Me.BtnSearchCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(985, 74)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchCustomer.BackgroundImage = CType(resources.GetObject("BtnSearchCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(375, 12)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'VisitID
        '
        Me.VisitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VisitID.HeaderText = "Visit ID"
        Me.VisitID.Name = "VisitID"
        Me.VisitID.ReadOnly = True
        Me.VisitID.Width = 65
        '
        'VisitTime
        '
        Me.VisitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VisitTime.HeaderText = "Visit Time"
        Me.VisitTime.Name = "VisitTime"
        Me.VisitTime.ReadOnly = True
        Me.VisitTime.Width = 78
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Visible = False
        Me.CustomerID.Width = 87
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        '
        'PetName
        '
        Me.PetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PetName.HeaderText = "Pet Name"
        Me.PetName.Name = "PetName"
        Me.PetName.ReadOnly = True
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Visible = False
        Me.EmployeeID.Width = 87
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeName.HeaderText = "Vet"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        '
        'IsVisitCompleted
        '
        Me.IsVisitCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsVisitCompleted.HeaderText = "Status"
        Me.IsVisitCompleted.Name = "IsVisitCompleted"
        Me.IsVisitCompleted.ReadOnly = True
        Me.IsVisitCompleted.Width = 63
        '
        'FrmTreatmentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 784)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTreatmentRecords"
        Me.Text = "Treatment Records"
        CType(Me.DgvTreatmentListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents DgvTreatmentListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewCustomer As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents VisitID As DataGridViewTextBoxColumn
    Friend WithEvents VisitTime As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents PetName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents IsVisitCompleted As DataGridViewTextBoxColumn
End Class
