<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemManagement))
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.DgvCustomerListing = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvCustomerListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchCustomer.BackgroundImage = CType(resources.GetObject("BtnSearchCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(731, 3)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(60, 52)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'DgvCustomerListing
        '
        Me.DgvCustomerListing.AllowUserToAddRows = False
        Me.DgvCustomerListing.AllowUserToDeleteRows = False
        Me.DgvCustomerListing.AllowUserToOrderColumns = True
        Me.DgvCustomerListing.AllowUserToResizeRows = False
        Me.DgvCustomerListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCustomerListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvCustomerListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvCustomerListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCustomerListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomerListing.Location = New System.Drawing.Point(8, 19)
        Me.DgvCustomerListing.Name = "DgvCustomerListing"
        Me.DgvCustomerListing.ReadOnly = True
        Me.DgvCustomerListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvCustomerListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCustomerListing.Size = New System.Drawing.Size(970, 655)
        Me.DgvCustomerListing.TabIndex = 2
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewCustomer)
        Me.PnlActionBar.Controls.Add(Me.BtnSearchCustomer)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(985, 57)
        Me.PnlActionBar.TabIndex = 73
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(919, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 52)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewCustomer.BackgroundImage = CType(resources.GetObject("BtnAddNewCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(797, 3)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(60, 52)
        Me.BtnAddNewCustomer.TabIndex = 2
        Me.BtnAddNewCustomer.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(858, 3)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 52)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvCustomerListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 680)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products && Services Listing"
        '
        'FrmItemManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 767)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmItemManagement"
        Me.Text = "Item Management"
        CType(Me.DgvCustomerListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents DgvCustomerListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewCustomer As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
