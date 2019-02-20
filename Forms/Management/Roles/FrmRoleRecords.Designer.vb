<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoleRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoleRecords))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnAddNewRole = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvRoleListing = New System.Windows.Forms.DataGridView()
        Me.DgvBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RoleCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvRoleListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewRole)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(502, 68)
        Me.PnlActionBar.TabIndex = 74
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(237, 32)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Role Management"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(438, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(378, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'BtnAddNewRole
        '
        Me.BtnAddNewRole.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewRole.BackgroundImage = CType(resources.GetObject("BtnAddNewRole.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewRole.Location = New System.Drawing.Point(318, 4)
        Me.BtnAddNewRole.Name = "BtnAddNewRole"
        Me.BtnAddNewRole.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewRole.TabIndex = 2
        Me.BtnAddNewRole.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvRoleListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 387)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Role List"
        '
        'DgvRoleListing
        '
        Me.DgvRoleListing.AllowUserToAddRows = False
        Me.DgvRoleListing.AllowUserToDeleteRows = False
        Me.DgvRoleListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvRoleListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRoleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoleListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnDelete, Me.RoleCode, Me.RoleName})
        Me.DgvRoleListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRoleListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvRoleListing.Name = "DgvRoleListing"
        Me.DgvRoleListing.ReadOnly = True
        Me.DgvRoleListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRoleListing.Size = New System.Drawing.Size(496, 368)
        Me.DgvRoleListing.TabIndex = 0
        '
        'DgvBtnDelete
        '
        Me.DgvBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvBtnDelete.HeaderText = "Delete?"
        Me.DgvBtnDelete.Name = "DgvBtnDelete"
        Me.DgvBtnDelete.ReadOnly = True
        Me.DgvBtnDelete.Text = "Delete"
        Me.DgvBtnDelete.ToolTipText = "Delete Role?"
        Me.DgvBtnDelete.UseColumnTextForButtonValue = True
        Me.DgvBtnDelete.Width = 49
        '
        'RoleCode
        '
        Me.RoleCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RoleCode.HeaderText = "Role Code"
        Me.RoleCode.Name = "RoleCode"
        Me.RoleCode.ReadOnly = True
        Me.RoleCode.Width = 81
        '
        'RoleName
        '
        Me.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleName.HeaderText = "Role Description"
        Me.RoleName.Name = "RoleName"
        Me.RoleName.ReadOnly = True
        '
        'FrmRoleRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmRoleRecords"
        Me.Text = "Role Management"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvRoleListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnAddNewRole As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvRoleListing As DataGridView
    Friend WithEvents DgvBtnDelete As DataGridViewButtonColumn
    Friend WithEvents RoleCode As DataGridViewTextBoxColumn
    Friend WithEvents RoleName As DataGridViewTextBoxColumn
End Class
