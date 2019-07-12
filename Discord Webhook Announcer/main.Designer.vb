<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.webhookLink = New System.Windows.Forms.TextBox()
        Me.profilePicLink = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.messageField = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.send = New System.Windows.Forms.Button()
        Me.profilesBtn = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.circleOverlay = New System.Windows.Forms.PictureBox()
        Me.profilePic = New System.Windows.Forms.PictureBox()
        Me.autoFetch = New System.Windows.Forms.CheckBox()
        CType(Me.circleOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(156, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Webhook link:"
        '
        'webhookLink
        '
        Me.webhookLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.webhookLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.webhookLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.webhookLink.Location = New System.Drawing.Point(269, 62)
        Me.webhookLink.Name = "webhookLink"
        Me.webhookLink.Size = New System.Drawing.Size(359, 20)
        Me.webhookLink.TabIndex = 5
        '
        'profilePicLink
        '
        Me.profilePicLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.profilePicLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profilePicLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.profilePicLink.Location = New System.Drawing.Point(299, 97)
        Me.profilePicLink.Name = "profilePicLink"
        Me.profilePicLink.Size = New System.Drawing.Size(329, 20)
        Me.profilePicLink.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(156, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Profile picture link:"
        '
        'messageField
        '
        Me.messageField.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.messageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.messageField.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.messageField.Location = New System.Drawing.Point(12, 182)
        Me.messageField.Multiline = True
        Me.messageField.Name = "messageField"
        Me.messageField.Size = New System.Drawing.Size(616, 120)
        Me.messageField.TabIndex = 1
        Me.messageField.Text = "Your message here."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Message:"
        '
        'send
        '
        Me.send.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.send.FlatAppearance.BorderSize = 0
        Me.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.send.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.send.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.send.Location = New System.Drawing.Point(413, 310)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(215, 54)
        Me.send.TabIndex = 3
        Me.send.Text = "Send message"
        Me.send.UseVisualStyleBackColor = False
        '
        'profilesBtn
        '
        Me.profilesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.profilesBtn.FlatAppearance.BorderSize = 0
        Me.profilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profilesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.profilesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.profilesBtn.Location = New System.Drawing.Point(12, 310)
        Me.profilesBtn.Name = "profilesBtn"
        Me.profilesBtn.Size = New System.Drawing.Size(118, 52)
        Me.profilesBtn.TabIndex = 2
        Me.profilesBtn.Text = "Profiles"
        Me.profilesBtn.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.username.Location = New System.Drawing.Point(159, 12)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(469, 42)
        Me.username.TabIndex = 4
        Me.username.Text = "Webhook"
        '
        'circleOverlay
        '
        Me.circleOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.circleOverlay.Image = CType(resources.GetObject("circleOverlay.Image"), System.Drawing.Image)
        Me.circleOverlay.Location = New System.Drawing.Point(22, 26)
        Me.circleOverlay.Name = "circleOverlay"
        Me.circleOverlay.Size = New System.Drawing.Size(128, 128)
        Me.circleOverlay.TabIndex = 10
        Me.circleOverlay.TabStop = False
        '
        'profilePic
        '
        Me.profilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.profilePic.Image = Global.Discord_Webhook_Announcer.My.Resources.Resources.default_picture
        Me.profilePic.Location = New System.Drawing.Point(12, 12)
        Me.profilePic.Name = "profilePic"
        Me.profilePic.Size = New System.Drawing.Size(128, 128)
        Me.profilePic.TabIndex = 0
        Me.profilePic.TabStop = False
        '
        'autoFetch
        '
        Me.autoFetch.AutoSize = True
        Me.autoFetch.Checked = True
        Me.autoFetch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoFetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.autoFetch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.autoFetch.Location = New System.Drawing.Point(160, 123)
        Me.autoFetch.Name = "autoFetch"
        Me.autoFetch.Size = New System.Drawing.Size(260, 24)
        Me.autoFetch.TabIndex = 11
        Me.autoFetch.Text = "Automatically fetch webhook info"
        Me.autoFetch.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 374)
        Me.Controls.Add(Me.autoFetch)
        Me.Controls.Add(Me.circleOverlay)
        Me.Controls.Add(Me.profilesBtn)
        Me.Controls.Add(Me.send)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.messageField)
        Me.Controls.Add(Me.profilePicLink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.webhookLink)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.profilePic)
        Me.Controls.Add(Me.username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "Discord Webhook Announcer"
        CType(Me.circleOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents profilePic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents webhookLink As TextBox
    Friend WithEvents profilePicLink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents messageField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents send As Button
    Friend WithEvents profilesBtn As Button
    Friend WithEvents circleOverlay As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents autoFetch As CheckBox
End Class
