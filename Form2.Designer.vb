<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_addpol = New System.Windows.Forms.Button()
        Me.Btn_adduser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_Buscador = New System.Windows.Forms.TextBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo.Enabled = False
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(90, -229)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(625, 673)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 3
        Me.logo.TabStop = False
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Btn_buscar.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_buscar.Location = New System.Drawing.Point(384, 306)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscar.TabIndex = 4
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(334, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese patente del vehiculo"
        '
        'Btn_addpol
        '
        Me.Btn_addpol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Btn_addpol.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_addpol.Location = New System.Drawing.Point(357, 357)
        Me.Btn_addpol.Name = "Btn_addpol"
        Me.Btn_addpol.Size = New System.Drawing.Size(128, 23)
        Me.Btn_addpol.TabIndex = 6
        Me.Btn_addpol.Text = "Agregar poliza"
        Me.Btn_addpol.UseVisualStyleBackColor = True
        '
        'Btn_adduser
        '
        Me.Btn_adduser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Btn_adduser.Font = New System.Drawing.Font("SquareFont", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_adduser.Location = New System.Drawing.Point(357, 386)
        Me.Btn_adduser.Name = "Btn_adduser"
        Me.Btn_adduser.Size = New System.Drawing.Size(128, 23)
        Me.Btn_adduser.TabIndex = 7
        Me.Btn_adduser.Text = "Agregar usuario"
        Me.Btn_adduser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Txt_Buscador
        '
        Me.Txt_Buscador.Location = New System.Drawing.Point(263, 279)
        Me.Txt_Buscador.Name = "Txt_Buscador"
        Me.Txt_Buscador.Size = New System.Drawing.Size(322, 23)
        Me.Txt_Buscador.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(810, 473)
        Me.Controls.Add(Me.Txt_Buscador)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_adduser)
        Me.Controls.Add(Me.Btn_addpol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_buscar)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "SolucionesPAS"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As PictureBox
    Friend WithEvents Btn_buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_addpol As Button
    Friend WithEvents Btn_adduser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Buscador As TextBox
End Class
