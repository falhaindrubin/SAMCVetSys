﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerReport
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
        Me.CrvCustomerInformation = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvCustomerInformation
        '
        Me.CrvCustomerInformation.ActiveViewIndex = -1
        Me.CrvCustomerInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvCustomerInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvCustomerInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvCustomerInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrvCustomerInformation.Location = New System.Drawing.Point(0, 0)
        Me.CrvCustomerInformation.Name = "CrvCustomerInformation"
        Me.CrvCustomerInformation.Size = New System.Drawing.Size(752, 441)
        Me.CrvCustomerInformation.TabIndex = 0
        Me.CrvCustomerInformation.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmCustomerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 441)
        Me.Controls.Add(Me.CrvCustomerInformation)
        Me.Name = "FrmCustomerReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrvCustomerInformation As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
