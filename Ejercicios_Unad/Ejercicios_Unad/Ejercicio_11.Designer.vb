<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio_11
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
        Me.ButtonRetornar11 = New System.Windows.Forms.Button()
        Me.ButtonCalcular11 = New System.Windows.Forms.Button()
        Me.TxNota75 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxValorCurso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxEscala = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonRetornar11
        '
        Me.ButtonRetornar11.Location = New System.Drawing.Point(169, 237)
        Me.ButtonRetornar11.Name = "ButtonRetornar11"
        Me.ButtonRetornar11.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetornar11.TabIndex = 11
        Me.ButtonRetornar11.Text = "Retornar"
        Me.ButtonRetornar11.UseVisualStyleBackColor = True
        '
        'ButtonCalcular11
        '
        Me.ButtonCalcular11.Location = New System.Drawing.Point(46, 237)
        Me.ButtonCalcular11.Name = "ButtonCalcular11"
        Me.ButtonCalcular11.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular11.TabIndex = 10
        Me.ButtonCalcular11.Text = "Calcular"
        Me.ButtonCalcular11.UseVisualStyleBackColor = True
        '
        'TxNota75
        '
        Me.TxNota75.Location = New System.Drawing.Point(251, 143)
        Me.TxNota75.Name = "TxNota75"
        Me.TxNota75.Size = New System.Drawing.Size(92, 20)
        Me.TxNota75.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nota Equivalente al 75%"
        '
        'TxValorCurso
        '
        Me.TxValorCurso.Location = New System.Drawing.Point(251, 93)
        Me.TxValorCurso.Name = "TxValorCurso"
        Me.TxValorCurso.Size = New System.Drawing.Size(92, 20)
        Me.TxValorCurso.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valor Total Del Curso"
        '
        'TxEscala
        '
        Me.TxEscala.Location = New System.Drawing.Point(251, 185)
        Me.TxEscala.Name = "TxEscala"
        Me.TxEscala.Size = New System.Drawing.Size(92, 20)
        Me.TxEscala.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Su calificacion en una escala de 1 a 5"
        '
        'Ejercicio_11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 444)
        Me.Controls.Add(Me.TxEscala)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonRetornar11)
        Me.Controls.Add(Me.ButtonCalcular11)
        Me.Controls.Add(Me.TxNota75)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxValorCurso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio_11"
        Me.Text = "Ejercicio_11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRetornar11 As Button
    Friend WithEvents ButtonCalcular11 As Button
    Friend WithEvents TxNota75 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxValorCurso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxEscala As TextBox
    Friend WithEvents Label3 As Label
End Class
