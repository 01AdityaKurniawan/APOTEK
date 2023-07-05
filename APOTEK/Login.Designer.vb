<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.LblIDAdmin = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtUsername.Location = New System.Drawing.Point(672, 249)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(337, 45)
        Me.txtUsername.TabIndex = 0
        '
        'LblIDAdmin
        '
        Me.LblIDAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblIDAdmin.AutoSize = True
        Me.LblIDAdmin.Location = New System.Drawing.Point(691, 119)
        Me.LblIDAdmin.Name = "LblIDAdmin"
        Me.LblIDAdmin.Size = New System.Drawing.Size(0, 13)
        Me.LblIDAdmin.TabIndex = 2
        '
        'LblUsername
        '
        Me.LblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUsername.Font = New System.Drawing.Font("Swis721 BlkCn BT", 25.0!)
        Me.LblUsername.ForeColor = System.Drawing.Color.Black
        Me.LblUsername.Location = New System.Drawing.Point(446, 249)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(162, 43)
        Me.LblUsername.TabIndex = 3
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPassword.Font = New System.Drawing.Font("Swis721 BlkCn BT", 25.0!)
        Me.LblPassword.Location = New System.Drawing.Point(444, 339)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(155, 43)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtPassword.Location = New System.Drawing.Point(672, 335)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(336, 45)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(672, 435)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(123, 36)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 50.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(674, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 82)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1520, 642)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblIDAdmin)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "Login"
        Me.Text = "Form Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents LblIDAdmin As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
End Class
