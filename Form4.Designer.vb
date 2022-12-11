<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.AdminCheck = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Apellido = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo.Enabled = False
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(97, -224)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(625, 673)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'Usuario
        '
        Me.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Usuario.Location = New System.Drawing.Point(231, 217)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(91, 31)
        Me.Usuario.TabIndex = 2
        Me.Usuario.Text = "Usuario"
        '
        'Txt_User
        '
        Me.Txt_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_User.Location = New System.Drawing.Point(182, 251)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(188, 23)
        Me.Txt_User.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(212, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Contraseña"
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Pass.Location = New System.Drawing.Point(182, 319)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Pass.TabIndex = 5
        '
        'Btn_Login
        '
        Me.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Login.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Login.Location = New System.Drawing.Point(342, 389)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(127, 34)
        Me.Btn_Login.TabIndex = 6
        Me.Btn_Login.Text = "Añadir usuario"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'AdminCheck
        '
        Me.AdminCheck.AutoSize = True
        Me.AdminCheck.Location = New System.Drawing.Point(352, 348)
        Me.AdminCheck.Name = "AdminCheck"
        Me.AdminCheck.Size = New System.Drawing.Size(102, 19)
        Me.AdminCheck.TabIndex = 7
        Me.AdminCheck.Text = "Administrador"
        Me.AdminCheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(477, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Nombre.Location = New System.Drawing.Point(429, 251)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Nombre.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(475, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido"
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Apellido.Location = New System.Drawing.Point(429, 319)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Apellido.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(810, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdminCheck)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Txt_Pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.Text = "SolucionesPAS"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents Usuario As Label
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents AdminCheck As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Apellido As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
