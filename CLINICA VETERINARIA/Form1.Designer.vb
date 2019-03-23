<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTOS
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
        Me.LST_PRODUCTOS = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUM_STOCK_CRITICO = New System.Windows.Forms.NumericUpDown()
        Me.NUM_STOCK_REAL = New System.Windows.Forms.NumericUpDown()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.BTN_NUEVO = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_PRODUCTOS
        '
        Me.LST_PRODUCTOS.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_PRODUCTOS.FormattingEnabled = True
        Me.LST_PRODUCTOS.ItemHeight = 15
        Me.LST_PRODUCTOS.Location = New System.Drawing.Point(32, 26)
        Me.LST_PRODUCTOS.Name = "LST_PRODUCTOS"
        Me.LST_PRODUCTOS.Size = New System.Drawing.Size(764, 199)
        Me.LST_PRODUCTOS.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_CANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NUM_STOCK_CRITICO)
        Me.GroupBox1.Controls.Add(Me.NUM_STOCK_REAL)
        Me.GroupBox1.Controls.Add(Me.TXT_PRECIO)
        Me.GroupBox1.Controls.Add(Me.TXT_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.TXT_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 218)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "v"
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Enabled = False
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(567, 140)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(91, 39)
        Me.BTN_CANCELAR.TabIndex = 6
        Me.BTN_CANCELAR.Text = "&CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Enabled = False
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(440, 140)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(91, 39)
        Me.BTN_ACEPTAR.TabIndex = 5
        Me.BTN_ACEPTAR.Text = "&ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "STOCK CRITICO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "STOCK REAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'NUM_STOCK_CRITICO
        '
        Me.NUM_STOCK_CRITICO.Enabled = False
        Me.NUM_STOCK_CRITICO.Location = New System.Drawing.Point(119, 164)
        Me.NUM_STOCK_CRITICO.Name = "NUM_STOCK_CRITICO"
        Me.NUM_STOCK_CRITICO.Size = New System.Drawing.Size(74, 20)
        Me.NUM_STOCK_CRITICO.TabIndex = 4
        '
        'NUM_STOCK_REAL
        '
        Me.NUM_STOCK_REAL.Enabled = False
        Me.NUM_STOCK_REAL.Location = New System.Drawing.Point(119, 130)
        Me.NUM_STOCK_REAL.Name = "NUM_STOCK_REAL"
        Me.NUM_STOCK_REAL.Size = New System.Drawing.Size(74, 20)
        Me.NUM_STOCK_REAL.TabIndex = 3
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Enabled = False
        Me.TXT_PRECIO.Location = New System.Drawing.Point(119, 94)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PRECIO.TabIndex = 2
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Enabled = False
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(119, 59)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(278, 20)
        Me.TXT_NOMBRE.TabIndex = 1
        '
        'TXT_ID
        '
        Me.TXT_ID.Enabled = False
        Me.TXT_ID.Location = New System.Drawing.Point(119, 25)
        Me.TXT_ID.MaxLength = 5
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(74, 20)
        Me.TXT_ID.TabIndex = 0
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(63, 483)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(142, 48)
        Me.BTN_NUEVO.TabIndex = 7
        Me.BTN_NUEVO.Text = "&NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(248, 483)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(142, 48)
        Me.BTN_MODIFICAR.TabIndex = 8
        Me.BTN_MODIFICAR.Text = "&MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(432, 483)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(142, 48)
        Me.BTN_ELIMINAR.TabIndex = 9
        Me.BTN_ELIMINAR.Text = "&ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(613, 483)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(142, 48)
        Me.BTN_SALIR.TabIndex = 10
        Me.BTN_SALIR.Text = "&SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'FRM_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 571)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LST_PRODUCTOS)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LST_PRODUCTOS As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_NUEVO As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NUM_STOCK_CRITICO As NumericUpDown
    Friend WithEvents NUM_STOCK_REAL As NumericUpDown
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_ACEPTAR As Button
End Class
