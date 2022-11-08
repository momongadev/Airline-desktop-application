<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservas_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservas_Cliente))
        Me.dtgvRerservasCliente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificarReserva = New System.Windows.Forms.Button()
        Me.btnEliminarReserva = New System.Windows.Forms.Button()
        Me.btnNuevaReserva = New System.Windows.Forms.Button()
        Me.btnExportarReserva = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.saveFileXML = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dtgvRerservasCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvRerservasCliente
        '
        Me.dtgvRerservasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvRerservasCliente.Location = New System.Drawing.Point(11, 65)
        Me.dtgvRerservasCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgvRerservasCliente.Name = "dtgvRerservasCliente"
        Me.dtgvRerservasCliente.RowHeadersWidth = 62
        Me.dtgvRerservasCliente.RowTemplate.Height = 28
        Me.dtgvRerservasCliente.Size = New System.Drawing.Size(1219, 266)
        Me.dtgvRerservasCliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(191, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mis Reservas"
        '
        'btnModificarReserva
        '
        Me.btnModificarReserva.Location = New System.Drawing.Point(955, 338)
        Me.btnModificarReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarReserva.Name = "btnModificarReserva"
        Me.btnModificarReserva.Size = New System.Drawing.Size(89, 28)
        Me.btnModificarReserva.TabIndex = 2
        Me.btnModificarReserva.Text = "Modificar"
        Me.btnModificarReserva.UseVisualStyleBackColor = True
        '
        'btnEliminarReserva
        '
        Me.btnEliminarReserva.Location = New System.Drawing.Point(1048, 337)
        Me.btnEliminarReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarReserva.Name = "btnEliminarReserva"
        Me.btnEliminarReserva.Size = New System.Drawing.Size(89, 28)
        Me.btnEliminarReserva.TabIndex = 3
        Me.btnEliminarReserva.Text = "Eliminar"
        Me.btnEliminarReserva.UseVisualStyleBackColor = True
        '
        'btnNuevaReserva
        '
        Me.btnNuevaReserva.Location = New System.Drawing.Point(862, 337)
        Me.btnNuevaReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevaReserva.Name = "btnNuevaReserva"
        Me.btnNuevaReserva.Size = New System.Drawing.Size(89, 29)
        Me.btnNuevaReserva.TabIndex = 4
        Me.btnNuevaReserva.Text = "Nueva Reserva"
        Me.btnNuevaReserva.UseVisualStyleBackColor = True
        '
        'btnExportarReserva
        '
        Me.btnExportarReserva.Location = New System.Drawing.Point(1141, 335)
        Me.btnExportarReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportarReserva.Name = "btnExportarReserva"
        Me.btnExportarReserva.Size = New System.Drawing.Size(89, 30)
        Me.btnExportarReserva.TabIndex = 5
        Me.btnExportarReserva.Text = "Exportar Reserva"
        Me.btnExportarReserva.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(498, 318)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 26)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Reservas_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 383)
        Me.Controls.Add(Me.btnExportarReserva)
        Me.Controls.Add(Me.btnNuevaReserva)
        Me.Controls.Add(Me.btnEliminarReserva)
        Me.Controls.Add(Me.btnModificarReserva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgvRerservasCliente)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Reservas_Cliente"
        Me.Text = "Reservas_Cliente"
        CType(Me.dtgvRerservasCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvRerservasCliente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificarReserva As Button
    Friend WithEvents btnEliminarReserva As Button
    Friend WithEvents btnNuevaReserva As Button
    Friend WithEvents btnExportarReserva As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents saveFileXML As SaveFileDialog
End Class
