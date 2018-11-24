<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserInformation))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnSearchEmployee = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnAddNewAppointment = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbUserRole = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRetypePassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUserPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.PnlActionBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Controls.Add(Me.BtnSearchEmployee)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewAppointment)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(776, 68)
        Me.PnlActionBar.TabIndex = 74
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(590, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 79
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnSearchEmployee
        '
        Me.BtnSearchEmployee.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchEmployee.BackgroundImage = CType(resources.GetObject("BtnSearchEmployee.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchEmployee.Location = New System.Drawing.Point(468, 4)
        Me.BtnSearchEmployee.Name = "BtnSearchEmployee"
        Me.BtnSearchEmployee.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearchEmployee.TabIndex = 78
        Me.BtnSearchEmployee.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(215, 32)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "User Information"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddNewAppointment
        '
        Me.BtnAddNewAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNewAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewAppointment.BackgroundImage = CType(resources.GetObject("BtnAddNewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewAppointment.Location = New System.Drawing.Point(529, 4)
        Me.BtnAddNewAppointment.Name = "BtnAddNewAppointment"
        Me.BtnAddNewAppointment.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewAppointment.TabIndex = 2
        Me.BtnAddNewAppointment.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(712, 4)
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
        Me.BtnReload.Location = New System.Drawing.Point(651, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 93)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 313)
        Me.TabControl1.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbUserRole)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtRetypePassword)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtUserPassword)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtUserID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Information"
        '
        'CmbUserRole
        '
        Me.CmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserRole.FormattingEnabled = True
        Me.CmbUserRole.Location = New System.Drawing.Point(103, 92)
        Me.CmbUserRole.Name = "CmbUserRole"
        Me.CmbUserRole.Size = New System.Drawing.Size(163, 22)
        Me.CmbUserRole.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "User Role"
        '
        'TxtRetypePassword
        '
        Me.TxtRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRetypePassword.Location = New System.Drawing.Point(103, 71)
        Me.TxtRetypePassword.Name = "TxtRetypePassword"
        Me.TxtRetypePassword.Size = New System.Drawing.Size(320, 20)
        Me.TxtRetypePassword.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Re-type Password"
        '
        'TxtUserPassword
        '
        Me.TxtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserPassword.Location = New System.Drawing.Point(103, 50)
        Me.TxtUserPassword.Name = "TxtUserPassword"
        Me.TxtUserPassword.Size = New System.Drawing.Size(320, 20)
        Me.TxtUserPassword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password"
        '
        'TxtUserID
        '
        Me.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserID.Location = New System.Drawing.Point(103, 29)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(320, 20)
        Me.TxtUserID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPosition)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtEmployeeName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'TxtPosition
        '
        Me.TxtPosition.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPosition.Location = New System.Drawing.Point(103, 43)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.ReadOnly = True
        Me.TxtPosition.Size = New System.Drawing.Size(320, 20)
        Me.TxtPosition.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Position"
        '
        'TxtEmployeeName
        '
        Me.TxtEmployeeName.BackColor = System.Drawing.SystemColors.Info
        Me.TxtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmployeeName.Location = New System.Drawing.Point(103, 22)
        Me.TxtEmployeeName.Name = "TxtEmployeeName"
        Me.TxtEmployeeName.ReadOnly = True
        Me.TxtEmployeeName.Size = New System.Drawing.Size(320, 20)
        Me.TxtEmployeeName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDateModified)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TxtDateCreated)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TxtModifiedBy)
        Me.Panel3.Location = New System.Drawing.Point(12, 412)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 61)
        Me.Panel3.TabIndex = 83
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 10)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateModified.Location = New System.Drawing.Point(142, 31)
        Me.TxtDateModified.Name = "TxtDateModified"
        Me.TxtDateModified.ReadOnly = True
        Me.TxtDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateModified.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Created By"
        '
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateCreated.Location = New System.Drawing.Point(142, 10)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Modified By"
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 31)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'FrmUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmUserInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnAddNewAppointment As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSearchEmployee As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEmployeeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPosition As TextBox
    Friend WithEvents TxtUserPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRetypePassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbUserRole As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtModifiedBy As TextBox
End Class
