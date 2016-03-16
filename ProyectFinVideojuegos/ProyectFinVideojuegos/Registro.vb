Public Class Registro

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text.Equals("") Or txtNick.Text.Equals("") Or txtDireccion.Text.Equals("") Or Val(txtTelefono.Text).Equals("") Or txtContraseña.Text.Equals("") Then
            MsgBox("Ha dejado campos vacios, rellene todos si desea continuar")
        Else
            RegistrarUsuario()
            btnRegistrar.Enabled = False
            MsgBox("El usuario ha sido registrado con éxito, ahora inicie sesión")
            Me.Hide()
            Tienda.InicioSesionMenu.Enabled = True
            Tienda.RegistroMenu.Enabled = False

        End If

    End Sub
    Private Sub RegistrarUsuario()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO USUARIOS (NOMBRE, NICK, DIRECCION, TELEFONO, CONTRASEÑA) VALUES ('" & txtNombre.Text & "','" & txtNick.Text & "','" & txtDireccion.Text & "','" & Val(txtTelefono.Text) & "','" & txtContraseña.Text & "')"
            cmd.ExecuteNonQuery()


            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub ComprobarUsuario()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT NICK, CONTRASEÑA FROM USUARIOS WHERE NICK = '" & txtNombre.Text & "' AND CONTRASEÑA = '" & txtContraseña.Text & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If (dr.Read) Then
            Else
                MsgBox("Introduce tu nick y contraseña correctamente")
                dr.Close()
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo")
            Me.Close()
        End Try
    End Sub
    Private Sub Registro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtTelefono.MaxLength = 9
        txtContraseña.Text = ""
        txtContraseña.PasswordChar = "*"
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtIdUsuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Escriba sólo números")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("No puedes tener un nombre con números")
        End If
    End Sub
End Class