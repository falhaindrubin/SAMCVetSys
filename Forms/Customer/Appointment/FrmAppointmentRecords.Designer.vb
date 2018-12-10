<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppointmentRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppointmentRecords))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvAppoinmentListing = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewAppointment = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearchAppointment = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvAppoinmentListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvAppoinmentListing)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 556)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointment List"
        '
        'DgvAppoinmentListing
        '
        Me.DgvAppoinmentListing.AllowUserToAddRows = False
        Me.DgvAppoinmentListing.AllowUserToDeleteRows = False
        Me.DgvAppoinmentListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvAppoinmentListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvAppoinmentListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvAppoinmentListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvAppoinmentListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAppoinmentListing.Location = New System.Drawing.Point(9, 19)
        Me.DgvAppoinmentListing.MultiSelect = False
        Me.DgvAppoinmentListing.Name = "DgvAppoinmentListing"
        Me.DgvAppoinmentListing.ReadOnly = True
        Me.DgvAppoinmentListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAppoinmentListing.Size = New System.Drawing.Size(969, 531)
        Me.DgvAppoinmentListing.TabIndex = 0
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewAppointment)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 68)
        Me.PnlActionBar.TabIndex = 71
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(277, 32)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "Appointment Records"
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
        'BtnAddNewAppointment
        '
        Me.BtnAddNewAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewAppointment.BackgroundImage = CType(resources.GetObject("BtnAddNewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewAppointment.Location = New System.Drawing.Point(798, 4)
        Me.BtnAddNewAppointment.Name = "BtnAddNewAppointment"
        Me.BtnAddNewAppointment.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewAppointment.TabIndex = 2
        Me.BtnAddNewAppointment.UseVisualStyleBackColor = False
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
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtSearchText)
        Me.GroupBox4.Controls.Add(Me.BtnSearchAppointment)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(984, 69)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Search"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(50, 24)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(357, 26)
        Me.TxtSearchText.TabIndex = 6
        '
        'BtnSearchAppointment
        '
        Me.BtnSearchAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchAppointment.BackgroundImage = CType(resources.GetObject("BtnSearchAppointment.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchAppointment.Location = New System.Drawing.Point(413, 9)
        Me.BtnSearchAppointment.Name = "BtnSearchAppointment"
        Me.BtnSearchAppointment.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearchAppointment.TabIndex = 5
        Me.BtnSearchAppointment.UseVisualStyleBackColor = False
        '
        'FrmAppointmentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "FrmAppointmentRecords"
        Me.Text = "Appointment Records"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvAppoinmentListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvAppoinmentListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewAppointment As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchAppointment As Button
    Friend WithEvents Label25 As Label
End Class
