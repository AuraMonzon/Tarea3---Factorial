<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.TextBoxIngreso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultadoFactorial = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(83, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C Á L C U L O   D E   F A C T O R I A L"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese un número:"
        '
        'Calcular
        '
        Me.Calcular.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Calcular.Location = New System.Drawing.Point(70, 223)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 2
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'TextBoxIngreso
        '
        Me.TextBoxIngreso.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxIngreso.Location = New System.Drawing.Point(56, 160)
        Me.TextBoxIngreso.Name = "TextBoxIngreso"
        Me.TextBoxIngreso.Size = New System.Drawing.Size(110, 23)
        Me.TextBoxIngreso.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(269, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "El factorial del número es:"
        '
        'resultadoFactorial
        '
        Me.resultadoFactorial.AutoSize = True
        Me.resultadoFactorial.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.resultadoFactorial.ForeColor = System.Drawing.Color.Red
        Me.resultadoFactorial.Location = New System.Drawing.Point(339, 178)
        Me.resultadoFactorial.Name = "resultadoFactorial"
        Me.resultadoFactorial.Size = New System.Drawing.Size(0, 25)
        Me.resultadoFactorial.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label4.Location = New System.Drawing.Point(284, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Aura Guadalupe Monzón Duarte (201503965)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(523, 297)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resultadoFactorial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxIngreso)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Factorial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents TextBoxIngreso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents resultadoFactorial As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
End Class
