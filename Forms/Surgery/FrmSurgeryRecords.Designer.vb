﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSurgeryRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSurgeryRecords))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewSurgery = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvSurgeryListing = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvSurgeryListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewSurgery)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(1199, 68)
        Me.PnlActionBar.TabIndex = 80
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(220, 32)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Surgery Records"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(1133, 6)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewSurgery
        '
        Me.BtnAddNewSurgery.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewSurgery.BackgroundImage = CType(resources.GetObject("BtnAddNewSurgery.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewSurgery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewSurgery.Location = New System.Drawing.Point(1011, 6)
        Me.BtnAddNewSurgery.Name = "BtnAddNewSurgery"
        Me.BtnAddNewSurgery.Size = New System.Drawing.Size(60, 56)
        Me.BtnAddNewSurgery.TabIndex = 2
        Me.BtnAddNewSurgery.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(1072, 6)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 56)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvSurgeryListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1199, 551)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Surgery Record List"
        '
        'DgvSurgeryListing
        '
        Me.DgvSurgeryListing.AllowUserToAddRows = False
        Me.DgvSurgeryListing.AllowUserToDeleteRows = False
        Me.DgvSurgeryListing.AllowUserToOrderColumns = True
        Me.DgvSurgeryListing.AllowUserToResizeRows = False
        Me.DgvSurgeryListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvSurgeryListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvSurgeryListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSurgeryListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSurgeryListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSurgeryListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvSurgeryListing.Name = "DgvSurgeryListing"
        Me.DgvSurgeryListing.ReadOnly = True
        Me.DgvSurgeryListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvSurgeryListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSurgeryListing.Size = New System.Drawing.Size(1193, 532)
        Me.DgvSurgeryListing.TabIndex = 2
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
        Me.GroupBox2.Size = New System.Drawing.Size(1199, 74)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
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
        'FrmSurgeryRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSurgeryRecords"
        Me.Text = "Surgery Records"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvSurgeryListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewSurgery As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvSurgeryListing As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchCustomer As Button
End Class
