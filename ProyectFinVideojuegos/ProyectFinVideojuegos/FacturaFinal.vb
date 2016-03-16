Public Class FacturaFinal
    Public juegos As New ArrayList
    Private Sub FacturaFinal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pasaDato()
        lblCompra.Text = Inicio_Sesión.usu & " has comprado "
        lblPrecio.Text = Inicio_Sesión.usu & " te ha costado: " & Compra.precioTotal & "€"
        muestra()
    End Sub
    Private Sub muestra()
        Dim i As Integer
        For i = 0 To juegos.Count
            lbsListaCompra.Items.Add(juegos(i))
        Next
    End Sub


    Private Sub ElegirImagen()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\videojuegos.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * FROM VIDEOJUEGOS WHERE TITULO LIKE '" & lbsListaCompra.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                pcbImagenFactura.Image = System.Drawing.Image.FromFile(Application.StartupPath & dr("Imagen"))

            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub pasaDato()
        Dim i As Integer
        For i = 0 To Compra.lsbListaCompra.Items.Count - 1
            juegos.Add(Compra.lsbListaCompra.Items(i).ToString)
        Next
    End Sub
    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub lbsListaCompra_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbsListaCompra.SelectedIndexChanged
        ElegirImagen()
    End Sub
End Class