<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaClientes_Administrativo
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
        Me.dtgvListaClientes = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnModReserva = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVolverListCli = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvListaClientes
        '
        Me.dtgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvListaClientes.Location = New System.Drawing.Point(37, 25)
        Me.dtgvListaClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgvListaClientes.Name = "dtgvListaClientes"
        Me.dtgvListaClientes.RowHeadersWidth = 62
        Me.dtgvListaClientes.Size = New System.Drawing.Size(374, 339)
        Me.dtgvListaClientes.TabIndex = 0
        '
        'btnModReserva
        '
        Me.btnModReserva.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModReserva.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnModReserva.Location = New System.Drawing.Point(417, 79)
        Me.btnModReserva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModReserva.Name = "btnModReserva"
        Me.btnModReserva.Size = New System.Drawing.Size(153, 32)
        Me.btnModReserva.TabIndex = 3
        Me.btnModReserva.Text = "Mantenimineto de Reservas"
        Me.btnModReserva.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(656, 511)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 36)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnVolverListCli
        '
        Me.btnVolverListCli.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolverListCli.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnVolverListCli.Location = New System.Drawing.Point(10, 374)
        Me.btnVolverListCli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolverListCli.Name = "btnVolverListCli"
        Me.btnVolverListCli.Size = New System.Drawing.Size(95, 28)
        Me.btnVolverListCli.TabIndex = 6
        Me.btnVolverListCli.Text = "Volver"
        Me.btnVolverListCli.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(417, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListaClientes_Administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 413)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVolverListCli)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnModReserva)
        Me.Controls.Add(Me.dtgvListaClientes)
        Me.Name = "ListaClientes_Administrativo"
        Me.Text = "ListaClientes_Administrativo"
        CType(Me.dtgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvListaClientes As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnModReserva As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnVolverListCli As Button
    Friend WithEvents Button1 As Button
End Class
