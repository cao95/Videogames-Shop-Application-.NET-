Public Class Inicio_Sesión
    Public usu As String
    Public ID As Integer
    Private Sub btnInicioSesion_Click(sender As System.Object, e As System.EventArgs) Handles btnInicioSesion.Click
        ComprobarUsuario()
        Tienda.CerrarSesiónToolStripMenuItem.Enabled = True
        Tienda.InicioSesionMenu.Enabled = False
    End Sub

    Private Sub ComprobarUsuario()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT NICK, CONTRASEÑA, ID_USUARIO, NOMBRE FROM USUARIOS WHERE NICK = '" & txtNombre.Text & "' AND CONTRASEÑA = '" & txtContraseña.Text & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                usu = (dr("NOMBRE"))
                ID = (dr("ID_USUARIO"))
                MsgBox("A iniciado sesión correctamente " & usu & " puedes acceder al catalogo ")
                Me.Hide()
                Tienda.CatalogoMenu.Enabled = True
                Tienda.CompraMenu.Enabled = True
                Tienda.AlquilerMenu.Enabled = True
                Tienda.AñadirMenu.Enabled = True
                Tienda.InicioSesionMenu.Enabled = False
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

    Private Sub Inicio_Sesión_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtContraseña.Text = ""
        txtContraseña.PasswordChar = "*"
    End Sub
End Class