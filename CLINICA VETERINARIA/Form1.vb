Option Explicit Off
Public Class FRM_PRODUCTOS
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        TXT_ID.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_PRECIO.Text = ""
        NUM_STOCK_REAL.Value = 0
        NUM_STOCK_CRITICO.Value = 0
        TXT_ID.Enabled = True
        TXT_ID.Focus()
        BTN_NUEVO.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_CANCELAR.Enabled = True
        Me.Text = "NUEVO PRODUCTO"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TXT_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID.TextChanged
        If TXT_ID.Text = "" Then
            BTN_ACEPTAR.Enabled = False
        Else
            BTN_ACEPTAR.Enabled = True
        End If
    End Sub

    Private Sub TXT_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ID.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        'AQUI SE DEBE HACER LA VALIDACION
        If BTN_ACEPTAR.Text = "&ACEPTAR" Then
            For Contador = 0 To LST_PRODUCTOS.Items.Count() - 1
                Item = LST_PRODUCTOS.Items.Item(Contador)
                ID = Trim(Item.ToString.Substring(0, 5))
                If ID = TXT_ID.Text Then
                    Existe = True
                    Exit For
                End If
            Next
            If Existe Then
                MsgBox("Error, Ya existe el producto.")
                TXT_ID.SelectAll()
                TXT_ID.Focus()
                Exit Sub
            End If

            BTN_ACEPTAR.Text = "&GUARDAR"
            TXT_ID.Enabled = False
            TXT_NOMBRE.Enabled = True
            TXT_PRECIO.Enabled = True
            NUM_STOCK_REAL.Enabled = True
            NUM_STOCK_CRITICO.Enabled = True
            BTN_CANCELAR.Enabled = True
            TXT_NOMBRE.Focus()
        Else
            If Trim(TXT_NOMBRE.Text) = "" Then
                MsgBox("Error, debe ingresar el nombre del producto")
                TXT_NOMBRE.SelectAll()
                TXT_NOMBRE.Focus()
                Exit Sub
            End If
            If Me.Text = "NUEVO PRODUCTO" Then
                LST_PRODUCTOS.Items.Add(FormatoItem(TXT_ID.Text, TXT_NOMBRE.Text, TXT_PRECIO.Text, NUM_STOCK_REAL.Value, NUM_STOCK_CRITICO.Value))
                BTN_ACEPTAR.Text = "&ACEPTAR"
                TXT_NOMBRE.Text = ""
                TXT_PRECIO.Text = ""
                NUM_STOCK_REAL.Value = 0
                NUM_STOCK_CRITICO.Value = 0
                TXT_ID.Enabled = True
                TXT_NOMBRE.Enabled = False
                TXT_PRECIO.Enabled = False
                NUM_STOCK_REAL.Enabled = False
                NUM_STOCK_CRITICO.Enabled = False
                TXT_ID.SelectAll()
                Me.AcceptButton = BTN_ACEPTAR
                TXT_ID.Focus()
            Else
                LST_PRODUCTOS.Items.Item(LST_PRODUCTOS.SelectedIndex) = FormatoItem(TXT_ID.Text, TXT_NOMBRE.Text, TXT_PRECIO.Text, NUM_STOCK_REAL.Value, NUM_STOCK_CRITICO.Value)
                TXT_NOMBRE.Focus()
            End If
        End If
    End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        Me.Text = "Mantenedor de Productos"
        TXT_ID.Enabled = False
        TXT_ID.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_PRECIO.Text = ""
        NUM_STOCK_REAL.Value = 0
        NUM_STOCK_CRITICO.Value = 0
        TXT_ID.Enabled = False
        TXT_NOMBRE.Enabled = False
        TXT_PRECIO.Enabled = False
        NUM_STOCK_REAL.Enabled = False
        NUM_STOCK_CRITICO.Enabled = False
        BTN_NUEVO.Enabled = True
        BTN_MODIFICAR.Enabled = True
        BTN_ELIMINAR.Enabled = True
        BTN_ACEPTAR.Enabled = False
        BTN_CANCELAR.Enabled = False
        BTN_ACEPTAR.Text = "&ACEPTAR"
        BTN_NUEVO.Focus()
    End Sub

    Private Sub TXT_PRECIO_LostFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.LostFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "Currency")
    End Sub

    Private Sub TXT_PRECIO_GotFocus(sender As Object, e As EventArgs) Handles TXT_PRECIO.GotFocus
        TXT_PRECIO.Text = Format(TXT_PRECIO.Text, "General Number")
    End Sub

    Private Sub TXT_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub LST_PRODUCTOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_PRODUCTOS.SelectedIndexChanged
        If (LST_PRODUCTOS.SelectedIndex >= 0) Then
            PictureBox1.Enabled = True
            Item = LST_PRODUCTOS.SelectedItem
            Campos = ExtraerDatos(Item)
            TXT_ID.Text = Campos(0)
            TXT_NOMBRE.Text = Campos(1)
            TXT_PRECIO.Text = Campos(2)
            NUM_STOCK_REAL.Value = Campos(3)
            NUM_STOCK_CRITICO.Value = Campos(4)
            If My.Computer.FileSystem.FileExists("D: \ClinicaVeterinaria-master\images\" + TXT_ID.Text) Then
                PictureBox1.Image = Image.FromFile("D: \ClinicaVeterinaria-master\images\" + TXT_ID.Text)
            End If
        End If
    End Sub

    Private Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
        If TXT_ID.Text = " " Then
            MsgBox("Error, debe seleccionar un elemento del listado.")
            LST_PRODUCTOS.Focus()
            Exit Sub
        End If
        Me.Text = "Modificar Producto"
        TXT_ID.Enabled = False
        TXT_NOMBRE.Enabled = True
        TXT_PRECIO.Enabled = True
        BTN_ACEPTAR.Enabled = True
        BTN_CANCELAR.Enabled = True
        NUM_STOCK_REAL.Enabled = True
        NUM_STOCK_CRITICO.Enabled = True
        TXT_NOMBRE.SelectAll()
        TXT_NOMBRE.Focus()
        BTN_NUEVO.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_ACEPTAR.Text = "&GUARDAR"
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        If LST_PRODUCTOS.SelectedIndex > -1 Then
            resultado = MsgBox("¿Esta seguro que desea eliminar?", vbOKCancel, "CONFIRMACION")
            If resultado = vbOK Then
                LST_PRODUCTOS.Items.RemoveAt(LST_PRODUCTOS.SelectedIndex)
            Else
                MsgBox("HE PULSADO BOTON CANCELAR")
                Exit Sub
            End If
        End If
    End Sub

    Private Function Centrar(Texto, Numero)
        Espacios = Space(Math.Truncate(Numero - Len(Texto)) / 2)
        Valor = Espacios & Texto & Espacios
        Return Valor
    End Function

    Private Sub FRM_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LST_PRODUCTOS.Items.Add("          1         2         3         4         5         6         7     ")
        'LST_PRODUCTOS.Items.Add("01234567890123456789012345678901234567890123456789012345678901234567890123456789")
        Dim ARCHIVO As New System.IO.StreamReader("PRODUCTOS.TXT")
        Dim REGISTRO As String
        Dim ELEMENTO() As String
        REGISTRO = ARCHIVO.ReadLine()
        While REGISTRO <> ""
            ELEMENTO = REGISTRO.Split(";")
            LST_PRODUCTOS.Items.Add(FormatoItem(ELEMENTO(0), ELEMENTO(1), ELEMENTO(2), ELEMENTO(3), ELEMENTO(4)))
            REGISTRO = ARCHIVO.ReadLine()
        End While
        ARCHIVO.Close()

    End Sub

    Private Sub LBL_ESTADO_MouseHover(sender As Object, e As EventArgs) Handles LBL_ESTADO.MouseHover, LBL_ID.MouseHover,
            LBL_NOMBRE.MouseHover, LBL_PRECIO.MouseHover, LBL_REAL.MouseHover, LBL_CRITICO.MouseHover
        Datos = sender.ToString.Split
        Select Case Datos(2)
            Case "ID"
                LBL_ESTADO.Text = "Ordenar por ID"
            Case "NOMBRE"
                LBL_ESTADO.Text = "Ordenar por nombre"
            Case "PRECIO"
                LBL_ESTADO.Text = "Ordenar por Precio"
            Case "REAL"
                LBL_ESTADO.Text = "Ordenar por Stock Real"
            Case "CRITICO"
                LBL_ESTADO.Text = "Ordenar por Stock Critico"
        End Select

    End Sub

    Private Sub LBL_ESTADO_MouseLeave(sender As Object, e As EventArgs) Handles LBL_ESTADO.MouseLeave, LBL_ID.MouseLeave,
            LBL_NOMBRE.MouseLeave, LBL_PRECIO.MouseLeave, LBL_REAL.MouseLeave, LBL_CRITICO.MouseLeave
        LBL_ESTADO.Text = ""
    End Sub

    Private Function FormatoItem(ID, NOMBRE, PRECIO, REAL, CRITICO)
        ID = ID.PadRight(5)
        NOMBRE = NOMBRE.PadRight(40)
        PRECIO = Format(PRECIO, "CURRENCY").PadLeft(10)
        REAL = Centrar(REAL.ToString.PadRight(3), 9)
        CRITICO = Centrar(CRITICO.ToString.PadRight(3), 8)
        Return ID & " " & NOMBRE & " " & PRECIO & " " & REAL & " " & CRITICO
    End Function

    Private Function ExtraerDatos(Item)
        If (Item <> "") Then
            Dim Campos(5)
            Campos(0) = Trim(Item.ToString.Substring(0, 5))
            Campos(1) = Trim(Item.ToString.Substring(6, 40))
            Campos(2) = Trim(Item.ToString.Substring(47, 10))
            Campos(3) = Trim(Item.ToString.Substring(58, 9))
            Campos(4) = Trim(Item.ToString.Substring(66, 9))
            Return Campos
        End If

    End Function

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub LBL_NOMBRE_Click(sender As Object, e As EventArgs) Handles LBL_NOMBRE.Click

    End Sub

    Private Sub LBL_CRITICO_Click(sender As Object, e As EventArgs) Handles LBL_CRITICO.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo PNG|*.png"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
            My.Computer.FileSystem.CopyFile(file.FileName, "D:\ClinicaVeterinaria-master\images\" + TXT_ID.Text)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_2(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then 'FILTRO
            CheckBox1.Image = Image.FromFile("C:\Users\Claudio Villarroel G\Desktop\Clinica\ClinicaVeterinaria-master\images\embudo1.png")
        Else 'BUSQUEDA
            CheckBox1.Image = Image.FromFile("C:\Users\Claudio Villarroel G\Desktop\Clinica\ClinicaVeterinaria-master\images\binoculares1.png")
        End If
        ''LST_PRODUCTOS_AUX.Location = New System.Drawing.Point(10, 10)

    End Sub

    Private Sub LST_PRODUCTOS_AUX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_PRODUCTOS_AUX.SelectedIndexChanged
        If (LST_PRODUCTOS_AUX.SelectedIndex >= 0) Then
            PictureBox1.Enabled = True
            Item = LST_PRODUCTOS_AUX.SelectedItem
            Campos = ExtraerDatos(Item)
            TXT_ID.Text = Campos(0)
            TXT_NOMBRE.Text = Campos(1)
            TXT_PRECIO.Text = Campos(2)
            NUM_STOCK_REAL.Value = Campos(3)
            NUM_STOCK_CRITICO.Value = Campos(4)
            If My.Computer.FileSystem.FileExists("D: \ClinicaVeterinaria-master\images\" + TXT_ID.Text) Then
                PictureBox1.Image = Image.FromFile("D: \ClinicaVeterinaria-master\images\" + TXT_ID.Text)
            End If
        End If

    End Sub

    Private Sub TXT_ID_AUX_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID_AUX.TextChanged
        If CheckBox1.Checked Then 'FILTRO
            If CheckBox2.Checked Then 'CONTENIDO
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_ID_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroContenido(LST_PRODUCTOS, TXT_ID_AUX.Text, LST_PRODUCTOS_AUX, 1)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            Else 'COINCIDENCIA
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_ID_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroCoincidencia(LST_PRODUCTOS, TXT_ID_AUX.Text, LST_PRODUCTOS_AUX, 1)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            End If
        Else 'BUSQUEDA 
            INDEX = 0
            If CheckBox2.Checked Then 'CONTENIDO
                For Each item As String In LST_PRODUCTOS.Items
                    If Trim(item.Substring(0, 5)).Contains(TXT_ID_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            Else 'COINCIDENCIA
                For Each item As String In LST_PRODUCTOS.Items
                    If Trim(item.Substring(0, Len(TXT_ID_AUX.Text))).Equals(TXT_ID_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            End If
        End If
    End Sub

    Private Function FiltroContenido(lista_original As ListBox, texto As String, lista_copia As ListBox, NUM As Integer)
        For Each item As String In lista_original.Items
            If NUM = 1 Then
                If item.Substring(0, 5).Contains(texto) Then 'ID
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 2 Then
                If item.Substring(6, 40).Contains(texto) Then 'NOMBRE
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 3 Then
                If item.Substring(47, 10).Contains(texto) Then 'PRECIO
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 4 Then
                If item.Substring(58, 9).Contains(texto) Then 'STOCK_REAL
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 5 Then
                If item.Substring(66, 9).Contains(texto) Then 'STOCK_CRITICO
                    lista_copia.Items.Add(item)
                End If
            End If
        Next
        Return lista_copia
    End Function

    Private Function FiltroCoincidencia(lista_original As ListBox, texto As String, lista_copia As ListBox, NUM As Integer)
        AUX = 0
        For Each item As String In lista_original.Items
            If NUM = 1 Then
                If Trim(item.Substring(0, Len(texto))).Equals(texto) Then 'ID
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 2 Then

                If Trim(item.Substring(6, Len(texto))).Equals(texto) Then 'NOMBRE
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 3 Then
                campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(AUX))
                campos(2) = campos(2).replace(".", "")
                campos(2) = campos(2).replace("$", "")
                If campos(2).ToString.Substring(0, Len(texto)).Equals(texto) Then 'PRECIO
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 4 Then
                campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(AUX))
                If campos(3).ToString.Substring(0, Len(texto)).Equals(texto) Then 'STOCK_REAL
                    lista_copia.Items.Add(item)
                End If
            ElseIf NUM = 5 Then
                campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(AUX))
                If campos(4).ToString.Substring(0, Len(texto)).Equals(texto) Then 'STOCK_CRITICO
                    lista_copia.Items.Add(item)
                End If
            End If
            AUX = AUX + 1
        Next
        Return lista_copia
    End Function

    Private Sub TXT_NOMBRE_AUX_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE_AUX.TextChanged
        If CheckBox1.Checked Then 'FILTRO
            If CheckBox2.Checked Then 'CONTENIDO
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_NOMBRE_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroContenido(LST_PRODUCTOS, TXT_NOMBRE_AUX.Text, LST_PRODUCTOS_AUX, 2)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            Else 'COINCIDENCIA
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_NOMBRE_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroCoincidencia(LST_PRODUCTOS, TXT_NOMBRE_AUX.Text, LST_PRODUCTOS_AUX, 2)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            End If
        Else 'BUSQUEDA 
            INDEX = 0
            If CheckBox2.Checked Then 'CONTENIDO
                For Each item As String In LST_PRODUCTOS.Items
                    If Trim(item.Substring(6, 40)).Contains(TXT_NOMBRE_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            Else 'COINCIDENCIA
                For Each item As String In LST_PRODUCTOS.Items
                    If item.Substring(6, Len(TXT_NOMBRE_AUX.Text)).Equals(TXT_NOMBRE_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            End If
        End If
    End Sub

    Private Sub TXT_PRECIO_AUX_TextChanged(sender As Object, e As EventArgs) Handles TXT_PRECIO_AUX.TextChanged
        If CheckBox1.Checked Then 'FILTRO
            If CheckBox2.Checked Then 'CONTENIDO
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_PRECIO_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroContenido(LST_PRODUCTOS, TXT_PRECIO_AUX.Text, LST_PRODUCTOS_AUX, 3)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            Else 'COINCIDENCIA
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_PRECIO_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroCoincidencia(LST_PRODUCTOS, TXT_PRECIO_AUX.Text, LST_PRODUCTOS_AUX, 3)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            End If
        Else 'BUSQUEDA 
            INDEX = 0
            str1 = ""
            If CheckBox2.Checked Then 'CONTENIDO
                For Each item As String In LST_PRODUCTOS.Items
                    campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(INDEX))
                    campos(2) = campos(2).replace(".", "")
                    campos(2) = campos(2).replace("$", "")
                    If campos(2).Contains(TXT_PRECIO_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            Else 'COINCIDENCIA
                For Each item As String In LST_PRODUCTOS.Items
                    campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(INDEX))
                    campos(2) = campos(2).replace(".", "")
                    If campos(2).ToString.Substring(1, Len(TXT_PRECIO_AUX.Text)).Equals(TXT_PRECIO_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            End If
        End If
    End Sub

    Private Sub TXT_REAL_AUX_TextChanged(sender As Object, e As EventArgs) Handles TXT_REAL_AUX.TextChanged
        If CheckBox1.Checked Then 'FILTRO
            If CheckBox2.Checked Then 'CONTENIDO
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_REAL_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroContenido(LST_PRODUCTOS, TXT_REAL_AUX.Text, LST_PRODUCTOS_AUX, 4)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            Else 'COINCIDENCIA
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_REAL_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroCoincidencia(LST_PRODUCTOS, TXT_REAL_AUX.Text, LST_PRODUCTOS_AUX, 4)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            End If
        Else 'BUSQUEDA 
            INDEX = 0
            If CheckBox2.Checked Then 'CONTENIDO
                For Each item As String In LST_PRODUCTOS.Items
                    If Trim(item.Substring(58, 9)).Contains(TXT_REAL_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            Else 'COINCIDENCIA
                For Each item As String In LST_PRODUCTOS.Items
                    campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(INDEX))
                    If campos(3).ToString.Substring(0, Len(TXT_REAL_AUX.Text)).Equals(TXT_REAL_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            End If
        End If
    End Sub

    Private Sub TXT_CRITICO_AUX_TextChanged(sender As Object, e As EventArgs) Handles TXT_CRITICO_AUX.TextChanged
        If CheckBox1.Checked Then 'FILTRO
            If CheckBox2.Checked Then 'CONTENIDO
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_CRITICO_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroContenido(LST_PRODUCTOS, TXT_CRITICO_AUX.Text, LST_PRODUCTOS_AUX, 5)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            Else 'COINCIDENCIA
                LST_PRODUCTOS_AUX.Items.Clear()
                If TXT_CRITICO_AUX.Text = "" Then
                    LST_PRODUCTOS_AUX.Visible = False
                Else
                    FiltroCoincidencia(LST_PRODUCTOS, TXT_CRITICO_AUX.Text, LST_PRODUCTOS_AUX, 5)
                    LST_PRODUCTOS_AUX.Visible = True
                End If
            End If
        Else 'BUSQUEDA 
            INDEX = 0
            If CheckBox2.Checked Then 'CONTENIDO
                For Each item As String In LST_PRODUCTOS.Items
                    If Trim(item.Substring(66, 9)).Contains(TXT_CRITICO_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            Else 'COINCIDENCIA
                For Each item As String In LST_PRODUCTOS.Items
                    campos = ExtraerDatos(LST_PRODUCTOS.Items.Item(INDEX))
                    If campos(4).ToString.Substring(0, Len(TXT_CRITICO_AUX.Text)).Equals(TXT_CRITICO_AUX.Text) Then
                        If INDEX <> -1 Then
                            LST_PRODUCTOS.SelectedIndex = INDEX
                            Exit Sub
                        End If
                    End If
                    INDEX = INDEX + 1
                Next
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then 'CONTENIDO
            CheckBox2.Image = Image.FromFile("C:\Users\Claudio Villarroel G\Desktop\Clinica\ClinicaVeterinaria-master\images\contenido1.png")
        Else 'COINCIDENCIA
            CheckBox2.Image = Image.FromFile("C:\Users\Claudio Villarroel G\Desktop\Clinica\ClinicaVeterinaria-master\images\coincidencia1.png")
        End If
    End Sub
End Class