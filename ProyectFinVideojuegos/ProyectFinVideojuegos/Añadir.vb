Imports System.IO

Public Class Añadir
    Dim idproductor As Integer
    Dim nombreFoto As String

    Private Sub Añadir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ElegirIDProductor()
        btnRegistrarProductora.Enabled = False
        btnRegistrarVideojuego.Enabled = False
        txtAño.MaxLength = 4
        txtValoracion.MaxLength = 2
        txtDuracion.MaxLength = 3
        txtFundacion.MaxLength = 3
    End Sub
    Private Sub activarRegistroVideojuego()
        If (cmbIdProductora.SelectedIndex > -1 And txtTitulo.Text.Count > 0 And txtGenero.Text.Count > 0 And txtValoracion.Text.Count > 0 And txtDuracion.Text.Count > 0 And txtAño.Text.Count > 0) Then
            btnRegistrarVideojuego.Enabled = True
        Else
            btnRegistrarVideojuego.Enabled = False
        End If
    End Sub

    Private Sub activarRegistroProductora()
        If (txtNombreProductora.Text.Count > 0 And txtPais.Text.Count > 0 And txtFundacion.Text.Count > 0) Then
            btnRegistrarProductora.Enabled = True
        Else
            btnRegistrarProductora.Enabled = False
        End If
    End Sub

    Private Sub RegistrarVideojuego()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()
            PasarIDProductor()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO VIDEOJUEGOS (TITULO, GENERO, VALORACION, DURACION, AÑO, ID_PRODUCTORA, IMAGEN) VALUES ('" & txtTitulo.Text & "','" & txtGenero.Text & "','" & Val(txtValoracion.Text) & "','" & Val(txtDuracion.Text) & "','" & Val(txtAño.Text) & "','" & idproductor & "','" & nombreFoto & "')"
            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub RegistrarProductora()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO PRODUCTORAS (NOMBRE, PAIS, AÑOFUNDACION) VALUES ('" & txtNombreProductora.Text & "','" & txtPais.Text & "','" & Val(txtFundacion.Text) & "')"
            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub btnRegistrarVideojuego_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarVideojuego.Click
        RegistrarVideojuego()
        txtAño.Text = ""
        txtTitulo.Text = ""
        txtGenero.Text = ""
        txtValoracion.Text = ""
        txtDuracion.Text = ""
        MsgBox("Añadido")
    End Sub

    Private Sub btnRegistrarProductora_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarProductora.Click
        RegistrarProductora()
        ElegirIDProductor()

        txtNombreProductora.Text = ""
        txtPais.Text = ""
        txtFundacion.Text = ""
        MsgBox("Añadido")
    End Sub

    Private Sub txtGenero_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtGenero.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("No hay generos con numeros")
        End If
    End Sub

    Private Sub txtValoracion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValoracion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Escriba sólo números")
        End If
    End Sub

    Private Sub txtDuracion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Escriba sólo números")
        End If
    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAño.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Escriba sólo números")
        End If
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As System.EventArgs) Handles txtTitulo.TextChanged, txtGenero.TextChanged, txtDuracion.TextChanged, txtValoracion.TextChanged, txtAño.TextChanged
        activarRegistroVideojuego()
    End Sub
    Private Sub ElegirIDProductor()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT NOMBRE FROM PRODUCTORAS"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()

                cmbIdProductora.Items.Add(dr("NOMBRE"))

            End While
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub PasarIDProductor()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * FROM PRODUCTORAS WHERE NOMBRE LIKE '" & cmbIdProductora.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                idproductor = dr("id_productora")


            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPais.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("No hay paises con numeros")
        End If
    End Sub

    Private Sub txtFundacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFundacion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Escriba sólo números")
        End If
    End Sub

    Private Sub txtNombreProductora_TextChanged(sender As Object, e As System.EventArgs) Handles txtNombreProductora.TextChanged, txtFundacion.TextChanged, txtPais.TextChanged
        activarRegistroProductora()
    End Sub

    Private Sub btnAñadirFoto_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadirFoto.Click

        Dim ruta As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Imagenes;"
        ' configurar el cuadro de diálogo por código
        Me.ofdFoto.Title = "Seleccionar archivo a leer"
        Me.ofdFoto.InitialDirectory = ruta
        Me.ofdFoto.Filter = "img files (*.jpg)|*.jpg|All files (*.*)|*.*"
        ' abrir el diálogo

        ' abrir archivo con un Stream
        ' y volcarlo al TextBox
        If ofdFoto.ShowDialog() = DialogResult.OK Then
            nombreFoto = Path.GetFileName(ofdFoto.FileName)
            pcbFotoAñade.Image = Image.FromFile(ofdFoto.FileName)
        End If
    End Sub

    Private Sub cmbIdProductora_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbIdProductora.SelectedIndexChanged
        If (cmbIdProductora.SelectedIndex > -1 And txtTitulo.Text.Count > 0 And txtGenero.Text.Count > 0 And txtValoracion.Text.Count > 0 And txtDuracion.Text.Count > 0 And txtAño.Text.Count > 0) Then
            btnRegistrarVideojuego.Enabled = True
        Else
            btnRegistrarVideojuego.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class