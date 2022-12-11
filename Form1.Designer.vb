<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo.Enabled = False
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(76, -227)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(625, 673)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'Usuario
        '
        Me.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("SquareFont", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Usuario.Location = New System.Drawing.Point(353, 221)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(102, 25)
        Me.Usuario.TabIndex = 1
        Me.Usuario.Text = "Usuario"
        '
        'Txt_User
        '
        Me.Txt_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_User.Location = New System.Drawing.Point(310, 262)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(188, 23)
        Me.Txt_User.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SquareFont", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(328, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña"
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Pass.Location = New System.Drawing.Point(310, 336)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Pass.TabIndex = 4
        '
        'Btn_Login
        '
        Me.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Login.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Login.Location = New System.Drawing.Point(341, 390)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(127, 34)
        Me.Btn_Login.TabIndex = 5
        Me.Btn_Login.Text = "Iniciar Sesión"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(805, 458)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_Pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "SolucionesPAS"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents Usuario As Label
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Btn_Login As Button
End Class
