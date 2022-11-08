<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Itinerario
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
        Me.dtgvIitnerariosIda = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dtgvItinerariosRegreso = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgvIitnerariosIda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvItinerariosRegreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Itinerario"
        '
        'dtgvIitnerariosIda
        '
        Me.dtgvIitnerariosIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvIitnerariosIda.Location = New System.Drawing.Point(12, 91)
        Me.dtgvIitnerariosIda.Name = "dtgvIitnerariosIda"
        Me.dtgvIitnerariosIda.RowHeadersWidth = 62
        Me.dtgvIitnerariosIda.Size = New System.Drawing.Size(760, 159)
        Me.dtgvIitnerariosIda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vuelos"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnConfirmar.Location = New System.Drawing.Point(691, 56)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 29)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnVolver.Location = New System.Drawing.Point(692, 448)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 26)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'dtgvItinerariosRegreso
        '
        Me.dtgvItinerariosRegreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvItinerariosRegreso.Location = New System.Drawing.Point(12, 274)
        Me.dtgvItinerariosRegreso.Name = "dtgvItinerariosRegreso"
        Me.dtgvItinerariosRegreso.RowHeadersWidth = 62
        Me.dtgvItinerariosRegreso.Size = New System.Drawing.Size(760, 159)
        Me.dtgvItinerariosRegreso.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Vuelo de ida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Vuelo de Regreso"
        '
        'Itinerario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 486)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgvItinerariosRegreso)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgvIitnerariosIda)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Itinerario"
        Me.Text = "Itinerario"
        CType(Me.dtgvIitnerariosIda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvItinerariosRegreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgvIitnerariosIda As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents dtgvItinerariosRegreso As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
