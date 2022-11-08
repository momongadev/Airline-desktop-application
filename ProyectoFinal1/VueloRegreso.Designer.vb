<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VueloRegreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VueloRegreso))
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.dtgvAeropuertoDestino = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgvAeropuertoOrigen = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaRegreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaViaje = New System.Windows.Forms.DateTimePicker()
        Me.cbPaisHasta = New System.Windows.Forms.ComboBox()
        Me.cbPaisDesde = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TeAyudamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreguntasFrecuentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SugerenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntesDelVueloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliticaDeEquipajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactenosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgvAeropuertoDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvAeropuertoOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(692, 55)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(97, 36)
        Me.btnConfirmar.TabIndex = 46
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'dtgvAeropuertoDestino
        '
        Me.dtgvAeropuertoDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvAeropuertoDestino.Location = New System.Drawing.Point(375, 297)
        Me.dtgvAeropuertoDestino.Name = "dtgvAeropuertoDestino"
        Me.dtgvAeropuertoDestino.RowHeadersWidth = 62
        Me.dtgvAeropuertoDestino.Size = New System.Drawing.Size(288, 117)
        Me.dtgvAeropuertoDestino.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(372, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Seleccione un aeropuerto de destino"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(372, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Seleccione un aeropuerto de origen"
        '
        'dtgvAeropuertoOrigen
        '
        Me.dtgvAeropuertoOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvAeropuertoOrigen.Location = New System.Drawing.Point(375, 123)
        Me.dtgvAeropuertoOrigen.Name = "dtgvAeropuertoOrigen"
        Me.dtgvAeropuertoOrigen.RowHeadersWidth = 62
        Me.dtgvAeropuertoOrigen.Size = New System.Drawing.Size(288, 117)
        Me.dtgvAeropuertoOrigen.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 123)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Hasta"
        '
        'dtpFechaRegreso
        '
        Me.dtpFechaRegreso.Location = New System.Drawing.Point(18, 322)
        Me.dtpFechaRegreso.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaRegreso.Name = "dtpFechaRegreso"
        Me.dtpFechaRegreso.Size = New System.Drawing.Size(150, 20)
        Me.dtpFechaRegreso.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 283)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Cuando Regresas?"
        '
        'dtpFechaViaje
        '
        Me.dtpFechaViaje.Location = New System.Drawing.Point(18, 236)
        Me.dtpFechaViaje.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaViaje.Name = "dtpFechaViaje"
        Me.dtpFechaViaje.Size = New System.Drawing.Size(150, 20)
        Me.dtpFechaViaje.TabIndex = 37
        '
        'cbPaisHasta
        '
        Me.cbPaisHasta.FormattingEnabled = True
        Me.cbPaisHasta.Location = New System.Drawing.Point(157, 145)
        Me.cbPaisHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPaisHasta.Name = "cbPaisHasta"
        Me.cbPaisHasta.Size = New System.Drawing.Size(114, 21)
        Me.cbPaisHasta.TabIndex = 36
        '
        'cbPaisDesde
        '
        Me.cbPaisDesde.FormattingEnabled = True
        Me.cbPaisDesde.Location = New System.Drawing.Point(19, 145)
        Me.cbPaisDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPaisDesde.Name = "cbPaisDesde"
        Me.cbPaisDesde.Size = New System.Drawing.Size(114, 21)
        Me.cbPaisDesde.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Cuando Viajas?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "A Donde Viajas?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nueva Reserva Aerea"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeAyudamosToolStripMenuItem, Me.AntesDelVueloToolStripMenuItem, Me.ContactenosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TeAyudamosToolStripMenuItem
        '
        Me.TeAyudamosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreguntasFrecuentesToolStripMenuItem, Me.SugerenciasToolStripMenuItem})
        Me.TeAyudamosToolStripMenuItem.Name = "TeAyudamosToolStripMenuItem"
        Me.TeAyudamosToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.TeAyudamosToolStripMenuItem.Text = "Te Ayudamos?"
        '
        'PreguntasFrecuentesToolStripMenuItem
        '
        Me.PreguntasFrecuentesToolStripMenuItem.Name = "PreguntasFrecuentesToolStripMenuItem"
        Me.PreguntasFrecuentesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PreguntasFrecuentesToolStripMenuItem.Text = "Preguntas Frecuentes"
        '
        'SugerenciasToolStripMenuItem
        '
        Me.SugerenciasToolStripMenuItem.Name = "SugerenciasToolStripMenuItem"
        Me.SugerenciasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SugerenciasToolStripMenuItem.Text = "Sugerencias"
        '
        'AntesDelVueloToolStripMenuItem
        '
        Me.AntesDelVueloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoliticaDeEquipajeToolStripMenuItem, Me.InformacionDeDocumentosToolStripMenuItem})
        Me.AntesDelVueloToolStripMenuItem.Name = "AntesDelVueloToolStripMenuItem"
        Me.AntesDelVueloToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.AntesDelVueloToolStripMenuItem.Text = "Antes del Vuelo"
        '
        'PoliticaDeEquipajeToolStripMenuItem
        '
        Me.PoliticaDeEquipajeToolStripMenuItem.Name = "PoliticaDeEquipajeToolStripMenuItem"
        Me.PoliticaDeEquipajeToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PoliticaDeEquipajeToolStripMenuItem.Text = "Politica de Equipaje"
        '
        'InformacionDeDocumentosToolStripMenuItem
        '
        Me.InformacionDeDocumentosToolStripMenuItem.Name = "InformacionDeDocumentosToolStripMenuItem"
        Me.InformacionDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.InformacionDeDocumentosToolStripMenuItem.Text = "Informacion de documentos"
        '
        'ContactenosToolStripMenuItem
        '
        Me.ContactenosToolStripMenuItem.Name = "ContactenosToolStripMenuItem"
        Me.ContactenosToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.ContactenosToolStripMenuItem.Text = "Contactenos"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(333, 105)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 333)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'VueloRegreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dtgvAeropuertoDestino)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtgvAeropuertoOrigen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpFechaRegreso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dtpFechaViaje)
        Me.Controls.Add(Me.cbPaisHasta)
        Me.Controls.Add(Me.cbPaisDesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "VueloRegreso"
        Me.Text = "VueloRegreso"
        CType(Me.dtgvAeropuertoDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvAeropuertoOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents dtgvAeropuertoDestino As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgvAeropuertoOrigen As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFechaRegreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dtpFechaViaje As DateTimePicker
    Friend WithEvents cbPaisHasta As ComboBox
    Friend WithEvents cbPaisDesde As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TeAyudamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreguntasFrecuentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SugerenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AntesDelVueloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoliticaDeEquipajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionDeDocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactenosToolStripMenuItem As ToolStripMenuItem
End Class
