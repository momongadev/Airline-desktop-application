<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModficarReserva
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgReservas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgItinerariosIda = New System.Windows.Forms.DataGridView()
        Me.dgItinerariosRegreso = New System.Windows.Forms.DataGridView()
        CType(Me.dgReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItinerariosIda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItinerariosRegreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Seleccione Itinerario de Regreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 25)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Seleccione Itinerario de Ida"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAceptar.Location = New System.Drawing.Point(1032, 67)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(146, 45)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'dgReservas
        '
        Me.dgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReservas.Location = New System.Drawing.Point(50, 77)
        Me.dgReservas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgReservas.Name = "dgReservas"
        Me.dgReservas.RowHeadersWidth = 62
        Me.dgReservas.Size = New System.Drawing.Size(310, 129)
        Me.dgReservas.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Seleccione Reserva"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.Location = New System.Drawing.Point(1062, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dgItinerariosIda
        '
        Me.dgItinerariosIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItinerariosIda.Location = New System.Drawing.Point(50, 254)
        Me.dgItinerariosIda.Name = "dgItinerariosIda"
        Me.dgItinerariosIda.RowHeadersWidth = 62
        Me.dgItinerariosIda.RowTemplate.Height = 28
        Me.dgItinerariosIda.Size = New System.Drawing.Size(1070, 197)
        Me.dgItinerariosIda.TabIndex = 48
        '
        'dgItinerariosRegreso
        '
        Me.dgItinerariosRegreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItinerariosRegreso.Location = New System.Drawing.Point(50, 488)
        Me.dgItinerariosRegreso.Name = "dgItinerariosRegreso"
        Me.dgItinerariosRegreso.RowHeadersWidth = 62
        Me.dgItinerariosRegreso.RowTemplate.Height = 28
        Me.dgItinerariosRegreso.Size = New System.Drawing.Size(1070, 197)
        Me.dgItinerariosRegreso.TabIndex = 49
        '
        'ModficarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalPrograIV.My.Resources.Resources.wp36988964
        Me.ClientSize = New System.Drawing.Size(1190, 831)
        Me.Controls.Add(Me.dgItinerariosRegreso)
        Me.Controls.Add(Me.dgItinerariosIda)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgReservas)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ModficarReserva"
        Me.Text = "Modficar Reserva"
        CType(Me.dgReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItinerariosIda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItinerariosRegreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgReservas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents dgItinerariosIda As DataGridView
    Friend WithEvents dgItinerariosRegreso As DataGridView
End Class
