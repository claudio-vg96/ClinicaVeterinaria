<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PRODUCTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LST_PRODUCTOS = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.TXT_ID_AUX = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE_AUX = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO_AUX = New System.Windows.Forms.TextBox()
        Me.LBL_ESTADO = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.LBL_NOMBRE = New System.Windows.Forms.Label()
        Me.LBL_PRECIO = New System.Windows.Forms.Label()
        Me.LBL_REAL = New System.Windows.Forms.Label()
        Me.LBL_CRITICO = New System.Windows.Forms.Label()
        Me.TXT_CRITICO_AUX = New System.Windows.Forms.TextBox()
        Me.TXT_REAL_AUX = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LST_PRODUCTOS_AUX = New System.Windows.Forms.ListBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_PRODUCTOS
        '
        Me.LST_PRODUCTOS.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_PRODUCTOS.FormattingEnabled = True
        Me.LST_PRODUCTOS.ItemHeight = 19
        Me.LST_PRODUCTOS.Location = New System.Drawing.Point(43, 32)
        Me.LST_PRODUCTOS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LST_PRODUCTOS.Name = "LST_PRODUCTOS"
        Me.LST_PRODUCTOS.Size = New System.Drawing.Size(721, 194)
        Me.LST_PRODUCTOS.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 319)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(749, 268)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "v"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(587, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Enabled = False
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(572, 178)
        Me.BTN_CANCELAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(121, 48)
        Me.BTN_CANCELAR.TabIndex = 6
        Me.BTN_CANCELAR.Text = "&CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Enabled = False
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(432, 178)
        Me.BTN_ACEPTAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(121, 48)
        Me.BTN_ACEPTAR.TabIndex = 5
        Me.BTN_ACEPTAR.Text = "&ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "STOCK CRITICO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "STOCK REAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOMBRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'NUM_STOCK_CRITICO
        '
        Me.NUM_STOCK_CRITICO.Enabled = False
        Me.NUM_STOCK_CRITICO.Location = New System.Drawing.Point(159, 202)
        Me.NUM_STOCK_CRITICO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NUM_STOCK_CRITICO.Name = "NUM_STOCK_CRITICO"
        Me.NUM_STOCK_CRITICO.Size = New System.Drawing.Size(99, 22)
        Me.NUM_STOCK_CRITICO.TabIndex = 4
        '
        'NUM_STOCK_REAL
        '
        Me.NUM_STOCK_REAL.Enabled = False
        Me.NUM_STOCK_REAL.Location = New System.Drawing.Point(159, 160)
        Me.NUM_STOCK_REAL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NUM_STOCK_REAL.Name = "NUM_STOCK_REAL"
        Me.NUM_STOCK_REAL.Size = New System.Drawing.Size(99, 22)
        Me.NUM_STOCK_REAL.TabIndex = 3
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Enabled = False
        Me.TXT_PRECIO.Location = New System.Drawing.Point(159, 116)
        Me.TXT_PRECIO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_PRECIO.MaxLength = 9
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(132, 22)
        Me.TXT_PRECIO.TabIndex = 2
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Enabled = False
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(159, 73)
        Me.TXT_NOMBRE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_NOMBRE.MaxLength = 40
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(369, 22)
        Me.TXT_NOMBRE.TabIndex = 1
        '
        'TXT_ID
        '
        Me.TXT_ID.Enabled = False
        Me.TXT_ID.Location = New System.Drawing.Point(159, 31)
        Me.TXT_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_ID.MaxLength = 5
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(97, 22)
        Me.TXT_ID.TabIndex = 0
        '
        'BTN_NUEVO
        '
        Me.BTN_NUEVO.Location = New System.Drawing.Point(43, 594)
        Me.BTN_NUEVO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_NUEVO.Name = "BTN_NUEVO"
        Me.BTN_NUEVO.Size = New System.Drawing.Size(173, 59)
        Me.BTN_NUEVO.TabIndex = 7
        Me.BTN_NUEVO.Text = "&NUEVO"
        Me.BTN_NUEVO.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(224, 594)
        Me.BTN_MODIFICAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(173, 59)
        Me.BTN_MODIFICAR.TabIndex = 8
        Me.BTN_MODIFICAR.Text = "&MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(405, 594)
        Me.BTN_ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(173, 59)
        Me.BTN_ELIMINAR.TabIndex = 9
        Me.BTN_ELIMINAR.Text = "&ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(581, 594)
        Me.BTN_SALIR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(173, 59)
        Me.BTN_SALIR.TabIndex = 10
        Me.BTN_SALIR.Text = "&SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'TXT_ID_AUX
        '
        Me.TXT_ID_AUX.Location = New System.Drawing.Point(43, 266)
        Me.TXT_ID_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_ID_AUX.MaxLength = 5
        Me.TXT_ID_AUX.Name = "TXT_ID_AUX"
        Me.TXT_ID_AUX.Size = New System.Drawing.Size(41, 22)
        Me.TXT_ID_AUX.TabIndex = 11
        '
        'TXT_NOMBRE_AUX
        '
        Me.TXT_NOMBRE_AUX.Location = New System.Drawing.Point(93, 266)
        Me.TXT_NOMBRE_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_NOMBRE_AUX.MaxLength = 40
        Me.TXT_NOMBRE_AUX.Name = "TXT_NOMBRE_AUX"
        Me.TXT_NOMBRE_AUX.Size = New System.Drawing.Size(381, 22)
        Me.TXT_NOMBRE_AUX.TabIndex = 12
        '
        'TXT_PRECIO_AUX
        '
        Me.TXT_PRECIO_AUX.Location = New System.Drawing.Point(488, 266)
        Me.TXT_PRECIO_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_PRECIO_AUX.MaxLength = 9
        Me.TXT_PRECIO_AUX.Name = "TXT_PRECIO_AUX"
        Me.TXT_PRECIO_AUX.Size = New System.Drawing.Size(101, 22)
        Me.TXT_PRECIO_AUX.TabIndex = 13
        '
        'LBL_ESTADO
        '
        Me.LBL_ESTADO.BackColor = System.Drawing.Color.Black
        Me.LBL_ESTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ESTADO.ForeColor = System.Drawing.Color.White
        Me.LBL_ESTADO.Location = New System.Drawing.Point(43, 672)
        Me.LBL_ESTADO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_ESTADO.Name = "LBL_ESTADO"
        Me.LBL_ESTADO.Size = New System.Drawing.Size(712, 16)
        Me.LBL_ESTADO.TabIndex = 15
        Me.LBL_ESTADO.Text = "PieFormulario"
        '
        'LBL_ID
        '
        Me.LBL_ID.BackColor = System.Drawing.SystemColors.Desktop
        Me.LBL_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ID.ForeColor = System.Drawing.Color.White
        Me.LBL_ID.Location = New System.Drawing.Point(43, 9)
        Me.LBL_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(53, 16)
        Me.LBL_ID.TabIndex = 16
        Me.LBL_ID.Text = "ID   "
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.BackColor = System.Drawing.SystemColors.Desktop
        Me.LBL_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE.ForeColor = System.Drawing.Color.White
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(104, 9)
        Me.LBL_NOMBRE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(372, 16)
        Me.LBL_NOMBRE.TabIndex = 17
        Me.LBL_NOMBRE.Text = "NOMBRE                                  "
        '
        'LBL_PRECIO
        '
        Me.LBL_PRECIO.BackColor = System.Drawing.SystemColors.Desktop
        Me.LBL_PRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PRECIO.ForeColor = System.Drawing.Color.White
        Me.LBL_PRECIO.Location = New System.Drawing.Point(484, 9)
        Me.LBL_PRECIO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_PRECIO.Name = "LBL_PRECIO"
        Me.LBL_PRECIO.Size = New System.Drawing.Size(107, 16)
        Me.LBL_PRECIO.TabIndex = 18
        Me.LBL_PRECIO.Text = "PRECIO"
        '
        'LBL_REAL
        '
        Me.LBL_REAL.BackColor = System.Drawing.SystemColors.Desktop
        Me.LBL_REAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_REAL.ForeColor = System.Drawing.Color.White
        Me.LBL_REAL.Location = New System.Drawing.Point(599, 9)
        Me.LBL_REAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_REAL.Name = "LBL_REAL"
        Me.LBL_REAL.Size = New System.Drawing.Size(72, 16)
        Me.LBL_REAL.TabIndex = 19
        Me.LBL_REAL.Text = "REAL"
        '
        'LBL_CRITICO
        '
        Me.LBL_CRITICO.BackColor = System.Drawing.SystemColors.Desktop
        Me.LBL_CRITICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CRITICO.ForeColor = System.Drawing.Color.White
        Me.LBL_CRITICO.Location = New System.Drawing.Point(679, 9)
        Me.LBL_CRITICO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_CRITICO.Name = "LBL_CRITICO"
        Me.LBL_CRITICO.Size = New System.Drawing.Size(76, 16)
        Me.LBL_CRITICO.TabIndex = 20
        Me.LBL_CRITICO.Text = "CRITICO"
        '
        'TXT_CRITICO_AUX
        '
        Me.TXT_CRITICO_AUX.Location = New System.Drawing.Point(683, 266)
        Me.TXT_CRITICO_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_CRITICO_AUX.MaxLength = 3
        Me.TXT_CRITICO_AUX.Name = "TXT_CRITICO_AUX"
        Me.TXT_CRITICO_AUX.Size = New System.Drawing.Size(71, 22)
        Me.TXT_CRITICO_AUX.TabIndex = 22
        '
        'TXT_REAL_AUX
        '
        Me.TXT_REAL_AUX.Location = New System.Drawing.Point(603, 266)
        Me.TXT_REAL_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_REAL_AUX.MaxLength = 3
        Me.TXT_REAL_AUX.Name = "TXT_REAL_AUX"
        Me.TXT_REAL_AUX.Size = New System.Drawing.Size(67, 22)
        Me.TXT_REAL_AUX.TabIndex = 23
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.Image = Global.CLINICA_VETERINARIA.My.Resources.Resources.Very_Basic_Binoculars_icon1
        Me.CheckBox1.Location = New System.Drawing.Point(773, 177)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 30)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LST_PRODUCTOS_AUX
        '
        Me.LST_PRODUCTOS_AUX.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_PRODUCTOS_AUX.FormattingEnabled = True
        Me.LST_PRODUCTOS_AUX.ItemHeight = 19
        Me.LST_PRODUCTOS_AUX.Location = New System.Drawing.Point(43, 32)
        Me.LST_PRODUCTOS_AUX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LST_PRODUCTOS_AUX.Name = "LST_PRODUCTOS_AUX"
        Me.LST_PRODUCTOS_AUX.Size = New System.Drawing.Size(721, 194)
        Me.LST_PRODUCTOS_AUX.TabIndex = 25
        Me.LST_PRODUCTOS_AUX.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.Image = Global.CLINICA_VETERINARIA.My.Resources.Resources.coincidencia1
        Me.CheckBox2.Location = New System.Drawing.Point(773, 214)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(40, 37)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FRM_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 703)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.LST_PRODUCTOS_AUX)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TXT_REAL_AUX)
        Me.Controls.Add(Me.TXT_CRITICO_AUX)
        Me.Controls.Add(Me.LBL_CRITICO)
        Me.Controls.Add(Me.LBL_REAL)
        Me.Controls.Add(Me.LBL_PRECIO)
        Me.Controls.Add(Me.LBL_NOMBRE)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.LBL_ESTADO)
        Me.Controls.Add(Me.TXT_PRECIO_AUX)
        Me.Controls.Add(Me.TXT_NOMBRE_AUX)
        Me.Controls.Add(Me.TXT_ID_AUX)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_NUEVO)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.LST_PRODUCTOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENEDOR DE PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_STOCK_CRITICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_STOCK_REAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TXT_ID_AUX As TextBox
    Friend WithEvents TXT_NOMBRE_AUX As TextBox
    Friend WithEvents TXT_PRECIO_AUX As TextBox
    Friend WithEvents LBL_ESTADO As Label
    Friend WithEvents LBL_ID As Label
    Friend WithEvents LBL_NOMBRE As Label
    Friend WithEvents LBL_PRECIO As Label
    Friend WithEvents LBL_REAL As Label
    Friend WithEvents LBL_CRITICO As Label
    Friend WithEvents TXT_CRITICO_AUX As TextBox
    Friend WithEvents TXT_REAL_AUX As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LST_PRODUCTOS_AUX As ListBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
