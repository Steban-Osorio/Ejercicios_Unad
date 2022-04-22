<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio_16
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
        Me.ButtonRetornar16 = New System.Windows.Forms.Button()
        Me.ButtonCalcular16 = New System.Windows.Forms.Button()
        Me.TxDistancia16 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxTiempo16 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonRetornar16
        '
        Me.ButtonRetornar16.Location = New System.Drawing.Point(161, 195)
        Me.ButtonRetornar16.Name = "ButtonRetornar16"
        Me.ButtonRetornar16.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetornar16.TabIndex = 11
        Me.ButtonRetornar16.Text = "Retornar"
        Me.ButtonRetornar16.UseVisualStyleBackColor = True
        '
        'ButtonCalcular16
        '
        Me.ButtonCalcular16.Location = New System.Drawing.Point(38, 195)
        Me.ButtonCalcular16.Name = "ButtonCalcular16"
        Me.ButtonCalcular16.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular16.TabIndex = 10
        Me.ButtonCalcular16.Text = "Calcular"
        Me.ButtonCalcular16.UseVisualStyleBackColor = True
        '
        'TxDistancia16
        '
        Me.TxDistancia16.Location = New System.Drawing.Point(161, 104)
        Me.TxDistancia16.Name = "TxDistancia16"
        Me.TxDistancia16.Size = New System.Drawing.Size(92, 20)
        Me.TxDistancia16.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Distancia"
        '
        'TxTiempo16
        '
        Me.TxTiempo16.Location = New System.Drawing.Point(161, 54)
        Me.TxTiempo16.Name = "TxTiempo16"
        Me.TxTiempo16.Size = New System.Drawing.Size(92, 20)
        Me.TxTiempo16.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tiempo"
        '
        'Ejercicio_16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 348)
        Me.Controls.Add(Me.ButtonRetornar16)
        Me.Controls.Add(Me.ButtonCalcular16)
        Me.Controls.Add(Me.TxDistancia16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxTiempo16)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio_16"
        Me.Text = "Ejercicio_16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRetornar16 As Button
    Friend WithEvents ButtonCalcular16 As Button
    Friend WithEvents TxDistancia16 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxTiempo16 As TextBox
    Friend WithEvents Label1 As Label
End Class
