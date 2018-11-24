<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearchEmployee))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DgvSearchResult = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(728, 68)
        Me.PnlActionBar.TabIndex = 74
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(229, 32)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Search Employee"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(663, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSearchText)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 87)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BackColor = System.Drawing.Color.White
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(9, 34)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(529, 25)
        Me.TxtSearchText.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(544, 20)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 52)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'DgvSearchResult
        '
        Me.DgvSearchResult.AllowUserToAddRows = False
        Me.DgvSearchResult.AllowUserToDeleteRows = False
        Me.DgvSearchResult.AllowUserToResizeRows = False
        Me.DgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvSearchResult.BackgroundColor = System.Drawing.Color.White
        Me.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSearchResult.Location = New System.Drawing.Point(3, 16)
        Me.DgvSearchResult.MultiSelect = False
        Me.DgvSearchResult.Name = "DgvSearchResult"
        Me.DgvSearchResult.ReadOnly = True
        Me.DgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSearchResult.Size = New System.Drawing.Size(722, 231)
        Me.DgvSearchResult.TabIndex = 77
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvSearchResult)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 250)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee List"
        '
        'FrmSearchEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 441)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSearchEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Employee"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DgvSearchResult As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
End Class
