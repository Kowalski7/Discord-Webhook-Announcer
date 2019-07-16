<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profiles))
        Me.profilesList = New System.Windows.Forms.ListBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.useBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'profilesList
        '
        Me.profilesList.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.profilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profilesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.profilesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.profilesList.FormattingEnabled = True
        Me.profilesList.ItemHeight = 20
        Me.profilesList.Location = New System.Drawing.Point(12, 127)
        Me.profilesList.Name = "profilesList"
        Me.profilesList.Size = New System.Drawing.Size(258, 142)
        Me.profilesList.TabIndex = 1
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.saveBtn.Location = New System.Drawing.Point(12, 275)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(81, 39)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.deleteBtn.Enabled = False
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deleteBtn.Location = New System.Drawing.Point(99, 275)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(90, 39)
        Me.deleteBtn.TabIndex = 3
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'useBtn
        '
        Me.useBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.useBtn.Enabled = False
        Me.useBtn.FlatAppearance.BorderSize = 0
        Me.useBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.useBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.useBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.useBtn.Location = New System.Drawing.Point(195, 275)
        Me.useBtn.Name = "useBtn"
        Me.useBtn.Size = New System.Drawing.Size(75, 39)
        Me.useBtn.TabIndex = 4
        Me.useBtn.Text = "Use"
        Me.useBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profiles"
        '
        'profiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(282, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.useBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.profilesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "profiles"
        Me.Text = "Profiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents profilesList As ListBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents useBtn As Button
    Friend WithEvents Label1 As Label
End Class
