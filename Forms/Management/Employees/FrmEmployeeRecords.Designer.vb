<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmployeeRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployeeRecords))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearchAppointment = New System.Windows.Forms.Button()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnAddNewEmployee = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvEmployeeListing = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvEmployeeListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtSearchText)
        Me.GroupBox4.Controls.Add(Me.BtnSearchAppointment)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1008, 85)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Search"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(50, 33)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(216, 22)
        Me.TxtSearchText.TabIndex = 6
        '
        'BtnSearchAppointment
        '
        Me.BtnSearchAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchAppointment.BackgroundImage = CType(resources.GetObject("BtnSearchAppointment.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchAppointment.Location = New System.Drawing.Point(270, 16)
        Me.BtnSearchAppointment.Name = "BtnSearchAppointment"
        Me.BtnSearchAppointment.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearchAppointment.TabIndex = 5
        Me.BtnSearchAppointment.UseVisualStyleBackColor = False
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewEmployee)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(1008, 68)
        Me.PnlActionBar.TabIndex = 73
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(245, 32)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Employee Records"
        '
        'BtnAddNewEmployee
        '
        Me.BtnAddNewEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNewEmployee.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewEmployee.BackgroundImage = CType(resources.GetObject("BtnAddNewEmployee.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewEmployee.Location = New System.Drawing.Point(822, 4)
        Me.BtnAddNewEmployee.Name = "BtnAddNewEmployee"
        Me.BtnAddNewEmployee.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewEmployee.TabIndex = 2
        Me.BtnAddNewEmployee.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(944, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(883, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvEmployeeListing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 557)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Listing"
        '
        'DgvEmployeeListing
        '
        Me.DgvEmployeeListing.AllowUserToAddRows = False
        Me.DgvEmployeeListing.AllowUserToDeleteRows = False
        Me.DgvEmployeeListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmployeeListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmployeeListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEmployeeListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvEmployeeListing.Name = "DgvEmployeeListing"
        Me.DgvEmployeeListing.ReadOnly = True
        Me.DgvEmployeeListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmployeeListing.Size = New System.Drawing.Size(1002, 538)
        Me.DgvEmployeeListing.TabIndex = 0
        '
        'FrmEmployeeRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 747)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmEmployeeRecords"
        Me.Text = "Employee Management"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvEmployeeListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearchAppointment As Button
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewEmployee As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvEmployeeListing As DataGridView
End Class
