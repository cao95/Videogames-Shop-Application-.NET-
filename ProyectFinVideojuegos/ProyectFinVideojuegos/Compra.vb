Public Class Compra
    Public precioTotal As Double
    Dim i As Integer
    Private Sub Compra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AñadirLista()
        lsbVideojuegos.SelectedIndex = 0
        lsbListaCompra.SelectedIndex = -1

    End Sub

    Private Sub AñadirLista()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT TITULO, ID_USUARIO FROM VIDEOJUEGOS WHERE ID_USUARIO IS NULL"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                lsbVideojuegos.Items.Add(dr("TITULO"))
            End While
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo")
            Me.Close()
        End Try
    End Sub

    Private Sub lsbVideojuegos_DoubleClick(sender As Object, e As System.EventArgs) Handles lsbVideojuegos.DoubleClick
        derecha()
    End Sub
    Private Sub lsbVideojuegos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbVideojuegos.SelectedIndexChanged
        MuestraDatos()
        ElegirImagen()

    End Sub

    Private Sub ElegirImagen()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * FROM VIDEOJUEGOS WHERE TITULO LIKE '" & lsbVideojuegos.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                pcbVideojuegos.Image = System.Drawing.Image.FromFile(Application.StartupPath & dr("Imagen"))


            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub MuestraDatos()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT NOMBRE, PAIS, AÑO, GENERO, VALORACION, DURACION, PRECIO FROM PRODUCTORAS P, VIDEOJUEGOS V WHERE P.ID_PRODUCTORA = V.ID_PRODUCTORA AND TITULO ='" & lsbVideojuegos.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                txtNombreProductora.Text = dr("NOMBRE")
                txtPaisProductora.Text = dr("PAIS")
                txtAñoVideojuego.Text = dr("AÑO")
                txtGeneroVideojuego.Text = dr("GENERO")
                txtValoracionVideojuego.Text = dr("VALORACION")
                txtDuracionVideojuego.Text = dr("DURACION")
                txtPreciojuego.Text = dr("PRECIO") + "€"

            End While
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        SumaJuego()
        txtPrecioTotal.Text = precioTotal & "€"
        derecha()

    End Sub

    Private Sub SumaJuego()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT TITULO, PRECIO FROM  VIDEOJUEGOS WHERE TITULO LIKE '" & lsbVideojuegos.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                precioTotal = precioTotal + dr("PRECIO")

            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub RestaJuego()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT TITULO, PRECIO FROM  VIDEOJUEGOS WHERE TITULO LIKE '" & lsbListaCompra.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                precioTotal = precioTotal - dr("PRECIO")

            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub derecha()
        If lsbVideojuegos.SelectedIndex <> -1 Then
            If lsbListaCompra.Items.Count < 7 Then
                lsbListaCompra.Items.Add(lsbVideojuegos.SelectedItem)
                lsbVideojuegos.Items.RemoveAt(lsbVideojuegos.SelectedIndex)
                ElegirImagen()
                lsbListaCompra.SelectedIndices.Add(lsbListaCompra.Items.Count - 1)
                For i = 0 To lsbListaCompra.Items.Count - 1

                    lsbListaCompra.SelectedIndices.Add(i)
                Next
            Else
                MsgBox("NO PUEDES DEJAR EL CATALOGO VACIO, EGOISTA!")
            End If
        End If
    End Sub
    Private Sub izquierda()
        If lsbListaCompra.SelectedIndex <> -1 Then
            lsbVideojuegos.Items.Add(lsbListaCompra.SelectedItem)
            lsbListaCompra.Items.RemoveAt(lsbListaCompra.SelectedIndex)
            ElegirImagen()
        End If
    End Sub

    Private Sub btnDeshacer_Click(sender As System.Object, e As System.EventArgs) Handles btnDeshacer.Click
        RestaJuego()
        txtPrecioTotal.Text = precioTotal & "€"
        izquierda()
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click

        lsbListaCompra.Items.Clear()
        izquierda()
    End Sub

    Private Sub btnComprar_Click(sender As System.Object, e As System.EventArgs) Handles btnComprar.Click
        MeteUsuario()
        ' Dim ofrmFactura As New FacturaFinal()
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        FacturaFinal.ShowDialog()

    End Sub
    Public Sub MeteUsuario()
        Try
            Dim i As Integer

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")

            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            For Each videojuego In lsbListaCompra.SelectedItems
                cmd.CommandText = "UPDATE VIDEOJUEGOS SET ID_USUARIO = '" & Inicio_Sesión.ID & "' WHERE TITULO LIKE '" & videojuego & "'"
                cmd.ExecuteNonQuery()
            Next
            
       
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()

        End Try
    End Sub


    Private Sub lsbListaCompra_DoubleClick(sender As Object, e As System.EventArgs) Handles lsbListaCompra.DoubleClick
        izquierda()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class