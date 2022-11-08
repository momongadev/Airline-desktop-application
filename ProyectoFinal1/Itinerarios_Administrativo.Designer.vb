<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Itinerarios_Administrativo
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
        Me.btnEliminarItinerario = New System.Windows.Forms.Button()
        Me.btnModificarItinerario = New System.Windows.Forms.Button()
        Me.btnAgregarItinerario = New System.Windows.Forms.Button()
        Me.cb_AeropuertoOrigenId = New System.Windows.Forms.ComboBox()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_AeropuertoDestinoId = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_AerolineaId = New System.Windows.Forms.ComboBox()
        Me.dp_FechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dp_FechaLlegada = New System.Windows.Forms.DateTimePicker()
        Me.txt_Asientos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_AvionId = New System.Windows.Forms.ComboBox()
        Me.dgItinerarios = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPaisHasta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbPaisDesde = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgItinerarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarItinerario
        '
        Me.btnEliminarItinerario.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminarItinerario.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEliminarItinerario.Location = New System.Drawing.Point(1314, 455)
        Me.btnEliminarItinerario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarItinerario.Name = "btnEliminarItinerario"
        Me.btnEliminarItinerario.Size = New System.Drawing.Size(148, 35)
        Me.btnEliminarItinerario.TabIndex = 8
        Me.btnEliminarItinerario.Text = "Eliminar"
        Me.btnEliminarItinerario.UseVisualStyleBackColor = False
        '
        'btnModificarItinerario
        '
        Me.btnModificarItinerario.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificarItinerario.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnModificarItinerario.Location = New System.Drawing.Point(1314, 512)
        Me.btnModificarItinerario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificarItinerario.Name = "btnModificarItinerario"
        Me.btnModificarItinerario.Size = New System.Drawing.Size(148, 38)
        Me.btnModificarItinerario.TabIndex = 7
        Me.btnModificarItinerario.Text = "Modificar"
        Me.btnModificarItinerario.UseVisualStyleBackColor = False
        '
        'btnAgregarItinerario
        '
        Me.btnAgregarItinerario.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregarItinerario.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAgregarItinerario.Location = New System.Drawing.Point(1314, 395)
        Me.btnAgregarItinerario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarItinerario.Name = "btnAgregarItinerario"
        Me.btnAgregarItinerario.Size = New System.Drawing.Size(148, 38)
        Me.btnAgregarItinerario.TabIndex = 5
        Me.btnAgregarItinerario.Text = "Agregar"
        Me.btnAgregarItinerario.UseVisualStyleBackColor = False
        '
        'cb_AeropuertoOrigenId
        '
        Me.cb_AeropuertoOrigenId.FormattingEnabled = True
        Me.cb_AeropuertoOrigenId.Location = New System.Drawing.Point(676, 192)
        Me.cb_AeropuertoOrigenId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_AeropuertoOrigenId.Name = "cb_AeropuertoOrigenId"
        Me.cb_AeropuertoOrigenId.Size = New System.Drawing.Size(211, 28)
        Me.cb_AeropuertoOrigenId.TabIndex = 9
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(220, 40)
        Me.txt_Codigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(121, 26)
        Me.txt_Codigo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo Itinerario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Aeropuerto Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Aeropuerto Destino"
        '
        'cb_AeropuertoDestinoId
        '
        Me.cb_AeropuertoDestinoId.FormattingEnabled = True
        Me.cb_AeropuertoDestinoId.Location = New System.Drawing.Point(676, 277)
        Me.cb_AeropuertoDestinoId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_AeropuertoDestinoId.Name = "cb_AeropuertoDestinoId"
        Me.cb_AeropuertoDestinoId.Size = New System.Drawing.Size(211, 28)
        Me.cb_AeropuertoDestinoId.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 286)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Aerolinea"
        '
        'cb_AerolineaId
        '
        Me.cb_AerolineaId.FormattingEnabled = True
        Me.cb_AerolineaId.Location = New System.Drawing.Point(220, 282)
        Me.cb_AerolineaId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_AerolineaId.Name = "cb_AerolineaId"
        Me.cb_AerolineaId.Size = New System.Drawing.Size(211, 28)
        Me.cb_AerolineaId.TabIndex = 16
        '
        'dp_FechaSalida
        '
        Me.dp_FechaSalida.Location = New System.Drawing.Point(1112, 38)
        Me.dp_FechaSalida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dp_FechaSalida.Name = "dp_FechaSalida"
        Me.dp_FechaSalida.Size = New System.Drawing.Size(298, 26)
        Me.dp_FechaSalida.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(956, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha salida"
        '
        'dp_FechaLlegada
        '
        Me.dp_FechaLlegada.Location = New System.Drawing.Point(1112, 120)
        Me.dp_FechaLlegada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dp_FechaLlegada.Name = "dp_FechaLlegada"
        Me.dp_FechaLlegada.Size = New System.Drawing.Size(298, 26)
        Me.dp_FechaLlegada.TabIndex = 19
        '
        'txt_Asientos
        '
        Me.txt_Asientos.Location = New System.Drawing.Point(1113, 198)
        Me.txt_Asientos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Asientos.Name = "txt_Asientos"
        Me.txt_Asientos.Size = New System.Drawing.Size(172, 26)
        Me.txt_Asientos.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(956, 260)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Avion"
        '
        'cb_AvionId
        '
        Me.cb_AvionId.FormattingEnabled = True
        Me.cb_AvionId.Location = New System.Drawing.Point(1113, 258)
        Me.cb_AvionId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_AvionId.Name = "cb_AvionId"
        Me.cb_AvionId.Size = New System.Drawing.Size(172, 28)
        Me.cb_AvionId.TabIndex = 24
        '
        'dgItinerarios
        '
        Me.dgItinerarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItinerarios.Location = New System.Drawing.Point(42, 342)
        Me.dgItinerarios.Name = "dgItinerarios"
        Me.dgItinerarios.RowHeadersWidth = 62
        Me.dgItinerarios.RowTemplate.Height = 28
        Me.dgItinerarios.Size = New System.Drawing.Size(1245, 209)
        Me.dgItinerarios.TabIndex = 25
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnVolver.Location = New System.Drawing.Point(26, 577)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(148, 38)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 212)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 22)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Pais Hasta"
        '
        'cbPaisHasta
        '
        Me.cbPaisHasta.FormattingEnabled = True
        Me.cbPaisHasta.Location = New System.Drawing.Point(220, 208)
        Me.cbPaisHasta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPaisHasta.Name = "cbPaisHasta"
        Me.cbPaisHasta.Size = New System.Drawing.Size(211, 28)
        Me.cbPaisHasta.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 128)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 22)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Pais Desde"
        '
        'cbPaisDesde
        '
        Me.cbPaisDesde.FormattingEnabled = True
        Me.cbPaisDesde.Location = New System.Drawing.Point(220, 123)
        Me.cbPaisDesde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPaisDesde.Name = "cbPaisDesde"
        Me.cbPaisDesde.Size = New System.Drawing.Size(211, 28)
        Me.cbPaisDesde.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(956, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 22)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Fecha destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(956, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 22)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Asientos"
        '
        'Itinerarios_Administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalPrograIV.My.Resources.Resources.wp36988963
        Me.ClientSize = New System.Drawing.Size(1480, 646)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbPaisHasta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbPaisDesde)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgItinerarios)
        Me.Controls.Add(Me.cb_AvionId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Asientos)
        Me.Controls.Add(Me.dp_FechaLlegada)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dp_FechaSalida)
        Me.Controls.Add(Me.cb_AerolineaId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_AeropuertoDestinoId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Controls.Add(Me.cb_AeropuertoOrigenId)
        Me.Controls.Add(Me.btnEliminarItinerario)
        Me.Controls.Add(Me.btnModificarItinerario)
        Me.Controls.Add(Me.btnAgregarItinerario)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Itinerarios_Administrativo"
        Me.Text = "Itinerarios_Administrativo"
        CType(Me.dgItinerarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarItinerario As Button
    Friend WithEvents btnModificarItinerario As Button
    Friend WithEvents btnAgregarItinerario As Button
    Friend WithEvents cb_AeropuertoOrigenId As ComboBox
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_AeropuertoDestinoId As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_AerolineaId As ComboBox
    Friend WithEvents dp_FechaSalida As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dp_FechaLlegada As DateTimePicker
    Friend WithEvents txt_Asientos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_AvionId As ComboBox
    Friend WithEvents dgItinerarios As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbPaisHasta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbPaisDesde As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
End Class
