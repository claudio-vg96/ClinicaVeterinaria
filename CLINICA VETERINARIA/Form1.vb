﻿Option Explicit Off
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
            ID = TXT_ID.Text.PadRight(5)
            NOMBRE = TXT_NOMBRE.Text.PadRight(40)
            PRECIO = TXT_PRECIO.Text.PadRight(7)
            REAL = NUM_STOCK_REAL.Value.ToString.PadRight(3)
            CRITICO = NUM_STOCK_CRITICO.Value.ToString.PadRight(3)
            LST_PRODUCTOS.Items.Add(ID & " " & NOMBRE & " " & PRECIO & " " & REAL & " " & CRITICO)
            BTN_ACEPTAR.Text = "&ACEPTAR"
            TXT_NOMBRE.Text() = ""
            TXT_PRECIO.Text = ""
            NUM_STOCK_REAL.Value = 0
            NUM_STOCK_CRITICO.Value = 0
            TXT_ID.Enabled = True
            TXT_NOMBRE.Enabled = False
            TXT_PRECIO.Enabled = False
            NUM_STOCK_REAL.Enabled = False
            NUM_STOCK_CRITICO.Enabled = False
            TXT_ID.SelectAll()
            TXT_ID.Focus()

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

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged
    End Sub

    Private Sub TXT_NOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress
    End Sub

    Private Sub TXT_PRECIO_TextChanged(sender As Object, e As EventArgs) Handles TXT_PRECIO.TextChanged

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
        'TXT_ID.Text = LST_PRODUCTOS.Items()
        MsgBox(LST_PRODUCTOS.Items(0)(0))
    End Sub
End Class