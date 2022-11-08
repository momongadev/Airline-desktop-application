<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroNuevo_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroNuevo_Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblFecha_Nacimiento = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txt_ConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.txt_NuevaContraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Nuevo Cliente:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(102, 100)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdentificacion.Multiline = True
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(180, 23)
        Me.txtIdentificacion.TabIndex = 1
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(19, 102)
        Me.lblIdentificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(73, 13)
        Me.lblIdentificacion.TabIndex = 2
        Me.lblIdentificacion.Text = "Identificacion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(19, 147)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(19, 196)
        Me.lblApellido1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(53, 13)
        Me.lblApellido1.TabIndex = 4
        Me.lblApellido1.Text = "Apellido1:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(19, 288)
        Me.lblNacionalidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 5
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(340, 147)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 6
        Me.lblGenero.Text = "Genero:"
        '
        'lblFecha_Nacimiento
        '
        Me.lblFecha_Nacimiento.AutoSize = True
        Me.lblFecha_Nacimiento.Location = New System.Drawing.Point(340, 102)
        Me.lblFecha_Nacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha_Nacimiento.Name = "lblFecha_Nacimiento"
        Me.lblFecha_Nacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lblFecha_Nacimiento.TabIndex = 7
        Me.lblFecha_Nacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(19, 243)
        Me.lblApellido2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(53, 13)
        Me.lblApellido2.TabIndex = 8
        Me.lblApellido2.Text = "Apellido2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Por favor llenar con sus datos personales:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(102, 243)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido2.Multiline = True
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(180, 26)
        Me.txtApellido2.TabIndex = 10
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(102, 196)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido1.Multiline = True
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(180, 25)
        Me.txtApellido1.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(102, 144)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 24)
        Me.txtNombre.TabIndex = 12
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(467, 95)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(135, 20)
        Me.dtpFechaNacimiento.TabIndex = 14
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"F", "M", "O"})
        Me.cbGenero.Location = New System.Drawing.Point(467, 139)
        Me.cbGenero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(101, 21)
        Me.cbGenero.TabIndex = 15
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(102, 288)
        Me.txtNacionalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNacionalidad.Multiline = True
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(180, 25)
        Me.txtNacionalidad.TabIndex = 16
        '
        'txt_ConfirmarContraseña
        '
        Me.txt_ConfirmarContraseña.Location = New System.Drawing.Point(461, 287)
        Me.txt_ConfirmarContraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_ConfirmarContraseña.Multiline = True
        Me.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña"
        Me.txt_ConfirmarContraseña.Size = New System.Drawing.Size(180, 25)
        Me.txt_ConfirmarContraseña.TabIndex = 24
        Me.txt_ConfirmarContraseña.UseSystemPasswordChar = True
        '
        'txt_NuevaContraseña
        '
        Me.txt_NuevaContraseña.Location = New System.Drawing.Point(461, 240)
        Me.txt_NuevaContraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_NuevaContraseña.Multiline = True
        Me.txt_NuevaContraseña.Name = "txt_NuevaContraseña"
        Me.txt_NuevaContraseña.Size = New System.Drawing.Size(180, 26)
        Me.txt_NuevaContraseña.TabIndex = 23
        Me.txt_NuevaContraseña.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 243)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Confirmar Contraseña:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRegistrar.Location = New System.Drawing.Point(324, 346)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(99, 27)
        Me.btnRegistrar.TabIndex = 25
        Me.btnRegistrar.Text = "Registrarse"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnIniciarSesion.Location = New System.Drawing.Point(196, 346)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(95, 27)
        Me.btnIniciarSesion.TabIndex = 26
        Me.btnIniciarSesion.Text = "Iniciar Sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Usuario:"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(461, 205)
        Me.txt_Usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Usuario.Multiline = True
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(180, 26)
        Me.txt_Usuario.TabIndex = 28
        Me.txt_Usuario.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 84)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(343, 176)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'RegistroNuevo_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 393)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txt_ConfirmarContraseña)
        Me.Controls.Add(Me.txt_NuevaContraseña)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblFecha_Nacimiento)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RegistroNuevo_Clientes"
        Me.Text = "Registrarse"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblFecha_Nacimiento As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_ConfirmarContraseña As TextBox
    Friend WithEvents txt_NuevaContraseña As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Usuario As TextBox
    Protected Friend WithEvents cbGenero As ComboBox
End Class
