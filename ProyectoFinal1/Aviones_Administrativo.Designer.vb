<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aviones_Administrativo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_CodAerolinea = New System.Windows.Forms.ComboBox()
        Me.txt_CodAvion = New System.Windows.Forms.TextBox()
        Me.txt_NombreAvion = New System.Windows.Forms.TextBox()
        Me.txt_Capacidad = New System.Windows.Forms.TextBox()
        Me.dgAvion = New System.Windows.Forms.DataGridView()
        Me.btnEliminarAvion = New System.Windows.Forms.Button()
        Me.btnModificarAvion = New System.Windows.Forms.Button()
        Me.btnAgregarAvion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(57, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Avion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(57, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Avion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(57, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aerolinea"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(57, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Capacidad"
        '
        'cb_CodAerolinea
        '
        Me.cb_CodAerolinea.FormattingEnabled = True
        Me.cb_CodAerolinea.Location = New System.Drawing.Point(193, 198)
        Me.cb_CodAerolinea.Name = "cb_CodAerolinea"
        Me.cb_CodAerolinea.Size = New System.Drawing.Size(160, 28)
        Me.cb_CodAerolinea.TabIndex = 5
        '
        'txt_CodAvion
        '
        Me.txt_CodAvion.Location = New System.Drawing.Point(193, 32)
        Me.txt_CodAvion.Multiline = True
        Me.txt_CodAvion.Name = "txt_CodAvion"
        Me.txt_CodAvion.ReadOnly = True
        Me.txt_CodAvion.Size = New System.Drawing.Size(133, 31)
        Me.txt_CodAvion.TabIndex = 6
        '
        'txt_NombreAvion
        '
        Me.txt_NombreAvion.Location = New System.Drawing.Point(193, 81)
        Me.txt_NombreAvion.Multiline = True
        Me.txt_NombreAvion.Name = "txt_NombreAvion"
        Me.txt_NombreAvion.Size = New System.Drawing.Size(234, 36)
        Me.txt_NombreAvion.TabIndex = 7
        '
        'txt_Capacidad
        '
        Me.txt_Capacidad.Location = New System.Drawing.Point(193, 143)
        Me.txt_Capacidad.Name = "txt_Capacidad"
        Me.txt_Capacidad.Size = New System.Drawing.Size(100, 26)
        Me.txt_Capacidad.TabIndex = 8
        '
        'dgAvion
        '
        Me.dgAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAvion.Location = New System.Drawing.Point(12, 270)
        Me.dgAvion.Name = "dgAvion"
        Me.dgAvion.RowHeadersWidth = 62
        Me.dgAvion.RowTemplate.Height = 28
        Me.dgAvion.Size = New System.Drawing.Size(724, 214)
        Me.dgAvion.TabIndex = 9
        '
        'btnEliminarAvion
        '
        Me.btnEliminarAvion.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminarAvion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEliminarAvion.Location = New System.Drawing.Point(772, 252)
        Me.btnEliminarAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarAvion.Name = "btnEliminarAvion"
        Me.btnEliminarAvion.Size = New System.Drawing.Size(140, 44)
        Me.btnEliminarAvion.TabIndex = 12
        Me.btnEliminarAvion.Text = "Eliminar"
        Me.btnEliminarAvion.UseVisualStyleBackColor = False
        '
        'btnModificarAvion
        '
        Me.btnModificarAvion.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificarAvion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnModificarAvion.Location = New System.Drawing.Point(772, 189)
        Me.btnModificarAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarAvion.Name = "btnModificarAvion"
        Me.btnModificarAvion.Size = New System.Drawing.Size(140, 42)
        Me.btnModificarAvion.TabIndex = 11
        Me.btnModificarAvion.Text = "Modificar datos"
        Me.btnModificarAvion.UseVisualStyleBackColor = False
        '
        'btnAgregarAvion
        '
        Me.btnAgregarAvion.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregarAvion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAgregarAvion.Location = New System.Drawing.Point(772, 113)
        Me.btnAgregarAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarAvion.Name = "btnAgregarAvion"
        Me.btnAgregarAvion.Size = New System.Drawing.Size(140, 47)
        Me.btnAgregarAvion.TabIndex = 10
        Me.btnAgregarAvion.Text = "Agregar"
        Me.btnAgregarAvion.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnVolver.Location = New System.Drawing.Point(799, 448)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(126, 36)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnActualizar.Location = New System.Drawing.Point(772, 306)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(140, 44)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar datos"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Aviones_Administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalPrograIV.My.Resources.Resources.wp36988961
        Me.ClientSize = New System.Drawing.Size(937, 510)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEliminarAvion)
        Me.Controls.Add(Me.btnModificarAvion)
        Me.Controls.Add(Me.btnAgregarAvion)
        Me.Controls.Add(Me.dgAvion)
        Me.Controls.Add(Me.txt_Capacidad)
        Me.Controls.Add(Me.txt_NombreAvion)
        Me.Controls.Add(Me.txt_CodAvion)
        Me.Controls.Add(Me.cb_CodAerolinea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Aviones_Administrativo"
        Me.Text = "Aviones_Administrativo"
        CType(Me.dgAvion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_CodAerolinea As ComboBox
    Friend WithEvents txt_CodAvion As TextBox
    Friend WithEvents txt_NombreAvion As TextBox
    Friend WithEvents txt_Capacidad As TextBox
    Friend WithEvents dgAvion As DataGridView
    Friend WithEvents btnEliminarAvion As Button
    Friend WithEvents btnModificarAvion As Button
    Friend WithEvents btnAgregarAvion As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
End Class
