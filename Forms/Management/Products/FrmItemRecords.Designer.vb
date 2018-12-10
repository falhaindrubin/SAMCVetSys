<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemRecords))
        Me.DgvItemListing = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewItem = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbProducts = New System.Windows.Forms.RadioButton()
        Me.RbServices = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvItemListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvItemListing
        '
        Me.DgvItemListing.AllowUserToAddRows = False
        Me.DgvItemListing.AllowUserToDeleteRows = False
        Me.DgvItemListing.AllowUserToOrderColumns = True
        Me.DgvItemListing.AllowUserToResizeRows = False
        Me.DgvItemListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvItemListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvItemListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvItemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItemListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvItemListing.Name = "DgvItemListing"
        Me.DgvItemListing.ReadOnly = True
        Me.DgvItemListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvItemListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItemListing.Size = New System.Drawing.Size(979, 553)
        Me.DgvItemListing.TabIndex = 2
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewItem)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(985, 68)
        Me.PnlActionBar.TabIndex = 73
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(178, 32)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Item Records"
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
        'BtnAddNewItem
        '
        Me.BtnAddNewItem.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewItem.BackgroundImage = CType(resources.GetObject("BtnAddNewItem.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewItem.Location = New System.Drawing.Point(799, 4)
        Me.BtnAddNewItem.Name = "BtnAddNewItem"
        Me.BtnAddNewItem.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewItem.TabIndex = 2
        Me.BtnAddNewItem.UseVisualStyleBackColor = False
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
        Me.GroupBox1.Controls.Add(Me.RbProducts)
        Me.GroupBox1.Controls.Add(Me.RbServices)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 91)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Products && Services"
        '
        'RbProducts
        '
        Me.RbProducts.AutoSize = True
        Me.RbProducts.Location = New System.Drawing.Point(95, 24)
        Me.RbProducts.Name = "RbProducts"
        Me.RbProducts.Size = New System.Drawing.Size(68, 18)
        Me.RbProducts.TabIndex = 8
        Me.RbProducts.Text = "Products"
        Me.RbProducts.UseVisualStyleBackColor = True
        '
        'RbServices
        '
        Me.RbServices.AutoSize = True
        Me.RbServices.Checked = True
        Me.RbServices.Location = New System.Drawing.Point(13, 24)
        Me.RbServices.Name = "RbServices"
        Me.RbServices.Size = New System.Drawing.Size(68, 18)
        Me.RbServices.TabIndex = 7
        Me.RbServices.TabStop = True
        Me.RbServices.Text = "Services"
        Me.RbServices.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(301, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvItemListing)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(985, 572)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service && Product Listing"
        '
        'FrmItemRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 767)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmItemRecords"
        Me.Text = "Item Records"
        CType(Me.DgvItemListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvItemListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewItem As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RbProducts As RadioButton
    Friend WithEvents RbServices As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label25 As Label
End Class
