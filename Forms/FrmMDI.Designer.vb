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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreatmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurgeryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRecord, Me.TreatmentToolStripMenuItem, Me.SurgeryToolStripMenuItem, Me.WardToolStripMenuItem, Me.BillingToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuRecord
        '
        Me.mnuRecord.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientRegistrationToolStripMenuItem, Me.ConsultationToolStripMenuItem, Me.AppointmentToolStripMenuItem})
        Me.mnuRecord.Name = "mnuRecord"
        Me.mnuRecord.Size = New System.Drawing.Size(65, 20)
        Me.mnuRecord.Text = "Customer"
        '
        'ClientRegistrationToolStripMenuItem
        '
        Me.ClientRegistrationToolStripMenuItem.Name = "ClientRegistrationToolStripMenuItem"
        Me.ClientRegistrationToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClientRegistrationToolStripMenuItem.Text = "Register"
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ConsultationToolStripMenuItem.Text = "Visit"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'TreatmentToolStripMenuItem
        '
        Me.TreatmentToolStripMenuItem.Name = "TreatmentToolStripMenuItem"
        Me.TreatmentToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TreatmentToolStripMenuItem.Text = "Examination"
        '
        'SurgeryToolStripMenuItem
        '
        Me.SurgeryToolStripMenuItem.Name = "SurgeryToolStripMenuItem"
        Me.SurgeryToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SurgeryToolStripMenuItem.Text = "Surgery"
        '
        'WardToolStripMenuItem
        '
        Me.WardToolStripMenuItem.Name = "WardToolStripMenuItem"
        Me.WardToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.WardToolStripMenuItem.Text = "Ward"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeUserToolStripMenuItem, Me.UserToolStripMenuItem, Me.ProductsServicesToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Management"
        '
        'EmployeeUserToolStripMenuItem
        '
        Me.EmployeeUserToolStripMenuItem.Name = "EmployeeUserToolStripMenuItem"
        Me.EmployeeUserToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EmployeeUserToolStripMenuItem.Text = "Employee"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ProductsServicesToolStripMenuItem
        '
        Me.ProductsServicesToolStripMenuItem.Name = "ProductsServicesToolStripMenuItem"
        Me.ProductsServicesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProductsServicesToolStripMenuItem.Text = "Products && Services"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 546)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "SAMC Veterinary System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuRecord As ToolStripMenuItem
    Friend WithEvents ClientRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreatmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SurgeryToolStripMenuItem As ToolStripMenuItem
End Class
