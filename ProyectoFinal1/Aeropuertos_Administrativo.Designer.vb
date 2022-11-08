<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aeropuertos_Administrativo
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgAeropuerto = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CodAeropuerto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Nombre_Aeropuerto = New System.Windows.Forms.TextBox()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnActualizardatos = New System.Windows.Forms.Button()
        CType(Me.dgAeropuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.Location = New System.Drawing.Point(496, 14)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(140, 48)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnModificar.Location = New System.Drawing.Point(496, 91)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 42)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar datos"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEliminar.Location = New System.Drawing.Point(496, 152)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 45)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgAeropuerto
        '
        Me.dgAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAeropuerto.Location = New System.Drawing.Point(12, 251)
        Me.dgAeropuerto.Name = "dgAeropuerto"
        Me.dgAeropuerto.RowHeadersWidth = 62
        Me.dgAeropuerto.RowTemplate.Height = 28
        Me.dgAeropuerto.Size = New System.Drawing.Size(624, 195)
        Me.dgAeropuerto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo Aeropuerto:"
        '
        'txt_CodAeropuerto
        '
        Me.txt_CodAeropuerto.Location = New System.Drawing.Point(184, 43)
        Me.txt_CodAeropuerto.Name = "txt_CodAeropuerto"
        Me.txt_CodAeropuerto.ReadOnly = True
        Me.txt_CodAeropuerto.Size = New System.Drawing.Size(144, 26)
        Me.txt_CodAeropuerto.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre Aeropuerto:"
        '
        'txt_Nombre_Aeropuerto
        '
        Me.txt_Nombre_Aeropuerto.Location = New System.Drawing.Point(184, 129)
        Me.txt_Nombre_Aeropuerto.Name = "txt_Nombre_Aeropuerto"
        Me.txt_Nombre_Aeropuerto.Size = New System.Drawing.Size(144, 26)
        Me.txt_Nombre_Aeropuerto.TabIndex = 9
        '
        'cbPais
        '
        Me.cbPais.FormattingEnabled = True
        Me.cbPais.Items.AddRange(New Object() {"Mexico", "Costa Rica", "Panama", "Estados Unidos", "Brasil ", "Colombia", "Argentina", "Uruguay ", "Paraguay", "Inglaterra", "Francia", "China", "Japon", "Corea del sur"})
        Me.cbPais.Location = New System.Drawing.Point(184, 185)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(144, 28)
        Me.cbPais.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pais:"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 494)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(116, 38)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnActualizardatos
        '
        Me.btnActualizardatos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnActualizardatos.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnActualizardatos.Location = New System.Drawing.Point(496, 207)
        Me.btnActualizardatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizardatos.Name = "btnActualizardatos"
        Me.btnActualizardatos.Size = New System.Drawing.Size(140, 45)
        Me.btnActualizardatos.TabIndex = 13
        Me.btnActualizardatos.Text = "Actualizar datos"
        Me.btnActualizardatos.UseVisualStyleBackColor = False
        '
        'Aeropuertos_Administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalPrograIV.My.Resources.Resources.wp36988962
        Me.ClientSize = New System.Drawing.Size(678, 549)
        Me.Controls.Add(Me.btnActualizardatos)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbPais)
        Me.Controls.Add(Me.txt_Nombre_Aeropuerto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_CodAeropuerto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgAeropuerto)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Aeropuertos_Administrativo"
        Me.Text = "Aeropuertos_Administrativo"
        CType(Me.dgAeropuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgAeropuerto As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_CodAeropuerto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Nombre_Aeropuerto As TextBox
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnActualizardatos As Button
End Class
