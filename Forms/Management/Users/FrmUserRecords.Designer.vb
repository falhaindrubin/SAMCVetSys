<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserRecords))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewUser = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvUserListing = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvUserListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewUser)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 68)
        Me.PnlActionBar.TabIndex = 74
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(182, 32)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "User Records"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(920, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewUser
        '
        Me.BtnAddNewUser.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewUser.BackgroundImage = CType(resources.GetObject("BtnAddNewUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewUser.Location = New System.Drawing.Point(798, 4)
        Me.BtnAddNewUser.Name = "BtnAddNewUser"
        Me.BtnAddNewUser.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewUser.TabIndex = 2
        Me.BtnAddNewUser.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(859, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvUserListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 599)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Listing"
        '
        'DgvUserListing
        '
        Me.DgvUserListing.AllowUserToAddRows = False
        Me.DgvUserListing.AllowUserToDeleteRows = False
        Me.DgvUserListing.AllowUserToOrderColumns = True
        Me.DgvUserListing.AllowUserToResizeRows = False
        Me.DgvUserListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvUserListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvUserListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUserListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUserListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvUserListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvUserListing.Name = "DgvUserListing"
        Me.DgvUserListing.ReadOnly = True
        Me.DgvUserListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvUserListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUserListing.Size = New System.Drawing.Size(978, 580)
        Me.DgvUserListing.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtSearchText)
        Me.GroupBox2.Controls.Add(Me.BtnSearchCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 79)
        Me.GroupBox2.TabIndex = 76
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
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(50, 25)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(321, 26)
        Me.TxtSearchText.TabIndex = 6
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchCustomer.BackgroundImage = CType(resources.GetObject("BtnSearchCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(377, 9)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'FrmUserRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 785)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmUserRecords"
        Me.Text = "System User Records"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvUserListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewUser As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvUserListing As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchCustomer As Button
End Class
