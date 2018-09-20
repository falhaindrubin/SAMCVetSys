<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemEntry))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbProducts = New System.Windows.Forms.RadioButton()
        Me.RbServices = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.RbProducts)
        Me.GroupBox2.Controls.Add(Me.RbServices)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtSearchText)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 222)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services/Products Information"
        '
        'RbProducts
        '
        Me.RbProducts.AutoSize = True
        Me.RbProducts.Location = New System.Drawing.Point(194, 34)
        Me.RbProducts.Name = "RbProducts"
        Me.RbProducts.Size = New System.Drawing.Size(67, 17)
        Me.RbProducts.TabIndex = 13
        Me.RbProducts.TabStop = True
        Me.RbProducts.Text = "Products"
        Me.RbProducts.UseVisualStyleBackColor = True
        '
        'RbServices
        '
        Me.RbServices.AutoSize = True
        Me.RbServices.Location = New System.Drawing.Point(108, 34)
        Me.RbServices.Name = "RbServices"
        Me.RbServices.Size = New System.Drawing.Size(66, 17)
        Me.RbServices.TabIndex = 12
        Me.RbServices.TabStop = True
        Me.RbServices.Text = "Services"
        Me.RbServices.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Price"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(108, 119)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 22)
        Me.TextBox2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item Description"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Code"
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(108, 58)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(216, 22)
        Me.TxtSearchText.TabIndex = 6
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.Button1)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.Button2)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(612, 57)
        Me.PnlActionBar.TabIndex = 76
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(547, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 52)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(425, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(486, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 52)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(364, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 52)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(108, 158)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Inactive Item"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmItemEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 318)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmItemEntry"
        Me.Text = "FrmItemEntry"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbProducts As RadioButton
    Friend WithEvents RbServices As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
