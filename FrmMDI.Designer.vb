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
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAppointment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreatmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicationHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardExaminationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreatmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DischargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurgeryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreSurgeryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DischargeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoryManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadiologyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadiologyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PharmacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRecord, Me.mnuAppointment, Me.ExaminationToolStripMenuItem, Me.TreatmentToolStripMenuItem, Me.WardToolStripMenuItem, Me.BillingToolStripMenuItem, Me.SurgeryToolStripMenuItem, Me.LaboratoryToolStripMenuItem1, Me.RadiologyToolStripMenuItem, Me.PharmacyToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuRecord
        '
        Me.mnuRecord.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientRegistrationToolStripMenuItem, Me.AppointmentToolStripMenuItem, Me.ConsultationToolStripMenuItem, Me.PaymentToolStripMenuItem})
        Me.mnuRecord.Name = "mnuRecord"
        Me.mnuRecord.Size = New System.Drawing.Size(65, 20)
        Me.mnuRecord.Text = "Customer"
        '
        'ClientRegistrationToolStripMenuItem
        '
        Me.ClientRegistrationToolStripMenuItem.Name = "ClientRegistrationToolStripMenuItem"
        Me.ClientRegistrationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientRegistrationToolStripMenuItem.Text = "Register"
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultationToolStripMenuItem.Text = "Visit"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'mnuAppointment
        '
        Me.mnuAppointment.Name = "mnuAppointment"
        Me.mnuAppointment.Size = New System.Drawing.Size(79, 20)
        Me.mnuAppointment.Text = "Appointment"
        '
        'ExaminationToolStripMenuItem
        '
        Me.ExaminationToolStripMenuItem.Name = "ExaminationToolStripMenuItem"
        Me.ExaminationToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ExaminationToolStripMenuItem.Text = "Examination"
        '
        'TreatmentToolStripMenuItem
        '
        Me.TreatmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicalHistoryToolStripMenuItem, Me.MedicationHistoryToolStripMenuItem, Me.AnimalInfoToolStripMenuItem})
        Me.TreatmentToolStripMenuItem.Name = "TreatmentToolStripMenuItem"
        Me.TreatmentToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TreatmentToolStripMenuItem.Text = "Treatment"
        '
        'MedicalHistoryToolStripMenuItem
        '
        Me.MedicalHistoryToolStripMenuItem.Name = "MedicalHistoryToolStripMenuItem"
        Me.MedicalHistoryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MedicalHistoryToolStripMenuItem.Text = "Treatment Record"
        '
        'MedicationHistoryToolStripMenuItem
        '
        Me.MedicationHistoryToolStripMenuItem.Name = "MedicationHistoryToolStripMenuItem"
        Me.MedicationHistoryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MedicationHistoryToolStripMenuItem.Text = "Medication History"
        '
        'AnimalInfoToolStripMenuItem
        '
        Me.AnimalInfoToolStripMenuItem.Name = "AnimalInfoToolStripMenuItem"
        Me.AnimalInfoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AnimalInfoToolStripMenuItem.Text = "Animal Info"
        '
        'WardToolStripMenuItem
        '
        Me.WardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WardExaminationToolStripMenuItem, Me.FindingsToolStripMenuItem, Me.LaboratoryToolStripMenuItem, Me.TreatmentToolStripMenuItem1, Me.DischargeToolStripMenuItem})
        Me.WardToolStripMenuItem.Name = "WardToolStripMenuItem"
        Me.WardToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.WardToolStripMenuItem.Text = "Ward"
        '
        'WardExaminationToolStripMenuItem
        '
        Me.WardExaminationToolStripMenuItem.Name = "WardExaminationToolStripMenuItem"
        Me.WardExaminationToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.WardExaminationToolStripMenuItem.Text = "Ward Examination"
        '
        'FindingsToolStripMenuItem
        '
        Me.FindingsToolStripMenuItem.Name = "FindingsToolStripMenuItem"
        Me.FindingsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FindingsToolStripMenuItem.Text = "Findings"
        '
        'LaboratoryToolStripMenuItem
        '
        Me.LaboratoryToolStripMenuItem.Name = "LaboratoryToolStripMenuItem"
        Me.LaboratoryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LaboratoryToolStripMenuItem.Text = "Laboratory"
        '
        'TreatmentToolStripMenuItem1
        '
        Me.TreatmentToolStripMenuItem1.Name = "TreatmentToolStripMenuItem1"
        Me.TreatmentToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.TreatmentToolStripMenuItem1.Text = "Treatment"
        '
        'DischargeToolStripMenuItem
        '
        Me.DischargeToolStripMenuItem.Name = "DischargeToolStripMenuItem"
        Me.DischargeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DischargeToolStripMenuItem.Text = "Discharge"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'SurgeryToolStripMenuItem
        '
        Me.SurgeryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreSurgeryToolStripMenuItem, Me.FindingsToolStripMenuItem1, Me.MaterialsToolStripMenuItem, Me.DischargeToolStripMenuItem1})
        Me.SurgeryToolStripMenuItem.Name = "SurgeryToolStripMenuItem"
        Me.SurgeryToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SurgeryToolStripMenuItem.Text = "Surgery"
        '
        'PreSurgeryToolStripMenuItem
        '
        Me.PreSurgeryToolStripMenuItem.Name = "PreSurgeryToolStripMenuItem"
        Me.PreSurgeryToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.PreSurgeryToolStripMenuItem.Text = "Pre-Surgery and Surgical Plan"
        '
        'FindingsToolStripMenuItem1
        '
        Me.FindingsToolStripMenuItem1.Name = "FindingsToolStripMenuItem1"
        Me.FindingsToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.FindingsToolStripMenuItem1.Text = "Findings"
        '
        'MaterialsToolStripMenuItem
        '
        Me.MaterialsToolStripMenuItem.Name = "MaterialsToolStripMenuItem"
        Me.MaterialsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.MaterialsToolStripMenuItem.Text = "Materials"
        '
        'DischargeToolStripMenuItem1
        '
        Me.DischargeToolStripMenuItem1.Name = "DischargeToolStripMenuItem1"
        Me.DischargeToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.DischargeToolStripMenuItem1.Text = "Discharge"
        '
        'LaboratoryToolStripMenuItem1
        '
        Me.LaboratoryToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaboratoryManagerToolStripMenuItem})
        Me.LaboratoryToolStripMenuItem1.Name = "LaboratoryToolStripMenuItem1"
        Me.LaboratoryToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.LaboratoryToolStripMenuItem1.Text = "Laboratory"
        '
        'LaboratoryManagerToolStripMenuItem
        '
        Me.LaboratoryManagerToolStripMenuItem.Name = "LaboratoryManagerToolStripMenuItem"
        Me.LaboratoryManagerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LaboratoryManagerToolStripMenuItem.Text = "Laboratory Manager"
        '
        'RadiologyToolStripMenuItem
        '
        Me.RadiologyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RadiologyReportToolStripMenuItem})
        Me.RadiologyToolStripMenuItem.Name = "RadiologyToolStripMenuItem"
        Me.RadiologyToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RadiologyToolStripMenuItem.Text = "Radiology"
        '
        'RadiologyReportToolStripMenuItem
        '
        Me.RadiologyReportToolStripMenuItem.Name = "RadiologyReportToolStripMenuItem"
        Me.RadiologyReportToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RadiologyReportToolStripMenuItem.Text = "Radiology Report"
        '
        'PharmacyToolStripMenuItem
        '
        Me.PharmacyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendingRequestToolStripMenuItem})
        Me.PharmacyToolStripMenuItem.Name = "PharmacyToolStripMenuItem"
        Me.PharmacyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PharmacyToolStripMenuItem.Text = "Pharmacy"
        '
        'PendingRequestToolStripMenuItem
        '
        Me.PendingRequestToolStripMenuItem.Name = "PendingRequestToolStripMenuItem"
        Me.PendingRequestToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PendingRequestToolStripMenuItem.Text = "Pending Request"
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
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
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
        Me.Text = "SAMC Animals Centre Vet Sys"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuRecord As ToolStripMenuItem
    Friend WithEvents ClientRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAppointment As ToolStripMenuItem
    Friend WithEvents TreatmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicationHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimalInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WardExaminationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaboratoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreatmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DischargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SurgeryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreSurgeryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DischargeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaboratoryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaboratoryManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadiologyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadiologyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PharmacyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExaminationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
End Class
