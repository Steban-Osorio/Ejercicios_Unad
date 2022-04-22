<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Tema1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Tema2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tema3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio16ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio24ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio25ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tema1ToolStripMenuItem, Me.Tema2ToolStripMenuItem, Me.Tema3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Tema1ToolStripMenuItem
        '
        Me.Tema1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio11ToolStripMenuItem, Me.Ejercicio4ToolStripMenuItem})
        Me.Tema1ToolStripMenuItem.Name = "Tema1ToolStripMenuItem"
        Me.Tema1ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Tema1ToolStripMenuItem.Text = "Tema 1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Tema2ToolStripMenuItem
        '
        Me.Tema2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio13ToolStripMenuItem, Me.Ejercicio16ToolStripMenuItem})
        Me.Tema2ToolStripMenuItem.Name = "Tema2ToolStripMenuItem"
        Me.Tema2ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Tema2ToolStripMenuItem.Text = "Tema 2"
        '
        'Tema3ToolStripMenuItem
        '
        Me.Tema3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio24ToolStripMenuItem, Me.Ejercicio25ToolStripMenuItem})
        Me.Tema3ToolStripMenuItem.Name = "Tema3ToolStripMenuItem"
        Me.Tema3ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Tema3ToolStripMenuItem.Text = "Tema 3"
        '
        'Ejercicio11ToolStripMenuItem
        '
        Me.Ejercicio11ToolStripMenuItem.Name = "Ejercicio11ToolStripMenuItem"
        Me.Ejercicio11ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio11ToolStripMenuItem.Text = "Ejercicio 11"
        '
        'Ejercicio4ToolStripMenuItem
        '
        Me.Ejercicio4ToolStripMenuItem.Name = "Ejercicio4ToolStripMenuItem"
        Me.Ejercicio4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio4ToolStripMenuItem.Text = "Ejercicio 4"
        '
        'Ejercicio13ToolStripMenuItem
        '
        Me.Ejercicio13ToolStripMenuItem.Name = "Ejercicio13ToolStripMenuItem"
        Me.Ejercicio13ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio13ToolStripMenuItem.Text = "Ejercicio 13"
        '
        'Ejercicio16ToolStripMenuItem
        '
        Me.Ejercicio16ToolStripMenuItem.Name = "Ejercicio16ToolStripMenuItem"
        Me.Ejercicio16ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio16ToolStripMenuItem.Text = "Ejercicio 16"
        '
        'Ejercicio24ToolStripMenuItem
        '
        Me.Ejercicio24ToolStripMenuItem.Name = "Ejercicio24ToolStripMenuItem"
        Me.Ejercicio24ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.Ejercicio24ToolStripMenuItem.Text = "Ejercicio 24"
        '
        'Ejercicio25ToolStripMenuItem
        '
        Me.Ejercicio25ToolStripMenuItem.Name = "Ejercicio25ToolStripMenuItem"
        Me.Ejercicio25ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.Ejercicio25ToolStripMenuItem.Text = "Ejercicio 25"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ejercicios_Unad.My.Resources.Resources.Logo_unad
        Me.PictureBox1.Location = New System.Drawing.Point(290, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 153)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 339)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Tema1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio16ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tema3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio24ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio25ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
End Class
