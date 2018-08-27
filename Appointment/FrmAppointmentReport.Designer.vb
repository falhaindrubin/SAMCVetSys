<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAppointmentReport
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
        Me.CrvAppointment = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvAppointment
        '
        Me.CrvAppointment.ActiveViewIndex = -1
        Me.CrvAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvAppointment.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvAppointment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrvAppointment.Location = New System.Drawing.Point(0, 0)
        Me.CrvAppointment.Name = "CrvAppointment"
        Me.CrvAppointment.Size = New System.Drawing.Size(784, 729)
        Me.CrvAppointment.TabIndex = 0
        Me.CrvAppointment.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmAppointmentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 729)
        Me.Controls.Add(Me.CrvAppointment)
        Me.Name = "FrmAppointmentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrvAppointment As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
