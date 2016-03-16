Public Class Tienda

    Private Sub RegistroMenu_Click(sender As System.Object, e As System.EventArgs) Handles RegistroMenu.Click
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        ' Registro.MdiParent = Me
        Registro.ShowDialog()
        lblInstruccionuno.Hide()
    End Sub

    Private Sub InicioSesionMenu_Click(sender As System.Object, e As System.EventArgs) Handles InicioSesionMenu.Click
        'Dim ofrmSesion As New Inicio_Sesión()
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        'ofrmSesion.MdiParent = Me
        lblInstruccionuno.Hide()
        Inicio_Sesión.ShowDialog()

    End Sub

    Private Sub CompraMenu_Click(sender As System.Object, e As System.EventArgs) Handles CompraMenu.Click
        ' Dim ofrmCompra As New Compra()
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        ' ofrmCompra.MdiParent = Me
        Compra.ShowDialog()

    End Sub

    Private Sub AlquilerMenu_Click(sender As System.Object, e As System.EventArgs) Handles AlquilerMenu.Click
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        ' Alquiler.MdiParent = Me
        Alquiler.ShowDialog()

    End Sub

    Private Sub AñadirMenu_Click(sender As System.Object, e As System.EventArgs) Handles AñadirMenu.Click
        'Dim ofrmAñadir As New Añadir()
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual
        'ofrmAñadir.MdiParent = Me
        Añadir.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' con la siguiente línea conseguimos que el
        ' formulario se comporte como hijo del actual

        VerificarSalida.ShowDialog()

    End Sub

    Private Sub Tienda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AñadirMenu.Enabled = False
        AlquilerMenu.Enabled = False
        CompraMenu.Enabled = False
        CatalogoMenu.Enabled = False
        CerrarSesiónToolStripMenuItem.Enabled = False

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim opc As DialogResult = MsgBox("¿Esta seguro de que desea salir de verdad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Esta saliendo")

        If opc = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Dim ofrmTienda As New Tienda()
            ' con la siguiente línea conseguimos que el
            ' formulario se comporte como hijo del actual

            ofrmTienda.ShowDialog()
        End If
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Alquiler.Close()
        Añadir.Close()
        Compra.Close()
        FacturaFinal.Close()
        RegistroMenu.Enabled = True
        InicioSesionMenu.Enabled = True
        CerrarSesiónToolStripMenuItem.Enabled = False
    End Sub
End Class
