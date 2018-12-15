<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPharmacyRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPharmacyRecords))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvPharmacyRecords = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPharmacyRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 68)
        Me.PnlActionBar.TabIndex = 77
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(246, 32)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Pharmacy Records"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(919, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnAddNewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewCustomer.BackgroundImage = CType(resources.GetObject("BtnAddNewCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(797, 4)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewCustomer.TabIndex = 2
        Me.BtnAddNewCustomer.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(858, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvPharmacyRecords)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 630)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pharmacy Request List"
        '
        'DgvPharmacyRecords
        '
        Me.DgvPharmacyRecords.AllowUserToAddRows = False
        Me.DgvPharmacyRecords.AllowUserToDeleteRows = False
        Me.DgvPharmacyRecords.BackgroundColor = System.Drawing.Color.White
        Me.DgvPharmacyRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPharmacyRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPharmacyRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPharmacyRecords.Location = New System.Drawing.Point(3, 16)
        Me.DgvPharmacyRecords.MultiSelect = False
        Me.DgvPharmacyRecords.Name = "DgvPharmacyRecords"
        Me.DgvPharmacyRecords.ReadOnly = True
        Me.DgvPharmacyRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPharmacyRecords.Size = New System.Drawing.Size(978, 611)
        Me.DgvPharmacyRecords.TabIndex = 0
        '
        'FrmPharmacyRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPharmacyRecords"
        Me.Text = "Pharmacy Records"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvPharmacyRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewCustomer As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvPharmacyRecords As DataGridView
End Class
