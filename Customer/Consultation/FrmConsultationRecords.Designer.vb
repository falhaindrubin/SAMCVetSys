<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultationRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultationRecords))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.DgvConsultationListing = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewConsultation = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvConsultationListing, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TxtSearchText.Size = New System.Drawing.Size(216, 22)
        Me.TxtSearchText.TabIndex = 6
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchCustomer.BackgroundImage = CType(resources.GetObject("BtnSearchCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(270, 12)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.UseVisualStyleBackColor = False
        '
        'DgvConsultationListing
        '
        Me.DgvConsultationListing.AllowUserToAddRows = False
        Me.DgvConsultationListing.AllowUserToDeleteRows = False
        Me.DgvConsultationListing.AllowUserToOrderColumns = True
        Me.DgvConsultationListing.AllowUserToResizeRows = False
        Me.DgvConsultationListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvConsultationListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvConsultationListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvConsultationListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvConsultationListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultationListing.Location = New System.Drawing.Point(9, 20)
        Me.DgvConsultationListing.Name = "DgvConsultationListing"
        Me.DgvConsultationListing.ReadOnly = True
        Me.DgvConsultationListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvConsultationListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultationListing.Size = New System.Drawing.Size(969, 528)
        Me.DgvConsultationListing.TabIndex = 2
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewConsultation)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 61)
        Me.PnlActionBar.TabIndex = 73
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(919, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewConsultation
        '
        Me.BtnAddNewConsultation.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewConsultation.BackgroundImage = CType(resources.GetObject("BtnAddNewConsultation.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewConsultation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewConsultation.Location = New System.Drawing.Point(797, 2)
        Me.BtnAddNewConsultation.Name = "BtnAddNewConsultation"
        Me.BtnAddNewConsultation.Size = New System.Drawing.Size(60, 56)
        Me.BtnAddNewConsultation.TabIndex = 2
        Me.BtnAddNewConsultation.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(858, 2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 56)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvConsultationListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 555)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultation List"
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
        Me.GroupBox2.Size = New System.Drawing.Size(984, 74)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'FrmConsultationRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmConsultationRecords"
        Me.Text = "Consultation Records"
        CType(Me.DgvConsultationListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchCustomer As Button
    Friend WithEvents DgvConsultationListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewConsultation As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
