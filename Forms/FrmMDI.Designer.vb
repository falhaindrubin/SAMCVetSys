<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMDI
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
        Me.components = New System.ComponentModel.Container()
        Me.MStripMain = New System.Windows.Forms.MenuStrip()
        Me.MnuCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVisit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAppointment = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTreatment = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSurgery = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuWard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPharmacy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBilling = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRoles = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProductServices = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuManagementSurgery = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.MStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MStripMain
        '
        Me.MStripMain.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCustomer, Me.MnuTreatment, Me.MnuSurgery, Me.MnuWard, Me.MnuPharmacy, Me.MnuBilling, Me.MnuManagement, Me.MnuWindow})
        Me.MStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MStripMain.MdiWindowListItem = Me.MnuWindow
        Me.MStripMain.Name = "MStripMain"
        Me.MStripMain.Size = New System.Drawing.Size(951, 24)
        Me.MStripMain.TabIndex = 1
        Me.MStripMain.Text = "MenuStrip1"
        '
        'MnuCustomer
        '
        Me.MnuCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuRegister, Me.MnuVisit, Me.MnuAppointment})
        Me.MnuCustomer.Name = "MnuCustomer"
        Me.MnuCustomer.Size = New System.Drawing.Size(56, 20)
        Me.MnuCustomer.Text = "Student"
        '
        'MnuRegister
        '
        Me.MnuRegister.Name = "MnuRegister"
        Me.MnuRegister.Size = New System.Drawing.Size(180, 22)
        Me.MnuRegister.Text = "Register"
        '
        'MnuVisit
        '
        Me.MnuVisit.Name = "MnuVisit"
        Me.MnuVisit.Size = New System.Drawing.Size(180, 22)
        Me.MnuVisit.Text = "Visit"
        Me.MnuVisit.Visible = False
        '
        'MnuAppointment
        '
        Me.MnuAppointment.Name = "MnuAppointment"
        Me.MnuAppointment.Size = New System.Drawing.Size(180, 22)
        Me.MnuAppointment.Text = "Appointment"
        Me.MnuAppointment.Visible = False
        '
        'MnuTreatment
        '
        Me.MnuTreatment.Name = "MnuTreatment"
        Me.MnuTreatment.Size = New System.Drawing.Size(67, 20)
        Me.MnuTreatment.Text = "Treatment"
        '
        'MnuSurgery
        '
        Me.MnuSurgery.Name = "MnuSurgery"
        Me.MnuSurgery.Size = New System.Drawing.Size(58, 20)
        Me.MnuSurgery.Text = "Surgery"
        '
        'MnuWard
        '
        Me.MnuWard.Name = "MnuWard"
        Me.MnuWard.Size = New System.Drawing.Size(45, 20)
        Me.MnuWard.Text = "Ward"
        '
        'MnuPharmacy
        '
        Me.MnuPharmacy.Name = "MnuPharmacy"
        Me.MnuPharmacy.Size = New System.Drawing.Size(67, 20)
        Me.MnuPharmacy.Text = "Pharmacy"
        '
        'MnuBilling
        '
        Me.MnuBilling.Name = "MnuBilling"
        Me.MnuBilling.Size = New System.Drawing.Size(46, 20)
        Me.MnuBilling.Text = "Billing"
        '
        'MnuManagement
        '
        Me.MnuManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEmployee, Me.MnuUser, Me.MnuRoles, Me.MnuProductServices, Me.MnuManagementSurgery})
        Me.MnuManagement.Name = "MnuManagement"
        Me.MnuManagement.Size = New System.Drawing.Size(80, 20)
        Me.MnuManagement.Text = "Management"
        '
        'MnuEmployee
        '
        Me.MnuEmployee.Name = "MnuEmployee"
        Me.MnuEmployee.Size = New System.Drawing.Size(173, 22)
        Me.MnuEmployee.Text = "Employee"
        '
        'MnuUser
        '
        Me.MnuUser.Name = "MnuUser"
        Me.MnuUser.Size = New System.Drawing.Size(173, 22)
        Me.MnuUser.Text = "User"
        '
        'MnuRoles
        '
        Me.MnuRoles.Name = "MnuRoles"
        Me.MnuRoles.Size = New System.Drawing.Size(173, 22)
        Me.MnuRoles.Text = "Roles"
        '
        'MnuProductServices
        '
        Me.MnuProductServices.Name = "MnuProductServices"
        Me.MnuProductServices.Size = New System.Drawing.Size(173, 22)
        Me.MnuProductServices.Text = "Products && Services"
        '
        'MnuManagementSurgery
        '
        Me.MnuManagementSurgery.Name = "MnuManagementSurgery"
        Me.MnuManagementSurgery.Size = New System.Drawing.Size(173, 22)
        Me.MnuManagementSurgery.Text = "Surgery"
        '
        'MnuWindow
        '
        Me.MnuWindow.Name = "MnuWindow"
        Me.MnuWindow.Size = New System.Drawing.Size(59, 20)
        Me.MnuWindow.Text = "Window"
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1000
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 546)
        Me.Controls.Add(Me.MStripMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MStripMain
        Me.Name = "FrmMDI"
        Me.Text = "School Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MStripMain.ResumeLayout(False)
        Me.MStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MStripMain As MenuStrip
    Friend WithEvents MnuCustomer As ToolStripMenuItem
    Friend WithEvents MnuRegister As ToolStripMenuItem
    Friend WithEvents MnuTreatment As ToolStripMenuItem
    Friend WithEvents MnuWard As ToolStripMenuItem
    Friend WithEvents MnuManagement As ToolStripMenuItem
    Friend WithEvents MnuWindow As ToolStripMenuItem
    Friend WithEvents MnuEmployee As ToolStripMenuItem
    Friend WithEvents MnuUser As ToolStripMenuItem
    Friend WithEvents MnuVisit As ToolStripMenuItem
    Friend WithEvents MnuProductServices As ToolStripMenuItem
    Friend WithEvents MnuAppointment As ToolStripMenuItem
    Friend WithEvents MnuBilling As ToolStripMenuItem
    Friend WithEvents MnuSurgery As ToolStripMenuItem
    Friend WithEvents MnuRoles As ToolStripMenuItem
    Friend WithEvents MnuPharmacy As ToolStripMenuItem
    Friend WithEvents MnuManagementSurgery As ToolStripMenuItem
    Friend WithEvents TimerMain As Timer
End Class
